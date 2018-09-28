#!/bin/bash

set -e

dotnet --info
echo "Regenerating projects: if this fails, run generateprojects.sh and commit changes"
bash generateprojects.sh && git diff --exit-code

if [[ -z "$APPVEYOR_PULL_REQUEST_NUMBER" ]]
then
  # Not in a pull request.
  # Run a full build (no --diff) with tests and coverage, then create and upload coverage report.
  ./build.sh --coverage
  ./createcoveragereport.sh --upload --upload_reportname unittests
else
  # We're in a pull request. Don't do any coverage; just
  # build and run tests.
  ./build.sh --diff
fi
