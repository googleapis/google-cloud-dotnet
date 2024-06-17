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
    // [START aiplatform_v1_generated_FeatureOnlineStoreAdminService_CreateFeatureOnlineStore_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedFeatureOnlineStoreAdminServiceClientSnippets
    {
        /// <summary>Snippet for CreateFeatureOnlineStoreAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateFeatureOnlineStoreRequestObjectAsync()
        {
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = await FeatureOnlineStoreAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFeatureOnlineStoreRequest request = new CreateFeatureOnlineStoreRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FeatureOnlineStore = new FeatureOnlineStore
                {
                    Bigtable = new FeatureOnlineStore.Types.Bigtable
                    {
                        AutoScaling = new FeatureOnlineStore.Types.Bigtable.Types.AutoScaling
                        {
                            MinNodeCount = 0,
                            MaxNodeCount = 0,
                        },
                    },
                },
                FeatureOnlineStoreId = "",
            };
            // Make the request
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> response = await featureOnlineStoreAdminServiceClient.CreateFeatureOnlineStoreAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FeatureOnlineStore result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureOnlineStore, CreateFeatureOnlineStoreOperationMetadata> retrievedResponse = await featureOnlineStoreAdminServiceClient.PollOnceCreateFeatureOnlineStoreAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureOnlineStore retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_FeatureOnlineStoreAdminService_CreateFeatureOnlineStore_async]
}
