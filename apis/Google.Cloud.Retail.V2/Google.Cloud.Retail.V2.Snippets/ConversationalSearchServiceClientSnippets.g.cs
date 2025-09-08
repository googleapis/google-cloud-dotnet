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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Retail.V2;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConversationalSearchServiceClientSnippets
    {
        /// <summary>Snippet for ConversationalSearch</summary>
        public async Task ConversationalSearchRequestObject()
        {
            // Snippet: ConversationalSearch(ConversationalSearchRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            ConversationalSearchRequest request = new ConversationalSearchRequest
            {
                Placement = "",
                BranchAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Query = "",
                PageCategories = { "", },
                ConversationId = "",
                SearchParams = new ConversationalSearchRequest.Types.SearchParams(),
                UserInfo = new UserInfo(),
                ConversationalFilteringSpec = new ConversationalSearchRequest.Types.ConversationalFilteringSpec(),
                VisitorId = "",
                UserLabels = { { "", "" }, },
                SafetySettings =
                {
                    new SafetySetting(),
                },
            };
            // Make the request, returning a streaming response
            using ConversationalSearchServiceClient.ConversationalSearchStream response = conversationalSearchServiceClient.ConversationalSearch(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ConversationalSearchResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ConversationalSearchResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }
    }
}
