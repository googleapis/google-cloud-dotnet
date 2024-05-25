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
    public sealed class AllGeneratedGroundedGenerationServiceClientSnippets
    {
        /// <summary>Snippet for CheckGrounding</summary>
        public void CheckGroundingRequestObject()
        {
            // Snippet: CheckGrounding(CheckGroundingRequest, CallSettings)
            // Create client
            GroundedGenerationServiceClient groundedGenerationServiceClient = GroundedGenerationServiceClient.Create();
            // Initialize request argument(s)
            CheckGroundingRequest request = new CheckGroundingRequest
            {
                GroundingConfigAsGroundingConfigName = GroundingConfigName.FromProjectLocationGroundingConfig("[PROJECT]", "[LOCATION]", "[GROUNDING_CONFIG]"),
                AnswerCandidate = "",
                Facts =
                {
                    new GroundingFact(),
                },
                GroundingSpec = new CheckGroundingSpec(),
                UserLabels = { { "", "" }, },
            };
            // Make the request
            CheckGroundingResponse response = groundedGenerationServiceClient.CheckGrounding(request);
            // End snippet
        }

        /// <summary>Snippet for CheckGroundingAsync</summary>
        public async Task CheckGroundingRequestObjectAsync()
        {
            // Snippet: CheckGroundingAsync(CheckGroundingRequest, CallSettings)
            // Additional: CheckGroundingAsync(CheckGroundingRequest, CancellationToken)
            // Create client
            GroundedGenerationServiceClient groundedGenerationServiceClient = await GroundedGenerationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CheckGroundingRequest request = new CheckGroundingRequest
            {
                GroundingConfigAsGroundingConfigName = GroundingConfigName.FromProjectLocationGroundingConfig("[PROJECT]", "[LOCATION]", "[GROUNDING_CONFIG]"),
                AnswerCandidate = "",
                Facts =
                {
                    new GroundingFact(),
                },
                GroundingSpec = new CheckGroundingSpec(),
                UserLabels = { { "", "" }, },
            };
            // Make the request
            CheckGroundingResponse response = await groundedGenerationServiceClient.CheckGroundingAsync(request);
            // End snippet
        }
    }
}
