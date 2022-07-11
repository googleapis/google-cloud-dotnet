// Copyright 2022 Google LLC
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

namespace Google.Cloud.Firestore.Admin.V1.Snippets
{
    // [START firestore_v1_generated_FirestoreAdmin_ImportDocuments_sync_flattened]
    using Google.Cloud.Firestore.Admin.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedFirestoreAdminClientSnippets
    {
        /// <summary>Snippet for ImportDocuments</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ImportDocuments()
        {
            // Create client
            FirestoreAdminClient firestoreAdminClient = FirestoreAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/databases/[DATABASE]";
            // Make the request
            Operation<Empty, ImportDocumentsMetadata> response = firestoreAdminClient.ImportDocuments(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportDocumentsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportDocumentsMetadata> retrievedResponse = firestoreAdminClient.PollOnceImportDocuments(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END firestore_v1_generated_FirestoreAdmin_ImportDocuments_sync_flattened]
}
