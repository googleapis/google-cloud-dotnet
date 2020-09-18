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

# If we have any previous coverage runs, remove them, regardless
# of whether we're about to create any.
rm -rf coverage

echo "Available disk space after removing old coverage"
df -h

if [[ -f "$SECRETS_LOCATION/codecov-token" ]]
then
 export CODECOV_TOKEN=$(cat "$SECRETS_LOCATION/codecov-token")
 script_flags=--coverage
 report_flags="--upload $report_flags"
fi

# Build the libraries and run unit tests, optionally with coverage.
./build.sh $script_flags

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
./runintegrationtests.sh $script_flags || true
./runintegrationtests.sh $script_flags --retry || true
./runintegrationtests.sh $script_flags --retry

echo "Available disk space after running runintegrationtests.sh"
df -h

# Even if we set up here some upload report flags, if --upload is not present we won't upload the report.
./createcoveragereport.sh $report_flags --upload_reportname integrationtests

echo "Available disk space after running createcoveragereport.sh"
df -h

./processbuildtiminglog.sh

echo "Available disk space after running processbuildtiminglog.sh"
df -h
