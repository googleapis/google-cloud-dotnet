#!/bin/bash

set -e

dotnet run -p ../../tools/Google.Cloud.Tools.RenameRetryCode -- \
  ../../googleapis/google/cloud/kms/v1/cloudkms_gapic.yaml \
  retryable idempotent

dotnet run -p ../../tools/Google.Cloud.Tools.RenameRetryCode -- \
  ../../googleapis/google/cloud/kms/v1/cloudkms_gapic.yaml \
  non_retryable non_idempotent
