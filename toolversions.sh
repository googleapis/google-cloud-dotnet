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

# Try to detect Python 3. It's quite different between Windows and Linux.
if which python > /dev/null && python --version 2>&1 | grep -q "Python 3"; then declare -r PYTHON3=python
elif which py > /dev/null && py -3 --version 2>&1 | grep -q "Python 3"; then declare -r PYTHON3="py -3"
elif which python3 > /dev/null && python3 --version 2>&1 | grep -q "Python 3"; then declare -r PYTHON3=python3
else
  echo "Unable to detect Python 3 installation."
  exit 1
fi

# When running in Java 9+, we want to disable some warnings... but
# the options aren't available in Java 8. Even detecting Java 9+ is ugly :(
if java -? 2>&1 | grep -q add-modules
then
  declare -r JAVA9OPTS="--add-opens=java.base/java.nio=ALL-UNNAMED --add-opens=java.base/java.lang=ALL-UNNAMED"
fi

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
    (echo "Fetching docfx v${DOCFX_VERSION}";
     mkdir -p $TOOL_PACKAGES;
     cd $TOOL_PACKAGES;
     mkdir docfx.$DOCFX_VERSION;
     cd docfx.$DOCFX_VERSION;
     curl -sSL https://github.com/dotnet/docfx/releases/download/v${DOCFX_VERSION}/docfx.zip -o tmp.zip;
     unzip -q tmp.zip;
     rm tmp.zip;
     )
  fi  
}

install_dotnet() {
  # This might be due to the incorrect version being installed,
  # or it not being present at all.
  if ! dotnet --version 2>&1 > /dev/null
  then
    case "$OSTYPE" in
      linux*)
        echo "Installing .NET Core SDK"
        sudo apt-get install dotnet-sdk-2.2
        ;;
      *)
        echo "Please install the version of the .NET Core listed in global.json"
        exit 1
    esac
  fi
}

# Logs to both stdout and a build timing log, allowing
# post-processing to see how long each part of the build takes.
log_build_action() {
  echo "$(date -u -Iseconds) $1" | tee -a $REPO_ROOT/build_timing_log.txt
}
