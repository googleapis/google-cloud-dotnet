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
    using Google.Cloud.DiscoveryEngine.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRankServiceClientSnippets
    {
        /// <summary>Snippet for Rank</summary>
        public void RankRequestObject()
        {
            // Snippet: Rank(RankRequest, CallSettings)
            // Create client
            RankServiceClient rankServiceClient = RankServiceClient.Create();
            // Initialize request argument(s)
            RankRequest request = new RankRequest
            {
                RankingConfigAsRankingConfigName = RankingConfigName.FromProjectLocationRankingConfig("[PROJECT]", "[LOCATION]", "[RANKING_CONFIG]"),
                Model = "",
                TopN = 0,
                Query = "",
                Records =
                {
                    new RankingRecord(),
                },
                IgnoreRecordDetailsInResponse = false,
                UserLabels = { { "", "" }, },
            };
            // Make the request
            RankResponse response = rankServiceClient.Rank(request);
            // End snippet
        }

        /// <summary>Snippet for RankAsync</summary>
        public async Task RankRequestObjectAsync()
        {
            // Snippet: RankAsync(RankRequest, CallSettings)
            // Additional: RankAsync(RankRequest, CancellationToken)
            // Create client
            RankServiceClient rankServiceClient = await RankServiceClient.CreateAsync();
            // Initialize request argument(s)
            RankRequest request = new RankRequest
            {
                RankingConfigAsRankingConfigName = RankingConfigName.FromProjectLocationRankingConfig("[PROJECT]", "[LOCATION]", "[RANKING_CONFIG]"),
                Model = "",
                TopN = 0,
                Query = "",
                Records =
                {
                    new RankingRecord(),
                },
                IgnoreRecordDetailsInResponse = false,
                UserLabels = { { "", "" }, },
            };
            // Make the request
            RankResponse response = await rankServiceClient.RankAsync(request);
            // End snippet
        }
    }
}
