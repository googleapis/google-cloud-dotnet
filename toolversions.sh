# This is intended to be imported using the "source" function from
# any scripts that use tools.

declare -r REPO_ROOT=$(realpath $(dirname ${BASH_SOURCE}))

declare -r DOCFX_VERSION=2.21.1
declare -r DOTCOVER_VERSION=2017.1.20170613.162720 
declare -r REPORTGENERATOR_VERSION=2.4.5.0

# Variables to use to invoke the tools themselves

declare -r DOCFX=$REPO_ROOT/packages/docfx.$DOCFX_VERSION/docfx.exe
declare -r FIND=/usr/bin/find
declare -r DOTCOVER=$REPO_ROOT/packages/JetBrains.dotCover.CommandLineTools.$DOTCOVER_VERSION/tools/dotCover.exe
declare -r REPORTGENERATOR=$REPO_ROOT/packages/ReportGenerator.$REPORTGENERATOR_VERSION/tools/ReportGenerator.exe

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
  $NUGET install -Verbosity quiet -OutputDirectory $REPO_ROOT/packages -Version $DOTCOVER_VERSION JetBrains.dotCover.CommandLineTools
}

install_reportgenerator() {
  $NUGET install -Verbosity quiet -OutputDirectory $REPO_ROOT/packages -Version $REPORTGENERATOR_VERSION ReportGenerator
}

install_docfx() {
  if [[ ! -f $DOCFX ]]
  then
    (echo "Fetching docfx v${DOCFX_VERSION}";
     mkdir -p $REPO_ROOT/packages;
     cd $REPO_ROOT/packages;
     mkdir docfx.$DOCFX_VERSION;
     cd docfx.$DOCFX_VERSION;
     curl -sSL https://github.com/dotnet/docfx/releases/download/v${DOCFX_VERSION}/docfx.zip -o tmp.zip;
     unzip -q tmp.zip;
     rm tmp.zip)
  fi
}
