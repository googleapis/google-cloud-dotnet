#!/bin/bash

set -e

ALLOW_BREAKING_CHANGES=
if [[ $1 == "--allow-breaking-changes" ]]
then
  ALLOW_BREAKING_CHANGES=true
  echo "(Breaking changes allowed during diff)"
fi


# Writes the argument to the console in bold magenta, to make it stand out.
log_header() {
  echo -e "\e[1;35m$1\e[0m"
}

# Fails the whole script (exit code 1) if and only if ALLOW_BREAKING_CHANGES isn't true
maybe_fail() {
  if [[ $ALLOW_BREAKING_CHANGES != "true" ]]
  then
    exit 1
  else
    echo -e "\e[1;31mWarning: breaking change detected, but the error has been suppressed by options.\e[0m"
  fi
}

# Find the APIs that have changed, excluding ServiceDirectory (which isn't a real API)
apis=$(git diff master --name-only | grep -e 'apis/.*/' | cut -d/ -f 2 | grep -v '^ServiceDirectory$' | uniq)

if [[ "$apis" == "" ]]
then
  log_header "No APIs have changed in this PR. Exiting diff."
  exit 0
fi

git clone . tmpgit --no-local -q -b master --depth 1 --recursive

mkdir tmpgit/old
mkdir tmpgit/new

# First build everything, so we can get straight to the good stuff at the end of the log.
dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.CompareVersions
dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.ReleaseManager

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
git fetch --tags -q

dotnet run --no-build -p tools/Google.Cloud.Tools.ReleaseManager -- check-version-compatibility $apis || maybe_fail
