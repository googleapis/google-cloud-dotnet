#!/bin/bash

set -e

echo "Cloning submodules"
git submodule init
git submodule update

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

./build.sh

./processbuildtiminglog.sh
