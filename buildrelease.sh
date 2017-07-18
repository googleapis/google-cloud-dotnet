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
git clone https://github.com/GoogleCloudPlatform/google-cloud-dotnet.git releasebuild -c core.autocrlf=input
cd releasebuild
export CI=true # Forces SourceLink in the main build.
git checkout $tag
./build.sh
dotnet pack AllProjects.sln --no-build -o $PWD/nuget -c Release

# TODO: Make builddocs.sh cope with being run from any directory.
cd docs
./builddocs.sh

echo "Release build complete. Next steps:"
echo "- Upload new docs to gh-pages branch"
echo "- Push packages to nuget:"
echo "  - cd releasebuild/nuget"
echo "  - Remove any packages you don't want to push"
echo "  - for pkg in *.nupkg; do nuget push -Source nuget.org -ApiKey API_KEY_HERE \$pkg; done"
