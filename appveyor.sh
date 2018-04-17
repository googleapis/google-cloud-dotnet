#!/bin/bash
dotnet --info
echo "Regenerating projects: if this fails, run generateprojects.sh and commit changes"
bash generateprojects.sh && git diff --exit-code

if [[ -z "$APPVEYOR_PULL_REQUEST_NUMBER" ]]
then
  # Not in a pull request. Run the build without tests,
  # then test with code coverage.
  choco install codecov
  bash build.sh --notests --diff
  bash createcoveragereport.sh
  if [[ -f "coverage/coverage-filtered.xml" ]]
  then
    codecov -f "coverage/coverage-filtered.xml"
  fi
else
  # We're in a pull request. Don't do any coverage; just
  # build and run tests.
  bash build.sh --diff
fi
