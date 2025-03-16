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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Products.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedProductInputsServiceClientSnippets
    {
        /// <summary>Snippet for InsertProductInput</summary>
        public void InsertProductInputRequestObject()
        {
            // Snippet: InsertProductInput(InsertProductInputRequest, CallSettings)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = ProductInputsServiceClient.Create();
            // Initialize request argument(s)
            InsertProductInputRequest request = new InsertProductInputRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                ProductInput = new ProductInput(),
                DataSource = "",
            };
            // Make the request
            ProductInput response = productInputsServiceClient.InsertProductInput(request);
            // End snippet
        }

        /// <summary>Snippet for InsertProductInputAsync</summary>
        public async Task InsertProductInputRequestObjectAsync()
        {
            // Snippet: InsertProductInputAsync(InsertProductInputRequest, CallSettings)
            // Additional: InsertProductInputAsync(InsertProductInputRequest, CancellationToken)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = await ProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertProductInputRequest request = new InsertProductInputRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                ProductInput = new ProductInput(),
                DataSource = "",
            };
            // Make the request
            ProductInput response = await productInputsServiceClient.InsertProductInputAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductInput</summary>
        public void UpdateProductInputRequestObject()
        {
            // Snippet: UpdateProductInput(UpdateProductInputRequest, CallSettings)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = ProductInputsServiceClient.Create();
            // Initialize request argument(s)
            UpdateProductInputRequest request = new UpdateProductInputRequest
            {
                ProductInput = new ProductInput(),
                UpdateMask = new FieldMask(),
                DataSource = "",
            };
            // Make the request
            ProductInput response = productInputsServiceClient.UpdateProductInput(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductInputAsync</summary>
        public async Task UpdateProductInputRequestObjectAsync()
        {
            // Snippet: UpdateProductInputAsync(UpdateProductInputRequest, CallSettings)
            // Additional: UpdateProductInputAsync(UpdateProductInputRequest, CancellationToken)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = await ProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateProductInputRequest request = new UpdateProductInputRequest
            {
                ProductInput = new ProductInput(),
                UpdateMask = new FieldMask(),
                DataSource = "",
            };
            // Make the request
            ProductInput response = await productInputsServiceClient.UpdateProductInputAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductInput</summary>
        public void UpdateProductInput()
        {
            // Snippet: UpdateProductInput(ProductInput, FieldMask, CallSettings)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = ProductInputsServiceClient.Create();
            // Initialize request argument(s)
            ProductInput productInput = new ProductInput();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProductInput response = productInputsServiceClient.UpdateProductInput(productInput, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateProductInputAsync</summary>
        public async Task UpdateProductInputAsync()
        {
            // Snippet: UpdateProductInputAsync(ProductInput, FieldMask, CallSettings)
            // Additional: UpdateProductInputAsync(ProductInput, FieldMask, CancellationToken)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = await ProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductInput productInput = new ProductInput();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ProductInput response = await productInputsServiceClient.UpdateProductInputAsync(productInput, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductInput</summary>
        public void DeleteProductInputRequestObject()
        {
            // Snippet: DeleteProductInput(DeleteProductInputRequest, CallSettings)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = ProductInputsServiceClient.Create();
            // Initialize request argument(s)
            DeleteProductInputRequest request = new DeleteProductInputRequest
            {
                ProductInputName = ProductInputName.FromAccountProductinput("[ACCOUNT]", "[PRODUCTINPUT]"),
                DataSource = "",
            };
            // Make the request
            productInputsServiceClient.DeleteProductInput(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductInputAsync</summary>
        public async Task DeleteProductInputRequestObjectAsync()
        {
            // Snippet: DeleteProductInputAsync(DeleteProductInputRequest, CallSettings)
            // Additional: DeleteProductInputAsync(DeleteProductInputRequest, CancellationToken)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = await ProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteProductInputRequest request = new DeleteProductInputRequest
            {
                ProductInputName = ProductInputName.FromAccountProductinput("[ACCOUNT]", "[PRODUCTINPUT]"),
                DataSource = "",
            };
            // Make the request
            await productInputsServiceClient.DeleteProductInputAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductInput</summary>
        public void DeleteProductInput()
        {
            // Snippet: DeleteProductInput(string, CallSettings)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = ProductInputsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/productInputs/[PRODUCTINPUT]";
            // Make the request
            productInputsServiceClient.DeleteProductInput(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductInputAsync</summary>
        public async Task DeleteProductInputAsync()
        {
            // Snippet: DeleteProductInputAsync(string, CallSettings)
            // Additional: DeleteProductInputAsync(string, CancellationToken)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = await ProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/productInputs/[PRODUCTINPUT]";
            // Make the request
            await productInputsServiceClient.DeleteProductInputAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductInput</summary>
        public void DeleteProductInputResourceNames()
        {
            // Snippet: DeleteProductInput(ProductInputName, CallSettings)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = ProductInputsServiceClient.Create();
            // Initialize request argument(s)
            ProductInputName name = ProductInputName.FromAccountProductinput("[ACCOUNT]", "[PRODUCTINPUT]");
            // Make the request
            productInputsServiceClient.DeleteProductInput(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProductInputAsync</summary>
        public async Task DeleteProductInputResourceNamesAsync()
        {
            // Snippet: DeleteProductInputAsync(ProductInputName, CallSettings)
            // Additional: DeleteProductInputAsync(ProductInputName, CancellationToken)
            // Create client
            ProductInputsServiceClient productInputsServiceClient = await ProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProductInputName name = ProductInputName.FromAccountProductinput("[ACCOUNT]", "[PRODUCTINPUT]");
            // Make the request
            await productInputsServiceClient.DeleteProductInputAsync(name);
            // End snippet
        }
    }
}
