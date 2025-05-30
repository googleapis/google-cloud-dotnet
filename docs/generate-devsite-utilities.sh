#!/bin/bash

set -e
REPOROOT=$(git rev-parse --show-toplevel)

dotnet tool restore > /dev/null

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

set -eu -o pipefail

declare -r DEVSITE_STAGING_BUCKET=docs-staging-v2
declare -r UTILITY_TYPE=$1
declare -r VERSION=$2

# These are listed in the order of dependencies:
# each type only depends on types listed earlier
case $UTILITY_TYPE in
  # It's clearer to users if we specify the NuGet
  # package version, but the tag needs to be the
  # "main" protobuf version. At the moment, that's
  # just a matter of replacing "3." with "v".
  protobuf)
    declare -r REPO=https://github.com/protocolbuffers/protobuf
    declare -r TAG=$(echo $VERSION | sed 's/^3\./v/g')
    declare -r DEVSITE_PACKAGE=Google.Protobuf
    declare -a XREFS=(
    )
    ;;
  google-apis)
    declare -r REPO=https://github.com/googleapis/google-api-dotnet-client
    declare -r DEVSITE_PACKAGE=Google.Apis
    declare -r TAG=v$VERSION
    declare -a XREFS=(
    )
    ;;
  common-proto)
    declare -r REPO=https://github.com/googleapis/gax-dotnet
    declare -r TAG=Google.Api.CommonProtos-$VERSION
    declare -r DEVSITE_PACKAGE=Google.Api.CommonProtos
    declare -a XREFS=(
      'Google.Protobuf'
    )
    ;;
  grpc)
    declare -r REPO=https://github.com/grpc/grpc-dotnet
    declare -r TAG=v$VERSION
    declare -r DEVSITE_PACKAGE=Grpc.Core
    declare -a XREFS=(
      'Google.Apis'
    )
    ;;
  gax)
    declare -r REPO=https://github.com/googleapis/gax-dotnet
    declare -r TAG=Google.Api.Gax-$VERSION
    declare -r DEVSITE_PACKAGE=Google.Api.Gax
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

# Hack for google-apis; harmless for others.
mkdir -p output/repo/NuPkgs/Support

cp dependencies-docfx/docfx-$UTILITY_TYPE.json output/repo/docfx.json

echo 'Running docfx metadata'
dotnet docfx metadata --logLevel Error output/repo/docfx.json

if [[ ! -d output/repo/api ]]
then
  echo "No API metadata generated. Exiting."
  exit 1
fi

cd output
mkdir -p utility/devsite

# It's unclear why we need to do this, but without it we regularly
# get errors when trying the directory move.
mv_attempts=10
until [[ $mv_attempts == 0 ]]
do
  mv repo/api utility/devsite/api/ && break
  mv_attempts=$((mv_attempts-1))
  if [[ $mv_attempts == 0 ]]
  then
    echo 'Failed to move output directory. Aborting.'
    exit 1
  else
    echo "Retrying move after sleep. Attempts left: $mv_attempts"
  fi
  sleep 1
done

echo 'Regenerating TOC'
dotnet run --project $REPOROOT/tools/Google.Cloud.Tools.RegenerateToc -- utility/devsite/api

echo "Post-processing YAML metadata files"
dotnet run --project $REPOROOT/tools/Google.Cloud.Tools.PostProcessDevSite -- utility

cd utility/devsite

echo 'Creating metadata file'

XREF_TMP=""
for xref in "${XREFS[@]}"
do
  FULL_XREF="devsite://dotnet/$xref"
  if [[ $XREF_TMP == "" ]]
  then
    XREF_TMP=$FULL_XREF
  else
    XREF_TMP="$XREF_TMP,$FULL_XREF"
  fi
done

if [[ $XREF_TMP == "" ]]
then
  XREF_FLAGS=""
else
  XREF_FLAGS="--xrefs $XREF_TMP"
fi

dotnet docuploader create-metadata \
  --name $DEVSITE_PACKAGE \
  --version $VERSION \
  --language dotnet \
  --xref-services 'https://xref.docs.microsoft.com/query?uid={uid}' \
  $XREF_FLAGS

# Tar up the file ready to be uploaded.
tar czvf ../../docfx-dotnet-$DEVSITE_PACKAGE-$VERSION.tar.gz .

echo 'Done'
