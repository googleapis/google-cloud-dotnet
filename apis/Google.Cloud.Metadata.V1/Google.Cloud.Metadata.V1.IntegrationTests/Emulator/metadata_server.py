# Copyright 2016 Google Inc. All Rights Reserved.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

from collections import OrderedDict
from flask import Flask, request
from oauth2client import service_account
from werkzeug.wrappers import Request
import common, errno, getopt, hashlib, json, logging, os, socket, string, sys, threading, time, urllib

class ServerState:
  _credential_scopes = ["https://www.googleapis.com/auth/cloud-platform",
                        "https://www.googleapis.com/auth/userinfo.email"]

  def __init__(self, project_id, numeric_project_id, use_default_credentials, credentials_files):
    self._lock = threading.RLock()
    self.project_id = project_id
    self.numeric_project_id = numeric_project_id
    
    self._credentials = {}
    if use_default_credentials:
      self._useDefaultCredentials()
    if credentials_files:
      self._useCredentials(credentials_files)

    self._loadData()

  def _useCredentials(self, credentials_files):
    """Adds the credentials from the specified files to the _credentials map, using the service account emails
    as the keys.

    Args:
      credentials_files: A list of credentials JSON files, separated by the OS's path separator.
    """

    for path in string.split(credentials_files, os.pathsep):
      account_credentials = service_account.ServiceAccountCredentials.from_json_keyfile_name(
        path,
        scopes = ServerState._credential_scopes)
      self._credentials[account_credentials.service_account_email] = account_credentials

  def _useDefaultCredentials(self):
    """Adds the application default credentials to the _credentials map, using 'default' as the key. """
    self._credentials[u'default'] = service_account.ServiceAccountCredentials.get_application_default()

  def _loadData(self):
    """Loads the data from the initial_data.json file (sibling to this file) into _all_data, which will be of
    type MetadataDict.
    """

    with open(os.path.join(os.path.dirname(os.path.realpath(__file__)), 'initial_data.json')) as initial_data_file:
      loaded_data = json.load(initial_data_file, object_pairs_hook=OrderedDict)

      # Replace service-accounts if any credentials were specified via flags.
      if len(self._credentials) != 0:
        def make_service_account(email, account_credentials):
          is_default = email == u'default'
          return OrderedDict((
              (u'aliases', [u'default'] if is_default else []),
              (u'email', account_credentials.client_id if is_default else account_credentials.service_account_email),
              (u'scopes', ServerState._credential_scopes),
              (u'token', None) # Real values will be substituted here upon request.
            ))
        loaded_data[u'instance'][u'service-accounts'] = OrderedDict(
          {email : make_service_account(email, self._credentials[email]) for email in self._credentials})

      all_data = self._prepareLoadedData(u'', loaded_data)
      assert all_data is not None
      self._all_data = all_data

  def _prepareLoadedData(self, path, data):
    """Prepares loaded or updated data by wrapping it in MetadataValue-derived objects so it may be incorporated
    into the server state. Values with PROJECT_ID and NUMERIC_PROJECT_ID will be replaced by the current project id
    and numeric project id, respectively. Returns the wrapper corresponding the to data value specified or None if
    the data is invalid.

    Args:
      path: The resource path where the data will live.
      data: The data to be prepared.
    """

    length_to_strip = len(path) + (0 if path == u'' else 1)

    indexed_lists = [
      u'instance/disks',
      u'instance/licenses',
      u'instance/network-interfaces',
      u'instance/network-interfaces/*/access-configs',
      u'instance/network-interfaces/*/forwarded-ips',
      u'instance/network-interfaces/*/ip-aliases'
    ]
    for indexed_list in indexed_lists:
      if not indexed_list.startswith(path):
        continue

      remainder = indexed_list[length_to_strip:]
      if remainder == u'':
        data = MetadataIndexedList(data, self._lock)
      else:
        components = remainder[length_to_strip:].split('/')
        def process(data, i):
          component = components[i]
          if component == '*':
            for item in data:
              process(item, i + 1)
          elif i == len(components) - 1:
            data[component] = MetadataIndexedList(data[component], self._lock)
          else:
            process(data[component], i + 1)

        process(data, 0)

    numeric_project_id_token = u'<NUMERIC_PROJECT_ID>'
    project_id_token = u'<PROJECT_ID>'
    def convertToMetadata(value):
      if isinstance(value, OrderedDict):
        result = OrderedDict()
        for key in value:
          new_key = key.replace(numeric_project_id_token, unicode(self.numeric_project_id))
          new_key = new_key.replace(project_id_token, self.project_id)
          result[new_key] = convertToMetadata(value[key])

        return MetadataDict(result, self._lock)

      if isinstance(value, MetadataIndexedList):
        return MetadataIndexedList([convertToMetadata(item) for item in value], self._lock)

      if isinstance(value, list):
        return MetadataList([convertToMetadata(item) for item in value], self._lock)

      if isinstance(value, unicode):
        if value == numeric_project_id_token:
          return MetadataValue(self.numeric_project_id, self._lock)

        value = value.replace(numeric_project_id_token, unicode(self.numeric_project_id))
        value = value.replace(project_id_token, self.project_id)
        return MetadataString(value, self._lock)

      return MetadataValue(value, self._lock)

    result = convertToMetadata(data)

    non_fixed_key_dicts = [
      u'instance/attributes',
      u'instance/service-accounts',
      u'project/attributes',
    ]
    for non_fixed_key_dict in non_fixed_key_dicts:
      if not non_fixed_key_dict.startswith(path):
        continue

      remainder = non_fixed_key_dict[length_to_strip:]
      if remainder == u'':
        result.setHasFixedKeys(False)
      else:
        components = remainder.split('/')
        def process(data, i):
          if i == len(components):
            data.setHasFixedKeys(False)
          else:
            process(data[components[i]], i + 1)

        process(result, 0)

    if hasattr(self, '_all_data') and self._all_data:
      original = self._getDataTemplateAt(path)
      assert original is not None
      result = original.verifyShape(result, self._lock)

    if result:
      result.initializeParents()

    return result

  def _getDataAt(self, path):
    """Gets the raw data at the specified path.

    Args:
      path: The resource path from where the data should be obtained.
    """
    result = self._all_data
    for component in path.split('/'):
      if len(component) == 0:
        continue

      result = result.getChild(component)
      if result is None:
        return (None, not_found_error)

    if path.endswith('/token'):
      # Even though we might fully replace the result here, let the loop above run always so we ensure
      # we have a path to a valid token at this point.
      if len(self._credentials) != 0:
        email = [component for component in path.split('/') if component][-2]
        if email in self._credentials:
          token_result = self._credentials[email].get_access_token()
          result = MetadataDict(OrderedDict((
            (u'access_token', MetadataString(token_result.access_token)),
            (u'expires_in', MetadataValue(token_result.expires_in)),
            (u'token_type', MetadataString(u'Bearer')))))

    return (result, None)

  def _getDataTemplateAt(self, path):
    """Gets the raw data at the specified path which can be used to verify the data shape of a new value.

    Args:
      path: The resource path from where the data template should be obtained.
    """
    result = self._all_data
    for component in path.split('/'):
      if len(component) == 0:
        continue

      result = result.getChildTemplate(component, self._lock)
      if result is None:
        return None

    return result

  def _getResult(self, raw_data, is_recursive, is_json, is_json_default, alt):
    """Returns a tuple containing the result data which should be returned, the result data which should
    be hashed to obtain the ETag, and the error. Either the result and result to be hashed will be valid
    or the error will be valid.

    Args:
      raw_data: The MetadataValue-derived object containing the data for the result.
      is_recursive: True if the data's full recursive structure should be included in the result. False if
        only the child names should be included in the result for directory resources.
      is_json: True if the result should be returned as JSON.
      is_json_default: True if the result should have been returned as JSON if the alt parameter were not
        specified in the query.
      alt: The value of the alt query parameter.
    """
    (result, error) = raw_data.prepareResult(is_recursive, is_json, alt)
    if error:
      return (None, None, error)

    if is_json == is_json_default:
      result_to_hash = result
    else:
      (result_to_hash, _) = raw_data.prepareResult(is_recursive, is_json_default, '')
      assert result_to_hash is not None

    return (result, result_to_hash, None)

  def deleteData(self, path):
    """Gets the response when requesting to delete data.

    Args:
      path: The resource path from where the data should be deleted.
    """
    components = [component for component in path.split('/') if component]
    parent_path = '/'.join(components[:-1])
    last_component = components[-1]

    with self._lock:
      (parent_data, error) = self._getDataAt(parent_path)
      if error:
        return error

      if parent_data.hasFixedKeys():
        return update_data_error_fixed_keys

      old_data = parent_data.getChild(last_component)
      if not parent_data.deleteChild(last_component):
        return update_data_error

      if old_data is not None:
        old_data.notifyAllChanged()
      parent_data.notifyAncestorsChanged()

      return update_success

  def getResponseForDataRequest(self, path, alt, is_recursive, timeout_sec, wait_for_change, last_etag):
    """Gets the response when requesting data, which will either be an error response if the request is
    invalid or a response containing the requested data.

    Args:
      path: The resource path from where the data should be obtained.
      alt: The value of the alt query parameter.
      is_recursive: The value of the recursive query parameter.
      timeout_sec: The value of the timeout_sec query parameter.
      wait_for_change: The value of the wait_for_change query parameter.
      last_etag: The value of the last_etag query parameter.
    """
    ends_with_slash = path.endswith('/')
    if ends_with_slash:
      path = path[:-1]

    with self._lock:
      (raw_data, error) = self._getDataAt(path)
      if error:
        return error

      if path.endswith('/token'):
        # Even though this acts like a directory, trailing slashes are not allowed for tokens.
        if ends_with_slash:
          return not_found_error

        is_json = (alt != 'text')
        is_json_default = True
        is_recursive = True
      else:
        is_directory = raw_data.isDirectory()
        def should_be_json(alt):
          # recursive directory requests and instance/tags default to json
          return (alt == 'json' or ((path.endswith('/tags') or (is_recursive and is_directory)) and alt != 'text'))

        is_json = should_be_json(alt)
        is_json_default = should_be_json('')

        if ends_with_slash and not is_directory:
          return not_found_error

      (result, result_to_hash, error) = self._getResult(raw_data, is_recursive, is_json, is_json_default, alt)
      if error:
        return error

      if wait_for_change:
        # When waiting for changes on non-list directories, it must be a recursive request
        if not is_recursive and raw_data.isDirectory() and raw_data.canRequestChildren():
          return bad_request_error

        if last_etag is None or last_etag == getETag(result_to_hash):
          raw_data.waitForChange(timeout_sec)

          (raw_data, error) = self._getDataAt(path)
          if error:
            return error

          (result, result_to_hash, error) = self._getResult(raw_data, is_recursive, is_json, is_json_default, alt)
          if error:
            return error

      return formatMetadataResponse(result,
                                    result_to_hash,
                                    200,
                                    common.content_type_json if is_json else common.content_type_text)

  def setAllData(self, all_data):
    """Sets all metadata to be used by the server.

    Args:
      all_data: The object containing all new metadata.
    """
    with self._lock:
      all_data = self._prepareLoadedData('', json.loads(all_data, object_pairs_hook=OrderedDict))
      if not all_data:
        return update_data_error

      self._all_data.notifyAllChanged()
      self._all_data = all_data
      return update_success

  def setData(self, path, data):
    """Sets all data at the specified path.

    Args:
      path: The path at which the new data should be placed.
      data: The object containing the new metadata to be used at the path.
    """
    components = [component for component in path.split('/') if component]
    parent_path = '/'.join(components[:-1])
    last_component = components[-1]

    with self._lock:
      (parent_data, error) = self._getDataAt(parent_path)
      if error:
        return error

      old_data = parent_data.getChild(last_component)
      if old_data is None and parent_data.hasFixedKeys():
        return update_data_error_fixed_keys

      data_template = parent_data.getChildTemplate(last_component, self._lock)
      if data_template is not None and data_template.isDirectory():
        data = json.loads(data, object_pairs_hook=OrderedDict)

      cleaned_path = parent_path + '/' + last_component
      data = self._prepareLoadedData(cleaned_path, data)
      if data is None:
        return update_data_error

      parent_data.setChild(last_component, data)
      if old_data is not None:
        old_data.notifyAllChanged()
      parent_data.notifyAncestorsChanged()

      return update_success

app = Flask(__name__)

def excludeKeyInRecursiveGet(key):
  return key == u'token'

def formatResponse(data, status_code, content_type):
  """Creates a response tuple for the current request.
  Args:
    data: The content data for the response.
    status_code: The HTTP status code for the response.
    content_type: The content type of the response data.
  """
  return data, status_code, {common.content_type: content_type}

def formatMetadataResponse(data, data_to_hash, status_code, content_type):
  """Creates a response tuple for the current request.

  Args:
    data: The content data for the response.
    data_to_hash: The data to hash to obtain the ETag header value.
    status_code: The HTTP status code for the response.
    content_type: The content type of the response data.
  """
  return data, status_code, {common.content_type: content_type,
                             common.etag: getETag(data_to_hash)}

def getETag(data):
  """Gets the ETag for the specified data.

  Args:
    data: The data for which the ETag should be generated.
  """
  md5 = hashlib.md5()
  md5.update(data)
  return md5.hexdigest()[-16:]

class HeaderCheckMiddleware(object):
  def __init__(self, app):
     self.app = app

  def __call__(self, environ, start_response):
    req = Request(environ, shallow=True)
    if (req.headers.get(common.metadata_flavor) != common.metadata_flavor_google):
      start_response('403 Forbidden',
                     [(common.content_type, common.content_type_html),
                      (common.metadata_flavor, common.metadata_flavor_google),
                      (common.server, common.server_value)])
      return ['Missing Metadata-Flavor:Google header.']
    return self.app(environ, start_response)

class MetadataValue(object):
  """Wrapper for a piece of metadata (either a value or directory)."""

  def __init__(self, value, lock):
    self._value = value
    self._parent = None
    self._changeConditon = threading.Condition(lock)

  def deleteChild(self, child_name):
    """Attempts to delete the child with the specified name and returns whether the operation was successful.

    Args:
      child_name: The name where the value should be deleted.
    """
    return False

  def getChild(self, child_name):
    return None

  def getChildTemplate(self, child_name, lock):
    """Gets the data template against which a child with the specified name can have its data shape verified.

    Args:
      child_name: The name where the new value will be placed.
      lock: the lock to use to create new metadata values if necessary.
    """
    return None

  def getValueToJSONEncode(self):
    return self._value

  def verifyShape(self, data, lock):
    """Verifies the shapes of the new data, possibly coercing the type if necessary, and returns it.
    Returns None if the data is invalid.
    
    Arg:
      data: the new data to verify.
      lock: the lock to use to create new metadata values if necessary.
    """
    if type(self) is type(data):
      return data

    # If the new data is a string but this is not, its possible the new data is the string representation
    # of an int, in which case we should simply coerce it.
    if isinstance(data, MetadataString) and not isinstance(self, MetadataString):
      try:
        return MetadataValue(int(data._value), lock)
      except ValueError:
        pass

    return None

  def initializeParents(self):
    """Sets the parent references on all descendant data."""
    pass

  def isDirectory(self):
    return False

  def notifyAllChanged(self):
    """Notifies any waiting threads that all data has changed."""
    self._changeConditon.notify_all()

  def notifyAncestorsChanged(self):
    """Notifies any waiting threads that this data and any ancestor data has changed."""
    current = self
    while current is not None:
      current._changeConditon.notify_all()
      current = current._parent

  def prepareResult(self, is_recursive, is_json, alt):
    if is_recursive:
      return self.prepareRecursiveResult(is_json)

    if alt and self.isDirectory() and self.canRequestChildren():
      return (None, bad_request_error)
  
    return self.prepareNonRecursiveResult(is_json)

  def prepareNonRecursiveResult(self, is_json):
    return (unicode(self._value), None)

  def prepareRecursiveResult(self, is_json):
    if is_json:
      return (json.dumps(self.getValueToJSONEncode(), separators=(u',', u':')), None)
    else:
      return (self.prepareRecursiveResultAsText(''), None)

  def prepareRecursiveResultAsText(self, prefix):
    result = unicode(self._value)
    return prefix + u' ' + result + u'\n' if prefix else result

  def setChild(self, child_name, value):
    """Sets the child data with the specified name

    Args:
      child_name: The name of the child to set.
      value: The data to set as the child.
    """
    raise KeyError('This value has no children')

  def setParent(self, parent):
    """Sets the reference to the parent data which owns this instance."""
    self._parent = parent

  def value(self):
    return self._value

  def waitForChange(self, timeout_sec):
    """Wait for the data or any of its descendants to change for the specified amount of time.
    
    Arg:
      timeout_sec: The maximum number of seconds to wait.
    """
    self._changeConditon.wait(timeout_sec)

class MetadataDirectory(MetadataValue):
  """Base class for a wrapper child contains child metadata values."""

  def __iter__(self):
    return self._value.__iter__()

  def __contains__(self, key):
    return self._value.__contains__(key)

  def __len__(self):
    return self._value.__len__()

  def __delitem__(self, key):
    self._value.__delitem__(key)

  def __getitem__(self, key):
    return self._value.__getitem__(key)
  
  def __setitem__(self, key, value):
    self._value.__setitem__(key, value)

  def canRequestChildren(self):
    return True

  def childIter(self):
    """Gets an iterator for all child data."""
    return self.__iter__()

  def getChildTemplate(self, child_name, lock):
    """Gets the data template against which a child with the specified name can have its data shape verified.

    Args:
      child_name: The name where the new value will be placed.
      lock: the lock to use to create new metadata values if necessary.
    """
    if self.hasFixedKeys():
      return self.getChild(child_name)

    child = next(self.childIter(), None)
    if child is not None:
      return child

    return MetadataString(u'', lock)

  def hasFixedKeys(self):
    """Gets the value indicating whether the directory has a fixed set of keys or not. If False, the directory
    can have an arbitrary set of keys, but the values associated with those keys must conform to a certain data
    shape."""
    return False

  def initializeParents(self):
    """Sets the parent references on all descendant data."""
    for item in self.childIter():
      item.setParent(self)
      item.initializeParents()

  def isDirectory(self):
    return True

  def notifyAllChanged(self):
    MetadataValue.notifyAllChanged(self)
    for item in self.childIter():
      item.notifyAllChanged()

class MetadataDict(MetadataDirectory):
  """Wrapper for a set of metadata key/value pairs."""

  def __init__(self, items, lock):
    assert isinstance(items, OrderedDict)
    MetadataDirectory.__init__(self, items, lock)
    self._has_fixed_keys = True

  def childIter(self):
    """Gets an iterator for all child data."""
    for key in self:
      yield self[key] 

  def deleteChild(self, child_name):
    """Attempts to delete the child with the specified name and returns whether the operation was successful.

    Args:
      child_name: The name where the value should be deleted.
    """
    if self.hasFixedKeys():
      return False

    if child_name not in self:
      return False

    del self[child_name]
    return True

  def getChild(self, child_name):
    if not child_name in self:
      return None

    return self[child_name]

  def getValueToJSONEncode(self):
    result = OrderedDict()
    for key in self:
      if excludeKeyInRecursiveGet(key):
        continue

      value = self[key]

      # Service account email and custom metadata keys should not be converted to camel case.
      newKey = common.convertToCamelCase(key) if self._has_fixed_keys else key
      result[newKey] = value.getValueToJSONEncode()

    return result

  def verifyShape(self, data, lock):
    data = MetadataDirectory.verifyShape(self, data, lock)
    if not data:
      return None

    if self._has_fixed_keys != data._has_fixed_keys:
      return None

    if self._has_fixed_keys:
      if len(self) != len(data):
        return None

      for key in self:
        if key not in data:
          return None

        child = self[key].verifyShape(data[key], lock)
        if not child:
          return None

        data[key] = child
    else:
      template = self.getChildTemplate(u'', lock)

      for key in data:
        child = template.verifyShape(data[key], lock)
        if not child:
          return None

        data[key] = child

    return data

  def hasFixedKeys(self):
    """Gets the value indicating whether the dictionary has a fixed set of keys or not. If False, the dictionary
    can have an arbitrary set of keys, but the values associated with those keys must conform to a certain data
    shape."""
    return self._has_fixed_keys

  def prepareNonRecursiveResult(self, is_json):
    def includeSlash(key):
      return not excludeKeyInRecursiveGet(key) and self[key].isDirectory() and self[key].canRequestChildren()

    return (''.join(key + (u'/\n' if includeSlash(key) else u'\n') for key in self), None)

  def prepareRecursiveResultAsText(self, prefix):
    result = u''
    for key in self:
      if excludeKeyInRecursiveGet(key):
        continue

      result += self[key].prepareRecursiveResultAsText(prefix + (u'/' if len(prefix) != 0 else u'') + key)

    return result

  def setChild(self, child_name, value):
    """Sets the child data with the specified name

    Args:
      child_name: The name of the child to set.
      value: The data to set as the child.
    """
    if child_name in self:
      self[child_name].setParent(None)

    self[child_name] = value
    value.setParent(self)

  def setHasFixedKeys(self, has_fixed_keys):
    """Sets the value indicating whether the dictionary has a fixed set of keys or not. If has_fixed_keys is
    False, the dictionary can have an arbitrary set of keys, but the values associated with those keys must
    conform to a certain data shape.
    
    Args:
      has_fixed_keys: Indicates whether the dictionary is expected to have a fixed set of keys or not.
    """
    self._has_fixed_keys = has_fixed_keys

  def value(self):
    return self

class MetadataIndexedList(MetadataDirectory):
  """Wrapper for a collection whose content is accessed via an index value in the relative URL."""

  def __init__(self, items, lock):
    assert isinstance(items, list)
    MetadataDirectory.__init__(self, items, lock)

  def deleteChild(self, child_name):
    """Attempts to delete the child with the specified name and returns whether the operation was successful.

    Args:
      child_name: The name where the value should be deleted.
    """
    try:
      index = int(child_name)
    except ValueError:
      pass
    else:
      if 0 <= index and index < len(self):
        del self[index]
        return True

    return False

  def getChild(self, child_name):
    try:
      index = int(child_name)
      if 0 <= index and index < len(self):
        return self[index]
    except ValueError:
      pass
    
    return None

  def getValueToJSONEncode(self):
    return [item.getValueToJSONEncode() for item in self]

  def verifyShape(self, data, lock):
    data = MetadataDirectory.verifyShape(self, data, lock)
    if not data:
      return None

    template = self.getChildTemplate(u'', lock)

    for i in range(len(data)):
      child = template.verifyShape(data[i], lock)
      if not child:
        return None

      data[i] = child

    return data

  def prepareNonRecursiveResult(self, is_json):
    return (''.join(unicode(i) + u'/\n' for i in range(len(self))), None)

  def prepareRecursiveResultAsText(self, prefix):
    result = u''
    for i in range(len(self._value)):
      result += self._value[i].prepareRecursiveResultAsText(prefix + (u'/' if len(prefix) != 0 else u'') + unicode(i))

    return result

  def setChild(self, child_name, value):
    """Sets the child data with the specified name

    Args:
      child_name: The name of the child to set.
      value: The data to set as the child.
    """
    try:
      index = int(child_name)
      if 0 <= index and index < len(self):
        self[index].setParent(None)
        self[index] = value
        value.setParent(self)
        return
      elif index == len(self):
        self._value.append(value)
        value.setParent(self)
        return
    except ValueError:
      pass

    raise KeyError('The child index is out of range or invalid for the list.')

class MetadataList(MetadataDirectory):
  """Wrapper for a list which can only be requested as a unit. Its children cannot be accessed via the relative URL."""

  def __init__(self, items, lock):
    assert isinstance(items, list)
    MetadataDirectory.__init__(self, items, lock)
    
  def canRequestChildren(self):
    return False

  def getValueToJSONEncode(self):
    return [item.getValueToJSONEncode() for item in self]

  def verifyShape(self, data, lock):
    data = MetadataDirectory.verifyShape(self, data, lock)
    if not data:
      return None

    template = self.getChildTemplate(u'', lock)

    for i in range(len(data)):
      child = template.verifyShape(data[i], lock)
      if not child:
        return None

      data[i] = child

    return data

  def prepareNonRecursiveResult(self, is_json):
    if is_json:
      return (json.dumps(self.getValueToJSONEncode(), separators=(u',', u':')), None)
    
    result = u''
    for item in self:
      (item_result, error) = item.prepareNonRecursiveResult(is_json)
      if error:
        return (None, error)

      result += item_result + u'\n'

    return (result, None)

  def prepareRecursiveResultAsText(self, prefix):
    return u''.join(val.prepareRecursiveResultAsText(prefix) for val in self)

class MetadataString(MetadataValue):
  """Wrapper for a metadata string value."""

  def __init__(self, value, lock):
    assert isinstance(value, unicode)
    MetadataValue.__init__(self, value, lock)

  def prepareNonRecursiveResult(self, is_json):
    if is_json:
      return (u'"' + self._value + u'"', None)

    return MetadataValue.prepareNonRecursiveResult(self, is_json)

not_found_error = formatResponse(u'Error: Not found', 404, common.content_type_html)
bad_request_error = formatResponse(u'Error: bad request', 400, common.content_type_html)
update_success = formatResponse(u'Update successful', 200, common.content_type_text)
update_data_error = formatResponse(u'Updated data does not have the correct format', 400, common.content_type_html)
update_data_error_fixed_keys = formatResponse(u'Cannot add or remove data at the specified path', 400, common.content_type_html)

@app.after_request
def add_headers(response):
  response.headers[common.server] = common.server_value

  # When the token is requested, the response should not have the Metadata-Flavor header
  if not response.data.startswith(u'{"access_token":"') and not response.data.startswith(u'access_token '):
    response.headers[common.metadata_flavor] = common.metadata_flavor_google
  return response

@app.route('/', methods = ['GET'])
def root():
  # TODO: Should we return error when any query parameters are specified?
  result = u'0.1/\ncomputeMetadata/\n'
  return formatMetadataResponse(result, result, 200, common.content_type_text)

@app.route('/computeMetadata/', methods = ['GET'])
def computeMetadataRoot():
  # TODO: Should we return error when any query parameters are specified?
  result = u'v1/\nv1beta1/\n'
  return formatMetadataResponse(result, result, 200, common.content_type_text)

@app.route('/computeMetadata/v1/', methods = ['GET'])
def getRootData():
  return getData(u'')

@app.route('/computeMetadata/v1/<path:path>', methods = ['GET'])
def getData(path):
  global state
  # TODO There are 500 max hanging gets (not sure if we need to enforce this)
  def asBool(value):
    if not value:
      return False

    return value.lower() in ['true', 'on', 'yes', '1']

  def asInt(value, default):
    try:
      return int(value)
    except (ValueError, TypeError):
      return default

  alt = request.args.get('alt')
  is_recursive = asBool(request.args.get('recursive'))
  timeout_sec = asInt(request.args.get('timeout_sec'), None)
  wait_for_change = asBool(request.args.get('wait_for_change'))
  last_etag = request.args.get('last_etag')

  return state.getResponseForDataRequest(path, alt, is_recursive, timeout_sec, wait_for_change, last_etag)

def getUpdatedData():
  result = urllib.unquote_plus(request.get_data(as_text=True))
  if not result:
    return (None, formatResponse(u'Error: no content specified with the POST request.',
                                 400,
                                 common.content_type_html))
  return (result, None)

@app.route('/emulator/v1/update/', methods = ['POST'])
def updateAllData():
  global state

  (new_data, error) = getUpdatedData()
  if error:
    return error

  return state.setAllData(new_data)

@app.route('/emulator/v1/update/<path:path>', methods = ['POST', 'DELETE'])
def updateData(path):
  global state

  if request.method == 'DELETE':
    return state.deleteData(path)

  (new_data, error) = getUpdatedData()
  if error:
    return error

  return state.setData(path, new_data)

if __name__ == '__main__':

  fake_numeric_project_id = 12345
  fake_project_id = u'fake-project'
  usage = """SYNOPSIS
     python metadata_server.py [-h] [-i <project_id>] [-d]
         [-c <json_credentials_files>] [-n <numeric_project_id>] [-t]
         [-p <port>]

FLAGS
      -h, --help
         Display help for the emulator.

      -t, --test
         Sets the emulator up for tests to be run on it, which will prevent it
         from picking up the TEST_PROJECT environment variable to initialize
         the project id. Instead the value of the value of %s will be
         used (or the --id value if specified).

      -i PROJECT_ID, --id=PROJECT_ID
         The project id to use. If unspecified and --test is also not
         specified, the value of the TEST_PROJECT environment variable will be
         used if set. Otherwise, the value of %s will be used.

      -n NUMERIC_PROJECT_ID, --num_id=NUMERIC_PROJECT_ID
         The numeric project id to use. If unspecified the value of %s will
         be used.

      -p PORT, --port=PORT
         Specifies the port on which to listen to requests. If unspecified, an
         open port will be selected automatically and an environment variable
         containing this port will be printed when the emulator is started.

      -d, --default_credentials
         Use the application default credentials as one of the service accounts
         for the emulated instance metadata. If this or --credentials are
         specified, the dummy service accounts will not be used for the
         emulator.

      -c FILES, --credentials=FILES
         A %s separated list of JSON files from which to obtain service account
         credentials for the emulated instance metadata. If this or
         --default_credentials are specified, the dummy service accounts will
         not be used for the emulator.""" % (fake_project_id,
                                             fake_project_id,
                                             fake_numeric_project_id,
                                             os.pathsep)

  port = None
  is_for_testing = False
  argv = sys.argv[1:]
  project_id = None
  numeric_project_id = None
  use_default_credentials = False
  credentials_files = None
  try:
    opts, args = getopt.getopt(argv, 'htdc:i:n:p:', ['help', 'test', "default_credentials", 'credentials=', 'id=', 'num_id=', 'port='])
  except getopt.GetoptError:
    print usage
    sys.exit(2)
  for opt, arg in opts:
    if opt in ('-h', '--help'):
      print usage
      sys.exit()
    elif opt in ('-d', '--default_credentials'):
      use_default_credentials = True
    elif opt in ('-c', '--credentials'):
      credentials_files = arg
    elif opt in ('-i', '--id'):
      project_id = arg
    elif opt in ('-n', '--num_id'):
      numeric_project_id = int(arg)
    elif opt in ('-t', '--test'):
      is_for_testing = True
    elif opt in ('-p', '--port'):
      port = int(arg)

  if not project_id:
    if is_for_testing:
      project_id = fake_project_id
    else:
      project_id = os.environ.get('TEST_PROJECT', fake_project_id)

  if not numeric_project_id:
    numeric_project_id = fake_numeric_project_id

  state = ServerState(project_id, numeric_project_id, use_default_credentials, credentials_files)

  if not port:
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.bind(('', 0))
    port = sock.getsockname()[1]
    sock.close()

  emulator_host = 'localhost:' + unicode(port)

  print "---------------------------------"
  print "Running Metadata Server Emulator with"
  print "  Project ID: %s" %  state.project_id
  print "  Numeric Project ID: %s" %  state.numeric_project_id
  print "---------------------------------"
  print "Use this environment variable to connect to the emulator"
  print "  %s %s=%s" % ("set" if os.name == 'nt' else "export", common.host_environment_variable, emulator_host)
  print "---------------------------------"
  print "To update or delete data in the emulator, send a POST or DELETE request, respectively, to"
  print "  http://%s/emulator/v1/update/<path>" % emulator_host
  print "For POSTs, the content should be the URL-encoded new value (specified in JSON for directory paths)"
  print ""
  print "For example, the following command will change the CPU platform"
  print '  curl -d "Intel+Ivy+Bridge" -H "Metadata-Flavor: Google" http://%s/emulator/v1/update/instance/cpu-platform"' % emulator_host
  print ""
  print "And this command will remove the 2nd license"
  print '  curl -X DELETE -H "Metadata-Flavor: Google" http://%s/emulator/v1/update/instance/licenses/1"' % emulator_host
  print "---------------------------------"

  # If the process is killed while standard output is getting redirected, the output above
  # may not make it to the consumer, so flush the output before running the server.
  sys.stdout.flush()

  app.wsgi_app = HeaderCheckMiddleware(app.wsgi_app)

  while True:
    try:
      app.run(host='', port=port, debug=False, threaded=True)
      break
    except socket.error as error:
      if error.errno != errno.WSAECONNRESET:
        raise
