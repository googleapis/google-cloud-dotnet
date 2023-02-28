#!/bin/bash

set -e

# Undo the changes made in pregeneration.sh
git -C $GOOGLEAPIS checkout google/cloud/accessapproval/v1/

# Fix up the generated client to use the right gRPC types
sed -i s/AccessApprovalService.AccessApprovalServiceClient/AccessApproval.AccessApprovalClient/g Google.Cloud.AccessApproval.V1/AccessApprovalServiceClient.g.cs
sed -i s/AccessApprovalService.Descriptor/AccessApproval.Descriptor/g Google.Cloud.AccessApproval.V1/AccessApprovalServiceClient.g.cs

# Fix up the metadata
sed -i 's/"AccessApprovalService": {/"AccessApproval": {/g' gapic_metadata.json

# Fix up the snippet metadata (carefully)
sed -i 's/v1.AccessApprovalService/v1.AccessApproval/g' Google.Cloud.AccessApproval.V1.GeneratedSnippets/snippet_metadata_google.cloud.accessapproval.v1.json
sed -i 's/generated_AccessApprovalService/generated_AccessApproval/g' Google.Cloud.AccessApproval.V1.GeneratedSnippets/snippet_metadata_google.cloud.accessapproval.v1.json
sed -i 's/"shortName": "AccessApprovalService"/"shortName": "AccessApproval"/g' Google.Cloud.AccessApproval.V1.GeneratedSnippets/snippet_metadata_google.cloud.accessapproval.v1.json
