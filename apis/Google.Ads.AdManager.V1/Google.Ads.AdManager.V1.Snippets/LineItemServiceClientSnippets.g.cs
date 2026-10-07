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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
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
            await foreach (LineItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemsResponse page in response.AsRawResponses())
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
            await foreach (LineItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemsResponse page in response.AsRawResponses())
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
            await foreach (LineItem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLineItemsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for CreateLineItem</summary>
        public void CreateLineItemRequestObject()
        {
            // Snippet: CreateLineItem(CreateLineItemRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            CreateLineItemRequest request = new CreateLineItemRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItem = new LineItem(),
            };
            // Make the request
            LineItem response = lineItemServiceClient.CreateLineItem(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItemAsync</summary>
        public async Task CreateLineItemRequestObjectAsync()
        {
            // Snippet: CreateLineItemAsync(CreateLineItemRequest, CallSettings)
            // Additional: CreateLineItemAsync(CreateLineItemRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLineItemRequest request = new CreateLineItemRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItem = new LineItem(),
            };
            // Make the request
            LineItem response = await lineItemServiceClient.CreateLineItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItem</summary>
        public void CreateLineItem()
        {
            // Snippet: CreateLineItem(string, LineItem, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            LineItem lineItem = new LineItem();
            // Make the request
            LineItem response = lineItemServiceClient.CreateLineItem(parent, lineItem);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItemAsync</summary>
        public async Task CreateLineItemAsync()
        {
            // Snippet: CreateLineItemAsync(string, LineItem, CallSettings)
            // Additional: CreateLineItemAsync(string, LineItem, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            LineItem lineItem = new LineItem();
            // Make the request
            LineItem response = await lineItemServiceClient.CreateLineItemAsync(parent, lineItem);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItem</summary>
        public void CreateLineItemResourceNames()
        {
            // Snippet: CreateLineItem(NetworkName, LineItem, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            LineItem lineItem = new LineItem();
            // Make the request
            LineItem response = lineItemServiceClient.CreateLineItem(parent, lineItem);
            // End snippet
        }

        /// <summary>Snippet for CreateLineItemAsync</summary>
        public async Task CreateLineItemResourceNamesAsync()
        {
            // Snippet: CreateLineItemAsync(NetworkName, LineItem, CallSettings)
            // Additional: CreateLineItemAsync(NetworkName, LineItem, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            LineItem lineItem = new LineItem();
            // Make the request
            LineItem response = await lineItemServiceClient.CreateLineItemAsync(parent, lineItem);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItems</summary>
        public void BatchCreateLineItemsRequestObject()
        {
            // Snippet: BatchCreateLineItems(BatchCreateLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateLineItemsRequest request = new BatchCreateLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateLineItemRequest(),
                },
            };
            // Make the request
            BatchCreateLineItemsResponse response = lineItemServiceClient.BatchCreateLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemsAsync</summary>
        public async Task BatchCreateLineItemsRequestObjectAsync()
        {
            // Snippet: BatchCreateLineItemsAsync(BatchCreateLineItemsRequest, CallSettings)
            // Additional: BatchCreateLineItemsAsync(BatchCreateLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateLineItemsRequest request = new BatchCreateLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateLineItemRequest(),
                },
            };
            // Make the request
            BatchCreateLineItemsResponse response = await lineItemServiceClient.BatchCreateLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItems</summary>
        public void BatchCreateLineItems()
        {
            // Snippet: BatchCreateLineItems(string, IEnumerable<CreateLineItemRequest>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateLineItemRequest> requests = new CreateLineItemRequest[]
            {
                new CreateLineItemRequest(),
            };
            // Make the request
            BatchCreateLineItemsResponse response = lineItemServiceClient.BatchCreateLineItems(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemsAsync</summary>
        public async Task BatchCreateLineItemsAsync()
        {
            // Snippet: BatchCreateLineItemsAsync(string, IEnumerable<CreateLineItemRequest>, CallSettings)
            // Additional: BatchCreateLineItemsAsync(string, IEnumerable<CreateLineItemRequest>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateLineItemRequest> requests = new CreateLineItemRequest[]
            {
                new CreateLineItemRequest(),
            };
            // Make the request
            BatchCreateLineItemsResponse response = await lineItemServiceClient.BatchCreateLineItemsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItems</summary>
        public void BatchCreateLineItemsResourceNames()
        {
            // Snippet: BatchCreateLineItems(NetworkName, IEnumerable<CreateLineItemRequest>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateLineItemRequest> requests = new CreateLineItemRequest[]
            {
                new CreateLineItemRequest(),
            };
            // Make the request
            BatchCreateLineItemsResponse response = lineItemServiceClient.BatchCreateLineItems(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateLineItemsAsync</summary>
        public async Task BatchCreateLineItemsResourceNamesAsync()
        {
            // Snippet: BatchCreateLineItemsAsync(NetworkName, IEnumerable<CreateLineItemRequest>, CallSettings)
            // Additional: BatchCreateLineItemsAsync(NetworkName, IEnumerable<CreateLineItemRequest>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateLineItemRequest> requests = new CreateLineItemRequest[]
            {
                new CreateLineItemRequest(),
            };
            // Make the request
            BatchCreateLineItemsResponse response = await lineItemServiceClient.BatchCreateLineItemsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateLineItem</summary>
        public void UpdateLineItemRequestObject()
        {
            // Snippet: UpdateLineItem(UpdateLineItemRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            UpdateLineItemRequest request = new UpdateLineItemRequest
            {
                LineItem = new LineItem(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LineItem response = lineItemServiceClient.UpdateLineItem(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLineItemAsync</summary>
        public async Task UpdateLineItemRequestObjectAsync()
        {
            // Snippet: UpdateLineItemAsync(UpdateLineItemRequest, CallSettings)
            // Additional: UpdateLineItemAsync(UpdateLineItemRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLineItemRequest request = new UpdateLineItemRequest
            {
                LineItem = new LineItem(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LineItem response = await lineItemServiceClient.UpdateLineItemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLineItem</summary>
        public void UpdateLineItem()
        {
            // Snippet: UpdateLineItem(LineItem, FieldMask, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            LineItem lineItem = new LineItem();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LineItem response = lineItemServiceClient.UpdateLineItem(lineItem, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateLineItemAsync</summary>
        public async Task UpdateLineItemAsync()
        {
            // Snippet: UpdateLineItemAsync(LineItem, FieldMask, CallSettings)
            // Additional: UpdateLineItemAsync(LineItem, FieldMask, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            LineItem lineItem = new LineItem();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LineItem response = await lineItemServiceClient.UpdateLineItemAsync(lineItem, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItems</summary>
        public void BatchUpdateLineItemsRequestObject()
        {
            // Snippet: BatchUpdateLineItems(BatchUpdateLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateLineItemsRequest request = new BatchUpdateLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateLineItemRequest(),
                },
            };
            // Make the request
            BatchUpdateLineItemsResponse response = lineItemServiceClient.BatchUpdateLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemsAsync</summary>
        public async Task BatchUpdateLineItemsRequestObjectAsync()
        {
            // Snippet: BatchUpdateLineItemsAsync(BatchUpdateLineItemsRequest, CallSettings)
            // Additional: BatchUpdateLineItemsAsync(BatchUpdateLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateLineItemsRequest request = new BatchUpdateLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateLineItemRequest(),
                },
            };
            // Make the request
            BatchUpdateLineItemsResponse response = await lineItemServiceClient.BatchUpdateLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItems</summary>
        public void BatchUpdateLineItems()
        {
            // Snippet: BatchUpdateLineItems(string, IEnumerable<UpdateLineItemRequest>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateLineItemRequest> requests = new UpdateLineItemRequest[]
            {
                new UpdateLineItemRequest(),
            };
            // Make the request
            BatchUpdateLineItemsResponse response = lineItemServiceClient.BatchUpdateLineItems(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemsAsync</summary>
        public async Task BatchUpdateLineItemsAsync()
        {
            // Snippet: BatchUpdateLineItemsAsync(string, IEnumerable<UpdateLineItemRequest>, CallSettings)
            // Additional: BatchUpdateLineItemsAsync(string, IEnumerable<UpdateLineItemRequest>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateLineItemRequest> requests = new UpdateLineItemRequest[]
            {
                new UpdateLineItemRequest(),
            };
            // Make the request
            BatchUpdateLineItemsResponse response = await lineItemServiceClient.BatchUpdateLineItemsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItems</summary>
        public void BatchUpdateLineItemsResourceNames()
        {
            // Snippet: BatchUpdateLineItems(NetworkName, IEnumerable<UpdateLineItemRequest>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateLineItemRequest> requests = new UpdateLineItemRequest[]
            {
                new UpdateLineItemRequest(),
            };
            // Make the request
            BatchUpdateLineItemsResponse response = lineItemServiceClient.BatchUpdateLineItems(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateLineItemsAsync</summary>
        public async Task BatchUpdateLineItemsResourceNamesAsync()
        {
            // Snippet: BatchUpdateLineItemsAsync(NetworkName, IEnumerable<UpdateLineItemRequest>, CallSettings)
            // Additional: BatchUpdateLineItemsAsync(NetworkName, IEnumerable<UpdateLineItemRequest>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateLineItemRequest> requests = new UpdateLineItemRequest[]
            {
                new UpdateLineItemRequest(),
            };
            // Make the request
            BatchUpdateLineItemsResponse response = await lineItemServiceClient.BatchUpdateLineItemsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItems</summary>
        public void BatchActivateLineItemsRequestObject()
        {
            // Snippet: BatchActivateLineItems(BatchActivateLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateLineItemsRequest request = new BatchActivateLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchActivateLineItemsResponse response = lineItemServiceClient.BatchActivateLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemsAsync</summary>
        public async Task BatchActivateLineItemsRequestObjectAsync()
        {
            // Snippet: BatchActivateLineItemsAsync(BatchActivateLineItemsRequest, CallSettings)
            // Additional: BatchActivateLineItemsAsync(BatchActivateLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateLineItemsRequest request = new BatchActivateLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchActivateLineItemsResponse response = await lineItemServiceClient.BatchActivateLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItems</summary>
        public void BatchActivateLineItems()
        {
            // Snippet: BatchActivateLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchActivateLineItemsResponse response = lineItemServiceClient.BatchActivateLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemsAsync</summary>
        public async Task BatchActivateLineItemsAsync()
        {
            // Snippet: BatchActivateLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchActivateLineItemsResponse response = await lineItemServiceClient.BatchActivateLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItems</summary>
        public void BatchActivateLineItemsResourceNames()
        {
            // Snippet: BatchActivateLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchActivateLineItemsResponse response = lineItemServiceClient.BatchActivateLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateLineItemsAsync</summary>
        public async Task BatchActivateLineItemsResourceNamesAsync()
        {
            // Snippet: BatchActivateLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchActivateLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchActivateLineItemsResponse response = await lineItemServiceClient.BatchActivateLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLineItems</summary>
        public void BatchPauseLineItemsRequestObject()
        {
            // Snippet: BatchPauseLineItems(BatchPauseLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchPauseLineItemsRequest request = new BatchPauseLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchPauseLineItemsResponse response = lineItemServiceClient.BatchPauseLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLineItemsAsync</summary>
        public async Task BatchPauseLineItemsRequestObjectAsync()
        {
            // Snippet: BatchPauseLineItemsAsync(BatchPauseLineItemsRequest, CallSettings)
            // Additional: BatchPauseLineItemsAsync(BatchPauseLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchPauseLineItemsRequest request = new BatchPauseLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchPauseLineItemsResponse response = await lineItemServiceClient.BatchPauseLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLineItems</summary>
        public void BatchPauseLineItems()
        {
            // Snippet: BatchPauseLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchPauseLineItemsResponse response = lineItemServiceClient.BatchPauseLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLineItemsAsync</summary>
        public async Task BatchPauseLineItemsAsync()
        {
            // Snippet: BatchPauseLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchPauseLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchPauseLineItemsResponse response = await lineItemServiceClient.BatchPauseLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLineItems</summary>
        public void BatchPauseLineItemsResourceNames()
        {
            // Snippet: BatchPauseLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchPauseLineItemsResponse response = lineItemServiceClient.BatchPauseLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchPauseLineItemsAsync</summary>
        public async Task BatchPauseLineItemsResourceNamesAsync()
        {
            // Snippet: BatchPauseLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchPauseLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchPauseLineItemsResponse response = await lineItemServiceClient.BatchPauseLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeLineItems</summary>
        public void BatchResumeLineItemsRequestObject()
        {
            // Snippet: BatchResumeLineItems(BatchResumeLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchResumeLineItemsRequest request = new BatchResumeLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchResumeLineItemsResponse response = lineItemServiceClient.BatchResumeLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeLineItemsAsync</summary>
        public async Task BatchResumeLineItemsRequestObjectAsync()
        {
            // Snippet: BatchResumeLineItemsAsync(BatchResumeLineItemsRequest, CallSettings)
            // Additional: BatchResumeLineItemsAsync(BatchResumeLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchResumeLineItemsRequest request = new BatchResumeLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchResumeLineItemsResponse response = await lineItemServiceClient.BatchResumeLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeLineItems</summary>
        public void BatchResumeLineItems()
        {
            // Snippet: BatchResumeLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchResumeLineItemsResponse response = lineItemServiceClient.BatchResumeLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeLineItemsAsync</summary>
        public async Task BatchResumeLineItemsAsync()
        {
            // Snippet: BatchResumeLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchResumeLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchResumeLineItemsResponse response = await lineItemServiceClient.BatchResumeLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeLineItems</summary>
        public void BatchResumeLineItemsResourceNames()
        {
            // Snippet: BatchResumeLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchResumeLineItemsResponse response = lineItemServiceClient.BatchResumeLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeLineItemsAsync</summary>
        public async Task BatchResumeLineItemsResourceNamesAsync()
        {
            // Snippet: BatchResumeLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchResumeLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchResumeLineItemsResponse response = await lineItemServiceClient.BatchResumeLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookLineItems</summary>
        public void BatchResumeAndOverbookLineItemsRequestObject()
        {
            // Snippet: BatchResumeAndOverbookLineItems(BatchResumeAndOverbookLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchResumeAndOverbookLineItemsRequest request = new BatchResumeAndOverbookLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchResumeAndOverbookLineItemsResponse response = lineItemServiceClient.BatchResumeAndOverbookLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookLineItemsAsync</summary>
        public async Task BatchResumeAndOverbookLineItemsRequestObjectAsync()
        {
            // Snippet: BatchResumeAndOverbookLineItemsAsync(BatchResumeAndOverbookLineItemsRequest, CallSettings)
            // Additional: BatchResumeAndOverbookLineItemsAsync(BatchResumeAndOverbookLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchResumeAndOverbookLineItemsRequest request = new BatchResumeAndOverbookLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchResumeAndOverbookLineItemsResponse response = await lineItemServiceClient.BatchResumeAndOverbookLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookLineItems</summary>
        public void BatchResumeAndOverbookLineItems()
        {
            // Snippet: BatchResumeAndOverbookLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchResumeAndOverbookLineItemsResponse response = lineItemServiceClient.BatchResumeAndOverbookLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookLineItemsAsync</summary>
        public async Task BatchResumeAndOverbookLineItemsAsync()
        {
            // Snippet: BatchResumeAndOverbookLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchResumeAndOverbookLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchResumeAndOverbookLineItemsResponse response = await lineItemServiceClient.BatchResumeAndOverbookLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookLineItems</summary>
        public void BatchResumeAndOverbookLineItemsResourceNames()
        {
            // Snippet: BatchResumeAndOverbookLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchResumeAndOverbookLineItemsResponse response = lineItemServiceClient.BatchResumeAndOverbookLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResumeAndOverbookLineItemsAsync</summary>
        public async Task BatchResumeAndOverbookLineItemsResourceNamesAsync()
        {
            // Snippet: BatchResumeAndOverbookLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchResumeAndOverbookLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchResumeAndOverbookLineItemsResponse response = await lineItemServiceClient.BatchResumeAndOverbookLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItems</summary>
        public void BatchDeleteLineItemsRequestObject()
        {
            // Snippet: BatchDeleteLineItems(BatchDeleteLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteLineItemsRequest request = new BatchDeleteLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            lineItemServiceClient.BatchDeleteLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemsAsync</summary>
        public async Task BatchDeleteLineItemsRequestObjectAsync()
        {
            // Snippet: BatchDeleteLineItemsAsync(BatchDeleteLineItemsRequest, CallSettings)
            // Additional: BatchDeleteLineItemsAsync(BatchDeleteLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteLineItemsRequest request = new BatchDeleteLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            await lineItemServiceClient.BatchDeleteLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItems</summary>
        public void BatchDeleteLineItems()
        {
            // Snippet: BatchDeleteLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            lineItemServiceClient.BatchDeleteLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemsAsync</summary>
        public async Task BatchDeleteLineItemsAsync()
        {
            // Snippet: BatchDeleteLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            await lineItemServiceClient.BatchDeleteLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItems</summary>
        public void BatchDeleteLineItemsResourceNames()
        {
            // Snippet: BatchDeleteLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            lineItemServiceClient.BatchDeleteLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteLineItemsAsync</summary>
        public async Task BatchDeleteLineItemsResourceNamesAsync()
        {
            // Snippet: BatchDeleteLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchDeleteLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            await lineItemServiceClient.BatchDeleteLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveLineItems</summary>
        public void BatchReserveLineItemsRequestObject()
        {
            // Snippet: BatchReserveLineItems(BatchReserveLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchReserveLineItemsRequest request = new BatchReserveLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchReserveLineItemsResponse response = lineItemServiceClient.BatchReserveLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveLineItemsAsync</summary>
        public async Task BatchReserveLineItemsRequestObjectAsync()
        {
            // Snippet: BatchReserveLineItemsAsync(BatchReserveLineItemsRequest, CallSettings)
            // Additional: BatchReserveLineItemsAsync(BatchReserveLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchReserveLineItemsRequest request = new BatchReserveLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchReserveLineItemsResponse response = await lineItemServiceClient.BatchReserveLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveLineItems</summary>
        public void BatchReserveLineItems()
        {
            // Snippet: BatchReserveLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchReserveLineItemsResponse response = lineItemServiceClient.BatchReserveLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveLineItemsAsync</summary>
        public async Task BatchReserveLineItemsAsync()
        {
            // Snippet: BatchReserveLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchReserveLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchReserveLineItemsResponse response = await lineItemServiceClient.BatchReserveLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveLineItems</summary>
        public void BatchReserveLineItemsResourceNames()
        {
            // Snippet: BatchReserveLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchReserveLineItemsResponse response = lineItemServiceClient.BatchReserveLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveLineItemsAsync</summary>
        public async Task BatchReserveLineItemsResourceNamesAsync()
        {
            // Snippet: BatchReserveLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchReserveLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchReserveLineItemsResponse response = await lineItemServiceClient.BatchReserveLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveAndOverbookLineItems</summary>
        public void BatchReserveAndOverbookLineItemsRequestObject()
        {
            // Snippet: BatchReserveAndOverbookLineItems(BatchReserveAndOverbookLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchReserveAndOverbookLineItemsRequest request = new BatchReserveAndOverbookLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchReserveAndOverbookLineItemsResponse response = lineItemServiceClient.BatchReserveAndOverbookLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveAndOverbookLineItemsAsync</summary>
        public async Task BatchReserveAndOverbookLineItemsRequestObjectAsync()
        {
            // Snippet: BatchReserveAndOverbookLineItemsAsync(BatchReserveAndOverbookLineItemsRequest, CallSettings)
            // Additional: BatchReserveAndOverbookLineItemsAsync(BatchReserveAndOverbookLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchReserveAndOverbookLineItemsRequest request = new BatchReserveAndOverbookLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchReserveAndOverbookLineItemsResponse response = await lineItemServiceClient.BatchReserveAndOverbookLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveAndOverbookLineItems</summary>
        public void BatchReserveAndOverbookLineItems()
        {
            // Snippet: BatchReserveAndOverbookLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchReserveAndOverbookLineItemsResponse response = lineItemServiceClient.BatchReserveAndOverbookLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveAndOverbookLineItemsAsync</summary>
        public async Task BatchReserveAndOverbookLineItemsAsync()
        {
            // Snippet: BatchReserveAndOverbookLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchReserveAndOverbookLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchReserveAndOverbookLineItemsResponse response = await lineItemServiceClient.BatchReserveAndOverbookLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveAndOverbookLineItems</summary>
        public void BatchReserveAndOverbookLineItemsResourceNames()
        {
            // Snippet: BatchReserveAndOverbookLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchReserveAndOverbookLineItemsResponse response = lineItemServiceClient.BatchReserveAndOverbookLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReserveAndOverbookLineItemsAsync</summary>
        public async Task BatchReserveAndOverbookLineItemsResourceNamesAsync()
        {
            // Snippet: BatchReserveAndOverbookLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchReserveAndOverbookLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchReserveAndOverbookLineItemsResponse response = await lineItemServiceClient.BatchReserveAndOverbookLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReleaseLineItems</summary>
        public void BatchReleaseLineItemsRequestObject()
        {
            // Snippet: BatchReleaseLineItems(BatchReleaseLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchReleaseLineItemsRequest request = new BatchReleaseLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchReleaseLineItemsResponse response = lineItemServiceClient.BatchReleaseLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReleaseLineItemsAsync</summary>
        public async Task BatchReleaseLineItemsRequestObjectAsync()
        {
            // Snippet: BatchReleaseLineItemsAsync(BatchReleaseLineItemsRequest, CallSettings)
            // Additional: BatchReleaseLineItemsAsync(BatchReleaseLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchReleaseLineItemsRequest request = new BatchReleaseLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchReleaseLineItemsResponse response = await lineItemServiceClient.BatchReleaseLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchReleaseLineItems</summary>
        public void BatchReleaseLineItems()
        {
            // Snippet: BatchReleaseLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchReleaseLineItemsResponse response = lineItemServiceClient.BatchReleaseLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReleaseLineItemsAsync</summary>
        public async Task BatchReleaseLineItemsAsync()
        {
            // Snippet: BatchReleaseLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchReleaseLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchReleaseLineItemsResponse response = await lineItemServiceClient.BatchReleaseLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReleaseLineItems</summary>
        public void BatchReleaseLineItemsResourceNames()
        {
            // Snippet: BatchReleaseLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchReleaseLineItemsResponse response = lineItemServiceClient.BatchReleaseLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchReleaseLineItemsAsync</summary>
        public async Task BatchReleaseLineItemsResourceNamesAsync()
        {
            // Snippet: BatchReleaseLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchReleaseLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchReleaseLineItemsResponse response = await lineItemServiceClient.BatchReleaseLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLineItems</summary>
        public void BatchArchiveLineItemsRequestObject()
        {
            // Snippet: BatchArchiveLineItems(BatchArchiveLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveLineItemsRequest request = new BatchArchiveLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchArchiveLineItemsResponse response = lineItemServiceClient.BatchArchiveLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLineItemsAsync</summary>
        public async Task BatchArchiveLineItemsRequestObjectAsync()
        {
            // Snippet: BatchArchiveLineItemsAsync(BatchArchiveLineItemsRequest, CallSettings)
            // Additional: BatchArchiveLineItemsAsync(BatchArchiveLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveLineItemsRequest request = new BatchArchiveLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchArchiveLineItemsResponse response = await lineItemServiceClient.BatchArchiveLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLineItems</summary>
        public void BatchArchiveLineItems()
        {
            // Snippet: BatchArchiveLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchArchiveLineItemsResponse response = lineItemServiceClient.BatchArchiveLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLineItemsAsync</summary>
        public async Task BatchArchiveLineItemsAsync()
        {
            // Snippet: BatchArchiveLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchArchiveLineItemsResponse response = await lineItemServiceClient.BatchArchiveLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLineItems</summary>
        public void BatchArchiveLineItemsResourceNames()
        {
            // Snippet: BatchArchiveLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchArchiveLineItemsResponse response = lineItemServiceClient.BatchArchiveLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveLineItemsAsync</summary>
        public async Task BatchArchiveLineItemsResourceNamesAsync()
        {
            // Snippet: BatchArchiveLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchArchiveLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchArchiveLineItemsResponse response = await lineItemServiceClient.BatchArchiveLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveLineItems</summary>
        public void BatchUnarchiveLineItemsRequestObject()
        {
            // Snippet: BatchUnarchiveLineItems(BatchUnarchiveLineItemsRequest, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            BatchUnarchiveLineItemsRequest request = new BatchUnarchiveLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchUnarchiveLineItemsResponse response = lineItemServiceClient.BatchUnarchiveLineItems(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveLineItemsAsync</summary>
        public async Task BatchUnarchiveLineItemsRequestObjectAsync()
        {
            // Snippet: BatchUnarchiveLineItemsAsync(BatchUnarchiveLineItemsRequest, CallSettings)
            // Additional: BatchUnarchiveLineItemsAsync(BatchUnarchiveLineItemsRequest, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUnarchiveLineItemsRequest request = new BatchUnarchiveLineItemsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                LineItemNames =
                {
                    LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
                },
            };
            // Make the request
            BatchUnarchiveLineItemsResponse response = await lineItemServiceClient.BatchUnarchiveLineItemsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveLineItems</summary>
        public void BatchUnarchiveLineItems()
        {
            // Snippet: BatchUnarchiveLineItems(string, IEnumerable<string>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchUnarchiveLineItemsResponse response = lineItemServiceClient.BatchUnarchiveLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveLineItemsAsync</summary>
        public async Task BatchUnarchiveLineItemsAsync()
        {
            // Snippet: BatchUnarchiveLineItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchUnarchiveLineItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/lineItems/[LINE_ITEM]",
            };
            // Make the request
            BatchUnarchiveLineItemsResponse response = await lineItemServiceClient.BatchUnarchiveLineItemsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveLineItems</summary>
        public void BatchUnarchiveLineItemsResourceNames()
        {
            // Snippet: BatchUnarchiveLineItems(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Create client
            LineItemServiceClient lineItemServiceClient = LineItemServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchUnarchiveLineItemsResponse response = lineItemServiceClient.BatchUnarchiveLineItems(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveLineItemsAsync</summary>
        public async Task BatchUnarchiveLineItemsResourceNamesAsync()
        {
            // Snippet: BatchUnarchiveLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CallSettings)
            // Additional: BatchUnarchiveLineItemsAsync(NetworkName, IEnumerable<LineItemName>, CancellationToken)
            // Create client
            LineItemServiceClient lineItemServiceClient = await LineItemServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<LineItemName> names = new LineItemName[]
            {
                LineItemName.FromNetworkCodeLineItem("[NETWORK_CODE]", "[LINE_ITEM]"),
            };
            // Make the request
            BatchUnarchiveLineItemsResponse response = await lineItemServiceClient.BatchUnarchiveLineItemsAsync(parent, names);
            // End snippet
        }
    }
}
