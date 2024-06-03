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
    // [START cloudcommerceconsumerprocurement_v1_generated_ConsumerProcurementService_PlaceOrder_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Commerce.Consumer.Procurement.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedConsumerProcurementServiceClientSnippets
    {
        /// <summary>Snippet for PlaceOrderAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task PlaceOrderRequestObjectAsync()
        {
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = await ConsumerProcurementServiceClient.CreateAsync();
            // Initialize request argument(s)
            PlaceOrderRequest request = new PlaceOrderRequest
            {
                ParentAsBillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                DisplayName = "",
                RequestId = "",
                LineItemInfo = { new LineItemInfo(), },
            };
            // Make the request
            Operation<Order, PlaceOrderMetadata> response = await consumerProcurementServiceClient.PlaceOrderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, PlaceOrderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, PlaceOrderMetadata> retrievedResponse = await consumerProcurementServiceClient.PollOncePlaceOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END cloudcommerceconsumerprocurement_v1_generated_ConsumerProcurementService_PlaceOrder_async]
}
