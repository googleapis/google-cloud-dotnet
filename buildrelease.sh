#!/bin/bash

# Script to perform a release build for all APIs, based on
# the tag for a single API version.
# Sample: buildrelease.sh Google.Pubsub.V1 1.0.0-beta05

# The repo is cloned into a fresh "releasebuild" directory.

set -e

if [ -z "$1" -o -z "$2" ]
then
  echo Please specify API name and version
  exit 1
fi

tag=$1-$2

# TODO: We don't really want a regex here... just a match.
git fetch -v --dry-run --tags upstream 2>&1 \
  | grep -e $tag > /dev/null \
  || (echo "Tag $tag appears not to exist. Did you run tagrelease.sh?"; exit 1)

# Do everything from the repository root for sanity.
cd $(dirname $0)

rm -rf releasebuild
git clone https://github.com/GoogleCloudPlatform/google-cloud-dotnet.git releasebuild
cd releasebuild
git checkout $tag
NOVERSIONSUFFIX=yes ./build.sh
mkdir nuget
cp `find . -name '*.nupkg'` nuget

# TODO: Make builddocs.sh cope with being run from any directory.
cd docs
./builddocs.sh
