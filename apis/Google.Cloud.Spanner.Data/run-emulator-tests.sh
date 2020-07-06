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

# Check if we need to run
if ! git diff master --name-only | grep -iq spanner
then
  echo "Skipping Spanner integration tests; no Spanner-related changes."
  exit 0
fi

declare -r REPO_ROOT=$(readlink -f $(dirname ${BASH_SOURCE})/../..)

declare -r REPO_TMP=$REPO_ROOT/tmp
rm -rf $REPO_TMP
mkdir $REPO_TMP

export SPANNER_EMULATOR_HOST=localhost:9010
export TEST_PROJECT=emulator-test-project
echo "Running the Cloud Spanner emulator: $SPANNER_EMULATOR_HOST";

# Download the Google Cloud SDK and fetch the beta component which contains the
# emulator.
GOOGLE_CLOUD_SDK_VERSION=299.0.0
(cd $REPO_TMP \
 && wget https://dl.google.com/dl/cloudsdk/channels/rapid/downloads/google-cloud-sdk-${GOOGLE_CLOUD_SDK_VERSION}-linux-x86_64.tar.gz \
  -O gcloud.tgz \
 && tar zxf gcloud.tgz)

# Install the emulator.
export CLOUDSDK_CORE_DISABLE_PROMPTS=1
$REPO_TMP/google-cloud-sdk/bin/gcloud components install beta cloud-spanner-emulator

# Start the emulator.
declare -r REPO_GCLOUD=$REPO_TMP/google-cloud-sdk/bin/gcloud
$REPO_GCLOUD beta emulators spanner start &

EMULATOR_PID=$!

# When this shell exits, stop the emulator.
trap "kill -15 $EMULATOR_PID; echo \"Cleaned up the emulator\";" EXIT

$REPO_GCLOUD config set auth/disable_credentials true
$REPO_GCLOUD config set project ${TEST_PROJECT}
$REPO_GCLOUD config set api_endpoint_overrides/spanner http://localhost:9020/
$REPO_GCLOUD spanner instances create spannerintegration \
   --config=emulator-config --description="Test Instance" --nodes=1

# Run the tests.
cd $REPO_ROOT/apis/Google.Cloud.Spanner.Data
dotnet test Google.Cloud.Spanner.Data.IntegrationTests
dotnet test Google.Cloud.Spanner.Data.Snippets
