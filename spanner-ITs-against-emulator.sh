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

# Download the Google Cloud SDK and fetch the beta component which contains the
# emulator.
GOOGLE_CLOUD_SDK_VERSION=299.0.0
wget https://dl.google.com/dl/cloudsdk/channels/rapid/downloads/google-cloud-sdk-${GOOGLE_CLOUD_SDK_VERSION}-linux-x86_64.tar.gz
tar zxvf google-cloud-sdk-${GOOGLE_CLOUD_SDK_VERSION}-linux-x86_64.tar.gz

export CLOUDSDK_CORE_DISABLE_PROMPTS=1
./google-cloud-sdk/bin/gcloud config set disable_usage_reporting false
./google-cloud-sdk/bin/gcloud components install beta cloud-spanner-emulator

# Start the emulator.
./google-cloud-sdk/bin/gcloud beta emulators spanner start &

EMULATOR_PID=$!

# When this shell exits, stop the emulator.
trap "kill -- -$(ps -o pgid= $EMULATOR_PID | grep -o '[0-9]*'); echo \"Cleaned up the emulator\";" EXIT

./google-cloud-sdk/bin/gcloud config set auth/disable_credentials true
./google-cloud-sdk/bin/gcloud config set project ${TEST_PROJECT}
./google-cloud-sdk/bin/gcloud config set api_endpoint_overrides/spanner http://localhost:9020/
./google-cloud-sdk/bin/gcloud spanner instances create spannerintegration \
   --config=emulator-config --description="Test Instance" --nodes=1

# Run the tests.
cd apis/Google.Cloud.Spanner.Data
dotnet test Google.Cloud.Spanner.Data.IntegrationTests
dotnet test Google.Cloud.Spanner.Data.Snippets
