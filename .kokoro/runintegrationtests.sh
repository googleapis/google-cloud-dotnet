#!/bin/bash

set -e

# Script entry point
SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

source $SCRIPT_DIR/populatesecrets.sh

echo "Available disk space at start"
df -h

populate_all_secrets
export GOOGLE_APPLICATION_CREDENTIALS="$SECRETS_LOCATION/cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$SECRETS_LOCATION/gcloud-devel-service-account"

export TEST_UNIVERSE_DOMAIN_CREDENTIAL=$(realpath $SECRETS_LOCATION/client-library-test-universe-domain-credential)
export TEST_UNIVERSE_DOMAIN=$(cat $SECRETS_LOCATION/client-library-test-universe-domain)
export TEST_UNIVERSE_PROJECT_ID=$(cat $SECRETS_LOCATION/client-library-test-universe-project-id)
export TEST_UNIVERSE_LOCATION=$(cat $SECRETS_LOCATION/client-library-test-universe-storage-location)

echo "Available disk space after populating secrets"
df -h

echo "Cloning submodules"
git submodule init
git submodule update

echo "Available disk space after cloning submodules"
df -h

# Non-coverage run doesn't need any extra flags
script_flags=
report_flags="--upload_commit $KOKORO_GITHUB_COMMIT --upload_build $KOKORO_BUILD_NUMBER"
# Specify RUN_FOR_APIS when manually triggering Kokoro to run tests only on a set of APIs.
apis="$RUN_FOR_APIS"

# If we have any previous coverage runs, remove them, regardless
# of whether we're about to create any.
rm -rf coverage

echo "Available disk space after removing old coverage"
df -h

# Note: we still use the presence of a codecov token to determine whether or not to
# run coverage, even though we don't upload to codecov.
# TODO: Use an environment variable instead.
if [[ -f "$SECRETS_LOCATION/codecov-token" ]]
then
 script_flags=--coverage
fi

# Build the libraries and run unit tests, optionally with coverage.
./build.sh $script_flags $apis

echo "Available disk space after running build.sh"
df -h

# Even if we set up here some upload report flags, if --upload is not present we won't upload the report.
./createcoveragereport.sh $report_flags --upload_reportname unittests

echo "Available disk space after running createcoveragereport.sh"
df -h

# Remove the reports potentially created for the unit tests so we only
# maybe upload the ones related to integration tests next.
rm -rf coverage

echo "Available disk space after removing coverage for unit tests"
df -h

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh $script_flags $apis || true
./runintegrationtests.sh $script_flags --retry || true
./runintegrationtests.sh $script_flags --retry

echo "Available disk space after running runintegrationtests.sh"
df -h

# Even if we set up here some upload report flags, if --upload is not present we won't upload the report.
./createcoveragereport.sh $report_flags --upload_reportname integrationtests

echo "Available disk space after running createcoveragereport.sh"
df -h

# Clean up to make artifact copying quicker
./clean.sh

./processbuildtiminglog.sh

echo "Available disk space after running processbuildtiminglog.sh"
df -h
