#!/bin/bash
# Copyright 2025 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#      http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

set -eo pipefail

## Get the directory of the build script
scriptDir=$(realpath $(dirname "${BASH_SOURCE[0]}"))
## cd to the parent directory, i.e. the root of the git repo
cd ${scriptDir}/..

set +e

# Build the proxy
pushd .
cd apis/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.ConformanceTests
dotnet build
# Start the proxy in a separate process
dotnet run &

# Run the conformance test
echo "Testing the client with all optional features enabled..."
configFlag="--enable_features_all"
popd

pushd .
cd cloud-bigtable-clients-test/tests
eval "go test -v -proxy_addr=:7238 ${configFlag} -skip '`cat ../../apis/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.ConformanceTests/known_failures.txt`'"
returnCode=$?
popd

# Stop the proxy
kill ${proxyPID}

if [[ ${returnCode} -gt 0 ]]
then
  echo "Conformance test failed for config: ${config}"
  RETURN_CODE=${returnCode}
else
  echo "Conformance test passed for config: ${config}"
fi

exit ${RETURN_CODE}