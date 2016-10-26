#!/bin/bash

# Script to create a release (with corresponding tag) on github.
# Sample: tagrelease.sh Google.Pubsub.V1 1.0.0-beta05
# Make sure github_access_token is set to a valid github personal
# access token first.

# TODO: Auto-detect the version from project.json.

set -e

if [ -z "$1" -o -z "$2" ]
then
  echo Please specify API name and version
  exit 1
fi

if [ -z "$github_access_token" ]
then
  echo Please set github_access_token first
  exit
fi

api=$1
version=$2

# Do everything from the repository root for sanity.
cd $(dirname $0)

# Check that the API exists. Some libraries
# don't exist in an api/api directory; allow an override with --force
# for now.
# TODO: Allow X/Y format, e.g. Google.Logging.V2/Google.Logging.Type
if [ ! -d apis/$api ]
then
  if [[ "$3" == "--force" ]]
  then
    echo Can\'t find apis/$api\, but --force specified.
  else
    echo Can\'t find apis/$api\; check for typos
    exit 1
  fi
fi

# Check that our master is up-to-date with upstream.
# This will exit with a non-zero error code if the line isn't found.
# TODO: Is this the best way to do this?
git fetch -v --dry-run upstream 2>&1 \
  | grep -E '\[up to date\]\s+master\s+->\s+upstream/master' > /dev/null \
  || (echo Please update your local git repo before creating a release; exit 1)

echo Creating release for API $api version $version

commit=`git rev-parse master`
[[ $version =~ ^(0\..*)|(.*-.*)$ ]] && prerelease="true" || prerelease="false"

api_json=`cat << EndOfJson
{
  "tag_name": "$api-$version",
  "target_commitish": "$commit",
  "name": "$version release of $api",
  "body": "",
  "draft": false,
  "prerelease": $prerelease
}
EndOfJson`

# TODO: Work out what to do with the output of this
curl --data "$api_json" https://api.github.com/repos/GoogleCloudPlatform/google-cloud-dotnet/releases?access_token=$github_access_token

echo Created release $api-$version.

# Plan:
# Accept API name and version, e.g. tagrelease.sh Google.Pubsub.V1 1.0.0-beta03
# Check that the local repo is up to date, using git fetch -v --dry-run upstream
# Check http://www.barrykooij.com/create-github-releases-via-command-line/
