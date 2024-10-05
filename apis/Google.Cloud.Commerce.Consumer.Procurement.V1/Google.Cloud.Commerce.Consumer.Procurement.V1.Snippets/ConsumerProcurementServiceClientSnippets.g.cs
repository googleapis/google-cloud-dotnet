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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Commerce.Consumer.Procurement.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConsumerProcurementServiceClientSnippets
    {
        /// <summary>Snippet for PlaceOrder</summary>
        public void PlaceOrderRequestObject()
        {
            // Snippet: PlaceOrder(PlaceOrderRequest, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = ConsumerProcurementServiceClient.Create();
            // Initialize request argument(s)
            PlaceOrderRequest request = new PlaceOrderRequest
            {
                ParentAsBillingAccountName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
                DisplayName = "",
                RequestId = "",
                LineItemInfo = { new LineItemInfo(), },
            };
            // Make the request
            Operation<Order, PlaceOrderMetadata> response = consumerProcurementServiceClient.PlaceOrder(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, PlaceOrderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, PlaceOrderMetadata> retrievedResponse = consumerProcurementServiceClient.PollOncePlaceOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PlaceOrderAsync</summary>
        public async Task PlaceOrderRequestObjectAsync()
        {
            // Snippet: PlaceOrderAsync(PlaceOrderRequest, CallSettings)
            // Additional: PlaceOrderAsync(PlaceOrderRequest, CancellationToken)
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
            // End snippet
        }

        /// <summary>Snippet for GetOrder</summary>
        public void GetOrderRequestObject()
        {
            // Snippet: GetOrder(GetOrderRequest, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = ConsumerProcurementServiceClient.Create();
            // Initialize request argument(s)
            GetOrderRequest request = new GetOrderRequest { Name = "", };
            // Make the request
            Order response = consumerProcurementServiceClient.GetOrder(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrderAsync</summary>
        public async Task GetOrderRequestObjectAsync()
        {
            // Snippet: GetOrderAsync(GetOrderRequest, CallSettings)
            // Additional: GetOrderAsync(GetOrderRequest, CancellationToken)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = await ConsumerProcurementServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOrderRequest request = new GetOrderRequest { Name = "", };
            // Make the request
            Order response = await consumerProcurementServiceClient.GetOrderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrder</summary>
        public void GetOrder()
        {
            // Snippet: GetOrder(string, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = ConsumerProcurementServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Order response = consumerProcurementServiceClient.GetOrder(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrderAsync</summary>
        public async Task GetOrderAsync()
        {
            // Snippet: GetOrderAsync(string, CallSettings)
            // Additional: GetOrderAsync(string, CancellationToken)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = await ConsumerProcurementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Order response = await consumerProcurementServiceClient.GetOrderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOrders</summary>
        public void ListOrdersRequestObject()
        {
            // Snippet: ListOrders(ListOrdersRequest, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = ConsumerProcurementServiceClient.Create();
            // Initialize request argument(s)
            ListOrdersRequest request = new ListOrdersRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListOrdersResponse, Order> response = consumerProcurementServiceClient.ListOrders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Order item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrdersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Order item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Order> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Order item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrdersAsync</summary>
        public async Task ListOrdersRequestObjectAsync()
        {
            // Snippet: ListOrdersAsync(ListOrdersRequest, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = await ConsumerProcurementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOrdersRequest request = new ListOrdersRequest
            {
                Parent = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOrdersResponse, Order> response = consumerProcurementServiceClient.ListOrdersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Order item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrdersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Order item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Order> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Order item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrders</summary>
        public void ListOrders()
        {
            // Snippet: ListOrders(string, string, int?, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = ConsumerProcurementServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListOrdersResponse, Order> response = consumerProcurementServiceClient.ListOrders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Order item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrdersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Order item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Order> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Order item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrdersAsync</summary>
        public async Task ListOrdersAsync()
        {
            // Snippet: ListOrdersAsync(string, string, int?, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = await ConsumerProcurementServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListOrdersResponse, Order> response = consumerProcurementServiceClient.ListOrdersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Order item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrdersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Order item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Order> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Order item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ModifyOrder</summary>
        public void ModifyOrderRequestObject()
        {
            // Snippet: ModifyOrder(ModifyOrderRequest, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = ConsumerProcurementServiceClient.Create();
            // Initialize request argument(s)
            ModifyOrderRequest request = new ModifyOrderRequest
            {
                Name = "",
                Etag = "",
                DisplayName = "",
                Modifications =
                {
                    new ModifyOrderRequest.Types.Modification(),
                },
            };
            // Make the request
            Operation<Order, ModifyOrderMetadata> response = consumerProcurementServiceClient.ModifyOrder(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, ModifyOrderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, ModifyOrderMetadata> retrievedResponse = consumerProcurementServiceClient.PollOnceModifyOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ModifyOrderAsync</summary>
        public async Task ModifyOrderRequestObjectAsync()
        {
            // Snippet: ModifyOrderAsync(ModifyOrderRequest, CallSettings)
            // Additional: ModifyOrderAsync(ModifyOrderRequest, CancellationToken)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = await ConsumerProcurementServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModifyOrderRequest request = new ModifyOrderRequest
            {
                Name = "",
                Etag = "",
                DisplayName = "",
                Modifications =
                {
                    new ModifyOrderRequest.Types.Modification(),
                },
            };
            // Make the request
            Operation<Order, ModifyOrderMetadata> response = await consumerProcurementServiceClient.ModifyOrderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, ModifyOrderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, ModifyOrderMetadata> retrievedResponse = await consumerProcurementServiceClient.PollOnceModifyOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelOrder</summary>
        public void CancelOrderRequestObject()
        {
            // Snippet: CancelOrder(CancelOrderRequest, CallSettings)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = ConsumerProcurementServiceClient.Create();
            // Initialize request argument(s)
            CancelOrderRequest request = new CancelOrderRequest
            {
                Name = "",
                Etag = "",
                CancellationPolicy = CancelOrderRequest.Types.CancellationPolicy.Unspecified,
            };
            // Make the request
            Operation<Order, CancelOrderMetadata> response = consumerProcurementServiceClient.CancelOrder(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, CancelOrderMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, CancelOrderMetadata> retrievedResponse = consumerProcurementServiceClient.PollOnceCancelOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelOrderAsync</summary>
        public async Task CancelOrderRequestObjectAsync()
        {
            // Snippet: CancelOrderAsync(CancelOrderRequest, CallSettings)
            // Additional: CancelOrderAsync(CancelOrderRequest, CancellationToken)
            // Create client
            ConsumerProcurementServiceClient consumerProcurementServiceClient = await ConsumerProcurementServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelOrderRequest request = new CancelOrderRequest
            {
                Name = "",
                Etag = "",
                CancellationPolicy = CancelOrderRequest.Types.CancellationPolicy.Unspecified,
            };
            // Make the request
            Operation<Order, CancelOrderMetadata> response = await consumerProcurementServiceClient.CancelOrderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, CancelOrderMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, CancelOrderMetadata> retrievedResponse = await consumerProcurementServiceClient.PollOnceCancelOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
