#!/bin/bash

# Assumption: everything has been built already.

set -e

[[ $(dotnet --info | grep "OS Platform" | grep -c Windows) -ne 0 ]] && OS=Windows || OS=Linux

cd apis

# Only run them for Core, for simplicity.
for testdir in */*.IntegrationTests */*.Snippets
do
  if [[ "$testdir" =~ (Metadata|AspNet|Log4Net) ]]
  then
    echo Skipping $testdir
  else
    dotnet test -f netcoreapp1.0 $DOTNET_TEST_ARGS $testdir
  fi
done
