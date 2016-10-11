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
import common, datetime, json, os, urllib2

try:
  server_address = 'http://' + os.environ[common.host_environment_variable]
  request = urllib2.Request(server_address,
                            headers={common.metadata_flavor : common.metadata_flavor_google})
  urllib2.urlopen(request)
except KeyError:
  raise Exception('%s must be set' % common.host_environment_variable)
except urllib2.URLError:
  raise Exception('The emulator cannot be reached at %s' % server_address)

error_count = 0

def check_header(headers, url, key, value):
  key_lower = key.lower()
  if not key_lower in headers:
    print "* Test failed: Cannot find %s header for %s" % (key, url)
    return False

  if headers[key_lower] != value:
    print "* Test failed: Wrong %s header value for %s\n\tExpected: %s\n\tActual  : %s" % (key, url, value, headers[key_lower])
    return False

  return True

def expect_content_absolute(url, expected, expected_content_type, expect_metadata_header=True):
  global error_count
  request = urllib2.Request(url, headers={common.metadata_flavor : common.metadata_flavor_google})
  response = urllib2.urlopen(request)
  headers = response.info().dict

  failed = False
  if expect_metadata_header:
    failed |= not check_header(headers, url, common.metadata_flavor, common.metadata_flavor_google)
  elif common.metadata_flavor.lower() in headers:
    print "* Test failed: Was not expecting to find %s header for %s" % (common.metadata_flavor, url)
    failed = True

  failed |= not check_header(headers, url, common.server, common.server_value)
  failed |= not check_header(headers, url, common.content_type, expected_content_type)
  
  contents = response.read()
  if expected != contents:
    failed = True
    print "* Test failed: Wrong content for %s\n\tExpected: `%s`\n\tActual  : `%s`" % (url, expected, contents)
    print "\tExpected type: %s\n\tActual type:   %s" % (type(expected), type(contents))

  if not failed:
    print "Test passed: %s" % url
  else:
    error_count += 1

def expect_content(path, expected, expected_content_type, expect_metadata_header=True):
  expect_content_absolute(server_address + '/computeMetadata/v1/' + path,
                          expected,
                          expected_content_type,
                          expect_metadata_header)

def expect_error(path, expected_code, metadata_flavor_value=common.metadata_flavor_google):
  global error_count
  url = server_address + '/computeMetadata/v1/' + path
  request = urllib2.Request(url,
                            headers={common.metadata_flavor :
                                     metadata_flavor_value} if metadata_flavor_value else {})
  failed = False
  try:
    response = urllib2.urlopen(request)
    failed = True
    print "* Test failed: Expected error for %s\n\tContent: %s" % (path, response.read())
  except urllib2.HTTPError as e:
    failed |= not check_header(e.headers, url, common.metadata_flavor, common.metadata_flavor_google)
    failed |= not check_header(e.headers, url, common.server, common.server_value)
    failed |= not check_header(e.headers, url, common.content_type, common.content_type_html)
    if e.code != expected_code:
       failed = True
       print "* Test failed: Wrong error code for %s\n\tExpected: %s\n\tActual  : %s" % (path, unicode(expected_code), unicode(e.code))
  
  if not failed:
    print "Test passed: %s" % path
  else:
    error_count += 1
  
def test_path(path, expected, default='text'):
  expected_json = json.dumps(expected, separators=(',', ':'))
  if isinstance(expected, list):
    expected_text = ''.join(s + '\n' for s in expected)
  else:
    expected_text = unicode(expected)
    
  expect_content(path,
                 expected_text if default == 'text' else expected_json,
                 common.content_type_text if default == 'text' else common.content_type_json)
  expect_content(path + "?alt=text", expected_text, common.content_type_text)
  expect_content(path + "?alt=json", expected_json, common.content_type_json)

def test_dir(path, expected):
  expect_content(path, expected, common.content_type_text)
  if path:
    expect_content(path + '/', expected, common.content_type_text)

def test_dir_absolute(url, expected):
  expect_content_absolute(url, expected, common.content_type_text)
  expect_content_absolute(url + '/', expected, common.content_type_text)

def test_dir_recursive(path, expected, test_trailing_slash=True, use_recursive_field=True, expect_metadata_header=True):
  query = '?recursive=true' if use_recursive_field else ''
  expect_content(path + query, expected, common.content_type_json, expect_metadata_header)
  if test_trailing_slash:
    expect_content(path + '/' + query, expected, common.content_type_json, expect_metadata_header)

  data = json.loads(expected, object_pairs_hook=OrderedDict)

  def convertToText(prefix, o):
    text = ''
    if isinstance(o, list):
      if len(o) != 0:
        if isinstance(o[0], OrderedDict):
          for i in range(len(o)):
            text += convertToText(prefix + ('/' if len(prefix) != 0 else '') + unicode(i), o[i])
        else:
          for i in range(len(o)):
            text += convertToText(prefix, o[i])
    elif isinstance(o, OrderedDict):
      for key in o:
        text += convertToText(prefix + ('/' if len(prefix) != 0 else '') + common.convertToDashed(key),
                              o[key])
    else:
      text += prefix + ' ' + unicode(o) + '\n'

    return text

  expected_text = convertToText('', data)
  query = '?recursive=true&alt=text' if use_recursive_field else '?alt=text'
  expect_content(path + query, expected_text, common.content_type_text, expect_metadata_header)
  if test_trailing_slash:
    expect_content(path + '/' + query, expected_text, common.content_type_text, expect_metadata_header)
  
  query = '?recursive=true&alt=json' if use_recursive_field else '?alt=json'
  expect_content(path + query, expected, common.content_type_json, expect_metadata_header)
  if test_trailing_slash:
    expect_content(path + '/' + query, expected, common.content_type_json, expect_metadata_header)

if __name__ == '__main__':
  error_count = 0

  test_dir_absolute(server_address, '0.1/\ncomputeMetadata/\n')
  test_dir_absolute(server_address + '/computeMetadata', 'v1/\nv1beta1/\n')
  test_dir('', 'instance/\nproject/\n')
  test_dir('instance', 'attributes/\ncpu-platform\ndescription\ndisks/\nhostname\nid\nimage\nlicenses/\nmachine-type\n'
           'maintenance-event\nnetwork-interfaces/\nscheduling/\nservice-accounts/\ntags\nvirtual-clock/\nzone\n')
  test_dir('instance/attributes', 'my_instance_key1\n')
  test_path('instance/attributes/my_instance_key1', 'my_instance_value1')
  test_path('instance/cpu-platform', 'Intel Haswell')
  test_path('instance/description', 'Fake instance for metadata server emulator')
  test_dir('instance/disks', '0/\n')
  test_dir('instance/disks/0', 'device-name\nindex\nmode\ntype\n')
  test_path('instance/disks/0/device-name', 'boot')
  test_path('instance/disks/0/index', 0)
  test_path('instance/disks/0/mode', 'READ_WRITE')
  test_path('instance/disks/0/type', 'PERSISTENT')
  test_path('instance/hostname', 'name.project.google.com.internal')
  test_path('instance/id', 67890)
  test_path('instance/image', '')
  test_dir('instance/licenses', '0/\n')
  test_dir('instance/licenses/0', 'id\n')
  test_path('instance/licenses/0/id', '0')
  test_path('instance/machine-type', 'projects/12345/machineTypes/n1-standard-1')
  test_path('instance/maintenance-event', 'NONE')
  test_dir('instance/network-interfaces', '0/\n')
  test_dir('instance/network-interfaces/0', 'access-configs/\nforwarded-ips/\nip\nip-aliases/\nmac\nnetwork\n')
  test_dir('instance/network-interfaces/0/access-configs', '0/\n')
  test_dir('instance/network-interfaces/0/access-configs/0', 'external-ip\ntype\n')
  test_path('instance/network-interfaces/0/access-configs/0/external-ip', '0.0.0.0')
  test_path('instance/network-interfaces/0/access-configs/0/type', 'ONE_TO_ONE_NAT')
  test_dir('instance/network-interfaces/0/forwarded-ips', '')
  test_path('instance/network-interfaces/0/ip', '0.0.0.0')
  test_dir('instance/network-interfaces/0/ip-aliases', '')
  test_path('instance/network-interfaces/0/mac', '00:00:00:00:00:00')
  test_path('instance/network-interfaces/0/network', 'projects/12345/networks/default')
  test_dir('instance/scheduling', 'automatic-restart\non-host-maintenance\npreemptible\n')
  test_path('instance/scheduling/automatic-restart', 'TRUE')
  test_path('instance/scheduling/on-host-maintenance', 'MIGRATE')
  test_path('instance/scheduling/preemptible', 'FALSE')
  test_dir('instance/service-accounts', '12345-compute@developer.gserviceaccount.com/\ndefault/\n')
  test_dir('instance/service-accounts/12345-compute@developer.gserviceaccount.com', 'aliases\nemail\nscopes\ntoken\n')
  test_path('instance/service-accounts/12345-compute@developer.gserviceaccount.com/aliases', ['default'])
  test_path('instance/service-accounts/12345-compute@developer.gserviceaccount.com/email',
            '12345-compute@developer.gserviceaccount.com')
  test_path('instance/service-accounts/12345-compute@developer.gserviceaccount.com/scopes',
            ['https://www.googleapis.com/auth/cloud-platform', 'https://www.googleapis.com/auth/userinfo.email'])
  test_dir('instance/service-accounts/default', 'aliases\nemail\nscopes\ntoken\n')
  test_path('instance/service-accounts/default/aliases', ['default'])
  test_path('instance/service-accounts/default/email', '12345-compute@developer.gserviceaccount.com')
  test_path('instance/service-accounts/default/scopes',
            ['https://www.googleapis.com/auth/cloud-platform', 'https://www.googleapis.com/auth/userinfo.email'])
  test_path('instance/tags', ['a', 'b', 'c'], default='json')
  test_dir('instance/virtual-clock', 'drift-token\n')
  test_path('instance/virtual-clock/drift-token', '0')
  test_path('instance/zone', 'projects/12345/zones/us-central1-f')
  test_dir('project', 'attributes/\nnumeric-project-id\nproject-id\n')
  test_dir('project/attributes', 'my_project_key1\n')
  test_path('project/attributes/my_project_key1', 'my_project_value1')
  test_path('project/numeric-project-id', 12345)
  test_path('project/project-id', 'fake-project')

  # Test double slash
  test_path('project//project-id', 'fake-project')

  # Test access the access token format
  test_dir_recursive('instance/service-accounts/12345-compute@developer.gserviceaccount.com/token',
                     '{"access_token":"0123456789ABCDEF","expires_in":3000,"token_type":"Bearer"}',
                     test_trailing_slash=False,
                     use_recursive_field=False,
                     expect_metadata_header=False)
  test_dir_recursive('instance/service-accounts/12345-compute@developer.gserviceaccount.com/token',
                     '{"access_token":"0123456789ABCDEF","expires_in":3000,"token_type":"Bearer"}',
                     test_trailing_slash=False,
                     use_recursive_field=True,
                     expect_metadata_header=False)
  test_dir_recursive('instance/service-accounts/default/token',
                     '{"access_token":"0123456789ABCDEF","expires_in":3000,"token_type":"Bearer"}',
                     test_trailing_slash=False,
                     use_recursive_field=False,
                     expect_metadata_header=False)
  test_dir_recursive('instance/service-accounts/default/token',
                     '{"access_token":"0123456789ABCDEF","expires_in":3000,"token_type":"Bearer"}',
                     test_trailing_slash=False,
                     use_recursive_field=True,
                     expect_metadata_header=False)

  test_dir_recursive('instance/disks', '[{"deviceName":"boot","index":0,"mode":"READ_WRITE","type":"PERSISTENT"}]')
  test_dir_recursive('instance/disks/0', '{"deviceName":"boot","index":0,"mode":"READ_WRITE","type":"PERSISTENT"}')
  test_dir_recursive('instance/licenses', '[{"id":"0"}]')
  test_dir_recursive('instance/licenses/0', '{"id":"0"}')
  test_dir_recursive('instance/network-interfaces',
                     '[{"accessConfigs":[{"externalIp":"0.0.0.0","type":"ONE_TO_ONE_NAT"}],"forwardedIps":[],"ip":"0.0.0.0",'
                     '"ipAliases":[],"mac":"00:00:00:00:00:00","network":"projects/12345/networks/default"}]')
  test_dir_recursive('instance/network-interfaces/0',
                     '{"accessConfigs":[{"externalIp":"0.0.0.0","type":"ONE_TO_ONE_NAT"}],"forwardedIps":[],"ip":"0.0.0.0",'
                     '"ipAliases":[],"mac":"00:00:00:00:00:00","network":"projects/12345/networks/default"}')
  test_dir_recursive('instance/network-interfaces/0/access-configs', '[{"externalIp":"0.0.0.0","type":"ONE_TO_ONE_NAT"}]')
  test_dir_recursive('instance/network-interfaces/0/forwarded-ips', '[]')
  test_dir_recursive('instance/network-interfaces/0/ip-aliases', '[]')
  test_dir_recursive('instance/scheduling', '{"automaticRestart":"TRUE","onHostMaintenance":"MIGRATE","preemptible":"FALSE"}')
  test_dir_recursive('instance/service-accounts',
                     '{"12345-compute@developer.gserviceaccount.com":{"aliases":["default"],'
                     '"email":"12345-compute@developer.gserviceaccount.com",'
                     '"scopes":["https://www.googleapis.com/auth/cloud-platform","https://www.googleapis.com/auth/userinfo.email"]},'
                     '"default":{"aliases":["default"],"email":"12345-compute@developer.gserviceaccount.com",'
                     '"scopes":["https://www.googleapis.com/auth/cloud-platform","https://www.googleapis.com/auth/userinfo.email"]}}')
  test_dir_recursive('instance/service-accounts/12345-compute@developer.gserviceaccount.com',
                     '{"aliases":["default"],"email":"12345-compute@developer.gserviceaccount.com",'
                     '"scopes":["https://www.googleapis.com/auth/cloud-platform","https://www.googleapis.com/auth/userinfo.email"]}')
  test_dir_recursive('instance/service-accounts/default',
                     '{"aliases":["default"],"email":"12345-compute@developer.gserviceaccount.com",'
                     '"scopes":["https://www.googleapis.com/auth/cloud-platform","https://www.googleapis.com/auth/userinfo.email"]}')
  test_dir_recursive('instance/virtual-clock', '{"driftToken":"0"}')
  test_dir_recursive('project',
                     '{"attributes":{"my_project_key1":"my_project_value1"},"numericProjectId":12345,"projectId":"fake-project"}')
  test_dir_recursive('project/attributes', '{"my_project_key1":"my_project_value1"}')

  # Test a non-directory with recursive specified
  expect_content('project/numeric-project-id?recursive=true', '12345', common.content_type_text)
  expect_content('project/numeric-project-id?recursive=true&alt=text', '12345', common.content_type_text)
  expect_content('project/numeric-project-id?recursive=true&alt=json', '12345', common.content_type_json)

  # Make sure attributes that don't make sense are ignored.
  expect_content('instance/scheduling/automatic-restart?last_etag=abc&timeout_sec=5&foo=blah', 'TRUE', common.content_type_text)
  expect_content('instance/network-interfaces?recursive=xyz', '0/\n', common.content_type_text)

  # Verify that proper errors codes are returned
  expect_error('', 403, metadata_flavor_value='')
  expect_error('', 403, metadata_flavor_value='Something-Else')
  expect_error('instance', 403, metadata_flavor_value='')
  expect_error('instance', 403, metadata_flavor_value='Something-Else')
  expect_error('foo', 404)
  expect_error('instance/disks/x', 404)
  expect_error('instance/disks/99', 404)
  expect_error('instance/virtual-clock/drift-token/', 404)
  expect_error('project/bar', 404)
  expect_error('project?alt=json', 400)
  expect_error('project?alt=text', 400)
  expect_error('project?wait_for_change=true', 400)
  expect_error('instance/service-accounts/default/token/', 404)
  expect_error('instance/service-accounts/12345-compute@developer.gserviceaccount.com/scopes/0', 404)

  # Test timeout_sec
  start = datetime.datetime.now()
  expect_content('instance/scheduling/automatic-restart?wait_for_changes=true&timeout_sec=5', 'TRUE', common.content_type_text)
  end = datetime.datetime.now()
  elapsed = start - end
  if elapsed.seconds < 5:
    print "* Test failed: timeout_sec"
  else:
    print "Test passed: timeout_sec"

  print '\nError count: %s' % error_count
