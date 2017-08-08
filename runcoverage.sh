#!/bin/bash

# We use the dotCover CLI for coverage.
# Other options considered include OpenCover, but that doesn't support portable PDBs.
# See https://github.com/OpenCover/opencover/issues/601 for current status of OpenCover,
# although now dotCover is working, we probably won't change back.

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

declare -r DOTCOVER_VERSION=2017.1.20170613.162720 
declare -r REPORTGENERATOR_VERSION=2.4.5.0

$NUGET install -Verbosity quiet -OutputDirectory packages -Version $DOTCOVER_VERSION JetBrains.dotCover.CommandLineTools

DOTCOVER=$PWD/packages/JetBrains.dotCover.CommandLineTools.$DOTCOVER_VERSION/tools/dotCover.exe
REPORTGENERATOR=$PWD/packages/ReportGenerator.$REPORTGENERATOR_VERSION/tools/ReportGenerator.exe
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

