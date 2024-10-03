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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTaxonomyCategoryServiceClientSnippets
    {
        /// <summary>Snippet for GetTaxonomyCategory</summary>
        public void GetTaxonomyCategoryRequestObject()
        {
            // Snippet: GetTaxonomyCategory(GetTaxonomyCategoryRequest, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = TaxonomyCategoryServiceClient.Create();
            // Initialize request argument(s)
            GetTaxonomyCategoryRequest request = new GetTaxonomyCategoryRequest
            {
                TaxonomyCategoryName = TaxonomyCategoryName.FromNetworkCodeTaxonomyCategory("[NETWORK_CODE]", "[TAXONOMY_CATEGORY]"),
            };
            // Make the request
            TaxonomyCategory response = taxonomyCategoryServiceClient.GetTaxonomyCategory(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomyCategoryAsync</summary>
        public async Task GetTaxonomyCategoryRequestObjectAsync()
        {
            // Snippet: GetTaxonomyCategoryAsync(GetTaxonomyCategoryRequest, CallSettings)
            // Additional: GetTaxonomyCategoryAsync(GetTaxonomyCategoryRequest, CancellationToken)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = await TaxonomyCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTaxonomyCategoryRequest request = new GetTaxonomyCategoryRequest
            {
                TaxonomyCategoryName = TaxonomyCategoryName.FromNetworkCodeTaxonomyCategory("[NETWORK_CODE]", "[TAXONOMY_CATEGORY]"),
            };
            // Make the request
            TaxonomyCategory response = await taxonomyCategoryServiceClient.GetTaxonomyCategoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomyCategory</summary>
        public void GetTaxonomyCategory()
        {
            // Snippet: GetTaxonomyCategory(string, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = TaxonomyCategoryServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/taxonomyCategories/[TAXONOMY_CATEGORY]";
            // Make the request
            TaxonomyCategory response = taxonomyCategoryServiceClient.GetTaxonomyCategory(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomyCategoryAsync</summary>
        public async Task GetTaxonomyCategoryAsync()
        {
            // Snippet: GetTaxonomyCategoryAsync(string, CallSettings)
            // Additional: GetTaxonomyCategoryAsync(string, CancellationToken)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = await TaxonomyCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/taxonomyCategories/[TAXONOMY_CATEGORY]";
            // Make the request
            TaxonomyCategory response = await taxonomyCategoryServiceClient.GetTaxonomyCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomyCategory</summary>
        public void GetTaxonomyCategoryResourceNames()
        {
            // Snippet: GetTaxonomyCategory(TaxonomyCategoryName, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = TaxonomyCategoryServiceClient.Create();
            // Initialize request argument(s)
            TaxonomyCategoryName name = TaxonomyCategoryName.FromNetworkCodeTaxonomyCategory("[NETWORK_CODE]", "[TAXONOMY_CATEGORY]");
            // Make the request
            TaxonomyCategory response = taxonomyCategoryServiceClient.GetTaxonomyCategory(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaxonomyCategoryAsync</summary>
        public async Task GetTaxonomyCategoryResourceNamesAsync()
        {
            // Snippet: GetTaxonomyCategoryAsync(TaxonomyCategoryName, CallSettings)
            // Additional: GetTaxonomyCategoryAsync(TaxonomyCategoryName, CancellationToken)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = await TaxonomyCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            TaxonomyCategoryName name = TaxonomyCategoryName.FromNetworkCodeTaxonomyCategory("[NETWORK_CODE]", "[TAXONOMY_CATEGORY]");
            // Make the request
            TaxonomyCategory response = await taxonomyCategoryServiceClient.GetTaxonomyCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomyCategories</summary>
        public void ListTaxonomyCategoriesRequestObject()
        {
            // Snippet: ListTaxonomyCategories(ListTaxonomyCategoriesRequest, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = TaxonomyCategoryServiceClient.Create();
            // Initialize request argument(s)
            ListTaxonomyCategoriesRequest request = new ListTaxonomyCategoriesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> response = taxonomyCategoryServiceClient.ListTaxonomyCategories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TaxonomyCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTaxonomyCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TaxonomyCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TaxonomyCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TaxonomyCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomyCategoriesAsync</summary>
        public async Task ListTaxonomyCategoriesRequestObjectAsync()
        {
            // Snippet: ListTaxonomyCategoriesAsync(ListTaxonomyCategoriesRequest, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = await TaxonomyCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTaxonomyCategoriesRequest request = new ListTaxonomyCategoriesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> response = taxonomyCategoryServiceClient.ListTaxonomyCategoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TaxonomyCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTaxonomyCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TaxonomyCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TaxonomyCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TaxonomyCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomyCategories</summary>
        public void ListTaxonomyCategories()
        {
            // Snippet: ListTaxonomyCategories(string, string, int?, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = TaxonomyCategoryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> response = taxonomyCategoryServiceClient.ListTaxonomyCategories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TaxonomyCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTaxonomyCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TaxonomyCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TaxonomyCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TaxonomyCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomyCategoriesAsync</summary>
        public async Task ListTaxonomyCategoriesAsync()
        {
            // Snippet: ListTaxonomyCategoriesAsync(string, string, int?, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = await TaxonomyCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> response = taxonomyCategoryServiceClient.ListTaxonomyCategoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TaxonomyCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTaxonomyCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TaxonomyCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TaxonomyCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TaxonomyCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomyCategories</summary>
        public void ListTaxonomyCategoriesResourceNames()
        {
            // Snippet: ListTaxonomyCategories(NetworkName, string, int?, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = TaxonomyCategoryServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> response = taxonomyCategoryServiceClient.ListTaxonomyCategories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TaxonomyCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTaxonomyCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TaxonomyCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TaxonomyCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TaxonomyCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTaxonomyCategoriesAsync</summary>
        public async Task ListTaxonomyCategoriesResourceNamesAsync()
        {
            // Snippet: ListTaxonomyCategoriesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            TaxonomyCategoryServiceClient taxonomyCategoryServiceClient = await TaxonomyCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListTaxonomyCategoriesResponse, TaxonomyCategory> response = taxonomyCategoryServiceClient.ListTaxonomyCategoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TaxonomyCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTaxonomyCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TaxonomyCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TaxonomyCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TaxonomyCategory item in singlePage)
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
