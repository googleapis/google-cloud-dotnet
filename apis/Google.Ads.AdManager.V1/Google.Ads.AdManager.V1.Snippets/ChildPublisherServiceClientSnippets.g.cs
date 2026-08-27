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
    public sealed class AllGeneratedChildPublisherServiceClientSnippets
    {
        /// <summary>Snippet for GetChildPublisher</summary>
        public void GetChildPublisherRequestObject()
        {
            // Snippet: GetChildPublisher(GetChildPublisherRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            GetChildPublisherRequest request = new GetChildPublisherRequest
            {
                ChildPublisherName = ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
            };
            // Make the request
            ChildPublisher response = childPublisherServiceClient.GetChildPublisher(request);
            // End snippet
        }

        /// <summary>Snippet for GetChildPublisherAsync</summary>
        public async Task GetChildPublisherRequestObjectAsync()
        {
            // Snippet: GetChildPublisherAsync(GetChildPublisherRequest, CallSettings)
            // Additional: GetChildPublisherAsync(GetChildPublisherRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetChildPublisherRequest request = new GetChildPublisherRequest
            {
                ChildPublisherName = ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
            };
            // Make the request
            ChildPublisher response = await childPublisherServiceClient.GetChildPublisherAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChildPublisher</summary>
        public void GetChildPublisher()
        {
            // Snippet: GetChildPublisher(string, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/childPublishers/[CHILD_PUBLISHER]";
            // Make the request
            ChildPublisher response = childPublisherServiceClient.GetChildPublisher(name);
            // End snippet
        }

        /// <summary>Snippet for GetChildPublisherAsync</summary>
        public async Task GetChildPublisherAsync()
        {
            // Snippet: GetChildPublisherAsync(string, CallSettings)
            // Additional: GetChildPublisherAsync(string, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/childPublishers/[CHILD_PUBLISHER]";
            // Make the request
            ChildPublisher response = await childPublisherServiceClient.GetChildPublisherAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChildPublisher</summary>
        public void GetChildPublisherResourceNames()
        {
            // Snippet: GetChildPublisher(ChildPublisherName, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            ChildPublisherName name = ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]");
            // Make the request
            ChildPublisher response = childPublisherServiceClient.GetChildPublisher(name);
            // End snippet
        }

        /// <summary>Snippet for GetChildPublisherAsync</summary>
        public async Task GetChildPublisherResourceNamesAsync()
        {
            // Snippet: GetChildPublisherAsync(ChildPublisherName, CallSettings)
            // Additional: GetChildPublisherAsync(ChildPublisherName, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChildPublisherName name = ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]");
            // Make the request
            ChildPublisher response = await childPublisherServiceClient.GetChildPublisherAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListChildPublishers</summary>
        public void ListChildPublishersRequestObject()
        {
            // Snippet: ListChildPublishers(ListChildPublishersRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            ListChildPublishersRequest request = new ListChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListChildPublishersResponse, ChildPublisher> response = childPublisherServiceClient.ListChildPublishers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChildPublisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChildPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChildPublisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChildPublisher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChildPublisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildPublishersAsync</summary>
        public async Task ListChildPublishersRequestObjectAsync()
        {
            // Snippet: ListChildPublishersAsync(ListChildPublishersRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListChildPublishersRequest request = new ListChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListChildPublishersResponse, ChildPublisher> response = childPublisherServiceClient.ListChildPublishersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ChildPublisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChildPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChildPublisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChildPublisher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChildPublisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildPublishers</summary>
        public void ListChildPublishers()
        {
            // Snippet: ListChildPublishers(string, string, int?, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListChildPublishersResponse, ChildPublisher> response = childPublisherServiceClient.ListChildPublishers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChildPublisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChildPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChildPublisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChildPublisher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChildPublisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildPublishersAsync</summary>
        public async Task ListChildPublishersAsync()
        {
            // Snippet: ListChildPublishersAsync(string, string, int?, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListChildPublishersResponse, ChildPublisher> response = childPublisherServiceClient.ListChildPublishersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ChildPublisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChildPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChildPublisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChildPublisher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChildPublisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildPublishers</summary>
        public void ListChildPublishersResourceNames()
        {
            // Snippet: ListChildPublishers(NetworkName, string, int?, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListChildPublishersResponse, ChildPublisher> response = childPublisherServiceClient.ListChildPublishers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChildPublisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChildPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChildPublisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChildPublisher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChildPublisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildPublishersAsync</summary>
        public async Task ListChildPublishersResourceNamesAsync()
        {
            // Snippet: ListChildPublishersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListChildPublishersResponse, ChildPublisher> response = childPublisherServiceClient.ListChildPublishersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ChildPublisher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChildPublishersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChildPublisher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChildPublisher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChildPublisher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateChildPublisher</summary>
        public void CreateChildPublisherRequestObject()
        {
            // Snippet: CreateChildPublisher(CreateChildPublisherRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            CreateChildPublisherRequest request = new CreateChildPublisherRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ChildPublisher = new ChildPublisher(),
            };
            // Make the request
            ChildPublisher response = childPublisherServiceClient.CreateChildPublisher(request);
            // End snippet
        }

        /// <summary>Snippet for CreateChildPublisherAsync</summary>
        public async Task CreateChildPublisherRequestObjectAsync()
        {
            // Snippet: CreateChildPublisherAsync(CreateChildPublisherRequest, CallSettings)
            // Additional: CreateChildPublisherAsync(CreateChildPublisherRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateChildPublisherRequest request = new CreateChildPublisherRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ChildPublisher = new ChildPublisher(),
            };
            // Make the request
            ChildPublisher response = await childPublisherServiceClient.CreateChildPublisherAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateChildPublisher</summary>
        public void CreateChildPublisher()
        {
            // Snippet: CreateChildPublisher(string, ChildPublisher, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            ChildPublisher childPublisher = new ChildPublisher();
            // Make the request
            ChildPublisher response = childPublisherServiceClient.CreateChildPublisher(parent, childPublisher);
            // End snippet
        }

        /// <summary>Snippet for CreateChildPublisherAsync</summary>
        public async Task CreateChildPublisherAsync()
        {
            // Snippet: CreateChildPublisherAsync(string, ChildPublisher, CallSettings)
            // Additional: CreateChildPublisherAsync(string, ChildPublisher, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            ChildPublisher childPublisher = new ChildPublisher();
            // Make the request
            ChildPublisher response = await childPublisherServiceClient.CreateChildPublisherAsync(parent, childPublisher);
            // End snippet
        }

        /// <summary>Snippet for CreateChildPublisher</summary>
        public void CreateChildPublisherResourceNames()
        {
            // Snippet: CreateChildPublisher(NetworkName, ChildPublisher, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ChildPublisher childPublisher = new ChildPublisher();
            // Make the request
            ChildPublisher response = childPublisherServiceClient.CreateChildPublisher(parent, childPublisher);
            // End snippet
        }

        /// <summary>Snippet for CreateChildPublisherAsync</summary>
        public async Task CreateChildPublisherResourceNamesAsync()
        {
            // Snippet: CreateChildPublisherAsync(NetworkName, ChildPublisher, CallSettings)
            // Additional: CreateChildPublisherAsync(NetworkName, ChildPublisher, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ChildPublisher childPublisher = new ChildPublisher();
            // Make the request
            ChildPublisher response = await childPublisherServiceClient.CreateChildPublisherAsync(parent, childPublisher);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateChildPublishers</summary>
        public void BatchCreateChildPublishersRequestObject()
        {
            // Snippet: BatchCreateChildPublishers(BatchCreateChildPublishersRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateChildPublishersRequest request = new BatchCreateChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateChildPublisherRequest(),
                },
            };
            // Make the request
            BatchCreateChildPublishersResponse response = childPublisherServiceClient.BatchCreateChildPublishers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateChildPublishersAsync</summary>
        public async Task BatchCreateChildPublishersRequestObjectAsync()
        {
            // Snippet: BatchCreateChildPublishersAsync(BatchCreateChildPublishersRequest, CallSettings)
            // Additional: BatchCreateChildPublishersAsync(BatchCreateChildPublishersRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateChildPublishersRequest request = new BatchCreateChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateChildPublisherRequest(),
                },
            };
            // Make the request
            BatchCreateChildPublishersResponse response = await childPublisherServiceClient.BatchCreateChildPublishersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateChildPublishers</summary>
        public void BatchCreateChildPublishers()
        {
            // Snippet: BatchCreateChildPublishers(string, IEnumerable<CreateChildPublisherRequest>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateChildPublisherRequest> requests = new CreateChildPublisherRequest[]
            {
                new CreateChildPublisherRequest(),
            };
            // Make the request
            BatchCreateChildPublishersResponse response = childPublisherServiceClient.BatchCreateChildPublishers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateChildPublishersAsync</summary>
        public async Task BatchCreateChildPublishersAsync()
        {
            // Snippet: BatchCreateChildPublishersAsync(string, IEnumerable<CreateChildPublisherRequest>, CallSettings)
            // Additional: BatchCreateChildPublishersAsync(string, IEnumerable<CreateChildPublisherRequest>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateChildPublisherRequest> requests = new CreateChildPublisherRequest[]
            {
                new CreateChildPublisherRequest(),
            };
            // Make the request
            BatchCreateChildPublishersResponse response = await childPublisherServiceClient.BatchCreateChildPublishersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateChildPublishers</summary>
        public void BatchCreateChildPublishersResourceNames()
        {
            // Snippet: BatchCreateChildPublishers(NetworkName, IEnumerable<CreateChildPublisherRequest>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateChildPublisherRequest> requests = new CreateChildPublisherRequest[]
            {
                new CreateChildPublisherRequest(),
            };
            // Make the request
            BatchCreateChildPublishersResponse response = childPublisherServiceClient.BatchCreateChildPublishers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateChildPublishersAsync</summary>
        public async Task BatchCreateChildPublishersResourceNamesAsync()
        {
            // Snippet: BatchCreateChildPublishersAsync(NetworkName, IEnumerable<CreateChildPublisherRequest>, CallSettings)
            // Additional: BatchCreateChildPublishersAsync(NetworkName, IEnumerable<CreateChildPublisherRequest>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateChildPublisherRequest> requests = new CreateChildPublisherRequest[]
            {
                new CreateChildPublisherRequest(),
            };
            // Make the request
            BatchCreateChildPublishersResponse response = await childPublisherServiceClient.BatchCreateChildPublishersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateChildPublisher</summary>
        public void UpdateChildPublisherRequestObject()
        {
            // Snippet: UpdateChildPublisher(UpdateChildPublisherRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            UpdateChildPublisherRequest request = new UpdateChildPublisherRequest
            {
                ChildPublisher = new ChildPublisher(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ChildPublisher response = childPublisherServiceClient.UpdateChildPublisher(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateChildPublisherAsync</summary>
        public async Task UpdateChildPublisherRequestObjectAsync()
        {
            // Snippet: UpdateChildPublisherAsync(UpdateChildPublisherRequest, CallSettings)
            // Additional: UpdateChildPublisherAsync(UpdateChildPublisherRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateChildPublisherRequest request = new UpdateChildPublisherRequest
            {
                ChildPublisher = new ChildPublisher(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ChildPublisher response = await childPublisherServiceClient.UpdateChildPublisherAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateChildPublisher</summary>
        public void UpdateChildPublisher()
        {
            // Snippet: UpdateChildPublisher(ChildPublisher, FieldMask, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            ChildPublisher childPublisher = new ChildPublisher();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ChildPublisher response = childPublisherServiceClient.UpdateChildPublisher(childPublisher, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateChildPublisherAsync</summary>
        public async Task UpdateChildPublisherAsync()
        {
            // Snippet: UpdateChildPublisherAsync(ChildPublisher, FieldMask, CallSettings)
            // Additional: UpdateChildPublisherAsync(ChildPublisher, FieldMask, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChildPublisher childPublisher = new ChildPublisher();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ChildPublisher response = await childPublisherServiceClient.UpdateChildPublisherAsync(childPublisher, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateChildPublishers</summary>
        public void BatchUpdateChildPublishersRequestObject()
        {
            // Snippet: BatchUpdateChildPublishers(BatchUpdateChildPublishersRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateChildPublishersRequest request = new BatchUpdateChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateChildPublisherRequest(),
                },
            };
            // Make the request
            BatchUpdateChildPublishersResponse response = childPublisherServiceClient.BatchUpdateChildPublishers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateChildPublishersAsync</summary>
        public async Task BatchUpdateChildPublishersRequestObjectAsync()
        {
            // Snippet: BatchUpdateChildPublishersAsync(BatchUpdateChildPublishersRequest, CallSettings)
            // Additional: BatchUpdateChildPublishersAsync(BatchUpdateChildPublishersRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateChildPublishersRequest request = new BatchUpdateChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateChildPublisherRequest(),
                },
            };
            // Make the request
            BatchUpdateChildPublishersResponse response = await childPublisherServiceClient.BatchUpdateChildPublishersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateChildPublishers</summary>
        public void BatchUpdateChildPublishers()
        {
            // Snippet: BatchUpdateChildPublishers(string, IEnumerable<UpdateChildPublisherRequest>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateChildPublisherRequest> requests = new UpdateChildPublisherRequest[]
            {
                new UpdateChildPublisherRequest(),
            };
            // Make the request
            BatchUpdateChildPublishersResponse response = childPublisherServiceClient.BatchUpdateChildPublishers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateChildPublishersAsync</summary>
        public async Task BatchUpdateChildPublishersAsync()
        {
            // Snippet: BatchUpdateChildPublishersAsync(string, IEnumerable<UpdateChildPublisherRequest>, CallSettings)
            // Additional: BatchUpdateChildPublishersAsync(string, IEnumerable<UpdateChildPublisherRequest>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateChildPublisherRequest> requests = new UpdateChildPublisherRequest[]
            {
                new UpdateChildPublisherRequest(),
            };
            // Make the request
            BatchUpdateChildPublishersResponse response = await childPublisherServiceClient.BatchUpdateChildPublishersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateChildPublishers</summary>
        public void BatchUpdateChildPublishersResourceNames()
        {
            // Snippet: BatchUpdateChildPublishers(NetworkName, IEnumerable<UpdateChildPublisherRequest>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateChildPublisherRequest> requests = new UpdateChildPublisherRequest[]
            {
                new UpdateChildPublisherRequest(),
            };
            // Make the request
            BatchUpdateChildPublishersResponse response = childPublisherServiceClient.BatchUpdateChildPublishers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateChildPublishersAsync</summary>
        public async Task BatchUpdateChildPublishersResourceNamesAsync()
        {
            // Snippet: BatchUpdateChildPublishersAsync(NetworkName, IEnumerable<UpdateChildPublisherRequest>, CallSettings)
            // Additional: BatchUpdateChildPublishersAsync(NetworkName, IEnumerable<UpdateChildPublisherRequest>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateChildPublisherRequest> requests = new UpdateChildPublisherRequest[]
            {
                new UpdateChildPublisherRequest(),
            };
            // Make the request
            BatchUpdateChildPublishersResponse response = await childPublisherServiceClient.BatchUpdateChildPublishersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchResendChildPublisherInvitationEmails</summary>
        public void BatchResendChildPublisherInvitationEmailsRequestObject()
        {
            // Snippet: BatchResendChildPublisherInvitationEmails(BatchResendChildPublisherInvitationEmailsRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            BatchResendChildPublisherInvitationEmailsRequest request = new BatchResendChildPublisherInvitationEmailsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ChildPublisherNames =
                {
                    ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
                },
            };
            // Make the request
            BatchResendChildPublisherInvitationEmailsResponse response = childPublisherServiceClient.BatchResendChildPublisherInvitationEmails(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResendChildPublisherInvitationEmailsAsync</summary>
        public async Task BatchResendChildPublisherInvitationEmailsRequestObjectAsync()
        {
            // Snippet: BatchResendChildPublisherInvitationEmailsAsync(BatchResendChildPublisherInvitationEmailsRequest, CallSettings)
            // Additional: BatchResendChildPublisherInvitationEmailsAsync(BatchResendChildPublisherInvitationEmailsRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchResendChildPublisherInvitationEmailsRequest request = new BatchResendChildPublisherInvitationEmailsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ChildPublisherNames =
                {
                    ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
                },
            };
            // Make the request
            BatchResendChildPublisherInvitationEmailsResponse response = await childPublisherServiceClient.BatchResendChildPublisherInvitationEmailsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchResendChildPublisherInvitationEmails</summary>
        public void BatchResendChildPublisherInvitationEmails()
        {
            // Snippet: BatchResendChildPublisherInvitationEmails(string, IEnumerable<string>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/childPublishers/[CHILD_PUBLISHER]",
            };
            // Make the request
            BatchResendChildPublisherInvitationEmailsResponse response = childPublisherServiceClient.BatchResendChildPublisherInvitationEmails(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResendChildPublisherInvitationEmailsAsync</summary>
        public async Task BatchResendChildPublisherInvitationEmailsAsync()
        {
            // Snippet: BatchResendChildPublisherInvitationEmailsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchResendChildPublisherInvitationEmailsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/childPublishers/[CHILD_PUBLISHER]",
            };
            // Make the request
            BatchResendChildPublisherInvitationEmailsResponse response = await childPublisherServiceClient.BatchResendChildPublisherInvitationEmailsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResendChildPublisherInvitationEmails</summary>
        public void BatchResendChildPublisherInvitationEmailsResourceNames()
        {
            // Snippet: BatchResendChildPublisherInvitationEmails(NetworkName, IEnumerable<ChildPublisherName>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ChildPublisherName> names = new ChildPublisherName[]
            {
                ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
            };
            // Make the request
            BatchResendChildPublisherInvitationEmailsResponse response = childPublisherServiceClient.BatchResendChildPublisherInvitationEmails(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchResendChildPublisherInvitationEmailsAsync</summary>
        public async Task BatchResendChildPublisherInvitationEmailsResourceNamesAsync()
        {
            // Snippet: BatchResendChildPublisherInvitationEmailsAsync(NetworkName, IEnumerable<ChildPublisherName>, CallSettings)
            // Additional: BatchResendChildPublisherInvitationEmailsAsync(NetworkName, IEnumerable<ChildPublisherName>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ChildPublisherName> names = new ChildPublisherName[]
            {
                ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
            };
            // Make the request
            BatchResendChildPublisherInvitationEmailsResponse response = await childPublisherServiceClient.BatchResendChildPublisherInvitationEmailsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRenegotiateChildPublisherAgreements</summary>
        public void BatchRenegotiateChildPublisherAgreementsRequestObject()
        {
            // Snippet: BatchRenegotiateChildPublisherAgreements(BatchRenegotiateChildPublisherAgreementsRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            BatchRenegotiateChildPublisherAgreementsRequest request = new BatchRenegotiateChildPublisherAgreementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new RenegotiateChildPublisherAgreementRequest(),
                },
            };
            // Make the request
            BatchRenegotiateChildPublisherAgreementsResponse response = childPublisherServiceClient.BatchRenegotiateChildPublisherAgreements(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRenegotiateChildPublisherAgreementsAsync</summary>
        public async Task BatchRenegotiateChildPublisherAgreementsRequestObjectAsync()
        {
            // Snippet: BatchRenegotiateChildPublisherAgreementsAsync(BatchRenegotiateChildPublisherAgreementsRequest, CallSettings)
            // Additional: BatchRenegotiateChildPublisherAgreementsAsync(BatchRenegotiateChildPublisherAgreementsRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRenegotiateChildPublisherAgreementsRequest request = new BatchRenegotiateChildPublisherAgreementsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new RenegotiateChildPublisherAgreementRequest(),
                },
            };
            // Make the request
            BatchRenegotiateChildPublisherAgreementsResponse response = await childPublisherServiceClient.BatchRenegotiateChildPublisherAgreementsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRenegotiateChildPublisherAgreements</summary>
        public void BatchRenegotiateChildPublisherAgreements()
        {
            // Snippet: BatchRenegotiateChildPublisherAgreements(string, IEnumerable<RenegotiateChildPublisherAgreementRequest>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<RenegotiateChildPublisherAgreementRequest> requests = new RenegotiateChildPublisherAgreementRequest[]
            {
                new RenegotiateChildPublisherAgreementRequest(),
            };
            // Make the request
            BatchRenegotiateChildPublisherAgreementsResponse response = childPublisherServiceClient.BatchRenegotiateChildPublisherAgreements(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchRenegotiateChildPublisherAgreementsAsync</summary>
        public async Task BatchRenegotiateChildPublisherAgreementsAsync()
        {
            // Snippet: BatchRenegotiateChildPublisherAgreementsAsync(string, IEnumerable<RenegotiateChildPublisherAgreementRequest>, CallSettings)
            // Additional: BatchRenegotiateChildPublisherAgreementsAsync(string, IEnumerable<RenegotiateChildPublisherAgreementRequest>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<RenegotiateChildPublisherAgreementRequest> requests = new RenegotiateChildPublisherAgreementRequest[]
            {
                new RenegotiateChildPublisherAgreementRequest(),
            };
            // Make the request
            BatchRenegotiateChildPublisherAgreementsResponse response = await childPublisherServiceClient.BatchRenegotiateChildPublisherAgreementsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchRenegotiateChildPublisherAgreements</summary>
        public void BatchRenegotiateChildPublisherAgreementsResourceNames()
        {
            // Snippet: BatchRenegotiateChildPublisherAgreements(NetworkName, IEnumerable<RenegotiateChildPublisherAgreementRequest>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<RenegotiateChildPublisherAgreementRequest> requests = new RenegotiateChildPublisherAgreementRequest[]
            {
                new RenegotiateChildPublisherAgreementRequest(),
            };
            // Make the request
            BatchRenegotiateChildPublisherAgreementsResponse response = childPublisherServiceClient.BatchRenegotiateChildPublisherAgreements(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchRenegotiateChildPublisherAgreementsAsync</summary>
        public async Task BatchRenegotiateChildPublisherAgreementsResourceNamesAsync()
        {
            // Snippet: BatchRenegotiateChildPublisherAgreementsAsync(NetworkName, IEnumerable<RenegotiateChildPublisherAgreementRequest>, CallSettings)
            // Additional: BatchRenegotiateChildPublisherAgreementsAsync(NetworkName, IEnumerable<RenegotiateChildPublisherAgreementRequest>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<RenegotiateChildPublisherAgreementRequest> requests = new RenegotiateChildPublisherAgreementRequest[]
            {
                new RenegotiateChildPublisherAgreementRequest(),
            };
            // Make the request
            BatchRenegotiateChildPublisherAgreementsResponse response = await childPublisherServiceClient.BatchRenegotiateChildPublisherAgreementsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectChildPublishers</summary>
        public void BatchRejectChildPublishersRequestObject()
        {
            // Snippet: BatchRejectChildPublishers(BatchRejectChildPublishersRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            BatchRejectChildPublishersRequest request = new BatchRejectChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ChildPublisherNames =
                {
                    ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
                },
            };
            // Make the request
            BatchRejectChildPublishersResponse response = childPublisherServiceClient.BatchRejectChildPublishers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectChildPublishersAsync</summary>
        public async Task BatchRejectChildPublishersRequestObjectAsync()
        {
            // Snippet: BatchRejectChildPublishersAsync(BatchRejectChildPublishersRequest, CallSettings)
            // Additional: BatchRejectChildPublishersAsync(BatchRejectChildPublishersRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchRejectChildPublishersRequest request = new BatchRejectChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ChildPublisherNames =
                {
                    ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
                },
            };
            // Make the request
            BatchRejectChildPublishersResponse response = await childPublisherServiceClient.BatchRejectChildPublishersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectChildPublishers</summary>
        public void BatchRejectChildPublishers()
        {
            // Snippet: BatchRejectChildPublishers(string, IEnumerable<string>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/childPublishers/[CHILD_PUBLISHER]",
            };
            // Make the request
            BatchRejectChildPublishersResponse response = childPublisherServiceClient.BatchRejectChildPublishers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectChildPublishersAsync</summary>
        public async Task BatchRejectChildPublishersAsync()
        {
            // Snippet: BatchRejectChildPublishersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchRejectChildPublishersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/childPublishers/[CHILD_PUBLISHER]",
            };
            // Make the request
            BatchRejectChildPublishersResponse response = await childPublisherServiceClient.BatchRejectChildPublishersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectChildPublishers</summary>
        public void BatchRejectChildPublishersResourceNames()
        {
            // Snippet: BatchRejectChildPublishers(NetworkName, IEnumerable<ChildPublisherName>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ChildPublisherName> names = new ChildPublisherName[]
            {
                ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
            };
            // Make the request
            BatchRejectChildPublishersResponse response = childPublisherServiceClient.BatchRejectChildPublishers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchRejectChildPublishersAsync</summary>
        public async Task BatchRejectChildPublishersResourceNamesAsync()
        {
            // Snippet: BatchRejectChildPublishersAsync(NetworkName, IEnumerable<ChildPublisherName>, CallSettings)
            // Additional: BatchRejectChildPublishersAsync(NetworkName, IEnumerable<ChildPublisherName>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ChildPublisherName> names = new ChildPublisherName[]
            {
                ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
            };
            // Make the request
            BatchRejectChildPublishersResponse response = await childPublisherServiceClient.BatchRejectChildPublishersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchWithdrawChildPublishers</summary>
        public void BatchWithdrawChildPublishersRequestObject()
        {
            // Snippet: BatchWithdrawChildPublishers(BatchWithdrawChildPublishersRequest, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            BatchWithdrawChildPublishersRequest request = new BatchWithdrawChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ChildPublisherNames =
                {
                    ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
                },
            };
            // Make the request
            BatchWithdrawChildPublishersResponse response = childPublisherServiceClient.BatchWithdrawChildPublishers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchWithdrawChildPublishersAsync</summary>
        public async Task BatchWithdrawChildPublishersRequestObjectAsync()
        {
            // Snippet: BatchWithdrawChildPublishersAsync(BatchWithdrawChildPublishersRequest, CallSettings)
            // Additional: BatchWithdrawChildPublishersAsync(BatchWithdrawChildPublishersRequest, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchWithdrawChildPublishersRequest request = new BatchWithdrawChildPublishersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ChildPublisherNames =
                {
                    ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
                },
            };
            // Make the request
            BatchWithdrawChildPublishersResponse response = await childPublisherServiceClient.BatchWithdrawChildPublishersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchWithdrawChildPublishers</summary>
        public void BatchWithdrawChildPublishers()
        {
            // Snippet: BatchWithdrawChildPublishers(string, IEnumerable<string>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/childPublishers/[CHILD_PUBLISHER]",
            };
            // Make the request
            BatchWithdrawChildPublishersResponse response = childPublisherServiceClient.BatchWithdrawChildPublishers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchWithdrawChildPublishersAsync</summary>
        public async Task BatchWithdrawChildPublishersAsync()
        {
            // Snippet: BatchWithdrawChildPublishersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchWithdrawChildPublishersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/childPublishers/[CHILD_PUBLISHER]",
            };
            // Make the request
            BatchWithdrawChildPublishersResponse response = await childPublisherServiceClient.BatchWithdrawChildPublishersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchWithdrawChildPublishers</summary>
        public void BatchWithdrawChildPublishersResourceNames()
        {
            // Snippet: BatchWithdrawChildPublishers(NetworkName, IEnumerable<ChildPublisherName>, CallSettings)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = ChildPublisherServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ChildPublisherName> names = new ChildPublisherName[]
            {
                ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
            };
            // Make the request
            BatchWithdrawChildPublishersResponse response = childPublisherServiceClient.BatchWithdrawChildPublishers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchWithdrawChildPublishersAsync</summary>
        public async Task BatchWithdrawChildPublishersResourceNamesAsync()
        {
            // Snippet: BatchWithdrawChildPublishersAsync(NetworkName, IEnumerable<ChildPublisherName>, CallSettings)
            // Additional: BatchWithdrawChildPublishersAsync(NetworkName, IEnumerable<ChildPublisherName>, CancellationToken)
            // Create client
            ChildPublisherServiceClient childPublisherServiceClient = await ChildPublisherServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ChildPublisherName> names = new ChildPublisherName[]
            {
                ChildPublisherName.FromNetworkCodeChildPublisher("[NETWORK_CODE]", "[CHILD_PUBLISHER]"),
            };
            // Make the request
            BatchWithdrawChildPublishersResponse response = await childPublisherServiceClient.BatchWithdrawChildPublishersAsync(parent, names);
            // End snippet
        }
    }
}
