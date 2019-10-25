#!/bin/bash

set -e
source ../toolversions.sh
install_docfx

declare -r PROTOBUF_BRANCH=3.8.x
declare -r GRPC_BRANCH=v1.22.x

# Blow away any previous files and clone the repo
rm -rf dependencies
git clone https://github.com/googleapis/google-cloud-dotnet dependencies --quiet -b dependencies
# Start with a clean slate other than README.md and .gitignore
git -C dependencies rm -rf .
git -C dependencies reset -- README.md .gitignore
git -C dependencies checkout README.md .gitignore

echo "Cloning repositories"
git clone https://github.com/googleapis/gax-dotnet dependencies/gax-dotnet --quiet --depth=1 -b master
git clone https://github.com/google/protobuf dependencies/protobuf --quiet --depth=1 -b $PROTOBUF_BRANCH
git clone https://github.com/grpc/grpc dependencies/grpc --quiet --depth=1 -b $GRPC_BRANCH
git clone https://github.com/google/google-api-dotnet-client dependencies/google-api-dotnet-client --quiet --depth=1 -b master

# Copy docfx files
cp dependencies-docfx/docfx-gax-dotnet.json dependencies/gax-dotnet/docfx.json
cp dependencies-docfx/docfx-protobuf.json dependencies/protobuf/docfx.json
cp dependencies-docfx/docfx-grpc.json dependencies/grpc/docfx.json
cp dependencies-docfx/docfx-google-api-dotnet-client.json dependencies/google-api-dotnet-client/docfx.json

# Restore packages and build metadata
(cd dependencies/gax-dotnet;
 dotnet restore Gax.sln
 $DOCFX metadata)

(cd dependencies/protobuf;
 $DOCFX metadata)

(cd dependencies/grpc; 
 $DOCFX metadata)

(cd dependencies/google-api-dotnet-client;
 rm NuGet.config;
 dotnet restore Src/Support/GoogleApisClient.sln;
 dotnet new sln --name Generated;
 dotnet sln Generated.sln add Src/Generated/Google.Apis.Bigquery.v2/*.csproj;
 dotnet sln Generated.sln add Src/Generated/Google.Apis.Storage.v1/*.csproj;
 dotnet restore Generated.sln;
 $DOCFX metadata)

# Copy the metadata into a single api directory, one subdirectory per package
mkdir dependencies/api
cp -r dependencies/{gax-dotnet,protobuf,grpc,google-api-dotnet-client}/api/* dependencies/api
for dir in dependencies/api/*
do
  # Make the build scripts significantly simpler...
  mv $dir/toc.yml $dir/toc
done

git -C dependencies add --all

echo "Done. Commit and push new files after checking they look okay."
