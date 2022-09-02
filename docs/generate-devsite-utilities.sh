#!/bin/bash

source ../toolversions.sh

install_docfx

# Some versions of docfx fail if VSINSTALLDIR is set.
export VSINSTALLDIR=

if [[ -z "$1" || -z "$2" ]]
then
  echo 'Please specify utility and version'
  echo 'Known types: google-apis protobuf common-proto grpc gax help'
  exit 1
fi

# We use this script as a simple bootstrapper for uploading
# a help package (to avoid near-duplicate Kokoro scripts and configs).
# Just delegate to the dedicated help script, and exit.
if [[ "$1" == "help" ]]
then
  ./generate-devsite-help.sh $2 $3
  exit 0
fi

if [[ "$3" != "" ]]
then
  declare -r SERVICE_ACCOUNT_JSON=$3
else
  declare -r SERVICE_ACCOUNT_JSON=""
fi

set -eu -o pipefail

declare -r DEVSITE_STAGING_BUCKET=docs-staging-v2
declare -r VERSION=$2

# These are listed in the order of dependencies:
# each type only depends on types listed earlier
case $1 in
  protobuf)
    declare -r REPO=https://github.com/protocolbuffers/protobuf
    declare -r TAG=v$VERSION
    declare -r DEVSITE_PACKAGE=Google.Protobuf
    declare -a PROJECTS=(
      'csharp/src/Google.Protobuf'
    )
    declare -r TARGET_FRAMEWORK=netstandard2.0
    declare -a XREFS=(
    )
    ;;
  google-apis)
    declare -r REPO=https://github.com/googleapis/google-api-dotnet-client
    declare -r DEVSITE_PACKAGE=Google.Apis
    declare -r TAG=v$VERSION
    declare -a PROJECTS=(
      'Src/Support/Google.Apis'
      'Src/Support/Google.Apis.Auth'
      'Src/Support/Google.Apis.Auth.AspNetCore3'
      'Src/Support/Google.Apis.Core'
    )
    declare -r TARGET_FRAMEWORK=netcoreapp3.1
    declare -a XREFS=(
    )
    ;;
  common-proto)
    declare -r REPO=https://github.com/googleapis/gax-dotnet
    declare -r TAG=Google.Api.CommonProtos-$VERSION
    declare -r DEVSITE_PACKAGE=Google.Api.CommonProtos
    declare -a PROJECTS=(
      'Google.Api.CommonProtos'
    )
    declare -r TARGET_FRAMEWORK=net461
    declare -a XREFS=(
      'Google.Protobuf'
    )
    ;;
  grpc)
    declare -r REPO=https://github.com/grpc/grpc-dotnet
    declare -r TAG=v$VERSION
    declare -r DEVSITE_PACKAGE=Grpc.Core
    declare -a PROJECTS=(
      'src/Grpc.Auth'
      'src/Grpc.Core.Api'
    )
    declare -r TARGET_FRAMEWORK=netstandard2.0
    declare -a XREFS=(
      'Google.Apis'
    )
    ;;
  gax)
    declare -r REPO=https://github.com/googleapis/gax-dotnet
    declare -r TAG=Google.Api.Gax-$VERSION
    declare -r DEVSITE_PACKAGE=Google.Api.Gax
    declare -a PROJECTS=(
      'Google.Api.Gax'
      'Google.Api.Gax.Grpc'
      'Google.Api.Gax.Grpc.Testing'
      'Google.Api.Gax.Rest'
      'Google.Api.Gax.Testing'
    )
    declare -r TARGET_FRAMEWORK=net462
    declare -a XREFS=(
      'Google.Protobuf'
      'Google.Api.CommonProtos'
      'Grpc.Core'
      'Google.Apis'
    )
    ;;
  *)
    echo "Invalid utility $1"
    exit 1
esac

rm -rf output
mkdir output
echo "Cloning $REPO"
git clone -q $REPO -b $TAG --depth=1 -c advice.detachedHead=false output/repo

PROJECTS_TMP=""
for project in "${PROJECTS[@]}"
do
  PROJECTS_TMP="$PROJECTS_TMP output/repo/$project/*.csproj"
done

echo 'Running docfx metadata'
$DOCFX metadata --logLevel Error -o output --property TargetFramework=$TARGET_FRAMEWORK $PROJECTS_TMP

# This will have created an output/output directory. 
# (For some reason docfx takes "output" and doubles it to output/output.)
# We rename this to output/devsite/api so we can use output/devsite as the
# "root" directory for docuploader.
# (This will make it easier to add snippets in the future if we want to.)
cd output
mkdir devsite

# It's unclear why we need to do this, but without it we regularly
# get errors when trying the directory move.
mv_attempts=10
until [[ $mv_attempts == 0 ]]
do
  mv output/ devsite/api/ && break
  mv_attempts=$((mv_attempts-1))
  if [[ mv_attempts == 0 ]]
  then
    echo 'Failed to move output directory. Aborting.'
    exit 1
  else
    echo "Retrying move after sleep. Attempts left: $mv_attempts"
  fi
  sleep 1
done

echo 'Regenerating TOC'
dotnet run --project ../../tools/Google.Cloud.Tools.RegenerateToc -- devsite/api

cd devsite

echo 'Creating metadata file'

XREF_TMP=""
for xref in "${XREFS[@]}"
do
  FULL_XREF="devsite://dotnet/$xref"
  XREF_TMP="$XREF_TMP --xrefs $FULL_XREF"
done

python -m docuploader create-metadata \
  --name $DEVSITE_PACKAGE \
  --version $VERSION \
  --xref-services 'https://xref.docs.microsoft.com/query?uid={uid}' \
  $XREF_TMP \
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

echo 'Done'
