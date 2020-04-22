#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR

# The publish reporter script uses "python3" which doesn't exist on Windows.
# We already know how to find it though, so let's just use an alias.
alias python3=$(source toolversions.sh && echo $PYTHON3)

# Make sure we have the most recent version of pip, then install the gcp-releasetool package
python -m pip install --upgrade pip
python -m pip install gcp-releasetool
python -m releasetool publish-reporter-script > /tmp/publisher-script; source /tmp/publisher-script

./release.sh
