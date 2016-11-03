#!/bin/bash

set -e

fetch() {
  # $1: repo (and directory name)
  # $2: organization
  if [ -d "external/$1" ]
  then
    echo Skipping $1
    return
  fi
  echo Fetching $1
  git clone https://github.com/$2/$1 external/$1 --quiet --depth=1
}

build_api_docs() {
  echo Building docs for $1
  local api=$1

  # Special case "root" where we don't need to generate the sources
  if [ "$api" == "root" ]
  then
    cp -r root output/root
  else
    dotnet run -p ../tools/Google.Cloud.Tools.GenerateDocfxSources -- $api
  fi
  
  docfx metadata -f output/$api/docfx.json
  dotnet run -p ../tools/Google.Cloud.Tools.GenerateSnippetMarkdown -- $api
  docfx build output/$api/docfx.json

  # Special case root: that should end up in the root of the assembled
  # site.
  if [ "$api" == "root" ]
  then
    # We don't want to end up with a "site" directory under assembled...
    # we want the contents of site directly under assembled.
    # There may well be a better way of doing this!
    cp -r -t output/assembled output/$api/site/*
  else
    cp -r output/$api/site output/assembled/$api
  fi
}

if [ ! -d external ]
then
  mkdir external
fi

# TODO: Only do this if there's a parameter?
rm -rf output
mkdir output
mkdir output/assembled

# For Google.Api.Gax and Google.Api.Gax.Rest
fetch gax-dotnet googleapis
dotnet restore -v Warning external/gax-dotnet

# For Google.Protobuf
fetch protobuf google
dotnet restore -v Warning external/protobuf
# Remove // comments in project.json; dotnet cli is fine with it, but docfx isn't.
sed -i -r 's/\s+\/\/.*//g' external/protobuf/csharp/src/Google.Protobuf/project.json

# For Grpc.Core etc
fetch grpc grpc
dotnet restore -v Warning external/grpc/src/csharp

# For all REST-based APIs
fetch google-api-dotnet-client google
mkdir -p external/google-api-dotnet-client/NuPkgs/Support
dotnet restore -v Warning external/google-api-dotnet-client

# TODO: google/google-api-dotnet-client, but those projects
# don't work with docfx right now

apis=$@
if [ -z "$apis" ]
then
  # Build all APIs, which means every ../apis subdirectory with a "docs" subdirectory,
  # and "root" which is the special top-level docs.
  apis="`/usr/bin/find ../apis -mindepth 2 -maxdepth 2 -name docs -type d | cut -d/ -f3` root"
fi

for api in $apis
do 
  build_api_docs $api
done
