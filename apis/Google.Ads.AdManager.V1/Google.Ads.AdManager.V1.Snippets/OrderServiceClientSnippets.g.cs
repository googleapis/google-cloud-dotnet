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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Linq;
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
    }
}
