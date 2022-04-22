#!/bin/bash

set -e
source toolversions.sh

if [ ! -d coverage ]
then
 mkdir coverage
fi

rm -f coverage/all.dvcr

if ! compgen -G "coverage/*.dvcr" > /dev/null
then
  echo "No coverage reports found to merge."
  # This isn't an error
  exit 0
fi

install_dotcover
install_reportgenerator

upload_report=false
while (( "$#" )); do
  if [[ "$1" == "--upload" ]]
  then
    upload_report=true
  elif [[ "$1" == "--upload_reportname" ]]
  then
    shift
    # No further actions right now
  elif [[ "$1" == "--upload_commit" ]]
  then
    shift
    # No further actions right now
  elif [[ "$1" == "--upload_build" ]]
  then
    shift
    # No further actions right now
  else
    echo "Unexpected param: $1"
    exit 1
  fi
  shift
done

echo "Merging reports..."
$DOTCOVER merge --Source="$(echo coverage/*.dvcr | sed 's/ /;/g')" --Output=coverage/all.dvcr ""

echo "Generating detailed xml report..."
$DOTCOVER report --Source=coverage/all.dvcr --Output=coverage/coverage.xml --ReportType=DetailedXML ""

# We assume the tools solution has already been restored as part of the build
echo "Filtering xml report..."
dotnet run --project tools/Google.Cloud.Tools.TrimCoverageReport/Google.Cloud.Tools.TrimCoverageReport.csproj -- coverage/coverage.xml coverage/coverage-filtered.xml

echo "Running ReportGenerator to create an html report..."

$REPORTGENERATOR \
   -reports:coverage/coverage-filtered.xml \
   -targetdir:coverage/report \
   -verbosity:Error

if [[ "$upload_report" = true ]]
then
  echo "Code coverage report uploading currently disabled."
fi
