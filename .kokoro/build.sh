#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

echo "Cloning submodules"
git submodule init
git submodule update

./build.sh

./processbuildtiminglog.sh
