#!/bin/bash

set -e

# Script entry point
SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

echo "Cloning submodules"
git submodule init
git submodule update

export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_gcloud-devel-service-account"

# Non-coverage run doesn't need any extra flags
script_flags=
report_flags="--upload_commit $KOKORO_GITHUB_COMMIT --upload_build $KOKORO_BUILD_NUMBER"

# If we have any previous coverage runs, remove them, regardless
# of whether we're about to create any.
rm -rf coverage

if [[ -f "$KOKORO_KEYSTORE_DIR/73609_codecov-token" ]]
then
 export CODECOV_TOKEN=$(cat "$KOKORO_KEYSTORE_DIR/73609_codecov-token")
 script_flags=--coverage
 report_flags="--upload $report_flags"
fi

# Build the libraries and run unit tests, optionally with coverage.
./build.sh $script_flags
# Even if we set up here some upload report flags, if --upload is not present we won't upload the report.
./createcoveragereport.sh $report_flags --upload_reportname unittests

# Remove the reports potentially created for the unit tests so we only
# maybe upload the ones related to integration tests next.
rm -rf coverage

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh $script_flags || true
./runintegrationtests.sh $script_flags --retry || true
./runintegrationtests.sh $script_flags --retry
# Even if we set up here some upload report flags, if --upload is not present we won't upload the report.
./createcoveragereport.sh $report_flags --upload_reportname integrationtests

./processbuildtiminglog.sh
