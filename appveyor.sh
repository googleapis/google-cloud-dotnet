#!/bin/bash
dotnet --info
echo "Regenerating projects: if this fails, run generateprojects.sh and commit changes"
bash generateprojects.sh && git diff --exit-code

if [[ -z "$APPVEYOR_PULL_REQUEST_NUMBER" ]]
then
  # Not in a pull request.
  # Run a full build (no --diff) but without tests,  then test with code coverage.
  choco install codecov
  ./build.sh --notests
  ./runcoverage.sh
  ./createcoveragereport.sh
  if [[ -f "coverage/coverage-filtered.xml" ]]
  then
    codecov -f "coverage/coverage-filtered.xml"
  fi
else
  # We're in a pull request. Don't do any coverage; just
  # build and run tests.
  ./build.sh --diff
fi
