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

namespace Google.Cloud.ManagedIdentities.V1.Snippets
{
    // [START managedidentities_v1_generated_ManagedIdentitiesService_DeleteDomain_async]
    using Google.Cloud.ManagedIdentities.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedManagedIdentitiesServiceClientSnippets
    {
        /// <summary>Snippet for DeleteDomainAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeleteDomainRequestObjectAsync()
        {
            // Create client
            ManagedIdentitiesServiceClient managedIdentitiesServiceClient = await ManagedIdentitiesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDomainRequest request = new DeleteDomainRequest
            {
                DomainName = DomainName.FromProjectLocationDomain("[PROJECT]", "[LOCATION]", "[DOMAIN]"),
            };
            // Make the request
            Operation<Empty, OpMetadata> response = await managedIdentitiesServiceClient.DeleteDomainAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OpMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OpMetadata> retrievedResponse = await managedIdentitiesServiceClient.PollOnceDeleteDomainAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END managedidentities_v1_generated_ManagedIdentitiesService_DeleteDomain_async]
}
