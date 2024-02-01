// Copyright 2024 Google LLC
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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START firestore_v1_generated_FirestoreAdmin_UpdateField_sync]
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using gcfav = Google.Cloud.Firestore.Admin.V1;

    public sealed partial class GeneratedFirestoreAdminClientSnippets
    {
        /// <summary>Snippet for UpdateField</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateFieldRequestObject()
        {
            // Create client
            gcfav::FirestoreAdminClient firestoreAdminClient = gcfav::FirestoreAdminClient.Create();
            // Initialize request argument(s)
            gcfav::UpdateFieldRequest request = new gcfav::UpdateFieldRequest
            {
                Field = new gcfav::Field(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcfav::Field, gcfav::FieldOperationMetadata> response = firestoreAdminClient.UpdateField(request);

            // Poll until the returned long-running operation is complete
            Operation<gcfav::Field, gcfav::FieldOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcfav::Field result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcfav::Field, gcfav::FieldOperationMetadata> retrievedResponse = firestoreAdminClient.PollOnceUpdateField(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcfav::Field retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END firestore_v1_generated_FirestoreAdmin_UpdateField_sync]
}
