#!/bin/bash

set -e

export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_gcloud-devel-service-account"

cd ..

# Build the libraries and run unit tests.
./build.sh

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh || true
./runintegrationtests.sh --retry || true
./runintegrationtests.sh --retry
