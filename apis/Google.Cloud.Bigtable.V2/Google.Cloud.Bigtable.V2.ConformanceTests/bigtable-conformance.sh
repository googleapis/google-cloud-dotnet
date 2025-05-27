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

#!/bin/bash

set -eo pipefail

## cd to the parent directory, i.e. the root of the git repo
cd ./

RETURN_CODE=0

# Build the proxy
pushd .
cd apis/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.ConformanceTests
dotnet build
# Start the proxy in a separate process
dotnet run &
popd

pushd .
cd cloud-bigtable-clients-test/tests
# Cookie, RetryInfo, ExecuteQuery, ReverseScans and FeatureGap are known failures of new features that we don't yet support.
# CloseClient we don't support as expected, but we support it in a valid manner.
# For the others we have issues to investigate, see comments in b/372509076 .
eval "go test -v -proxy_addr=:7238 -skip _Retry_WithRoutingCookie\|_Retry_WithRetryInfo\|_CloseClient\|_ReverseScans\|TestFeatureGap\|TestExecuteQuery\|TestReadRows_Retry_LastScannedRow_Reverse"
returnCode=$?
popd

if [[ ${returnCode} -gt 0 ]]
then
  echo "Conformance test failed"
  RETURN_CODE=${returnCode}
else
  echo "Conformance test passed"
fi

exit ${RETURN_CODE}