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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Vision.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProductSearchClientSnippets
    {
        /// <summary>Snippet for CreateProductSet</summary>
        public void CreateProductSetRequestObject()
        {
            // Snippet: CreateProductSet(CreateProductSetRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "",
            };
            // Make the request
            ProductSet response = productSearchClient.CreateProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSetAsync</summary>
        public async Task CreateProductSetRequestObjectAsync()
        {
            // Snippet: CreateProductSetAsync(CreateProductSetRequest, CallSettings)
            // Additional: CreateProductSetAsync(CreateProductSetRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            CreateProductSetRequest request = new CreateProductSetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSet = new ProductSet(),
                ProductSetId = "",
            };
            // Make the request
            ProductSet response = await productSearchClient.CreateProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSet</summary>
        public void CreateProductSet()
        {
            // Snippet: CreateProductSet(string, ProductSet, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ProductSet productSet = new ProductSet();
            string productSetId = "";
            // Make the request
            ProductSet response = productSearchClient.CreateProductSet(parent, productSet, productSetId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSetAsync</summary>
        public async Task CreateProductSetAsync()
        {
            // Snippet: CreateProductSetAsync(string, ProductSet, string, CallSettings)
            // Additional: CreateProductSetAsync(string, ProductSet, string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ProductSet productSet = new ProductSet();
            string productSetId = "";
            // Make the request
            ProductSet response = await productSearchClient.CreateProductSetAsync(parent, productSet, productSetId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSet</summary>
        public void CreateProductSetResourceNames()
        {
            // Snippet: CreateProductSet(LocationName, ProductSet, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ProductSet productSet = new ProductSet();
            string productSetId = "";
            // Make the request
            ProductSet response = productSearchClient.CreateProductSet(parent, productSet, productSetId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductSetAsync</summary>
        public async Task CreateProductSetResourceNamesAsync()
        {
            // Snippet: CreateProductSetAsync(LocationName, ProductSet, string, CallSettings)
            // Additional: CreateProductSetAsync(LocationName, ProductSet, string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ProductSet productSet = new ProductSet();
            string productSetId = "";
            // Make the request
            ProductSet response = await productSearchClient.CreateProductSetAsync(parent, productSet, productSetId);
            // End snippet
        }

        /// <summary>Snippet for ListProductSets</summary>
        public void ListProductSetsRequestObject()
        {
            // Snippet: ListProductSets(ListProductSetsRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ListProductSetsRequest request = new ListProductSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListProductSetsResponse, ProductSet> response = productSearchClient.ListProductSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSetsAsync</summary>
        public async Task ListProductSetsRequestObjectAsync()
        {
            // Snippet: ListProductSetsAsync(ListProductSetsRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ListProductSetsRequest request = new ListProductSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> response = productSearchClient.ListProductSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProductSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSets</summary>
        public void ListProductSets()
        {
            // Snippet: ListProductSets(string, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProductSetsResponse, ProductSet> response = productSearchClient.ListProductSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSetsAsync</summary>
        public async Task ListProductSetsAsync()
        {
            // Snippet: ListProductSetsAsync(string, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> response = productSearchClient.ListProductSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProductSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSets</summary>
        public void ListProductSetsResourceNames()
        {
            // Snippet: ListProductSets(LocationName, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProductSetsResponse, ProductSet> response = productSearchClient.ListProductSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ProductSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProductSetsAsync</summary>
        public async Task ListProductSetsResourceNamesAsync()
        {
            // Snippet: ListProductSetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProductSetsResponse, ProductSet> response = productSearchClient.ListProductSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ProductSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ProductSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ProductSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ProductSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProductSet</summary>
        public void GetProductSetRequestObject()
        {
            // Snippet: GetProductSet(GetProductSetRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            // Make the request
            ProductSet response = productSearchClient.GetProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductSetAsync</summary>
        public async Task GetProductSetRequestObjectAsync()
        {
            // Snippet: GetProductSetAsync(GetProductSetRequest, CallSettings)
            // Additional: GetProductSetAsync(GetProductSetRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            GetProductSetRequest request = new GetProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            // Make the request
            ProductSet response = await productSearchClient.GetProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductSet</summary>
        public void GetProductSet()
        {
            // Snippet: GetProductSet(string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            // Make the request
            ProductSet response = productSearchClient.GetProductSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductSetAsync</summary>
        public async Task GetProductSetAsync()
        {
            // Snippet: GetProductSetAsync(string, CallSettings)
            // Additional: GetProductSetAsync(string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            // Make the request
            ProductSet response = await productSearchClient.GetProductSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductSet</summary>
        public void GetProductSetResourceNames()
        {
            // Snippet: GetProductSet(ProductSetName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            // Make the request
            ProductSet response = productSearchClient.GetProductSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductSetAsync</summary>
        public async Task GetProductSetResourceNamesAsync()
        {
            // Snippet: GetProductSetAsync(ProductSetName, CallSettings)
            // Additional: GetProductSetAsync(ProductSetName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            // Make the request
            ProductSet response = await productSearchClient.GetProductSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductSet</summary>
        public void UpdateProductSetRequestObject()
        {
            // Snippet: UpdateProductSet(UpdateProductSetRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ProductSet response = productSearchClient.UpdateProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductSetAsync</summary>
        public async Task UpdateProductSetRequestObjectAsync()
        {
            // Snippet: UpdateProductSetAsync(UpdateProductSetRequest, CallSettings)
            // Additional: UpdateProductSetAsync(UpdateProductSetRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProductSetRequest request = new UpdateProductSetRequest
            {
                ProductSet = new ProductSet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ProductSet response = await productSearchClient.UpdateProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductSet</summary>
        public void UpdateProductSet()
        {
            // Snippet: UpdateProductSet(ProductSet, FieldMask, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductSet productSet = new ProductSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProductSet response = productSearchClient.UpdateProductSet(productSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductSetAsync</summary>
        public async Task UpdateProductSetAsync()
        {
            // Snippet: UpdateProductSetAsync(ProductSet, FieldMask, CallSettings)
            // Additional: UpdateProductSetAsync(ProductSet, FieldMask, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductSet productSet = new ProductSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProductSet response = await productSearchClient.UpdateProductSetAsync(productSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSet</summary>
        public void DeleteProductSetRequestObject()
        {
            // Snippet: DeleteProductSet(DeleteProductSetRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            // Make the request
            productSearchClient.DeleteProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSetAsync</summary>
        public async Task DeleteProductSetRequestObjectAsync()
        {
            // Snippet: DeleteProductSetAsync(DeleteProductSetRequest, CallSettings)
            // Additional: DeleteProductSetAsync(DeleteProductSetRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProductSetRequest request = new DeleteProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            // Make the request
            await productSearchClient.DeleteProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSet</summary>
        public void DeleteProductSet()
        {
            // Snippet: DeleteProductSet(string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            // Make the request
            productSearchClient.DeleteProductSet(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSetAsync</summary>
        public async Task DeleteProductSetAsync()
        {
            // Snippet: DeleteProductSetAsync(string, CallSettings)
            // Additional: DeleteProductSetAsync(string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            // Make the request
            await productSearchClient.DeleteProductSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSet</summary>
        public void DeleteProductSetResourceNames()
        {
            // Snippet: DeleteProductSet(ProductSetName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            // Make the request
            productSearchClient.DeleteProductSet(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductSetAsync</summary>
        public async Task DeleteProductSetResourceNamesAsync()
        {
            // Snippet: DeleteProductSetAsync(ProductSetName, CallSettings)
            // Additional: DeleteProductSetAsync(ProductSetName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            // Make the request
            await productSearchClient.DeleteProductSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProductRequestObject()
        {
            // Snippet: CreateProduct(CreateProductRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "",
            };
            // Make the request
            Product response = productSearchClient.CreateProduct(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProductAsync</summary>
        public async Task CreateProductRequestObjectAsync()
        {
            // Snippet: CreateProductAsync(CreateProductRequest, CallSettings)
            // Additional: CreateProductAsync(CreateProductRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Product = new Product(),
                ProductId = "",
            };
            // Make the request
            Product response = await productSearchClient.CreateProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProduct()
        {
            // Snippet: CreateProduct(string, Product, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = productSearchClient.CreateProduct(parent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductAsync</summary>
        public async Task CreateProductAsync()
        {
            // Snippet: CreateProductAsync(string, Product, string, CallSettings)
            // Additional: CreateProductAsync(string, Product, string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = await productSearchClient.CreateProductAsync(parent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProductResourceNames()
        {
            // Snippet: CreateProduct(LocationName, Product, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = productSearchClient.CreateProduct(parent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductAsync</summary>
        public async Task CreateProductResourceNamesAsync()
        {
            // Snippet: CreateProductAsync(LocationName, Product, string, CallSettings)
            // Additional: CreateProductAsync(LocationName, Product, string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = await productSearchClient.CreateProductAsync(parent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProductsRequestObject()
        {
            // Snippet: ListProducts(ListProductsRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productSearchClient.ListProducts(request);

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
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productSearchClient.ListProductsAsync(request);

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
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productSearchClient.ListProducts(parent);

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
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productSearchClient.ListProductsAsync(parent);

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
            // Snippet: ListProducts(LocationName, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productSearchClient.ListProducts(parent);

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
            // Snippet: ListProductsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productSearchClient.ListProductsAsync(parent);

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

        /// <summary>Snippet for GetProduct</summary>
        public void GetProductRequestObject()
        {
            // Snippet: GetProduct(GetProductRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            Product response = productSearchClient.GetProduct(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductRequestObjectAsync()
        {
            // Snippet: GetProductAsync(GetProductRequest, CallSettings)
            // Additional: GetProductAsync(GetProductRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            Product response = await productSearchClient.GetProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProduct()
        {
            // Snippet: GetProduct(string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            Product response = productSearchClient.GetProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductAsync()
        {
            // Snippet: GetProductAsync(string, CallSettings)
            // Additional: GetProductAsync(string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            Product response = await productSearchClient.GetProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProductResourceNames()
        {
            // Snippet: GetProduct(ProductName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            Product response = productSearchClient.GetProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductResourceNamesAsync()
        {
            // Snippet: GetProductAsync(ProductName, CallSettings)
            // Additional: GetProductAsync(ProductName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            Product response = await productSearchClient.GetProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateProduct</summary>
        public void UpdateProductRequestObject()
        {
            // Snippet: UpdateProduct(UpdateProductRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Product response = productSearchClient.UpdateProduct(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductAsync</summary>
        public async Task UpdateProductRequestObjectAsync()
        {
            // Snippet: UpdateProductAsync(UpdateProductRequest, CallSettings)
            // Additional: UpdateProductAsync(UpdateProductRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Product response = await productSearchClient.UpdateProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProduct</summary>
        public void UpdateProduct()
        {
            // Snippet: UpdateProduct(Product, FieldMask, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            Product product = new Product();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Product response = productSearchClient.UpdateProduct(product, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductAsync</summary>
        public async Task UpdateProductAsync()
        {
            // Snippet: UpdateProductAsync(Product, FieldMask, CallSettings)
            // Additional: UpdateProductAsync(Product, FieldMask, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            Product product = new Product();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Product response = await productSearchClient.UpdateProductAsync(product, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteProduct</summary>
        public void DeleteProductRequestObject()
        {
            // Snippet: DeleteProduct(DeleteProductRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            productSearchClient.DeleteProduct(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductAsync</summary>
        public async Task DeleteProductRequestObjectAsync()
        {
            // Snippet: DeleteProductAsync(DeleteProductRequest, CallSettings)
            // Additional: DeleteProductAsync(DeleteProductRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            await productSearchClient.DeleteProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProduct</summary>
        public void DeleteProduct()
        {
            // Snippet: DeleteProduct(string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            productSearchClient.DeleteProduct(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductAsync</summary>
        public async Task DeleteProductAsync()
        {
            // Snippet: DeleteProductAsync(string, CallSettings)
            // Additional: DeleteProductAsync(string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            await productSearchClient.DeleteProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProduct</summary>
        public void DeleteProductResourceNames()
        {
            // Snippet: DeleteProduct(ProductName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            productSearchClient.DeleteProduct(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductAsync</summary>
        public async Task DeleteProductResourceNamesAsync()
        {
            // Snippet: DeleteProductAsync(ProductName, CallSettings)
            // Additional: DeleteProductAsync(ProductName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            await productSearchClient.DeleteProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImage</summary>
        public void CreateReferenceImageRequestObject()
        {
            // Snippet: CreateReferenceImage(CreateReferenceImageRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "",
            };
            // Make the request
            ReferenceImage response = productSearchClient.CreateReferenceImage(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImageAsync</summary>
        public async Task CreateReferenceImageRequestObjectAsync()
        {
            // Snippet: CreateReferenceImageAsync(CreateReferenceImageRequest, CallSettings)
            // Additional: CreateReferenceImageAsync(CreateReferenceImageRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            CreateReferenceImageRequest request = new CreateReferenceImageRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                ReferenceImage = new ReferenceImage(),
                ReferenceImageId = "",
            };
            // Make the request
            ReferenceImage response = await productSearchClient.CreateReferenceImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImage</summary>
        public void CreateReferenceImage()
        {
            // Snippet: CreateReferenceImage(string, ReferenceImage, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            ReferenceImage referenceImage = new ReferenceImage();
            string referenceImageId = "";
            // Make the request
            ReferenceImage response = productSearchClient.CreateReferenceImage(parent, referenceImage, referenceImageId);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImageAsync</summary>
        public async Task CreateReferenceImageAsync()
        {
            // Snippet: CreateReferenceImageAsync(string, ReferenceImage, string, CallSettings)
            // Additional: CreateReferenceImageAsync(string, ReferenceImage, string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            ReferenceImage referenceImage = new ReferenceImage();
            string referenceImageId = "";
            // Make the request
            ReferenceImage response = await productSearchClient.CreateReferenceImageAsync(parent, referenceImage, referenceImageId);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImage</summary>
        public void CreateReferenceImageResourceNames()
        {
            // Snippet: CreateReferenceImage(ProductName, ReferenceImage, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductName parent = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            ReferenceImage referenceImage = new ReferenceImage();
            string referenceImageId = "";
            // Make the request
            ReferenceImage response = productSearchClient.CreateReferenceImage(parent, referenceImage, referenceImageId);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceImageAsync</summary>
        public async Task CreateReferenceImageResourceNamesAsync()
        {
            // Snippet: CreateReferenceImageAsync(ProductName, ReferenceImage, string, CallSettings)
            // Additional: CreateReferenceImageAsync(ProductName, ReferenceImage, string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductName parent = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            ReferenceImage referenceImage = new ReferenceImage();
            string referenceImageId = "";
            // Make the request
            ReferenceImage response = await productSearchClient.CreateReferenceImageAsync(parent, referenceImage, referenceImageId);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImage</summary>
        public void DeleteReferenceImageRequestObject()
        {
            // Snippet: DeleteReferenceImage(DeleteReferenceImageRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            // Make the request
            productSearchClient.DeleteReferenceImage(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImageAsync</summary>
        public async Task DeleteReferenceImageRequestObjectAsync()
        {
            // Snippet: DeleteReferenceImageAsync(DeleteReferenceImageRequest, CallSettings)
            // Additional: DeleteReferenceImageAsync(DeleteReferenceImageRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReferenceImageRequest request = new DeleteReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            // Make the request
            await productSearchClient.DeleteReferenceImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImage</summary>
        public void DeleteReferenceImage()
        {
            // Snippet: DeleteReferenceImage(string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]/referenceImages/[REFERENCE_IMAGE]";
            // Make the request
            productSearchClient.DeleteReferenceImage(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImageAsync</summary>
        public async Task DeleteReferenceImageAsync()
        {
            // Snippet: DeleteReferenceImageAsync(string, CallSettings)
            // Additional: DeleteReferenceImageAsync(string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]/referenceImages/[REFERENCE_IMAGE]";
            // Make the request
            await productSearchClient.DeleteReferenceImageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImage</summary>
        public void DeleteReferenceImageResourceNames()
        {
            // Snippet: DeleteReferenceImage(ReferenceImageName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ReferenceImageName name = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]");
            // Make the request
            productSearchClient.DeleteReferenceImage(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReferenceImageAsync</summary>
        public async Task DeleteReferenceImageResourceNamesAsync()
        {
            // Snippet: DeleteReferenceImageAsync(ReferenceImageName, CallSettings)
            // Additional: DeleteReferenceImageAsync(ReferenceImageName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ReferenceImageName name = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]");
            // Make the request
            await productSearchClient.DeleteReferenceImageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImages</summary>
        public void ListReferenceImagesRequestObject()
        {
            // Snippet: ListReferenceImages(ListReferenceImagesRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ListReferenceImagesRequest request = new ListReferenceImagesRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> response = productSearchClient.ListReferenceImages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReferenceImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReferenceImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImagesAsync</summary>
        public async Task ListReferenceImagesRequestObjectAsync()
        {
            // Snippet: ListReferenceImagesAsync(ListReferenceImagesRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ListReferenceImagesRequest request = new ListReferenceImagesRequest
            {
                ParentAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> response = productSearchClient.ListReferenceImagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReferenceImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReferenceImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImages</summary>
        public void ListReferenceImages()
        {
            // Snippet: ListReferenceImages(string, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> response = productSearchClient.ListReferenceImages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReferenceImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReferenceImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImagesAsync</summary>
        public async Task ListReferenceImagesAsync()
        {
            // Snippet: ListReferenceImagesAsync(string, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> response = productSearchClient.ListReferenceImagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReferenceImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReferenceImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImages</summary>
        public void ListReferenceImagesResourceNames()
        {
            // Snippet: ListReferenceImages(ProductName, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductName parent = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            PagedEnumerable<ListReferenceImagesResponse, ReferenceImage> response = productSearchClient.ListReferenceImages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReferenceImage item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReferenceImagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceImagesAsync</summary>
        public async Task ListReferenceImagesResourceNamesAsync()
        {
            // Snippet: ListReferenceImagesAsync(ProductName, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductName parent = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            PagedAsyncEnumerable<ListReferenceImagesResponse, ReferenceImage> response = productSearchClient.ListReferenceImagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReferenceImage item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReferenceImagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceImage item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceImage> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceImage item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImage</summary>
        public void GetReferenceImageRequestObject()
        {
            // Snippet: GetReferenceImage(GetReferenceImageRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            // Make the request
            ReferenceImage response = productSearchClient.GetReferenceImage(request);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImageAsync</summary>
        public async Task GetReferenceImageRequestObjectAsync()
        {
            // Snippet: GetReferenceImageAsync(GetReferenceImageRequest, CallSettings)
            // Additional: GetReferenceImageAsync(GetReferenceImageRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            GetReferenceImageRequest request = new GetReferenceImageRequest
            {
                ReferenceImageName = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]"),
            };
            // Make the request
            ReferenceImage response = await productSearchClient.GetReferenceImageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImage</summary>
        public void GetReferenceImage()
        {
            // Snippet: GetReferenceImage(string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]/referenceImages/[REFERENCE_IMAGE]";
            // Make the request
            ReferenceImage response = productSearchClient.GetReferenceImage(name);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImageAsync</summary>
        public async Task GetReferenceImageAsync()
        {
            // Snippet: GetReferenceImageAsync(string, CallSettings)
            // Additional: GetReferenceImageAsync(string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]/referenceImages/[REFERENCE_IMAGE]";
            // Make the request
            ReferenceImage response = await productSearchClient.GetReferenceImageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImage</summary>
        public void GetReferenceImageResourceNames()
        {
            // Snippet: GetReferenceImage(ReferenceImageName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ReferenceImageName name = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]");
            // Make the request
            ReferenceImage response = productSearchClient.GetReferenceImage(name);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceImageAsync</summary>
        public async Task GetReferenceImageResourceNamesAsync()
        {
            // Snippet: GetReferenceImageAsync(ReferenceImageName, CallSettings)
            // Additional: GetReferenceImageAsync(ReferenceImageName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ReferenceImageName name = ReferenceImageName.FromProjectLocationProductReferenceImage("[PROJECT]", "[LOCATION]", "[PRODUCT]", "[REFERENCE_IMAGE]");
            // Make the request
            ReferenceImage response = await productSearchClient.GetReferenceImageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSet</summary>
        public void AddProductToProductSetRequestObject()
        {
            // Snippet: AddProductToProductSet(AddProductToProductSetRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            productSearchClient.AddProductToProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSetAsync</summary>
        public async Task AddProductToProductSetRequestObjectAsync()
        {
            // Snippet: AddProductToProductSetAsync(AddProductToProductSetRequest, CallSettings)
            // Additional: AddProductToProductSetAsync(AddProductToProductSetRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            AddProductToProductSetRequest request = new AddProductToProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            await productSearchClient.AddProductToProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSet</summary>
        public void AddProductToProductSet()
        {
            // Snippet: AddProductToProductSet(string, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            string product = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            productSearchClient.AddProductToProductSet(name, product);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSetAsync</summary>
        public async Task AddProductToProductSetAsync()
        {
            // Snippet: AddProductToProductSetAsync(string, string, CallSettings)
            // Additional: AddProductToProductSetAsync(string, string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            string product = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            await productSearchClient.AddProductToProductSetAsync(name, product);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSet</summary>
        public void AddProductToProductSetResourceNames()
        {
            // Snippet: AddProductToProductSet(ProductSetName, ProductName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductName product = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            productSearchClient.AddProductToProductSet(name, product);
            // End snippet
        }

        /// <summary>Snippet for AddProductToProductSetAsync</summary>
        public async Task AddProductToProductSetResourceNamesAsync()
        {
            // Snippet: AddProductToProductSetAsync(ProductSetName, ProductName, CallSettings)
            // Additional: AddProductToProductSetAsync(ProductSetName, ProductName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductName product = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            await productSearchClient.AddProductToProductSetAsync(name, product);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSet</summary>
        public void RemoveProductFromProductSetRequestObject()
        {
            // Snippet: RemoveProductFromProductSet(RemoveProductFromProductSetRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            productSearchClient.RemoveProductFromProductSet(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSetAsync</summary>
        public async Task RemoveProductFromProductSetRequestObjectAsync()
        {
            // Snippet: RemoveProductFromProductSetAsync(RemoveProductFromProductSetRequest, CallSettings)
            // Additional: RemoveProductFromProductSetAsync(RemoveProductFromProductSetRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            RemoveProductFromProductSetRequest request = new RemoveProductFromProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                ProductAsProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
            };
            // Make the request
            await productSearchClient.RemoveProductFromProductSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSet</summary>
        public void RemoveProductFromProductSet()
        {
            // Snippet: RemoveProductFromProductSet(string, string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            string product = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            productSearchClient.RemoveProductFromProductSet(name, product);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSetAsync</summary>
        public async Task RemoveProductFromProductSetAsync()
        {
            // Snippet: RemoveProductFromProductSetAsync(string, string, CallSettings)
            // Additional: RemoveProductFromProductSetAsync(string, string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            string product = "projects/[PROJECT]/locations/[LOCATION]/products/[PRODUCT]";
            // Make the request
            await productSearchClient.RemoveProductFromProductSetAsync(name, product);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSet</summary>
        public void RemoveProductFromProductSetResourceNames()
        {
            // Snippet: RemoveProductFromProductSet(ProductSetName, ProductName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductName product = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            productSearchClient.RemoveProductFromProductSet(name, product);
            // End snippet
        }

        /// <summary>Snippet for RemoveProductFromProductSetAsync</summary>
        public async Task RemoveProductFromProductSetResourceNamesAsync()
        {
            // Snippet: RemoveProductFromProductSetAsync(ProductSetName, ProductName, CallSettings)
            // Additional: RemoveProductFromProductSetAsync(ProductSetName, ProductName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            ProductName product = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]");
            // Make the request
            await productSearchClient.RemoveProductFromProductSetAsync(name, product);
            // End snippet
        }

        /// <summary>Snippet for ListProductsInProductSet</summary>
        public void ListProductsInProductSetRequestObject()
        {
            // Snippet: ListProductsInProductSet(ListProductsInProductSetRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ListProductsInProductSetRequest request = new ListProductsInProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            // Make the request
            PagedEnumerable<ListProductsInProductSetResponse, Product> response = productSearchClient.ListProductsInProductSet(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsInProductSetResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProductsInProductSetAsync</summary>
        public async Task ListProductsInProductSetRequestObjectAsync()
        {
            // Snippet: ListProductsInProductSetAsync(ListProductsInProductSetRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ListProductsInProductSetRequest request = new ListProductsInProductSetRequest
            {
                ProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> response = productSearchClient.ListProductsInProductSetAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsInProductSetResponse page) =>
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

        /// <summary>Snippet for ListProductsInProductSet</summary>
        public void ListProductsInProductSet()
        {
            // Snippet: ListProductsInProductSet(string, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            // Make the request
            PagedEnumerable<ListProductsInProductSetResponse, Product> response = productSearchClient.ListProductsInProductSet(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsInProductSetResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProductsInProductSetAsync</summary>
        public async Task ListProductsInProductSetAsync()
        {
            // Snippet: ListProductsInProductSetAsync(string, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/productSets/[PRODUCT_SET]";
            // Make the request
            PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> response = productSearchClient.ListProductsInProductSetAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsInProductSetResponse page) =>
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

        /// <summary>Snippet for ListProductsInProductSet</summary>
        public void ListProductsInProductSetResourceNames()
        {
            // Snippet: ListProductsInProductSet(ProductSetName, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            // Make the request
            PagedEnumerable<ListProductsInProductSetResponse, Product> response = productSearchClient.ListProductsInProductSet(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Product item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProductsInProductSetResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListProductsInProductSetAsync</summary>
        public async Task ListProductsInProductSetResourceNamesAsync()
        {
            // Snippet: ListProductsInProductSetAsync(ProductSetName, string, int?, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ProductSetName name = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]");
            // Make the request
            PagedAsyncEnumerable<ListProductsInProductSetResponse, Product> response = productSearchClient.ListProductsInProductSetAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Product item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProductsInProductSetResponse page) =>
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

        /// <summary>Snippet for ImportProductSets</summary>
        public void ImportProductSetsRequestObject()
        {
            // Snippet: ImportProductSets(ImportProductSetsRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            ImportProductSetsRequest request = new ImportProductSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InputConfig = new ImportProductSetsInputConfig(),
            };
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response = productSearchClient.ImportProductSets(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse = productSearchClient.PollOnceImportProductSets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductSetsAsync</summary>
        public async Task ImportProductSetsRequestObjectAsync()
        {
            // Snippet: ImportProductSetsAsync(ImportProductSetsRequest, CallSettings)
            // Additional: ImportProductSetsAsync(ImportProductSetsRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            ImportProductSetsRequest request = new ImportProductSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InputConfig = new ImportProductSetsInputConfig(),
            };
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response = await productSearchClient.ImportProductSetsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse = await productSearchClient.PollOnceImportProductSetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductSets</summary>
        public void ImportProductSets()
        {
            // Snippet: ImportProductSets(string, ImportProductSetsInputConfig, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ImportProductSetsInputConfig inputConfig = new ImportProductSetsInputConfig();
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response = productSearchClient.ImportProductSets(parent, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse = productSearchClient.PollOnceImportProductSets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductSetsAsync</summary>
        public async Task ImportProductSetsAsync()
        {
            // Snippet: ImportProductSetsAsync(string, ImportProductSetsInputConfig, CallSettings)
            // Additional: ImportProductSetsAsync(string, ImportProductSetsInputConfig, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ImportProductSetsInputConfig inputConfig = new ImportProductSetsInputConfig();
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response = await productSearchClient.ImportProductSetsAsync(parent, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse = await productSearchClient.PollOnceImportProductSetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductSets</summary>
        public void ImportProductSetsResourceNames()
        {
            // Snippet: ImportProductSets(LocationName, ImportProductSetsInputConfig, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ImportProductSetsInputConfig inputConfig = new ImportProductSetsInputConfig();
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response = productSearchClient.ImportProductSets(parent, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse = productSearchClient.PollOnceImportProductSets(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductSetsAsync</summary>
        public async Task ImportProductSetsResourceNamesAsync()
        {
            // Snippet: ImportProductSetsAsync(LocationName, ImportProductSetsInputConfig, CallSettings)
            // Additional: ImportProductSetsAsync(LocationName, ImportProductSetsInputConfig, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ImportProductSetsInputConfig inputConfig = new ImportProductSetsInputConfig();
            // Make the request
            Operation<ImportProductSetsResponse, BatchOperationMetadata> response = await productSearchClient.ImportProductSetsAsync(parent, inputConfig);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductSetsResponse, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportProductSetsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductSetsResponse, BatchOperationMetadata> retrievedResponse = await productSearchClient.PollOnceImportProductSetsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductSetsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeProducts</summary>
        public void PurgeProductsRequestObject()
        {
            // Snippet: PurgeProducts(PurgeProductsRequest, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            PurgeProductsRequest request = new PurgeProductsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSetPurgeConfig = new ProductSetPurgeConfig(),
                Force = false,
            };
            // Make the request
            Operation<Empty, BatchOperationMetadata> response = productSearchClient.PurgeProducts(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchOperationMetadata> retrievedResponse = productSearchClient.PollOncePurgeProducts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeProductsAsync</summary>
        public async Task PurgeProductsRequestObjectAsync()
        {
            // Snippet: PurgeProductsAsync(PurgeProductsRequest, CallSettings)
            // Additional: PurgeProductsAsync(PurgeProductsRequest, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            PurgeProductsRequest request = new PurgeProductsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ProductSetPurgeConfig = new ProductSetPurgeConfig(),
                Force = false,
            };
            // Make the request
            Operation<Empty, BatchOperationMetadata> response = await productSearchClient.PurgeProductsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchOperationMetadata> retrievedResponse = await productSearchClient.PollOncePurgeProductsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeProducts</summary>
        public void PurgeProducts()
        {
            // Snippet: PurgeProducts(string, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            Operation<Empty, BatchOperationMetadata> response = productSearchClient.PurgeProducts(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchOperationMetadata> retrievedResponse = productSearchClient.PollOncePurgeProducts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeProductsAsync</summary>
        public async Task PurgeProductsAsync()
        {
            // Snippet: PurgeProductsAsync(string, CallSettings)
            // Additional: PurgeProductsAsync(string, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            Operation<Empty, BatchOperationMetadata> response = await productSearchClient.PurgeProductsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchOperationMetadata> retrievedResponse = await productSearchClient.PollOncePurgeProductsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeProducts</summary>
        public void PurgeProductsResourceNames()
        {
            // Snippet: PurgeProducts(LocationName, CallSettings)
            // Create client
            ProductSearchClient productSearchClient = ProductSearchClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<Empty, BatchOperationMetadata> response = productSearchClient.PurgeProducts(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchOperationMetadata> retrievedResponse = productSearchClient.PollOncePurgeProducts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeProductsAsync</summary>
        public async Task PurgeProductsResourceNamesAsync()
        {
            // Snippet: PurgeProductsAsync(LocationName, CallSettings)
            // Additional: PurgeProductsAsync(LocationName, CancellationToken)
            // Create client
            ProductSearchClient productSearchClient = await ProductSearchClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<Empty, BatchOperationMetadata> response = await productSearchClient.PurgeProductsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<Empty, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, BatchOperationMetadata> retrievedResponse = await productSearchClient.PollOncePurgeProductsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
