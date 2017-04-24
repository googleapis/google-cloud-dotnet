#!/bin/bash

set -e

# TODO: Use some appropriate way of determining OS. Ideally, shouldn't need dotnet installed.
#[[ $(dotnet --info | grep "OS Platform" | grep -c Windows) -ne 0 ]] && OS=windows || OS=linux
OS=linux
[[ ${OS} = "windows" ]] && EXE_SUFFIX=.exe || EXE_SUFFIX=

GRPC_VERSION=1.2.0
PROTOBUF_VERSION=3.2.0
PROTOC=packages/Grpc.Tools.$GRPC_VERSION/tools/${OS}_x64/protoc${EXE_SUFFIX}
GRPC_PLUGIN=packages/Grpc.Tools.$GRPC_VERSION/tools/${OS}_x64/grpc_csharp_plugin${EXE_SUFFIX}
CORE_PROTOS_ROOT=packages/Google.Protobuf.Tools.$PROTOBUF_VERSION/tools
OUTDIR=tmp

# Nuget isn't working nicely for me on Linux...
nuget_install() {
  outdir=packages/$1.$2
  if [ ! -d "$outdir" ]
  then
    echo Fetching $1 version $2
    mkdir -p $outdir
    wget --quiet -Otmp.zip https://www.nuget.org/api/v2/package/$1/$2    
    unzip -q -d $outdir tmp.zip
    if [ -d "packages/$1.$2/tools" ]
    then 
      chmod +x `find packages/$1.$2/tools -type f`
    fi

    rm tmp.zip
  fi
}

install_dependencies() {
  # Make sure we have all the tools we need.
  # Prerequisite: Java already installed so that gradlew will work
  nuget_install Google.Protobuf.Tools $PROTOBUF_VERSION
  nuget_install Google.Protobuf $PROTOBUF_VERSION
  nuget_install Grpc.Tools $GRPC_VERSION
  
  if [ -d "toolkit" ]
  then
    pushd toolkit > /dev/null
    git pull
    git submodule update
    popd > /dev/null
  else
    git clone --recursive  https://github.com/googleapis/toolkit
  fi
          
  if [ -d "googleapis" ]
  then
    pushd googleapis > /dev/null
    git pull
    popd > /dev/null
  else
    git clone --recursive  https://github.com/googleapis/googleapis
  fi
}

generate_api() {
  API_TMP_DIR=$OUTDIR/$1
  API_OUT_DIR=apis/$1
  API_SRC_DIR=googleapis/$2
  API_YAML=$API_SRC_DIR/../$3
  [[ "$4" != "" ]] && EXTRA_PROTOS=googleapis/$4/*.proto || EXTRA_PROTOS=
  
  echo Generating $1
  mkdir $API_TMP_DIR
  
  # Generate the C# protos/gRPC
  $PROTOC \
    --csharp_out=$API_TMP_DIR \
    --grpc_out=$API_TMP_DIR \
    -I googleapis \
    -I $CORE_PROTOS_ROOT \
    --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
    $API_SRC_DIR/*.proto \
    $EXTRA_PROTOS
  
  # There should be only one gapic yaml file...
  for i in $API_SRC_DIR/*_gapic.yaml
  do
    cp $i $API_TMP_DIR/gapic.yaml
  done
  cat >> $API_TMP_DIR/gapic.yaml << EOF
language: csharp
generator:
  factory: com.google.api.codegen.gapic.MainGapicProviderFactory
  id: csharp
EOF
  
  pushd toolkit > /dev/null
  ./gradlew -q runCodeGen -Pclargs=--descriptor_set=../$OUTDIR/protos.desc,--service_yaml=../$API_YAML,--gapic_yaml=../$API_TMP_DIR/gapic.yaml,--output=../$API_TMP_DIR
  popd > /dev/null

  for f in `find $API_TMP_DIR -type f -name '*.cs'`
  do
    ns=`grep '^namespace' $f | cut -d ' ' -f 2`
    mkdir -p $API_OUT_DIR/$ns
    mv $f $API_OUT_DIR/$ns
  done
}

# Entry point

install_dependencies

OUTDIR=tmp
rm -rf $OUTDIR
mkdir $OUTDIR
# Generate a single descriptor file for all protos we may care about.
# We can then reuse that for all APIs.
$PROTOC \
  -I googleapis \
  -I $CORE_PROTOS_ROOT \
  --include_source_info \
  -o $OUTDIR/protos.desc \
  $CORE_PROTOS_ROOT/google/protobuf/*.proto \
  `find googleapis/google -name '*.proto'`

# Generate LongRunning, after changing the license text (because we use
# Apache for LRO where other languages use BSD)
sed -i s/license-header-bsd-3-clause.txt/license-header-apache-2.0.txt/g googleapis/google/longrunning/longrunning_gapic.yaml
generate_api Google.LongRunning google/longrunning longrunning/longrunning.yaml
git -C googleapis checkout google/longrunning/longrunning_gapic.yaml

# IAM (just proto and grpc)
$PROTOC \
  --csharp_out=apis/Google.Cloud.Iam.V1/Google.Cloud.Iam.V1 \
  --grpc_out=apis/Google.Cloud.Iam.V1/Google.Cloud.Iam.V1 \
  -I googleapis \
  -I $CORE_PROTOS_ROOT \
  --plugin=protoc-gen-grpc=$GRPC_PLUGIN \
  googleapis/google/iam/v1/*.proto

# Now the per-API codegen  
generate_api Google.Cloud.Vision.V1 google/cloud/vision/v1 vision.yaml
generate_api Google.Cloud.Language.V1 google/cloud/language/v1 language_v1.yaml
generate_api Google.Cloud.Language.V1.Experimental google/cloud/language/v1beta2 language_v1beta2.yaml
generate_api Google.Cloud.Speech.V1 google/cloud/speech/v1 cloud_speech_v1.yaml
generate_api Google.Cloud.Logging.V2 google/logging/v2 logging.yaml google/logging/type
generate_api Google.Cloud.Trace.V1 google/devtools/cloudtrace/v1 trace.yaml
generate_api Google.Cloud.ErrorReporting.V1Beta1 google/devtools/clouderrorreporting/v1beta1 errorreporting.yaml
generate_api Google.Cloud.PubSub.V1 google/pubsub/v1 pubsub.yaml
generate_api Google.Cloud.Datastore.V1 google/datastore/v1 datastore.yaml
generate_api Google.Cloud.Monitoring.V3 google/monitoring/v3 monitoring.yaml

generate_api Google.Cloud.Spanner.V1 google/spanner/v1 spanner.yaml
generate_api Google.Cloud.Spanner.Admin.Database.V1 google/spanner/admin/database/v1 spanner_admin_database.yaml
generate_api Google.Cloud.Spanner.Admin.Instance.V1 google/spanner/admin/instance/v1 spanner_admin_instance.yaml