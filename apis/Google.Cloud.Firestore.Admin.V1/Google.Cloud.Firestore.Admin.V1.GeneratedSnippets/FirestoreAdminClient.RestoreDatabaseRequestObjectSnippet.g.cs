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
    // [START firestore_v1_generated_FirestoreAdmin_RestoreDatabase_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Firestore.Admin.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedFirestoreAdminClientSnippets
    {
        /// <summary>Snippet for RestoreDatabase</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void RestoreDatabaseRequestObject()
        {
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            RestoreDatabaseRequest request = new RestoreDatabaseRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                DatabaseId = "",
                BackupAsBackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                EncryptionConfig = new Database.Types.EncryptionConfig(),
                Tags = { { "", "" }, },
            };
            // Make the request
            Operation<Database, RestoreDatabaseMetadata> response = firestoreAdminClient.RestoreDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, RestoreDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, RestoreDatabaseMetadata> retrievedResponse = firestoreAdminClient.PollOnceRestoreDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END firestore_v1_generated_FirestoreAdmin_RestoreDatabase_sync]
}
