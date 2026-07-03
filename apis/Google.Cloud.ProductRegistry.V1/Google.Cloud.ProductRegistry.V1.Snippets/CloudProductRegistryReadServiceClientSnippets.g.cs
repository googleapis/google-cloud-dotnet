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
    using Google.Api.Gax;
    using Google.Cloud.ProductRegistry.V1;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudProductRegistryReadServiceClientSnippets
    {
        /// <summary>Snippet for GetProductSuite</summary>
        public void GetProductSuiteRequestObject()
        {
            // Snippet: GetProductSuite(GetProductSuiteRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            GetProductSuiteRequest request = new GetProductSuiteRequest
            {
                ProductSuiteName = ProductSuiteName.FromProductSuite("[PRODUCT_SUITE]"),
            };
            // Make the request
            ProductSuite response = cloudProductRegistryReadServiceClient.GetProductSuite(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductSuiteAsync</summary>
        public async Task GetProductSuiteRequestObjectAsync()
        {
            // Snippet: GetProductSuiteAsync(GetProductSuiteRequest, CallSettings)
            // Additional: GetProductSuiteAsync(GetProductSuiteRequest, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProductSuiteRequest request = new GetProductSuiteRequest
            {
                ProductSuiteName = ProductSuiteName.FromProductSuite("[PRODUCT_SUITE]"),
            };
            // Make the request
            ProductSuite response = await cloudProductRegistryReadServiceClient.GetProductSuiteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductSuite</summary>
        public void GetProductSuite()
        {
            // Snippet: GetProductSuite(string, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            string name = "productSuites/[PRODUCT_SUITE]";
            // Make the request
            ProductSuite response = cloudProductRegistryReadServiceClient.GetProductSuite(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductSuiteAsync</summary>
        public async Task GetProductSuiteAsync()
        {
            // Snippet: GetProductSuiteAsync(string, CallSettings)
            // Additional: GetProductSuiteAsync(string, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "productSuites/[PRODUCT_SUITE]";
            // Make the request
            ProductSuite response = await cloudProductRegistryReadServiceClient.GetProductSuiteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductSuite</summary>
        public void GetProductSuiteResourceNames()
        {
            // Snippet: GetProductSuite(ProductSuiteName, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            ProductSuiteName name = ProductSuiteName.FromProductSuite("[PRODUCT_SUITE]");
            // Make the request
            ProductSuite response = cloudProductRegistryReadServiceClient.GetProductSuite(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductSuiteAsync</summary>
        public async Task GetProductSuiteResourceNamesAsync()
        {
            // Snippet: GetProductSuiteAsync(ProductSuiteName, CallSettings)
            // Additional: GetProductSuiteAsync(ProductSuiteName, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductSuiteName name = ProductSuiteName.FromProductSuite("[PRODUCT_SUITE]");
            // Make the request
            ProductSuite response = await cloudProductRegistryReadServiceClient.GetProductSuiteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProductSuites</summary>
        public void ListProductSuitesRequestObject()
        {
            // Snippet: ListProductSuites(ListProductSuitesRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            ListProductSuitesRequest request = new ListProductSuitesRequest { };
            // Make the request
            PagedEnumerable<ListProductSuitesResponse, ProductSuite> response = cloudProductRegistryReadServiceClient.ListProductSuites(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductSuite item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductSuitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSuite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSuite> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSuite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSuitesAsync</summary>
        public async Task ListProductSuitesRequestObjectAsync()
        {
            // Snippet: ListProductSuitesAsync(ListProductSuitesRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProductSuitesRequest request = new ListProductSuitesRequest { };
            // Make the request
            PagedAsyncEnumerable<ListProductSuitesResponse, ProductSuite> response = cloudProductRegistryReadServiceClient.ListProductSuitesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ProductSuite item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListProductSuitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSuite item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSuite> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSuite item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProduct</summary>
        public void GetLogicalProductRequestObject()
        {
            // Snippet: GetLogicalProduct(GetLogicalProductRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            GetLogicalProductRequest request = new GetLogicalProductRequest
            {
                LogicalProductName = LogicalProductName.FromLogicalProduct("[LOGICAL_PRODUCT]"),
            };
            // Make the request
            LogicalProduct response = cloudProductRegistryReadServiceClient.GetLogicalProduct(request);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductAsync</summary>
        public async Task GetLogicalProductRequestObjectAsync()
        {
            // Snippet: GetLogicalProductAsync(GetLogicalProductRequest, CallSettings)
            // Additional: GetLogicalProductAsync(GetLogicalProductRequest, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLogicalProductRequest request = new GetLogicalProductRequest
            {
                LogicalProductName = LogicalProductName.FromLogicalProduct("[LOGICAL_PRODUCT]"),
            };
            // Make the request
            LogicalProduct response = await cloudProductRegistryReadServiceClient.GetLogicalProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProduct</summary>
        public void GetLogicalProduct()
        {
            // Snippet: GetLogicalProduct(string, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            string name = "logicalProducts/[LOGICAL_PRODUCT]";
            // Make the request
            LogicalProduct response = cloudProductRegistryReadServiceClient.GetLogicalProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductAsync</summary>
        public async Task GetLogicalProductAsync()
        {
            // Snippet: GetLogicalProductAsync(string, CallSettings)
            // Additional: GetLogicalProductAsync(string, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "logicalProducts/[LOGICAL_PRODUCT]";
            // Make the request
            LogicalProduct response = await cloudProductRegistryReadServiceClient.GetLogicalProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProduct</summary>
        public void GetLogicalProductResourceNames()
        {
            // Snippet: GetLogicalProduct(LogicalProductName, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            LogicalProductName name = LogicalProductName.FromLogicalProduct("[LOGICAL_PRODUCT]");
            // Make the request
            LogicalProduct response = cloudProductRegistryReadServiceClient.GetLogicalProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductAsync</summary>
        public async Task GetLogicalProductResourceNamesAsync()
        {
            // Snippet: GetLogicalProductAsync(LogicalProductName, CallSettings)
            // Additional: GetLogicalProductAsync(LogicalProductName, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            LogicalProductName name = LogicalProductName.FromLogicalProduct("[LOGICAL_PRODUCT]");
            // Make the request
            LogicalProduct response = await cloudProductRegistryReadServiceClient.GetLogicalProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLogicalProducts</summary>
        public void ListLogicalProductsRequestObject()
        {
            // Snippet: ListLogicalProducts(ListLogicalProductsRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            ListLogicalProductsRequest request = new ListLogicalProductsRequest { Filter = "", };
            // Make the request
            PagedEnumerable<ListLogicalProductsResponse, LogicalProduct> response = cloudProductRegistryReadServiceClient.ListLogicalProducts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogicalProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogicalProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogicalProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogicalProduct> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogicalProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogicalProductsAsync</summary>
        public async Task ListLogicalProductsRequestObjectAsync()
        {
            // Snippet: ListLogicalProductsAsync(ListLogicalProductsRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLogicalProductsRequest request = new ListLogicalProductsRequest { Filter = "", };
            // Make the request
            PagedAsyncEnumerable<ListLogicalProductsResponse, LogicalProduct> response = cloudProductRegistryReadServiceClient.ListLogicalProductsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LogicalProduct item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLogicalProductsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogicalProduct item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogicalProduct> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogicalProduct item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductVariant</summary>
        public void GetLogicalProductVariantRequestObject()
        {
            // Snippet: GetLogicalProductVariant(GetLogicalProductVariantRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            GetLogicalProductVariantRequest request = new GetLogicalProductVariantRequest
            {
                LogicalProductVariantName = LogicalProductVariantName.FromLogicalProductVariant("[LOGICAL_PRODUCT]", "[VARIANT]"),
            };
            // Make the request
            LogicalProductVariant response = cloudProductRegistryReadServiceClient.GetLogicalProductVariant(request);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductVariantAsync</summary>
        public async Task GetLogicalProductVariantRequestObjectAsync()
        {
            // Snippet: GetLogicalProductVariantAsync(GetLogicalProductVariantRequest, CallSettings)
            // Additional: GetLogicalProductVariantAsync(GetLogicalProductVariantRequest, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLogicalProductVariantRequest request = new GetLogicalProductVariantRequest
            {
                LogicalProductVariantName = LogicalProductVariantName.FromLogicalProductVariant("[LOGICAL_PRODUCT]", "[VARIANT]"),
            };
            // Make the request
            LogicalProductVariant response = await cloudProductRegistryReadServiceClient.GetLogicalProductVariantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductVariant</summary>
        public void GetLogicalProductVariant()
        {
            // Snippet: GetLogicalProductVariant(string, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            string name = "logicalProducts/[LOGICAL_PRODUCT]/variants/[VARIANT]";
            // Make the request
            LogicalProductVariant response = cloudProductRegistryReadServiceClient.GetLogicalProductVariant(name);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductVariantAsync</summary>
        public async Task GetLogicalProductVariantAsync()
        {
            // Snippet: GetLogicalProductVariantAsync(string, CallSettings)
            // Additional: GetLogicalProductVariantAsync(string, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "logicalProducts/[LOGICAL_PRODUCT]/variants/[VARIANT]";
            // Make the request
            LogicalProductVariant response = await cloudProductRegistryReadServiceClient.GetLogicalProductVariantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductVariant</summary>
        public void GetLogicalProductVariantResourceNames()
        {
            // Snippet: GetLogicalProductVariant(LogicalProductVariantName, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            LogicalProductVariantName name = LogicalProductVariantName.FromLogicalProductVariant("[LOGICAL_PRODUCT]", "[VARIANT]");
            // Make the request
            LogicalProductVariant response = cloudProductRegistryReadServiceClient.GetLogicalProductVariant(name);
            // End snippet
        }

        /// <summary>Snippet for GetLogicalProductVariantAsync</summary>
        public async Task GetLogicalProductVariantResourceNamesAsync()
        {
            // Snippet: GetLogicalProductVariantAsync(LogicalProductVariantName, CallSettings)
            // Additional: GetLogicalProductVariantAsync(LogicalProductVariantName, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            LogicalProductVariantName name = LogicalProductVariantName.FromLogicalProductVariant("[LOGICAL_PRODUCT]", "[VARIANT]");
            // Make the request
            LogicalProductVariant response = await cloudProductRegistryReadServiceClient.GetLogicalProductVariantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLogicalProductVariants</summary>
        public void ListLogicalProductVariantsRequestObject()
        {
            // Snippet: ListLogicalProductVariants(ListLogicalProductVariantsRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            ListLogicalProductVariantsRequest request = new ListLogicalProductVariantsRequest
            {
                ParentAsLogicalProductName = LogicalProductName.FromLogicalProduct("[LOGICAL_PRODUCT]"),
            };
            // Make the request
            PagedEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> response = cloudProductRegistryReadServiceClient.ListLogicalProductVariants(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogicalProductVariant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogicalProductVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogicalProductVariant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogicalProductVariant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogicalProductVariant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogicalProductVariantsAsync</summary>
        public async Task ListLogicalProductVariantsRequestObjectAsync()
        {
            // Snippet: ListLogicalProductVariantsAsync(ListLogicalProductVariantsRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLogicalProductVariantsRequest request = new ListLogicalProductVariantsRequest
            {
                ParentAsLogicalProductName = LogicalProductName.FromLogicalProduct("[LOGICAL_PRODUCT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> response = cloudProductRegistryReadServiceClient.ListLogicalProductVariantsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LogicalProductVariant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLogicalProductVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogicalProductVariant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogicalProductVariant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogicalProductVariant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogicalProductVariants</summary>
        public void ListLogicalProductVariants()
        {
            // Snippet: ListLogicalProductVariants(string, string, int?, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            string parent = "logicalProducts/[LOGICAL_PRODUCT]";
            // Make the request
            PagedEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> response = cloudProductRegistryReadServiceClient.ListLogicalProductVariants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogicalProductVariant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogicalProductVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogicalProductVariant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogicalProductVariant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogicalProductVariant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogicalProductVariantsAsync</summary>
        public async Task ListLogicalProductVariantsAsync()
        {
            // Snippet: ListLogicalProductVariantsAsync(string, string, int?, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "logicalProducts/[LOGICAL_PRODUCT]";
            // Make the request
            PagedAsyncEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> response = cloudProductRegistryReadServiceClient.ListLogicalProductVariantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LogicalProductVariant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLogicalProductVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogicalProductVariant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogicalProductVariant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogicalProductVariant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogicalProductVariants</summary>
        public void ListLogicalProductVariantsResourceNames()
        {
            // Snippet: ListLogicalProductVariants(LogicalProductName, string, int?, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            LogicalProductName parent = LogicalProductName.FromLogicalProduct("[LOGICAL_PRODUCT]");
            // Make the request
            PagedEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> response = cloudProductRegistryReadServiceClient.ListLogicalProductVariants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogicalProductVariant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogicalProductVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogicalProductVariant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogicalProductVariant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogicalProductVariant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogicalProductVariantsAsync</summary>
        public async Task ListLogicalProductVariantsResourceNamesAsync()
        {
            // Snippet: ListLogicalProductVariantsAsync(LogicalProductName, string, int?, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            LogicalProductName parent = LogicalProductName.FromLogicalProduct("[LOGICAL_PRODUCT]");
            // Make the request
            PagedAsyncEnumerable<ListLogicalProductVariantsResponse, LogicalProductVariant> response = cloudProductRegistryReadServiceClient.ListLogicalProductVariantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LogicalProductVariant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLogicalProductVariantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogicalProductVariant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogicalProductVariant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogicalProductVariant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for LookupEntity</summary>
        public void LookupEntityRequestObject()
        {
            // Snippet: LookupEntity(LookupEntityRequest, CallSettings)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = CloudProductRegistryReadServiceClient.Create();
            // Initialize request argument(s)
            LookupEntityRequest request = new LookupEntityRequest { LookupUri = "", };
            // Make the request
            LookupEntityResponse response = cloudProductRegistryReadServiceClient.LookupEntity(request);
            // End snippet
        }

        /// <summary>Snippet for LookupEntityAsync</summary>
        public async Task LookupEntityRequestObjectAsync()
        {
            // Snippet: LookupEntityAsync(LookupEntityRequest, CallSettings)
            // Additional: LookupEntityAsync(LookupEntityRequest, CancellationToken)
            // Create client
            CloudProductRegistryReadServiceClient cloudProductRegistryReadServiceClient = await CloudProductRegistryReadServiceClient.CreateAsync();
            // Initialize request argument(s)
            LookupEntityRequest request = new LookupEntityRequest { LookupUri = "", };
            // Make the request
            LookupEntityResponse response = await cloudProductRegistryReadServiceClient.LookupEntityAsync(request);
            // End snippet
        }
    }
}
