#!/bin/bash

# Script to push a release to nuget or myget.
# Prerequisites:
# - myget_api_key or nuget_api_key is set appropriately
# - The release has been created and built (see tagrelease.sh and
#   buildrelease.sh)
#
# Note that buildrelease.sh doesn't have to have been invoked with
# the same API name and version, so long as the tag is for the same
# commit.

# Sample: pushrelease.sh Google.Pubsub.V1 1.0.0-beta05

set -e

if [ -z "$1" -o -z "$2" ]
then
  echo Please specify API name and version
  exit 1
fi

# Start from the repository root for sanity.
cd $(dirname $0)

if [ ! -d "releasebuild" ]
then
  echo Please run the release build first
  exit 1
fi

api=$1
version=$2
tag="$api"-"$version"

cd releasebuild

git tag | grep -x "$tag" \
  || (echo "Tag $tag appears not to exist. Did you run tagrelease.sh?"; exit 1)

# Check that they're the same commit...
tagcommit=`git rev-parse $tag`
headcommit=`git rev-parse HEAD`

if [ "$tagcommit" != "$headcommit" ]
then
  echo "Tag commit ($tagcommit) is not the same as the HEAD commit ($headcommit)"
  exit 1
fi

packagefile="apis/$api/$api/bin/Release/$api.$version.nupkg"

if [ ! -e "$packagefile" ]
then
  echo "Package file $packagefile not found. Bad build?"
  exit 1
fi

# TODO: Do these two in a single block
[[ $version =~ ^0\..*$ ]] && \
  nuget_source="https://www.myget.org/F/google-dotnet-public/api/v2/package" || \
  nuget_source="https://www.nuget.org/api/v2/package"

[[ $version =~ ^0\..*$ ]] && \
  api_key="$myget_api_key" || \
  api_key="$nuget_api_key"

if [ -z "$api_key" ]
then
  echo "Please set the relevant API key environment variable"
  exit 1
fi

echo "Pushing $api version $version to $nuget_source"

nuget push -Source "$nuget_source" -ApiKey "$api_key" "$packagefile"
