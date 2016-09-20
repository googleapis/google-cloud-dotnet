#!/bin/bash

set -e

if [ $(dotnet --info | grep "OS Platform" | grep -c Windows) -ne 0 ]
then
  OS=Windows
  nuget install -OutputDirectory packages OpenCover -Version 4.6.519
  nuget install -OutputDirectory packages ReportGenerator -Version 2.4.5.0
  # Comment out the lines below to disable coverage
  OPENCOVER=$PWD/packages/OpenCover.4.6.519/tools/OpenCover.Console.exe
  REPORTGENERATOR=$PWD/packages/ReportGenerator.2.4.5.0/tools/ReportGenerator.exe
else
  OS=Linux
fi

FIND=/usr/bin/find

CONFIG=Release
# Arguments to use for all build-related commands (build, pack)
DOTNET_BUILD_ARGS="-c $CONFIG"
# Arguments to use for test-related commands (test)
DOTNET_TEST_ARGS="$DOTNET_BUILD_ARGS"

# Three options:
# - No environment variables: make sure it's not for release
# - PRERELEASETAG set: use that
# - NOVERSIONSUFFIX set: use no suffix; build as per project.json
if [ -n "$PRERELEASETAG" ]
then
  DOTNET_BUILD_ARGS="$DOTNET_BUILD_ARGS --version-suffix $PRERELEASETAG"
elif [ -z "$NOVERSIONSUFFIX" ]
then
  DOTNET_BUILD_ARGS="$DOTNET_BUILD_ARGS --version-suffix dont-release"
fi

echo CLI args: $DOTNET_BUILD_ARGS

echo Building

dotnet restore tools apis

cd tools
dotnet build $DOTNET_BUILD_ARGS `$FIND . -mindepth 1 -maxdepth 1 -name 'Google*' -type d `
cd ..

cd apis
dotnet build $DOTNET_BUILD_ARGS `$FIND * -mindepth 1 -maxdepth 1 -name 'Google*' -type d`

echo Testing

coverage=../coverage
rm -rf $coverage
mkdir $coverage

for testdir in */*.Tests
do
  api=`echo $testdir | cut -d/ -f1`
  if [ $OS == "Windows" ]
  then
    dotnet test -f net451 $DOTNET_TEST_ARGS $testdir
    if [ -n "$OPENCOVER" ]
    then
      # OpenCover is picky about how it finds the excluded files. There may be a better approach than this,
      # but it'll do for now.
      generatedFiles=`$FIND $api/$api -name '*.cs' | xargs grep -l "// Generated" | sed 's/.*\/.*\//*\\\\*\\\\/g' | tr '\n' ';'`
      echo Coverage excluding files $generatedFiles
      
      # TODO: We still end up with output lines for the service and client, but with nothing
      # available to be covered or uncovered. Protobuf messages don't appear (which is right!)
      # so excludebyfile appears to be working. Odd.
      $OPENCOVER \
        -target:"c:\Program Files\dotnet\dotnet.exe" \
        -targetargs:"test -f net451 $DOTNET_TEST_ARGS $testdir" \
        -mergeoutput \
        -hideskipped:File \
        -output:$coverage/coverage.xml \
        -oldStyle \
        -filter:"+[$api]*" \
        -searchdirs:$testdir/bin/$CONFIG/net451/win7-x64 \
        -register:user \
        -excludebyfile:$generatedFiles
    fi
  else
    project=`echo $testdir | cut -d/ -f2`
    bin=$testdir/bin/$CONFIG/net451/ubuntu.14.04-x64
    mono $bin/dotnet-test-xunit.exe $bin/$project.dll
  fi
done

if [ -n "$OPENCOVER" -a -n "REPORTGENERATOR" ]
then
  $REPORTGENERATOR \
    -reports:$coverage/coverage.xml \
    -targetdir:$coverage \
    -verbosity:Error
fi

# TODO: Work out all projects we can test with dotnet test
# automatically

dotnet test -f netcoreapp1.0 $DOTNET_TEST_ARGS Google.Storage.V1/Google.Storage.V1.Tests
dotnet test -f netcoreapp1.0 $DOTNET_TEST_ARGS Google.Bigquery.V2/Google.Bigquery.V2.Tests

echo Packing

# Assume each packagable project contains something like "version": "1.0.0-*"
# and no other projects do.
for package in `$FIND . -name project.json | xargs grep -le 'version.*-\*' | sed 's/\/project.json//g'`
do
  dotnet pack $DOTNET_BUILD_ARGS $package
done
