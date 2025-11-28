#!/bin/sh

set -e

if [[ -z "$1" || -z "$2" || -z "$3" || -z "$4" ]]
then
  echo "Usage: uploaddocs.sh <nupkg directory> <docs output directory> <service account json> <googleapis.dev staging bucket> <devsite staging bucket>"
  echo "or: uploaddocs.sh <nupkg directory> <docs output directory> <googleapis.dev staging bucket> <devsite staging bucket>"
  exit 1
fi

declare -r NUPKG_DIR=$1
declare -r DOCS_OUTPUT_DIR=$2

if [[ -z "$5" ]]
then
  declare -r SERVICE_ACCOUNT_JSON=adc
  declare -r GOOGLEAPIS_DEV_STAGING_BUCKET=$3
  declare -r DEVSITE_STAGING_BUCKET=$4
else
  declare -r SERVICE_ACCOUNT_JSON=$(realpath $3)
  declare -r GOOGLEAPIS_DEV_STAGING_BUCKET=$4
  declare -r DEVSITE_STAGING_BUCKET=$5
fi

for nupkg in $NUPKG_DIR/*.nupkg
do
  pair=$(basename $nupkg | sed -r 's/^(.*)\.([0-9]+\.[0-9]+\.[0-9]+(-.*)?)\.nupkg$/\1 \2/g')
  pkg=$(echo $pair | cut -d\  -f 1)
  version=$(echo $pair | cut -d\  -f 2)

  # Legacy comment - as of 2025-04-10 I (jonskeet@google.com) believe the comment
  # below to be untrue (and massively out of date) but I'll leave the comment and
  # logic in place for now, in the hope that we can remove this script entirely.
  #
  # Currently we don't generate documentation for libraries such as
  # Google.Cloud.Spanner.V1.Common. When we've moved entirely to googleapis.dev,
  # we can change this to generate reference documentation for all packages.
  if [[ -d $DOCS_OUTPUT_DIR/$pkg/site ]]
  then
    echo "Uploading docs for package $pkg version $version"
    pushd $DOCS_OUTPUT_DIR/$pkg/site > /dev/null

    # We need to perform a few fix-ups of the docfx generated site for googleapis.dev:
    # - Remove the "All APIs" link, as that page isn't included on googleapis.dev
    # - Add an xrefmap baseUrl

    if grep -q "All APIs" toc.html
    then
      echo "Removing 'All APIs' link"
      sed -i '16,18d' toc.html
    else
      echo "No 'All APIs' link to remove"
    fi
    
    if ! head xrefmap.yml | grep -q baseUrl
    then
      sed -i "1s/^/baseUrl: https:\/\/googleapis.dev\/dotnet\/$pkg\/$version\/\n/" xrefmap.yml
    fi

    # TODO: Product page
    echo "Generating metadata (googleapis.dev)"
    dotnet docuploader create-metadata --name $pkg --version $version --language dotnet --github-repository googleapis/google-cloud-dotnet
    
    echo "Final upload stage (googleapis.dev)"
    dotnet docuploader upload --documentation-path . --credentials $SERVICE_ACCOUNT_JSON --staging-bucket $GOOGLEAPIS_DEV_STAGING_BUCKET

    # Upload to DevSite, only for Cloud/Cloud-related packages
    if [[ -d ../devsite ]]
    then
      # For DevSite, we've already generated the metadata file, so we just need to do the upload.
      cd ../devsite
    
      echo "Final upload stage (DevSite)"
      dotnet docuploader upload --documentation-path . --credentials $SERVICE_ACCOUNT_JSON --staging-bucket $DEVSITE_STAGING_BUCKET --destination-prefix docfx
    fi
    
    popd > /dev/null
  else
    echo "Skipping $pkg; no documentation generated"
  fi 
done
