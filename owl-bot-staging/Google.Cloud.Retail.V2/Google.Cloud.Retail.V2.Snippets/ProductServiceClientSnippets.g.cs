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
    using Google.Cloud.Retail.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProductServiceClientSnippets
    {
        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProductRequestObject()
        {
            // Snippet: CreateProduct(CreateProductRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "",
            };
            // Make the request
            Product response = productServiceClient.CreateProduct(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProductAsync</summary>
        public async Task CreateProductRequestObjectAsync()
        {
            // Snippet: CreateProductAsync(CreateProductRequest, CallSettings)
            // Additional: CreateProductAsync(CreateProductRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateProductRequest request = new CreateProductRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Product = new Product(),
                ProductId = "",
            };
            // Make the request
            Product response = await productServiceClient.CreateProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProduct()
        {
            // Snippet: CreateProduct(string, Product, string, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]";
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = productServiceClient.CreateProduct(parent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductAsync</summary>
        public async Task CreateProductAsync()
        {
            // Snippet: CreateProductAsync(string, Product, string, CallSettings)
            // Additional: CreateProductAsync(string, Product, string, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]";
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = await productServiceClient.CreateProductAsync(parent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for CreateProduct</summary>
        public void CreateProductResourceNames()
        {
            // Snippet: CreateProduct(BranchName, Product, string, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]");
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = productServiceClient.CreateProduct(parent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for CreateProductAsync</summary>
        public async Task CreateProductResourceNamesAsync()
        {
            // Snippet: CreateProductAsync(BranchName, Product, string, CallSettings)
            // Additional: CreateProductAsync(BranchName, Product, string, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]");
            Product product = new Product();
            string productId = "";
            // Make the request
            Product response = await productServiceClient.CreateProductAsync(parent, product, productId);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProductRequestObject()
        {
            // Snippet: GetProduct(GetProductRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            // Make the request
            Product response = productServiceClient.GetProduct(request);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductRequestObjectAsync()
        {
            // Snippet: GetProductAsync(GetProductRequest, CallSettings)
            // Additional: GetProductAsync(GetProductRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetProductRequest request = new GetProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            // Make the request
            Product response = await productServiceClient.GetProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProduct()
        {
            // Snippet: GetProduct(string, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Product response = productServiceClient.GetProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductAsync()
        {
            // Snippet: GetProductAsync(string, CallSettings)
            // Additional: GetProductAsync(string, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Product response = await productServiceClient.GetProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProduct</summary>
        public void GetProductResourceNames()
        {
            // Snippet: GetProduct(ProductName, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Product response = productServiceClient.GetProduct(name);
            // End snippet
        }

        /// <summary>Snippet for GetProductAsync</summary>
        public async Task GetProductResourceNamesAsync()
        {
            // Snippet: GetProductAsync(ProductName, CallSettings)
            // Additional: GetProductAsync(ProductName, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Product response = await productServiceClient.GetProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProducts</summary>
        public void ListProductsRequestObject()
        {
            // Snippet: ListProducts(ListProductsRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productServiceClient.ListProducts(request);

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
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListProductsRequest request = new ListProductsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Filter = "",
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productServiceClient.ListProductsAsync(request);

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
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]";
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productServiceClient.ListProducts(parent);

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
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]";
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productServiceClient.ListProductsAsync(parent);

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
            // Snippet: ListProducts(BranchName, string, int?, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]");
            // Make the request
            PagedEnumerable<ListProductsResponse, Product> response = productServiceClient.ListProducts(parent);

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
            // Snippet: ListProductsAsync(BranchName, string, int?, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            BranchName parent = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]");
            // Make the request
            PagedAsyncEnumerable<ListProductsResponse, Product> response = productServiceClient.ListProductsAsync(parent);

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

        /// <summary>Snippet for UpdateProduct</summary>
        public void UpdateProductRequestObject()
        {
            // Snippet: UpdateProduct(UpdateProductRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Product response = productServiceClient.UpdateProduct(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductAsync</summary>
        public async Task UpdateProductRequestObjectAsync()
        {
            // Snippet: UpdateProductAsync(UpdateProductRequest, CallSettings)
            // Additional: UpdateProductAsync(UpdateProductRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProductRequest request = new UpdateProductRequest
            {
                Product = new Product(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Product response = await productServiceClient.UpdateProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProduct</summary>
        public void UpdateProduct()
        {
            // Snippet: UpdateProduct(Product, FieldMask, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            Product product = new Product();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Product response = productServiceClient.UpdateProduct(product, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductAsync</summary>
        public async Task UpdateProductAsync()
        {
            // Snippet: UpdateProductAsync(Product, FieldMask, CallSettings)
            // Additional: UpdateProductAsync(Product, FieldMask, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            Product product = new Product();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Product response = await productServiceClient.UpdateProductAsync(product, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteProduct</summary>
        public void DeleteProductRequestObject()
        {
            // Snippet: DeleteProduct(DeleteProductRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            // Make the request
            productServiceClient.DeleteProduct(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductAsync</summary>
        public async Task DeleteProductRequestObjectAsync()
        {
            // Snippet: DeleteProductAsync(DeleteProductRequest, CallSettings)
            // Additional: DeleteProductAsync(DeleteProductRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProductRequest request = new DeleteProductRequest
            {
                ProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
            };
            // Make the request
            await productServiceClient.DeleteProductAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProduct</summary>
        public void DeleteProduct()
        {
            // Snippet: DeleteProduct(string, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            productServiceClient.DeleteProduct(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductAsync</summary>
        public async Task DeleteProductAsync()
        {
            // Snippet: DeleteProductAsync(string, CallSettings)
            // Additional: DeleteProductAsync(string, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            await productServiceClient.DeleteProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProduct</summary>
        public void DeleteProductResourceNames()
        {
            // Snippet: DeleteProduct(ProductName, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            productServiceClient.DeleteProduct(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductAsync</summary>
        public async Task DeleteProductResourceNamesAsync()
        {
            // Snippet: DeleteProductAsync(ProductName, CallSettings)
            // Additional: DeleteProductAsync(ProductName, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName name = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            await productServiceClient.DeleteProductAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PurgeProducts</summary>
        public void PurgeProductsRequestObject()
        {
            // Snippet: PurgeProducts(PurgeProductsRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            PurgeProductsRequest request = new PurgeProductsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeProductsResponse, PurgeProductsMetadata> response = productServiceClient.PurgeProducts(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeProductsResponse, PurgeProductsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeProductsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeProductsResponse, PurgeProductsMetadata> retrievedResponse = productServiceClient.PollOncePurgeProducts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeProductsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PurgeProductsAsync</summary>
        public async Task PurgeProductsRequestObjectAsync()
        {
            // Snippet: PurgeProductsAsync(PurgeProductsRequest, CallSettings)
            // Additional: PurgeProductsAsync(PurgeProductsRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            PurgeProductsRequest request = new PurgeProductsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                Filter = "",
                Force = false,
            };
            // Make the request
            Operation<PurgeProductsResponse, PurgeProductsMetadata> response = await productServiceClient.PurgeProductsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PurgeProductsResponse, PurgeProductsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PurgeProductsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeProductsResponse, PurgeProductsMetadata> retrievedResponse = await productServiceClient.PollOncePurgeProductsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeProductsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProducts</summary>
        public void ImportProductsRequestObject()
        {
            // Snippet: ImportProducts(ImportProductsRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ImportProductsRequest request = new ImportProductsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                InputConfig = new ProductInputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
                UpdateMask = new FieldMask(),
                ReconciliationMode = ImportProductsRequest.Types.ReconciliationMode.Unspecified,
                NotificationPubsubTopic = "",
            };
            // Make the request
            Operation<ImportProductsResponse, ImportMetadata> response = productServiceClient.ImportProducts(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductsResponse, ImportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportProductsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductsResponse, ImportMetadata> retrievedResponse = productServiceClient.PollOnceImportProducts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportProductsAsync</summary>
        public async Task ImportProductsRequestObjectAsync()
        {
            // Snippet: ImportProductsAsync(ImportProductsRequest, CallSettings)
            // Additional: ImportProductsAsync(ImportProductsRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportProductsRequest request = new ImportProductsRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationCatalogBranch("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]"),
                InputConfig = new ProductInputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
                UpdateMask = new FieldMask(),
                ReconciliationMode = ImportProductsRequest.Types.ReconciliationMode.Unspecified,
                NotificationPubsubTopic = "",
            };
            // Make the request
            Operation<ImportProductsResponse, ImportMetadata> response = await productServiceClient.ImportProductsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportProductsResponse, ImportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportProductsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportProductsResponse, ImportMetadata> retrievedResponse = await productServiceClient.PollOnceImportProductsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportProductsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInventory</summary>
        public void SetInventoryRequestObject()
        {
            // Snippet: SetInventory(SetInventoryRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            SetInventoryRequest request = new SetInventoryRequest
            {
                Inventory = new Product(),
                SetMask = new FieldMask(),
                SetTime = new Timestamp(),
                AllowMissing = false,
            };
            // Make the request
            Operation<SetInventoryResponse, SetInventoryMetadata> response = productServiceClient.SetInventory(request);

            // Poll until the returned long-running operation is complete
            Operation<SetInventoryResponse, SetInventoryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SetInventoryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInventoryResponse, SetInventoryMetadata> retrievedResponse = productServiceClient.PollOnceSetInventory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInventoryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInventoryAsync</summary>
        public async Task SetInventoryRequestObjectAsync()
        {
            // Snippet: SetInventoryAsync(SetInventoryRequest, CallSettings)
            // Additional: SetInventoryAsync(SetInventoryRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetInventoryRequest request = new SetInventoryRequest
            {
                Inventory = new Product(),
                SetMask = new FieldMask(),
                SetTime = new Timestamp(),
                AllowMissing = false,
            };
            // Make the request
            Operation<SetInventoryResponse, SetInventoryMetadata> response = await productServiceClient.SetInventoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SetInventoryResponse, SetInventoryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SetInventoryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInventoryResponse, SetInventoryMetadata> retrievedResponse = await productServiceClient.PollOnceSetInventoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInventoryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInventory</summary>
        public void SetInventory()
        {
            // Snippet: SetInventory(Product, FieldMask, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            Product inventory = new Product();
            FieldMask setMask = new FieldMask();
            // Make the request
            Operation<SetInventoryResponse, SetInventoryMetadata> response = productServiceClient.SetInventory(inventory, setMask);

            // Poll until the returned long-running operation is complete
            Operation<SetInventoryResponse, SetInventoryMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SetInventoryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInventoryResponse, SetInventoryMetadata> retrievedResponse = productServiceClient.PollOnceSetInventory(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInventoryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInventoryAsync</summary>
        public async Task SetInventoryAsync()
        {
            // Snippet: SetInventoryAsync(Product, FieldMask, CallSettings)
            // Additional: SetInventoryAsync(Product, FieldMask, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            Product inventory = new Product();
            FieldMask setMask = new FieldMask();
            // Make the request
            Operation<SetInventoryResponse, SetInventoryMetadata> response = await productServiceClient.SetInventoryAsync(inventory, setMask);

            // Poll until the returned long-running operation is complete
            Operation<SetInventoryResponse, SetInventoryMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SetInventoryResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInventoryResponse, SetInventoryMetadata> retrievedResponse = await productServiceClient.PollOnceSetInventoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInventoryResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddFulfillmentPlaces</summary>
        public void AddFulfillmentPlacesRequestObject()
        {
            // Snippet: AddFulfillmentPlaces(AddFulfillmentPlacesRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            AddFulfillmentPlacesRequest request = new AddFulfillmentPlacesRequest
            {
                ProductAsProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Type = "",
                PlaceIds = { "", },
                AddTime = new Timestamp(),
                AllowMissing = false,
            };
            // Make the request
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> response = productServiceClient.AddFulfillmentPlaces(request);

            // Poll until the returned long-running operation is complete
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> retrievedResponse = productServiceClient.PollOnceAddFulfillmentPlaces(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddFulfillmentPlacesAsync</summary>
        public async Task AddFulfillmentPlacesRequestObjectAsync()
        {
            // Snippet: AddFulfillmentPlacesAsync(AddFulfillmentPlacesRequest, CallSettings)
            // Additional: AddFulfillmentPlacesAsync(AddFulfillmentPlacesRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddFulfillmentPlacesRequest request = new AddFulfillmentPlacesRequest
            {
                ProductAsProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Type = "",
                PlaceIds = { "", },
                AddTime = new Timestamp(),
                AllowMissing = false,
            };
            // Make the request
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> response = await productServiceClient.AddFulfillmentPlacesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> retrievedResponse = await productServiceClient.PollOnceAddFulfillmentPlacesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddFulfillmentPlaces</summary>
        public void AddFulfillmentPlaces()
        {
            // Snippet: AddFulfillmentPlaces(string, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> response = productServiceClient.AddFulfillmentPlaces(product);

            // Poll until the returned long-running operation is complete
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> retrievedResponse = productServiceClient.PollOnceAddFulfillmentPlaces(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddFulfillmentPlacesAsync</summary>
        public async Task AddFulfillmentPlacesAsync()
        {
            // Snippet: AddFulfillmentPlacesAsync(string, CallSettings)
            // Additional: AddFulfillmentPlacesAsync(string, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> response = await productServiceClient.AddFulfillmentPlacesAsync(product);

            // Poll until the returned long-running operation is complete
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> retrievedResponse = await productServiceClient.PollOnceAddFulfillmentPlacesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddFulfillmentPlaces</summary>
        public void AddFulfillmentPlacesResourceNames()
        {
            // Snippet: AddFulfillmentPlaces(ProductName, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> response = productServiceClient.AddFulfillmentPlaces(product);

            // Poll until the returned long-running operation is complete
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> retrievedResponse = productServiceClient.PollOnceAddFulfillmentPlaces(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddFulfillmentPlacesAsync</summary>
        public async Task AddFulfillmentPlacesResourceNamesAsync()
        {
            // Snippet: AddFulfillmentPlacesAsync(ProductName, CallSettings)
            // Additional: AddFulfillmentPlacesAsync(ProductName, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> response = await productServiceClient.AddFulfillmentPlacesAsync(product);

            // Poll until the returned long-running operation is complete
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddFulfillmentPlacesResponse, AddFulfillmentPlacesMetadata> retrievedResponse = await productServiceClient.PollOnceAddFulfillmentPlacesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveFulfillmentPlaces</summary>
        public void RemoveFulfillmentPlacesRequestObject()
        {
            // Snippet: RemoveFulfillmentPlaces(RemoveFulfillmentPlacesRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            RemoveFulfillmentPlacesRequest request = new RemoveFulfillmentPlacesRequest
            {
                ProductAsProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Type = "",
                PlaceIds = { "", },
                RemoveTime = new Timestamp(),
                AllowMissing = false,
            };
            // Make the request
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> response = productServiceClient.RemoveFulfillmentPlaces(request);

            // Poll until the returned long-running operation is complete
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> retrievedResponse = productServiceClient.PollOnceRemoveFulfillmentPlaces(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveFulfillmentPlacesAsync</summary>
        public async Task RemoveFulfillmentPlacesRequestObjectAsync()
        {
            // Snippet: RemoveFulfillmentPlacesAsync(RemoveFulfillmentPlacesRequest, CallSettings)
            // Additional: RemoveFulfillmentPlacesAsync(RemoveFulfillmentPlacesRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemoveFulfillmentPlacesRequest request = new RemoveFulfillmentPlacesRequest
            {
                ProductAsProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                Type = "",
                PlaceIds = { "", },
                RemoveTime = new Timestamp(),
                AllowMissing = false,
            };
            // Make the request
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> response = await productServiceClient.RemoveFulfillmentPlacesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> retrievedResponse = await productServiceClient.PollOnceRemoveFulfillmentPlacesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveFulfillmentPlaces</summary>
        public void RemoveFulfillmentPlaces()
        {
            // Snippet: RemoveFulfillmentPlaces(string, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> response = productServiceClient.RemoveFulfillmentPlaces(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> retrievedResponse = productServiceClient.PollOnceRemoveFulfillmentPlaces(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveFulfillmentPlacesAsync</summary>
        public async Task RemoveFulfillmentPlacesAsync()
        {
            // Snippet: RemoveFulfillmentPlacesAsync(string, CallSettings)
            // Additional: RemoveFulfillmentPlacesAsync(string, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> response = await productServiceClient.RemoveFulfillmentPlacesAsync(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> retrievedResponse = await productServiceClient.PollOnceRemoveFulfillmentPlacesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveFulfillmentPlaces</summary>
        public void RemoveFulfillmentPlacesResourceNames()
        {
            // Snippet: RemoveFulfillmentPlaces(ProductName, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> response = productServiceClient.RemoveFulfillmentPlaces(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> retrievedResponse = productServiceClient.PollOnceRemoveFulfillmentPlaces(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveFulfillmentPlacesAsync</summary>
        public async Task RemoveFulfillmentPlacesResourceNamesAsync()
        {
            // Snippet: RemoveFulfillmentPlacesAsync(ProductName, CallSettings)
            // Additional: RemoveFulfillmentPlacesAsync(ProductName, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> response = await productServiceClient.RemoveFulfillmentPlacesAsync(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveFulfillmentPlacesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveFulfillmentPlacesResponse, RemoveFulfillmentPlacesMetadata> retrievedResponse = await productServiceClient.PollOnceRemoveFulfillmentPlacesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveFulfillmentPlacesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddLocalInventories</summary>
        public void AddLocalInventoriesRequestObject()
        {
            // Snippet: AddLocalInventories(AddLocalInventoriesRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            AddLocalInventoriesRequest request = new AddLocalInventoriesRequest
            {
                ProductAsProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                LocalInventories =
                {
                    new LocalInventory(),
                },
                AddMask = new FieldMask(),
                AddTime = new Timestamp(),
                AllowMissing = false,
            };
            // Make the request
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> response = productServiceClient.AddLocalInventories(request);

            // Poll until the returned long-running operation is complete
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> retrievedResponse = productServiceClient.PollOnceAddLocalInventories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddLocalInventoriesAsync</summary>
        public async Task AddLocalInventoriesRequestObjectAsync()
        {
            // Snippet: AddLocalInventoriesAsync(AddLocalInventoriesRequest, CallSettings)
            // Additional: AddLocalInventoriesAsync(AddLocalInventoriesRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddLocalInventoriesRequest request = new AddLocalInventoriesRequest
            {
                ProductAsProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                LocalInventories =
                {
                    new LocalInventory(),
                },
                AddMask = new FieldMask(),
                AddTime = new Timestamp(),
                AllowMissing = false,
            };
            // Make the request
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> response = await productServiceClient.AddLocalInventoriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> retrievedResponse = await productServiceClient.PollOnceAddLocalInventoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddLocalInventories</summary>
        public void AddLocalInventories()
        {
            // Snippet: AddLocalInventories(string, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> response = productServiceClient.AddLocalInventories(product);

            // Poll until the returned long-running operation is complete
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> retrievedResponse = productServiceClient.PollOnceAddLocalInventories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddLocalInventoriesAsync</summary>
        public async Task AddLocalInventoriesAsync()
        {
            // Snippet: AddLocalInventoriesAsync(string, CallSettings)
            // Additional: AddLocalInventoriesAsync(string, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> response = await productServiceClient.AddLocalInventoriesAsync(product);

            // Poll until the returned long-running operation is complete
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> retrievedResponse = await productServiceClient.PollOnceAddLocalInventoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddLocalInventories</summary>
        public void AddLocalInventoriesResourceNames()
        {
            // Snippet: AddLocalInventories(ProductName, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> response = productServiceClient.AddLocalInventories(product);

            // Poll until the returned long-running operation is complete
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> retrievedResponse = productServiceClient.PollOnceAddLocalInventories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddLocalInventoriesAsync</summary>
        public async Task AddLocalInventoriesResourceNamesAsync()
        {
            // Snippet: AddLocalInventoriesAsync(ProductName, CallSettings)
            // Additional: AddLocalInventoriesAsync(ProductName, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> response = await productServiceClient.AddLocalInventoriesAsync(product);

            // Poll until the returned long-running operation is complete
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddLocalInventoriesResponse, AddLocalInventoriesMetadata> retrievedResponse = await productServiceClient.PollOnceAddLocalInventoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveLocalInventories</summary>
        public void RemoveLocalInventoriesRequestObject()
        {
            // Snippet: RemoveLocalInventories(RemoveLocalInventoriesRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            RemoveLocalInventoriesRequest request = new RemoveLocalInventoriesRequest
            {
                ProductAsProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                PlaceIds = { "", },
                AllowMissing = false,
                RemoveTime = new Timestamp(),
            };
            // Make the request
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> response = productServiceClient.RemoveLocalInventories(request);

            // Poll until the returned long-running operation is complete
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> retrievedResponse = productServiceClient.PollOnceRemoveLocalInventories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveLocalInventoriesAsync</summary>
        public async Task RemoveLocalInventoriesRequestObjectAsync()
        {
            // Snippet: RemoveLocalInventoriesAsync(RemoveLocalInventoriesRequest, CallSettings)
            // Additional: RemoveLocalInventoriesAsync(RemoveLocalInventoriesRequest, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemoveLocalInventoriesRequest request = new RemoveLocalInventoriesRequest
            {
                ProductAsProductName = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]"),
                PlaceIds = { "", },
                AllowMissing = false,
                RemoveTime = new Timestamp(),
            };
            // Make the request
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> response = await productServiceClient.RemoveLocalInventoriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> retrievedResponse = await productServiceClient.PollOnceRemoveLocalInventoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveLocalInventories</summary>
        public void RemoveLocalInventories()
        {
            // Snippet: RemoveLocalInventories(string, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> response = productServiceClient.RemoveLocalInventories(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> retrievedResponse = productServiceClient.PollOnceRemoveLocalInventories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveLocalInventoriesAsync</summary>
        public async Task RemoveLocalInventoriesAsync()
        {
            // Snippet: RemoveLocalInventoriesAsync(string, CallSettings)
            // Additional: RemoveLocalInventoriesAsync(string, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> response = await productServiceClient.RemoveLocalInventoriesAsync(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> retrievedResponse = await productServiceClient.PollOnceRemoveLocalInventoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveLocalInventories</summary>
        public void RemoveLocalInventoriesResourceNames()
        {
            // Snippet: RemoveLocalInventories(ProductName, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> response = productServiceClient.RemoveLocalInventories(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> retrievedResponse = productServiceClient.PollOnceRemoveLocalInventories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveLocalInventoriesAsync</summary>
        public async Task RemoveLocalInventoriesResourceNamesAsync()
        {
            // Snippet: RemoveLocalInventoriesAsync(ProductName, CallSettings)
            // Additional: RemoveLocalInventoriesAsync(ProductName, CancellationToken)
            // Create client
            ProductServiceClient productServiceClient = await ProductServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductName product = ProductName.FromProjectLocationCatalogBranchProduct("[PROJECT]", "[LOCATION]", "[CATALOG]", "[BRANCH]", "[PRODUCT]");
            // Make the request
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> response = await productServiceClient.RemoveLocalInventoriesAsync(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RemoveLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> retrievedResponse = await productServiceClient.PollOnceRemoveLocalInventoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
