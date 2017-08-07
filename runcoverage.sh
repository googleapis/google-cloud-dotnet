#!/bin/bash

# We use dotcover instead of OpenCover.
# OpenCover doesn't support portable pdbs, and we don't
# really want to go back to full pdbs.
# See https://github.com/OpenCover/opencover/issues/601
# for current status.

# Run unit tests with coverage. We expect this script
# only to be executed on Windows, and only after build.sh
# has been run (so we already have an AllTests.txt file).

# Disable automatic test reporting to AppVeyor.
# See https://github.com/GoogleCloudPlatform/google-cloud-dotnet/issues/1232
unset APPVEYOR_API_URL

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
set -e

$NUGET install -Verbosity quiet -OutputDirectory packages -Version 2017.1.20170613.162720 JetBrains.dotCover.CommandLineTools

DOTCOVER=$PWD/packages/JetBrains.dotCover.CommandLineTools.2017.1.20170613.162720/tools/dotCover.exe
REPORTGENERATOR=$PWD/packages/ReportGenerator.2.4.5.0/tools/ReportGenerator.exe
FIND=/usr/bin/find

if [ ! -d coverage ]
then
 mkdir coverage
fi

while read csproj
do
  testdir=$(dirname $csproj)
  api=$(basename $(realpath $testdir/..))

  echo "Scanning for $testdir/coverage.xml"

  [ ! -f "$testdir/coverage.xml" ] && continue
  pushd "$testdir"

  echo "Running coverage for $api"
  $DOTCOVER cover "coverage.xml" /ReturnTargetExitCode

  popd
done < AllTests.txt

