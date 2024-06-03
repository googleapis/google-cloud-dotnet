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

namespace GoogleCSharpSnippets
{
    // [START aiplatform_v1_generated_PersistentResourceService_CreatePersistentResource_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedPersistentResourceServiceClientSnippets
    {
        /// <summary>Snippet for CreatePersistentResource</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreatePersistentResourceResourceNames()
        {
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = PersistentResourceServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PersistentResource persistentResource = new PersistentResource();
            string persistentResourceId = "";
            // Make the request
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> response = persistentResourceServiceClient.CreatePersistentResource(parent, persistentResource, persistentResourceId);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> retrievedResponse = persistentResourceServiceClient.PollOnceCreatePersistentResource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_PersistentResourceService_CreatePersistentResource_sync_flattened_resourceNames]
}
