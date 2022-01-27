#!/bin/bash

# Rename the AccessApproval service to AccessApprovalService.
# This avoids naming collisions with AccessApprovalSettings, which
# is both a message type in the protos and the settings class we
# would otherwise generate for the service.
#
# It's not great to have to do this, but there are no nice alternatives.
sed -i 's/^service AccessApproval /service AccessApprovalService /g' $GOOGLEAPIS/google/cloud/accessapproval/v1/accessapproval.proto
sed -i 's/v1.AccessApproval/v1.AccessApprovalService/g' $GOOGLEAPIS/google/cloud/accessapproval/v1/accessapproval_grpc_service_config.json
sed -i 's/v1.AccessApproval/v1.AccessApprovalService/g' $GOOGLEAPIS/google/cloud/accessapproval/v1/accessapproval_v1.yaml
