#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
ROOT_DIR=$(dirname "$SCRIPT")

cd $ROOT_DIR
cd ..

export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_gcloud-devel-service-account"

# Build the libraries and run unit tests.
./build.sh

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh || true
./runintegrationtests.sh --retry || true
./runintegrationtests.sh --retry
