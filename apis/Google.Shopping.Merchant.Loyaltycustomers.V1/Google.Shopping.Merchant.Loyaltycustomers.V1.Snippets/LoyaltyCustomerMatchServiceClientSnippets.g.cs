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
    using Google.Shopping.Merchant.Loyaltycustomers.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLoyaltyCustomerMatchServiceClientSnippets
    {
        /// <summary>Snippet for ManageLoyaltyCustomerMatch</summary>
        public void ManageLoyaltyCustomerMatchRequestObject()
        {
            // Snippet: ManageLoyaltyCustomerMatch(ManageLoyaltyCustomerMatchRequest, CallSettings)
            // Create client
            LoyaltyCustomerMatchServiceClient loyaltyCustomerMatchServiceClient = LoyaltyCustomerMatchServiceClient.Create();
            // Initialize request argument(s)
            ManageLoyaltyCustomerMatchRequest request = new ManageLoyaltyCustomerMatchRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                LoyaltyCustomer = new LoyaltyCustomer(),
            };
            // Make the request
            ManageLoyaltyCustomerMatchResponse response = loyaltyCustomerMatchServiceClient.ManageLoyaltyCustomerMatch(request);
            // End snippet
        }

        /// <summary>Snippet for ManageLoyaltyCustomerMatchAsync</summary>
        public async Task ManageLoyaltyCustomerMatchRequestObjectAsync()
        {
            // Snippet: ManageLoyaltyCustomerMatchAsync(ManageLoyaltyCustomerMatchRequest, CallSettings)
            // Additional: ManageLoyaltyCustomerMatchAsync(ManageLoyaltyCustomerMatchRequest, CancellationToken)
            // Create client
            LoyaltyCustomerMatchServiceClient loyaltyCustomerMatchServiceClient = await LoyaltyCustomerMatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ManageLoyaltyCustomerMatchRequest request = new ManageLoyaltyCustomerMatchRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                LoyaltyCustomer = new LoyaltyCustomer(),
            };
            // Make the request
            ManageLoyaltyCustomerMatchResponse response = await loyaltyCustomerMatchServiceClient.ManageLoyaltyCustomerMatchAsync(request);
            // End snippet
        }
    }
}
