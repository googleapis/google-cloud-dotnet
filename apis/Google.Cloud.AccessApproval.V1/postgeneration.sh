#!/bin/bash

set -e

# Undo the changes made in pregeneration.sh
git -C $GOOGLEAPIS checkout google/cloud/accessapproval/v1/

# Fix up the generated client to use the right gRPC types
sed -i s/AccessApprovalService.AccessApprovalServiceClient/AccessApproval.AccessApprovalClient/g Google.Cloud.AccessApproval.V1/AccessApprovalServiceClient.g.cs
sed -i s/AccessApprovalService.Descriptor/AccessApproval.Descriptor/g Google.Cloud.AccessApproval.V1/AccessApprovalServiceClient.g.cs

# Fix up unit test classes
sed -i s/AccessApprovalService.AccessApprovalServiceClient/AccessApproval.AccessApprovalClient/g Google.Cloud.AccessApproval.V1.Tests/AccessApprovalServiceClientTest.g.cs

# Fix up the metadata
sed -i 's/"AccessApprovalService": {/"AccessApproval": {/g' gapic_metadata.json
