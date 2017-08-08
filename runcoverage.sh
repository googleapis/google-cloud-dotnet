#!/bin/bash

set -e

source toolversions.sh
install_dotcover

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
