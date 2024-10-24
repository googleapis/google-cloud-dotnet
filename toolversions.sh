# This is intended to be imported using the "source" function from
# any scripts that use tools.

# TODO: Make all of this work under Linux too, if it's useful

# Note: versions of dotnet tools (e.g. docfx) are under
# .config/dotnet-tools.json

declare -r REPO_ROOT=$(readlink -f $(dirname ${BASH_SOURCE}))
declare -r TOOL_PACKAGES=$REPO_ROOT/packages

declare -r DOTCOVER_VERSION=2019.3.4
declare -r REPORTGENERATOR_VERSION=2.4.5.0
declare -r PROTOC_VERSION=3.25.2
declare -r GRPC_VERSION=2.60.0

# Tools that only run under Windows (at the moment)
declare -r DOTCOVER=$TOOL_PACKAGES/JetBrains.dotCover.CommandLineTools.$DOTCOVER_VERSION/tools/dotCover.exe
declare -r REPORTGENERATOR=$TOOL_PACKAGES/ReportGenerator.$REPORTGENERATOR_VERSION/tools/ReportGenerator.exe

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

install_dotcover() {
  install_nuget_package JetBrains.dotCover.CommandLineTools $DOTCOVER_VERSION
}

install_reportgenerator() {
  install_nuget_package ReportGenerator $REPORTGENERATOR_VERSION
}

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
    echo "Skipping microgenerator fetch: an existing directory for the generator has been specified"
    (cd $CSHARP_GENERATOR_DIR; \
     dotnet restore -v quiet; \
     dotnet publish -v quiet -nologo -clp:NoSummary -c Release --self-contained --runtime=$RUNTIME Google.Api.Generator)
    export GAPIC_PLUGIN=$CSHARP_GENERATOR_DIR/Google.Api.Generator/bin/Release/net6.0/$RUNTIME/publish/Google.Api.Generator$EXTENSION
  else
    # We don't just use "dotnet tool restore", as we need it installed in a specific
    # path in order to access the executable directly (as it's a protoc plugin).
    rm -rf gapic-generator
    dotnet tool install Google.Api.Generator --tool-path gapic-generator > /dev/null
    export GAPIC_PLUGIN=$REPO_ROOT/gapic-generator/google-gapic-generator$EXTENSION
  fi
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
