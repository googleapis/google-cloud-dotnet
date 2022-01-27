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
  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE_ID protoPath)

  # Delete previously-generated files
  delete_generated apis/$1/$1
  delete_generated apis/$1/$1.Tests
  delete_generated apis/$1/$1.Snippets

  # If there's exactly one gRPC service config file, pass it in. Otherwise, omit it.
  GRPC_SERVICE_CONFIG=$(echo $API_SRC_DIR/*_grpc_service_config.json)
  GRPC_SERVICE_CONFIG_OPTION=
  if [[ -f "$GRPC_SERVICE_CONFIG" ]]
  then
    GRPC_SERVICE_CONFIG_OPTION=--gapic_opt=grpc-service-config=$GRPC_SERVICE_CONFIG
  fi

  # Default to "all resources are common" but allow a per-API config file too.
  COMMON_RESOURCES_CONFIG=common-resources-config=CommonResourcesConfig.json

  # Note: defaulting to "x" is pretty horrible, but it's hard to tell the difference
  # between empty and unspecified otherwise.
  API_COMMON_RESOURCES_CONFIG=$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE_ID commonResourcesConfig --default=x)
  if [[ $API_COMMON_RESOURCES_CONFIG != "" && $API_COMMON_RESOURCES_CONFIG != "x" ]]
  then
    COMMON_RESOURCES_CONFIG=$COMMON_RESOURCES_CONFIG,common-resources-config=$API_COMMON_RESOURCES_CONFIG
  fi
  COMMON_RESOURCES_OPTION=--gapic_opt=$COMMON_RESOURCES_CONFIG

  # All APIs should have a service config specified, but it might be deliberately "none" to mean
  # "there are no services for this API directory" e.g. for oslogin/common
  SERVICE_CONFIG_FILE=$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE_ID serviceConfigFile)
  SERVICE_CONFIG_OPTION=
  if [[ $SERVICE_CONFIG_FILE != "none" ]]
  then
    SERVICE_CONFIG_OPTION=--gapic_opt=service-config=$API_SRC_DIR/$SERVICE_CONFIG_FILE
  fi

  # Only specify common resource protos for GCP APIs.
  # Don't include the file for the ResourceManager API, which genuinely defines these resources.
  COMMON_RESOURCES_PROTO=
  if [[ ( $PACKAGE_ID == Google.Cloud.* || $PACKAGE_ID == Google.Identity.* ) && $PACKAGE_ID != Google.Cloud.ResourceManager.V3 ]]
  then
    COMMON_RESOURCES_PROTO=$GOOGLEAPIS/google/cloud/common_resources.proto
  fi
  
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
  
  # Allow protos to be changed after proto/gRPC generation but before the
  # GAPIC microgenerator. This is pretty extreme, but is used for service renaming.
  if [[ -f $API_OUT_DIR/$1/midmicrogeneration.sh ]]
  then
    echo "Running mid-micro-generation script for $1"
    (cd $API_OUT_DIR/$1; ./midmicrogeneration.sh)
  fi

  # Client generation. This needs the common resources proto as a reference,
  # but it won't generate anything for it.
  # The Cloud Common protos are likewise included so that operation result/metadata
  # types can use the messages in them, but nothing will be generated.
  $PROTOC \
    --gapic_out=$API_TMP_DIR \
    $GRPC_SERVICE_CONFIG_OPTION \
    $SERVICE_CONFIG_OPTION \
    $COMMON_RESOURCES_OPTION \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $GOOGLEAPIS/google/cloud/common/*.proto \
    $(find $API_SRC_DIR -name '*.proto') \
    $COMMON_RESOURCES_PROTO \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # Remove the newly generated standalone snippets until they are ready for surfacing.
  rm -rf $API_TMP_DIR/$1.StandaloneSnippets
  rm -rf $API_TMP_DIR/$1.GeneratedSnippets

  # We generate our own project files
  rm $(find tmp -name '*.csproj')
  
  # Copy the rest into the right place
  cp -r $API_TMP_DIR $API_OUT_DIR
}

generate_proto() {
  # Delete previously-generated files
  delete_generated apis/$1/$1

  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
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
  GENERATOR=$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE generator)
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
  if [[ -f $PACKAGE_DIR/postgeneration.patch ]]
  then
    echo "Applying post-generation patch for $PACKAGE"
    (cd $PACKAGE_DIR; git apply postgeneration.patch)
  fi

  if [[ -f $PACKAGE_DIR/postgeneration.sh ]]
  then    
    echo "Running post-generation script for $PACKAGE"
    (cd $PACKAGE_DIR; ./postgeneration.sh)
  fi
  
  if [[ $(grep -E "^namespace" apis/$1/$1/*.cs | grep -Ev "namespace ${1}[[:space:]{]*\$") ]]
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

install_protoc
install_microgenerator
install_grpc
fetch_github_repos

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
  packages=$($PYTHON3 tools/listapis.py apis/apis.json --test generator)
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
