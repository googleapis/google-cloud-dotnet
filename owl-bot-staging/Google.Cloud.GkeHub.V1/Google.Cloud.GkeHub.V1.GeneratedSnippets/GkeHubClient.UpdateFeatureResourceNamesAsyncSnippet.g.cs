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

namespace Google.Cloud.GkeHub.V1.Snippets
{
    // [START gkehub_v1_generated_GkeHub_UpdateFeature_async_flattened_resourceNames]
    using Google.Cloud.GkeHub.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGkeHubClientSnippets
    {
        /// <summary>Snippet for UpdateFeatureAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateFeatureResourceNamesAsync()
        {
            // Create client
            GkeHubClient gkeHubClient = await GkeHubClient.CreateAsync();
            // Initialize request argument(s)
            FeatureName name = FeatureName.FromProjectLocationFeature("[PROJECT]", "[LOCATION]", "[FEATURE]");
            Feature resource = new Feature();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Feature, OperationMetadata> response = await gkeHubClient.UpdateFeatureAsync(name, resource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Feature, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Feature result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Feature, OperationMetadata> retrievedResponse = await gkeHubClient.PollOnceUpdateFeatureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Feature retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gkehub_v1_generated_GkeHub_UpdateFeature_async_flattened_resourceNames]
}
