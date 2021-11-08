#!/bin/bash

# Script to report each tag in git that doesn't have a corresponding
# package on nuget.org. There are a few reasons for this:
# - The Kokoro release build wasn't triggered
# - The Kokoro release build failed
# - The package has been deleted
# - The tag is an ancient one that doesn't represent a package

set -e

# Make sure we have all the tags locally.
git fetch --tags -f -q upstream main

FAILURES=0
# Order by "most recent first" as those are the tags we're
# most likely to care about.
TAGS=$(git tag --sort=-creatordate)

echo "Checking $(echo $TAGS | wc -w) tags"

for tag in $TAGS
do
  # Show progress - and also make the script easier to kill
  # (git bash appears not to notice ^-C until there's output.)
  echo -n "."
  PACKAGE=$(echo $tag | cut --delimiter=- --fields=1)
  VERSION=$(echo $tag | cut --delimiter=- --fields=2-)
  # Fetch the status code via a HEAD request, using the lower-cased version
  # of the package name.
  STATUS=$(curl -I https://globalcdn.nuget.org/packages/${PACKAGE,,}.$VERSION.nupkg \
      2>/dev/null \
      | head -n 1 | cut -d$' ' -f2)
  if [[ $STATUS != "200" ]]
  then
    # Start on a new line...
    echo ""
    # Show the date and tag name that doesn't have a matching package
    echo "$(git log -1 --format=%aI $tag): $tag"
    FAILURES=$((FAILURES+1))
  fi
done

# Start on a new line...
echo ""
echo "Failures: $FAILURES"
