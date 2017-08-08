#!/bin/bash

set -e
source toolversions.sh

install_dotcover
install_reportgenerator

if [ ! -d coverage ]
then
 mkdir coverage
fi

[ -f coverage/all.dvcr ] && rm coverage/all.dvcr

echo "Merging reports..."
$DOTCOVER merge -Source=$(echo coverage/*.dvcr | sed 's/ /;/g') -Output=coverage/all.dvcr ""

echo "Generating detailed xml report..."
$DOTCOVER report -Source=coverage/all.dvcr -Output=coverage/coverage.xml -ReportType=DetailedXML ""

# We assume the tools solution has already been restored as part of the build
echo "Filtering xml report..."
dotnet run -p tools/Google.Cloud.Tools.TrimCoverageReport/Google.Cloud.Tools.TrimCoverageReport.csproj -- coverage/coverage.xml coverage/coverage-filtered.xml

echo "Running ReportGenerator to create an html report..."

$REPORTGENERATOR \
   -reports:coverage/coverage-filtered.xml \
   -targetdir:coverage/report \
   -verbosity:Error

# TODO(benwu): upload coverage/report to public blob storage
