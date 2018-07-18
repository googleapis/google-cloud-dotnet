#!/bin/bash

set -e

cd ..

# Build the libraries w/o running unit tests.
./build.sh --notests

# Build the docs.
cd docs
./builddocs.sh
