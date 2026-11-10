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
    public sealed class AllGeneratedYieldGroupServiceClientSnippets
    {
        /// <summary>Snippet for GetYieldGroup</summary>
        public void GetYieldGroupRequestObject()
        {
            // Snippet: GetYieldGroup(GetYieldGroupRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            GetYieldGroupRequest request = new GetYieldGroupRequest
            {
                YieldGroupName = YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
            };
            // Make the request
            YieldGroup response = yieldGroupServiceClient.GetYieldGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetYieldGroupAsync</summary>
        public async Task GetYieldGroupRequestObjectAsync()
        {
            // Snippet: GetYieldGroupAsync(GetYieldGroupRequest, CallSettings)
            // Additional: GetYieldGroupAsync(GetYieldGroupRequest, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetYieldGroupRequest request = new GetYieldGroupRequest
            {
                YieldGroupName = YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
            };
            // Make the request
            YieldGroup response = await yieldGroupServiceClient.GetYieldGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetYieldGroup</summary>
        public void GetYieldGroup()
        {
            // Snippet: GetYieldGroup(string, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/yieldGroups/[YIELD_GROUP]";
            // Make the request
            YieldGroup response = yieldGroupServiceClient.GetYieldGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetYieldGroupAsync</summary>
        public async Task GetYieldGroupAsync()
        {
            // Snippet: GetYieldGroupAsync(string, CallSettings)
            // Additional: GetYieldGroupAsync(string, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/yieldGroups/[YIELD_GROUP]";
            // Make the request
            YieldGroup response = await yieldGroupServiceClient.GetYieldGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetYieldGroup</summary>
        public void GetYieldGroupResourceNames()
        {
            // Snippet: GetYieldGroup(YieldGroupName, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            YieldGroupName name = YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]");
            // Make the request
            YieldGroup response = yieldGroupServiceClient.GetYieldGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetYieldGroupAsync</summary>
        public async Task GetYieldGroupResourceNamesAsync()
        {
            // Snippet: GetYieldGroupAsync(YieldGroupName, CallSettings)
            // Additional: GetYieldGroupAsync(YieldGroupName, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            YieldGroupName name = YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]");
            // Make the request
            YieldGroup response = await yieldGroupServiceClient.GetYieldGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListYieldGroups</summary>
        public void ListYieldGroupsRequestObject()
        {
            // Snippet: ListYieldGroups(ListYieldGroupsRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            ListYieldGroupsRequest request = new ListYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListYieldGroupsResponse, YieldGroup> response = yieldGroupServiceClient.ListYieldGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (YieldGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListYieldGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldGroupsAsync</summary>
        public async Task ListYieldGroupsRequestObjectAsync()
        {
            // Snippet: ListYieldGroupsAsync(ListYieldGroupsRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListYieldGroupsRequest request = new ListYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListYieldGroupsResponse, YieldGroup> response = yieldGroupServiceClient.ListYieldGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (YieldGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListYieldGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldGroups</summary>
        public void ListYieldGroups()
        {
            // Snippet: ListYieldGroups(string, string, int?, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListYieldGroupsResponse, YieldGroup> response = yieldGroupServiceClient.ListYieldGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (YieldGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListYieldGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldGroupsAsync</summary>
        public async Task ListYieldGroupsAsync()
        {
            // Snippet: ListYieldGroupsAsync(string, string, int?, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListYieldGroupsResponse, YieldGroup> response = yieldGroupServiceClient.ListYieldGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (YieldGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListYieldGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldGroups</summary>
        public void ListYieldGroupsResourceNames()
        {
            // Snippet: ListYieldGroups(NetworkName, string, int?, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListYieldGroupsResponse, YieldGroup> response = yieldGroupServiceClient.ListYieldGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (YieldGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListYieldGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListYieldGroupsAsync</summary>
        public async Task ListYieldGroupsResourceNamesAsync()
        {
            // Snippet: ListYieldGroupsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListYieldGroupsResponse, YieldGroup> response = yieldGroupServiceClient.ListYieldGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (YieldGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListYieldGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (YieldGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<YieldGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (YieldGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateYieldGroup</summary>
        public void CreateYieldGroupRequestObject()
        {
            // Snippet: CreateYieldGroup(CreateYieldGroupRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            CreateYieldGroupRequest request = new CreateYieldGroupRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                YieldGroup = new YieldGroup(),
            };
            // Make the request
            YieldGroup response = yieldGroupServiceClient.CreateYieldGroup(request);
            // End snippet
        }

        /// <summary>Snippet for CreateYieldGroupAsync</summary>
        public async Task CreateYieldGroupRequestObjectAsync()
        {
            // Snippet: CreateYieldGroupAsync(CreateYieldGroupRequest, CallSettings)
            // Additional: CreateYieldGroupAsync(CreateYieldGroupRequest, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateYieldGroupRequest request = new CreateYieldGroupRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                YieldGroup = new YieldGroup(),
            };
            // Make the request
            YieldGroup response = await yieldGroupServiceClient.CreateYieldGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateYieldGroup</summary>
        public void CreateYieldGroup()
        {
            // Snippet: CreateYieldGroup(string, YieldGroup, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            YieldGroup yieldGroup = new YieldGroup();
            // Make the request
            YieldGroup response = yieldGroupServiceClient.CreateYieldGroup(parent, yieldGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateYieldGroupAsync</summary>
        public async Task CreateYieldGroupAsync()
        {
            // Snippet: CreateYieldGroupAsync(string, YieldGroup, CallSettings)
            // Additional: CreateYieldGroupAsync(string, YieldGroup, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            YieldGroup yieldGroup = new YieldGroup();
            // Make the request
            YieldGroup response = await yieldGroupServiceClient.CreateYieldGroupAsync(parent, yieldGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateYieldGroup</summary>
        public void CreateYieldGroupResourceNames()
        {
            // Snippet: CreateYieldGroup(NetworkName, YieldGroup, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            YieldGroup yieldGroup = new YieldGroup();
            // Make the request
            YieldGroup response = yieldGroupServiceClient.CreateYieldGroup(parent, yieldGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateYieldGroupAsync</summary>
        public async Task CreateYieldGroupResourceNamesAsync()
        {
            // Snippet: CreateYieldGroupAsync(NetworkName, YieldGroup, CallSettings)
            // Additional: CreateYieldGroupAsync(NetworkName, YieldGroup, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            YieldGroup yieldGroup = new YieldGroup();
            // Make the request
            YieldGroup response = await yieldGroupServiceClient.CreateYieldGroupAsync(parent, yieldGroup);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateYieldGroups</summary>
        public void BatchCreateYieldGroupsRequestObject()
        {
            // Snippet: BatchCreateYieldGroups(BatchCreateYieldGroupsRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateYieldGroupsRequest request = new BatchCreateYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateYieldGroupRequest(),
                },
            };
            // Make the request
            BatchCreateYieldGroupsResponse response = yieldGroupServiceClient.BatchCreateYieldGroups(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateYieldGroupsAsync</summary>
        public async Task BatchCreateYieldGroupsRequestObjectAsync()
        {
            // Snippet: BatchCreateYieldGroupsAsync(BatchCreateYieldGroupsRequest, CallSettings)
            // Additional: BatchCreateYieldGroupsAsync(BatchCreateYieldGroupsRequest, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateYieldGroupsRequest request = new BatchCreateYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateYieldGroupRequest(),
                },
            };
            // Make the request
            BatchCreateYieldGroupsResponse response = await yieldGroupServiceClient.BatchCreateYieldGroupsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateYieldGroups</summary>
        public void BatchCreateYieldGroups()
        {
            // Snippet: BatchCreateYieldGroups(string, IEnumerable<CreateYieldGroupRequest>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateYieldGroupRequest> requests = new CreateYieldGroupRequest[]
            {
                new CreateYieldGroupRequest(),
            };
            // Make the request
            BatchCreateYieldGroupsResponse response = yieldGroupServiceClient.BatchCreateYieldGroups(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateYieldGroupsAsync</summary>
        public async Task BatchCreateYieldGroupsAsync()
        {
            // Snippet: BatchCreateYieldGroupsAsync(string, IEnumerable<CreateYieldGroupRequest>, CallSettings)
            // Additional: BatchCreateYieldGroupsAsync(string, IEnumerable<CreateYieldGroupRequest>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateYieldGroupRequest> requests = new CreateYieldGroupRequest[]
            {
                new CreateYieldGroupRequest(),
            };
            // Make the request
            BatchCreateYieldGroupsResponse response = await yieldGroupServiceClient.BatchCreateYieldGroupsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateYieldGroups</summary>
        public void BatchCreateYieldGroupsResourceNames()
        {
            // Snippet: BatchCreateYieldGroups(NetworkName, IEnumerable<CreateYieldGroupRequest>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateYieldGroupRequest> requests = new CreateYieldGroupRequest[]
            {
                new CreateYieldGroupRequest(),
            };
            // Make the request
            BatchCreateYieldGroupsResponse response = yieldGroupServiceClient.BatchCreateYieldGroups(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateYieldGroupsAsync</summary>
        public async Task BatchCreateYieldGroupsResourceNamesAsync()
        {
            // Snippet: BatchCreateYieldGroupsAsync(NetworkName, IEnumerable<CreateYieldGroupRequest>, CallSettings)
            // Additional: BatchCreateYieldGroupsAsync(NetworkName, IEnumerable<CreateYieldGroupRequest>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateYieldGroupRequest> requests = new CreateYieldGroupRequest[]
            {
                new CreateYieldGroupRequest(),
            };
            // Make the request
            BatchCreateYieldGroupsResponse response = await yieldGroupServiceClient.BatchCreateYieldGroupsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateYieldGroup</summary>
        public void UpdateYieldGroupRequestObject()
        {
            // Snippet: UpdateYieldGroup(UpdateYieldGroupRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            UpdateYieldGroupRequest request = new UpdateYieldGroupRequest
            {
                YieldGroup = new YieldGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            YieldGroup response = yieldGroupServiceClient.UpdateYieldGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateYieldGroupAsync</summary>
        public async Task UpdateYieldGroupRequestObjectAsync()
        {
            // Snippet: UpdateYieldGroupAsync(UpdateYieldGroupRequest, CallSettings)
            // Additional: UpdateYieldGroupAsync(UpdateYieldGroupRequest, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateYieldGroupRequest request = new UpdateYieldGroupRequest
            {
                YieldGroup = new YieldGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            YieldGroup response = await yieldGroupServiceClient.UpdateYieldGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateYieldGroup</summary>
        public void UpdateYieldGroup()
        {
            // Snippet: UpdateYieldGroup(YieldGroup, FieldMask, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            YieldGroup yieldGroup = new YieldGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            YieldGroup response = yieldGroupServiceClient.UpdateYieldGroup(yieldGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateYieldGroupAsync</summary>
        public async Task UpdateYieldGroupAsync()
        {
            // Snippet: UpdateYieldGroupAsync(YieldGroup, FieldMask, CallSettings)
            // Additional: UpdateYieldGroupAsync(YieldGroup, FieldMask, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            YieldGroup yieldGroup = new YieldGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            YieldGroup response = await yieldGroupServiceClient.UpdateYieldGroupAsync(yieldGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateYieldGroups</summary>
        public void BatchUpdateYieldGroupsRequestObject()
        {
            // Snippet: BatchUpdateYieldGroups(BatchUpdateYieldGroupsRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateYieldGroupsRequest request = new BatchUpdateYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateYieldGroupRequest(),
                },
            };
            // Make the request
            BatchUpdateYieldGroupsResponse response = yieldGroupServiceClient.BatchUpdateYieldGroups(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateYieldGroupsAsync</summary>
        public async Task BatchUpdateYieldGroupsRequestObjectAsync()
        {
            // Snippet: BatchUpdateYieldGroupsAsync(BatchUpdateYieldGroupsRequest, CallSettings)
            // Additional: BatchUpdateYieldGroupsAsync(BatchUpdateYieldGroupsRequest, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateYieldGroupsRequest request = new BatchUpdateYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateYieldGroupRequest(),
                },
            };
            // Make the request
            BatchUpdateYieldGroupsResponse response = await yieldGroupServiceClient.BatchUpdateYieldGroupsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateYieldGroups</summary>
        public void BatchUpdateYieldGroups()
        {
            // Snippet: BatchUpdateYieldGroups(string, IEnumerable<UpdateYieldGroupRequest>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateYieldGroupRequest> requests = new UpdateYieldGroupRequest[]
            {
                new UpdateYieldGroupRequest(),
            };
            // Make the request
            BatchUpdateYieldGroupsResponse response = yieldGroupServiceClient.BatchUpdateYieldGroups(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateYieldGroupsAsync</summary>
        public async Task BatchUpdateYieldGroupsAsync()
        {
            // Snippet: BatchUpdateYieldGroupsAsync(string, IEnumerable<UpdateYieldGroupRequest>, CallSettings)
            // Additional: BatchUpdateYieldGroupsAsync(string, IEnumerable<UpdateYieldGroupRequest>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateYieldGroupRequest> requests = new UpdateYieldGroupRequest[]
            {
                new UpdateYieldGroupRequest(),
            };
            // Make the request
            BatchUpdateYieldGroupsResponse response = await yieldGroupServiceClient.BatchUpdateYieldGroupsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateYieldGroups</summary>
        public void BatchUpdateYieldGroupsResourceNames()
        {
            // Snippet: BatchUpdateYieldGroups(NetworkName, IEnumerable<UpdateYieldGroupRequest>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateYieldGroupRequest> requests = new UpdateYieldGroupRequest[]
            {
                new UpdateYieldGroupRequest(),
            };
            // Make the request
            BatchUpdateYieldGroupsResponse response = yieldGroupServiceClient.BatchUpdateYieldGroups(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateYieldGroupsAsync</summary>
        public async Task BatchUpdateYieldGroupsResourceNamesAsync()
        {
            // Snippet: BatchUpdateYieldGroupsAsync(NetworkName, IEnumerable<UpdateYieldGroupRequest>, CallSettings)
            // Additional: BatchUpdateYieldGroupsAsync(NetworkName, IEnumerable<UpdateYieldGroupRequest>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateYieldGroupRequest> requests = new UpdateYieldGroupRequest[]
            {
                new UpdateYieldGroupRequest(),
            };
            // Make the request
            BatchUpdateYieldGroupsResponse response = await yieldGroupServiceClient.BatchUpdateYieldGroupsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateYieldGroups</summary>
        public void BatchActivateYieldGroupsRequestObject()
        {
            // Snippet: BatchActivateYieldGroups(BatchActivateYieldGroupsRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateYieldGroupsRequest request = new BatchActivateYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                YieldGroupNames =
                {
                    YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
                },
            };
            // Make the request
            BatchActivateYieldGroupsResponse response = yieldGroupServiceClient.BatchActivateYieldGroups(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateYieldGroupsAsync</summary>
        public async Task BatchActivateYieldGroupsRequestObjectAsync()
        {
            // Snippet: BatchActivateYieldGroupsAsync(BatchActivateYieldGroupsRequest, CallSettings)
            // Additional: BatchActivateYieldGroupsAsync(BatchActivateYieldGroupsRequest, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateYieldGroupsRequest request = new BatchActivateYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                YieldGroupNames =
                {
                    YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
                },
            };
            // Make the request
            BatchActivateYieldGroupsResponse response = await yieldGroupServiceClient.BatchActivateYieldGroupsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateYieldGroups</summary>
        public void BatchActivateYieldGroups()
        {
            // Snippet: BatchActivateYieldGroups(string, IEnumerable<string>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/yieldGroups/[YIELD_GROUP]",
            };
            // Make the request
            BatchActivateYieldGroupsResponse response = yieldGroupServiceClient.BatchActivateYieldGroups(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateYieldGroupsAsync</summary>
        public async Task BatchActivateYieldGroupsAsync()
        {
            // Snippet: BatchActivateYieldGroupsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateYieldGroupsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/yieldGroups/[YIELD_GROUP]",
            };
            // Make the request
            BatchActivateYieldGroupsResponse response = await yieldGroupServiceClient.BatchActivateYieldGroupsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateYieldGroups</summary>
        public void BatchActivateYieldGroupsResourceNames()
        {
            // Snippet: BatchActivateYieldGroups(NetworkName, IEnumerable<YieldGroupName>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<YieldGroupName> names = new YieldGroupName[]
            {
                YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
            };
            // Make the request
            BatchActivateYieldGroupsResponse response = yieldGroupServiceClient.BatchActivateYieldGroups(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateYieldGroupsAsync</summary>
        public async Task BatchActivateYieldGroupsResourceNamesAsync()
        {
            // Snippet: BatchActivateYieldGroupsAsync(NetworkName, IEnumerable<YieldGroupName>, CallSettings)
            // Additional: BatchActivateYieldGroupsAsync(NetworkName, IEnumerable<YieldGroupName>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<YieldGroupName> names = new YieldGroupName[]
            {
                YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
            };
            // Make the request
            BatchActivateYieldGroupsResponse response = await yieldGroupServiceClient.BatchActivateYieldGroupsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateYieldGroups</summary>
        public void BatchDeactivateYieldGroupsRequestObject()
        {
            // Snippet: BatchDeactivateYieldGroups(BatchDeactivateYieldGroupsRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateYieldGroupsRequest request = new BatchDeactivateYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                YieldGroupNames =
                {
                    YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
                },
            };
            // Make the request
            BatchDeactivateYieldGroupsResponse response = yieldGroupServiceClient.BatchDeactivateYieldGroups(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateYieldGroupsAsync</summary>
        public async Task BatchDeactivateYieldGroupsRequestObjectAsync()
        {
            // Snippet: BatchDeactivateYieldGroupsAsync(BatchDeactivateYieldGroupsRequest, CallSettings)
            // Additional: BatchDeactivateYieldGroupsAsync(BatchDeactivateYieldGroupsRequest, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateYieldGroupsRequest request = new BatchDeactivateYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                YieldGroupNames =
                {
                    YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
                },
            };
            // Make the request
            BatchDeactivateYieldGroupsResponse response = await yieldGroupServiceClient.BatchDeactivateYieldGroupsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateYieldGroups</summary>
        public void BatchDeactivateYieldGroups()
        {
            // Snippet: BatchDeactivateYieldGroups(string, IEnumerable<string>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/yieldGroups/[YIELD_GROUP]",
            };
            // Make the request
            BatchDeactivateYieldGroupsResponse response = yieldGroupServiceClient.BatchDeactivateYieldGroups(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateYieldGroupsAsync</summary>
        public async Task BatchDeactivateYieldGroupsAsync()
        {
            // Snippet: BatchDeactivateYieldGroupsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateYieldGroupsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/yieldGroups/[YIELD_GROUP]",
            };
            // Make the request
            BatchDeactivateYieldGroupsResponse response = await yieldGroupServiceClient.BatchDeactivateYieldGroupsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateYieldGroups</summary>
        public void BatchDeactivateYieldGroupsResourceNames()
        {
            // Snippet: BatchDeactivateYieldGroups(NetworkName, IEnumerable<YieldGroupName>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<YieldGroupName> names = new YieldGroupName[]
            {
                YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
            };
            // Make the request
            BatchDeactivateYieldGroupsResponse response = yieldGroupServiceClient.BatchDeactivateYieldGroups(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateYieldGroupsAsync</summary>
        public async Task BatchDeactivateYieldGroupsResourceNamesAsync()
        {
            // Snippet: BatchDeactivateYieldGroupsAsync(NetworkName, IEnumerable<YieldGroupName>, CallSettings)
            // Additional: BatchDeactivateYieldGroupsAsync(NetworkName, IEnumerable<YieldGroupName>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<YieldGroupName> names = new YieldGroupName[]
            {
                YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
            };
            // Make the request
            BatchDeactivateYieldGroupsResponse response = await yieldGroupServiceClient.BatchDeactivateYieldGroupsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveYieldGroups</summary>
        public void BatchArchiveYieldGroupsRequestObject()
        {
            // Snippet: BatchArchiveYieldGroups(BatchArchiveYieldGroupsRequest, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveYieldGroupsRequest request = new BatchArchiveYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                YieldGroupNames =
                {
                    YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
                },
            };
            // Make the request
            BatchArchiveYieldGroupsResponse response = yieldGroupServiceClient.BatchArchiveYieldGroups(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveYieldGroupsAsync</summary>
        public async Task BatchArchiveYieldGroupsRequestObjectAsync()
        {
            // Snippet: BatchArchiveYieldGroupsAsync(BatchArchiveYieldGroupsRequest, CallSettings)
            // Additional: BatchArchiveYieldGroupsAsync(BatchArchiveYieldGroupsRequest, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveYieldGroupsRequest request = new BatchArchiveYieldGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                YieldGroupNames =
                {
                    YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
                },
            };
            // Make the request
            BatchArchiveYieldGroupsResponse response = await yieldGroupServiceClient.BatchArchiveYieldGroupsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveYieldGroups</summary>
        public void BatchArchiveYieldGroups()
        {
            // Snippet: BatchArchiveYieldGroups(string, IEnumerable<string>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/yieldGroups/[YIELD_GROUP]",
            };
            // Make the request
            BatchArchiveYieldGroupsResponse response = yieldGroupServiceClient.BatchArchiveYieldGroups(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveYieldGroupsAsync</summary>
        public async Task BatchArchiveYieldGroupsAsync()
        {
            // Snippet: BatchArchiveYieldGroupsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveYieldGroupsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/yieldGroups/[YIELD_GROUP]",
            };
            // Make the request
            BatchArchiveYieldGroupsResponse response = await yieldGroupServiceClient.BatchArchiveYieldGroupsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveYieldGroups</summary>
        public void BatchArchiveYieldGroupsResourceNames()
        {
            // Snippet: BatchArchiveYieldGroups(NetworkName, IEnumerable<YieldGroupName>, CallSettings)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = YieldGroupServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<YieldGroupName> names = new YieldGroupName[]
            {
                YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
            };
            // Make the request
            BatchArchiveYieldGroupsResponse response = yieldGroupServiceClient.BatchArchiveYieldGroups(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveYieldGroupsAsync</summary>
        public async Task BatchArchiveYieldGroupsResourceNamesAsync()
        {
            // Snippet: BatchArchiveYieldGroupsAsync(NetworkName, IEnumerable<YieldGroupName>, CallSettings)
            // Additional: BatchArchiveYieldGroupsAsync(NetworkName, IEnumerable<YieldGroupName>, CancellationToken)
            // Create client
            YieldGroupServiceClient yieldGroupServiceClient = await YieldGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<YieldGroupName> names = new YieldGroupName[]
            {
                YieldGroupName.FromNetworkCodeYieldGroup("[NETWORK_CODE]", "[YIELD_GROUP]"),
            };
            // Make the request
            BatchArchiveYieldGroupsResponse response = await yieldGroupServiceClient.BatchArchiveYieldGroupsAsync(parent, names);
            // End snippet
        }
    }
}
