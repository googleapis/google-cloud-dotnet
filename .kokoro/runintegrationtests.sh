#!/bin/bash

set -e

# Script entry point
SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

source $SCRIPT_DIR/populatesecrets.sh

populate_all_secrets
export GOOGLE_APPLICATION_CREDENTIALS="$SECRETS_LOCATION/cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$SECRETS_LOCATION/gcloud-devel-service-account"

export TEST_UNIVERSE_DOMAIN_CREDENTIAL=$(realpath $SECRETS_LOCATION/client-library-test-universe-domain-credential)
export TEST_UNIVERSE_DOMAIN=$(cat $SECRETS_LOCATION/client-library-test-universe-domain)
export TEST_UNIVERSE_PROJECT_ID=$(cat $SECRETS_LOCATION/client-library-test-universe-project-id)
export TEST_UNIVERSE_LOCATION=$(cat $SECRETS_LOCATION/client-library-test-universe-storage-location)

echo "Cloning submodules"
git submodule init
git submodule update

# Specify RUN_FOR_APIS when manually triggering Kokoro to run tests only on a set of APIs.
apis="$RUN_FOR_APIS"

# Build the libraries and run unit tests, optionally with coverage.
./build.sh $apis

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh $apis || true
./runintegrationtests.sh --retry || true
./runintegrationtests.sh --retry

# Clean up to make artifact copying quicker
./clean.sh

./processbuildtiminglog.sh
