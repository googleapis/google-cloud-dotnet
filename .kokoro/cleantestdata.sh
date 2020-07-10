#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

# We don't really need the submodules, but it prevents some warnings in logs.
echo "Cloning submodules"
git submodule init
git submodule update

# Use the explicitly-provided credentials rather than relying on default compute credentials
export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"

./cleantestdata.sh

./processbuildtiminglog.sh
