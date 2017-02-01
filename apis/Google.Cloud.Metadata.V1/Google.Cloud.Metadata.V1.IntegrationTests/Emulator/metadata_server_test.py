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
import common, datetime, json, os, threading, time, urllib, urllib2

# These tests can be run with pytest: http://doc.pytest.org/en/latest/index.html

try:
  server_address = 'http://' + os.environ[common.host_environment_variable]
except KeyError:
  raise Exception('%s must be set' % common.host_environment_variable)

request_template = server_address + '/computeMetadata/v1/{}'
update_template = server_address + '/emulator/v1/update/{}'

def check_header(headers, key, value):
  assert headers.get(key.lower()) == value

def expect_content_absolute(url, expected, expected_content_type, expect_metadata_header=True):
  request = urllib2.Request(url, headers={common.metadata_flavor : common.metadata_flavor_google})
  try:
    response = urllib2.urlopen(request)
  except urllib2.URLError as e:
    raise Exception('Error connecting to emulator at %s - %s' % (server_address, e))

  headers = response.info().dict

  if expect_metadata_header:
    check_header(headers, common.metadata_flavor, common.metadata_flavor_google)
  else:
    assert common.metadata_flavor.lower() not in headers

  check_header(headers, common.server, common.server_value)
  check_header(headers, common.content_type, expected_content_type)
  
  contents = response.read()
  assert expected == contents

  return headers.get(common.etag.lower())

def expect_content(path, expected, expected_content_type, expect_metadata_header=True):
  return expect_content_absolute(request_template.format(path),
                                 expected,
                                 expected_content_type,
                                 expect_metadata_header)

def expect_error(path, expected_code, metadata_flavor_value=common.metadata_flavor_google):
  url = request_template.format(path)
  request = urllib2.Request(url,
                            headers={common.metadata_flavor :
                                     metadata_flavor_value} if metadata_flavor_value else {})
  try:
    response = urllib2.urlopen(request)
    # This will always fail but I'm asserting so the response appears in the test results
    assert response.read() is None
  except urllib2.HTTPError as e:
    check_header(e.headers, common.metadata_flavor, common.metadata_flavor_google)
    check_header(e.headers, common.server, common.server_value)
    check_header(e.headers, common.content_type, common.content_type_html)
    assert e.code == expected_code
  except urllib2.URLError as e:
    raise Exception('Error connecting to emulator at %s - %s' % (server_address, e))

def expect_error_deleting_content(path, expected_code):
  request = urllib2.Request(url = update_template.format(path),
                            headers={common.metadata_flavor: common.metadata_flavor_google})
  request.get_method = lambda: "DELETE"
  try:
    response = urllib2.urlopen(request)
    # This will always fail but I'm asserting so the response appears in the test results
    assert response.read() is None
  except urllib2.HTTPError as e:
    check_header(e.headers, common.metadata_flavor, common.metadata_flavor_google)
    check_header(e.headers, common.server, common.server_value)
    check_header(e.headers, common.content_type, common.content_type_html)
    assert e.code == expected_code
  except urllib2.URLError as e:
    raise Exception('Error connecting to emulator at %s - %s' % (server_address, e))

def expect_error_updating_content(path, new_data, expected_code):
  if not isinstance(new_data, str):
    new_data = json.dumps(new_data, separators=(',', ':'))

  data = urllib.quote_plus(new_data)
  request = urllib2.Request(update_template.format(path),
                            data,
                            headers={common.metadata_flavor: common.metadata_flavor_google,
                                     common.content_type: common.content_type_text})
  
  try:
    response = urllib2.urlopen(request)
    # This will always fail but I'm asserting so the response appears in the test results
    assert response.read() is None
  except urllib2.HTTPError as e:
    check_header(e.headers, common.metadata_flavor, common.metadata_flavor_google)
    check_header(e.headers, common.server, common.server_value)
    check_header(e.headers, common.content_type, common.content_type_html)
    assert e.code == expected_code
  except urllib2.URLError as e:
    raise Exception('Error connecting to emulator at %s - %s' % (server_address, e))

def check_path(path, expected, default='text'):
  expected_json = json.dumps(expected, separators=(',', ':'))
  if isinstance(expected, list):
    expected_text = ''.join(s + '\n' for s in expected)
  else:
    expected_text = unicode(expected)
    
  etag1 = expect_content(path,
                         expected_text if default == 'text' else expected_json,
                         common.content_type_text if default == 'text' else common.content_type_json)
  etag2 = expect_content(path + "?alt=text", expected_text, common.content_type_text)
  etag3 = expect_content(path + "?alt=json", expected_json, common.content_type_json) 
  assert len(etag1) == 16
  assert etag1 == etag2
  assert etag1 == etag3

def check_dir(path, expected):
  etag1 = expect_content(path, expected, common.content_type_text)
  assert len(etag1) == 16
  if path:
    etag2 = expect_content(path + '/', expected, common.content_type_text)
    assert etag1 == etag2

def check_dir_absolute(url, expected):
  etag1 = expect_content_absolute(url, expected, common.content_type_text)
  etag2 = expect_content_absolute(url + '/', expected, common.content_type_text)
  assert len(etag1) == 16
  assert etag1 == etag2

def check_dir_recursive(path, expected, test_trailing_slash=True, use_recursive_field=True, expect_metadata_header=True):
  query = '?recursive=true' if use_recursive_field else ''
  etag1 = expect_content(path + query, expected, common.content_type_json, expect_metadata_header)
  if test_trailing_slash:
    etag2 = expect_content(path + '/' + query, expected, common.content_type_json, expect_metadata_header)
  else:
    etag2 = etag1

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
  etag3 = expect_content(path + query, expected_text, common.content_type_text, expect_metadata_header)
  if test_trailing_slash:
    etag4 = expect_content(path + '/' + query, expected_text, common.content_type_text, expect_metadata_header)
  else:
    etag4 = etag3
  
  query = '?recursive=true&alt=json' if use_recursive_field else '?alt=json'
  etag5 = expect_content(path + query, expected, common.content_type_json, expect_metadata_header)
  if test_trailing_slash:
    etag6 = expect_content(path + '/' + query, expected, common.content_type_json, expect_metadata_header)
  else:
    etag6 = etag5

  assert len(etag1) == 16
  assert etag1 == etag2
  assert etag1 == etag3
  assert etag1 == etag4
  assert etag1 == etag5
  assert etag1 == etag6

def delete_content(path):
  request = urllib2.Request(update_template.format(path),
                            headers={common.metadata_flavor: common.metadata_flavor_google})
  request.get_method = lambda: "DELETE"
  try:
    urllib2.urlopen(request)
  except urllib2.URLError as e:
    raise Exception('Error connecting to emulator at %s - %s' % (server_address, e))

def update_content(path, new_data):
  if not isinstance(new_data, str):
    new_data = json.dumps(new_data, separators=(',', ':'))

  data = urllib.quote_plus(new_data)
  request = urllib2.Request(update_template.format(path),
                            data,
                            headers={common.metadata_flavor: common.metadata_flavor_google,
                                     common.content_type: common.content_type_text})
  
  try:
    urllib2.urlopen(request)
  except urllib2.URLError as e:
    raise Exception('Error connecting to emulator at %s - %s' % (server_address, e))

def test_root():
  check_dir_absolute(server_address, '0.1/\ncomputeMetadata/\n')

def test_root_computeMetadata():
  check_dir_absolute(server_address + '/computeMetadata', 'v1/\nv1beta1/\n')

def test_root_computeMetadata_v1():
  check_dir('', 'instance/\nproject/\n')

def test_instance():
  check_dir('instance', 'attributes/\ncpu-platform\ndescription\ndisks/\nhostname\nid\nimage\nlicenses/\nmachine-type\n'
            'maintenance-event\nnetwork-interfaces/\nscheduling/\nservice-accounts/\ntags\nvirtual-clock/\nzone\n')

def test_instance_attributes():
  check_dir('instance/attributes', 'my_instance_key1\n')

def test_instance_attributes_myinstancekey1():
  check_path('instance/attributes/my_instance_key1', 'my_instance_value1')

def test_instance_cpuplatform():
  check_path('instance/cpu-platform', 'Intel Haswell')

def test_instance_description():
  check_path('instance/description', 'Fake instance for metadata server emulator')

def test_instance_disks():
  check_dir('instance/disks', '0/\n')

def test_instance_disks_0():
  check_dir('instance/disks/0', 'device-name\nindex\nmode\ntype\n')

def test_instance_disks_0_devicename():
  check_path('instance/disks/0/device-name', 'boot')

def test_instance_disks_0_index():
  check_path('instance/disks/0/index', 0)

def test_instance_disks_0_mode():
  check_path('instance/disks/0/mode', 'READ_WRITE')

def test_instance_disks_0_type():
  check_path('instance/disks/0/type', 'PERSISTENT')

def test_instance_hostname():
  check_path('instance/hostname', 'name.project.google.com.internal')

def test_instance_id():
  check_path('instance/id', 13512546227574112017)

def test_instance_image():
  check_path('instance/image', '')

def test_instance_licenses():
  check_dir('instance/licenses', '0/\n1/\n2/\n')

def test_instance_licenses_0():
  check_dir('instance/licenses/0', 'id\n')

def test_instance_licenses_0_id():
  check_path('instance/licenses/0/id', '0')

def test_instance_machinetype():
  check_path('instance/machine-type', 'projects/12345/machineTypes/n1-standard-1')

def test_instance_maintenanceevent():
  check_path('instance/maintenance-event', 'NONE')

def test_instance_networkinterfaces():
  check_dir('instance/network-interfaces', '0/\n')

def test_instance_networkinterfaces_0():
  check_dir('instance/network-interfaces/0', 'access-configs/\nforwarded-ips/\nip\nip-aliases/\nmac\nnetwork\n')

def test_instance_networkinterfaces_0_accessconfigs():
  check_dir('instance/network-interfaces/0/access-configs', '0/\n')

def test_instance_networkinterfaces_0_accessconfigs_0():
  check_dir('instance/network-interfaces/0/access-configs/0', 'external-ip\ntype\n')

def test_instance_networkinterfaces_0_accessconfigs_0_externalip():
  check_path('instance/network-interfaces/0/access-configs/0/external-ip', '0.0.0.0')

def test_instance_networkinterfaces_0_accessconfigs_0_type():
  check_path('instance/network-interfaces/0/access-configs/0/type', 'ONE_TO_ONE_NAT')

def test_instance_networkinterfaces_0_forwardedips():
  check_dir('instance/network-interfaces/0/forwarded-ips', '')

def test_instance_networkinterfaces_0_ip():
  check_path('instance/network-interfaces/0/ip', '0.0.0.0')

def test_instance_networkinterfaces_0_ipaliases():
  check_dir('instance/network-interfaces/0/ip-aliases', '')

def test_instance_networkinterfaces_0_mac():
  check_path('instance/network-interfaces/0/mac', '00:00:00:00:00:00')

def test_instance_networkinterfaces_0_network():
  check_path('instance/network-interfaces/0/network', 'projects/12345/networks/default')

def test_instance_scheduling():
  check_dir('instance/scheduling', 'automatic-restart\non-host-maintenance\npreemptible\n')

def test_instance_scheduling_automaticrestart():
  check_path('instance/scheduling/automatic-restart', 'TRUE')

def test_instance_scheduling_onhostmaintenance():
  check_path('instance/scheduling/on-host-maintenance', 'MIGRATE')

def test_instance_scheduling_preemptible():
  check_path('instance/scheduling/preemptible', 'FALSE')

def test_instance_serviceaccounts():
  check_dir('instance/service-accounts', '12345-compute@developer.gserviceaccount.com/\ndefault/\n')

def test_instance_serviceaccounts_0():
  check_dir('instance/service-accounts/12345-compute@developer.gserviceaccount.com', 'aliases\nemail\nscopes\ntoken\n')

def test_instance_serviceaccounts_0_aliases():
  check_path('instance/service-accounts/12345-compute@developer.gserviceaccount.com/aliases', ['default'])

def test_instance_serviceaccounts_0_email():
  check_path('instance/service-accounts/12345-compute@developer.gserviceaccount.com/email',
             '12345-compute@developer.gserviceaccount.com')

def test_instance_serviceaccounts_0_scopes():
  check_path('instance/service-accounts/12345-compute@developer.gserviceaccount.com/scopes',
             ['https://www.googleapis.com/auth/cloud-platform', 'https://www.googleapis.com/auth/userinfo.email'])

def test_instance_serviceaccounts_default():
  check_dir('instance/service-accounts/default', 'aliases\nemail\nscopes\ntoken\n')

def test_instance_serviceaccounts_default_aliases():
  check_path('instance/service-accounts/default/aliases', ['default'])

def test_instance_serviceaccounts_default_email():
  check_path('instance/service-accounts/default/email', '12345-compute@developer.gserviceaccount.com')

def test_instance_serviceaccounts_default_scopes():
  check_path('instance/service-accounts/default/scopes',
             ['https://www.googleapis.com/auth/cloud-platform', 'https://www.googleapis.com/auth/userinfo.email'])

def test_instance_tags():
  check_path('instance/tags', ['a', 'b', 'c'], default='json')

def test_instance_virtualclock():
  check_dir('instance/virtual-clock', 'drift-token\n')

def test_instance_virtualclock_drifttoken():
  check_path('instance/virtual-clock/drift-token', '0')

def test_instance_zone():
  check_path('instance/zone', 'projects/12345/zones/us-central1-f')

def test_project():
  check_dir('project', 'attributes/\nnumeric-project-id\nproject-id\n')

def test_project_attributes():
  check_dir('project/attributes', 'my_project_key1\n')

def test_project_attributes_myprojectkey1():
  check_path('project/attributes/my_project_key1', 'my_project_value1')

def test_project_numericprojectid():
  check_path('project/numeric-project-id', 12345)

def test_project_projectid():
  check_path('project/project-id', 'fake-project')

def test_double_slash():
  check_path('project//project-id', 'fake-project')

def test_recursive_token_1():
  check_dir_recursive('instance/service-accounts/12345-compute@developer.gserviceaccount.com/token',
                      '{"access_token":"0123456789ABCDEF","expires_in":3000,"token_type":"Bearer"}',
                      test_trailing_slash=False,
                      use_recursive_field=False,
                      expect_metadata_header=False)

def test_recursive_token_2():
  check_dir_recursive('instance/service-accounts/12345-compute@developer.gserviceaccount.com/token',
                      '{"access_token":"0123456789ABCDEF","expires_in":3000,"token_type":"Bearer"}',
                      test_trailing_slash=False,
                      use_recursive_field=True,
                      expect_metadata_header=False)

def test_recursive_token_3():
  check_dir_recursive('instance/service-accounts/default/token',
                      '{"access_token":"0123456789ABCDEF","expires_in":3000,"token_type":"Bearer"}',
                      test_trailing_slash=False,
                      use_recursive_field=False,
                      expect_metadata_header=False)

def test_recursive_token_4():
  check_dir_recursive('instance/service-accounts/default/token',
                      '{"access_token":"0123456789ABCDEF","expires_in":3000,"token_type":"Bearer"}',
                      test_trailing_slash=False,
                      use_recursive_field=True,
                      expect_metadata_header=False)

def test_recursive_instance_attributes():
  check_dir_recursive('instance/attributes', '{"my_instance_key1":"my_instance_value1"}')

def test_recursive_instance_disks():
  check_dir_recursive('instance/disks', '[{"deviceName":"boot","index":0,"mode":"READ_WRITE","type":"PERSISTENT"}]')

def test_recursive_instance_disks_0():
  check_dir_recursive('instance/disks/0', '{"deviceName":"boot","index":0,"mode":"READ_WRITE","type":"PERSISTENT"}')

def test_recursive_instance_licenses():
  check_dir_recursive('instance/licenses', '[{"id":"0"},{"id":"1"},{"id":"2"}]')

def test_recursive_instance_licenses_0():
  check_dir_recursive('instance/licenses/0', '{"id":"0"}')

def test_recursive_instance_networkinterfaces():
  check_dir_recursive('instance/network-interfaces',
                      '[{"accessConfigs":[{"externalIp":"0.0.0.0","type":"ONE_TO_ONE_NAT"}],"forwardedIps":[],"ip":"0.0.0.0",'
                      '"ipAliases":[],"mac":"00:00:00:00:00:00","network":"projects/12345/networks/default"}]')

def test_recursive_instance_networkinterfaces_0():
  check_dir_recursive('instance/network-interfaces/0',
                      '{"accessConfigs":[{"externalIp":"0.0.0.0","type":"ONE_TO_ONE_NAT"}],"forwardedIps":[],"ip":"0.0.0.0",'
                      '"ipAliases":[],"mac":"00:00:00:00:00:00","network":"projects/12345/networks/default"}')

def test_recursive_instance_networkinterfaces_0_accessconfigs():
  check_dir_recursive('instance/network-interfaces/0/access-configs', '[{"externalIp":"0.0.0.0","type":"ONE_TO_ONE_NAT"}]')

def test_recursive_instance_networkinterfaces_0_forwardedips():
  check_dir_recursive('instance/network-interfaces/0/forwarded-ips', '[]')

def test_recursive_instance_networkinterfaces_0_ipaliases():
  check_dir_recursive('instance/network-interfaces/0/ip-aliases', '[]')

def test_recursive_instance_scheduling():
  check_dir_recursive('instance/scheduling', '{"automaticRestart":"TRUE","onHostMaintenance":"MIGRATE","preemptible":"FALSE"}')

def test_recursive_instance_serviceaccounts():
  check_dir_recursive('instance/service-accounts',
                      '{"12345-compute@developer.gserviceaccount.com":{"aliases":["default"],'
                      '"email":"12345-compute@developer.gserviceaccount.com",'
                      '"scopes":["https://www.googleapis.com/auth/cloud-platform","https://www.googleapis.com/auth/userinfo.email"]},'
                      '"default":{"aliases":["default"],"email":"12345-compute@developer.gserviceaccount.com",'
                      '"scopes":["https://www.googleapis.com/auth/cloud-platform","https://www.googleapis.com/auth/userinfo.email"]}}')

def test_recursive_instance_serviceaccounts_1():
  check_dir_recursive('instance/service-accounts/12345-compute@developer.gserviceaccount.com',
                      '{"aliases":["default"],"email":"12345-compute@developer.gserviceaccount.com",'
                      '"scopes":["https://www.googleapis.com/auth/cloud-platform","https://www.googleapis.com/auth/userinfo.email"]}')

def test_recursive_instance_serviceaccounts_2():
  check_dir_recursive('instance/service-accounts/default',
                      '{"aliases":["default"],"email":"12345-compute@developer.gserviceaccount.com",'
                      '"scopes":["https://www.googleapis.com/auth/cloud-platform","https://www.googleapis.com/auth/userinfo.email"]}')

def test_recursive_instance_virtualclock():
  check_dir_recursive('instance/virtual-clock', '{"driftToken":"0"}')

def test_recursive_project():
  check_dir_recursive('project',
                     '{"attributes":{"my_project_key1":"my_project_value1"},"numericProjectId":12345,"projectId":"fake-project"}')

def test_recursive_project_attributes():
  check_dir_recursive('project/attributes', '{"my_project_key1":"my_project_value1"}')

def test_recursive_value():
  expect_content('project/numeric-project-id?recursive=true', '12345', common.content_type_text)

def test_recursive_value_alt_1():
  expect_content('project/numeric-project-id?recursive=true&alt=text', '12345', common.content_type_text)

def test_recursive_value_alt_2():
  expect_content('project/numeric-project-id?recursive=true&alt=json', '12345', common.content_type_json)

def test_ignore_nonsense_parameters():
  expect_content('instance/scheduling/automatic-restart?last_etag=abc&timeout_sec=5&foo=blah', 'TRUE', common.content_type_text)

def test_ignore_nonsense_values():
  expect_content('instance/network-interfaces?recursive=xyz', '0/\n', common.content_type_text)

def test_error_no_metadata_flavor_1():
  expect_error('', 403, metadata_flavor_value='')

def test_error_wrong_metadata_flavor_1():
  expect_error('', 403, metadata_flavor_value='Something-Else')

def test_error_no_metadata_flavor_2():
  expect_error('instance', 403, metadata_flavor_value='')

def test_error_wrong_metadata_flavor_2():
  expect_error('instance', 403, metadata_flavor_value='Something-Else')

def test_error_bad_index_1():
  expect_error('instance/disks/x', 404)

def test_error_bad_index_2():
  expect_error('instance/disks/99', 404)

def test_error_slash_on_value():
  expect_error('instance/virtual-clock/drift-token/', 404)

def test_error_bad_key_1():
  expect_error('foo', 404)

def test_error_bad_key_2():
  expect_error('project/bar', 404)

def test_error_alt_on_dir_1():
  expect_error('project?alt=json', 400)

def test_error_alt_on_dir_2():
  expect_error('project?alt=text', 400)

def test_error_wait_on_dir_without_recursive():
  expect_error('project?wait_for_change=true', 400)

def test_error_slash_on_token():
  expect_error('instance/service-accounts/default/token/', 404)

def test_error_index_into_array_value():
  expect_error('instance/service-accounts/12345-compute@developer.gserviceaccount.com/scopes/0', 404)

def test_timeout_sec():
  start = datetime.datetime.now()
  expect_content('instance/scheduling/automatic-restart?wait_for_change=true&timeout_sec=5', 'TRUE', common.content_type_text)
  end = datetime.datetime.now()
  elapsed = end - start
  assert elapsed.seconds > 5

def test_update_string():
  path = 'instance/cpu-platform'
  original = 'Intel Haswell'
  changed = 'My Platform'

  check_path(path, original)
  update_content(path, changed)
  try:
    check_path(path, changed)
  finally:
    update_content(path, original)

def test_update_int():
  path = 'instance/id'
  original = 13512546227574112017
  changed = 43985743985

  check_path(path, original)
  update_content(path, changed)
  try:
    check_path(path, changed)
  finally:
    update_content(path, original)

def test_update_indexed_list():
  path = 'instance/licenses'
  original = [
      {
        "id": "0"
      },
      {
        "id": "1"
      },
      {
        "id": "2"
      }
    ]
  changed = [
      {
        "id": "42"
      },
      {
        "id": "43587"
      }
    ]

  check_dir_recursive(path, json.dumps(original, separators=(',', ':')))
  update_content(path, changed)
  try:
    check_dir_recursive(path, json.dumps(changed, separators=(',', ':')))
  finally:
    update_content(path, original)

def test_update_list():
  path = 'instance/tags'
  original = ['a', 'b', 'c']
  changed = ['tag1', 'tag2']

  check_path(path, original, default='json')
  update_content(path, changed)
  try:
    check_path(path, changed, default='json')
  finally:
    update_content(path, original)

def test_update_directory():
  path = 'instance/attributes'
  original = {'my_instance_key1':
              'my_instance_value1'}
  changed = {'abc': 'value1',
             'xyz': 'value2'}

  check_dir_recursive(path, json.dumps(original, separators=(',', ':')))
  update_content(path, changed)
  try:
    check_dir_recursive(path, json.dumps(changed, separators=(',', ':')))
  finally:
    update_content(path, original)

def test_update_invalid_value():
  path = 'instance/attributes'
  changed = {'abc': 'value1',
             'complex' : { 'foo': 'bar' },
             'xyz': 'value2'}
  expect_error_updating_content(path, changed, 400)

def test_etags_differ_based_on_recursive():
  etag1 = expect_content('instance/disks?recursive=true',
                         '[{"deviceName":"boot","index":0,"mode":"READ_WRITE","type":"PERSISTENT"}]',
                         common.content_type_json)
  etag2 = expect_content('instance/disks',
                         '0/\n',
                         common.content_type_text)
  assert etag1 != etag2

def test_etag_reverts_when_original_value_restored():
  path = 'instance/cpu-platform'
  original = 'Intel Haswell'
  changed = 'My Platform'

  etag1 = expect_content(path, original, common.content_type_text)
  update_content(path, changed)
  try:
    etag2 = expect_content(path, changed, common.content_type_text)
    assert etag1 != etag2
  finally:
    update_content(path, original)

  etag3 = expect_content(path, original, common.content_type_text)
  assert etag1 == etag3

def test_wait_for_change():
  path = 'instance/cpu-platform'
  original = 'Intel Haswell'
  changed = 'My Platform'

  def changeData():
    time.sleep(1)
    update_content(path, changed)
    update_content(path, original)

  thread = threading.Thread(target=changeData)
  thread.start()
  expect_content(path + '?wait_for_change=true&timeout_sec=5', changed, common.content_type_text)
  thread.join()

def test_wait_for_change_on_descendant():
  path = 'instance/disks'
  descendant_path = 'instance/disks/0/device-name'
  original = 'boot'
  changed = 'My Custom Disk'

  def changeData():
    time.sleep(1)
    update_content(descendant_path, changed)
    update_content(descendant_path, original)

  thread = threading.Thread(target=changeData)
  thread.start()
  expect_content(path + '?recursive=True&wait_for_change=true&timeout_sec=5',
                 '[{"deviceName":"My Custom Disk","index":0,"mode":"READ_WRITE","type":"PERSISTENT"}]',
                 common.content_type_json)
  thread.join()

def test_wait_for_change_on_delete():
  path = 'instance/attributes'
  original = {'my_instance_key1':
              'my_instance_value1'}

  def changeData():
    time.sleep(1)
    delete_content(path + '/my_instance_key1')
    update_content(path, original)

  thread = threading.Thread(target=changeData)
  thread.start()
  expect_content(path + '?recursive=True&wait_for_change=true&timeout_sec=5', '{}', common.content_type_json)
  thread.join()

def test_last_etag_match():
  path = 'instance/cpu-platform'
  original = 'Intel Haswell'
  changed = 'My Platform'
  etag1 = expect_content(path, original, common.content_type_text)

  def changeData():
    time.sleep(1)
    update_content(path, changed)
    update_content(path, original)

  thread = threading.Thread(target=changeData)

  thread.start()
  etag2 = expect_content(path + '?wait_for_change=true&last_etag=%s&timeout_sec=5' % etag1,
                         changed,
                         common.content_type_text)
  assert etag1 != etag2
  thread.join()

def test_last_etag_non_match():
  path = 'instance/cpu-platform'
  original = 'Intel Haswell'
  changed = 'My Platform'

  etag1 = expect_content(path, original, common.content_type_text)
  update_content(path, changed)
  try:
    start = datetime.datetime.now()
    etag2 = expect_content(path + '?wait_for_change=true&last_etag=%s&timeout_sec=5' % etag1,
                           changed,
                           common.content_type_text)
    end = datetime.datetime.now()
    elapsed = end - start
    assert elapsed.seconds < 5
    assert etag1 != etag2
  finally:
    update_content(path, original)

def test_add_value():
  update_content('instance/attributes/foo', 'bar')
  try:
    check_dir_recursive('instance/attributes', '{"my_instance_key1":"my_instance_value1","foo":"bar"}')
  finally:
    update_content('instance/attributes', '{"my_instance_key1":"my_instance_value1"}')

def test_add_key_with_dashes():
  update_content('instance/attributes/foo-bar', 'baz')
  try:
    check_dir_recursive('instance/attributes', '{"my_instance_key1":"my_instance_value1","foo-bar":"baz"}')
  finally:
    update_content('instance/attributes', '{"my_instance_key1":"my_instance_value1"}')

def test_add_value_invalid():
  expect_error_updating_content('instance/foo', 'bar', 400)

def test_delete_content():
  delete_content('instance/attributes/my_instance_key1')
  try:
    check_dir_recursive('instance/attributes', '{}')
  finally:
    update_content('instance/attributes', '{"my_instance_key1":"my_instance_value1"}')

def test_delete_list_item():
  path = 'instance/licenses'
  original = [
      {
        "id": "0"
      },
      {
        "id": "1"
      },
      {
        "id": "2"
      }
    ]
  changed = [
      {
        "id": "0"
      },
      {
        "id": "2"
      }
    ]
  check_dir_recursive(path, json.dumps(original, separators=(',', ':')))
  delete_content(path + '/1')
  try:
    check_dir_recursive(path, json.dumps(changed, separators=(',', ':')))
  finally:
    update_content(path, original)

def test_delete_value_invalid():
  expect_error_deleting_content('instance/attributes', 400)
