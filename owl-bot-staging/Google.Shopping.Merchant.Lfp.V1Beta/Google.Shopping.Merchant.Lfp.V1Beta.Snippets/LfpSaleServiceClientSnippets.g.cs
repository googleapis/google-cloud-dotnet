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
    public sealed class AllGeneratedLfpSaleServiceClientSnippets
    {
        /// <summary>Snippet for InsertLfpSale</summary>
        public void InsertLfpSaleRequestObject()
        {
            // Snippet: InsertLfpSale(InsertLfpSaleRequest, CallSettings)
            // Create client
            LfpSaleServiceClient lfpSaleServiceClient = LfpSaleServiceClient.Create();
            // Initialize request argument(s)
            InsertLfpSaleRequest request = new InsertLfpSaleRequest
            {
                Parent = "",
                LfpSale = new LfpSale(),
            };
            // Make the request
            LfpSale response = lfpSaleServiceClient.InsertLfpSale(request);
            // End snippet
        }

        /// <summary>Snippet for InsertLfpSaleAsync</summary>
        public async Task InsertLfpSaleRequestObjectAsync()
        {
            // Snippet: InsertLfpSaleAsync(InsertLfpSaleRequest, CallSettings)
            // Additional: InsertLfpSaleAsync(InsertLfpSaleRequest, CancellationToken)
            // Create client
            LfpSaleServiceClient lfpSaleServiceClient = await LfpSaleServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsertLfpSaleRequest request = new InsertLfpSaleRequest
            {
                Parent = "",
                LfpSale = new LfpSale(),
            };
            // Make the request
            LfpSale response = await lfpSaleServiceClient.InsertLfpSaleAsync(request);
            // End snippet
        }
    }
}
