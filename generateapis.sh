#!/bin/bash

set -e

source toolversions.sh
declare -r CORE_PROTOS_ROOT=$PROTOBUF_TOOLS_ROOT/tools

# This script generates all APIs from the googleapis/googleapis github repository,
# using the code generator from googleapis/gapic-generator.
# It will fetch both repositories if necessary.

# Currently it will only work on Windows due to the way nuget packages installed;
# changing toolversions.sh could mitigate that, if it's ever necessary.
#
# Prerequisites
# - Bash as supplied with Windows git
# - git
# - wget
# - unzip
# - Java 9

OUTDIR=tmp
if [[ "$SYNTHTOOL_GOOGLEAPIS" != "" ]]
then
  declare -r GOOGLEAPIS="$SYNTHTOOL_GOOGLEAPIS"
else
  declare -r GOOGLEAPIS=googleapis
fi

fetch_github_repos() {
  if [ -d "gapic-generator" ]
  then
    git -C gapic-generator pull -q
    git -C gapic-generator submodule update
  else
    git clone --recursive https://github.com/googleapis/gapic-generator \
      --config core.autocrlf=false \
      --config core.eol=lf
  fi
          
  if [[ "$SYNTHTOOL_GOOGLEAPIS" == "" ]]
  then
    if [ -d "googleapis" ]
    then
      git -C googleapis pull -q
    else
      # Auto-detect whether we're cloning the public or private googleapis repo.
      git remote -v | grep -q google-cloud-dotnet-private && repo=googleapis-private || repo=googleapis
      git clone --recursive https://github.com/googleapis/${repo} googleapis
    fi
  fi
}

generate_microgenerator() {
  API_TMP_DIR=$OUTDIR/$1
  PRODUCTION_PACKAGE_DIR=$API_TMP_DIR/$1
  API_OUT_DIR=apis
  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)

  # If there's exactly one service config file, pass it in. Otherwise, omit it.
  GRPC_SERVICE_CONFIG=$(echo $API_SRC_DIR/*.json)
  SERVICE_CONFIG_OPTION=
  if [[ -f "$GRPC_SERVICE_CONFIG" ]]
  then
    SERVICE_CONFIG_OPTION=--gapic_opt=grpc-service-config=$GRPC_SERVICE_CONFIG
  fi

  # Defalt to "all resources are common" but allow a per-API config file too.
  COMMON_RESOURCES_CONFIG=CommonResourcesConfig.json
  if [[ -f "$API_OUT_DIR/$1/CommonResourcesConfig.json" ]]
  then
    COMMON_RESOURCES_CONFIG=$API_OUT_DIR/$1/CommonResourcesConfig.json
  fi
  COMMON_RESOURCES_OPTION=--gapic_opt=common-resources-config=$COMMON_RESOURCES_CONFIG
  
  mkdir -p $PRODUCTION_PACKAGE_DIR
  
  # Message and service generation. This doesn't need the common resources,
  # and we don't want to pass in the common resources proto because we don't
  # want to generate it.
  $PROTOC \
    --csharp_out=$PRODUCTION_PACKAGE_DIR \
    --grpc_out=$PRODUCTION_PACKAGE_DIR \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "but not used" || true # Ignore import warnings (and grep exit code)

  # Allow protos to be changed after proto/gRPC generation but before the
  # GAPIC microgenerator. This is pretty extreme, but is used for service renaming.
  if [[ -f $API_OUT_DIR/$1/midmicrogeneration.sh ]]
  then
    echo "Running mid-micro-generation script for $1"
    (cd $API_OUT_DIR/$1; ./midmicrogeneration.sh)
  fi

  # Client generation. This needs the common resources proto as a reference,
  # but it won't generate anything for it.
  $PROTOC \
    --gapic_out=$API_TMP_DIR \
    $SERVICE_CONFIG_OPTION \
    $COMMON_RESOURCES_OPTION \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto \
    $GOOGLEAPIS/google/cloud/common_resources.proto \
    2>&1 | grep -v "but not used" || true # Ignore import warnings (and grep exit code)

  # The microgenerator currently creates Google.Cloud directories due to being given
  # the common resources proto. Clean up for now; this is being fixed in the generator.
  rm -rf $API_TMP_DIR/Google.Cloud{,.Snippets,.Tests}

  # We generate our own project files
  rm $(find tmp -name '*.csproj')
  
  # Copy the rest into the right place
  cp -r $API_TMP_DIR $API_OUT_DIR
}

generate_gapicgenerator() {
  API_TMP_DIR=$OUTDIR/$1
  API_OUT_DIR=apis
  PROTO_PATH=$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  API_SRC_DIR=$GOOGLEAPIS/$PROTO_PATH
  SERVICE_YAML=$($PYTHON3 tools/getapifield.py apis/apis.json $1 serviceYaml)
  # This is a hacky way of allowing a proto package to be explicitly specified,
  # or inferred from the proto path. We might want to add an option to getapifield.py for default values.
  PROTO_PACKAGE=$(python tools/getapifield.py apis/apis.json $1 protoPackage 2> /dev/null || echo $PROTO_PATH | sed 's/\//./g')

  # Look the versioned directory and its parent for the service YAML.
  # (Currently the location is in flux; we should be able to use just the
  # versioned directory eventually.)
  if [[ -f $API_SRC_DIR/$SERVICE_YAML ]]
  then
    API_YAML=$API_SRC_DIR/$SERVICE_YAML
  elif [[ -f $API_SRC_DIR/../$SERVICE_YAML ]]
  then
    API_YAML=$API_SRC_DIR/../$SERVICE_YAML
  else
    echo "$SERVICE_YAML doesn't exist. Please check inputs."
    exit 1
  fi

  mkdir $API_TMP_DIR
  
  # There should be only one gapic yaml file...
  for i in $API_SRC_DIR/*_gapic.yaml
  do
    cp $i $API_TMP_DIR/gapic.yaml
  done
  
  # Include extra protos, when they're present, even if they're not needed.
  extra_protos=()
  if [[ -d $GOOGLEAPIS/google/iam/v1 ]]; then extra_protos+=($GOOGLEAPIS/google/iam/v1/*.proto); fi
  if [[ -d $GOOGLEAPIS/grafeas/v1 ]]; then extra_protos+=($GOOGLEAPIS/grafeas/v1/*.proto); fi
  if [[ -f $GOOGLEAPIS/google/cloud/common_resources.proto ]]; then extra_protos+=($GOOGLEAPIS/google/cloud/common_resources.proto); fi
  
  # Generate the descriptor set for this API.
  $PROTOC \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    --include_source_info \
    --include_imports \
    -o $API_TMP_DIR/protos.desc \
    $API_SRC_DIR/*.proto \
    ${extra_protos[*]} \
    2>&1 | grep -v "but not used" || true # Ignore import warnings (and grep exit code)


  jvm_args=()
  jvm_args+=(-cp gapic-generator/build/libs/gapic-generator-${GAPIC_GENERATOR_VERSION}-all.jar)
  
  args=()
  args+=(--descriptor_set=$API_TMP_DIR/protos.desc)
  args+=(--service_yaml=$API_YAML)
  args+=(--gapic_yaml=$API_TMP_DIR/gapic.yaml)
  args+=(--output=$API_TMP_DIR)
  args+=(--language=csharp)
  args+=(--package=$PROTO_PACKAGE)

  # Suppress protobuf warnings in Java 9/10. By the time they
  # become a problem, we won't be using Java...
  java $JAVA9OPTS ${jvm_args[*]} com.google.api.codegen.GeneratorMain GAPIC_CODE ${args[*]} \
  2>&1 | grep -v "does not have control environment" || true # Ignore control environment warnings (and grep exit code)

  cp -r $API_TMP_DIR/$1 $API_OUT_DIR

  # Generate the C# protos/gRPC directly into the right directory
  # This assumes they all belong to the same API, and are in the same namespace...
  $PROTOC \
    --csharp_out=$API_OUT_DIR/$1/$1 \
    --grpc_out=$API_OUT_DIR/$1/$1 \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "but not used" || true # Ignore import warnings (and grep exit code)
}

generate_proto() {
  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto
}

generate_protogrpc() {
  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    --grpc_out=apis/$1/$1 \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto
}

generate_api() {
  PACKAGE=$1
  PACKAGE_DIR=apis/$1
  if [[ $CHECK_COMPATIBILITY == "true" && -d $PACKAGE_DIR ]]
  then
    echo "Building existing version of $PACKAGE for compatibility checking"
    dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false $PACKAGE_DIR/$PACKAGE
    cp $PACKAGE_DIR/$PACKAGE/bin/Release/netstandard2.0/$PACKAGE.dll $OUTDIR
  fi
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
    gapic)
      generate_gapicgenerator $1
      ;;
    proto)
      generate_proto $1
      ;;
    protogrpc)
      generate_protogrpc $1
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
    echo "API $1 has broken namespace declarations"
    # Monitoring currently has an exemption as we know it's broken.
    # We plan to remove that exemption (and the breakage) when we do a major version bump.
    # For anything else, fail the build.
    if [[ $1 != "Google.Cloud.Monitoring.V3" ]]
    then
      exit 1
    fi
  fi
  
  if [[ $CHECK_COMPATIBILITY == "true" ]]
  then
    if [[ -f $OUTDIR/$PACKAGE.dll ]]
    then
      echo "Building new version of $PACKAGE for compatibility checking"
      dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false $PACKAGE_DIR/$PACKAGE
      echo ""
      echo "Changes in $PACKAGE:"
      dotnet run --no-build -p tools/Google.Cloud.Tools.CompareVersions -- \
        --file1=$OUTDIR/$PACKAGE.dll \
        --file2=$PACKAGE_DIR/$PACKAGE/bin/Release/netstandard2.0/$PACKAGE.dll
    else
      echo ""
      echo "$PACKAGE is a new API."
    fi
  fi
}



# Entry point

install_protoc
install_microgenerator
install_grpc
fetch_github_repos
GAPIC_GENERATOR_VERSION=$(cat gapic-generator/version.txt)

# Build GAPIC generator once with gradle so we can invoke it from Java directly
# once per API. We don't care that we're using deprecated Gradle features: we
# won't be using Gradle at all by the end of 2018, with any luck...
(cd gapic-generator; ./gradlew shadowJar --warning-mode=none)

OUTDIR=tmp
rm -rf $OUTDIR
mkdir $OUTDIR
CHECK_COMPATIBILITY=false
if [[ $1 == "--check_compatibility" ]]
then
  CHECK_COMPATIBILITY=true
  # Build the tool once so it doesn't interfere with output later
  dotnet build tools/Google.Cloud.Tools.CompareVersions -v quiet -nologo -clp:NoSummary
  shift
fi

packages=$@
if [[ -z "$packages" ]]
then
  packages=$($PYTHON3 tools/listapis.py apis/apis.json --test generator)
fi

for package in $packages
do
  generate_api $package
done
