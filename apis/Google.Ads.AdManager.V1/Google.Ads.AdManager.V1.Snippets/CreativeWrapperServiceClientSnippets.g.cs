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
    public sealed class AllGeneratedCreativeWrapperServiceClientSnippets
    {
        /// <summary>Snippet for GetCreativeWrapper</summary>
        public void GetCreativeWrapperRequestObject()
        {
            // Snippet: GetCreativeWrapper(GetCreativeWrapperRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            GetCreativeWrapperRequest request = new GetCreativeWrapperRequest
            {
                CreativeWrapperName = CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
            };
            // Make the request
            CreativeWrapper response = creativeWrapperServiceClient.GetCreativeWrapper(request);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeWrapperAsync</summary>
        public async Task GetCreativeWrapperRequestObjectAsync()
        {
            // Snippet: GetCreativeWrapperAsync(GetCreativeWrapperRequest, CallSettings)
            // Additional: GetCreativeWrapperAsync(GetCreativeWrapperRequest, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCreativeWrapperRequest request = new GetCreativeWrapperRequest
            {
                CreativeWrapperName = CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
            };
            // Make the request
            CreativeWrapper response = await creativeWrapperServiceClient.GetCreativeWrapperAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeWrapper</summary>
        public void GetCreativeWrapper()
        {
            // Snippet: GetCreativeWrapper(string, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/creativeWrappers/[CREATIVE_WRAPPER]";
            // Make the request
            CreativeWrapper response = creativeWrapperServiceClient.GetCreativeWrapper(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeWrapperAsync</summary>
        public async Task GetCreativeWrapperAsync()
        {
            // Snippet: GetCreativeWrapperAsync(string, CallSettings)
            // Additional: GetCreativeWrapperAsync(string, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/creativeWrappers/[CREATIVE_WRAPPER]";
            // Make the request
            CreativeWrapper response = await creativeWrapperServiceClient.GetCreativeWrapperAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeWrapper</summary>
        public void GetCreativeWrapperResourceNames()
        {
            // Snippet: GetCreativeWrapper(CreativeWrapperName, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            CreativeWrapperName name = CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]");
            // Make the request
            CreativeWrapper response = creativeWrapperServiceClient.GetCreativeWrapper(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeWrapperAsync</summary>
        public async Task GetCreativeWrapperResourceNamesAsync()
        {
            // Snippet: GetCreativeWrapperAsync(CreativeWrapperName, CallSettings)
            // Additional: GetCreativeWrapperAsync(CreativeWrapperName, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreativeWrapperName name = CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]");
            // Make the request
            CreativeWrapper response = await creativeWrapperServiceClient.GetCreativeWrapperAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCreativeWrappers</summary>
        public void ListCreativeWrappersRequestObject()
        {
            // Snippet: ListCreativeWrappers(ListCreativeWrappersRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            ListCreativeWrappersRequest request = new ListCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCreativeWrappersResponse, CreativeWrapper> response = creativeWrapperServiceClient.ListCreativeWrappers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeWrapper item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeWrappersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeWrapper item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeWrapper> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeWrapper item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeWrappersAsync</summary>
        public async Task ListCreativeWrappersRequestObjectAsync()
        {
            // Snippet: ListCreativeWrappersAsync(ListCreativeWrappersRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCreativeWrappersRequest request = new ListCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCreativeWrappersResponse, CreativeWrapper> response = creativeWrapperServiceClient.ListCreativeWrappersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CreativeWrapper item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativeWrappersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeWrapper item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeWrapper> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeWrapper item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeWrappers</summary>
        public void ListCreativeWrappers()
        {
            // Snippet: ListCreativeWrappers(string, string, int?, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCreativeWrappersResponse, CreativeWrapper> response = creativeWrapperServiceClient.ListCreativeWrappers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeWrapper item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeWrappersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeWrapper item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeWrapper> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeWrapper item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeWrappersAsync</summary>
        public async Task ListCreativeWrappersAsync()
        {
            // Snippet: ListCreativeWrappersAsync(string, string, int?, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCreativeWrappersResponse, CreativeWrapper> response = creativeWrapperServiceClient.ListCreativeWrappersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CreativeWrapper item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativeWrappersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeWrapper item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeWrapper> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeWrapper item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeWrappers</summary>
        public void ListCreativeWrappersResourceNames()
        {
            // Snippet: ListCreativeWrappers(NetworkName, string, int?, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCreativeWrappersResponse, CreativeWrapper> response = creativeWrapperServiceClient.ListCreativeWrappers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeWrapper item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeWrappersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeWrapper item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeWrapper> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeWrapper item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeWrappersAsync</summary>
        public async Task ListCreativeWrappersResourceNamesAsync()
        {
            // Snippet: ListCreativeWrappersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCreativeWrappersResponse, CreativeWrapper> response = creativeWrapperServiceClient.ListCreativeWrappersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CreativeWrapper item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativeWrappersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeWrapper item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeWrapper> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeWrapper item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeWrapper</summary>
        public void CreateCreativeWrapperRequestObject()
        {
            // Snippet: CreateCreativeWrapper(CreateCreativeWrapperRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            CreateCreativeWrapperRequest request = new CreateCreativeWrapperRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeWrapper = new CreativeWrapper(),
            };
            // Make the request
            CreativeWrapper response = creativeWrapperServiceClient.CreateCreativeWrapper(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeWrapperAsync</summary>
        public async Task CreateCreativeWrapperRequestObjectAsync()
        {
            // Snippet: CreateCreativeWrapperAsync(CreateCreativeWrapperRequest, CallSettings)
            // Additional: CreateCreativeWrapperAsync(CreateCreativeWrapperRequest, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCreativeWrapperRequest request = new CreateCreativeWrapperRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeWrapper = new CreativeWrapper(),
            };
            // Make the request
            CreativeWrapper response = await creativeWrapperServiceClient.CreateCreativeWrapperAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeWrapper</summary>
        public void CreateCreativeWrapper()
        {
            // Snippet: CreateCreativeWrapper(string, CreativeWrapper, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CreativeWrapper creativeWrapper = new CreativeWrapper();
            // Make the request
            CreativeWrapper response = creativeWrapperServiceClient.CreateCreativeWrapper(parent, creativeWrapper);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeWrapperAsync</summary>
        public async Task CreateCreativeWrapperAsync()
        {
            // Snippet: CreateCreativeWrapperAsync(string, CreativeWrapper, CallSettings)
            // Additional: CreateCreativeWrapperAsync(string, CreativeWrapper, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CreativeWrapper creativeWrapper = new CreativeWrapper();
            // Make the request
            CreativeWrapper response = await creativeWrapperServiceClient.CreateCreativeWrapperAsync(parent, creativeWrapper);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeWrapper</summary>
        public void CreateCreativeWrapperResourceNames()
        {
            // Snippet: CreateCreativeWrapper(NetworkName, CreativeWrapper, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CreativeWrapper creativeWrapper = new CreativeWrapper();
            // Make the request
            CreativeWrapper response = creativeWrapperServiceClient.CreateCreativeWrapper(parent, creativeWrapper);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeWrapperAsync</summary>
        public async Task CreateCreativeWrapperResourceNamesAsync()
        {
            // Snippet: CreateCreativeWrapperAsync(NetworkName, CreativeWrapper, CallSettings)
            // Additional: CreateCreativeWrapperAsync(NetworkName, CreativeWrapper, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CreativeWrapper creativeWrapper = new CreativeWrapper();
            // Make the request
            CreativeWrapper response = await creativeWrapperServiceClient.CreateCreativeWrapperAsync(parent, creativeWrapper);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCreativeWrappers</summary>
        public void BatchCreateCreativeWrappersRequestObject()
        {
            // Snippet: BatchCreateCreativeWrappers(BatchCreateCreativeWrappersRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateCreativeWrappersRequest request = new BatchCreateCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateCreativeWrapperRequest(),
                },
            };
            // Make the request
            BatchCreateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchCreateCreativeWrappers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCreativeWrappersAsync</summary>
        public async Task BatchCreateCreativeWrappersRequestObjectAsync()
        {
            // Snippet: BatchCreateCreativeWrappersAsync(BatchCreateCreativeWrappersRequest, CallSettings)
            // Additional: BatchCreateCreativeWrappersAsync(BatchCreateCreativeWrappersRequest, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateCreativeWrappersRequest request = new BatchCreateCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateCreativeWrapperRequest(),
                },
            };
            // Make the request
            BatchCreateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchCreateCreativeWrappersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCreativeWrappers</summary>
        public void BatchCreateCreativeWrappers()
        {
            // Snippet: BatchCreateCreativeWrappers(string, IEnumerable<CreateCreativeWrapperRequest>, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateCreativeWrapperRequest> requests = new CreateCreativeWrapperRequest[]
            {
                new CreateCreativeWrapperRequest(),
            };
            // Make the request
            BatchCreateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchCreateCreativeWrappers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCreativeWrappersAsync</summary>
        public async Task BatchCreateCreativeWrappersAsync()
        {
            // Snippet: BatchCreateCreativeWrappersAsync(string, IEnumerable<CreateCreativeWrapperRequest>, CallSettings)
            // Additional: BatchCreateCreativeWrappersAsync(string, IEnumerable<CreateCreativeWrapperRequest>, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateCreativeWrapperRequest> requests = new CreateCreativeWrapperRequest[]
            {
                new CreateCreativeWrapperRequest(),
            };
            // Make the request
            BatchCreateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchCreateCreativeWrappersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCreativeWrappers</summary>
        public void BatchCreateCreativeWrappersResourceNames()
        {
            // Snippet: BatchCreateCreativeWrappers(NetworkName, IEnumerable<CreateCreativeWrapperRequest>, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateCreativeWrapperRequest> requests = new CreateCreativeWrapperRequest[]
            {
                new CreateCreativeWrapperRequest(),
            };
            // Make the request
            BatchCreateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchCreateCreativeWrappers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCreativeWrappersAsync</summary>
        public async Task BatchCreateCreativeWrappersResourceNamesAsync()
        {
            // Snippet: BatchCreateCreativeWrappersAsync(NetworkName, IEnumerable<CreateCreativeWrapperRequest>, CallSettings)
            // Additional: BatchCreateCreativeWrappersAsync(NetworkName, IEnumerable<CreateCreativeWrapperRequest>, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateCreativeWrapperRequest> requests = new CreateCreativeWrapperRequest[]
            {
                new CreateCreativeWrapperRequest(),
            };
            // Make the request
            BatchCreateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchCreateCreativeWrappersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateCreativeWrapper</summary>
        public void UpdateCreativeWrapperRequestObject()
        {
            // Snippet: UpdateCreativeWrapper(UpdateCreativeWrapperRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            UpdateCreativeWrapperRequest request = new UpdateCreativeWrapperRequest
            {
                CreativeWrapper = new CreativeWrapper(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CreativeWrapper response = creativeWrapperServiceClient.UpdateCreativeWrapper(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCreativeWrapperAsync</summary>
        public async Task UpdateCreativeWrapperRequestObjectAsync()
        {
            // Snippet: UpdateCreativeWrapperAsync(UpdateCreativeWrapperRequest, CallSettings)
            // Additional: UpdateCreativeWrapperAsync(UpdateCreativeWrapperRequest, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCreativeWrapperRequest request = new UpdateCreativeWrapperRequest
            {
                CreativeWrapper = new CreativeWrapper(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CreativeWrapper response = await creativeWrapperServiceClient.UpdateCreativeWrapperAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCreativeWrapper</summary>
        public void UpdateCreativeWrapper()
        {
            // Snippet: UpdateCreativeWrapper(CreativeWrapper, FieldMask, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            CreativeWrapper creativeWrapper = new CreativeWrapper();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CreativeWrapper response = creativeWrapperServiceClient.UpdateCreativeWrapper(creativeWrapper, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCreativeWrapperAsync</summary>
        public async Task UpdateCreativeWrapperAsync()
        {
            // Snippet: UpdateCreativeWrapperAsync(CreativeWrapper, FieldMask, CallSettings)
            // Additional: UpdateCreativeWrapperAsync(CreativeWrapper, FieldMask, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreativeWrapper creativeWrapper = new CreativeWrapper();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CreativeWrapper response = await creativeWrapperServiceClient.UpdateCreativeWrapperAsync(creativeWrapper, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCreativeWrappers</summary>
        public void BatchUpdateCreativeWrappersRequestObject()
        {
            // Snippet: BatchUpdateCreativeWrappers(BatchUpdateCreativeWrappersRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateCreativeWrappersRequest request = new BatchUpdateCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateCreativeWrapperRequest(),
                },
            };
            // Make the request
            BatchUpdateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchUpdateCreativeWrappers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCreativeWrappersAsync</summary>
        public async Task BatchUpdateCreativeWrappersRequestObjectAsync()
        {
            // Snippet: BatchUpdateCreativeWrappersAsync(BatchUpdateCreativeWrappersRequest, CallSettings)
            // Additional: BatchUpdateCreativeWrappersAsync(BatchUpdateCreativeWrappersRequest, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateCreativeWrappersRequest request = new BatchUpdateCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateCreativeWrapperRequest(),
                },
            };
            // Make the request
            BatchUpdateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchUpdateCreativeWrappersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCreativeWrappers</summary>
        public void BatchUpdateCreativeWrappers()
        {
            // Snippet: BatchUpdateCreativeWrappers(string, IEnumerable<UpdateCreativeWrapperRequest>, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateCreativeWrapperRequest> requests = new UpdateCreativeWrapperRequest[]
            {
                new UpdateCreativeWrapperRequest(),
            };
            // Make the request
            BatchUpdateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchUpdateCreativeWrappers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCreativeWrappersAsync</summary>
        public async Task BatchUpdateCreativeWrappersAsync()
        {
            // Snippet: BatchUpdateCreativeWrappersAsync(string, IEnumerable<UpdateCreativeWrapperRequest>, CallSettings)
            // Additional: BatchUpdateCreativeWrappersAsync(string, IEnumerable<UpdateCreativeWrapperRequest>, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateCreativeWrapperRequest> requests = new UpdateCreativeWrapperRequest[]
            {
                new UpdateCreativeWrapperRequest(),
            };
            // Make the request
            BatchUpdateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchUpdateCreativeWrappersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCreativeWrappers</summary>
        public void BatchUpdateCreativeWrappersResourceNames()
        {
            // Snippet: BatchUpdateCreativeWrappers(NetworkName, IEnumerable<UpdateCreativeWrapperRequest>, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateCreativeWrapperRequest> requests = new UpdateCreativeWrapperRequest[]
            {
                new UpdateCreativeWrapperRequest(),
            };
            // Make the request
            BatchUpdateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchUpdateCreativeWrappers(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCreativeWrappersAsync</summary>
        public async Task BatchUpdateCreativeWrappersResourceNamesAsync()
        {
            // Snippet: BatchUpdateCreativeWrappersAsync(NetworkName, IEnumerable<UpdateCreativeWrapperRequest>, CallSettings)
            // Additional: BatchUpdateCreativeWrappersAsync(NetworkName, IEnumerable<UpdateCreativeWrapperRequest>, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateCreativeWrapperRequest> requests = new UpdateCreativeWrapperRequest[]
            {
                new UpdateCreativeWrapperRequest(),
            };
            // Make the request
            BatchUpdateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchUpdateCreativeWrappersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativeWrappers</summary>
        public void BatchActivateCreativeWrappersRequestObject()
        {
            // Snippet: BatchActivateCreativeWrappers(BatchActivateCreativeWrappersRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateCreativeWrappersRequest request = new BatchActivateCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeWrapperNames =
                {
                    CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
                },
            };
            // Make the request
            BatchActivateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchActivateCreativeWrappers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativeWrappersAsync</summary>
        public async Task BatchActivateCreativeWrappersRequestObjectAsync()
        {
            // Snippet: BatchActivateCreativeWrappersAsync(BatchActivateCreativeWrappersRequest, CallSettings)
            // Additional: BatchActivateCreativeWrappersAsync(BatchActivateCreativeWrappersRequest, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateCreativeWrappersRequest request = new BatchActivateCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeWrapperNames =
                {
                    CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
                },
            };
            // Make the request
            BatchActivateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchActivateCreativeWrappersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativeWrappers</summary>
        public void BatchActivateCreativeWrappers()
        {
            // Snippet: BatchActivateCreativeWrappers(string, IEnumerable<string>, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/creativeWrappers/[CREATIVE_WRAPPER]",
            };
            // Make the request
            BatchActivateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchActivateCreativeWrappers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativeWrappersAsync</summary>
        public async Task BatchActivateCreativeWrappersAsync()
        {
            // Snippet: BatchActivateCreativeWrappersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateCreativeWrappersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/creativeWrappers/[CREATIVE_WRAPPER]",
            };
            // Make the request
            BatchActivateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchActivateCreativeWrappersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativeWrappers</summary>
        public void BatchActivateCreativeWrappersResourceNames()
        {
            // Snippet: BatchActivateCreativeWrappers(NetworkName, IEnumerable<CreativeWrapperName>, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreativeWrapperName> names = new CreativeWrapperName[]
            {
                CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
            };
            // Make the request
            BatchActivateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchActivateCreativeWrappers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativeWrappersAsync</summary>
        public async Task BatchActivateCreativeWrappersResourceNamesAsync()
        {
            // Snippet: BatchActivateCreativeWrappersAsync(NetworkName, IEnumerable<CreativeWrapperName>, CallSettings)
            // Additional: BatchActivateCreativeWrappersAsync(NetworkName, IEnumerable<CreativeWrapperName>, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreativeWrapperName> names = new CreativeWrapperName[]
            {
                CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
            };
            // Make the request
            BatchActivateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchActivateCreativeWrappersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativeWrappers</summary>
        public void BatchDeactivateCreativeWrappersRequestObject()
        {
            // Snippet: BatchDeactivateCreativeWrappers(BatchDeactivateCreativeWrappersRequest, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateCreativeWrappersRequest request = new BatchDeactivateCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeWrapperNames =
                {
                    CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
                },
            };
            // Make the request
            BatchDeactivateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchDeactivateCreativeWrappers(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativeWrappersAsync</summary>
        public async Task BatchDeactivateCreativeWrappersRequestObjectAsync()
        {
            // Snippet: BatchDeactivateCreativeWrappersAsync(BatchDeactivateCreativeWrappersRequest, CallSettings)
            // Additional: BatchDeactivateCreativeWrappersAsync(BatchDeactivateCreativeWrappersRequest, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateCreativeWrappersRequest request = new BatchDeactivateCreativeWrappersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeWrapperNames =
                {
                    CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
                },
            };
            // Make the request
            BatchDeactivateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchDeactivateCreativeWrappersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativeWrappers</summary>
        public void BatchDeactivateCreativeWrappers()
        {
            // Snippet: BatchDeactivateCreativeWrappers(string, IEnumerable<string>, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/creativeWrappers/[CREATIVE_WRAPPER]",
            };
            // Make the request
            BatchDeactivateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchDeactivateCreativeWrappers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativeWrappersAsync</summary>
        public async Task BatchDeactivateCreativeWrappersAsync()
        {
            // Snippet: BatchDeactivateCreativeWrappersAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateCreativeWrappersAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/creativeWrappers/[CREATIVE_WRAPPER]",
            };
            // Make the request
            BatchDeactivateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchDeactivateCreativeWrappersAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativeWrappers</summary>
        public void BatchDeactivateCreativeWrappersResourceNames()
        {
            // Snippet: BatchDeactivateCreativeWrappers(NetworkName, IEnumerable<CreativeWrapperName>, CallSettings)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = CreativeWrapperServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreativeWrapperName> names = new CreativeWrapperName[]
            {
                CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
            };
            // Make the request
            BatchDeactivateCreativeWrappersResponse response = creativeWrapperServiceClient.BatchDeactivateCreativeWrappers(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativeWrappersAsync</summary>
        public async Task BatchDeactivateCreativeWrappersResourceNamesAsync()
        {
            // Snippet: BatchDeactivateCreativeWrappersAsync(NetworkName, IEnumerable<CreativeWrapperName>, CallSettings)
            // Additional: BatchDeactivateCreativeWrappersAsync(NetworkName, IEnumerable<CreativeWrapperName>, CancellationToken)
            // Create client
            CreativeWrapperServiceClient creativeWrapperServiceClient = await CreativeWrapperServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreativeWrapperName> names = new CreativeWrapperName[]
            {
                CreativeWrapperName.FromNetworkCodeCreativeWrapper("[NETWORK_CODE]", "[CREATIVE_WRAPPER]"),
            };
            // Make the request
            BatchDeactivateCreativeWrappersResponse response = await creativeWrapperServiceClient.BatchDeactivateCreativeWrappersAsync(parent, names);
            // End snippet
        }
    }
}
