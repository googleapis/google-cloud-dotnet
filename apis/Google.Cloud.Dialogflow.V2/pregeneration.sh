#!/bin/bash

# Fix comments to avoid unnecessary broken links and XML escaping in format strings.

dotnet run --project Google.Cloud.Dialogflow.V2.PatchProtos -- $GOOGLEAPIS/google/cloud/dialogflow/v2
