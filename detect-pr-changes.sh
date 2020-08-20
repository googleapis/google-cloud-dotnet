#!/bin/bash

set -e

apis=$(git diff master --name-only | grep -e 'apis/.*/' | cut -d/ -f 2 | uniq)

git clone . tmpgit --no-local -q -b master --depth 1 --recursive

mkdir tmpgit/old
mkdir tmpgit/new

# First build everything, so we can get straight to the good stuff at the end of the log.
dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.CompareVersions
dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.ReleaseManager

# Writes the argument to the console in bold magenta, to make it stand out.
log_header() {
  echo -e "\e[1;35m$1\e[0m"
}

for api in $apis
do  
  if [[ -d tmpgit/apis/$api/$api && -d apis/$api/$api ]]
  then
    targetVersion="netstandard2.0"
    if [[ $api == "Google.Cloud.Diagnostics.AspNetCore3" ]]
    then
      targetVersion="netcoreapp3.1"
    fi
    log_header "Building $api"
    apidir=apis/$api/$api
    dotnet build -c Release -f $targetVersion -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false tmpgit/$apidir 
    dotnet build -c Release -f $targetVersion -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false $apidir
    asm=apis/$api/$api/bin/Release/$targetVersion/$api.dll
    cp tmpgit/$asm tmpgit/old
    cp $asm tmpgit/new
  fi
done

echo ""

for api in $apis
do  
  log_header "Detecting changes for $api"
  
  if [[ ! -d tmpgit/apis/$api/$api ]]
  then
    echo "$api is new"
  elif [[ ! -d apis/$api/$api ]]
  then
    echo "$api was deleted"
  else
    dotnet run --no-build -p tools/Google.Cloud.Tools.CompareVersions -- --file1=tmpgit/old/$api.dll --file2=tmpgit/new/$api.dll
  fi
done  

log_header "Checking compatibility with previous releases"

# Make sure all the tags are available for checking compatibility
git fetch --all --tags -q

echo "Displaying all tags"
git tag
echo "Done"

dotnet run --no-build -p tools/Google.Cloud.Tools.ReleaseManager -- check-version-compatibility
