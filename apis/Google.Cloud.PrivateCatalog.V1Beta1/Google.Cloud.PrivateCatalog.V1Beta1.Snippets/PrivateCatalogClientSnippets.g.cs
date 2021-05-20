// Copyright 2021 Google LLC
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

namespace Google.Cloud.PrivateCatalog.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcpv = Google.Cloud.PrivateCatalog.V1Beta1;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedPrivateCatalogClientSnippets
    {
        /// <summary>Snippet for SearchCatalogs</summary>
        public void SearchCatalogsRequestObject()
        {
            // Snippet: SearchCatalogs(SearchCatalogsRequest, CallSettings)
            // Create client
            PrivateCatalogClient privateCatalogClient = PrivateCatalogClient.Create();
            // Initialize request argument(s)
            SearchCatalogsRequest request = new SearchCatalogsRequest
            {
                Resource = "",
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchCatalogsResponse, Catalog> response = privateCatalogClient.SearchCatalogs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Catalog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchCatalogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCatalogsAsync</summary>
        public async Task SearchCatalogsRequestObjectAsync()
        {
            // Snippet: SearchCatalogsAsync(SearchCatalogsRequest, CallSettings)
            // Create client
            PrivateCatalogClient privateCatalogClient = await PrivateCatalogClient.CreateAsync();
            // Initialize request argument(s)
            SearchCatalogsRequest request = new SearchCatalogsRequest
            {
                Resource = "",
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchCatalogsResponse, Catalog> response = privateCatalogClient.SearchCatalogsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Catalog item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchCatalogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Catalog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Catalog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Catalog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchProducts</summary>
        public void SearchProductsRequestObject()
        {
            // Snippet: SearchProducts(SearchProductsRequest, CallSettings)
            // Create client
            PrivateCatalogClient privateCatalogClient = PrivateCatalogClient.Create();
            // Initialize request argument(s)
            SearchProductsRequest request = new SearchProductsRequest
            {
                Resource = "",
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchProductsResponse, Product> response = privateCatalogClient.SearchProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchProductsAsync</summary>
        public async Task SearchProductsRequestObjectAsync()
        {
            // Snippet: SearchProductsAsync(SearchProductsRequest, CallSettings)
            // Create client
            PrivateCatalogClient privateCatalogClient = await PrivateCatalogClient.CreateAsync();
            // Initialize request argument(s)
            SearchProductsRequest request = new SearchProductsRequest
            {
                Resource = "",
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchProductsResponse, Product> response = privateCatalogClient.SearchProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Product item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Product> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Product item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchVersions</summary>
        public void SearchVersionsRequestObject()
        {
            // Snippet: SearchVersions(SearchVersionsRequest, CallSettings)
            // Create client
            PrivateCatalogClient privateCatalogClient = PrivateCatalogClient.Create();
            // Initialize request argument(s)
            SearchVersionsRequest request = new SearchVersionsRequest
            {
                Resource = "",
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchVersionsResponse, gcpv::Version> response = privateCatalogClient.SearchVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcpv::Version item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcpv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcpv::Version> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcpv::Version item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchVersionsAsync</summary>
        public async Task SearchVersionsRequestObjectAsync()
        {
            // Snippet: SearchVersionsAsync(SearchVersionsRequest, CallSettings)
            // Create client
            PrivateCatalogClient privateCatalogClient = await PrivateCatalogClient.CreateAsync();
            // Initialize request argument(s)
            SearchVersionsRequest request = new SearchVersionsRequest
            {
                Resource = "",
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchVersionsResponse, gcpv::Version> response = privateCatalogClient.SearchVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcpv::Version item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcpv::Version item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcpv::Version> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcpv::Version item in singlePage)
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
