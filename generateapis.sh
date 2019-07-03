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
          
  if [ -d "gapic-generator-csharp" ]
  then
    git -C gapic-generator-csharp pull -q
    git -C gapic-generator-csharp submodule update
  else
    git clone --recursive https://github.com/googleapis/gapic-generator-csharp
  fi

  if [ -d "googleapis" ]
  then
    git -C googleapis pull -q
  else
    # Auto-detect whether we're cloning the public or private googleapis repo.
    git remote -v | grep -q google-cloud-dotnet-private && repo=googleapis-private || repo=googleapis
    git clone --recursive https://github.com/googleapis/${repo} googleapis
  fi
}

generate_microgenerator() {
  API_TMP_DIR=$OUTDIR/$1
  PRODUCTION_PACKAGE_DIR=$API_TMP_DIR/$1
  API_OUT_DIR=apis
  API_SRC_DIR=googleapis/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  
  mkdir -p $PRODUCTION_PACKAGE_DIR
  
  echo "Generating $1 (micro-generator)"
  
  $PROTOC \
    --csharp_out=$PRODUCTION_PACKAGE_DIR \
    --grpc_out=$PRODUCTION_PACKAGE_DIR \
    --gapic_out=$API_TMP_DIR \
    -I googleapis \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "but not used" || true # Ignore import warnings (and grep exit code)

  # We generate our own project files
  rm $(find tmp -name '*.csproj')
  
  # Copy the rest into the right place
  cp -r $API_TMP_DIR $API_OUT_DIR

  if [[ -f $API_OUT_DIR/$1/postgeneration.sh ]]
  then
    echo "Running post-generation script for $1"
    (cd $API_OUT_DIR/$1; ./postgeneration.sh)
  fi
}

generate_gapicgenerator() {
  API_TMP_DIR=$OUTDIR/$1
  API_OUT_DIR=apis
  API_SRC_DIR=googleapis/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  API_YAML=$API_SRC_DIR/../$($PYTHON3 tools/getapifield.py apis/apis.json $1 serviceYaml)

  if [[ ! -f $API_YAML ]]
  then
    echo "$API_YAML doesn't exist. Please check inputs."
    exit 1
  fi

  mkdir $API_TMP_DIR
  
  # There should be only one gapic yaml file...
  for i in $API_SRC_DIR/*_gapic.yaml
  do
    cp $i $API_TMP_DIR/gapic.yaml
  done
  
  # Generate the descriptor set for this API. We always explicitly
  # include IAM so that gRPC rerouting works; it doesn't have any negative
  # impact for non-IAM APIs. (Ditto Grafeas.)
  $PROTOC \
    -I googleapis \
    -I $CORE_PROTOS_ROOT \
    --include_source_info \
    --include_imports \
    -o $API_TMP_DIR/protos.desc \
    $API_SRC_DIR/*.proto \
    googleapis/google/iam/v1/*.proto \
    googleapis/grafeas/v1/*.proto \
    2>&1 | grep -v "but not used" || true # Ignore import warnings (and grep exit code)


  jvm_args=()
  jvm_args+=(-cp gapic-generator/build/libs/gapic-generator-${GAPIC_GENERATOR_VERSION}-all.jar)
  
  args=()
  args+=(--descriptor_set=$API_TMP_DIR/protos.desc)
  args+=(--service_yaml=$API_YAML)
  args+=(--gapic_yaml=$API_TMP_DIR/gapic.yaml)
  args+=(--output=$API_TMP_DIR)
  args+=(--language=csharp)

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
    -I googleapis \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "but not used" || true # Ignore import warnings (and grep exit code)
}

generate_proto() {
  API_SRC_DIR=googleapis/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    -I googleapis \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto
}

generate_protogrpc() {
  API_SRC_DIR=googleapis/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    --grpc_out=apis/$1/$1 \
    -I googleapis \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto
}

generate_api() {
  PACKAGE=$1
  PACKAGE_DIR=apis/$1
  echo "Generating $PACKAGE"
  GENERATOR=$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE generator)

  if [[ -f $API_OUT_DIR/$1/pregeneration.sh ]]
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

  if [[ -f $API_OUT_DIR/$1/postgeneration.sh ]]
  then
    echo "Running post-generation script for $PACKAGE"
    (cd $PACKAGE_DIR; ./postgeneration.sh)
  fi
}



# Entry point

install_protoc
install_grpc
fetch_github_repos
GAPIC_GENERATOR_VERSION=$(cat gapic-generator/version.txt)

# Build GAPIC generator once with gradle so we can invoke it from Java directly
# once per API. We don't care that we're using deprecated Gradle features: we
# won't be using Gradle at all by the end of 2018, with any luck...
(cd gapic-generator; ./gradlew shadowJar --warning-mode=none)

# Build the microgenerator
# This is disabled for now as we're not using it. We'll need to make it cross-platform, too.
# (cd gapic-generator-csharp; dotnet publish -c Release --self-contained --runtime=win-x64 Google.Api.Generator)
# declare -r GAPIC_PLUGIN=gapic-generator-csharp/Google.Api.Generator/bin/Release/netcoreapp2.2/win-x64/publish/Google.Api.Generator.exe

OUTDIR=tmp
rm -rf $OUTDIR
mkdir $OUTDIR

packages=$@
if [[ -z "$packages" ]]
then
  packages=$($PYTHON3 tools/listapis.py apis/apis.json --test generator)
fi

for package in $packages
do
  generate_api $package
done
