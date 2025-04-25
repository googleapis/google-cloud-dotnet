#!/bin/bash

# Environment variables:
# - SKIP_NUGET_PUSH: If non-empty, the push to nuget.org is skipped
# - SKIP_GOOGLEAPISDEV_UPLOAD: If non-empty, the push to googleapis.dev is skipped

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

source $SCRIPT_DIR/populatesecrets.sh

git config --global core.longpaths true

# We don't clone the repo anymore, we release in place.
# But Kokoro is not fetching submodules when cloning the repo itself.
git submodule update --init --recursive

# Only populate secrets if we have to.
# Else, we assume secrets have already been populated by the caller.
populatesecrets=true
if [[ "$#" -eq 1 ]] && [[ "$1" == "--skippopulatesecrets" ]]
then
    populatesecrets=false
    echo "Skipping populate secrets."
elif [[ "$#" -gt 0 ]]
then
    echo "Usage: $0 [--skippopulatesecrets]"
    exit 1
fi
if [[ "$populatesecrets" == "true" ]]
then
    populate_all_secrets
fi

export GOOGLE_APPLICATION_CREDENTIALS="$SECRETS_LOCATION/cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$SECRETS_LOCATION/gcloud-devel-service-account"

DOCS_CREDENTIALS="$SECRETS_LOCATION/docuploader_service_account"
GOOGLE_CLOUD_NUGET_API_KEY="$(cat "$SECRETS_LOCATION"/google-cloud-nuget-api-key)"
GOOGLE_APIS_PACKAGES_NUGET_API_KEY="$(cat "$SECRETS_LOCATION"/google-apis-nuget-api-key)"

if [[ $COMMITTISH_OVERRIDE != "" ]]
then
    git checkout $COMMITTISH_OVERRIDE
fi

# Build the release and run the tests.
./buildrelease.sh

# Restore tools just in case we haven't done so already.
# (If we're using autorelease, this should have happened, but
# doing it again is harmless.) This will make the SBOM generator available.
dotnet tool restore

if [[ $SKIP_NUGET_PUSH = "" ]]
then
  echo "Pushing NuGet packages"
  # Push the changes to nuget.
  cd ./nuget
  for pkg in *.nupkg
  do
    # Work out just the package ID based on the filename.
    pkg_id=$(echo $pkg | sed -r 's/^(.*)\.([0-9]+\.[0-9]+\.[0-9]+(-.*)?)\.nupkg$/\1/g')
    
    # Google.Cloud.Tools.* don't exist in apis.json, but are always owned by google-cloud
    if [[ $pkg_id == Google.Cloud.Tools.* ]]
    then
      package_owner=google-cloud
    else
      # Work out the package owner based on apis.json and the package ID
      default_package_owner=$([[ $pkg == Google.Cloud* ]] && echo google-cloud || echo google-apis-packages)
      package_owner=$(dotnet run --project ../tools/Google.Cloud.Tools.ReleaseManager -- query-api-catalog get-field $pkg_id packageOwner $default_package_owner)
    fi
    
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

    dotnet generate-sbom $pkg
    dotnet nuget push -s https://api.nuget.org/v3/index.json -k $pkg_nuget_api_key $pkg
  done
  cd ..
else
  echo "Skipping NuGet push"
fi

# Push documentation, if we've got the right credentials and haven't been asked to skip
if [[ -f $DOCS_CREDENTIALS && $SKIP_GOOGLEAPISDEV_UPLOAD = "" ]]
then
  echo "Uploading documentation to googleapis.dev and devsite"
  ./uploaddocs.sh nuget docs/output $DOCS_CREDENTIALS docs-staging docs-staging-v2
else
  echo "Skipping googleapis.dev and devsite upload"
fi

# Process the build log
./processbuildtiminglog.sh
