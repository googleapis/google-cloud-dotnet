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

namespace Google.Cloud.Retail.V2.Snippets
{
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedProductServiceClientSnippets
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

        /// <summary>Snippet for ImportProducts</summary>
        public void ImportProductsRequestObject()
        {
            // Snippet: ImportProducts(ImportProductsRequest, CallSettings)
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            ImportProductsRequest request = new ImportProductsRequest
            {
                Parent = "",
                InputConfig = new ProductInputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
                UpdateMask = new FieldMask(),
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
                Parent = "",
                InputConfig = new ProductInputConfig(),
                ErrorsConfig = new ImportErrorsConfig(),
                UpdateMask = new FieldMask(),
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
    }
}
