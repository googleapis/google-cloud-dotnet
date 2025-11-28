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
    using Google.Shopping.Merchant.OrderTracking.V1Beta;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOrderTrackingSignalsServiceClientSnippets
    {
        /// <summary>Snippet for CreateOrderTrackingSignal</summary>
        public void CreateOrderTrackingSignalRequestObject()
        {
            // Snippet: CreateOrderTrackingSignal(CreateOrderTrackingSignalRequest, CallSettings)
            // Create client
            OrderTrackingSignalsServiceClient orderTrackingSignalsServiceClient = OrderTrackingSignalsServiceClient.Create();
            // Initialize request argument(s)
            CreateOrderTrackingSignalRequest request = new CreateOrderTrackingSignalRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                OrderTrackingSignalId = "",
                OrderTrackingSignal = new OrderTrackingSignal(),
            };
            // Make the request
            OrderTrackingSignal response = orderTrackingSignalsServiceClient.CreateOrderTrackingSignal(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOrderTrackingSignalAsync</summary>
        public async Task CreateOrderTrackingSignalRequestObjectAsync()
        {
            // Snippet: CreateOrderTrackingSignalAsync(CreateOrderTrackingSignalRequest, CallSettings)
            // Additional: CreateOrderTrackingSignalAsync(CreateOrderTrackingSignalRequest, CancellationToken)
            // Create client
            OrderTrackingSignalsServiceClient orderTrackingSignalsServiceClient = await OrderTrackingSignalsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOrderTrackingSignalRequest request = new CreateOrderTrackingSignalRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                OrderTrackingSignalId = "",
                OrderTrackingSignal = new OrderTrackingSignal(),
            };
            // Make the request
            OrderTrackingSignal response = await orderTrackingSignalsServiceClient.CreateOrderTrackingSignalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOrderTrackingSignal</summary>
        public void CreateOrderTrackingSignal()
        {
            // Snippet: CreateOrderTrackingSignal(string, string, CallSettings)
            // Create client
            OrderTrackingSignalsServiceClient orderTrackingSignalsServiceClient = OrderTrackingSignalsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            string orderTrackingSignalId = "";
            // Make the request
            OrderTrackingSignal response = orderTrackingSignalsServiceClient.CreateOrderTrackingSignal(parent, orderTrackingSignalId);
            // End snippet
        }

        /// <summary>Snippet for CreateOrderTrackingSignalAsync</summary>
        public async Task CreateOrderTrackingSignalAsync()
        {
            // Snippet: CreateOrderTrackingSignalAsync(string, string, CallSettings)
            // Additional: CreateOrderTrackingSignalAsync(string, string, CancellationToken)
            // Create client
            OrderTrackingSignalsServiceClient orderTrackingSignalsServiceClient = await OrderTrackingSignalsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            string orderTrackingSignalId = "";
            // Make the request
            OrderTrackingSignal response = await orderTrackingSignalsServiceClient.CreateOrderTrackingSignalAsync(parent, orderTrackingSignalId);
            // End snippet
        }

        /// <summary>Snippet for CreateOrderTrackingSignal</summary>
        public void CreateOrderTrackingSignalResourceNames()
        {
            // Snippet: CreateOrderTrackingSignal(AccountName, string, CallSettings)
            // Create client
            OrderTrackingSignalsServiceClient orderTrackingSignalsServiceClient = OrderTrackingSignalsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            string orderTrackingSignalId = "";
            // Make the request
            OrderTrackingSignal response = orderTrackingSignalsServiceClient.CreateOrderTrackingSignal(parent, orderTrackingSignalId);
            // End snippet
        }

        /// <summary>Snippet for CreateOrderTrackingSignalAsync</summary>
        public async Task CreateOrderTrackingSignalResourceNamesAsync()
        {
            // Snippet: CreateOrderTrackingSignalAsync(AccountName, string, CallSettings)
            // Additional: CreateOrderTrackingSignalAsync(AccountName, string, CancellationToken)
            // Create client
            OrderTrackingSignalsServiceClient orderTrackingSignalsServiceClient = await OrderTrackingSignalsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            string orderTrackingSignalId = "";
            // Make the request
            OrderTrackingSignal response = await orderTrackingSignalsServiceClient.CreateOrderTrackingSignalAsync(parent, orderTrackingSignalId);
            // End snippet
        }
    }
}
