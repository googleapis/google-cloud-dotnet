#!/bin/bash

set -e

fetch() {
  if [ -d "external/$1" ]
  then
    echo Skipping $1
    return
  fi
  echo Fetching $1
  git clone https://github.com/$2 external/$1 --quiet --depth=1
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
  
  docfx.cmd metadata -f output/$api/docfx.json
  dotnet run -p ../tools/Google.Cloud.Tools.GenerateSnippetMarkdown -- $api
  docfx.cmd output/$api/docfx.json
  cp -r output/$api/site output/assembled/$api
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
fetch gax-dotnet googleapis/gax-dotnet
# For Google.Protobuf
fetch protobuf google/protobuf
# For Grpc.Core etc
fetch grpc google/grpc

# TODO: google/google-api-dotnet-client, but those projects
# don't work with docfx right now

# TODO: Support building multiple APIs (but not all) in one call

if [ -n "$1" ]
then
  build_api_docs $1
else
  for api in `find ../apis -mindepth 1 -maxdepth 1 -name 'Google*' -type d | cut -d/ -f3` root
  do
    build_api_docs $api
  done
fi
