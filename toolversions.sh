# This is intended to be imported using the "source" function from
# any scripts that use tools.

# TODO: Make all of this work under Linux too, if it's useful

declare -r REPO_ROOT=$(readlink -f $(dirname ${BASH_SOURCE}))
declare -r TOOL_PACKAGES=$REPO_ROOT/packages

declare -r DOCFX_VERSION=2.39.1
declare -r DOTCOVER_VERSION=2018.2.3
declare -r REPORTGENERATOR_VERSION=2.4.5.0
declare -r PROTOC_VERSION=3.6.0
declare -r GRPC_VERSION=1.12.0

# Tools that only run under Windows (at the moment)
declare -r DOCFX=$TOOL_PACKAGES/docfx.$DOCFX_VERSION/docfx.exe
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

install_grpc() {
  install_nuget_package Grpc.Tools $GRPC_VERSION
  chmod +x $GRPC_PLUGIN
}

install_docfx() {
  if [[ ! -f $DOCFX ]]
  then
    # Not ideal, but only part of the temporary fix later...
    if [[ "$VSINSTALLDIR" == "" ]]
    then
      echo "Unable to detect VS installation directory when installing docfx."
      echo "Rerun from git bash launched from a VS 2017 command prompt, just once!"
      exit 1
    fi

    (echo "Fetching docfx v${DOCFX_VERSION}";
     mkdir -p $TOOL_PACKAGES;
     cd $TOOL_PACKAGES;
     mkdir docfx.$DOCFX_VERSION;
     cd docfx.$DOCFX_VERSION;
     curl -sSL https://github.com/dotnet/docfx/releases/download/v${DOCFX_VERSION}/docfx.zip -o tmp.zip;
     unzip -q tmp.zip;
     rm tmp.zip;
     # Temporary fix for https://github.com/googleapis/google-cloud-dotnet/issues/1969
     cp -f "$VSINSTALLDIR"/MSBuild/15.0/Bin/Microsoft.Build*.dll .
     )
  fi  
}

# Logs to both stdout and a build timing log, allowing
# post-processing to see how long each part of the build takes.
log_build_action() {
  echo "$(date -u -Iseconds) $1" | tee -a $REPO_ROOT/build_timing_log.txt
}
