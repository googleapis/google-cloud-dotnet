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
    // [START aiplatform_v1_generated_FeatureRegistryService_CreateFeatureGroup_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedFeatureRegistryServiceClientSnippets
    {
        /// <summary>Snippet for CreateFeatureGroup</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateFeatureGroupResourceNames()
        {
            // Create client
            FeatureRegistryServiceClient featureRegistryServiceClient = FeatureRegistryServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FeatureGroup featureGroup = new FeatureGroup
            {
                BigQuery = new FeatureGroup.Types.BigQuery
                {
                    BigQuerySource = new BigQuerySource { InputUri = "", },
                },
            };
            string featureGroupId = "";
            // Make the request
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> response = featureRegistryServiceClient.CreateFeatureGroup(parent, featureGroup, featureGroupId);

            // Poll until the returned long-running operation is complete
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureGroup, CreateFeatureGroupOperationMetadata> retrievedResponse = featureRegistryServiceClient.PollOnceCreateFeatureGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureGroup retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_FeatureRegistryService_CreateFeatureGroup_sync_flattened_resourceNames]
}
