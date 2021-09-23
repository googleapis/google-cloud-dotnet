#!/bin/bash

set -e
source ../toolversions.sh
install_docfx

declare -r PROTOBUF_BRANCH=3.11.x
declare -r GRPC_BRANCH=v1.27.x

# Blow away any previous files and clone the repo
rm -rf dependencies
git clone https://github.com/googleapis/google-cloud-dotnet dependencies --quiet -b dependencies
# Start with a clean slate other than README.md and .gitignore
git -C dependencies rm -rf .
git -C dependencies reset -- README.md .gitignore
git -C dependencies checkout README.md .gitignore

echo "Cloning repositories"
git clone https://github.com/googleapis/gax-dotnet dependencies/gax-dotnet --quiet --depth=1 -b main
git clone https://github.com/google/protobuf dependencies/protobuf --quiet --depth=1 -b $PROTOBUF_BRANCH
git clone https://github.com/grpc/grpc dependencies/grpc --quiet --depth=1 -b $GRPC_BRANCH

# Copy docfx files
cp dependencies-docfx/docfx-gax-dotnet.json dependencies/gax-dotnet/docfx.json
cp dependencies-docfx/docfx-protobuf.json dependencies/protobuf/docfx.json
cp dependencies-docfx/docfx-grpc.json dependencies/grpc/docfx.json

# Fetch the dependency maps for Google.Apis.*
# TODO: Ideally this should be based on the actual dependency versions, but this is okay to start with.
mkdir dependencies/xrefmaps
curl -sSL https://googleapis.dev/dotnet/Google.Apis/latest/xrefmap.yml -o dependencies/xrefmaps/Google.Apis.xrefmap.yml
curl -sSL https://googleapis.dev/dotnet/Google.Apis.Core/latest/xrefmap.yml -o dependencies/xrefmaps/Google.Apis.Core.xrefmap.yml
curl -sSL https://googleapis.dev/dotnet/Google.Apis.Auth/latest/xrefmap.yml -o dependencies/xrefmaps/Google.Apis.Auth.xrefmap.yml
curl -sSL https://googleapis.dev/dotnet/Google.Apis.Storage.v1/latest/xrefmap.yml -o dependencies/xrefmaps/Google.Apis.Storage.v1.xrefmap.yml
curl -sSL https://googleapis.dev/dotnet/Google.Apis.Bigquery.v2/latest/xrefmap.yml -o dependencies/xrefmaps/Google.Apis.Bigquery.v2.xrefmap.yml

# Restore packages and build metadata
(cd dependencies/gax-dotnet;
 dotnet restore Gax.sln
 $DOCFX metadata)

(cd dependencies/protobuf;
 $DOCFX metadata)

(cd dependencies/grpc; 
 $DOCFX metadata)

# Copy the metadata into a single api directory, one subdirectory per package
mkdir dependencies/api
cp -r dependencies/{gax-dotnet,protobuf,grpc}/api/* dependencies/api
for dir in dependencies/api/*
do
  # Make the build scripts significantly simpler...
  mv $dir/toc.yml $dir/toc
done

git -C dependencies add --all

echo "Done. Commit and push new files after checking they look okay."
