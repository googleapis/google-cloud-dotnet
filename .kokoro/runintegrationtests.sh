#!/bin/bash

set -e

# Function used to upload coverage, if CODECOV_TOKEN is set.
# $1 is used as the flag to codecov to indicate the report name.
maybe_upload_coverage() {
  if [[ -z "$CODECOV_TOKEN" ]]
  then
    return 0
  fi
  
  ./createcoveragereport.sh
  # Assume we've created the coverage file by this point. If we haven't, there should already have been an error.
  codecov -f "coverage/coverage-filtered.xml" --flag $1 --c $KOKORO_GITHUB_COMMIT --b KOKORO_BUILD_NUMBER
}

# Script entry point
SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_gcloud-devel-service-account"

# Non-coverage run doesn't need any extra flags
SCRIPT_FLAGS=

# If we have any previous coverage runs, remove them, regardless
# of whether we're about to create any.
rm -rf coverage

if [[ -f "$KOKORO_KEYSTORE_DIR/73609_codecov-token" ]]
then
  CODECOV_TOKEN=$(cat "$KOKORO_KEYSTORE_DIR/73609_codecov-token")
  SCRIPT_FLAGS=--coverage
  choco install codecov
fi

# Build the libraries and run unit tests, optionally with coverage.
./build.sh $SCRIPT_FLAGS

maybe_upload_coverage unittests

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh $SCRIPT_FLAGS || true
./runintegrationtests.sh $SCRIPT_FLAGS --retry || true
./runintegrationtests.sh $SCRIPT_FLAGS --retry

maybe_upload_coverage integrationtests
