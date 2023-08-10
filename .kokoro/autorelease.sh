#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR

# Make sure secrets are loaded in a well known localtion before running releasetool
source ./populatesecrets.sh
populate_all_secrets

../tools/Google.Cloud.Tools.ReleaseTool/publish_reporter.sh

# Secrets are already populated, let's not do that again
./release.sh --skippopulatesecrets

echo "Not really doing a release"

# We use COMMITTISH_OVERRIDE in the real release, but
# it's fine to use it here as a way of failing.
if [[ "$COMMITTISH_OVERRIDE" != "" ]]
then
  echo "Failing! $COMMITTISH_OVERRIDE"
  exit 1
fi

echo "Fake release succeeded!"
