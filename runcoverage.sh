#!/bin/bash

# THIS DOES NOT WORK YET!
# OpenCover doesn't support portable pdbs, and we don't
# really want to go back to full pdbs.
# See https://github.com/OpenCover/opencover/issues/601
# for current status.

# Run unit tests with coverage. We expect this script
# only to be executed on Windows, and only after build.sh
# has been run (so we already have an AllTests.txt file).

# Use an appropriate version of nuget... preferring
# first an existing NUGET variable, then NuGet, then
# just falling back to the path.
if [ -z "$NUGET" ]
then
  if [ -n "$NuGet" ]
  then
    NUGET="$NuGet"
  else
    NUGET="nuget"
  fi
fi

$NUGET install -Verbosity quiet -OutputDirectory packages -Version 4.6.519 OpenCover
$NUGET install -Verbosity quiet -OutputDirectory packages -Version 2.4.5.0 ReportGenerator
OPENCOVER=$PWD/packages/OpenCover.4.6.519/tools/OpenCover.Console.exe
REPORTGENERATOR=$PWD/packages/ReportGenerator.2.4.5.0/tools/ReportGenerator.exe
FIND=/usr/bin/find

rm -rf coverage
mkdir coverage

while read csproj
do
  testdir=$(dirname $csproj)
  api=$(basename $(realpath $testdir/..))
  echo "Running coverage for $api"
  # OpenCover is picky about how it finds the excluded files. There may be a better approach than this,
  # but it'll do for now.
  generatedFiles=$($FIND $testdir/../$api -name '*.cs' | grep -v "obj/" | xargs -n 1 grep -l "// Generated" | sed 's/.*\/.*\//*\\\\*\\\\/g' | tr '\n' ';')
  echo Coverage excluding files $generatedFiles
  
  $OPENCOVER \
    -target:"c:\Program Files\dotnet\dotnet.exe" \
    -targetargs:"test --no-build -f net452 -c Release $csproj" \
    -mergeoutput \
    -hideskipped:File \
    -output:coverage/coverage.xml \
    -filter:"+[$api]*" \
    -oldStyle \
    -searchdirs:$testdir/bin/$CONFIG/net452 \
    -register:user \
    -excludebyfile:$generatedFiles

done < AllTests.txt

$REPORTGENERATOR \
  -reports:$coverage/coverage.xml \
  -targetdir:$coverage \
  -verbosity:Error
