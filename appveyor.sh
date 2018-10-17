#!/bin/bash

set -e

dotnet --info
echo "Regenerating projects: if this fails, run generateprojects.sh and commit changes"
bash generateprojects.sh && git diff --exit-code

> build_timing_log.txt

if [[ -z "$APPVEYOR_PULL_REQUEST_NUMBER" ]]
then
  # Not in a pull request.
  # Run a full build (no --diff) with tests. Don't do any coverage so it
  # won't clash with coverage generated through Kokoro.
  ./build.sh
else
  # We're in a pull request. Just build and run tests for the changes.
  ./build.sh --diff
fi

./processbuildtiminglog.sh
