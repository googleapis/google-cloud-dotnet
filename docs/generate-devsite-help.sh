#!/bin/bash

set -e
REPOROOT=$(git rev-parse --show-toplevel)

if [[ -z "$1" ]]
then
  echo 'Please specify notional version'
  exit 1
fi

dotnet tool restore > /dev/null

declare -r DEVSITE_STAGING_BUCKET=docs-staging-v2
declare -r VERSION=$1

# Build the snippets for the help docset
dotnet run --project $REPOROOT/tools/Google.Cloud.Tools.GenerateSnippetMarkdown -- help

rm -rf output/devsite-help
mkdir -p output/devsite-help/api
mkdir -p output/devsite-help/examples

cp devsite-help/* output/devsite-help/api
cp output/help/obj/snippets/* output/devsite-help/examples

cd output/devsite-help

# Create the docs metadata. We assume we may need to refer to any of the utility libraries.
# We also refer to Datastore, PubSub and Storage.
dotnet docuploader create-metadata \
  --name help \
  --version $VERSION \
  --xref-services 'https://xref.docs.microsoft.com/query?uid={uid}' \
  --xrefs devsite://dotnet/Google.Protobuf,\
devsite://dotnet/Grpc.Core,\
devsite://dotnet/Google.Api.CommonProtos,\
devsite://dotnet/Google.Api.Gax,\
devsite://dotnet/Google.Apis,\
devsite://dotnet/Google.Cloud.PubSub.V1,\
devsite://dotnet/Google.Cloud.Datastore.V1,\
devsite://dotnet/Google.Cloud.Storage.V1 \
  --language dotnet 

# Tar up the file ready to be uploaded.
tar czvf ../docfx-dotnet-help-$VERSION.tar.gz .

cd ../..

echo 'Building site for local debugging purposes'
cp devsite-help-docfx.json output/devsite-help/docfx.json
dotnet docfx build --disableGitFeatures output/devsite-help/docfx.json

echo 'Done'
