# This is intended to be imported using the "source" function from
# any scripts that use tools.

# TODO: Make all of this work under Linux too, if it's useful

declare -r REPO_ROOT=$(readlink -f $(dirname ${BASH_SOURCE}))
declare -r TOOL_PACKAGES=$REPO_ROOT/packages

declare -r DOCFX_VERSION=2.39.1
declare -r DOTCOVER_VERSION=2018.2.0
declare -r REPORTGENERATOR_VERSION=2.4.5.0
declare -r PROTOC_VERSION=3.6.0
declare -r GRPC_VERSION=1.12.0

# Variables to use to invoke the tools themselves

declare -r DOCFX=$TOOL_PACKAGES/docfx.$DOCFX_VERSION/docfx.exe
declare -r FIND=/usr/bin/find
declare -r DOTCOVER=$TOOL_PACKAGES/JetBrains.dotCover.CommandLineTools.$DOTCOVER_VERSION/tools/dotCover.exe
declare -r REPORTGENERATOR=$TOOL_PACKAGES/ReportGenerator.$REPORTGENERATOR_VERSION/tools/ReportGenerator.exe

declare -r PROTOBUF_TOOLS_ROOT=$TOOL_PACKAGES/Google.Protobuf.Tools.$PROTOC_VERSION
declare -r PROTOC=$PROTOBUF_TOOLS_ROOT/tools/windows_x64/protoc.exe
declare -r GRPC_PLUGIN=packages/Grpc.Tools.$GRPC_VERSION/tools/windows_x64/grpc_csharp_plugin.exe

# Use an appropriate version of nuget... preferring
# first an existing NUGET variable, then NuGet, then
# just falling back to the path.
if [ -z "$NUGET" ]
then
  if [ -n "$NuGet" ]
  then
    declare -r NUGET="$NuGet"
  else
    declare -r NUGET="nuget"
  fi
fi

# Installation functions, all of which should be unconditionally called
# when required. (They handle the case where the tool is already installed.)

install_dotcover() {
  $NUGET install -Verbosity quiet -OutputDirectory $TOOL_PACKAGES -Version $DOTCOVER_VERSION JetBrains.dotCover.CommandLineTools
}

install_reportgenerator() {
  $NUGET install -Verbosity quiet -OutputDirectory $TOOL_PACKAGES -Version $REPORTGENERATOR_VERSION ReportGenerator
}

install_protoc() {
  $NUGET install -Verbosity quiet -OutputDirectory $TOOL_PACKAGES -Version $PROTOC_VERSION Google.Protobuf.Tools
  
  # Temporary fix for a broken proto in the protobuf tools package
  sed -i 's/--)/-- )/g' $PROTOBUF_TOOLS_ROOT/tools/google/protobuf/timestamp.proto
}

install_grpc() {
  $NUGET install -Verbosity quiet -OutputDirectory $TOOL_PACKAGES -Version $GRPC_VERSION Grpc.Tools
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
