#!/bin/bash

set -e

apis=$(git diff master --name-only | grep -e 'apis/.*/' | cut -d/ -f 2 | uniq)

git clone . tmpgit -q --no-local -b master --depth 1 --recursive

mkdir tmpgit/old
mkdir tmpgit/new

# First build everything, so we can get straight to the good stuff at the end of the log.
dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.CompareVersions
dotnet build -nologo -clp:NoSummary -v quiet tools/Google.Cloud.Tools.ReleaseManager

echo -e "\e[0m"

echo "First line after sane"
echo "Second line after sane"

for api in $apis
do  
  if [[ -d tmpgit/apis/$api/$api && -d apis/$api/$api ]]
  then
    echo -e "\e[1;32mBuilding $api"
    apidir=apis/$api/$api
    dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false tmpgit/$apidir 
    dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false $apidir
    asm=apis/$api/$api/bin/Release/netstandard2.0/$api.dll
    cp tmpgit/$asm tmpgit/old
    cp $asm tmpgit/new
  fi
done

echo ""
echo -e "\e[1;32mChanges detected\e[0m"
echo ""
echo "This is a line after changes detected"


for api in $apis
do  
  if [[ ! -d tmpgit/apis/$api/$api ]]
  then
    echo -e "\e[1;32m$api is new\e[0m"
  elif [[ ! -d apis/$api/$api ]]
  then
    echo -e "\e[1;32m$api was deleted\e[0m"
  else
    echo -e "\e[1;32mChecking $api for changes\e[0m"
    dotnet run --no-build -p tools/Google.Cloud.Tools.CompareVersions -- --file1=tmpgit/old/$api.dll --file2=tmpgit/new/$api.dll
  fi
  echo ""
stty sane
done  

echo ""
echo -e "\e[1;32mChecking compatibility with previous releases\e[0m"
echo ""
echo "This is a line after checking compatibility"

# Make sure all the tags are available for checking compatibility
git fetch --tags -q
dotnet run --no-build -p tools/Google.Cloud.Tools.ReleaseManager -- check-version-compatibility
