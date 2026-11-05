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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAudienceSegmentCategoryServiceClientSnippets
    {
        /// <summary>Snippet for GetAudienceSegmentCategory</summary>
        public void GetAudienceSegmentCategoryRequestObject()
        {
            // Snippet: GetAudienceSegmentCategory(GetAudienceSegmentCategoryRequest, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = AudienceSegmentCategoryServiceClient.Create();
            // Initialize request argument(s)
            GetAudienceSegmentCategoryRequest request = new GetAudienceSegmentCategoryRequest
            {
                AudienceSegmentCategoryName = AudienceSegmentCategoryName.FromNetworkCodeAudienceSegmentCategory("[NETWORK_CODE]", "[AUDIENCE_SEGMENT_CATEGORY]"),
            };
            // Make the request
            AudienceSegmentCategory response = audienceSegmentCategoryServiceClient.GetAudienceSegmentCategory(request);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegmentCategoryAsync</summary>
        public async Task GetAudienceSegmentCategoryRequestObjectAsync()
        {
            // Snippet: GetAudienceSegmentCategoryAsync(GetAudienceSegmentCategoryRequest, CallSettings)
            // Additional: GetAudienceSegmentCategoryAsync(GetAudienceSegmentCategoryRequest, CancellationToken)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = await AudienceSegmentCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAudienceSegmentCategoryRequest request = new GetAudienceSegmentCategoryRequest
            {
                AudienceSegmentCategoryName = AudienceSegmentCategoryName.FromNetworkCodeAudienceSegmentCategory("[NETWORK_CODE]", "[AUDIENCE_SEGMENT_CATEGORY]"),
            };
            // Make the request
            AudienceSegmentCategory response = await audienceSegmentCategoryServiceClient.GetAudienceSegmentCategoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegmentCategory</summary>
        public void GetAudienceSegmentCategory()
        {
            // Snippet: GetAudienceSegmentCategory(string, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = AudienceSegmentCategoryServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/audienceSegmentCategories/[AUDIENCE_SEGMENT_CATEGORY]";
            // Make the request
            AudienceSegmentCategory response = audienceSegmentCategoryServiceClient.GetAudienceSegmentCategory(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegmentCategoryAsync</summary>
        public async Task GetAudienceSegmentCategoryAsync()
        {
            // Snippet: GetAudienceSegmentCategoryAsync(string, CallSettings)
            // Additional: GetAudienceSegmentCategoryAsync(string, CancellationToken)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = await AudienceSegmentCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/audienceSegmentCategories/[AUDIENCE_SEGMENT_CATEGORY]";
            // Make the request
            AudienceSegmentCategory response = await audienceSegmentCategoryServiceClient.GetAudienceSegmentCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegmentCategory</summary>
        public void GetAudienceSegmentCategoryResourceNames()
        {
            // Snippet: GetAudienceSegmentCategory(AudienceSegmentCategoryName, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = AudienceSegmentCategoryServiceClient.Create();
            // Initialize request argument(s)
            AudienceSegmentCategoryName name = AudienceSegmentCategoryName.FromNetworkCodeAudienceSegmentCategory("[NETWORK_CODE]", "[AUDIENCE_SEGMENT_CATEGORY]");
            // Make the request
            AudienceSegmentCategory response = audienceSegmentCategoryServiceClient.GetAudienceSegmentCategory(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceSegmentCategoryAsync</summary>
        public async Task GetAudienceSegmentCategoryResourceNamesAsync()
        {
            // Snippet: GetAudienceSegmentCategoryAsync(AudienceSegmentCategoryName, CallSettings)
            // Additional: GetAudienceSegmentCategoryAsync(AudienceSegmentCategoryName, CancellationToken)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = await AudienceSegmentCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            AudienceSegmentCategoryName name = AudienceSegmentCategoryName.FromNetworkCodeAudienceSegmentCategory("[NETWORK_CODE]", "[AUDIENCE_SEGMENT_CATEGORY]");
            // Make the request
            AudienceSegmentCategory response = await audienceSegmentCategoryServiceClient.GetAudienceSegmentCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentCategories</summary>
        public void ListAudienceSegmentCategoriesRequestObject()
        {
            // Snippet: ListAudienceSegmentCategories(ListAudienceSegmentCategoriesRequest, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = AudienceSegmentCategoryServiceClient.Create();
            // Initialize request argument(s)
            ListAudienceSegmentCategoriesRequest request = new ListAudienceSegmentCategoriesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> response = audienceSegmentCategoryServiceClient.ListAudienceSegmentCategories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceSegmentCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceSegmentCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegmentCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegmentCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegmentCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentCategoriesAsync</summary>
        public async Task ListAudienceSegmentCategoriesRequestObjectAsync()
        {
            // Snippet: ListAudienceSegmentCategoriesAsync(ListAudienceSegmentCategoriesRequest, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = await AudienceSegmentCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAudienceSegmentCategoriesRequest request = new ListAudienceSegmentCategoriesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> response = audienceSegmentCategoryServiceClient.ListAudienceSegmentCategoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AudienceSegmentCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAudienceSegmentCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegmentCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegmentCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegmentCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentCategories</summary>
        public void ListAudienceSegmentCategories()
        {
            // Snippet: ListAudienceSegmentCategories(string, string, int?, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = AudienceSegmentCategoryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> response = audienceSegmentCategoryServiceClient.ListAudienceSegmentCategories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceSegmentCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceSegmentCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegmentCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegmentCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegmentCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentCategoriesAsync</summary>
        public async Task ListAudienceSegmentCategoriesAsync()
        {
            // Snippet: ListAudienceSegmentCategoriesAsync(string, string, int?, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = await AudienceSegmentCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> response = audienceSegmentCategoryServiceClient.ListAudienceSegmentCategoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AudienceSegmentCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAudienceSegmentCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegmentCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegmentCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegmentCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentCategories</summary>
        public void ListAudienceSegmentCategoriesResourceNames()
        {
            // Snippet: ListAudienceSegmentCategories(NetworkName, string, int?, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = AudienceSegmentCategoryServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> response = audienceSegmentCategoryServiceClient.ListAudienceSegmentCategories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AudienceSegmentCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudienceSegmentCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegmentCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegmentCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegmentCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudienceSegmentCategoriesAsync</summary>
        public async Task ListAudienceSegmentCategoriesResourceNamesAsync()
        {
            // Snippet: ListAudienceSegmentCategoriesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            AudienceSegmentCategoryServiceClient audienceSegmentCategoryServiceClient = await AudienceSegmentCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListAudienceSegmentCategoriesResponse, AudienceSegmentCategory> response = audienceSegmentCategoryServiceClient.ListAudienceSegmentCategoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AudienceSegmentCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAudienceSegmentCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AudienceSegmentCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AudienceSegmentCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AudienceSegmentCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
