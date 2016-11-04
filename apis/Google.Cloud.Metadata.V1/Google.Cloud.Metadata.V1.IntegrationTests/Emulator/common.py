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

content_type = 'Content-Type'
content_type_html = 'text/html; charset=UTF-8'
content_type_json = 'application/json'
content_type_text = 'application/text'
etag = 'ETag'
host_environment_variable = 'METADATA_EMULATOR_HOST'
metadata_flavor = 'Metadata-Flavor'
metadata_flavor_google = 'Google'
server = 'Server'
server_value = 'Metadata Server Emulator'

# Converts a value-like-this to a valueLikeThis
def convertToCamelCase(original):
  temp = ''.join(x.capitalize() for x in original.split('-'))
  return (temp[0].lower() + temp[1:]) if temp else ''

# Converts a valueLikeThis to a value-like-this
def convertToDashed(value):
  return ''.join(('-' + c.lower() if c.isupper() else c) for c in value)
