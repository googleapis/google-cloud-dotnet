#!/bin/bash

set -e

# Expectations
# - This script is run from the root of googleapis-gen.
#   (We can add parameters later.)
# - googleapis-gen is a peer of google-cloud-dotnet
#   (so we can copy global.json from there)
# - It's okay to create and delete a "tmp" directory
# - It's okay to create a global.json

ROOT=$PWD

rm -rf tmp
mkdir tmp

cp ../google-cloud-dotnet/global.json .

echo "Starting at $(date -u +%FT%TZ)"
echo "Finding *-csharp directories"

find * -type d -name '*-csharp' \
  | grep -v google/ads \
  | grep -v google/iam/v1 \
  | grep -v google/cloud/location \
  > tmp/csharp-directories.txt

echo "Found $(wc -l < tmp/csharp-directories.txt) csharp directories"

failures=0
successes=0
ignored=0

for directory in $(cat tmp/csharp-directories.txt)
do
  cd $ROOT
  api=$(basename $directory)
  echo -n "Building $api... "

  # Copy source code, so we do everything in tmp
  rm -rf tmp/build
  cp -r $directory tmp/build
  cd tmp/build
  # TODO: Stop these directories from being generated in the first place
  find . -name '*.csproj' \
    | grep -v Google.Cloud.Iam.V1 \
    | grep -v Google.Cloud.Location \
    > $ROOT/tmp/$api-projects.txt \
    || echo -n "(Ignoring grep failure.) "
  
  # Check whether there are any project files - skip logging.type etc.
  if [[ ! -s $ROOT/tmp/$api-projects.txt ]]
  then
    echo "No project files found; ignoring."
    ignored=$((ignored+1))
    continue
  fi
  
  # Create a new solution and add projects to it
  dotnet new sln -n $api > /dev/null
  dotnet sln add $(cat $ROOT/tmp/$api-projects.txt) > /dev/null
  # Build, redirecting all output to a log file specific to the API
  dotnet build -nologo -clp:NoSummary -v quiet $api.sln \
    2>&1 > $ROOT/tmp/$api-build.txt \
    && { echo "Succeeded."; successes=$((successes+1)); } \
    || { echo "Failed."; failures=$((failures+1)); }
    
  # Delete empty builds, as they basically represent success.
  if [[ ! -s $ROOT/tmp/$api-build.txt ]]
  then
    rm -f $ROOT/tmp/$api-build.txt
  fi
done

cd $ROOT

echo "Total successes: $successes"
echo "Total failures: $failures"
echo "Total ignored: $ignored"
echo "Finished at $(date -u +%FT%TZ)"
