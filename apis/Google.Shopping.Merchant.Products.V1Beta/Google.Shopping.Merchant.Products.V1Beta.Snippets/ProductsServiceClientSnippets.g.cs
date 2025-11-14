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
    using Google.Api.Gax;
    using Google.Shopping.Merchant.Products.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProductsServiceClientSnippets
    {
        /// <summary>Snippet for GetProduct</summary>
        public void GetProductRequestObject()
        {
            // Snippet: GetProduct(GetProductRequest, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = ProductsServiceClient.Create();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
            };
            // Make the request
            Product response = productsServiceClient.GetProduct(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductRequestObjectAsync()
        {
            // Snippet: GetProductAsync(GetProductRequest, CallSettings)
            // Additional: GetProductAsync(GetProductRequest, CancellationToken)
            // Create client
            ProductsServiceClient productsServiceClient = await ProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]"),
            };
            // Make the request
            Product response = await productsServiceClient.GetProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProduct()
        {
            // Snippet: GetProduct(string, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = ProductsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/products/[PRODUCT]";
            // Make the request
            Product response = productsServiceClient.GetProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductAsync()
        {
            // Snippet: GetProductAsync(string, CallSettings)
            // Additional: GetProductAsync(string, CancellationToken)
            // Create client
            ProductsServiceClient productsServiceClient = await ProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/products/[PRODUCT]";
            // Make the request
            Product response = await productsServiceClient.GetProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProductResourceNames()
        {
            // Snippet: GetProduct(ProductName, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = ProductsServiceClient.Create();
            // Initialize request argument(s)
            ProductName name = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]");
            // Make the request
            Product response = productsServiceClient.GetProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductResourceNamesAsync()
        {
            // Snippet: GetProductAsync(ProductName, CallSettings)
            // Additional: GetProductAsync(ProductName, CancellationToken)
            // Create client
            ProductsServiceClient productsServiceClient = await ProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName name = ProductName.FromAccountProduct("[ACCOUNT]", "[PRODUCT]");
            // Make the request
            Product response = await productsServiceClient.GetProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProductsRequestObject()
        {
            // Snippet: ListProducts(ListProductsRequest, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = ProductsServiceClient.Create();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productsServiceClient.ListProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProductsAsync</summary>
        public async Task ListProductsRequestObjectAsync()
        {
            // Snippet: ListProductsAsync(ListProductsRequest, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = await ProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productsServiceClient.ListProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
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

        /// <summary>Snippet for ListProducts</summary>
        public void ListProducts()
        {
            // Snippet: ListProducts(string, string, int?, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = ProductsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productsServiceClient.ListProducts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProductsAsync</summary>
        public async Task ListProductsAsync()
        {
            // Snippet: ListProductsAsync(string, string, int?, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = await ProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productsServiceClient.ListProductsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
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

        /// <summary>Snippet for ListProducts</summary>
        public void ListProductsResourceNames()
        {
            // Snippet: ListProducts(AccountName, string, int?, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = ProductsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productsServiceClient.ListProducts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProductsAsync</summary>
        public async Task ListProductsResourceNamesAsync()
        {
            // Snippet: ListProductsAsync(AccountName, string, int?, CallSettings)
            // Create client
            ProductsServiceClient productsServiceClient = await ProductsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productsServiceClient.ListProductsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsResponse page) =>
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
    }
}
