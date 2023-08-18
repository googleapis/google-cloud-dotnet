#!/bin/bash

# Copyright 2018 Google LLC
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

set -e

if [ -f "${KOKORO_GFILE_DIR}/secret_manager/releasetool-publish-reporter-app" ]; then
    export APP_ID_PATH="${KOKORO_GFILE_DIR}/secret_manager/releasetool-publish-reporter-app"
    if [ -f "${KOKORO_GFILE_DIR}/secret_manager/releasetool-publish-reporter-googleapis-installation" ]; then
        export INSTALLATION_ID_PATH="${KOKORO_GFILE_DIR}/secret_manager/releasetool-publish-reporter-googleapis-installation"    
    elif [ -f "${KOKORO_GFILE_DIR}/secret_manager/releasetool-publish-reporter-googlecloudplatform-installation" ]; then
        export INSTALLATION_ID_PATH="${KOKORO_GFILE_DIR}/secret_manager/releasetool-publish-reporter-googlecloudplatform-installation"
    else
        echo 'Could not load GitHub installation ID from Secret Manager files.'
        exit 1
    fi
    export GITHUB_PRIVATE_KEY_PATH="${KOKORO_GFILE_DIR}/secret_manager/releasetool-publish-reporter-pem"
else
    echo 'Failure: Could not find GitHub installation credentials in Secret Manager files.'
    exit 1
fi

# Install an exit hook to report status.
releasetool_finish_report() {
    rv=$?
    if [[ $rv == 0 ]]; then
        dotnet run --project ../tools/Google.Cloud.Tools.ReleaseProgressReporter finish true || true
    else
        dotnet run --project ../tools/Google.Cloud.Tools.ReleaseProgressReporter finish false || true
    fi
    echo "Release status reported."
    exit $rv
}

trap releasetool_finish_report EXIT

# Report the start of a build
dotnet run --project ../tools/Google.Cloud.Tools.ReleaseProgressReporter start || true
