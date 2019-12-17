#!/bin/bash

set -e

if [[ -z "$1" || -z "$2" ]]
then
  echo Please specify the API name and the NuGet package version
  exit 1
fi

# Fetch the package from NuGet and unzip it
rm -rf tmp
mkdir tmp
cd tmp
curl -sSL https://www.nuget.org/api/v2/package/$1/$2 --output tmp.zip
unzip -q tmp.zip
cd ..

# Build the current source code
./build.sh $1

# Run the comparison tool

old_dll=tmp/lib/netstandard1.*/$1.dll
new_dll=apis/$1/$1/bin/Release/netstandard1.*/$1.dll
dotnet run -p tools/Google.Cloud.Tools.CompareVersions -- --file1=$old_dll --file2=$new_dll
