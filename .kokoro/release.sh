#!/bin/bash

# Environment variables:
# - KOKORO_KEYSTORE_DIR: Where Kokoro copies the keys from Keystore
# - COMMITTISH_OVERRIDE: The commit to actually build the release from, if not the one that has been checked out
# - SKIP_NUGET_PUSH: If non-empty, the push to nuget.org is skipped
# - SKIP_PAGES_UPLOAD: If non-empty, the push to gh-pages is skipped
# - SKIP_GOOGLEAPISDEV_UPLOAD: If non-empty, the push to googleapis.dev is skipped

set -e

SCRIPT=$(readlink -f "$0")
SCRIPT_DIR=$(dirname "$SCRIPT")

cd $SCRIPT_DIR
cd ..

export GOOGLE_APPLICATION_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_cloud-sharp-jenkins-compute-service-account"
export REQUESTER_PAYS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73609_gcloud-devel-service-account"
export DOCS_CREDENTIALS="$KOKORO_KEYSTORE_DIR/73713_docuploader_service_account"

# THIS DOES NOT DO A BUILD! It's just meant to copy our built API docs from github pages to googleapis.dev

rm -rf tmp
git clone https://github.com/googleapis/google-cloud-dotnet.git tmp/gh-pages -b gh-pages --depth 1 -c core.autocrlf=input

# Directory to reverse engineer docfx output from, based on github pages
mkdir tmp/docfx_output

# Directory to store fake nuget package files in (just so uploaddocs can find the names)
mkdir tmp/nuget

fake_release() {
  API=$1
  VERSION=$2
  
  mkdir tmp/docfx_output/$API
  cp -r tmp/gh-pages/docs/$API tmp/docfx_output/$API/site
  touch tmp/nuget/${API}.${VERSION}.nupkg
}

fake_release Google.Cloud.OrgPolicy.V1 2.0.0-beta02
fake_release Google.Cloud.Trace.V1 2.0.0
fake_release Google.Cloud.Trace.V2 2.0.0
fake_release Google.Cloud.Diagnostics.AspNetCore.Analyzers 2.0.0
fake_release Google.Cloud.BigQuery.V2 2.0.0-beta02
fake_release Google.Cloud.Asset.V1 2.0.0-beta02
fake_release Google.Cloud.Logging.NLog 3.0.0
fake_release Google.Cloud.Logging.Log4Net 3.0.0
fake_release Google.Cloud.Logging.V2 3.0.0
fake_release Google.Cloud.Logging.Type 3.0.0
fake_release Google.Cloud.Language.V1 2.0.0
fake_release Google.Cloud.Kms.V1 2.0.0-beta03
fake_release Google.Cloud.Firestore 2.0.0-beta02
fake_release Google.Cloud.Firestore.V1 2.0.0-beta02
fake_release Google.Cloud.Firestore.Admin.V1 2.0.0
fake_release Google.Cloud.ErrorReporting.V1Beta1 2.0.0-beta02
fake_release Google.Cloud.Dialogflow.V2 2.0.0
fake_release Google.Cloud.Spanner.Common.V1 3.0.0-beta02
fake_release Google.Cloud.Spanner.Data 3.0.0-beta02
fake_release Google.Cloud.Spanner.Admin.Database.V1 3.0.0-beta02
fake_release Google.Cloud.Spanner.Admin.Instance 3.0.0-beta02
fake_release Google.Cloud.Spanner.V1 3.0.0-beta02
fake_release Google.Cloud.Debugger.V2 2.0.0
fake_release Google.Cloud.DevTools.Common 2.0.0
fake_release Google.Cloud.Datastore.V1 3.0.0
fake_release Google.Cloud.Dataproc.V1 2.0.0
fake_release Google.Cloud.Container.V1 2.0.0
fake_release Google.Cloud.Billing.V1 2.0.0
fake_release Google.Cloud.Bigtable.V2 2.0.0-beta02
fake_release Google.Cloud.Bigtable.Admin 2.0.0-beta02
fake_release Google.Cloud.Bigtable.Common 2.0.0-beta02
fake_release Google.Cloud.BigQuery.DataTransfer.V1 2.0.0
fake_release Google.Cloud.Iam.V1 2.0.0
fake_release Google.LongRunning 2.0.0


echo "Uploading documentation to googleapis.dev"
./uploaddocs.sh tmp/nuget tmp/docfx_output $DOCS_CREDENTIALS docs-staging
