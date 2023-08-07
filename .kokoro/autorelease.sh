#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR

# Make sure secrets are loaded in a well known localtion before running releasetool
source ./populatesecrets.sh
populate_all_secrets

# Make sure we have the most recent version of pip, then install other packages.
python -m pip install --require-hashes -r pip-requirements.txt
python -m pip install --require-hashes -r requirements.txt

# The publish reporter script uses "python3" which doesn't exist on Windows.
# Work out what we should use instead, and fix up the script.
python -m releasetool publish-reporter-script > /tmp/publisher-script
PYTHON3=$(source ../toolversions.sh && echo $PYTHON3)
sed -i "s/python3/$PYTHON3/g" /tmp/publisher-script
source /tmp/publisher-script

echo "Not really doing a release"

# We use COMMITTISH_OVERRIDE in the real release, but
# it's fine to use it here as a way of failing.
if [[ "$COMMITTISH_OVERRIDE" != "" ]]
then
  echo "Failing! $COMMITTISH_OVERRIDE"
  exit 1
fi

echo "Fake release succeeded!"

