#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

source $SCRIPT_DIR/populatesecrets.sh

populate_all_secrets
# Use the explicitly-provided credentials rather than relying on default compute credentials
export GOOGLE_APPLICATION_CREDENTIALS="$SECRETS_LOCATION/cloud-sharp-jenkins-compute-service-account"

# We don't really need the submodules, but it prevents some warnings in logs.
echo "Cloning submodules"
git submodule init
git submodule update

./cleantestdata.sh

./processbuildtiminglog.sh
