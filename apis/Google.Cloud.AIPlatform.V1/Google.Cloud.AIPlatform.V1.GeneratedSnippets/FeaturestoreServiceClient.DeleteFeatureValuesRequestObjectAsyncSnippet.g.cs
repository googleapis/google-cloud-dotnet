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
    // [START aiplatform_v1_generated_FeaturestoreService_DeleteFeatureValues_async]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Type;
    using System.Threading.Tasks;

    public sealed partial class GeneratedFeaturestoreServiceClientSnippets
    {
        /// <summary>Snippet for DeleteFeatureValuesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task DeleteFeatureValuesRequestObjectAsync()
        {
            // Create client
            FeaturestoreServiceClient featurestoreServiceClient = await FeaturestoreServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFeatureValuesRequest request = new DeleteFeatureValuesRequest
            {
                EntityTypeAsEntityTypeName = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]"),
                SelectEntity = new DeleteFeatureValuesRequest.Types.SelectEntity
                {
                    EntityIdSelector = new EntityIdSelector
                    {
                        CsvSource = new CsvSource
                        {
                            GcsSource = new GcsSource { Uris = { "", }, },
                        },
                    },
                },
                SelectTimeRangeAndFeature = new DeleteFeatureValuesRequest.Types.SelectTimeRangeAndFeature
                {
                    TimeRange = new Interval { },
                    FeatureSelector = new FeatureSelector
                    {
                        IdMatcher = new IdMatcher { Ids = { "", }, },
                    },
                },
            };
            // Make the request
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> response = await featurestoreServiceClient.DeleteFeatureValuesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeleteFeatureValuesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeleteFeatureValuesResponse, DeleteFeatureValuesOperationMetadata> retrievedResponse = await featurestoreServiceClient.PollOnceDeleteFeatureValuesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeleteFeatureValuesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_FeaturestoreService_DeleteFeatureValues_async]
}
