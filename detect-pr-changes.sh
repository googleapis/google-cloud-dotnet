#!/bin/bash

set -e

apis=$(git diff master --name-only | grep -e 'apis/.*/' | cut -d/ -f 2 | uniq)

git clone . tmpgit --no-local -b master --depth 1

mkdir tmpgit/old
mkdir tmpgit/new

# First build everything, so we can get straight to the good stuff at the end of the log.
dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.CompareVersions
dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.CheckVersionCompatibility

for api in $apis
do
  # We can't build Google.Cloud.Diagnostics.AspNet at all on Travis;
  # The analyzer uses netstandard1.3 instead of netstandard2.0 and it's not worth parameterizing that
  if [[ $api == "Google.Cloud.Diagnostics.AspNet" || $api == "Google.Cloud.Diagnostics.AspNetCore.Analyzers" ]]
  then
    continue
  fi
  
  if [[ -d tmpgit/apis/$api/$api && -d apis/$api/$api ]]
  then
    echo "Building $api"
    apidir=apis/$api/$api
    dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false tmpgit/$apidir 
    dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false $apidir
    asm=apis/$api/$api/bin/Release/netstandard2.0/$api.dll
    cp tmpgit/$asm tmpgit/old
    cp $asm tmpgit/new
  fi
done

echo ""
echo "====================="
echo "Changes detected"
echo "====================="
echo ""


for api in $apis
do
  # See above
  if [[ $api == "Google.Cloud.Diagnostics.AspNet" || $api == "Google.Cloud.Diagnostics.AspNetCore.Analyzers" ]]
  then
    continue
  fi
  
  if [[ ! -d tmpgit/apis/$api/$api ]]
  then
    echo "$api is new"
  elif [[ ! -d apis/$api/$api ]]
  then
    echo "$api was deleted"
  else
    echo "Checking $api for changes"
    dotnet run --no-build -p tools/Google.Cloud.Tools.CompareVersions -- --file1=tmpgit/old/$api.dll --file2=tmpgit/new/$api.dll
  fi
  echo "---------------------"
done  

echo ""
echo "============================================="
echo "Checking compatibility with previous releases"
echo "============================================="
echo ""

# Make sure all the tags are available for checking compatibility
git fetch --tags -q
dotnet run --no-build -p tools/Google.Cloud.Tools.CheckVersionCompatibility
