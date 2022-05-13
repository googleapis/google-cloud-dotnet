#!/bin/bash

# Copyright 2020 Google LLC
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
# limitations under the License..

# Fail on any error.
set -e

export SPANNER_EMULATOR_HOST=localhost:9010
export TEST_PROJECT=emulator-test-project

echo "Running the Cloud Spanner emulator: $SPANNER_EMULATOR_HOST";

# Start the emulator.
gcloud emulators spanner start &

EMULATOR_PID=$!
# When this shell exits, stop the emulator.
trap "kill -15 $EMULATOR_PID; echo \"Cleaned up the emulator\";" EXIT

# Run the tests.
dotnet test -c Release Google.Cloud.Spanner.Data.IntegrationTests --filter FullyQualifiedName!~PostgreSql
dotnet test -c Release Google.Cloud.Spanner.Data/Google.Cloud.Spanner.Data.Snippets