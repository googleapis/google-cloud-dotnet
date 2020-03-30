#!/bin/bash

set -e

source toolversions.sh
declare -r CORE_PROTOS_ROOT=$PROTOBUF_TOOLS_ROOT/tools

# This script generates all APIs from the googleapis/googleapis github repository,
# using the code generator from googleapis/gapic-generator-csharp.
# It will fetch both repositories if necessary.

# Currently it will only work on Windows due to the way nuget packages installed;
# changing toolversions.sh could mitigate that, if it's ever necessary.
#
# Prerequisites
# - Bash as supplied with Windows git
# - git
# - wget
# - unzip

OUTDIR=tmp
if [[ "$SYNTHTOOL_PRECONFIG_FILE" != "" ]]
then
  declare -r GOOGLEAPIS=$(python - <<END
import json
with open('$SYNTHTOOL_PRECONFIG_FILE') as json_file:
  data = json.load(json_file)
  print(data['preclonedRepos']['https://github.com/googleapis/googleapis.git'])
END
  )
elif [[ "$SYNTHTOOL_GOOGLEAPIS" != "" ]]
then
  declare -r GOOGLEAPIS="$SYNTHTOOL_GOOGLEAPIS"
elif [[ "$SYNTHTOOL_CACHE" != "" ]]
then
  declare -r GOOGLEAPIS="$SYNTHTOOL_CACHE/googleapis"
else
  declare -r GOOGLEAPIS="$PWD/googleapis"
fi

# Allow pre/post-generation scripts to know where to find the repo
export GOOGLEAPIS

fetch_github_repos() {
  if [[ "$SYNTHTOOL_GOOGLEAPIS" == "" && "$SYNTHTOOL_PRECONFIG_FILE" == "" ]]
  then
    if [ -d "$GOOGLEAPIS" ]
    then
      git -C $GOOGLEAPIS pull -q
    else
      # Auto-detect whether we're cloning the public or private googleapis repo.
      git remote -v | grep -q google-cloud-dotnet-private && repo=googleapis-private || repo=googleapis
      git clone https://github.com/googleapis/${repo} $GOOGLEAPIS --depth 1
    fi
  fi
}

generate_microgenerator() {
  PACKAGE_ID=$1
  API_TMP_DIR=$OUTDIR/$PACKAGE_ID
  PRODUCTION_PACKAGE_DIR=$API_TMP_DIR/$PACKAGE_ID
  API_OUT_DIR=apis
  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE_ID protoPath)

  # If there's exactly one service config file, pass it in. Otherwise, omit it.
  GRPC_SERVICE_CONFIG=$(echo $API_SRC_DIR/*.json)
  SERVICE_CONFIG_OPTION=
  if [[ -f "$GRPC_SERVICE_CONFIG" ]]
  then
    SERVICE_CONFIG_OPTION=--gapic_opt=grpc-service-config=$GRPC_SERVICE_CONFIG
  fi

  # Defalt to "all resources are common" but allow a per-API config file too.
  COMMON_RESOURCES_CONFIG=CommonResourcesConfig.json
  if [[ -f "$API_OUT_DIR/$PACKAGE_ID/CommonResourcesConfig.json" ]]
  then
    COMMON_RESOURCES_CONFIG=$API_OUT_DIR/$PACKAGE_ID/CommonResourcesConfig.json
  fi
  COMMON_RESOURCES_OPTION=--gapic_opt=common-resources-config=$COMMON_RESOURCES_CONFIG
  
  # Only specify common resource protos for GCP APIs
  COMMON_RESOURCES_PROTO=
  if [[ $PACKAGE_ID == Google.Cloud.* ]]
  then
    COMMON_RESOURCES_PROTO=$GOOGLEAPIS/google/cloud/common_resources.proto
  fi
  
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
  $PROTOC \
    --gapic_out=$API_TMP_DIR \
    $SERVICE_CONFIG_OPTION \
    $COMMON_RESOURCES_OPTION \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto \
    $COMMON_RESOURCES_PROTO \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # The microgenerator currently creates Google.Cloud directories due to being given
  # the common resources proto. Clean up for now; this is being fixed in the generator.
  rm -rf $API_TMP_DIR/Google.Cloud{,.Snippets,.Tests}

  # We generate our own project files
  rm $(find tmp -name '*.csproj')
  
  # Copy the rest into the right place
  cp -r $API_TMP_DIR $API_OUT_DIR
}

generate_proto() {
  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  mkdir -p apis/$1/$1
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)
}

generate_protogrpc() {
  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    --grpc_out=apis/$1/$1 \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)
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
    exit 1
  fi

  if [[ $CHECK_COMPATIBILITY == "true" ]]
  then
    if [[ -f $OUTDIR/$PACKAGE.dll ]]
    then
      # In order to skip expensive "build and check compatibility" step,
      # first see whether git thinks anything has changed.
      # Command line arguments:
      # -c core.safecrlf=false: don't warn on line ending changes
      # diff: do a diff :)
      # -s: suppress output as we only care about the exit code
      # -b: ignore whitespace
      # --exit-code: set the exit code to 0 for no diff, 1 when a diff is detected      
      if git -c core.safecrlf=false diff -s -b --exit-code -- $PACKAGE_DIR
      then
        echo "git detects no change in $PACKAGE; skipping compatibility checking"
      else
        echo "Building new version of $PACKAGE for compatibility checking"
        dotnet build -c Release -f netstandard2.0 -v quiet -nologo -clp:NoSummary -p:SourceLinkCreate=false $PACKAGE_DIR/$PACKAGE
        echo ""
        echo "Changes in $PACKAGE:"
        dotnet run -p tools/Google.Cloud.Tools.CompareVersions -- \
          --file1=$OUTDIR/$PACKAGE.dll \
          --file2=$PACKAGE_DIR/$PACKAGE/bin/Release/netstandard2.0/$PACKAGE.dll
      fi
    else
      echo ""
      echo "$PACKAGE is a new API."
    fi
  fi

  # Record the commit in synth.metadata
  cat > $PACKAGE_DIR/synth.metadata <<END
{
  "sources": [
    {
      "git": {
        "name": "googleapis",
        "remote": "https://github.com/googleapis/googleapis.git",
        "sha": "$(git -C $GOOGLEAPIS rev-parse HEAD)"        
      }
    }
  ]
}
END
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

for package in $packages
do
  generate_api $package
done
