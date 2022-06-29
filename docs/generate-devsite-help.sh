#!/bin/bash

set -e

if [[ -z "$1" ]]
then
  echo 'Please specify notional version'
  exit 1
fi

source ../toolversions.sh

install_docfx

if [[ "$2" != "" ]]
then
  declare -r SERVICE_ACCOUNT_JSON=$2
else
  declare -r SERVICE_ACCOUNT_JSON=""
fi

declare -r DEVSITE_STAGING_BUCKET=docs-staging-v2
declare -r VERSION=$1

# Build the snippets for the help docset
dotnet run --project ../tools/Google.Cloud.Tools.GenerateSnippetMarkdown -- help

rm -rf output/devsite-help
mkdir -p output/devsite-help/api
mkdir -p output/devsite-help/examples

cp devsite-help/* output/devsite-help/api
cp output/help/obj/snippets/* output/devsite-help/examples

cd output/devsite-help

# Make sure we have the most recent version of pip, then install the gcp-docuploader package
python -m pip install -q --upgrade pip
python -m pip install -q gcp-docuploader

# Create the docs metadata. We assume we may need to refer to any of the utility libraries.
# We also refer to Datastore, PubSub and Storage.
python -m docuploader create-metadata \
  --name help \
  --version $VERSION \
  --xref-services 'https://xref.docs.microsoft.com/query?uid={uid}' \
  --xrefs devsite://dotnet/Google.Protobuf \
  --xrefs devsite://dotnet/Grpc.Core \
  --xrefs devsite://dotnet/Google.Api.CommonProtos \
  --xrefs devsite://dotnet/Google.Api.Gax \
  --xrefs devsite://dotnet/Google.Apis \
  --xrefs devsite://dotnet/Google.Cloud.PubSub.V1 \
  --xrefs devsite://dotnet/Google.Cloud.Datastore.V1 \
  --xrefs devsite://dotnet/Google.Cloud.Storage.V1 \
  --language dotnet  

if [[ $SERVICE_ACCOUNT_JSON != "" ]]
then
  python -m docuploader upload \
    . \
    --credentials $SERVICE_ACCOUNT_JSON \
    --staging-bucket $DEVSITE_STAGING_BUCKET \
    --destination-prefix docfx
else
  echo 'Service account JSON file not specified; skipping upload'
fi

cd ../..

echo 'Building site for local debugging purposes'
cp devsite-help-docfx.json output/devsite-help/docfx.json
$DOCFX build --disableGitFeatures output/devsite-help/docfx.json

echo 'Done'
