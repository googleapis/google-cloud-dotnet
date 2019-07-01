# Copyright 2019 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     https://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

import json
import sys
import argparse

parser = argparse.ArgumentParser(description='List APIs in the catalog')
parser.add_argument('file', help='File to load')
parser.add_argument('--field', default='id', help='Field to find and output')
parser.add_argument('--test', help='Field (with optional value) to match; defaults to field to output')
args = parser.parse_args()

if not args.test:
  args.test = args.field

test_parts = args.test.split('=', 2)
test_field = test_parts[0]
if len(test_parts) == 1:
	matcher = lambda value : value
else:
	matcher = lambda value : value == test_parts[1]

filename = sys.argv[1]
file = open(filename, "r") 
catalog = json.load(file)

fields = [api.get(args.field) for api in catalog if matcher(api.get(test_field))]
print(*fields)
