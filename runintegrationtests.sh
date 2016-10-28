#!/bin/bash

# Assumption: everything has been built already.

set -e
PROGRESS_FILE=`realpath integrationprogress.txt`

[[ "$1" == "--continue" ]] || rm $PROGRESS_FILE
touch $PROGRESS_FILE

cd apis

# Only run them for Core, for simplicity.
for testdir in */*.IntegrationTests */*.Snippets
do
  if [[ "$testdir" =~ (Metadata|AspNet|Log4Net) ]]
  then
    echo "Skipping $testdir; test not supported yet."
  elif echo "$testdir" | grep --quiet -F -f $PROGRESS_FILE
  then
    echo "Skipping $testdir; test already run"
  else
    dotnet test -c Release --no-build -f netcoreapp1.0 $DOTNET_TEST_ARGS $testdir -xml $testdir/results.xml
    echo "$testdir" >> $PROGRESS_FILE
  fi
done
