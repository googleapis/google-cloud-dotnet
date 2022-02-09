#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

echo "Cloning submodules"
git submodule init
git submodule update

# Build the libraries w/o running unit tests.
./build.sh --notests

# Build the docs.
cd docs
./builddocs.sh
cd ..
./processbuildtiminglog.sh
