// Copyright 2025 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1Beta1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEvaluationServiceClientSnippets
    {
        /// <summary>Snippet for EvaluateInstances</summary>
        public void EvaluateInstancesRequestObject()
        {
            // Snippet: EvaluateInstances(EvaluateInstancesRequest, CallSettings)
            // Create client
            EvaluationServiceClient evaluationServiceClient = EvaluationServiceClient.Create();
            // Initialize request argument(s)
            EvaluateInstancesRequest request = new EvaluateInstancesRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExactMatchInput = new ExactMatchInput(),
            };
            // Make the request
            EvaluateInstancesResponse response = evaluationServiceClient.EvaluateInstances(request);
            // End snippet
        }

        /// <summary>Snippet for EvaluateInstancesAsync</summary>
        public async Task EvaluateInstancesRequestObjectAsync()
        {
            // Snippet: EvaluateInstancesAsync(EvaluateInstancesRequest, CallSettings)
            // Additional: EvaluateInstancesAsync(EvaluateInstancesRequest, CancellationToken)
            // Create client
            EvaluationServiceClient evaluationServiceClient = await EvaluationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EvaluateInstancesRequest request = new EvaluateInstancesRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExactMatchInput = new ExactMatchInput(),
            };
            // Make the request
            EvaluateInstancesResponse response = await evaluationServiceClient.EvaluateInstancesAsync(request);
            // End snippet
        }
    }
}
