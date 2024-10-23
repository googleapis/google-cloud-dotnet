#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR

# Make sure secrets are loaded in a well known localtion before running the release reporter
source ./populatesecrets.sh
populate_all_secrets

dotnet tool restore
# Pause release progress reporting temporarily. See b/373927472
# source <(dotnet release-progress-reporter publish-reporter-script)

# Secrets are already populated, let's not do that again
./release.sh --skippopulatesecrets
