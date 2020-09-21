#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR

# Make sure secrets are loaded in a well known localtion before running releasetool
source ./populatesecrets.sh
populate_all_secrets

# Make sure we have the most recent version of pip, then install the gcp-releasetool package
python -m pip install --upgrade pip
python -m pip install gcp-releasetool
python -m releasetool publish-reporter-script > /tmp/publisher-script

# The publish reporter script uses "python3" which doesn't exist on Windows.
# Work out what we should use instead.
PYTHON3=$(source ../toolversions.sh && echo $PYTHON3)

# Fix up the publish reporter script using $PYTHON3. We assume this won't
# be harmful within sed - at the moment it's always "python", "py -3" or "python3".
sed -i "s/python3/$PYTHON3/g" /tmp/publisher-script

source /tmp/publisher-script

# Secrets are already populated, let's not do that again
./release.sh --skippopulatesecrets
