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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOrderServiceClientSnippets
    {
        /// <summary>Snippet for GetOrder</summary>
        public void GetOrderRequestObject()
        {
            // Snippet: GetOrder(GetOrderRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            GetOrderRequest request = new GetOrderRequest
            {
                OrderName = OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            Order response = orderServiceClient.GetOrder(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrderAsync</summary>
        public async Task GetOrderRequestObjectAsync()
        {
            // Snippet: GetOrderAsync(GetOrderRequest, CallSettings)
            // Additional: GetOrderAsync(GetOrderRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOrderRequest request = new GetOrderRequest
            {
                OrderName = OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            Order response = await orderServiceClient.GetOrderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrder</summary>
        public void GetOrder()
        {
            // Snippet: GetOrder(string, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/orders/[ORDER]";
            // Make the request
            Order response = orderServiceClient.GetOrder(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrderAsync</summary>
        public async Task GetOrderAsync()
        {
            // Snippet: GetOrderAsync(string, CallSettings)
            // Additional: GetOrderAsync(string, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/orders/[ORDER]";
            // Make the request
            Order response = await orderServiceClient.GetOrderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrder</summary>
        public void GetOrderResourceNames()
        {
            // Snippet: GetOrder(OrderName, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            OrderName name = OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]");
            // Make the request
            Order response = orderServiceClient.GetOrder(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrderAsync</summary>
        public async Task GetOrderResourceNamesAsync()
        {
            // Snippet: GetOrderAsync(OrderName, CallSettings)
            // Additional: GetOrderAsync(OrderName, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrderName name = OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]");
            // Make the request
            Order response = await orderServiceClient.GetOrderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOrders</summary>
        public void ListOrdersRequestObject()
        {
            // Snippet: ListOrders(ListOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            ListOrdersRequest request = new ListOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListOrdersResponse, Order> response = orderServiceClient.ListOrders(request);

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
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOrdersRequest request = new ListOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListOrdersResponse, Order> response = orderServiceClient.ListOrdersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Order item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListOrdersResponse page in response.AsRawResponses())
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
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListOrdersResponse, Order> response = orderServiceClient.ListOrders(parent);

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
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListOrdersResponse, Order> response = orderServiceClient.ListOrdersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Order item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListOrdersResponse page in response.AsRawResponses())
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
            // Snippet: ListOrders(NetworkName, string, int?, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListOrdersResponse, Order> response = orderServiceClient.ListOrders(parent);

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
            // Snippet: ListOrdersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListOrdersResponse, Order> response = orderServiceClient.ListOrdersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Order item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListOrdersResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for BatchCreateOrders</summary>
        public void BatchCreateOrdersRequestObject()
        {
            // Snippet: BatchCreateOrders(BatchCreateOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateOrdersRequest request = new BatchCreateOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateOrderRequest(),
                },
            };
            // Make the request
            BatchCreateOrdersResponse response = orderServiceClient.BatchCreateOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOrdersAsync</summary>
        public async Task BatchCreateOrdersRequestObjectAsync()
        {
            // Snippet: BatchCreateOrdersAsync(BatchCreateOrdersRequest, CallSettings)
            // Additional: BatchCreateOrdersAsync(BatchCreateOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateOrdersRequest request = new BatchCreateOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateOrderRequest(),
                },
            };
            // Make the request
            BatchCreateOrdersResponse response = await orderServiceClient.BatchCreateOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOrders</summary>
        public void BatchCreateOrders()
        {
            // Snippet: BatchCreateOrders(string, IEnumerable<CreateOrderRequest>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateOrderRequest> requests = new CreateOrderRequest[]
            {
                new CreateOrderRequest(),
            };
            // Make the request
            BatchCreateOrdersResponse response = orderServiceClient.BatchCreateOrders(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOrdersAsync</summary>
        public async Task BatchCreateOrdersAsync()
        {
            // Snippet: BatchCreateOrdersAsync(string, IEnumerable<CreateOrderRequest>, CallSettings)
            // Additional: BatchCreateOrdersAsync(string, IEnumerable<CreateOrderRequest>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateOrderRequest> requests = new CreateOrderRequest[]
            {
                new CreateOrderRequest(),
            };
            // Make the request
            BatchCreateOrdersResponse response = await orderServiceClient.BatchCreateOrdersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOrders</summary>
        public void BatchCreateOrdersResourceNames()
        {
            // Snippet: BatchCreateOrders(NetworkName, IEnumerable<CreateOrderRequest>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateOrderRequest> requests = new CreateOrderRequest[]
            {
                new CreateOrderRequest(),
            };
            // Make the request
            BatchCreateOrdersResponse response = orderServiceClient.BatchCreateOrders(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateOrdersAsync</summary>
        public async Task BatchCreateOrdersResourceNamesAsync()
        {
            // Snippet: BatchCreateOrdersAsync(NetworkName, IEnumerable<CreateOrderRequest>, CallSettings)
            // Additional: BatchCreateOrdersAsync(NetworkName, IEnumerable<CreateOrderRequest>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateOrderRequest> requests = new CreateOrderRequest[]
            {
                new CreateOrderRequest(),
            };
            // Make the request
            BatchCreateOrdersResponse response = await orderServiceClient.BatchCreateOrdersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateOrders</summary>
        public void BatchUpdateOrdersRequestObject()
        {
            // Snippet: BatchUpdateOrders(BatchUpdateOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateOrdersRequest request = new BatchUpdateOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateOrderRequest(),
                },
            };
            // Make the request
            BatchUpdateOrdersResponse response = orderServiceClient.BatchUpdateOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateOrdersAsync</summary>
        public async Task BatchUpdateOrdersRequestObjectAsync()
        {
            // Snippet: BatchUpdateOrdersAsync(BatchUpdateOrdersRequest, CallSettings)
            // Additional: BatchUpdateOrdersAsync(BatchUpdateOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateOrdersRequest request = new BatchUpdateOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateOrderRequest(),
                },
            };
            // Make the request
            BatchUpdateOrdersResponse response = await orderServiceClient.BatchUpdateOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateOrders</summary>
        public void BatchUpdateOrders()
        {
            // Snippet: BatchUpdateOrders(string, IEnumerable<UpdateOrderRequest>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateOrderRequest> requests = new UpdateOrderRequest[]
            {
                new UpdateOrderRequest(),
            };
            // Make the request
            BatchUpdateOrdersResponse response = orderServiceClient.BatchUpdateOrders(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateOrdersAsync</summary>
        public async Task BatchUpdateOrdersAsync()
        {
            // Snippet: BatchUpdateOrdersAsync(string, IEnumerable<UpdateOrderRequest>, CallSettings)
            // Additional: BatchUpdateOrdersAsync(string, IEnumerable<UpdateOrderRequest>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateOrderRequest> requests = new UpdateOrderRequest[]
            {
                new UpdateOrderRequest(),
            };
            // Make the request
            BatchUpdateOrdersResponse response = await orderServiceClient.BatchUpdateOrdersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateOrders</summary>
        public void BatchUpdateOrdersResourceNames()
        {
            // Snippet: BatchUpdateOrders(NetworkName, IEnumerable<UpdateOrderRequest>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateOrderRequest> requests = new UpdateOrderRequest[]
            {
                new UpdateOrderRequest(),
            };
            // Make the request
            BatchUpdateOrdersResponse response = orderServiceClient.BatchUpdateOrders(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateOrdersAsync</summary>
        public async Task BatchUpdateOrdersResourceNamesAsync()
        {
            // Snippet: BatchUpdateOrdersAsync(NetworkName, IEnumerable<UpdateOrderRequest>, CallSettings)
            // Additional: BatchUpdateOrdersAsync(NetworkName, IEnumerable<UpdateOrderRequest>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateOrderRequest> requests = new UpdateOrderRequest[]
            {
                new UpdateOrderRequest(),
            };
            // Make the request
            BatchUpdateOrdersResponse response = await orderServiceClient.BatchUpdateOrdersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrders</summary>
        public void BatchApproveOrdersRequestObject()
        {
            // Snippet: BatchApproveOrders(BatchApproveOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchApproveOrdersRequest request = new BatchApproveOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
                SkipInventoryCheck = false,
            };
            // Make the request
            BatchApproveOrdersResponse response = orderServiceClient.BatchApproveOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersAsync</summary>
        public async Task BatchApproveOrdersRequestObjectAsync()
        {
            // Snippet: BatchApproveOrdersAsync(BatchApproveOrdersRequest, CallSettings)
            // Additional: BatchApproveOrdersAsync(BatchApproveOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchApproveOrdersRequest request = new BatchApproveOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
                SkipInventoryCheck = false,
            };
            // Make the request
            BatchApproveOrdersResponse response = await orderServiceClient.BatchApproveOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrders</summary>
        public void BatchApproveOrders()
        {
            // Snippet: BatchApproveOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchApproveOrdersResponse response = orderServiceClient.BatchApproveOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersAsync</summary>
        public async Task BatchApproveOrdersAsync()
        {
            // Snippet: BatchApproveOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchApproveOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchApproveOrdersResponse response = await orderServiceClient.BatchApproveOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrders</summary>
        public void BatchApproveOrdersResourceNames()
        {
            // Snippet: BatchApproveOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchApproveOrdersResponse response = orderServiceClient.BatchApproveOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersAsync</summary>
        public async Task BatchApproveOrdersResourceNamesAsync()
        {
            // Snippet: BatchApproveOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchApproveOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchApproveOrdersResponse response = await orderServiceClient.BatchApproveOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAndOverbookOrders</summary>
        public void BatchApproveAndOverbookOrdersRequestObject()
        {
            // Snippet: BatchApproveAndOverbookOrders(BatchApproveAndOverbookOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchApproveAndOverbookOrdersRequest request = new BatchApproveAndOverbookOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
                SkipInventoryCheck = false,
            };
            // Make the request
            BatchApproveAndOverbookOrdersResponse response = orderServiceClient.BatchApproveAndOverbookOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAndOverbookOrdersAsync</summary>
        public async Task BatchApproveAndOverbookOrdersRequestObjectAsync()
        {
            // Snippet: BatchApproveAndOverbookOrdersAsync(BatchApproveAndOverbookOrdersRequest, CallSettings)
            // Additional: BatchApproveAndOverbookOrdersAsync(BatchApproveAndOverbookOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchApproveAndOverbookOrdersRequest request = new BatchApproveAndOverbookOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
                SkipInventoryCheck = false,
            };
            // Make the request
            BatchApproveAndOverbookOrdersResponse response = await orderServiceClient.BatchApproveAndOverbookOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAndOverbookOrders</summary>
        public void BatchApproveAndOverbookOrders()
        {
            // Snippet: BatchApproveAndOverbookOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchApproveAndOverbookOrdersResponse response = orderServiceClient.BatchApproveAndOverbookOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAndOverbookOrdersAsync</summary>
        public async Task BatchApproveAndOverbookOrdersAsync()
        {
            // Snippet: BatchApproveAndOverbookOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchApproveAndOverbookOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchApproveAndOverbookOrdersResponse response = await orderServiceClient.BatchApproveAndOverbookOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAndOverbookOrders</summary>
        public void BatchApproveAndOverbookOrdersResourceNames()
        {
            // Snippet: BatchApproveAndOverbookOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchApproveAndOverbookOrdersResponse response = orderServiceClient.BatchApproveAndOverbookOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveAndOverbookOrdersAsync</summary>
        public async Task BatchApproveAndOverbookOrdersResourceNamesAsync()
        {
            // Snippet: BatchApproveAndOverbookOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchApproveAndOverbookOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchApproveAndOverbookOrdersResponse response = await orderServiceClient.BatchApproveAndOverbookOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApproval</summary>
        public void BatchSubmitOrdersForApprovalRequestObject()
        {
            // Snippet: BatchSubmitOrdersForApproval(BatchSubmitOrdersForApprovalRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchSubmitOrdersForApprovalRequest request = new BatchSubmitOrdersForApprovalRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
                SkipInventoryCheck = false,
            };
            // Make the request
            BatchSubmitOrdersForApprovalResponse response = orderServiceClient.BatchSubmitOrdersForApproval(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAsync</summary>
        public async Task BatchSubmitOrdersForApprovalRequestObjectAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalAsync(BatchSubmitOrdersForApprovalRequest, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalAsync(BatchSubmitOrdersForApprovalRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchSubmitOrdersForApprovalRequest request = new BatchSubmitOrdersForApprovalRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
                SkipInventoryCheck = false,
            };
            // Make the request
            BatchSubmitOrdersForApprovalResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApproval</summary>
        public void BatchSubmitOrdersForApproval()
        {
            // Snippet: BatchSubmitOrdersForApproval(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchSubmitOrdersForApprovalResponse response = orderServiceClient.BatchSubmitOrdersForApproval(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAsync</summary>
        public async Task BatchSubmitOrdersForApprovalAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchSubmitOrdersForApprovalResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApproval</summary>
        public void BatchSubmitOrdersForApprovalResourceNames()
        {
            // Snippet: BatchSubmitOrdersForApproval(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchSubmitOrdersForApprovalResponse response = orderServiceClient.BatchSubmitOrdersForApproval(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAsync</summary>
        public async Task BatchSubmitOrdersForApprovalResourceNamesAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchSubmitOrdersForApprovalResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAndOverbook</summary>
        public void BatchSubmitOrdersForApprovalAndOverbookRequestObject()
        {
            // Snippet: BatchSubmitOrdersForApprovalAndOverbook(BatchSubmitOrdersForApprovalAndOverbookRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchSubmitOrdersForApprovalAndOverbookRequest request = new BatchSubmitOrdersForApprovalAndOverbookRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchSubmitOrdersForApprovalAndOverbookResponse response = orderServiceClient.BatchSubmitOrdersForApprovalAndOverbook(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAndOverbookAsync</summary>
        public async Task BatchSubmitOrdersForApprovalAndOverbookRequestObjectAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalAndOverbookAsync(BatchSubmitOrdersForApprovalAndOverbookRequest, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalAndOverbookAsync(BatchSubmitOrdersForApprovalAndOverbookRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchSubmitOrdersForApprovalAndOverbookRequest request = new BatchSubmitOrdersForApprovalAndOverbookRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchSubmitOrdersForApprovalAndOverbookResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalAndOverbookAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAndOverbook</summary>
        public void BatchSubmitOrdersForApprovalAndOverbook()
        {
            // Snippet: BatchSubmitOrdersForApprovalAndOverbook(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchSubmitOrdersForApprovalAndOverbookResponse response = orderServiceClient.BatchSubmitOrdersForApprovalAndOverbook(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAndOverbookAsync</summary>
        public async Task BatchSubmitOrdersForApprovalAndOverbookAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalAndOverbookAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalAndOverbookAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchSubmitOrdersForApprovalAndOverbookResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalAndOverbookAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAndOverbook</summary>
        public void BatchSubmitOrdersForApprovalAndOverbookResourceNames()
        {
            // Snippet: BatchSubmitOrdersForApprovalAndOverbook(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchSubmitOrdersForApprovalAndOverbookResponse response = orderServiceClient.BatchSubmitOrdersForApprovalAndOverbook(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalAndOverbookAsync</summary>
        public async Task BatchSubmitOrdersForApprovalAndOverbookResourceNamesAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalAndOverbookAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalAndOverbookAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchSubmitOrdersForApprovalAndOverbookResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalAndOverbookAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalWithoutReservationChanges</summary>
        public void BatchSubmitOrdersForApprovalWithoutReservationChangesRequestObject()
        {
            // Snippet: BatchSubmitOrdersForApprovalWithoutReservationChanges(BatchSubmitOrdersForApprovalWithoutReservationChangesRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchSubmitOrdersForApprovalWithoutReservationChangesRequest request = new BatchSubmitOrdersForApprovalWithoutReservationChangesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchSubmitOrdersForApprovalWithoutReservationChangesResponse response = orderServiceClient.BatchSubmitOrdersForApprovalWithoutReservationChanges(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalWithoutReservationChangesAsync</summary>
        public async Task BatchSubmitOrdersForApprovalWithoutReservationChangesRequestObjectAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(BatchSubmitOrdersForApprovalWithoutReservationChangesRequest, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(BatchSubmitOrdersForApprovalWithoutReservationChangesRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchSubmitOrdersForApprovalWithoutReservationChangesRequest request = new BatchSubmitOrdersForApprovalWithoutReservationChangesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchSubmitOrdersForApprovalWithoutReservationChangesResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalWithoutReservationChanges</summary>
        public void BatchSubmitOrdersForApprovalWithoutReservationChanges()
        {
            // Snippet: BatchSubmitOrdersForApprovalWithoutReservationChanges(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchSubmitOrdersForApprovalWithoutReservationChangesResponse response = orderServiceClient.BatchSubmitOrdersForApprovalWithoutReservationChanges(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalWithoutReservationChangesAsync</summary>
        public async Task BatchSubmitOrdersForApprovalWithoutReservationChangesAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchSubmitOrdersForApprovalWithoutReservationChangesResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalWithoutReservationChanges</summary>
        public void BatchSubmitOrdersForApprovalWithoutReservationChangesResourceNames()
        {
            // Snippet: BatchSubmitOrdersForApprovalWithoutReservationChanges(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchSubmitOrdersForApprovalWithoutReservationChangesResponse response = orderServiceClient.BatchSubmitOrdersForApprovalWithoutReservationChanges(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchSubmitOrdersForApprovalWithoutReservationChangesAsync</summary>
        public async Task BatchSubmitOrdersForApprovalWithoutReservationChangesResourceNamesAsync()
        {
            // Snippet: BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchSubmitOrdersForApprovalWithoutReservationChangesResponse response = await orderServiceClient.BatchSubmitOrdersForApprovalWithoutReservationChangesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseOrders</summary>
        public void BatchPauseOrdersRequestObject()
        {
            // Snippet: BatchPauseOrders(BatchPauseOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchPauseOrdersRequest request = new BatchPauseOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchPauseOrdersResponse response = orderServiceClient.BatchPauseOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseOrdersAsync</summary>
        public async Task BatchPauseOrdersRequestObjectAsync()
        {
            // Snippet: BatchPauseOrdersAsync(BatchPauseOrdersRequest, CallSettings)
            // Additional: BatchPauseOrdersAsync(BatchPauseOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPauseOrdersRequest request = new BatchPauseOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchPauseOrdersResponse response = await orderServiceClient.BatchPauseOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseOrders</summary>
        public void BatchPauseOrders()
        {
            // Snippet: BatchPauseOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchPauseOrdersResponse response = orderServiceClient.BatchPauseOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseOrdersAsync</summary>
        public async Task BatchPauseOrdersAsync()
        {
            // Snippet: BatchPauseOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchPauseOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchPauseOrdersResponse response = await orderServiceClient.BatchPauseOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseOrders</summary>
        public void BatchPauseOrdersResourceNames()
        {
            // Snippet: BatchPauseOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchPauseOrdersResponse response = orderServiceClient.BatchPauseOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseOrdersAsync</summary>
        public async Task BatchPauseOrdersResourceNamesAsync()
        {
            // Snippet: BatchPauseOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchPauseOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchPauseOrdersResponse response = await orderServiceClient.BatchPauseOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeOrders</summary>
        public void BatchResumeOrdersRequestObject()
        {
            // Snippet: BatchResumeOrders(BatchResumeOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchResumeOrdersRequest request = new BatchResumeOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
                SkipInventoryCheck = false,
            };
            // Make the request
            BatchResumeOrdersResponse response = orderServiceClient.BatchResumeOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeOrdersAsync</summary>
        public async Task BatchResumeOrdersRequestObjectAsync()
        {
            // Snippet: BatchResumeOrdersAsync(BatchResumeOrdersRequest, CallSettings)
            // Additional: BatchResumeOrdersAsync(BatchResumeOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchResumeOrdersRequest request = new BatchResumeOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
                SkipInventoryCheck = false,
            };
            // Make the request
            BatchResumeOrdersResponse response = await orderServiceClient.BatchResumeOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeOrders</summary>
        public void BatchResumeOrders()
        {
            // Snippet: BatchResumeOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchResumeOrdersResponse response = orderServiceClient.BatchResumeOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeOrdersAsync</summary>
        public async Task BatchResumeOrdersAsync()
        {
            // Snippet: BatchResumeOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchResumeOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchResumeOrdersResponse response = await orderServiceClient.BatchResumeOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeOrders</summary>
        public void BatchResumeOrdersResourceNames()
        {
            // Snippet: BatchResumeOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchResumeOrdersResponse response = orderServiceClient.BatchResumeOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeOrdersAsync</summary>
        public async Task BatchResumeOrdersResourceNamesAsync()
        {
            // Snippet: BatchResumeOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchResumeOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchResumeOrdersResponse response = await orderServiceClient.BatchResumeOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookOrders</summary>
        public void BatchResumeAndOverbookOrdersRequestObject()
        {
            // Snippet: BatchResumeAndOverbookOrders(BatchResumeAndOverbookOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchResumeAndOverbookOrdersRequest request = new BatchResumeAndOverbookOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchResumeAndOverbookOrdersResponse response = orderServiceClient.BatchResumeAndOverbookOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookOrdersAsync</summary>
        public async Task BatchResumeAndOverbookOrdersRequestObjectAsync()
        {
            // Snippet: BatchResumeAndOverbookOrdersAsync(BatchResumeAndOverbookOrdersRequest, CallSettings)
            // Additional: BatchResumeAndOverbookOrdersAsync(BatchResumeAndOverbookOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchResumeAndOverbookOrdersRequest request = new BatchResumeAndOverbookOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchResumeAndOverbookOrdersResponse response = await orderServiceClient.BatchResumeAndOverbookOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookOrders</summary>
        public void BatchResumeAndOverbookOrders()
        {
            // Snippet: BatchResumeAndOverbookOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchResumeAndOverbookOrdersResponse response = orderServiceClient.BatchResumeAndOverbookOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookOrdersAsync</summary>
        public async Task BatchResumeAndOverbookOrdersAsync()
        {
            // Snippet: BatchResumeAndOverbookOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchResumeAndOverbookOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchResumeAndOverbookOrdersResponse response = await orderServiceClient.BatchResumeAndOverbookOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookOrders</summary>
        public void BatchResumeAndOverbookOrdersResourceNames()
        {
            // Snippet: BatchResumeAndOverbookOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchResumeAndOverbookOrdersResponse response = orderServiceClient.BatchResumeAndOverbookOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookOrdersAsync</summary>
        public async Task BatchResumeAndOverbookOrdersResourceNamesAsync()
        {
            // Snippet: BatchResumeAndOverbookOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchResumeAndOverbookOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchResumeAndOverbookOrdersResponse response = await orderServiceClient.BatchResumeAndOverbookOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersWithoutReservation</summary>
        public void BatchApproveOrdersWithoutReservationRequestObject()
        {
            // Snippet: BatchApproveOrdersWithoutReservation(BatchApproveOrdersWithoutReservationRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchApproveOrdersWithoutReservationRequest request = new BatchApproveOrdersWithoutReservationRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchApproveOrdersWithoutReservationResponse response = orderServiceClient.BatchApproveOrdersWithoutReservation(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersWithoutReservationAsync</summary>
        public async Task BatchApproveOrdersWithoutReservationRequestObjectAsync()
        {
            // Snippet: BatchApproveOrdersWithoutReservationAsync(BatchApproveOrdersWithoutReservationRequest, CallSettings)
            // Additional: BatchApproveOrdersWithoutReservationAsync(BatchApproveOrdersWithoutReservationRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchApproveOrdersWithoutReservationRequest request = new BatchApproveOrdersWithoutReservationRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchApproveOrdersWithoutReservationResponse response = await orderServiceClient.BatchApproveOrdersWithoutReservationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersWithoutReservation</summary>
        public void BatchApproveOrdersWithoutReservation()
        {
            // Snippet: BatchApproveOrdersWithoutReservation(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchApproveOrdersWithoutReservationResponse response = orderServiceClient.BatchApproveOrdersWithoutReservation(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersWithoutReservationAsync</summary>
        public async Task BatchApproveOrdersWithoutReservationAsync()
        {
            // Snippet: BatchApproveOrdersWithoutReservationAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchApproveOrdersWithoutReservationAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchApproveOrdersWithoutReservationResponse response = await orderServiceClient.BatchApproveOrdersWithoutReservationAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersWithoutReservation</summary>
        public void BatchApproveOrdersWithoutReservationResourceNames()
        {
            // Snippet: BatchApproveOrdersWithoutReservation(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchApproveOrdersWithoutReservationResponse response = orderServiceClient.BatchApproveOrdersWithoutReservation(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveOrdersWithoutReservationAsync</summary>
        public async Task BatchApproveOrdersWithoutReservationResourceNamesAsync()
        {
            // Snippet: BatchApproveOrdersWithoutReservationAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchApproveOrdersWithoutReservationAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchApproveOrdersWithoutReservationResponse response = await orderServiceClient.BatchApproveOrdersWithoutReservationAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveOrders</summary>
        public void BatchArchiveOrdersRequestObject()
        {
            // Snippet: BatchArchiveOrders(BatchArchiveOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveOrdersRequest request = new BatchArchiveOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchArchiveOrdersResponse response = orderServiceClient.BatchArchiveOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveOrdersAsync</summary>
        public async Task BatchArchiveOrdersRequestObjectAsync()
        {
            // Snippet: BatchArchiveOrdersAsync(BatchArchiveOrdersRequest, CallSettings)
            // Additional: BatchArchiveOrdersAsync(BatchArchiveOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveOrdersRequest request = new BatchArchiveOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchArchiveOrdersResponse response = await orderServiceClient.BatchArchiveOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveOrders</summary>
        public void BatchArchiveOrders()
        {
            // Snippet: BatchArchiveOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchArchiveOrdersResponse response = orderServiceClient.BatchArchiveOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveOrdersAsync</summary>
        public async Task BatchArchiveOrdersAsync()
        {
            // Snippet: BatchArchiveOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchArchiveOrdersResponse response = await orderServiceClient.BatchArchiveOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveOrders</summary>
        public void BatchArchiveOrdersResourceNames()
        {
            // Snippet: BatchArchiveOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchArchiveOrdersResponse response = orderServiceClient.BatchArchiveOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveOrdersAsync</summary>
        public async Task BatchArchiveOrdersResourceNamesAsync()
        {
            // Snippet: BatchArchiveOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchArchiveOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchArchiveOrdersResponse response = await orderServiceClient.BatchArchiveOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveOrders</summary>
        public void BatchUnarchiveOrdersRequestObject()
        {
            // Snippet: BatchUnarchiveOrders(BatchUnarchiveOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchUnarchiveOrdersRequest request = new BatchUnarchiveOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchUnarchiveOrdersResponse response = orderServiceClient.BatchUnarchiveOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveOrdersAsync</summary>
        public async Task BatchUnarchiveOrdersRequestObjectAsync()
        {
            // Snippet: BatchUnarchiveOrdersAsync(BatchUnarchiveOrdersRequest, CallSettings)
            // Additional: BatchUnarchiveOrdersAsync(BatchUnarchiveOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUnarchiveOrdersRequest request = new BatchUnarchiveOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchUnarchiveOrdersResponse response = await orderServiceClient.BatchUnarchiveOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveOrders</summary>
        public void BatchUnarchiveOrders()
        {
            // Snippet: BatchUnarchiveOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchUnarchiveOrdersResponse response = orderServiceClient.BatchUnarchiveOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveOrdersAsync</summary>
        public async Task BatchUnarchiveOrdersAsync()
        {
            // Snippet: BatchUnarchiveOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchUnarchiveOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchUnarchiveOrdersResponse response = await orderServiceClient.BatchUnarchiveOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveOrders</summary>
        public void BatchUnarchiveOrdersResourceNames()
        {
            // Snippet: BatchUnarchiveOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchUnarchiveOrdersResponse response = orderServiceClient.BatchUnarchiveOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveOrdersAsync</summary>
        public async Task BatchUnarchiveOrdersResourceNamesAsync()
        {
            // Snippet: BatchUnarchiveOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchUnarchiveOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchUnarchiveOrdersResponse response = await orderServiceClient.BatchUnarchiveOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteOrders</summary>
        public void BatchDeleteOrdersRequestObject()
        {
            // Snippet: BatchDeleteOrders(BatchDeleteOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteOrdersRequest request = new BatchDeleteOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchDeleteOrdersResponse response = orderServiceClient.BatchDeleteOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteOrdersAsync</summary>
        public async Task BatchDeleteOrdersRequestObjectAsync()
        {
            // Snippet: BatchDeleteOrdersAsync(BatchDeleteOrdersRequest, CallSettings)
            // Additional: BatchDeleteOrdersAsync(BatchDeleteOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteOrdersRequest request = new BatchDeleteOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchDeleteOrdersResponse response = await orderServiceClient.BatchDeleteOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteOrders</summary>
        public void BatchDeleteOrders()
        {
            // Snippet: BatchDeleteOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchDeleteOrdersResponse response = orderServiceClient.BatchDeleteOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteOrdersAsync</summary>
        public async Task BatchDeleteOrdersAsync()
        {
            // Snippet: BatchDeleteOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchDeleteOrdersResponse response = await orderServiceClient.BatchDeleteOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteOrders</summary>
        public void BatchDeleteOrdersResourceNames()
        {
            // Snippet: BatchDeleteOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchDeleteOrdersResponse response = orderServiceClient.BatchDeleteOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteOrdersAsync</summary>
        public async Task BatchDeleteOrdersResourceNamesAsync()
        {
            // Snippet: BatchDeleteOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchDeleteOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchDeleteOrdersResponse response = await orderServiceClient.BatchDeleteOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrders</summary>
        public void BatchDisapproveOrdersRequestObject()
        {
            // Snippet: BatchDisapproveOrders(BatchDisapproveOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchDisapproveOrdersRequest request = new BatchDisapproveOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchDisapproveOrdersResponse response = orderServiceClient.BatchDisapproveOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersAsync</summary>
        public async Task BatchDisapproveOrdersRequestObjectAsync()
        {
            // Snippet: BatchDisapproveOrdersAsync(BatchDisapproveOrdersRequest, CallSettings)
            // Additional: BatchDisapproveOrdersAsync(BatchDisapproveOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDisapproveOrdersRequest request = new BatchDisapproveOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchDisapproveOrdersResponse response = await orderServiceClient.BatchDisapproveOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrders</summary>
        public void BatchDisapproveOrders()
        {
            // Snippet: BatchDisapproveOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchDisapproveOrdersResponse response = orderServiceClient.BatchDisapproveOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersAsync</summary>
        public async Task BatchDisapproveOrdersAsync()
        {
            // Snippet: BatchDisapproveOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDisapproveOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchDisapproveOrdersResponse response = await orderServiceClient.BatchDisapproveOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrders</summary>
        public void BatchDisapproveOrdersResourceNames()
        {
            // Snippet: BatchDisapproveOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchDisapproveOrdersResponse response = orderServiceClient.BatchDisapproveOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersAsync</summary>
        public async Task BatchDisapproveOrdersResourceNamesAsync()
        {
            // Snippet: BatchDisapproveOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchDisapproveOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchDisapproveOrdersResponse response = await orderServiceClient.BatchDisapproveOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersWithoutReservationChanges</summary>
        public void BatchDisapproveOrdersWithoutReservationChangesRequestObject()
        {
            // Snippet: BatchDisapproveOrdersWithoutReservationChanges(BatchDisapproveOrdersWithoutReservationChangesRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchDisapproveOrdersWithoutReservationChangesRequest request = new BatchDisapproveOrdersWithoutReservationChangesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchDisapproveOrdersWithoutReservationChangesResponse response = orderServiceClient.BatchDisapproveOrdersWithoutReservationChanges(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersWithoutReservationChangesAsync</summary>
        public async Task BatchDisapproveOrdersWithoutReservationChangesRequestObjectAsync()
        {
            // Snippet: BatchDisapproveOrdersWithoutReservationChangesAsync(BatchDisapproveOrdersWithoutReservationChangesRequest, CallSettings)
            // Additional: BatchDisapproveOrdersWithoutReservationChangesAsync(BatchDisapproveOrdersWithoutReservationChangesRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDisapproveOrdersWithoutReservationChangesRequest request = new BatchDisapproveOrdersWithoutReservationChangesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchDisapproveOrdersWithoutReservationChangesResponse response = await orderServiceClient.BatchDisapproveOrdersWithoutReservationChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersWithoutReservationChanges</summary>
        public void BatchDisapproveOrdersWithoutReservationChanges()
        {
            // Snippet: BatchDisapproveOrdersWithoutReservationChanges(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchDisapproveOrdersWithoutReservationChangesResponse response = orderServiceClient.BatchDisapproveOrdersWithoutReservationChanges(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersWithoutReservationChangesAsync</summary>
        public async Task BatchDisapproveOrdersWithoutReservationChangesAsync()
        {
            // Snippet: BatchDisapproveOrdersWithoutReservationChangesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDisapproveOrdersWithoutReservationChangesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchDisapproveOrdersWithoutReservationChangesResponse response = await orderServiceClient.BatchDisapproveOrdersWithoutReservationChangesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersWithoutReservationChanges</summary>
        public void BatchDisapproveOrdersWithoutReservationChangesResourceNames()
        {
            // Snippet: BatchDisapproveOrdersWithoutReservationChanges(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchDisapproveOrdersWithoutReservationChangesResponse response = orderServiceClient.BatchDisapproveOrdersWithoutReservationChanges(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDisapproveOrdersWithoutReservationChangesAsync</summary>
        public async Task BatchDisapproveOrdersWithoutReservationChangesResourceNamesAsync()
        {
            // Snippet: BatchDisapproveOrdersWithoutReservationChangesAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchDisapproveOrdersWithoutReservationChangesAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchDisapproveOrdersWithoutReservationChangesResponse response = await orderServiceClient.BatchDisapproveOrdersWithoutReservationChangesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrders</summary>
        public void BatchRetractOrdersRequestObject()
        {
            // Snippet: BatchRetractOrders(BatchRetractOrdersRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchRetractOrdersRequest request = new BatchRetractOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchRetractOrdersResponse response = orderServiceClient.BatchRetractOrders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersAsync</summary>
        public async Task BatchRetractOrdersRequestObjectAsync()
        {
            // Snippet: BatchRetractOrdersAsync(BatchRetractOrdersRequest, CallSettings)
            // Additional: BatchRetractOrdersAsync(BatchRetractOrdersRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRetractOrdersRequest request = new BatchRetractOrdersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchRetractOrdersResponse response = await orderServiceClient.BatchRetractOrdersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrders</summary>
        public void BatchRetractOrders()
        {
            // Snippet: BatchRetractOrders(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchRetractOrdersResponse response = orderServiceClient.BatchRetractOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersAsync</summary>
        public async Task BatchRetractOrdersAsync()
        {
            // Snippet: BatchRetractOrdersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchRetractOrdersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchRetractOrdersResponse response = await orderServiceClient.BatchRetractOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrders</summary>
        public void BatchRetractOrdersResourceNames()
        {
            // Snippet: BatchRetractOrders(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchRetractOrdersResponse response = orderServiceClient.BatchRetractOrders(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersAsync</summary>
        public async Task BatchRetractOrdersResourceNamesAsync()
        {
            // Snippet: BatchRetractOrdersAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchRetractOrdersAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchRetractOrdersResponse response = await orderServiceClient.BatchRetractOrdersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersWithoutReservationChanges</summary>
        public void BatchRetractOrdersWithoutReservationChangesRequestObject()
        {
            // Snippet: BatchRetractOrdersWithoutReservationChanges(BatchRetractOrdersWithoutReservationChangesRequest, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            BatchRetractOrdersWithoutReservationChangesRequest request = new BatchRetractOrdersWithoutReservationChangesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchRetractOrdersWithoutReservationChangesResponse response = orderServiceClient.BatchRetractOrdersWithoutReservationChanges(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersWithoutReservationChangesAsync</summary>
        public async Task BatchRetractOrdersWithoutReservationChangesRequestObjectAsync()
        {
            // Snippet: BatchRetractOrdersWithoutReservationChangesAsync(BatchRetractOrdersWithoutReservationChangesRequest, CallSettings)
            // Additional: BatchRetractOrdersWithoutReservationChangesAsync(BatchRetractOrdersWithoutReservationChangesRequest, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRetractOrdersWithoutReservationChangesRequest request = new BatchRetractOrdersWithoutReservationChangesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                OrderNames =
                {
                    OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
                },
            };
            // Make the request
            BatchRetractOrdersWithoutReservationChangesResponse response = await orderServiceClient.BatchRetractOrdersWithoutReservationChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersWithoutReservationChanges</summary>
        public void BatchRetractOrdersWithoutReservationChanges()
        {
            // Snippet: BatchRetractOrdersWithoutReservationChanges(string, IEnumerable<string>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchRetractOrdersWithoutReservationChangesResponse response = orderServiceClient.BatchRetractOrdersWithoutReservationChanges(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersWithoutReservationChangesAsync</summary>
        public async Task BatchRetractOrdersWithoutReservationChangesAsync()
        {
            // Snippet: BatchRetractOrdersWithoutReservationChangesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchRetractOrdersWithoutReservationChangesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/orders/[ORDER]",
            };
            // Make the request
            BatchRetractOrdersWithoutReservationChangesResponse response = await orderServiceClient.BatchRetractOrdersWithoutReservationChangesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersWithoutReservationChanges</summary>
        public void BatchRetractOrdersWithoutReservationChangesResourceNames()
        {
            // Snippet: BatchRetractOrdersWithoutReservationChanges(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Create client
            OrderServiceClient orderServiceClient = OrderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchRetractOrdersWithoutReservationChangesResponse response = orderServiceClient.BatchRetractOrdersWithoutReservationChanges(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRetractOrdersWithoutReservationChangesAsync</summary>
        public async Task BatchRetractOrdersWithoutReservationChangesResourceNamesAsync()
        {
            // Snippet: BatchRetractOrdersWithoutReservationChangesAsync(NetworkName, IEnumerable<OrderName>, CallSettings)
            // Additional: BatchRetractOrdersWithoutReservationChangesAsync(NetworkName, IEnumerable<OrderName>, CancellationToken)
            // Create client
            OrderServiceClient orderServiceClient = await OrderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<OrderName> names = new OrderName[]
            {
                OrderName.FromNetworkCodeOrder("[NETWORK_CODE]", "[ORDER]"),
            };
            // Make the request
            BatchRetractOrdersWithoutReservationChangesResponse response = await orderServiceClient.BatchRetractOrdersWithoutReservationChangesAsync(parent, names);
            // End snippet
        }
    }
}
