#!/bin/bash

# This script merges all coverage files found under the 'coverage' directory
# and then creates a dotcover XML report and from that creates a browsable
# ReportGenerator html report.

# Use an appropriate version of nuget... preferring
# first an existing NUGET variable, then NuGet, then
# just falling back to the path.
if [ -z "$NUGET" ]
then
  if [ -n "$NuGet" ]
  then
    NUGET="$NuGet"
  else
    NUGET="nuget"
  fi
fi
set -e

$NUGET install -Verbosity quiet -OutputDirectory packages -Version 2017.1.20170613.162720 JetBrains.dotCover.CommandLineTools
$NUGET install -Verbosity quiet -OutputDirectory packages -Version 2.4.5.0 ReportGenerator

DOTCOVER=$PWD/packages/JetBrains.dotCover.CommandLineTools.2017.1.20170613.162720/tools/dotCover.exe
REPORTGENERATOR=$PWD/packages/ReportGenerator.2.4.5.0/tools/ReportGenerator.exe
FIND=/usr/bin/find

if [ ! -d coverage ]
then
 mkdir coverage
fi

[ -f coverage/all.dvcr ] && rm coverage/all.dvcr

echo "Merging reports..."
$DOTCOVER merge -Source=$(echo coverage/*.dvcr | sed 's/ /;/g') -Output=coverage/all.dvcr ""

echo "Generating detailed xml report..."
$DOTCOVER report -Source=coverage/all.dvcr -Output=coverage/coverage.xml -ReportType=DetailedXML ""

echo "Running ReportGenerator to create an html report..."

$REPORTGENERATOR \
   -reports:coverage/coverage.xml \
   -targetdir:coverage/report \
   -verbosity:Error

# TODO(benwu): upload coverage/report to public blob storage
