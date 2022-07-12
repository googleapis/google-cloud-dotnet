#!/bin/bash

set -e

# This script repopulates the dependencies directory.
# It must be run as a user with application default credentials
# that can access the docs-staging-v2 GCS bucket.

# Blow away any previous files
rm -rf dependencies
mkdir dependencies

# Fetch the cloud.google.com dependencies
dotnet run --project ../tools/Google.Cloud.Tools.FetchDependencyXrefmaps

# Fetch the dependency maps for the REST libraries we depend on
# TODO: The xref maps stopped being generated properly in early May 2022.
# We need to find out why, and then update this to "latest" instead of specific versions.
curl -sSL https://googleapis.dev/dotnet/Google.Apis.Storage.v1/1.57.0.2647/xrefmap.yml -o dependencies/Google.Apis.Storage.v1.xrefmap.yml
curl -sSL https://googleapis.dev/dotnet/Google.Apis.Bigquery.v2/1.57.0.2668/xrefmap.yml -o dependencies/Google.Apis.Bigquery.v2.xrefmap.yml
