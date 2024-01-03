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
    using Google.Api.Gax;
    using Google.Shopping.Css.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCssProductsServiceClientSnippets
    {
        /// <summary>Snippet for GetCssProduct</summary>
        public void GetCssProductRequestObject()
        {
            // Snippet: GetCssProduct(GetCssProductRequest, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = CssProductsServiceClient.Create();
            // Initialize request argument(s)
            GetCssProductRequest request = new GetCssProductRequest
            {
                CssProductName = CssProductName.FromAccountCssProduct("[ACCOUNT]", "[CSS_PRODUCT]"),
            };
            // Make the request
            CssProduct response = cssProductsServiceClient.GetCssProduct(request);
            // End snippet
        }

        /// <summary>Snippet for GetCssProductAsync</summary>
        public async Task GetCssProductRequestObjectAsync()
        {
            // Snippet: GetCssProductAsync(GetCssProductRequest, CallSettings)
            // Additional: GetCssProductAsync(GetCssProductRequest, CancellationToken)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = await CssProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCssProductRequest request = new GetCssProductRequest
            {
                CssProductName = CssProductName.FromAccountCssProduct("[ACCOUNT]", "[CSS_PRODUCT]"),
            };
            // Make the request
            CssProduct response = await cssProductsServiceClient.GetCssProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCssProduct</summary>
        public void GetCssProduct()
        {
            // Snippet: GetCssProduct(string, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = CssProductsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/cssProducts/[CSS_PRODUCT]";
            // Make the request
            CssProduct response = cssProductsServiceClient.GetCssProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetCssProductAsync</summary>
        public async Task GetCssProductAsync()
        {
            // Snippet: GetCssProductAsync(string, CallSettings)
            // Additional: GetCssProductAsync(string, CancellationToken)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = await CssProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/cssProducts/[CSS_PRODUCT]";
            // Make the request
            CssProduct response = await cssProductsServiceClient.GetCssProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCssProduct</summary>
        public void GetCssProductResourceNames()
        {
            // Snippet: GetCssProduct(CssProductName, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = CssProductsServiceClient.Create();
            // Initialize request argument(s)
            CssProductName name = CssProductName.FromAccountCssProduct("[ACCOUNT]", "[CSS_PRODUCT]");
            // Make the request
            CssProduct response = cssProductsServiceClient.GetCssProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetCssProductAsync</summary>
        public async Task GetCssProductResourceNamesAsync()
        {
            // Snippet: GetCssProductAsync(CssProductName, CallSettings)
            // Additional: GetCssProductAsync(CssProductName, CancellationToken)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = await CssProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CssProductName name = CssProductName.FromAccountCssProduct("[ACCOUNT]", "[CSS_PRODUCT]");
            // Make the request
            CssProduct response = await cssProductsServiceClient.GetCssProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCssProducts</summary>
        public void ListCssProductsRequestObject()
        {
            // Snippet: ListCssProducts(ListCssProductsRequest, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = CssProductsServiceClient.Create();
            // Initialize request argument(s)
            ListCssProductsRequest request = new ListCssProductsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListCssProductsResponse, CssProduct> response = cssProductsServiceClient.ListCssProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CssProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCssProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CssProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CssProduct> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CssProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCssProductsAsync</summary>
        public async Task ListCssProductsRequestObjectAsync()
        {
            // Snippet: ListCssProductsAsync(ListCssProductsRequest, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = await CssProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCssProductsRequest request = new ListCssProductsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCssProductsResponse, CssProduct> response = cssProductsServiceClient.ListCssProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CssProduct item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCssProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CssProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CssProduct> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CssProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCssProducts</summary>
        public void ListCssProducts()
        {
            // Snippet: ListCssProducts(string, string, int?, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = CssProductsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListCssProductsResponse, CssProduct> response = cssProductsServiceClient.ListCssProducts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CssProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCssProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CssProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CssProduct> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CssProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCssProductsAsync</summary>
        public async Task ListCssProductsAsync()
        {
            // Snippet: ListCssProductsAsync(string, string, int?, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = await CssProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListCssProductsResponse, CssProduct> response = cssProductsServiceClient.ListCssProductsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CssProduct item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCssProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CssProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CssProduct> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CssProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCssProducts</summary>
        public void ListCssProductsResourceNames()
        {
            // Snippet: ListCssProducts(AccountName, string, int?, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = CssProductsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListCssProductsResponse, CssProduct> response = cssProductsServiceClient.ListCssProducts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CssProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCssProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CssProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CssProduct> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CssProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCssProductsAsync</summary>
        public async Task ListCssProductsResourceNamesAsync()
        {
            // Snippet: ListCssProductsAsync(AccountName, string, int?, CallSettings)
            // Create client
            CssProductsServiceClient cssProductsServiceClient = await CssProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListCssProductsResponse, CssProduct> response = cssProductsServiceClient.ListCssProductsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CssProduct item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCssProductsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CssProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CssProduct> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CssProduct item in singlePage)
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
