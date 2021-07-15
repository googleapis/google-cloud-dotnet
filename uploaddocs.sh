#!/bin/sh

set -e

if [[ -z "$1" || -z "$2" || -z "$3" || -z "$4" || -z "$5" ]]
then
  echo "Usage: uploaddocs.sh <nupkg directory> <docs output directory> <service account json> <googleapis.dev staging bucket> <devsite staging bucket>"
  exit 1
fi

declare -r NUPKG_DIR=$1
declare -r DOCS_OUTPUT_DIR=$2
declare -r SERVICE_ACCOUNT_JSON=$(realpath $3)
declare -r GOOGLEAPIS_DEV_STAGING_BUCKET=$4
declare -r DEVSITE_STAGING_BUCKET=$5

# Make sure we have the most recent version of pip, then install the gcp-docuploader package
python -m pip install --upgrade pip
python -m pip install -q gcp-docuploader

for nupkg in $NUPKG_DIR/*.nupkg
do
  pair=$(basename $nupkg | sed -r 's/^(.*)\.([0-9]+\.[0-9]+\.[0-9]+(-.*)?)\.nupkg$/\1 \2/g')
  pkg=$(echo $pair | cut -d\  -f 1)
  version=$(echo $pair | cut -d\  -f 2)
  
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
    python -m docuploader create-metadata --name $pkg --version $version --language dotnet --github-repository googleapis/google-cloud-dotnet
    
    echo "Final upload stage (googleapis.dev)"
    python -m docuploader upload . --credentials $SERVICE_ACCOUNT_JSON --staging-bucket $GOOGLEAPIS_DEV_STAGING_BUCKET

    # Upload to DevSite, only for Cloud/Cloud-related packages
    if [[ -d ../devsite ]]
    then
      # For DevSite, we've already generated the metadata file, so we just need to do the upload.
      cd ../devsite
    
      echo "Final upload stage (DevSite)"
      python -m docuploader upload . --credentials $SERVICE_ACCOUNT_JSON --staging-bucket $DEVSITE_STAGING_BUCKET --destination-prefix docfx
    fi
    
    popd > /dev/null
  else
    echo "Skipping $pkg; no documentation generated"
  fi 
done
