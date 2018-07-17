#!/bin/bash

set -e

cd ..

# Build the libraries w/o running unit tests.
./build.sh --notests

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh || true
./runintegrationtests.sh --retry || true
./runintegrationtests.sh --retry
