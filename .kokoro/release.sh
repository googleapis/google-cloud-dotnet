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

PYTHON3=$(source toolversions.sh && echo $PYTHON3)
DOCS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73713_docuploader_service_account"
GOOGLE_CLOUD_NUGET_API_KEY="$(cat "$KOKORO_KEYSTORE_DIR"/73609_google-cloud-nuget-api-key)"
GOOGLE_APIS_PACKAGES_NUGET_API_KEY="$(cat "$KOKORO_KEYSTORE_DIR"/73609_google-apis-nuget-api-key)"

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
  for pkg in *.nupkg
  do
    # Work out just the package ID based on the filename.
    pkg_id=$(echo $pkg | sed -r 's/^(.*)\.([0-9]+\.[0-9]+\.[0-9]+(-.*)?)\.nupkg$/\1/g')
    # Work out the package owner based on apis.json and the package ID
    default_package_owner=$([[ $pkg == Google.Cloud* ]] && echo google-cloud || echo google-api-packages)
    package_owner=$($PYTHON3 ../tools/getapifield.py ../apis/apis.json $pkg_id packageOwner --default=$default_package_owner)
    # Work out the right NuGet API key based on the package owner
    case "$package_owner" in
      google-cloud)
        pkg_nuget_api_key=$GOOGLE_CLOUD_NUGET_API_KEY
        ;;
      google-apis-packages)
        pkg_nuget_api_key=$GOOGLE_APIS_PACKAGES_NUGET_API_KEY
        ;;
      *)
       echo "No NuGet API key found for package owner $package_owner"
       exit 1
    esac
    
    dotnet nuget push -s https://api.nuget.org/v3/index.json -k $pkg_nuget_api_key $pkg
  done
  cd ../..
else
  echo "Skipping NuGet push"
fi

# Push documentation, if we've got the right credentials and haven't been asked to skip
if [[ -f $DOCS_CREDENTIALS && $SKIP_GOOGLEAPISDEV_UPLOAD = "" ]]
then
  echo "Uploading documentation to googleapis.dev and devsite"
  ./uploaddocs.sh releasebuild/nuget releasebuild/docs/output $DOCS_CREDENTIALS docs-staging docs-staging-v2-staging
else
  echo "Skipping googleapis.dev and devsite upload"
fi

# Process the build log in releasebuild
cd releasebuild
./processbuildtiminglog.sh
