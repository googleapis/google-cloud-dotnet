// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    // [START backupdr_v1_generated_BackupDR_UpdateBackupVault_sync]
    using Google.Cloud.BackupDR.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedBackupDRClientSnippets
    {
        /// <summary>Snippet for UpdateBackupVault</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateBackupVaultRequestObject()
        {
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            UpdateBackupVaultRequest request = new UpdateBackupVaultRequest
            {
                UpdateMask = new FieldMask(),
                BackupVault = new BackupVault(),
                RequestId = "",
                ValidateOnly = false,
                Force = false,
                ForceUpdateAccessRestriction = false,
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = backupDRClient.UpdateBackupVault(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = backupDRClient.PollOnceUpdateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END backupdr_v1_generated_BackupDR_UpdateBackupVault_sync]
}
