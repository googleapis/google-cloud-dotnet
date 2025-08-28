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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.GdcHardwareManagement.V1Alpha;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Google.Type;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGDCHardwareManagementClientSnippets
    {
        /// <summary>Snippet for ListOrders</summary>
        public void ListOrdersRequestObject()
        {
            // Snippet: ListOrders(ListOrdersRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ListOrdersRequest request = new ListOrdersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListOrdersResponse, Order> response = gDCHardwareManagementClient.ListOrders(request);

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
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListOrdersRequest request = new ListOrdersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOrdersResponse, Order> response = gDCHardwareManagementClient.ListOrdersAsync(request);

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
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOrdersResponse, Order> response = gDCHardwareManagementClient.ListOrders(parent);

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
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOrdersResponse, Order> response = gDCHardwareManagementClient.ListOrdersAsync(parent);

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
        public void ListOrdersResourceNames()
        {
            // Snippet: ListOrders(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOrdersResponse, Order> response = gDCHardwareManagementClient.ListOrders(parent);

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
        public async Task ListOrdersResourceNamesAsync()
        {
            // Snippet: ListOrdersAsync(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOrdersResponse, Order> response = gDCHardwareManagementClient.ListOrdersAsync(parent);

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

        /// <summary>Snippet for GetOrder</summary>
        public void GetOrderRequestObject()
        {
            // Snippet: GetOrder(GetOrderRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            GetOrderRequest request = new GetOrderRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
            };
            // Make the request
            Order response = gDCHardwareManagementClient.GetOrder(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrderAsync</summary>
        public async Task GetOrderRequestObjectAsync()
        {
            // Snippet: GetOrderAsync(GetOrderRequest, CallSettings)
            // Additional: GetOrderAsync(GetOrderRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetOrderRequest request = new GetOrderRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
            };
            // Make the request
            Order response = await gDCHardwareManagementClient.GetOrderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrder</summary>
        public void GetOrder()
        {
            // Snippet: GetOrder(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            Order response = gDCHardwareManagementClient.GetOrder(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrderAsync</summary>
        public async Task GetOrderAsync()
        {
            // Snippet: GetOrderAsync(string, CallSettings)
            // Additional: GetOrderAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            Order response = await gDCHardwareManagementClient.GetOrderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrder</summary>
        public void GetOrderResourceNames()
        {
            // Snippet: GetOrder(OrderName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Order response = gDCHardwareManagementClient.GetOrder(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrderAsync</summary>
        public async Task GetOrderResourceNamesAsync()
        {
            // Snippet: GetOrderAsync(OrderName, CallSettings)
            // Additional: GetOrderAsync(OrderName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Order response = await gDCHardwareManagementClient.GetOrderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateOrder</summary>
        public void CreateOrderRequestObject()
        {
            // Snippet: CreateOrder(CreateOrderRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CreateOrderRequest request = new CreateOrderRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderId = "",
                Order = new Order(),
                RequestId = "",
            };
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.CreateOrder(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrderAsync</summary>
        public async Task CreateOrderRequestObjectAsync()
        {
            // Snippet: CreateOrderAsync(CreateOrderRequest, CallSettings)
            // Additional: CreateOrderAsync(CreateOrderRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateOrderRequest request = new CreateOrderRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrderId = "",
                Order = new Order(),
                RequestId = "",
            };
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.CreateOrderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrder</summary>
        public void CreateOrder()
        {
            // Snippet: CreateOrder(string, Order, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Order order = new Order();
            string orderId = "";
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.CreateOrder(parent, order, orderId);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrderAsync</summary>
        public async Task CreateOrderAsync()
        {
            // Snippet: CreateOrderAsync(string, Order, string, CallSettings)
            // Additional: CreateOrderAsync(string, Order, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Order order = new Order();
            string orderId = "";
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.CreateOrderAsync(parent, order, orderId);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrder</summary>
        public void CreateOrderResourceNames()
        {
            // Snippet: CreateOrder(LocationName, Order, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Order order = new Order();
            string orderId = "";
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.CreateOrder(parent, order, orderId);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrderAsync</summary>
        public async Task CreateOrderResourceNamesAsync()
        {
            // Snippet: CreateOrderAsync(LocationName, Order, string, CallSettings)
            // Additional: CreateOrderAsync(LocationName, Order, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Order order = new Order();
            string orderId = "";
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.CreateOrderAsync(parent, order, orderId);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOrder</summary>
        public void UpdateOrderRequestObject()
        {
            // Snippet: UpdateOrder(UpdateOrderRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            UpdateOrderRequest request = new UpdateOrderRequest
            {
                UpdateMask = new FieldMask(),
                Order = new Order(),
                RequestId = "",
            };
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.UpdateOrder(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOrderAsync</summary>
        public async Task UpdateOrderRequestObjectAsync()
        {
            // Snippet: UpdateOrderAsync(UpdateOrderRequest, CallSettings)
            // Additional: UpdateOrderAsync(UpdateOrderRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateOrderRequest request = new UpdateOrderRequest
            {
                UpdateMask = new FieldMask(),
                Order = new Order(),
                RequestId = "",
            };
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.UpdateOrderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOrder</summary>
        public void UpdateOrder()
        {
            // Snippet: UpdateOrder(Order, FieldMask, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            Order order = new Order();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.UpdateOrder(order, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateOrderAsync</summary>
        public async Task UpdateOrderAsync()
        {
            // Snippet: UpdateOrderAsync(Order, FieldMask, CallSettings)
            // Additional: UpdateOrderAsync(Order, FieldMask, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            Order order = new Order();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.UpdateOrderAsync(order, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrder</summary>
        public void DeleteOrderRequestObject()
        {
            // Snippet: DeleteOrder(DeleteOrderRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            DeleteOrderRequest request = new DeleteOrderRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteOrder(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrderAsync</summary>
        public async Task DeleteOrderRequestObjectAsync()
        {
            // Snippet: DeleteOrderAsync(DeleteOrderRequest, CallSettings)
            // Additional: DeleteOrderAsync(DeleteOrderRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOrderRequest request = new DeleteOrderRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteOrderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrder</summary>
        public void DeleteOrder()
        {
            // Snippet: DeleteOrder(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteOrder(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrderAsync</summary>
        public async Task DeleteOrderAsync()
        {
            // Snippet: DeleteOrderAsync(string, CallSettings)
            // Additional: DeleteOrderAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteOrderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrder</summary>
        public void DeleteOrderResourceNames()
        {
            // Snippet: DeleteOrder(OrderName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteOrder(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrderAsync</summary>
        public async Task DeleteOrderResourceNamesAsync()
        {
            // Snippet: DeleteOrderAsync(OrderName, CallSettings)
            // Additional: DeleteOrderAsync(OrderName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteOrderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitOrder</summary>
        public void SubmitOrderRequestObject()
        {
            // Snippet: SubmitOrder(SubmitOrderRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            SubmitOrderRequest request = new SubmitOrderRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                RequestId = "",
                Type = SubmitOrderRequest.Types.Type.Unspecified,
            };
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.SubmitOrder(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceSubmitOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitOrderAsync</summary>
        public async Task SubmitOrderRequestObjectAsync()
        {
            // Snippet: SubmitOrderAsync(SubmitOrderRequest, CallSettings)
            // Additional: SubmitOrderAsync(SubmitOrderRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            SubmitOrderRequest request = new SubmitOrderRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                RequestId = "",
                Type = SubmitOrderRequest.Types.Type.Unspecified,
            };
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.SubmitOrderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceSubmitOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitOrder</summary>
        public void SubmitOrder()
        {
            // Snippet: SubmitOrder(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.SubmitOrder(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceSubmitOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitOrderAsync</summary>
        public async Task SubmitOrderAsync()
        {
            // Snippet: SubmitOrderAsync(string, CallSettings)
            // Additional: SubmitOrderAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.SubmitOrderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceSubmitOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitOrder</summary>
        public void SubmitOrderResourceNames()
        {
            // Snippet: SubmitOrder(OrderName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.SubmitOrder(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceSubmitOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitOrderAsync</summary>
        public async Task SubmitOrderResourceNamesAsync()
        {
            // Snippet: SubmitOrderAsync(OrderName, CallSettings)
            // Additional: SubmitOrderAsync(OrderName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.SubmitOrderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceSubmitOrderAsync(operationName);
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
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CancelOrderRequest request = new CancelOrderRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.CancelOrder(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCancelOrder(operationName);
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
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CancelOrderRequest request = new CancelOrderRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.CancelOrderAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCancelOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelOrder</summary>
        public void CancelOrder()
        {
            // Snippet: CancelOrder(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.CancelOrder(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCancelOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelOrderAsync</summary>
        public async Task CancelOrderAsync()
        {
            // Snippet: CancelOrderAsync(string, CallSettings)
            // Additional: CancelOrderAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.CancelOrderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCancelOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelOrder</summary>
        public void CancelOrderResourceNames()
        {
            // Snippet: CancelOrder(OrderName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.CancelOrder(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCancelOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelOrderAsync</summary>
        public async Task CancelOrderResourceNamesAsync()
        {
            // Snippet: CancelOrderAsync(OrderName, CallSettings)
            // Additional: CancelOrderAsync(OrderName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.CancelOrderAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCancelOrderAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSites</summary>
        public void ListSitesRequestObject()
        {
            // Snippet: ListSites(ListSitesRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ListSitesRequest request = new ListSitesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSitesResponse, Site> response = gDCHardwareManagementClient.ListSites(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Site item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSitesAsync</summary>
        public async Task ListSitesRequestObjectAsync()
        {
            // Snippet: ListSitesAsync(ListSitesRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListSitesRequest request = new ListSitesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSitesResponse, Site> response = gDCHardwareManagementClient.ListSitesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Site item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSites</summary>
        public void ListSites()
        {
            // Snippet: ListSites(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSitesResponse, Site> response = gDCHardwareManagementClient.ListSites(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Site item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSitesAsync</summary>
        public async Task ListSitesAsync()
        {
            // Snippet: ListSitesAsync(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSitesResponse, Site> response = gDCHardwareManagementClient.ListSitesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Site item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSites</summary>
        public void ListSitesResourceNames()
        {
            // Snippet: ListSites(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSitesResponse, Site> response = gDCHardwareManagementClient.ListSites(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Site item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSitesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSitesAsync</summary>
        public async Task ListSitesResourceNamesAsync()
        {
            // Snippet: ListSitesAsync(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSitesResponse, Site> response = gDCHardwareManagementClient.ListSitesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Site item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSitesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Site item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Site> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Site item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSite</summary>
        public void GetSiteRequestObject()
        {
            // Snippet: GetSite(GetSiteRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            GetSiteRequest request = new GetSiteRequest
            {
                SiteName = SiteName.FromProjectLocationSite("[PROJECT]", "[LOCATION]", "[SITE]"),
            };
            // Make the request
            Site response = gDCHardwareManagementClient.GetSite(request);
            // End snippet
        }

        /// <summary>Snippet for GetSiteAsync</summary>
        public async Task GetSiteRequestObjectAsync()
        {
            // Snippet: GetSiteAsync(GetSiteRequest, CallSettings)
            // Additional: GetSiteAsync(GetSiteRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetSiteRequest request = new GetSiteRequest
            {
                SiteName = SiteName.FromProjectLocationSite("[PROJECT]", "[LOCATION]", "[SITE]"),
            };
            // Make the request
            Site response = await gDCHardwareManagementClient.GetSiteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSite</summary>
        public void GetSite()
        {
            // Snippet: GetSite(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sites/[SITE]";
            // Make the request
            Site response = gDCHardwareManagementClient.GetSite(name);
            // End snippet
        }

        /// <summary>Snippet for GetSiteAsync</summary>
        public async Task GetSiteAsync()
        {
            // Snippet: GetSiteAsync(string, CallSettings)
            // Additional: GetSiteAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sites/[SITE]";
            // Make the request
            Site response = await gDCHardwareManagementClient.GetSiteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSite</summary>
        public void GetSiteResourceNames()
        {
            // Snippet: GetSite(SiteName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            SiteName name = SiteName.FromProjectLocationSite("[PROJECT]", "[LOCATION]", "[SITE]");
            // Make the request
            Site response = gDCHardwareManagementClient.GetSite(name);
            // End snippet
        }

        /// <summary>Snippet for GetSiteAsync</summary>
        public async Task GetSiteResourceNamesAsync()
        {
            // Snippet: GetSiteAsync(SiteName, CallSettings)
            // Additional: GetSiteAsync(SiteName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            SiteName name = SiteName.FromProjectLocationSite("[PROJECT]", "[LOCATION]", "[SITE]");
            // Make the request
            Site response = await gDCHardwareManagementClient.GetSiteAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSite</summary>
        public void CreateSiteRequestObject()
        {
            // Snippet: CreateSite(CreateSiteRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CreateSiteRequest request = new CreateSiteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SiteId = "",
                Site = new Site(),
                RequestId = "",
            };
            // Make the request
            Operation<Site, OperationMetadata> response = gDCHardwareManagementClient.CreateSite(request);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSiteAsync</summary>
        public async Task CreateSiteRequestObjectAsync()
        {
            // Snippet: CreateSiteAsync(CreateSiteRequest, CallSettings)
            // Additional: CreateSiteAsync(CreateSiteRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateSiteRequest request = new CreateSiteRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SiteId = "",
                Site = new Site(),
                RequestId = "",
            };
            // Make the request
            Operation<Site, OperationMetadata> response = await gDCHardwareManagementClient.CreateSiteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSite</summary>
        public void CreateSite()
        {
            // Snippet: CreateSite(string, Site, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Site site = new Site();
            string siteId = "";
            // Make the request
            Operation<Site, OperationMetadata> response = gDCHardwareManagementClient.CreateSite(parent, site, siteId);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSiteAsync</summary>
        public async Task CreateSiteAsync()
        {
            // Snippet: CreateSiteAsync(string, Site, string, CallSettings)
            // Additional: CreateSiteAsync(string, Site, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Site site = new Site();
            string siteId = "";
            // Make the request
            Operation<Site, OperationMetadata> response = await gDCHardwareManagementClient.CreateSiteAsync(parent, site, siteId);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSite</summary>
        public void CreateSiteResourceNames()
        {
            // Snippet: CreateSite(LocationName, Site, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Site site = new Site();
            string siteId = "";
            // Make the request
            Operation<Site, OperationMetadata> response = gDCHardwareManagementClient.CreateSite(parent, site, siteId);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSiteAsync</summary>
        public async Task CreateSiteResourceNamesAsync()
        {
            // Snippet: CreateSiteAsync(LocationName, Site, string, CallSettings)
            // Additional: CreateSiteAsync(LocationName, Site, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Site site = new Site();
            string siteId = "";
            // Make the request
            Operation<Site, OperationMetadata> response = await gDCHardwareManagementClient.CreateSiteAsync(parent, site, siteId);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSite</summary>
        public void UpdateSiteRequestObject()
        {
            // Snippet: UpdateSite(UpdateSiteRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            UpdateSiteRequest request = new UpdateSiteRequest
            {
                UpdateMask = new FieldMask(),
                Site = new Site(),
                RequestId = "",
            };
            // Make the request
            Operation<Site, OperationMetadata> response = gDCHardwareManagementClient.UpdateSite(request);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSiteAsync</summary>
        public async Task UpdateSiteRequestObjectAsync()
        {
            // Snippet: UpdateSiteAsync(UpdateSiteRequest, CallSettings)
            // Additional: UpdateSiteAsync(UpdateSiteRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSiteRequest request = new UpdateSiteRequest
            {
                UpdateMask = new FieldMask(),
                Site = new Site(),
                RequestId = "",
            };
            // Make the request
            Operation<Site, OperationMetadata> response = await gDCHardwareManagementClient.UpdateSiteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSite</summary>
        public void UpdateSite()
        {
            // Snippet: UpdateSite(Site, FieldMask, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            Site site = new Site();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Site, OperationMetadata> response = gDCHardwareManagementClient.UpdateSite(site, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSiteAsync</summary>
        public async Task UpdateSiteAsync()
        {
            // Snippet: UpdateSiteAsync(Site, FieldMask, CallSettings)
            // Additional: UpdateSiteAsync(Site, FieldMask, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            Site site = new Site();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Site, OperationMetadata> response = await gDCHardwareManagementClient.UpdateSiteAsync(site, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Site, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Site result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Site, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Site retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSite</summary>
        public void DeleteSiteRequestObject()
        {
            // Snippet: DeleteSite(DeleteSiteRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            DeleteSiteRequest request = new DeleteSiteRequest
            {
                SiteName = SiteName.FromProjectLocationSite("[PROJECT]", "[LOCATION]", "[SITE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteSite(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSiteAsync</summary>
        public async Task DeleteSiteRequestObjectAsync()
        {
            // Snippet: DeleteSiteAsync(DeleteSiteRequest, CallSettings)
            // Additional: DeleteSiteAsync(DeleteSiteRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSiteRequest request = new DeleteSiteRequest
            {
                SiteName = SiteName.FromProjectLocationSite("[PROJECT]", "[LOCATION]", "[SITE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteSiteAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSite</summary>
        public void DeleteSite()
        {
            // Snippet: DeleteSite(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sites/[SITE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteSite(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSiteAsync</summary>
        public async Task DeleteSiteAsync()
        {
            // Snippet: DeleteSiteAsync(string, CallSettings)
            // Additional: DeleteSiteAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sites/[SITE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteSiteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSite</summary>
        public void DeleteSiteResourceNames()
        {
            // Snippet: DeleteSite(SiteName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            SiteName name = SiteName.FromProjectLocationSite("[PROJECT]", "[LOCATION]", "[SITE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteSite(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteSite(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSiteAsync</summary>
        public async Task DeleteSiteResourceNamesAsync()
        {
            // Snippet: DeleteSiteAsync(SiteName, CallSettings)
            // Additional: DeleteSiteAsync(SiteName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            SiteName name = SiteName.FromProjectLocationSite("[PROJECT]", "[LOCATION]", "[SITE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteSiteAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteSiteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListHardwareGroups</summary>
        public void ListHardwareGroupsRequestObject()
        {
            // Snippet: ListHardwareGroups(ListHardwareGroupsRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ListHardwareGroupsRequest request = new ListHardwareGroupsRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListHardwareGroupsResponse, HardwareGroup> response = gDCHardwareManagementClient.ListHardwareGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HardwareGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHardwareGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HardwareGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HardwareGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HardwareGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardwareGroupsAsync</summary>
        public async Task ListHardwareGroupsRequestObjectAsync()
        {
            // Snippet: ListHardwareGroupsAsync(ListHardwareGroupsRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListHardwareGroupsRequest request = new ListHardwareGroupsRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListHardwareGroupsResponse, HardwareGroup> response = gDCHardwareManagementClient.ListHardwareGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HardwareGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHardwareGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HardwareGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HardwareGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HardwareGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardwareGroups</summary>
        public void ListHardwareGroups()
        {
            // Snippet: ListHardwareGroups(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            PagedEnumerable<ListHardwareGroupsResponse, HardwareGroup> response = gDCHardwareManagementClient.ListHardwareGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HardwareGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHardwareGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HardwareGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HardwareGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HardwareGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardwareGroupsAsync</summary>
        public async Task ListHardwareGroupsAsync()
        {
            // Snippet: ListHardwareGroupsAsync(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            PagedAsyncEnumerable<ListHardwareGroupsResponse, HardwareGroup> response = gDCHardwareManagementClient.ListHardwareGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HardwareGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHardwareGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HardwareGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HardwareGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HardwareGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardwareGroups</summary>
        public void ListHardwareGroupsResourceNames()
        {
            // Snippet: ListHardwareGroups(OrderName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            PagedEnumerable<ListHardwareGroupsResponse, HardwareGroup> response = gDCHardwareManagementClient.ListHardwareGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HardwareGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHardwareGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HardwareGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HardwareGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HardwareGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardwareGroupsAsync</summary>
        public async Task ListHardwareGroupsResourceNamesAsync()
        {
            // Snippet: ListHardwareGroupsAsync(OrderName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            PagedAsyncEnumerable<ListHardwareGroupsResponse, HardwareGroup> response = gDCHardwareManagementClient.ListHardwareGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HardwareGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHardwareGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HardwareGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HardwareGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HardwareGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetHardwareGroup</summary>
        public void GetHardwareGroupRequestObject()
        {
            // Snippet: GetHardwareGroup(GetHardwareGroupRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            GetHardwareGroupRequest request = new GetHardwareGroupRequest
            {
                HardwareGroupName = HardwareGroupName.FromProjectLocationOrderHardwareGroup("[PROJECT]", "[LOCATION]", "[ORDER]", "[HARDWARE_GROUP]"),
            };
            // Make the request
            HardwareGroup response = gDCHardwareManagementClient.GetHardwareGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetHardwareGroupAsync</summary>
        public async Task GetHardwareGroupRequestObjectAsync()
        {
            // Snippet: GetHardwareGroupAsync(GetHardwareGroupRequest, CallSettings)
            // Additional: GetHardwareGroupAsync(GetHardwareGroupRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetHardwareGroupRequest request = new GetHardwareGroupRequest
            {
                HardwareGroupName = HardwareGroupName.FromProjectLocationOrderHardwareGroup("[PROJECT]", "[LOCATION]", "[ORDER]", "[HARDWARE_GROUP]"),
            };
            // Make the request
            HardwareGroup response = await gDCHardwareManagementClient.GetHardwareGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHardwareGroup</summary>
        public void GetHardwareGroup()
        {
            // Snippet: GetHardwareGroup(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/hardwareGroups/[HARDWARE_GROUP]";
            // Make the request
            HardwareGroup response = gDCHardwareManagementClient.GetHardwareGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetHardwareGroupAsync</summary>
        public async Task GetHardwareGroupAsync()
        {
            // Snippet: GetHardwareGroupAsync(string, CallSettings)
            // Additional: GetHardwareGroupAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/hardwareGroups/[HARDWARE_GROUP]";
            // Make the request
            HardwareGroup response = await gDCHardwareManagementClient.GetHardwareGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHardwareGroup</summary>
        public void GetHardwareGroupResourceNames()
        {
            // Snippet: GetHardwareGroup(HardwareGroupName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            HardwareGroupName name = HardwareGroupName.FromProjectLocationOrderHardwareGroup("[PROJECT]", "[LOCATION]", "[ORDER]", "[HARDWARE_GROUP]");
            // Make the request
            HardwareGroup response = gDCHardwareManagementClient.GetHardwareGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetHardwareGroupAsync</summary>
        public async Task GetHardwareGroupResourceNamesAsync()
        {
            // Snippet: GetHardwareGroupAsync(HardwareGroupName, CallSettings)
            // Additional: GetHardwareGroupAsync(HardwareGroupName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            HardwareGroupName name = HardwareGroupName.FromProjectLocationOrderHardwareGroup("[PROJECT]", "[LOCATION]", "[ORDER]", "[HARDWARE_GROUP]");
            // Make the request
            HardwareGroup response = await gDCHardwareManagementClient.GetHardwareGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareGroup</summary>
        public void CreateHardwareGroupRequestObject()
        {
            // Snippet: CreateHardwareGroup(CreateHardwareGroupRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CreateHardwareGroupRequest request = new CreateHardwareGroupRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                HardwareGroupId = "",
                HardwareGroup = new HardwareGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = gDCHardwareManagementClient.CreateHardwareGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateHardwareGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareGroupAsync</summary>
        public async Task CreateHardwareGroupRequestObjectAsync()
        {
            // Snippet: CreateHardwareGroupAsync(CreateHardwareGroupRequest, CallSettings)
            // Additional: CreateHardwareGroupAsync(CreateHardwareGroupRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateHardwareGroupRequest request = new CreateHardwareGroupRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                HardwareGroupId = "",
                HardwareGroup = new HardwareGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = await gDCHardwareManagementClient.CreateHardwareGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateHardwareGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareGroup</summary>
        public void CreateHardwareGroup()
        {
            // Snippet: CreateHardwareGroup(string, HardwareGroup, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            HardwareGroup hardwareGroup = new HardwareGroup();
            string hardwareGroupId = "";
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = gDCHardwareManagementClient.CreateHardwareGroup(parent, hardwareGroup, hardwareGroupId);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateHardwareGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareGroupAsync</summary>
        public async Task CreateHardwareGroupAsync()
        {
            // Snippet: CreateHardwareGroupAsync(string, HardwareGroup, string, CallSettings)
            // Additional: CreateHardwareGroupAsync(string, HardwareGroup, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            HardwareGroup hardwareGroup = new HardwareGroup();
            string hardwareGroupId = "";
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = await gDCHardwareManagementClient.CreateHardwareGroupAsync(parent, hardwareGroup, hardwareGroupId);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateHardwareGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareGroup</summary>
        public void CreateHardwareGroupResourceNames()
        {
            // Snippet: CreateHardwareGroup(OrderName, HardwareGroup, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            HardwareGroup hardwareGroup = new HardwareGroup();
            string hardwareGroupId = "";
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = gDCHardwareManagementClient.CreateHardwareGroup(parent, hardwareGroup, hardwareGroupId);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateHardwareGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareGroupAsync</summary>
        public async Task CreateHardwareGroupResourceNamesAsync()
        {
            // Snippet: CreateHardwareGroupAsync(OrderName, HardwareGroup, string, CallSettings)
            // Additional: CreateHardwareGroupAsync(OrderName, HardwareGroup, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            HardwareGroup hardwareGroup = new HardwareGroup();
            string hardwareGroupId = "";
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = await gDCHardwareManagementClient.CreateHardwareGroupAsync(parent, hardwareGroup, hardwareGroupId);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateHardwareGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHardwareGroup</summary>
        public void UpdateHardwareGroupRequestObject()
        {
            // Snippet: UpdateHardwareGroup(UpdateHardwareGroupRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            UpdateHardwareGroupRequest request = new UpdateHardwareGroupRequest
            {
                UpdateMask = new FieldMask(),
                HardwareGroup = new HardwareGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = gDCHardwareManagementClient.UpdateHardwareGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateHardwareGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHardwareGroupAsync</summary>
        public async Task UpdateHardwareGroupRequestObjectAsync()
        {
            // Snippet: UpdateHardwareGroupAsync(UpdateHardwareGroupRequest, CallSettings)
            // Additional: UpdateHardwareGroupAsync(UpdateHardwareGroupRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHardwareGroupRequest request = new UpdateHardwareGroupRequest
            {
                UpdateMask = new FieldMask(),
                HardwareGroup = new HardwareGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = await gDCHardwareManagementClient.UpdateHardwareGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateHardwareGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHardwareGroup</summary>
        public void UpdateHardwareGroup()
        {
            // Snippet: UpdateHardwareGroup(HardwareGroup, FieldMask, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            HardwareGroup hardwareGroup = new HardwareGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = gDCHardwareManagementClient.UpdateHardwareGroup(hardwareGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateHardwareGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHardwareGroupAsync</summary>
        public async Task UpdateHardwareGroupAsync()
        {
            // Snippet: UpdateHardwareGroupAsync(HardwareGroup, FieldMask, CallSettings)
            // Additional: UpdateHardwareGroupAsync(HardwareGroup, FieldMask, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            HardwareGroup hardwareGroup = new HardwareGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<HardwareGroup, OperationMetadata> response = await gDCHardwareManagementClient.UpdateHardwareGroupAsync(hardwareGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<HardwareGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            HardwareGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<HardwareGroup, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateHardwareGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                HardwareGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareGroup</summary>
        public void DeleteHardwareGroupRequestObject()
        {
            // Snippet: DeleteHardwareGroup(DeleteHardwareGroupRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            DeleteHardwareGroupRequest request = new DeleteHardwareGroupRequest
            {
                HardwareGroupName = HardwareGroupName.FromProjectLocationOrderHardwareGroup("[PROJECT]", "[LOCATION]", "[ORDER]", "[HARDWARE_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteHardwareGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteHardwareGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareGroupAsync</summary>
        public async Task DeleteHardwareGroupRequestObjectAsync()
        {
            // Snippet: DeleteHardwareGroupAsync(DeleteHardwareGroupRequest, CallSettings)
            // Additional: DeleteHardwareGroupAsync(DeleteHardwareGroupRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHardwareGroupRequest request = new DeleteHardwareGroupRequest
            {
                HardwareGroupName = HardwareGroupName.FromProjectLocationOrderHardwareGroup("[PROJECT]", "[LOCATION]", "[ORDER]", "[HARDWARE_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteHardwareGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteHardwareGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareGroup</summary>
        public void DeleteHardwareGroup()
        {
            // Snippet: DeleteHardwareGroup(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/hardwareGroups/[HARDWARE_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteHardwareGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteHardwareGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareGroupAsync</summary>
        public async Task DeleteHardwareGroupAsync()
        {
            // Snippet: DeleteHardwareGroupAsync(string, CallSettings)
            // Additional: DeleteHardwareGroupAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/hardwareGroups/[HARDWARE_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteHardwareGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteHardwareGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareGroup</summary>
        public void DeleteHardwareGroupResourceNames()
        {
            // Snippet: DeleteHardwareGroup(HardwareGroupName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            HardwareGroupName name = HardwareGroupName.FromProjectLocationOrderHardwareGroup("[PROJECT]", "[LOCATION]", "[ORDER]", "[HARDWARE_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteHardwareGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteHardwareGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareGroupAsync</summary>
        public async Task DeleteHardwareGroupResourceNamesAsync()
        {
            // Snippet: DeleteHardwareGroupAsync(HardwareGroupName, CallSettings)
            // Additional: DeleteHardwareGroupAsync(HardwareGroupName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            HardwareGroupName name = HardwareGroupName.FromProjectLocationOrderHardwareGroup("[PROJECT]", "[LOCATION]", "[ORDER]", "[HARDWARE_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteHardwareGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteHardwareGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListHardware</summary>
        public void ListHardwareRequestObject()
        {
            // Snippet: ListHardware(ListHardwareRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ListHardwareRequest request = new ListHardwareRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListHardwareResponse, Hardware> response = gDCHardwareManagementClient.ListHardware(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hardware item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHardwareResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hardware item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hardware> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hardware item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardwareAsync</summary>
        public async Task ListHardwareRequestObjectAsync()
        {
            // Snippet: ListHardwareAsync(ListHardwareRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListHardwareRequest request = new ListHardwareRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListHardwareResponse, Hardware> response = gDCHardwareManagementClient.ListHardwareAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hardware item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHardwareResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hardware item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hardware> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hardware item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardware</summary>
        public void ListHardware()
        {
            // Snippet: ListHardware(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListHardwareResponse, Hardware> response = gDCHardwareManagementClient.ListHardware(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hardware item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHardwareResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hardware item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hardware> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hardware item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardwareAsync</summary>
        public async Task ListHardwareAsync()
        {
            // Snippet: ListHardwareAsync(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListHardwareResponse, Hardware> response = gDCHardwareManagementClient.ListHardwareAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hardware item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHardwareResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hardware item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hardware> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hardware item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardware</summary>
        public void ListHardwareResourceNames()
        {
            // Snippet: ListHardware(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListHardwareResponse, Hardware> response = gDCHardwareManagementClient.ListHardware(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Hardware item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHardwareResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hardware item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hardware> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hardware item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHardwareAsync</summary>
        public async Task ListHardwareResourceNamesAsync()
        {
            // Snippet: ListHardwareAsync(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListHardwareResponse, Hardware> response = gDCHardwareManagementClient.ListHardwareAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Hardware item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHardwareResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Hardware item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Hardware> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Hardware item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetHardware</summary>
        public void GetHardwareRequestObject()
        {
            // Snippet: GetHardware(GetHardwareRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            GetHardwareRequest request = new GetHardwareRequest
            {
                HardwareName = HardwareName.FromProjectLocationHardware("[PROJECT]", "[LOCATION]", "[HARDWARE]"),
            };
            // Make the request
            Hardware response = gDCHardwareManagementClient.GetHardware(request);
            // End snippet
        }

        /// <summary>Snippet for GetHardwareAsync</summary>
        public async Task GetHardwareRequestObjectAsync()
        {
            // Snippet: GetHardwareAsync(GetHardwareRequest, CallSettings)
            // Additional: GetHardwareAsync(GetHardwareRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetHardwareRequest request = new GetHardwareRequest
            {
                HardwareName = HardwareName.FromProjectLocationHardware("[PROJECT]", "[LOCATION]", "[HARDWARE]"),
            };
            // Make the request
            Hardware response = await gDCHardwareManagementClient.GetHardwareAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHardware</summary>
        public void GetHardware()
        {
            // Snippet: GetHardware(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hardware/[HARDWARE]";
            // Make the request
            Hardware response = gDCHardwareManagementClient.GetHardware(name);
            // End snippet
        }

        /// <summary>Snippet for GetHardwareAsync</summary>
        public async Task GetHardwareAsync()
        {
            // Snippet: GetHardwareAsync(string, CallSettings)
            // Additional: GetHardwareAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hardware/[HARDWARE]";
            // Make the request
            Hardware response = await gDCHardwareManagementClient.GetHardwareAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHardware</summary>
        public void GetHardwareResourceNames()
        {
            // Snippet: GetHardware(HardwareName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            HardwareName name = HardwareName.FromProjectLocationHardware("[PROJECT]", "[LOCATION]", "[HARDWARE]");
            // Make the request
            Hardware response = gDCHardwareManagementClient.GetHardware(name);
            // End snippet
        }

        /// <summary>Snippet for GetHardwareAsync</summary>
        public async Task GetHardwareResourceNamesAsync()
        {
            // Snippet: GetHardwareAsync(HardwareName, CallSettings)
            // Additional: GetHardwareAsync(HardwareName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            HardwareName name = HardwareName.FromProjectLocationHardware("[PROJECT]", "[LOCATION]", "[HARDWARE]");
            // Make the request
            Hardware response = await gDCHardwareManagementClient.GetHardwareAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateHardware</summary>
        public void CreateHardwareRequestObject()
        {
            // Snippet: CreateHardware(CreateHardwareRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CreateHardwareRequest request = new CreateHardwareRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HardwareId = "",
                Hardware = new Hardware(),
            };
            // Make the request
            Operation<Hardware, OperationMetadata> response = gDCHardwareManagementClient.CreateHardware(request);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareAsync</summary>
        public async Task CreateHardwareRequestObjectAsync()
        {
            // Snippet: CreateHardwareAsync(CreateHardwareRequest, CallSettings)
            // Additional: CreateHardwareAsync(CreateHardwareRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateHardwareRequest request = new CreateHardwareRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HardwareId = "",
                Hardware = new Hardware(),
            };
            // Make the request
            Operation<Hardware, OperationMetadata> response = await gDCHardwareManagementClient.CreateHardwareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateHardwareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardware</summary>
        public void CreateHardware()
        {
            // Snippet: CreateHardware(string, Hardware, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Hardware hardware = new Hardware();
            string hardwareId = "";
            // Make the request
            Operation<Hardware, OperationMetadata> response = gDCHardwareManagementClient.CreateHardware(parent, hardware, hardwareId);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareAsync</summary>
        public async Task CreateHardwareAsync()
        {
            // Snippet: CreateHardwareAsync(string, Hardware, string, CallSettings)
            // Additional: CreateHardwareAsync(string, Hardware, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Hardware hardware = new Hardware();
            string hardwareId = "";
            // Make the request
            Operation<Hardware, OperationMetadata> response = await gDCHardwareManagementClient.CreateHardwareAsync(parent, hardware, hardwareId);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateHardwareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardware</summary>
        public void CreateHardwareResourceNames()
        {
            // Snippet: CreateHardware(LocationName, Hardware, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Hardware hardware = new Hardware();
            string hardwareId = "";
            // Make the request
            Operation<Hardware, OperationMetadata> response = gDCHardwareManagementClient.CreateHardware(parent, hardware, hardwareId);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateHardwareAsync</summary>
        public async Task CreateHardwareResourceNamesAsync()
        {
            // Snippet: CreateHardwareAsync(LocationName, Hardware, string, CallSettings)
            // Additional: CreateHardwareAsync(LocationName, Hardware, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Hardware hardware = new Hardware();
            string hardwareId = "";
            // Make the request
            Operation<Hardware, OperationMetadata> response = await gDCHardwareManagementClient.CreateHardwareAsync(parent, hardware, hardwareId);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateHardwareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHardware</summary>
        public void UpdateHardwareRequestObject()
        {
            // Snippet: UpdateHardware(UpdateHardwareRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            UpdateHardwareRequest request = new UpdateHardwareRequest
            {
                UpdateMask = new FieldMask(),
                Hardware = new Hardware(),
                RequestId = "",
            };
            // Make the request
            Operation<Hardware, OperationMetadata> response = gDCHardwareManagementClient.UpdateHardware(request);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHardwareAsync</summary>
        public async Task UpdateHardwareRequestObjectAsync()
        {
            // Snippet: UpdateHardwareAsync(UpdateHardwareRequest, CallSettings)
            // Additional: UpdateHardwareAsync(UpdateHardwareRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHardwareRequest request = new UpdateHardwareRequest
            {
                UpdateMask = new FieldMask(),
                Hardware = new Hardware(),
                RequestId = "",
            };
            // Make the request
            Operation<Hardware, OperationMetadata> response = await gDCHardwareManagementClient.UpdateHardwareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateHardwareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHardware</summary>
        public void UpdateHardware()
        {
            // Snippet: UpdateHardware(Hardware, FieldMask, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            Hardware hardware = new Hardware();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Hardware, OperationMetadata> response = gDCHardwareManagementClient.UpdateHardware(hardware, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateHardwareAsync</summary>
        public async Task UpdateHardwareAsync()
        {
            // Snippet: UpdateHardwareAsync(Hardware, FieldMask, CallSettings)
            // Additional: UpdateHardwareAsync(Hardware, FieldMask, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            Hardware hardware = new Hardware();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Hardware, OperationMetadata> response = await gDCHardwareManagementClient.UpdateHardwareAsync(hardware, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateHardwareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardware</summary>
        public void DeleteHardwareRequestObject()
        {
            // Snippet: DeleteHardware(DeleteHardwareRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            DeleteHardwareRequest request = new DeleteHardwareRequest
            {
                HardwareName = HardwareName.FromProjectLocationHardware("[PROJECT]", "[LOCATION]", "[HARDWARE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteHardware(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareAsync</summary>
        public async Task DeleteHardwareRequestObjectAsync()
        {
            // Snippet: DeleteHardwareAsync(DeleteHardwareRequest, CallSettings)
            // Additional: DeleteHardwareAsync(DeleteHardwareRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteHardwareRequest request = new DeleteHardwareRequest
            {
                HardwareName = HardwareName.FromProjectLocationHardware("[PROJECT]", "[LOCATION]", "[HARDWARE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteHardwareAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteHardwareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardware</summary>
        public void DeleteHardware()
        {
            // Snippet: DeleteHardware(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hardware/[HARDWARE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteHardware(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareAsync</summary>
        public async Task DeleteHardwareAsync()
        {
            // Snippet: DeleteHardwareAsync(string, CallSettings)
            // Additional: DeleteHardwareAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hardware/[HARDWARE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteHardwareAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteHardwareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardware</summary>
        public void DeleteHardwareResourceNames()
        {
            // Snippet: DeleteHardware(HardwareName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            HardwareName name = HardwareName.FromProjectLocationHardware("[PROJECT]", "[LOCATION]", "[HARDWARE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteHardware(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteHardwareAsync</summary>
        public async Task DeleteHardwareResourceNamesAsync()
        {
            // Snippet: DeleteHardwareAsync(HardwareName, CallSettings)
            // Additional: DeleteHardwareAsync(HardwareName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            HardwareName name = HardwareName.FromProjectLocationHardware("[PROJECT]", "[LOCATION]", "[HARDWARE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteHardwareAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteHardwareAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListComments</summary>
        public void ListCommentsRequestObject()
        {
            // Snippet: ListComments(ListCommentsRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ListCommentsRequest request = new ListCommentsRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCommentsResponse, Comment> response = gDCHardwareManagementClient.ListComments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Comment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCommentsAsync</summary>
        public async Task ListCommentsRequestObjectAsync()
        {
            // Snippet: ListCommentsAsync(ListCommentsRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListCommentsRequest request = new ListCommentsRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCommentsResponse, Comment> response = gDCHardwareManagementClient.ListCommentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Comment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComments</summary>
        public void ListComments()
        {
            // Snippet: ListComments(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            PagedEnumerable<ListCommentsResponse, Comment> response = gDCHardwareManagementClient.ListComments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Comment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCommentsAsync</summary>
        public async Task ListCommentsAsync()
        {
            // Snippet: ListCommentsAsync(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            PagedAsyncEnumerable<ListCommentsResponse, Comment> response = gDCHardwareManagementClient.ListCommentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Comment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListComments</summary>
        public void ListCommentsResourceNames()
        {
            // Snippet: ListComments(OrderName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            PagedEnumerable<ListCommentsResponse, Comment> response = gDCHardwareManagementClient.ListComments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Comment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCommentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCommentsAsync</summary>
        public async Task ListCommentsResourceNamesAsync()
        {
            // Snippet: ListCommentsAsync(OrderName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            PagedAsyncEnumerable<ListCommentsResponse, Comment> response = gDCHardwareManagementClient.ListCommentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Comment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCommentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Comment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Comment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Comment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetComment</summary>
        public void GetCommentRequestObject()
        {
            // Snippet: GetComment(GetCommentRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            GetCommentRequest request = new GetCommentRequest
            {
                CommentName = CommentName.FromProjectLocationOrderComment("[PROJECT]", "[LOCATION]", "[ORDER]", "[COMMENT]"),
            };
            // Make the request
            Comment response = gDCHardwareManagementClient.GetComment(request);
            // End snippet
        }

        /// <summary>Snippet for GetCommentAsync</summary>
        public async Task GetCommentRequestObjectAsync()
        {
            // Snippet: GetCommentAsync(GetCommentRequest, CallSettings)
            // Additional: GetCommentAsync(GetCommentRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetCommentRequest request = new GetCommentRequest
            {
                CommentName = CommentName.FromProjectLocationOrderComment("[PROJECT]", "[LOCATION]", "[ORDER]", "[COMMENT]"),
            };
            // Make the request
            Comment response = await gDCHardwareManagementClient.GetCommentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetComment</summary>
        public void GetComment()
        {
            // Snippet: GetComment(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/comments/[COMMENT]";
            // Make the request
            Comment response = gDCHardwareManagementClient.GetComment(name);
            // End snippet
        }

        /// <summary>Snippet for GetCommentAsync</summary>
        public async Task GetCommentAsync()
        {
            // Snippet: GetCommentAsync(string, CallSettings)
            // Additional: GetCommentAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/comments/[COMMENT]";
            // Make the request
            Comment response = await gDCHardwareManagementClient.GetCommentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetComment</summary>
        public void GetCommentResourceNames()
        {
            // Snippet: GetComment(CommentName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CommentName name = CommentName.FromProjectLocationOrderComment("[PROJECT]", "[LOCATION]", "[ORDER]", "[COMMENT]");
            // Make the request
            Comment response = gDCHardwareManagementClient.GetComment(name);
            // End snippet
        }

        /// <summary>Snippet for GetCommentAsync</summary>
        public async Task GetCommentResourceNamesAsync()
        {
            // Snippet: GetCommentAsync(CommentName, CallSettings)
            // Additional: GetCommentAsync(CommentName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CommentName name = CommentName.FromProjectLocationOrderComment("[PROJECT]", "[LOCATION]", "[ORDER]", "[COMMENT]");
            // Make the request
            Comment response = await gDCHardwareManagementClient.GetCommentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateComment</summary>
        public void CreateCommentRequestObject()
        {
            // Snippet: CreateComment(CreateCommentRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CreateCommentRequest request = new CreateCommentRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                CommentId = "",
                Comment = new Comment(),
                RequestId = "",
            };
            // Make the request
            Operation<Comment, OperationMetadata> response = gDCHardwareManagementClient.CreateComment(request);

            // Poll until the returned long-running operation is complete
            Operation<Comment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Comment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Comment, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Comment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCommentAsync</summary>
        public async Task CreateCommentRequestObjectAsync()
        {
            // Snippet: CreateCommentAsync(CreateCommentRequest, CallSettings)
            // Additional: CreateCommentAsync(CreateCommentRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateCommentRequest request = new CreateCommentRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                CommentId = "",
                Comment = new Comment(),
                RequestId = "",
            };
            // Make the request
            Operation<Comment, OperationMetadata> response = await gDCHardwareManagementClient.CreateCommentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Comment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Comment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Comment, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Comment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateComment</summary>
        public void CreateComment()
        {
            // Snippet: CreateComment(string, Comment, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            Comment comment = new Comment();
            string commentId = "";
            // Make the request
            Operation<Comment, OperationMetadata> response = gDCHardwareManagementClient.CreateComment(parent, comment, commentId);

            // Poll until the returned long-running operation is complete
            Operation<Comment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Comment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Comment, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Comment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCommentAsync</summary>
        public async Task CreateCommentAsync()
        {
            // Snippet: CreateCommentAsync(string, Comment, string, CallSettings)
            // Additional: CreateCommentAsync(string, Comment, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            Comment comment = new Comment();
            string commentId = "";
            // Make the request
            Operation<Comment, OperationMetadata> response = await gDCHardwareManagementClient.CreateCommentAsync(parent, comment, commentId);

            // Poll until the returned long-running operation is complete
            Operation<Comment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Comment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Comment, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Comment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateComment</summary>
        public void CreateCommentResourceNames()
        {
            // Snippet: CreateComment(OrderName, Comment, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            Comment comment = new Comment();
            string commentId = "";
            // Make the request
            Operation<Comment, OperationMetadata> response = gDCHardwareManagementClient.CreateComment(parent, comment, commentId);

            // Poll until the returned long-running operation is complete
            Operation<Comment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Comment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Comment, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateComment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Comment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCommentAsync</summary>
        public async Task CreateCommentResourceNamesAsync()
        {
            // Snippet: CreateCommentAsync(OrderName, Comment, string, CallSettings)
            // Additional: CreateCommentAsync(OrderName, Comment, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            Comment comment = new Comment();
            string commentId = "";
            // Make the request
            Operation<Comment, OperationMetadata> response = await gDCHardwareManagementClient.CreateCommentAsync(parent, comment, commentId);

            // Poll until the returned long-running operation is complete
            Operation<Comment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Comment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Comment, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateCommentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Comment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RecordActionOnComment</summary>
        public void RecordActionOnCommentRequestObject()
        {
            // Snippet: RecordActionOnComment(RecordActionOnCommentRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            RecordActionOnCommentRequest request = new RecordActionOnCommentRequest
            {
                CommentName = CommentName.FromProjectLocationOrderComment("[PROJECT]", "[LOCATION]", "[ORDER]", "[COMMENT]"),
                ActionType = RecordActionOnCommentRequest.Types.ActionType.Unspecified,
            };
            // Make the request
            Comment response = gDCHardwareManagementClient.RecordActionOnComment(request);
            // End snippet
        }

        /// <summary>Snippet for RecordActionOnCommentAsync</summary>
        public async Task RecordActionOnCommentRequestObjectAsync()
        {
            // Snippet: RecordActionOnCommentAsync(RecordActionOnCommentRequest, CallSettings)
            // Additional: RecordActionOnCommentAsync(RecordActionOnCommentRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            RecordActionOnCommentRequest request = new RecordActionOnCommentRequest
            {
                CommentName = CommentName.FromProjectLocationOrderComment("[PROJECT]", "[LOCATION]", "[ORDER]", "[COMMENT]"),
                ActionType = RecordActionOnCommentRequest.Types.ActionType.Unspecified,
            };
            // Make the request
            Comment response = await gDCHardwareManagementClient.RecordActionOnCommentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RecordActionOnComment</summary>
        public void RecordActionOnComment()
        {
            // Snippet: RecordActionOnComment(string, RecordActionOnCommentRequest.Types.ActionType, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/comments/[COMMENT]";
            RecordActionOnCommentRequest.Types.ActionType actionType = RecordActionOnCommentRequest.Types.ActionType.Unspecified;
            // Make the request
            Comment response = gDCHardwareManagementClient.RecordActionOnComment(name, actionType);
            // End snippet
        }

        /// <summary>Snippet for RecordActionOnCommentAsync</summary>
        public async Task RecordActionOnCommentAsync()
        {
            // Snippet: RecordActionOnCommentAsync(string, RecordActionOnCommentRequest.Types.ActionType, CallSettings)
            // Additional: RecordActionOnCommentAsync(string, RecordActionOnCommentRequest.Types.ActionType, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/comments/[COMMENT]";
            RecordActionOnCommentRequest.Types.ActionType actionType = RecordActionOnCommentRequest.Types.ActionType.Unspecified;
            // Make the request
            Comment response = await gDCHardwareManagementClient.RecordActionOnCommentAsync(name, actionType);
            // End snippet
        }

        /// <summary>Snippet for RecordActionOnComment</summary>
        public void RecordActionOnCommentResourceNames()
        {
            // Snippet: RecordActionOnComment(CommentName, RecordActionOnCommentRequest.Types.ActionType, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CommentName name = CommentName.FromProjectLocationOrderComment("[PROJECT]", "[LOCATION]", "[ORDER]", "[COMMENT]");
            RecordActionOnCommentRequest.Types.ActionType actionType = RecordActionOnCommentRequest.Types.ActionType.Unspecified;
            // Make the request
            Comment response = gDCHardwareManagementClient.RecordActionOnComment(name, actionType);
            // End snippet
        }

        /// <summary>Snippet for RecordActionOnCommentAsync</summary>
        public async Task RecordActionOnCommentResourceNamesAsync()
        {
            // Snippet: RecordActionOnCommentAsync(CommentName, RecordActionOnCommentRequest.Types.ActionType, CallSettings)
            // Additional: RecordActionOnCommentAsync(CommentName, RecordActionOnCommentRequest.Types.ActionType, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CommentName name = CommentName.FromProjectLocationOrderComment("[PROJECT]", "[LOCATION]", "[ORDER]", "[COMMENT]");
            RecordActionOnCommentRequest.Types.ActionType actionType = RecordActionOnCommentRequest.Types.ActionType.Unspecified;
            // Make the request
            Comment response = await gDCHardwareManagementClient.RecordActionOnCommentAsync(name, actionType);
            // End snippet
        }

        /// <summary>Snippet for ListChangeLogEntries</summary>
        public void ListChangeLogEntriesRequestObject()
        {
            // Snippet: ListChangeLogEntries(ListChangeLogEntriesRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ListChangeLogEntriesRequest request = new ListChangeLogEntriesRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> response = gDCHardwareManagementClient.ListChangeLogEntries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChangeLogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangeLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeLogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeLogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeLogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeLogEntriesAsync</summary>
        public async Task ListChangeLogEntriesRequestObjectAsync()
        {
            // Snippet: ListChangeLogEntriesAsync(ListChangeLogEntriesRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListChangeLogEntriesRequest request = new ListChangeLogEntriesRequest
            {
                ParentAsOrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> response = gDCHardwareManagementClient.ListChangeLogEntriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChangeLogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChangeLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeLogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeLogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeLogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeLogEntries</summary>
        public void ListChangeLogEntries()
        {
            // Snippet: ListChangeLogEntries(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            PagedEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> response = gDCHardwareManagementClient.ListChangeLogEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChangeLogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangeLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeLogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeLogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeLogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeLogEntriesAsync</summary>
        public async Task ListChangeLogEntriesAsync()
        {
            // Snippet: ListChangeLogEntriesAsync(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            // Make the request
            PagedAsyncEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> response = gDCHardwareManagementClient.ListChangeLogEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChangeLogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChangeLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeLogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeLogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeLogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeLogEntries</summary>
        public void ListChangeLogEntriesResourceNames()
        {
            // Snippet: ListChangeLogEntries(OrderName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            PagedEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> response = gDCHardwareManagementClient.ListChangeLogEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChangeLogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangeLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeLogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeLogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeLogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeLogEntriesAsync</summary>
        public async Task ListChangeLogEntriesResourceNamesAsync()
        {
            // Snippet: ListChangeLogEntriesAsync(OrderName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName parent = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            PagedAsyncEnumerable<ListChangeLogEntriesResponse, ChangeLogEntry> response = gDCHardwareManagementClient.ListChangeLogEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChangeLogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChangeLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeLogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeLogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeLogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetChangeLogEntry</summary>
        public void GetChangeLogEntryRequestObject()
        {
            // Snippet: GetChangeLogEntry(GetChangeLogEntryRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            GetChangeLogEntryRequest request = new GetChangeLogEntryRequest
            {
                ChangeLogEntryName = ChangeLogEntryName.FromProjectLocationOrderChangeLogEntry("[PROJECT]", "[LOCATION]", "[ORDER]", "[CHANGE_LOG_ENTRY]"),
            };
            // Make the request
            ChangeLogEntry response = gDCHardwareManagementClient.GetChangeLogEntry(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangeLogEntryAsync</summary>
        public async Task GetChangeLogEntryRequestObjectAsync()
        {
            // Snippet: GetChangeLogEntryAsync(GetChangeLogEntryRequest, CallSettings)
            // Additional: GetChangeLogEntryAsync(GetChangeLogEntryRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetChangeLogEntryRequest request = new GetChangeLogEntryRequest
            {
                ChangeLogEntryName = ChangeLogEntryName.FromProjectLocationOrderChangeLogEntry("[PROJECT]", "[LOCATION]", "[ORDER]", "[CHANGE_LOG_ENTRY]"),
            };
            // Make the request
            ChangeLogEntry response = await gDCHardwareManagementClient.GetChangeLogEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangeLogEntry</summary>
        public void GetChangeLogEntry()
        {
            // Snippet: GetChangeLogEntry(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/changeLogEntries/[CHANGE_LOG_ENTRY]";
            // Make the request
            ChangeLogEntry response = gDCHardwareManagementClient.GetChangeLogEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangeLogEntryAsync</summary>
        public async Task GetChangeLogEntryAsync()
        {
            // Snippet: GetChangeLogEntryAsync(string, CallSettings)
            // Additional: GetChangeLogEntryAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]/changeLogEntries/[CHANGE_LOG_ENTRY]";
            // Make the request
            ChangeLogEntry response = await gDCHardwareManagementClient.GetChangeLogEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangeLogEntry</summary>
        public void GetChangeLogEntryResourceNames()
        {
            // Snippet: GetChangeLogEntry(ChangeLogEntryName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ChangeLogEntryName name = ChangeLogEntryName.FromProjectLocationOrderChangeLogEntry("[PROJECT]", "[LOCATION]", "[ORDER]", "[CHANGE_LOG_ENTRY]");
            // Make the request
            ChangeLogEntry response = gDCHardwareManagementClient.GetChangeLogEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangeLogEntryAsync</summary>
        public async Task GetChangeLogEntryResourceNamesAsync()
        {
            // Snippet: GetChangeLogEntryAsync(ChangeLogEntryName, CallSettings)
            // Additional: GetChangeLogEntryAsync(ChangeLogEntryName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ChangeLogEntryName name = ChangeLogEntryName.FromProjectLocationOrderChangeLogEntry("[PROJECT]", "[LOCATION]", "[ORDER]", "[CHANGE_LOG_ENTRY]");
            // Make the request
            ChangeLogEntry response = await gDCHardwareManagementClient.GetChangeLogEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkusRequestObject()
        {
            // Snippet: ListSkus(ListSkusRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = gDCHardwareManagementClient.ListSkus(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusRequestObjectAsync()
        {
            // Snippet: ListSkusAsync(ListSkusRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = gDCHardwareManagementClient.ListSkusAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Sku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkus()
        {
            // Snippet: ListSkus(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = gDCHardwareManagementClient.ListSkus(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusAsync()
        {
            // Snippet: ListSkusAsync(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = gDCHardwareManagementClient.ListSkusAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Sku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkus</summary>
        public void ListSkusResourceNames()
        {
            // Snippet: ListSkus(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSkusResponse, Sku> response = gDCHardwareManagementClient.ListSkus(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Sku item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSkusResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSkusAsync</summary>
        public async Task ListSkusResourceNamesAsync()
        {
            // Snippet: ListSkusAsync(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSkusResponse, Sku> response = gDCHardwareManagementClient.ListSkusAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Sku item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSkusResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Sku item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Sku> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Sku item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSku</summary>
        public void GetSkuRequestObject()
        {
            // Snippet: GetSku(GetSkuRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            GetSkuRequest request = new GetSkuRequest
            {
                SkuName = SkuName.FromProjectLocationSku("[PROJECT]", "[LOCATION]", "[SKU]"),
            };
            // Make the request
            Sku response = gDCHardwareManagementClient.GetSku(request);
            // End snippet
        }

        /// <summary>Snippet for GetSkuAsync</summary>
        public async Task GetSkuRequestObjectAsync()
        {
            // Snippet: GetSkuAsync(GetSkuRequest, CallSettings)
            // Additional: GetSkuAsync(GetSkuRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetSkuRequest request = new GetSkuRequest
            {
                SkuName = SkuName.FromProjectLocationSku("[PROJECT]", "[LOCATION]", "[SKU]"),
            };
            // Make the request
            Sku response = await gDCHardwareManagementClient.GetSkuAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSku</summary>
        public void GetSku()
        {
            // Snippet: GetSku(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skus/[SKU]";
            // Make the request
            Sku response = gDCHardwareManagementClient.GetSku(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkuAsync</summary>
        public async Task GetSkuAsync()
        {
            // Snippet: GetSkuAsync(string, CallSettings)
            // Additional: GetSkuAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/skus/[SKU]";
            // Make the request
            Sku response = await gDCHardwareManagementClient.GetSkuAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSku</summary>
        public void GetSkuResourceNames()
        {
            // Snippet: GetSku(SkuName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            SkuName name = SkuName.FromProjectLocationSku("[PROJECT]", "[LOCATION]", "[SKU]");
            // Make the request
            Sku response = gDCHardwareManagementClient.GetSku(name);
            // End snippet
        }

        /// <summary>Snippet for GetSkuAsync</summary>
        public async Task GetSkuResourceNamesAsync()
        {
            // Snippet: GetSkuAsync(SkuName, CallSettings)
            // Additional: GetSkuAsync(SkuName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            SkuName name = SkuName.FromProjectLocationSku("[PROJECT]", "[LOCATION]", "[SKU]");
            // Make the request
            Sku response = await gDCHardwareManagementClient.GetSkuAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZonesRequestObject()
        {
            // Snippet: ListZones(ListZonesRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ListZonesRequest request = new ListZonesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListZonesResponse, Zone> response = gDCHardwareManagementClient.ListZones(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesRequestObjectAsync()
        {
            // Snippet: ListZonesAsync(ListZonesRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListZonesRequest request = new ListZonesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = gDCHardwareManagementClient.ListZonesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZones()
        {
            // Snippet: ListZones(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListZonesResponse, Zone> response = gDCHardwareManagementClient.ListZones(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesAsync()
        {
            // Snippet: ListZonesAsync(string, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = gDCHardwareManagementClient.ListZonesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZonesResourceNames()
        {
            // Snippet: ListZones(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListZonesResponse, Zone> response = gDCHardwareManagementClient.ListZones(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesResourceNamesAsync()
        {
            // Snippet: ListZonesAsync(LocationName, string, int?, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = gDCHardwareManagementClient.ListZonesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZoneRequestObject()
        {
            // Snippet: GetZone(GetZoneRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
            };
            // Make the request
            Zone response = gDCHardwareManagementClient.GetZone(request);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneRequestObjectAsync()
        {
            // Snippet: GetZoneAsync(GetZoneRequest, CallSettings)
            // Additional: GetZoneAsync(GetZoneRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
            };
            // Make the request
            Zone response = await gDCHardwareManagementClient.GetZoneAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZone()
        {
            // Snippet: GetZone(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            Zone response = gDCHardwareManagementClient.GetZone(name);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneAsync()
        {
            // Snippet: GetZoneAsync(string, CallSettings)
            // Additional: GetZoneAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            Zone response = await gDCHardwareManagementClient.GetZoneAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZoneResourceNames()
        {
            // Snippet: GetZone(ZoneName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            Zone response = gDCHardwareManagementClient.GetZone(name);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneResourceNamesAsync()
        {
            // Snippet: GetZoneAsync(ZoneName, CallSettings)
            // Additional: GetZoneAsync(ZoneName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            Zone response = await gDCHardwareManagementClient.GetZoneAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateZone</summary>
        public void CreateZoneRequestObject()
        {
            // Snippet: CreateZone(CreateZoneRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            CreateZoneRequest request = new CreateZoneRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ZoneId = "",
                Zone = new Zone(),
                RequestId = "",
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = gDCHardwareManagementClient.CreateZone(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneRequestObjectAsync()
        {
            // Snippet: CreateZoneAsync(CreateZoneRequest, CallSettings)
            // Additional: CreateZoneAsync(CreateZoneRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateZoneRequest request = new CreateZoneRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ZoneId = "",
                Zone = new Zone(),
                RequestId = "",
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.CreateZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZone</summary>
        public void CreateZone()
        {
            // Snippet: CreateZone(string, Zone, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Zone zone = new Zone();
            string zoneId = "";
            // Make the request
            Operation<Zone, OperationMetadata> response = gDCHardwareManagementClient.CreateZone(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneAsync()
        {
            // Snippet: CreateZoneAsync(string, Zone, string, CallSettings)
            // Additional: CreateZoneAsync(string, Zone, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Zone zone = new Zone();
            string zoneId = "";
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.CreateZoneAsync(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZone</summary>
        public void CreateZoneResourceNames()
        {
            // Snippet: CreateZone(LocationName, Zone, string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Zone zone = new Zone();
            string zoneId = "";
            // Make the request
            Operation<Zone, OperationMetadata> response = gDCHardwareManagementClient.CreateZone(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneResourceNamesAsync()
        {
            // Snippet: CreateZoneAsync(LocationName, Zone, string, CallSettings)
            // Additional: CreateZoneAsync(LocationName, Zone, string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Zone zone = new Zone();
            string zoneId = "";
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.CreateZoneAsync(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZone</summary>
        public void UpdateZoneRequestObject()
        {
            // Snippet: UpdateZone(UpdateZoneRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            UpdateZoneRequest request = new UpdateZoneRequest
            {
                UpdateMask = new FieldMask(),
                Zone = new Zone(),
                RequestId = "",
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = gDCHardwareManagementClient.UpdateZone(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZoneAsync</summary>
        public async Task UpdateZoneRequestObjectAsync()
        {
            // Snippet: UpdateZoneAsync(UpdateZoneRequest, CallSettings)
            // Additional: UpdateZoneAsync(UpdateZoneRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            UpdateZoneRequest request = new UpdateZoneRequest
            {
                UpdateMask = new FieldMask(),
                Zone = new Zone(),
                RequestId = "",
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.UpdateZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZone</summary>
        public void UpdateZone()
        {
            // Snippet: UpdateZone(Zone, FieldMask, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            Zone zone = new Zone();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Zone, OperationMetadata> response = gDCHardwareManagementClient.UpdateZone(zone, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceUpdateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZoneAsync</summary>
        public async Task UpdateZoneAsync()
        {
            // Snippet: UpdateZoneAsync(Zone, FieldMask, CallSettings)
            // Additional: UpdateZoneAsync(Zone, FieldMask, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            Zone zone = new Zone();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.UpdateZoneAsync(zone, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceUpdateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZone</summary>
        public void DeleteZoneRequestObject()
        {
            // Snippet: DeleteZone(DeleteZoneRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            DeleteZoneRequest request = new DeleteZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteZone(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZoneAsync</summary>
        public async Task DeleteZoneRequestObjectAsync()
        {
            // Snippet: DeleteZoneAsync(DeleteZoneRequest, CallSettings)
            // Additional: DeleteZoneAsync(DeleteZoneRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteZoneRequest request = new DeleteZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZone</summary>
        public void DeleteZone()
        {
            // Snippet: DeleteZone(string, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteZone(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZoneAsync</summary>
        public async Task DeleteZoneAsync()
        {
            // Snippet: DeleteZoneAsync(string, CallSettings)
            // Additional: DeleteZoneAsync(string, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteZoneAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZone</summary>
        public void DeleteZoneResourceNames()
        {
            // Snippet: DeleteZone(ZoneName, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gDCHardwareManagementClient.DeleteZone(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceDeleteZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZoneAsync</summary>
        public async Task DeleteZoneResourceNamesAsync()
        {
            // Snippet: DeleteZoneAsync(ZoneName, CallSettings)
            // Additional: DeleteZoneAsync(ZoneName, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gDCHardwareManagementClient.DeleteZoneAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceDeleteZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SignalZoneState</summary>
        public void SignalZoneStateRequestObject()
        {
            // Snippet: SignalZoneState(SignalZoneStateRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            SignalZoneStateRequest request = new SignalZoneStateRequest
            {
                ZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                RequestId = "",
                StateSignal = SignalZoneStateRequest.Types.StateSignal.Unspecified,
                ProvisioningStateSignal = SignalZoneStateRequest.Types.ProvisioningStateSignal.Unspecified,
                Step = "",
                Details = "",
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = gDCHardwareManagementClient.SignalZoneState(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceSignalZoneState(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SignalZoneStateAsync</summary>
        public async Task SignalZoneStateRequestObjectAsync()
        {
            // Snippet: SignalZoneStateAsync(SignalZoneStateRequest, CallSettings)
            // Additional: SignalZoneStateAsync(SignalZoneStateRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            SignalZoneStateRequest request = new SignalZoneStateRequest
            {
                ZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                RequestId = "",
                StateSignal = SignalZoneStateRequest.Types.StateSignal.Unspecified,
                ProvisioningStateSignal = SignalZoneStateRequest.Types.ProvisioningStateSignal.Unspecified,
                Step = "",
                Details = "",
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.SignalZoneStateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceSignalZoneStateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SignalZoneState</summary>
        public void SignalZoneState()
        {
            // Snippet: SignalZoneState(string, SignalZoneStateRequest.Types.StateSignal, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            SignalZoneStateRequest.Types.StateSignal stateSignal = SignalZoneStateRequest.Types.StateSignal.Unspecified;
            // Make the request
            Operation<Zone, OperationMetadata> response = gDCHardwareManagementClient.SignalZoneState(name, stateSignal);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceSignalZoneState(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SignalZoneStateAsync</summary>
        public async Task SignalZoneStateAsync()
        {
            // Snippet: SignalZoneStateAsync(string, SignalZoneStateRequest.Types.StateSignal, CallSettings)
            // Additional: SignalZoneStateAsync(string, SignalZoneStateRequest.Types.StateSignal, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            SignalZoneStateRequest.Types.StateSignal stateSignal = SignalZoneStateRequest.Types.StateSignal.Unspecified;
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.SignalZoneStateAsync(name, stateSignal);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceSignalZoneStateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SignalZoneState</summary>
        public void SignalZoneStateResourceNames()
        {
            // Snippet: SignalZoneState(ZoneName, SignalZoneStateRequest.Types.StateSignal, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            SignalZoneStateRequest.Types.StateSignal stateSignal = SignalZoneStateRequest.Types.StateSignal.Unspecified;
            // Make the request
            Operation<Zone, OperationMetadata> response = gDCHardwareManagementClient.SignalZoneState(name, stateSignal);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceSignalZoneState(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SignalZoneStateAsync</summary>
        public async Task SignalZoneStateResourceNamesAsync()
        {
            // Snippet: SignalZoneStateAsync(ZoneName, SignalZoneStateRequest.Types.StateSignal, CallSettings)
            // Additional: SignalZoneStateAsync(ZoneName, SignalZoneStateRequest.Types.StateSignal, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            SignalZoneStateRequest.Types.StateSignal stateSignal = SignalZoneStateRequest.Types.StateSignal.Unspecified;
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.SignalZoneStateAsync(name, stateSignal);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceSignalZoneStateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RequestOrderDateChange</summary>
        public void RequestOrderDateChangeRequestObject()
        {
            // Snippet: RequestOrderDateChange(RequestOrderDateChangeRequest, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            RequestOrderDateChangeRequest request = new RequestOrderDateChangeRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                RequestedDate = new Date(),
            };
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.RequestOrderDateChange(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceRequestOrderDateChange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RequestOrderDateChangeAsync</summary>
        public async Task RequestOrderDateChangeRequestObjectAsync()
        {
            // Snippet: RequestOrderDateChangeAsync(RequestOrderDateChangeRequest, CallSettings)
            // Additional: RequestOrderDateChangeAsync(RequestOrderDateChangeRequest, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            RequestOrderDateChangeRequest request = new RequestOrderDateChangeRequest
            {
                OrderName = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]"),
                RequestedDate = new Date(),
            };
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.RequestOrderDateChangeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceRequestOrderDateChangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RequestOrderDateChange</summary>
        public void RequestOrderDateChange()
        {
            // Snippet: RequestOrderDateChange(string, Date, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            Date requestedDate = new Date();
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.RequestOrderDateChange(name, requestedDate);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceRequestOrderDateChange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RequestOrderDateChangeAsync</summary>
        public async Task RequestOrderDateChangeAsync()
        {
            // Snippet: RequestOrderDateChangeAsync(string, Date, CallSettings)
            // Additional: RequestOrderDateChangeAsync(string, Date, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            Date requestedDate = new Date();
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.RequestOrderDateChangeAsync(name, requestedDate);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceRequestOrderDateChangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RequestOrderDateChange</summary>
        public void RequestOrderDateChangeResourceNames()
        {
            // Snippet: RequestOrderDateChange(OrderName, Date, CallSettings)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            Date requestedDate = new Date();
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.RequestOrderDateChange(name, requestedDate);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceRequestOrderDateChange(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RequestOrderDateChangeAsync</summary>
        public async Task RequestOrderDateChangeResourceNamesAsync()
        {
            // Snippet: RequestOrderDateChangeAsync(OrderName, Date, CallSettings)
            // Additional: RequestOrderDateChangeAsync(OrderName, Date, CancellationToken)
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            Date requestedDate = new Date();
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.RequestOrderDateChangeAsync(name, requestedDate);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceRequestOrderDateChangeAsync(operationName);
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
