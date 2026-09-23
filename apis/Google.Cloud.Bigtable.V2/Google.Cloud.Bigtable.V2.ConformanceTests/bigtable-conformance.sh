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

# Navigate to the repo root directory
cd "$(dirname "$0")/../../.."

# Build the proxy
dotnet build apis/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.ConformanceTests

# Start the proxy in the background
dotnet run --no-build --project apis/Google.Cloud.Bigtable.V2/Google.Cloud.Bigtable.V2.ConformanceTests &
PROXY_PID=$!

# Ensure the proxy process is killed on exit
trap 'kill $PROXY_PID || true' EXIT

# Cookie, RetryInfo, ExecuteQuery, ReverseScans and FeatureGap are known failures of new features that we don't yet support.
# CloseClient we don't support as expected, but we support it in a valid manner.
# For the others we have issues to investigate, see comments in b/372509076 .
cd cloud-bigtable-clients-test/tests
go test -v -proxy_addr=:7238 -skip "_Retry_WithRoutingCookie|_Retry_WithRetryInfo|_CloseClient|_ReverseScans|TestFeatureGap|TestExecuteQuery|TestReadRows_Retry_LastScannedRow_Reverse|TestReadRow_Generic_DeadlineExceeded"
