// Copyright 2026 Google LLC
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
    using Google.Ads.DataManager.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMarketingDataInsightsServiceClientSnippets
    {
        /// <summary>Snippet for RetrieveInsights</summary>
        public void RetrieveInsightsRequestObject()
        {
            // Snippet: RetrieveInsights(RetrieveInsightsRequest, CallSettings)
            // Create client
            MarketingDataInsightsServiceClient marketingDataInsightsServiceClient = MarketingDataInsightsServiceClient.Create();
            // Initialize request argument(s)
            RetrieveInsightsRequest request = new RetrieveInsightsRequest
            {
                Parent = "",
                Baseline = new Baseline(),
                UserListId = "",
            };
            // Make the request
            RetrieveInsightsResponse response = marketingDataInsightsServiceClient.RetrieveInsights(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveInsightsAsync</summary>
        public async Task RetrieveInsightsRequestObjectAsync()
        {
            // Snippet: RetrieveInsightsAsync(RetrieveInsightsRequest, CallSettings)
            // Additional: RetrieveInsightsAsync(RetrieveInsightsRequest, CancellationToken)
            // Create client
            MarketingDataInsightsServiceClient marketingDataInsightsServiceClient = await MarketingDataInsightsServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveInsightsRequest request = new RetrieveInsightsRequest
            {
                Parent = "",
                Baseline = new Baseline(),
                UserListId = "",
            };
            // Make the request
            RetrieveInsightsResponse response = await marketingDataInsightsServiceClient.RetrieveInsightsAsync(request);
            // End snippet
        }
    }
}
