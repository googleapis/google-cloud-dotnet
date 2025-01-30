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
    using Google.Shopping.Merchant.Lfp.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLfpInventoryServiceClientSnippets
    {
        /// <summary>Snippet for InsertLfpInventory</summary>
        public void InsertLfpInventoryRequestObject()
        {
            // Snippet: InsertLfpInventory(InsertLfpInventoryRequest, CallSettings)
            // Create client
            LfpInventoryServiceClient lfpInventoryServiceClient = LfpInventoryServiceClient.Create();
            // Initialize request argument(s)
            InsertLfpInventoryRequest request = new InsertLfpInventoryRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                LfpInventory = new LfpInventory(),
            };
            // Make the request
            LfpInventory response = lfpInventoryServiceClient.InsertLfpInventory(request);
            // End snippet
        }

        /// <summary>Snippet for InsertLfpInventoryAsync</summary>
        public async Task InsertLfpInventoryRequestObjectAsync()
        {
            // Snippet: InsertLfpInventoryAsync(InsertLfpInventoryRequest, CallSettings)
            // Additional: InsertLfpInventoryAsync(InsertLfpInventoryRequest, CancellationToken)
            // Create client
            LfpInventoryServiceClient lfpInventoryServiceClient = await LfpInventoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertLfpInventoryRequest request = new InsertLfpInventoryRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                LfpInventory = new LfpInventory(),
            };
            // Make the request
            LfpInventory response = await lfpInventoryServiceClient.InsertLfpInventoryAsync(request);
            // End snippet
        }
    }
}
