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
import common, errno, getopt, json, logging, os, socket, string, sys, time

numeric_project_id = 12345
numeric_project_id_token = u'<NUMERIC_PROJECT_ID>'
project_id = u'fake-project'
project_id_token = u'<PROJECT_ID>'

credential_scopes = [ "https://www.googleapis.com/auth/cloud-platform", "https://www.googleapis.com/auth/userinfo.email" ]
credentials = {}

app = Flask(__name__)

def excludeKeyInRecursiveGet(key):
  return key == u'token'

def formatResponse(data, status_code, content_type):
  return data, status_code, {common.content_type: content_type}

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

# Wrapper for a piece of metadata (either a value or directory).
class MetadataValue:
  def __init__(self, value):
    self._value = value

  def getChild(self, child_name):
    return None

  def getValueToJSONEncode(self):
    return self._value

  def isDirectory(self):
    return False

  def isServiceAccount(self):
    return False

  def prepareResult(self, is_recursive, is_directory, is_json, alt):
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

  def value(self):
    return self._value

# Base class for a wrapper child contains child metadata values.
class MetadataDirectory(MetadataValue):
  def __iter__(self):
    return self._value.__iter__()

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

  def isDirectory(self):
    return True

# Wrapper for a set of metadata key/value pairs.
class MetadataDict(MetadataDirectory):
  def __init__(self, items):
    assert isinstance(items, OrderedDict)
    MetadataDirectory.__init__(self, items)

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

      # Service account email keys should not be converted to camel case.
      newKey = key if value.isServiceAccount() else common.convertToCamelCase(key)
      result[newKey] = value.getValueToJSONEncode()

    return result

  def isServiceAccount(self):
    return "email" in self and "scopes" in self and "token" in self

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

  def value(self):
    return self

# Wrapper for a collection whose content is accessed via an index value in the relative URL.
class MetadataIndexedList(MetadataDirectory):
  def __init__(self, items):
    assert isinstance(items, list)
    MetadataDirectory.__init__(self, items)

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

  def prepareNonRecursiveResult(self, is_json):
    return (''.join(unicode(i) + u'/\n' for i in range(len(self))), None)

  def prepareRecursiveResultAsText(self, prefix):
    result = u''
    for i in range(len(self._value)):
      result += self._value[i].prepareRecursiveResultAsText(prefix + (u'/' if len(prefix) != 0 else u'') + unicode(i))

    return result

# Wrapper for a list which can only be requested as a unit. Its children cannot be accessed via the relative URL.
class MetadataList(MetadataDirectory):
  def __init__(self, items):
    assert isinstance(items, list)
    MetadataDirectory.__init__(self, items)
    
  def canRequestChildren(self):
    return False

  def getValueToJSONEncode(self):
    return [item.getValueToJSONEncode() for item in self]

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

# Wrapper for a metadata string value.
class MetadataString(MetadataValue):
  def __init__(self, value):
    assert isinstance(value, unicode)
    MetadataValue.__init__(self, value)

  def prepareNonRecursiveResult(self, is_json):
    if is_json:
      return (u'"' + self._value + u'"', None)

    return MetadataValue.prepareNonRecursiveResult(self, is_json)

not_found_error = formatResponse(u'Error: Not found', 404, common.content_type_html)
bad_request_error = formatResponse(u'Error: bad request', 400, common.content_type_html)

all_data = {}
def loadData():
  global all_data
  global credential_scopes
  global credentials

  with open(os.path.join(os.path.dirname(os.path.realpath(__file__)), 'initial_data.json')) as initial_data_file:
    all_data = json.load(initial_data_file, object_pairs_hook=OrderedDict)
    indexed_lists = [
      u'instance/disks',
      u'instance/licenses',
      u'instance/network-interfaces',
      u'instance/network-interfaces/*/access-configs',
      u'instance/network-interfaces/*/forwarded-ips',
      u'instance/network-interfaces/*/ip-aliases'
    ]
    for indexed_list in indexed_lists:
      components = indexed_list.split('/')
      def process(data, i):
        component = components[i]
        if component == '*':
          for item in data:
            process(item, i + 1)
        elif i == len(components) - 1:
          data[component] = MetadataIndexedList(data[component])
        else:
          process(data[component], i + 1)

      process(all_data, 0)

    # Replace service-accounts if any credentials were specified via flags.
    if len(credentials) != 0:
      def make_service_account(email, account_credentials):
        is_default = email == u'default'
        return OrderedDict((
            (u'aliases', ([ u'default' ] if is_default else [])),
            (u'email', (account_credentials.client_id if is_default else account_credentials.service_account_email)),
            (u'scopes', credential_scopes),
            (u'token', None) # Real values will be substituted here upon request.
          ))
      all_data[u'instance'][u'service-accounts'] = OrderedDict(
        {email : make_service_account(email, credentials[email]) for email in credentials})

    def convertToMetadata(value):
      if isinstance(value, OrderedDict):
        result = OrderedDict()
        for key in value:
          new_key = key.replace(numeric_project_id_token, unicode(numeric_project_id))
          new_key = new_key.replace(project_id_token, project_id)
          result[new_key] = convertToMetadata(value[key])

        return MetadataDict(result)

      if isinstance(value, MetadataIndexedList):
        return MetadataIndexedList([convertToMetadata(item) for item in value])

      if isinstance(value, list):
        return MetadataList([convertToMetadata(item) for item in value])

      if isinstance(value, unicode):
        if value == numeric_project_id_token:
          return MetadataValue(numeric_project_id)

        value = value.replace(numeric_project_id_token, unicode(numeric_project_id))
        value = value.replace(project_id_token, project_id)
        return MetadataString(value)

      return MetadataValue(value)

    all_data = convertToMetadata(all_data)

def getRawDataAt(parent_data, path):
  result = parent_data
  for component in path.split('/'):
    if len(component) == 0:
      continue

    result = result.getChild(component)
    if result is None:
      return (None, not_found_error)

  return (result, None)

@app.after_request
def add_headers(response):
  response.headers[common.server] = common.server_value

  # When the token is requested, the response should not have the Metadata-Flavor header
  if not response.data.startswith(u'{"access_token":"') and not response.data.startswith(u'access_token '):
    response.headers[common.metadata_flavor] = common.metadata_flavor_google
  return response

@app.route('/', methods = ['GET'])
def root():
  return formatResponse(u'0.1/\ncomputeMetadata/\n', 200, common.content_type_text)

@app.route('/computeMetadata/', methods = ['GET'])
def computeMetadataRoot():
  return formatResponse(u'v1/\nv1beta1/\n', 200, common.content_type_text)

@app.route('/computeMetadata/v1/', methods = ['GET'])
def getRootData():
  return getData(u'')

@app.route('/computeMetadata/v1/<path:path>', methods = ['GET'])
def getData(path):
  global all_data
  global credentials

  # TODO There are 500 max hanging gets (not sure if we need to enforce this)
  # TODO Actually handle waiting for changes and last_etag

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
  timeout_sec = asInt(request.args.get('timeout_sec'), -1)
  wait_for_change = asBool(request.args.get('wait_for_change'))

  ends_with_slash = path.endswith('/')
  if ends_with_slash:
    path = path[:-1]

  (raw_data, error) = getRawDataAt(all_data, path)
  if error:
    return error

  is_directory = raw_data.isDirectory()
  if path.endswith('/token'):
    # Even though this acts like a directory, trailing slashes are not allowed for tokens.
    if ends_with_slash:
      return not_found_error

    if len(credentials) != 0:
      email = [component for component in path.split('/') if component][-2]
      if email in credentials:
        token_result = credentials[email].get_access_token()
        raw_data = MetadataDict(OrderedDict((
          (u'access_token', MetadataString(token_result.access_token)),
          (u'expires_in', MetadataValue(token_result.expires_in)),
          (u'token_type', MetadataString(u'Bearer')))))

    is_json = (alt != 'text')
    is_recursive = True
  else:
    # recursive directory requests and instance/tags default to json
    is_json = (alt == 'json' or ((path.endswith('/tags') or (is_recursive and is_directory)) and alt != 'text'))
    if ends_with_slash and not is_directory:
      return not_found_error

  if wait_for_change:
    # When waiting for changes on non-list directories, it must be a recursive request
    if not is_recursive and raw_data.isDirectory() and raw_data.canRequestChildren():
      return bad_request_error

    if timeout_sec < 0:
      return formatResponse(u'Error: indefinitely waiting for changes is not supported',
                            400, 
                            common.content_type_html)
    time.sleep(timeout_sec)

  (result, error) = raw_data.prepareResult(is_recursive, is_directory, is_json, alt)
  if error:
    return error

  return formatResponse(result,
                        200,
                        common.content_type_json if is_json else common.content_type_text)

if __name__ == '__main__':
  test_project_id = project_id
  project_id = os.environ.get('TEST_PROJECT')

  port = None
  is_for_testing = False
  credentials_files = None
  argv = sys.argv[1:]
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
         not be used for the emulator.""" % (test_project_id, test_project_id, numeric_project_id, os.pathsep)
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
      credentials[u'default'] = service_account.ServiceAccountCredentials.get_application_default()
    elif opt in ('-c', '--credentials'):
      credentials_files = arg
    elif opt in ('-i', '--id'):
      project_id = arg
      test_project_id = arg
    elif opt in ('-n', '--num_id'):
      numeric_project_id = int(arg)
    elif opt in ('-t', '--test'):
      is_for_testing = True
    elif opt in ('-p', '--port'):
      port = int(arg)

  if credentials_files:
    for path in string.split(credentials_files, os.pathsep):
      account_credentials = service_account.ServiceAccountCredentials.from_json_keyfile_name(
        path,
        scopes = credential_scopes)
      credentials[account_credentials.service_account_email] = account_credentials

  if is_for_testing:
    project_id = test_project_id

  loadData()

  if not port:
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.bind(('', 0))
    port = sock.getsockname()[1]
    sock.close()

  emulator_host = 'localhost:' + unicode(port)

  print "---------------------------------"
  print "Running Metadata Server Emulator with"
  print "  Project ID: %s" %  project_id
  print "  Numeric Project ID: %s" %  numeric_project_id
  print "---------------------------------"
  print "Use this environment variable to connect to the emulator"
  print "  %s %s=%s" % ("set" if os.name == 'nt' else "export", common.host_environment_variable, emulator_host)
  print "---------------------------------"

  app.wsgi_app = HeaderCheckMiddleware(app.wsgi_app)

  while True:
    try:
      app.run(host='', port=port, debug=False)
      break
    except socket.error as error:
      if error.errno != errno.WSAECONNRESET:
        raise

