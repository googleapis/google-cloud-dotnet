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

# TODO: Work out whether we need synthtool handling etc.
declare -r GOOGLEAPIS_DISCOVERY="$PWD/googleapis-discovery"

# Allow pre/post-generation scripts to know where to find the repos
export GOOGLEAPIS
export GOOGLEAPIS_DISCOVERY

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
  
  if [ -d "$GOOGLEAPIS_DISCOVERY" ]
  then
    git -C $GOOGLEAPIS_DISCOVERY pull -q
  else
    git clone https://github.com/googleapis/googleapis-discovery $GOOGLEAPIS_DISCOVERY --depth 1
  fi
}

delete_generated() {
  rm -f "$1/*.g.cs"
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

  # If there's exactly one service config file, pass it in. Otherwise, omit it.
  GRPC_SERVICE_CONFIG=$(echo $API_SRC_DIR/*.json)
  SERVICE_CONFIG_OPTION=
  if [[ -f "$GRPC_SERVICE_CONFIG" ]]
  then
    SERVICE_CONFIG_OPTION=--gapic_opt=grpc-service-config=$GRPC_SERVICE_CONFIG
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
  
  # Only specify common resource protos for GCP APIs.
  # Don't include the file for the ResourceManager API, which genuinely defines these resources.
  COMMON_RESOURCES_PROTO=
  if [[ $PACKAGE_ID == Google.Cloud.* && $PACKAGE_ID != Google.Cloud.ResourceManager.V3 ]]
  then
    COMMON_RESOURCES_PROTO=$GOOGLEAPIS/google/cloud/common_resources.proto
  fi
  
  mkdir -p $PRODUCTION_PACKAGE_DIR
  mkdir -p $GRPC_GENERATION_DIR
  
  # Message and service generation. This doesn't need the common resources,
  # and we don't want to pass in the common resources proto because we don't
  # want to generate it.
  $PROTOC \
    --csharp_out=$PRODUCTION_PACKAGE_DIR \
    --csharp_opt=base_namespace=$1,file_extension=.g.cs \
    --grpc_out=$GRPC_GENERATION_DIR \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $(find $API_SRC_DIR -name '*.proto') \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # Change extension of gRPC-generated files
  if compgen -G "$GRPC_GENERATION_DIR/*.cs" > /dev/null
  then
    for grpc_output in $GRPC_GENERATION_DIR/*.cs
    do
      mv $grpc_output $(echo $grpc_output | sed -E 's/.cs$/.g.cs/g')
    done
    mv $GRPC_GENERATION_DIR/* $PRODUCTION_PACKAGE_DIR
  fi
  rm -rf $GRPC_GENERATION_DIR    
  
  # Allow protos to be changed after proto/gRPC generation but before the
  # GAPIC microgenerator. This is pretty extreme, but is used for service renaming.
  if [[ -f $API_OUT_DIR/$1/midmicrogeneration.sh ]]
  then
    echo "Running mid-micro-generation script for $1"
    (cd $API_OUT_DIR/$1; ./midmicrogeneration.sh)
  fi

  # Add in any common protos that are available. Due to the way autosynth
  # runs, this should not fail if it runs against an older version of googleapis.
  COMMON_PROTOS=
  if [[ -d $GOOGLE_APIS/google/cloud/common ]]
  then
    COMMON_PROTOS=$COMMON_PROTOS $GOOGLEAPIS/google/cloud/common/*.proto
  fi

  # Client generation. This needs the common resources proto as a reference,
  # but it won't generate anything for it.
  # The Cloud Common protos are likewise included so that operation result/metadata
  # types can use the messages in them, but nothing will be generated.
  $PROTOC \
    --gapic_out=$API_TMP_DIR \
    --gapic_opt=metadata \
    $SERVICE_CONFIG_OPTION \
    $COMMON_RESOURCES_OPTION \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $COMMON_PROTOS \
    $(find $API_SRC_DIR -name '*.proto') \
    $COMMON_RESOURCES_PROTO \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # Remove the newly generated standalone snippets until they are ready for surfacing.
  rm -rf $API_TMP_DIR/$1.StandaloneSnippets

  # We generate our own project files
  rm $(find tmp -name '*.csproj')
  
  # Copy the rest into the right place
  cp -r $API_TMP_DIR $API_OUT_DIR
}

# TODO: Use a common function for both kinds of generation
generate_microgenerator_regapic() {
  PACKAGE_ID=$1
  API_TMP_DIR=$OUTDIR/$PACKAGE_ID
  PRODUCTION_PACKAGE_DIR=$API_TMP_DIR/$PACKAGE_ID
  GRPC_GENERATION_DIR=$API_TMP_DIR/grpc-$PACKAGE_ID
  API_OUT_DIR=apis
  API_SRC_DIR=$GOOGLEAPIS_DISCOVERY/$($PYTHON3 tools/getapifield.py apis/apis.json $PACKAGE_ID protoPath)

  # Delete previously-generated files
  delete_generated apis/$1/$1
  delete_generated apis/$1/$1.Tests
  delete_generated apis/$1/$1.Snippets

  mkdir -p $PRODUCTION_PACKAGE_DIR
  mkdir -p $GRPC_GENERATION_DIR
  
  # Message and service generation.
  $PROTOC \
    --csharp_out=$PRODUCTION_PACKAGE_DIR \
    --csharp_opt=base_namespace=$1,file_extension=.g.cs \
    --grpc_out=$GRPC_GENERATION_DIR \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    -I $GOOGLEAPIS_DISCOVERY \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $(find $API_SRC_DIR -name '*.proto') \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # Change extension of gRPC-generated files
  if compgen -G "$GRPC_GENERATION_DIR/*.cs" > /dev/null
  then
    for grpc_output in $GRPC_GENERATION_DIR/*.cs
    do
      mv $grpc_output $(echo $grpc_output | sed -E 's/.cs$/.g.cs/g')
    done
    mv $GRPC_GENERATION_DIR/* $PRODUCTION_PACKAGE_DIR
  fi
  rm -rf $GRPC_GENERATION_DIR    

  # Client generation.
  $PROTOC \
    --gapic_out=$API_TMP_DIR \
    --gapic_opt=metadata \
    $SERVICE_CONFIG_OPTION \
    --plugin=protoc-gen-gapic=$GAPIC_PLUGIN \
    -I $GOOGLEAPIS_DISCOVERY \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $(find $API_SRC_DIR -name '*.proto') \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  # Remove the newly generated standalone snippets until they are ready for surfacing.
  rm -rf $API_TMP_DIR/$1.StandaloneSnippets

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
    --csharp_opt=base_namespace=$1 \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    $(find $API_SRC_DIR -name '*.proto') \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)
}

generate_protogrpc() {
  # Delete previously-generated files
  delete_generated apis/$1/$1

  # Note: not renaming the gRPC-generated files as carefully here. The only API
  # that uses this type (right now) is IAM. We'll notice any changes easily.

  API_SRC_DIR=$GOOGLEAPIS/$($PYTHON3 tools/getapifield.py apis/apis.json $1 protoPath)
  $PROTOC \
    --csharp_out=apis/$1/$1 \
    --grpc_out=apis/$1/$1 \
    --csharp_opt=file_extension=.g.cs \
    -I $GOOGLEAPIS \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto \
    2>&1 | grep -v "is unused" || true # Ignore import warnings (and grep exit code)

  if compgen -G "apis/$1/$1/*Grpc.cs" > /dev/null
  then
    for grpc_output in apis/$1/$1/*Grpc.cs
    do
      mv $grpc_output $(echo $grpc_output | sed -E 's/.cs$/.g.cs/g')
    done
  fi
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
    regapic)
      generate_microgenerator_regapic $1
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

  # Record the commit in synth.metadata, using either googleapis or googleapis-discovery
  # depending on the generator.
  REPO_TO_HASH=$([ "$GENERATOR" == "regapic" ] && echo "$GOOGLEAPIS_DISCOVERY" || echo "$GOOGLEAPIS")
  REMOTE_NAME=$(basename $REPO_TO_HASH)
  cat > $PACKAGE_DIR/synth.metadata <<END
{
  "sources": [
    {
      "git": {
        "name": "googleapis",
        "remote": "https://github.com/googleapis/$REMOTE_NAME.git",
        "sha": "$(git -C $REPO_TO_HASH rev-parse HEAD)"
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
