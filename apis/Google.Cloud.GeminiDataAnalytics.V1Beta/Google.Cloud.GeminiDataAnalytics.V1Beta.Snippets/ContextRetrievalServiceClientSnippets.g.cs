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
    using Google.Cloud.GeminiDataAnalytics.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedContextRetrievalServiceClientSnippets
    {
        /// <summary>Snippet for RetrieveBigQueryTableContext</summary>
        public void RetrieveBigQueryTableContextRequestObject()
        {
            // Snippet: RetrieveBigQueryTableContext(RetrieveBigQueryTableContextRequest, CallSettings)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = ContextRetrievalServiceClient.Create();
            // Initialize request argument(s)
            RetrieveBigQueryTableContextRequest request = new RetrieveBigQueryTableContextRequest
            {
                Query = "",
                DirectLookup = { new DirectLookup(), },
                Parent = "",
            };
            // Make the request
            RetrieveBigQueryTableContextResponse response = contextRetrievalServiceClient.RetrieveBigQueryTableContext(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableContextAsync</summary>
        public async Task RetrieveBigQueryTableContextRequestObjectAsync()
        {
            // Snippet: RetrieveBigQueryTableContextAsync(RetrieveBigQueryTableContextRequest, CallSettings)
            // Additional: RetrieveBigQueryTableContextAsync(RetrieveBigQueryTableContextRequest, CancellationToken)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = await ContextRetrievalServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveBigQueryTableContextRequest request = new RetrieveBigQueryTableContextRequest
            {
                Query = "",
                DirectLookup = { new DirectLookup(), },
                Parent = "",
            };
            // Make the request
            RetrieveBigQueryTableContextResponse response = await contextRetrievalServiceClient.RetrieveBigQueryTableContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableContexts</summary>
        public void RetrieveBigQueryTableContextsRequestObject()
        {
            // Snippet: RetrieveBigQueryTableContexts(RetrieveBigQueryTableContextsRequest, CallSettings)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = ContextRetrievalServiceClient.Create();
            // Initialize request argument(s)
            RetrieveBigQueryTableContextsRequest request = new RetrieveBigQueryTableContextsRequest
            {
                Parent = "",
                Query = "",
                DirectLookups = { new DirectLookup(), },
            };
            // Make the request
            RetrieveBigQueryTableContextsResponse response = contextRetrievalServiceClient.RetrieveBigQueryTableContexts(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableContextsAsync</summary>
        public async Task RetrieveBigQueryTableContextsRequestObjectAsync()
        {
            // Snippet: RetrieveBigQueryTableContextsAsync(RetrieveBigQueryTableContextsRequest, CallSettings)
            // Additional: RetrieveBigQueryTableContextsAsync(RetrieveBigQueryTableContextsRequest, CancellationToken)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = await ContextRetrievalServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveBigQueryTableContextsRequest request = new RetrieveBigQueryTableContextsRequest
            {
                Parent = "",
                Query = "",
                DirectLookups = { new DirectLookup(), },
            };
            // Make the request
            RetrieveBigQueryTableContextsResponse response = await contextRetrievalServiceClient.RetrieveBigQueryTableContextsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableContextsFromRecentTables</summary>
        public void RetrieveBigQueryTableContextsFromRecentTablesRequestObject()
        {
            // Snippet: RetrieveBigQueryTableContextsFromRecentTables(RetrieveBigQueryTableContextsFromRecentTablesRequest, CallSettings)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = ContextRetrievalServiceClient.Create();
            // Initialize request argument(s)
            RetrieveBigQueryTableContextsFromRecentTablesRequest request = new RetrieveBigQueryTableContextsFromRecentTablesRequest
            {
                Parent = "",
                Query = "",
            };
            // Make the request
            RetrieveBigQueryTableContextsFromRecentTablesResponse response = contextRetrievalServiceClient.RetrieveBigQueryTableContextsFromRecentTables(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableContextsFromRecentTablesAsync</summary>
        public async Task RetrieveBigQueryTableContextsFromRecentTablesRequestObjectAsync()
        {
            // Snippet: RetrieveBigQueryTableContextsFromRecentTablesAsync(RetrieveBigQueryTableContextsFromRecentTablesRequest, CallSettings)
            // Additional: RetrieveBigQueryTableContextsFromRecentTablesAsync(RetrieveBigQueryTableContextsFromRecentTablesRequest, CancellationToken)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = await ContextRetrievalServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveBigQueryTableContextsFromRecentTablesRequest request = new RetrieveBigQueryTableContextsFromRecentTablesRequest
            {
                Parent = "",
                Query = "",
            };
            // Make the request
            RetrieveBigQueryTableContextsFromRecentTablesResponse response = await contextRetrievalServiceClient.RetrieveBigQueryTableContextsFromRecentTablesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableSuggestedDescriptions</summary>
        public void RetrieveBigQueryTableSuggestedDescriptionsRequestObject()
        {
            // Snippet: RetrieveBigQueryTableSuggestedDescriptions(RetrieveBigQueryTableSuggestedDescriptionsRequest, CallSettings)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = ContextRetrievalServiceClient.Create();
            // Initialize request argument(s)
            RetrieveBigQueryTableSuggestedDescriptionsRequest request = new RetrieveBigQueryTableSuggestedDescriptionsRequest
            {
                Parent = "",
                DirectLookup = { new DirectLookup(), },
            };
            // Make the request
            RetrieveBigQueryTableSuggestedDescriptionsResponse response = contextRetrievalServiceClient.RetrieveBigQueryTableSuggestedDescriptions(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableSuggestedDescriptionsAsync</summary>
        public async Task RetrieveBigQueryTableSuggestedDescriptionsRequestObjectAsync()
        {
            // Snippet: RetrieveBigQueryTableSuggestedDescriptionsAsync(RetrieveBigQueryTableSuggestedDescriptionsRequest, CallSettings)
            // Additional: RetrieveBigQueryTableSuggestedDescriptionsAsync(RetrieveBigQueryTableSuggestedDescriptionsRequest, CancellationToken)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = await ContextRetrievalServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveBigQueryTableSuggestedDescriptionsRequest request = new RetrieveBigQueryTableSuggestedDescriptionsRequest
            {
                Parent = "",
                DirectLookup = { new DirectLookup(), },
            };
            // Make the request
            RetrieveBigQueryTableSuggestedDescriptionsResponse response = await contextRetrievalServiceClient.RetrieveBigQueryTableSuggestedDescriptionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableSuggestedExamples</summary>
        public void RetrieveBigQueryTableSuggestedExamplesRequestObject()
        {
            // Snippet: RetrieveBigQueryTableSuggestedExamples(RetrieveBigQueryTableSuggestedExamplesRequest, CallSettings)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = ContextRetrievalServiceClient.Create();
            // Initialize request argument(s)
            RetrieveBigQueryTableSuggestedExamplesRequest request = new RetrieveBigQueryTableSuggestedExamplesRequest
            {
                Parent = "",
                DirectLookup = { new DirectLookup(), },
            };
            // Make the request
            RetrieveBigQueryTableSuggestedExamplesResponse response = contextRetrievalServiceClient.RetrieveBigQueryTableSuggestedExamples(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryTableSuggestedExamplesAsync</summary>
        public async Task RetrieveBigQueryTableSuggestedExamplesRequestObjectAsync()
        {
            // Snippet: RetrieveBigQueryTableSuggestedExamplesAsync(RetrieveBigQueryTableSuggestedExamplesRequest, CallSettings)
            // Additional: RetrieveBigQueryTableSuggestedExamplesAsync(RetrieveBigQueryTableSuggestedExamplesRequest, CancellationToken)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = await ContextRetrievalServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveBigQueryTableSuggestedExamplesRequest request = new RetrieveBigQueryTableSuggestedExamplesRequest
            {
                Parent = "",
                DirectLookup = { new DirectLookup(), },
            };
            // Make the request
            RetrieveBigQueryTableSuggestedExamplesResponse response = await contextRetrievalServiceClient.RetrieveBigQueryTableSuggestedExamplesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryRecentRelevantTables</summary>
        public void RetrieveBigQueryRecentRelevantTablesRequestObject()
        {
            // Snippet: RetrieveBigQueryRecentRelevantTables(RetrieveBigQueryRecentRelevantTablesRequest, CallSettings)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = ContextRetrievalServiceClient.Create();
            // Initialize request argument(s)
            RetrieveBigQueryRecentRelevantTablesRequest request = new RetrieveBigQueryRecentRelevantTablesRequest
            {
                Parent = "",
                Query = "",
            };
            // Make the request
            RetrieveBigQueryRecentRelevantTablesResponse response = contextRetrievalServiceClient.RetrieveBigQueryRecentRelevantTables(request);
            // End snippet
        }

        /// <summary>Snippet for RetrieveBigQueryRecentRelevantTablesAsync</summary>
        public async Task RetrieveBigQueryRecentRelevantTablesRequestObjectAsync()
        {
            // Snippet: RetrieveBigQueryRecentRelevantTablesAsync(RetrieveBigQueryRecentRelevantTablesRequest, CallSettings)
            // Additional: RetrieveBigQueryRecentRelevantTablesAsync(RetrieveBigQueryRecentRelevantTablesRequest, CancellationToken)
            // Create client
            ContextRetrievalServiceClient contextRetrievalServiceClient = await ContextRetrievalServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrieveBigQueryRecentRelevantTablesRequest request = new RetrieveBigQueryRecentRelevantTablesRequest
            {
                Parent = "",
                Query = "",
            };
            // Make the request
            RetrieveBigQueryRecentRelevantTablesResponse response = await contextRetrievalServiceClient.RetrieveBigQueryRecentRelevantTablesAsync(request);
            // End snippet
        }
    }
}
