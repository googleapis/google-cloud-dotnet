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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLineItemServiceClientSnippets
    {
        /// <summary>Snippet for GetLineItem</summary>
        public void GetLineItemRequestObject()
        {
            // Snippet: GetLineItem(GetLineItemRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            GetLineItemRequest request = new GetLineItemRequest
            {
                LineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            LineItem response = lineItemServiceClient.GetLineItem(request);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemAsync</summary>
        public async Task GetLineItemRequestObjectAsync()
        {
            // Snippet: GetLineItemAsync(GetLineItemRequest, CallSettings)
            // Additional: GetLineItemAsync(GetLineItemRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLineItemRequest request = new GetLineItemRequest
            {
                LineItemName = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            LineItem response = await lineItemServiceClient.GetLineItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLineItem</summary>
        public void GetLineItem()
        {
            // Snippet: GetLineItem(string, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            // Make the request
            LineItem response = lineItemServiceClient.GetLineItem(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemAsync</summary>
        public async Task GetLineItemAsync()
        {
            // Snippet: GetLineItemAsync(string, CallSettings)
            // Additional: GetLineItemAsync(string, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]";
            // Make the request
            LineItem response = await lineItemServiceClient.GetLineItemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItem</summary>
        public void GetLineItemResourceNames()
        {
            // Snippet: GetLineItem(LineItemName, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            LineItemName name = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            // Make the request
            LineItem response = lineItemServiceClient.GetLineItem(name);
            // End snippet
        }

        /// <summary>Snippet for GetLineItemAsync</summary>
        public async Task GetLineItemResourceNamesAsync()
        {
            // Snippet: GetLineItemAsync(LineItemName, CallSettings)
            // Additional: GetLineItemAsync(LineItemName, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItemName name = LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]");
            // Make the request
            LineItem response = await lineItemServiceClient.GetLineItemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLineItems</summary>
        public void ListLineItemsRequestObject()
        {
            // Snippet: ListLineItems(ListLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            ListLineItemsRequest request = new ListLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListLineItemsResponse, LineItem> response = lineItemServiceClient.ListLineItems(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemsAsync</summary>
        public async Task ListLineItemsRequestObjectAsync()
        {
            // Snippet: ListLineItemsAsync(ListLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLineItemsRequest request = new ListLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListLineItemsResponse, LineItem> response = lineItemServiceClient.ListLineItemsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LineItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLineItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItems</summary>
        public void ListLineItems()
        {
            // Snippet: ListLineItems(string, string, int?, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListLineItemsResponse, LineItem> response = lineItemServiceClient.ListLineItems(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemsAsync</summary>
        public async Task ListLineItemsAsync()
        {
            // Snippet: ListLineItemsAsync(string, string, int?, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListLineItemsResponse, LineItem> response = lineItemServiceClient.ListLineItemsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LineItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLineItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItems</summary>
        public void ListLineItemsResourceNames()
        {
            // Snippet: ListLineItems(NetworkName, string, int?, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListLineItemsResponse, LineItem> response = lineItemServiceClient.ListLineItems(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LineItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLineItemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLineItemsAsync</summary>
        public async Task ListLineItemsResourceNamesAsync()
        {
            // Snippet: ListLineItemsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListLineItemsResponse, LineItem> response = lineItemServiceClient.ListLineItemsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LineItem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLineItemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LineItem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LineItem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LineItem item in singlePage)
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
