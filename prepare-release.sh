#!/bin/bash

set -e

if [ -z "$1" ]
then
  echo "Please specify the API you're releasing, e.g. Google.Cloud.Storage.V1"
  exit 1
fi

# Make sure we have all the tags locally.
git fetch --all --tags -f -q

echo "Building $1"
./build.sh $1 --notests
echo ""

echo "Updating release notes"
dotnet run -p tools/Google.Cloud.Tools.UpdateReleaseNotes -- $1

echo "Checking version compatibility"
dotnet run -p tools/Google.Cloud.Tools.CheckVersionCompatibility -- $1
