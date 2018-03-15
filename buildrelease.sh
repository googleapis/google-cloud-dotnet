#!/bin/bash

# Script to perform a release build for all APIs tagged at
# a specific commit. A single argument is required: the commit to use.

# The repo is cloned into a fresh "releasebuild" directory.

set -e

if [ -z "$1" ]
then
  echo "Please specify a commit hash"
  exit 1
fi

commit=$1

# Do everything from the repository root for sanity.
cd $(dirname $0)

rm -rf releasebuild
git clone https://github.com/GoogleCloudPlatform/google-cloud-dotnet.git releasebuild -c core.autocrlf=input
cd releasebuild
export CI=true # Forces SourceLink in the main build.
git checkout $commit

# Turn the multi-line output of git tag --points-at into space-separated list of projects
projects=$(git tag --points-at $commit | sed 's/-.*//g' | awk -vORS=\  '{print $1}' | sed 's/ $//')

if [ -z "$projects" ]
then
  echo "No tags found for commit $commit"
  exit 1
fi

./build.sh $projects

./runintegrationtests.sh $projects

for project in $projects
do
  # Don't pack the whole solution - just the project. (Avoids packing dependent
  # projects such as Google.LongRunning.)
  dotnet pack --no-build --no-restore -o $PWD/nuget -c Release apis/$project/$project
done

# TODO: Make builddocs.sh cope with being run from any directory.
(cd docs && ./builddocs.sh root $projects)

rm -rf releasedocs
git clone git@github.com:GoogleCloudPlatform/google-cloud-dotnet.git releasedocs -b gh-pages --depth 1 -c core.autocrlf=input
cd releasedocs

for project in $projects
do
  rm -rf ./docs/$project
  mv ../docs/output/assembled/$project ./docs
done

mv -f ../docs/output/assembled/index.html ./docs/

echo "Release build and docs complete for the following projects:"
for project in $projects
do
  echo "- ${project}"
done
echo "Next steps:"
echo "- Upload new docs to gh-pages branch"
echo "  - cd releasebuild/releasedocs"
echo "  - git add --all"
echo "  - git commit -m 'Regenerate docs'"
echo "  - git push"
echo "- Push packages to nuget:"
echo "  - cd releasebuild/nuget"
echo "  - Remove any packages you don't want to push"
echo "  - for pkg in *.nupkg; do dotnet nuget push -s https://api.nuget.org/v3/index.json -k API_KEY_HERE \$pkg; done"
