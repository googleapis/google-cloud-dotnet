#!/bin/bash

# Script to perform a release build for all APIs tagged at HEAD.

set -e

# Optional arguments:
# --rebuild_docs: Just build the projects and docs, don't create nuget packages.
# --skip_tests: Skip the integration tests
rebuild_docs=false
run_tests=true
while (( "$#" )); do
  if [[ "$1" == "--rebuild_docs" ]]
  then
    rebuild_docs=true
  elif [[ "$1" == "--skip_tests" ]]
  then
    run_tests=false
  else
    echo "Incorrect arguments."
  exit 1
  fi
  shift
done

# Do everything from the repository root for sanity.
cd $(dirname $0)

# Make sure the package is deterministic. We don't do this for local builds,
# but it makes debugging work more reliably for PDBs in packages.
export DeterministicSourcePaths=true

# Turn the multi-line output of git tag into space-separated list of projects
projects=$(git tag --points-at HEAD | sed 's/-.*//g' | awk -vORS=\  '{print $1}' | sed 's/ $//')

if [ -z "$projects" ]
then
  echo "No tags found for commit $(git rev-parse HEAD)"
  exit 1
fi

# If we're building at least one tool, assume we're not building anything else: we just need to pack
# the tools into the nuget directory, and finish.
if [[ $projects == Google.Cloud.Tools.* ]]
then
  for project in $projects
  do
    dotnet pack -c Release -o $PWD/nuget tools/$project
  done
  exit 0
fi

./build.sh $projects

# Build LRO and IAM to make docs simpler.
./build.sh Google.LongRunning Google.Cloud.Iam.V1

# Retry integration tests up to 3 times as they can sometimes
# be a little flakey.
if [[ "$run_tests" = true ]]
then
  ./runintegrationtests.sh $projects || ./runintegrationtests.sh --retry || ./runintegrationtests.sh --retry
fi

if [[ "$rebuild_docs" = false ]]
then
  for project in $projects
  do
    # Don't pack the whole solution - just the project. (Avoids packing dependent
    # projects such as Google.LongRunning.)
    dotnet pack --no-build --no-restore -o $PWD/nuget -c Release apis/$project/$project
  done
fi

# TODO: Make builddocs.sh cope with being run from any directory.
(cd docs && ./builddocs.sh $projects)

echo "Release build and docs complete for the following projects:"
for project in $projects
do
  echo "- ${project}"
done
if [[ "$rebuild_docs" = false ]]
then
  echo "- Push packages to nuget:"
  echo "  - cd releasebuild/nuget"
  echo "  - Remove any packages you don't want to push"
  echo "  - for pkg in *.nupkg; do dotnet nuget push -s https://api.nuget.org/v3/index.json -k API_KEY_HERE \$pkg; done"
fi
