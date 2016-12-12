#!/bin/bash

# Script to create a release (with corresponding tag) on github.
# Sample: tagrelease.sh Google.Pubsub.V1 1.0.0-beta05
# Make sure github_access_token is set to a valid github personal
# access token first.

# TODO: Auto-detect the version from project.json.

set -e

if [ -z "$1" ]
then
  echo "Please specify API name and (optionally) package within API"
  exit 1
fi

if [ -z "$github_access_token" ]
then
  echo Please set github_access_token first
  exit
fi

api=$1
package=$2

[[ "$2" == "" ]] && \
  package="$1" || \
  package="$2"

# Do everything from the repository root for sanity.
cd $(dirname $0)

# Check that the API exists.
if [ ! -f apis/$api/$package/project.json ]
then
  echo "Can't find apis/$api/$package/project.json; check for typos"
  exit 1
fi

# Check that our master is up-to-date with upstream.
# This will exit with a non-zero error code if the line isn't found.
# TODO: Is this the best way to do this?
git fetch -v --dry-run upstream 2>&1 \
  | grep -E '\[up to date\]\s+master\s+->\s+upstream/master' > /dev/null \
  || (echo Please update your local git repo before creating a release; exit 1)

version=`grep -E '"version": "[0-9]+\.[0-9]+\.[0-9]+(-[a-z0-9]+)?-\*",' apis/$api/$package/project.json \
  | sed -E 's/"version": "//g' \
  | sed 's/-\*",//g' \
  | sed 's/ //g'`

echo "Creating release for package $package version $version"

commit=`git rev-parse master`
[[ $version =~ ^(0\..*)|(.*-.*)$ ]] && prerelease="true" || prerelease="false"

api_json=`cat << EndOfJson
{
  "tag_name": "$package-$version",
  "target_commitish": "$commit",
  "name": "$version release of $apackage",
  "body": "",
  "draft": false,
  "prerelease": $prerelease
}
EndOfJson`

# TODO: Work out what to do with the output of this
curl --data "$api_json" https://api.github.com/repos/GoogleCloudPlatform/google-cloud-dotnet/releases?access_token=$github_access_token

echo Created release $package-$version.
