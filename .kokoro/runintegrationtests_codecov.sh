#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_gcloud-devel-service-account"

choco install codecov

# Build the libraries, run unit tests, and upload unit tests coverage report.
./build.sh --notests
./runcoverage.sh
./createcoveragereport.sh
if [[ -f "coverage/coverage-filtered.xml" ]]
then
  codecov -f "coverage/coverage-filtered.xml" --flag unittests --c $KOKORO_GITHUB_COMMIT --b KOKORO_BUILD_NUMBER
fi

# Removing all code coverage files generated for unit tests before generating the ones for integration tests.
rm -f coverage/*

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh --coverage || true
./runintegrationtests.sh --retry --coverage || true
./runintegrationtests.sh --retry --coverage
# No need to call ./runcoverage.sh here, since ./runintegrationtests already runs coverage when the --coverage option is set.
# We do need to creat the coverage report though.
./createcoveragereport.sh
if [[ -f "coverage/coverage-filtered.xml" ]]
then
  codecov -f "coverage/coverage-filtered.xml" --flag integrationtests --c $KOKORO_GITHUB_COMMIT --b KOKORO_BUILD_NUMBER
fi