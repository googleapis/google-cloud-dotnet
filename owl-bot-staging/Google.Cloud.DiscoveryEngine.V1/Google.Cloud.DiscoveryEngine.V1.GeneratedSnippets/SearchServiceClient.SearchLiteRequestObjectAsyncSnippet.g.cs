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
    // [START discoveryengine_v1_generated_SearchService_SearchLite_async]
    using Google.Api.Gax;
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSearchServiceClientSnippets
    {
        /// <summary>Snippet for SearchLiteAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task SearchLiteRequestObjectAsync()
        {
            // Create client
            SearchServiceClient searchServiceClient = await SearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchRequest request = new SearchRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                BranchAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Query = "",
                Offset = 0,
                Filter = "",
                OrderBy = "",
                FacetSpecs =
                {
                    new SearchRequest.Types.FacetSpec(),
                },
                BoostSpec = new SearchRequest.Types.BoostSpec(),
                Params = { { "", new Value() }, },
                QueryExpansionSpec = new SearchRequest.Types.QueryExpansionSpec(),
                SpellCorrectionSpec = new SearchRequest.Types.SpellCorrectionSpec(),
                UserPseudoId = "",
                ImageQuery = new SearchRequest.Types.ImageQuery(),
                SafeSearch = false,
                UserInfo = new UserInfo(),
                UserLabels = { { "", "" }, },
                ContentSearchSpec = new SearchRequest.Types.ContentSearchSpec(),
                CanonicalFilter = "",
                SearchAsYouTypeSpec = new SearchRequest.Types.SearchAsYouTypeSpec(),
                DataStoreSpecs =
                {
                    new SearchRequest.Types.DataStoreSpec(),
                },
                LanguageCode = "",
                SessionAsSessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                SessionSpec = new SearchRequest.Types.SessionSpec(),
                OneBoxPageSize = 0,
            };
            // Make the request
            PagedAsyncEnumerable<SearchResponse, SearchResponse.Types.SearchResult> response = searchServiceClient.SearchLiteAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchResponse.Types.SearchResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchResponse.Types.SearchResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchResponse.Types.SearchResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchResponse.Types.SearchResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END discoveryengine_v1_generated_SearchService_SearchLite_async]
}
