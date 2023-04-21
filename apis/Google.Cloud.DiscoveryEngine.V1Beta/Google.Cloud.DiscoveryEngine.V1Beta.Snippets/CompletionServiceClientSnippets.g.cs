// Copyright 2023 Google LLC
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

namespace Google.Cloud.DiscoveryEngine.V1Beta.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCompletionServiceClientSnippets
    {
        /// <summary>Snippet for CompleteQuery</summary>
        public void CompleteQueryRequestObject()
        {
            // Snippet: CompleteQuery(CompleteQueryRequest, CallSettings)
            // Create client
            CompletionServiceClient completionServiceClient = CompletionServiceClient.Create();
            // Initialize request argument(s)
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                DataStoreAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Query = "",
                QueryModel = "",
                UserPseudoId = "",
            };
            // Make the request
            CompleteQueryResponse response = completionServiceClient.CompleteQuery(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteQueryAsync</summary>
        public async Task CompleteQueryRequestObjectAsync()
        {
            // Snippet: CompleteQueryAsync(CompleteQueryRequest, CallSettings)
            // Additional: CompleteQueryAsync(CompleteQueryRequest, CancellationToken)
            // Create client
            CompletionServiceClient completionServiceClient = await CompletionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                DataStoreAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Query = "",
                QueryModel = "",
                UserPseudoId = "",
            };
            // Make the request
            CompleteQueryResponse response = await completionServiceClient.CompleteQueryAsync(request);
            // End snippet
        }
    }
}
