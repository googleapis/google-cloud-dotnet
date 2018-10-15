#!/bin/bash

# Clean up test data from integration tests that is not
# cleaned up at the time of the tests.  Uses the 
# 'TEST_PROJECT' environment variable to get the project
# to delete test data from.

set -e

cd $(dirname $0)

source toolversions.sh

apis=$(echo apis/Google.* | sed 's/apis\///g')

echo "Using test project '$TEST_PROJECT'"

log_build_action "(Start) Cleaning test data"
for api in ${apis[*]}
do  
  cleantestdir=apis/$api/$api.CleanTestData
  if [[ -d "$cleantestdir" ]]
  then
    log_build_action "Cleaning test data for $api"
    dotnet build -c Release $cleantestdir
    dotnet run --project $cleantestdir -- $TEST_PROJECT
  fi
done
log_build_action "(End) Cleaning test data"
