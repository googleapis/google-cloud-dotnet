#!/bin/bash

set -e

source toolversions.sh
declare -r CORE_PROTOS_ROOT=$PROTOBUF_TOOLS_ROOT/tools

# This script generates all APIs from the googleapis/googleapis github repository,
# using the code generator from googleapis/gapic-generator-csharp.
# It will fetch both repositories if necessary.

OUTDIR=tmp

if [[ "$GOOGLEAPIS_DIR" != "" ]]
then
  declare -r GOOGLEAPIS="$GOOGLEAPIS_DIR"
else
  declare -r GOOGLEAPIS="$PWD/googleapis"
fi

# Allow pre/post-generation scripts to know where to find the repos
export GOOGLEAPIS

# We call ReleaseManager frequently; dotnet run takes a while to start it,
# even with --no-build and --no-restore.
# Using "dotnet" with the DLL is more portable than executing the .exe file directly.
# TODO: Rather than hard-coding this, we could build into a new directory (once)
# where we'd always have a fresh copy.
RELEASE_MANAGER_BINARY=tools/Google.Cloud.Tools.ReleaseManager/bin/Release/net6.0/Google.Cloud.Tools.ReleaseManager.dll

get_api_field() {
  # TODO: Echo the error if there's a failure. (It currently makes the script fail, but silently.)
  dotnet $RELEASE_MANAGER_BINARY query-api-catalog get-field "$@"
}

list_generated_apis() {
  dotnet $RELEASE_MANAGER_BINARY query-api-catalog list generator
}

fetch_github_repos() {
  # We assume that if the directory has been explicitly specified, we don't need
  # to fetch it.
  if [[ "$GOOGLEAPIS_DIR" != "" ]]
  then
    return 0
  fi

  if [ -d "$GOOGLEAPIS" ]
  then
    git -C $GOOGLEAPIS pull -q
  else
    # Auto-detect whether we're cloning the public or private googleapis repo.
    git remote -v | grep -q google-cloud-dotnet-private && repo=googleapis-private || repo=googleapis
    git clone https://github.com/googleapis/${repo} $GOOGLEAPIS --depth 1
  fi
}

delete_generated() {
  rm -f $1/*.g.cs
}

generate_microgenerator() {
  PACKAGE_ID=$1
  API_TMP_DIR=$OUTDIR/$PACKAGE_ID
  PRODUCTION_PACKAGE_DIR=$API_TMP_DIR/$PACKAGE_ID
  GRPC_GENERATION_DIR=$API_TMP_DIR/grpc-$PACKAGE_ID
  API_OUT_DIR=apis
  API_SRC_DIR=$GOOGLEAPIS/$(get_api_field $PACKAGE_ID protoPath)

  # Delete previously-generated files
  delete_generated apis/$1/$1
  delete_generated apis/$1/$1.Tests
  rm -f apis/$1/$1.Tests/$1.Tests.csproj
  rm -f apis/$1/$1.Tests/coverage.xml
  delete_generated apis/$1/$1.Snippets
  delete_generated apis/$1/$1.GeneratedSnippets

  mkdir -p $PRODUCTION_PACKAGE_DIR
  
  # Message and service generation. This doesn't need the common resources,
  # and we don't want to pass in the common resources proto because we don't
  # want to generate it.
  $PROTOC \
    --csharp_out=$PRODUCTION_PACKAGE_DIR \
    --csharp_opt=base_namespace=$1,file_extension=.g.cs \
    --grpc_out=$PRODUCTION_PACKAGE_DIR \
    --grpc_opt=file_suffix=Grpc.g.cs \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $(find $API_SRC_DIR -name '*.proto') \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)
  
  # Client generation. This needs the common resources proto as a reference,
  # but it won't generate anything for it.
  # The Cloud Common protos are likewise included so that operation result/metadata
  # types can use the messages in them, but nothing will be generated.
  $PROTOC \
    --gapic_out=$API_TMP_DIR \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $GOOGLEAPIS/google/cloud/common/*.proto \
    $(find $API_SRC_DIR -name '*.proto') \
    $(dotnet $RELEASE_MANAGER_BINARY get-generator-options $PACKAGE_ID $GOOGLEAPIS) \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # We generate our own project files
  rm $(find tmp -name '*.csproj')
  
  # Copy the rest into the right place
  cp -r $API_TMP_DIR $API_OUT_DIR
}

generate_proto() {
  # Delete previously-generated files
  delete_generated apis/$1/$1

  API_SRC_DIR=$GOOGLEAPIS/$(get_api_field $1 protoPath)
  mkdir -p apis/$1/$1
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    --csharp_opt=base_namespace=$1,file_extension=.g.cs \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $(find $API_SRC_DIR -name '*.proto') \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)
}

generate_api() {
  PACKAGE=$1
  PACKAGE_DIR=apis/$1

  echo "Generating $PACKAGE"
  GENERATOR=$(get_api_field $PACKAGE generator)
  if [[ -f $PACKAGE_DIR/pregeneration.sh ]]
  then
    echo "Running pre-generation script for $PACKAGE"
    (cd $PACKAGE_DIR; ./pregeneration.sh)
  fi

  case "$GENERATOR" in
    micro)
      generate_microgenerator $1
      ;;
    proto)
      generate_proto $1
      ;;
    *)
      echo "Unknown generator: $GENERATOR"
      exit 1
  esac

  if [[ -f $PACKAGE_DIR/postgeneration.sh ]]
  then    
    echo "Running post-generation script for $PACKAGE"
    (cd $PACKAGE_DIR; ./postgeneration.sh)
  fi
  
  if [[ $(grep -E "^namespace" apis/$1/$1/*.cs | grep -v "namespace Microsoft.Extensions.DependencyInjection" | grep -Ev "namespace ${1}[[:space:]{]*;?\$") ]]
  then
    # We know Google.LongRunning contains a proto in Google.Cloud.
    if [[ $1 == "Google.LongRunning" ]]
    then
      echo "Ignoring broken namespaces in $1"
    else
      echo "API $1 has broken namespace declarations"
      exit 1
    fi
  fi
}



# Entry point

echo "Preparing tools"

install_protoc
install_microgenerator
install_grpc
fetch_github_repos

# Used to query the API catalog
dotnet build -nologo -clp:NoSummary -v quiet -c Release tools/Google.Cloud.Tools.ReleaseManager

OUTDIR=tmp
rm -rf $OUTDIR
mkdir $OUTDIR
CHECK_COMPATIBILITY=false
if [[ $1 == "--check_compatibility" ]]
then
  CHECK_COMPATIBILITY=true
  shift
fi

packages=$@
if [[ -z "$packages" ]]
then
  packages=$(list_generated_apis)
fi

# TODO: For OwlBot APIs, should we just copy from googleapis-gen,
# unless we're testing a generator change? (Using two different generation
# paths may end up causing issues.)
for package in $packages
do
  generate_api $package
done

echo "Regenerating projects"
./generateprojects.sh
echo "Done."
