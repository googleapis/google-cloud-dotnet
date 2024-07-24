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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRecommendationServiceClientSnippets
    {
        /// <summary>Snippet for Recommend</summary>
        public void RecommendRequestObject()
        {
            // Snippet: Recommend(RecommendRequest, CallSettings)
            // Create client
            RecommendationServiceClient recommendationServiceClient = RecommendationServiceClient.Create();
            // Initialize request argument(s)
            RecommendRequest request = new RecommendRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                UserEvent = new UserEvent(),
                PageSize = 0,
                Filter = "",
                ValidateOnly = false,
                Params = { { "", new Value() }, },
                UserLabels = { { "", "" }, },
            };
            // Make the request
            RecommendResponse response = recommendationServiceClient.Recommend(request);
            // End snippet
        }

        /// <summary>Snippet for RecommendAsync</summary>
        public async Task RecommendRequestObjectAsync()
        {
            // Snippet: RecommendAsync(RecommendRequest, CallSettings)
            // Additional: RecommendAsync(RecommendRequest, CancellationToken)
            // Create client
            RecommendationServiceClient recommendationServiceClient = await RecommendationServiceClient.CreateAsync();
            // Initialize request argument(s)
            RecommendRequest request = new RecommendRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                UserEvent = new UserEvent(),
                PageSize = 0,
                Filter = "",
                ValidateOnly = false,
                Params = { { "", new Value() }, },
                UserLabels = { { "", "" }, },
            };
            // Make the request
            RecommendResponse response = await recommendationServiceClient.RecommendAsync(request);
            // End snippet
        }
    }
}
