#!/bin/bash

set -e

cd tools
dotnet restore
dotnet build `find . -name 'Google*' -type d -maxdepth 1`
cd ..

cd apis
dotnet restore
dotnet build `find * -mindepth 1 -maxdepth 1 -name 'Google*' -type d`

# TODO: Tests. We need to:
# - Run Mono for all tests
# - Run dotnet test for all netcore-supporting tests.

for testdir in */*.Tests
do
  api=`echo $testdir | cut -d/ -f1`
  project=`echo $testdir | cut -d/ -f2`
  bin=$testdir/bin/Debug/net451/ubuntu.14.04-x64
  mono $bin/dotnet-test-xunit.exe $bin/$project.dll
done

# TODO: Work out all projects we can test with dotnet test
# automatically

dotnet test -f netcoreapp1.0 Google.Storage.V1/Google.Storage.V1.Tests
dotnet test -f netcoreapp1.0 Google.Bigquery.V2/Google.Bigquery.V2.Tests
