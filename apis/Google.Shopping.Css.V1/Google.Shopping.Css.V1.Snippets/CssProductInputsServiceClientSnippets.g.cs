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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Css.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCssProductInputsServiceClientSnippets
    {
        /// <summary>Snippet for InsertCssProductInput</summary>
        public void InsertCssProductInputRequestObject()
        {
            // Snippet: InsertCssProductInput(InsertCssProductInputRequest, CallSettings)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = CssProductInputsServiceClient.Create();
            // Initialize request argument(s)
            InsertCssProductInputRequest request = new InsertCssProductInputRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                CssProductInput = new CssProductInput(),
            };
            // Make the request
            CssProductInput response = cssProductInputsServiceClient.InsertCssProductInput(request);
            // End snippet
        }

        /// <summary>Snippet for InsertCssProductInputAsync</summary>
        public async Task InsertCssProductInputRequestObjectAsync()
        {
            // Snippet: InsertCssProductInputAsync(InsertCssProductInputRequest, CallSettings)
            // Additional: InsertCssProductInputAsync(InsertCssProductInputRequest, CancellationToken)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = await CssProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertCssProductInputRequest request = new InsertCssProductInputRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                CssProductInput = new CssProductInput(),
            };
            // Make the request
            CssProductInput response = await cssProductInputsServiceClient.InsertCssProductInputAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCssProductInput</summary>
        public void UpdateCssProductInputRequestObject()
        {
            // Snippet: UpdateCssProductInput(UpdateCssProductInputRequest, CallSettings)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = CssProductInputsServiceClient.Create();
            // Initialize request argument(s)
            UpdateCssProductInputRequest request = new UpdateCssProductInputRequest
            {
                CssProductInput = new CssProductInput(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CssProductInput response = cssProductInputsServiceClient.UpdateCssProductInput(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCssProductInputAsync</summary>
        public async Task UpdateCssProductInputRequestObjectAsync()
        {
            // Snippet: UpdateCssProductInputAsync(UpdateCssProductInputRequest, CallSettings)
            // Additional: UpdateCssProductInputAsync(UpdateCssProductInputRequest, CancellationToken)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = await CssProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCssProductInputRequest request = new UpdateCssProductInputRequest
            {
                CssProductInput = new CssProductInput(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CssProductInput response = await cssProductInputsServiceClient.UpdateCssProductInputAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCssProductInput</summary>
        public void UpdateCssProductInput()
        {
            // Snippet: UpdateCssProductInput(CssProductInput, FieldMask, CallSettings)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = CssProductInputsServiceClient.Create();
            // Initialize request argument(s)
            CssProductInput cssProductInput = new CssProductInput();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CssProductInput response = cssProductInputsServiceClient.UpdateCssProductInput(cssProductInput, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCssProductInputAsync</summary>
        public async Task UpdateCssProductInputAsync()
        {
            // Snippet: UpdateCssProductInputAsync(CssProductInput, FieldMask, CallSettings)
            // Additional: UpdateCssProductInputAsync(CssProductInput, FieldMask, CancellationToken)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = await CssProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CssProductInput cssProductInput = new CssProductInput();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CssProductInput response = await cssProductInputsServiceClient.UpdateCssProductInputAsync(cssProductInput, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCssProductInput</summary>
        public void DeleteCssProductInputRequestObject()
        {
            // Snippet: DeleteCssProductInput(DeleteCssProductInputRequest, CallSettings)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = CssProductInputsServiceClient.Create();
            // Initialize request argument(s)
            DeleteCssProductInputRequest request = new DeleteCssProductInputRequest
            {
                CssProductInputName = CssProductInputName.FromAccountCssProductInput("[ACCOUNT]", "[CSS_PRODUCT_INPUT]"),
                SupplementalFeedId = 0L,
            };
            // Make the request
            cssProductInputsServiceClient.DeleteCssProductInput(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCssProductInputAsync</summary>
        public async Task DeleteCssProductInputRequestObjectAsync()
        {
            // Snippet: DeleteCssProductInputAsync(DeleteCssProductInputRequest, CallSettings)
            // Additional: DeleteCssProductInputAsync(DeleteCssProductInputRequest, CancellationToken)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = await CssProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCssProductInputRequest request = new DeleteCssProductInputRequest
            {
                CssProductInputName = CssProductInputName.FromAccountCssProductInput("[ACCOUNT]", "[CSS_PRODUCT_INPUT]"),
                SupplementalFeedId = 0L,
            };
            // Make the request
            await cssProductInputsServiceClient.DeleteCssProductInputAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCssProductInput</summary>
        public void DeleteCssProductInput()
        {
            // Snippet: DeleteCssProductInput(string, CallSettings)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = CssProductInputsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/cssProductInputs/[CSS_PRODUCT_INPUT]";
            // Make the request
            cssProductInputsServiceClient.DeleteCssProductInput(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCssProductInputAsync</summary>
        public async Task DeleteCssProductInputAsync()
        {
            // Snippet: DeleteCssProductInputAsync(string, CallSettings)
            // Additional: DeleteCssProductInputAsync(string, CancellationToken)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = await CssProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/cssProductInputs/[CSS_PRODUCT_INPUT]";
            // Make the request
            await cssProductInputsServiceClient.DeleteCssProductInputAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCssProductInput</summary>
        public void DeleteCssProductInputResourceNames()
        {
            // Snippet: DeleteCssProductInput(CssProductInputName, CallSettings)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = CssProductInputsServiceClient.Create();
            // Initialize request argument(s)
            CssProductInputName name = CssProductInputName.FromAccountCssProductInput("[ACCOUNT]", "[CSS_PRODUCT_INPUT]");
            // Make the request
            cssProductInputsServiceClient.DeleteCssProductInput(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCssProductInputAsync</summary>
        public async Task DeleteCssProductInputResourceNamesAsync()
        {
            // Snippet: DeleteCssProductInputAsync(CssProductInputName, CallSettings)
            // Additional: DeleteCssProductInputAsync(CssProductInputName, CancellationToken)
            // Create client
            CssProductInputsServiceClient cssProductInputsServiceClient = await CssProductInputsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CssProductInputName name = CssProductInputName.FromAccountCssProductInput("[ACCOUNT]", "[CSS_PRODUCT_INPUT]");
            // Make the request
            await cssProductInputsServiceClient.DeleteCssProductInputAsync(name);
            // End snippet
        }
    }
}
