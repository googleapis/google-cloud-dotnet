#!/bin/bash

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

echo "Available disk space at start"
df -h

echo "Cloning submodules"
git submodule init
git submodule update

echo "Available disk space after cloning submodules"
df -h

./build.sh

echo "Available disk space after running build.sh"
df -h

./clean.sh

echo "Available disk space after running clean.sh"
df -h

./processbuildtiminglog.sh

echo "Available disk space after running processbuildtiminglog.sh"
df -h
