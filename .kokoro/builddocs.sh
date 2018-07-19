#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
ROOT_DIR=$(dirname "$SCRIPT")

cd $ROOT_DIR
cd ..

# Build the libraries w/o running unit tests.
./build.sh --notests

# Build the docs.
cd docs
./builddocs.sh
