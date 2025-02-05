# This is intended to be imported using the "source" function from
# any scripts that use tools.

# TODO: Make all of this work under Linux too, if it's useful

# Note: versions of dotnet tools (e.g. docfx) are under
# .config/dotnet-tools.json

declare -r REPO_ROOT=$(readlink -f $(dirname ${BASH_SOURCE}))
declare -r TOOL_PACKAGES=$REPO_ROOT/packages

declare -r PROTOC_VERSION=3.25.2
declare -r GRPC_VERSION=2.60.0
if [[ $GAPIC_GENERATOR_VERSION == "" ]]
then
  declare -r GAPIC_GENERATOR_VERSION=v1.4.33
else
  echo "Using GAPIC generator override: ${GAPIC_GENERATOR_VERSION}"
fi

declare -r PROTOBUF_TOOLS_ROOT=$TOOL_PACKAGES/Google.Protobuf.Tools.$PROTOC_VERSION

# Cross-platform tools
case "$OSTYPE" in
  linux*)
    declare -r PROTOC=$PROTOBUF_TOOLS_ROOT/tools/linux_x64/protoc
    declare -r GRPC_PLUGIN=packages/Grpc.Tools.$GRPC_VERSION/tools/linux_x64/grpc_csharp_plugin
    ;;
  darwin*)
    declare -r PROTOC=$PROTOBUF_TOOLS_ROOT/tools/macosx_x64/protoc
    declare -r GRPC_PLUGIN=packages/Grpc.Tools.$GRPC_VERSION/tools/macosx_x64/grpc_csharp_plugin
    ;;
  win* | msys* | cygwin*)
    declare -r PROTOC=$PROTOBUF_TOOLS_ROOT/tools/windows_x64/protoc.exe
    declare -r GRPC_PLUGIN=packages/Grpc.Tools.$GRPC_VERSION/tools/windows_x64/grpc_csharp_plugin.exe
    ;;
  *)
    echo "Unknown OSTYPE: $OSTYPE"
    exit 1
esac

# The nuget command line tool is annoying to get installed on Linux/Mac.
# We only need to be able to install tool packages, so let's just fake that by fetching with curl and unzipping.
# Arguments:
# - Package name
# - Version
install_nuget_package() {
  local output=$TOOL_PACKAGES/$1.$2
  # Assume that if the directory exists, it's already installed correctly.  
  if [[ -d $output ]]; then return 0; fi
  
  (mkdir -p $output;
   cd $output;
   curl -sSL https://www.nuget.org/api/v2/package/$1/$2 --output tmp.zip;
   unzip -q tmp.zip;
   rm tmp.zip)
}

# Installation functions, all of which should be unconditionally called
# when required. (They handle the case where the tool is already installed.)

install_protoc() {
  install_nuget_package Google.Protobuf.Tools $PROTOC_VERSION
  
  # Temporary fix for a broken proto in the protobuf tools package
  sed -i 's/--)/-- )/g' $PROTOBUF_TOOLS_ROOT/tools/google/protobuf/timestamp.proto
  chmod +x $PROTOC
}

install_microgenerator() {
  case "$OSTYPE" in
    linux*)
      declare -r RUNTIME=linux-x64
      declare -r EXTENSION=
      ;;
    darwin*)
      echo "Microgenerator not currently supported on MacOSX. Ask jonskeet@ for help."
      exit 1
      ;;
    win* | msys* | cygwin*)
      declare -r RUNTIME=win-x64
      declare -r EXTENSION=.exe
      ;;
    *)
      echo "Unknown OSTYPE: $OSTYPE"
      exit 1
  esac
  
  # If the CSHARP_GENERATOR_DIR env variable is set
  # we use that as the generator root dir.
  if [[ "$CSHARP_GENERATOR_DIR" != "" ]]
  then
    declare -r GENERATOR_ROOT=$CSHARP_GENERATOR_DIR
  else
    declare -r GENERATOR_ROOT=$REPO_ROOT/gapic-generator-csharp
  fi
  
  export GAPIC_PLUGIN=$GENERATOR_ROOT/Google.Api.Generator/bin/Release/net6.0/$RUNTIME/publish/Google.Api.Generator$EXTENSION
  
  if [[ "$CSHARP_GENERATOR_DIR" != "" ]]
  then
    echo "Skipping microgenerator fetch: an existing directory for the generator has been specified"
  elif [ -d $GENERATOR_ROOT ]
  then
    git -C $GENERATOR_ROOT fetch -q --tags
    git -C $GENERATOR_ROOT checkout -q $GAPIC_GENERATOR_VERSION
  else
    git clone https://github.com/googleapis/gapic-generator-csharp $GENERATOR_ROOT -q
    git -C $GENERATOR_ROOT checkout -q $GAPIC_GENERATOR_VERSION
  fi

  # The dotnet restore step isn't generally required when cloning from elsewhere,
  # but helps when running a local generator. (It does no harm even when not required.)
  (cd $GENERATOR_ROOT; \
   dotnet restore -v quiet; \
   dotnet publish -v quiet -nologo -clp:NoSummary -c Release --self-contained --runtime=$RUNTIME Google.Api.Generator)
}

install_grpc() {
  install_nuget_package Grpc.Tools $GRPC_VERSION
  chmod +x $GRPC_PLUGIN
}

# Logs to both stdout and a build timing log, allowing
# post-processing to see how long each part of the build takes.
# The console log is in magenta to stand out, and doesn't include the
# timing part.
log_build_action() {
  echo -e "\e[1;35m$1\e[0m"
  echo "$(date -u -Iseconds) $1" >> $REPO_ROOT/build_timing_log.txt
}
