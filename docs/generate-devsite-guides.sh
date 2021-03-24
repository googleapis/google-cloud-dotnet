#!/bin/bash

set -e

if [[ -z "$1" ]]
then
  echo 'Please specify notional version'
  exit 1
fi

if [[ "$2" != "" ]]
then
  declare -r SERVICE_ACCOUNT_JSON=$2
else
  declare -r SERVICE_ACCOUNT_JSON=""
fi

declare -r DEVSITE_STAGING_BUCKET=docs-staging-v2
declare -r VERSION=$1

# Build the "regular" root docs - this processes the snippets.
./builddocs.sh root

rm -rf output/devsite-guides
mkdir -p output/devsite-guides/api
mkdir -p output/devsite-guides/examples

cp root/*.md output/devsite-guides/api
cp root/*/*.md output/devsite-guides/api
cp output/root/obj/snippets/* output/devsite-guides/examples

# Remove the index, which isn't part of the DevSite Guides docset
rm output/devsite-guides/api/index.md

# Use xrefs instead of file references, so it links to the right place.
# Note that PagedEnumerable<,> generates a file of PagedEnumerable-2.html, but
# a UID of PagedEnumerable`2, so we need to fix that up (and similar)
sed -i -E 's/\.\.\/obj\/api\/(.*)\.yml/xref:\1/g' output/devsite-guides/api/*.md
sed -i -E 's/\.\.\/[^\/]+\/api\/(.*)\.html/xref:\1/g' output/devsite-guides/api/*.md
sed -i 's/PagedEnumerable-2/PagedEnumerable`2/g' output/devsite-guides/api/*.md
sed -i 's/PagedAsyncEnumerable-2/PagedAsyncEnumerable`2/g' output/devsite-guides/api/*.md
sed -i 's/Page-1/Page`1/g' output/devsite-guides/api/*.md

# Fix snippet inclusions, including flattening the hierarchy that
# exists in GitHub pages.
sed -i -E 's/\.\.\/obj\/snippets\//..\/examples\//g' output/devsite-guides/api/*.md
sed -i -E 's/obj\/snippets\//..\/examples\//g' output/devsite-guides/api/*.md

# Fix links within "root" to "guides" (due to flattened structure)
sed -i -E 's/\(guides\//\(/g' output/devsite-guides/api/*.md

# Copy the TOC, which is hard-coded (and slightly different to the GitHub Pages TOC)
cp devsite-guides-toc.yml output/devsite-guides/api/toc.yml

cd output/devsite-guides

# Make sure we have the most recent version of pip, then install the gcp-docuploader package
python -m pip install -q --upgrade pip
python -m pip install -q gcp-docuploader

# Create the docs metadata. We assume we may need to refer to any of the utility libraries.
# We also refer to Datastore, PubSub and Storage.
python -m docuploader create-metadata \
  --name guides \
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

echo 'Done'
