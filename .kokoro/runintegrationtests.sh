#!/bin/bash

set -e

cd ..

# Build the libraries and run unit tests.
./build.sh

# Allow each integration test 3 chances to pass.
./runintegrationtests.sh || true
./runintegrationtests.sh --retry || true
./runintegrationtests.sh --retry
