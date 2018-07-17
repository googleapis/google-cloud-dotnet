#!/bin/bash

set -e

cd ..

# Build the release and run the tests.
./buildrelease.sh --ssh $(git rev-parse HEAD)


# Add any docs cahnges if they exist.
cd ./releasebuild/releasedocs
git add --all
if ! git diff --quiet --cached; then git commit -m 'Regenerate docs'; git push; fi

cd ../..

#Push the changes to nuget.
cd ./releasebuild/nuget
for pkg in *.nupkg; do dotnet nuget push -s https://api.nuget.org/v3/index.json -k $NUGET_API_KEY $pkg; done
