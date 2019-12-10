#!/bin/bash

# Environment variables:
# - KOKORO_KEYSTORE_DIR: Where Kokoro copies the keys from Keystore
# - COMMITTISH_OVERRIDE: The commit to actually build the release from, if not the one that has been checked out
# - SKIP_NUGET_PUSH: If non-empty, the push to nuget.org is skipped
# - SKIP_PAGES_UPLOAD: If non-empty, the push to gh-pages is skipped
# - SKIP_GOOGLEAPISDEV_UPLOAD: If non-empty, the push to googleapis.dev is skipped

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_gcloud-devel-service-account"
export DOCS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73713_docuploader_service_account"
export NUGET_API_KEY="$(cat "$KOKORO_KEYSTORE_DIR"/73609_google-cloud-nuget-api-key)"

COMMITTISH=$COMMITTISH_OVERRIDE
if [[ $COMMITTISH_OVERRIDE = "" ]]
then
  COMMITTISH=$(git rev-parse HEAD)
else
  COMMITTISH=$COMMITTISH_OVERRIDE
fi

echo "Building with commit $COMMITTISH"

# Build the release and run the tests.
./buildrelease.sh --ssh $COMMITTISH


if [[ $SKIP_PAGES_UPLOAD = "" ]]
then
  echo "Pushing to GitHub pages"
  # Add any docs changes if they exist.
  cd ./releasebuild/releasedocs
  git add --all
  if ! git diff --quiet --cached; then git commit -m 'Regenerate docs'; git push; fi
  cd ../..
else
  echo "Skipping push to GitHub pages"
fi

if [[ $SKIP_NUGET_PUSH = "" ]]
then
  echo "Pushing NuGet packages"
  # Push the changes to nuget.
  cd ./releasebuild/nuget
  for pkg in *.nupkg; do dotnet nuget push -s https://api.nuget.org/v3/index.json -k $NUGET_API_KEY $pkg; done
  cd ../..
else
  echo "Skipping NuGet push"
fi

# Push documentation, if we've got the right credentials and haven't been asked to skip
if [[ -f $DOCS_CREDENTIALS && $SKIP_GOOGLEAPISDEV_UPLOAD = "" ]]
then
  echo "Uploading documentation to googleapis.dev"
  ./uploaddocs.sh releasebuild/nuget releasebuild/docs/output $DOCS_CREDENTIALS docs-staging
else
  echo "Skipping googleapis.dev upload"
fi

# Process the build log in releasebuild
cd releasebuild
./processbuildtiminglog.sh
