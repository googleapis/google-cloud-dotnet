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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCreativeSetServiceClientSnippets
    {
        /// <summary>Snippet for GetCreativeSet</summary>
        public void GetCreativeSetRequestObject()
        {
            // Snippet: GetCreativeSet(GetCreativeSetRequest, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            GetCreativeSetRequest request = new GetCreativeSetRequest
            {
                CreativeSetName = CreativeSetName.FromNetworkCodeCreativeSet("[NETWORK_CODE]", "[CREATIVE_SET]"),
            };
            // Make the request
            CreativeSet response = creativeSetServiceClient.GetCreativeSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeSetAsync</summary>
        public async Task GetCreativeSetRequestObjectAsync()
        {
            // Snippet: GetCreativeSetAsync(GetCreativeSetRequest, CallSettings)
            // Additional: GetCreativeSetAsync(GetCreativeSetRequest, CancellationToken)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCreativeSetRequest request = new GetCreativeSetRequest
            {
                CreativeSetName = CreativeSetName.FromNetworkCodeCreativeSet("[NETWORK_CODE]", "[CREATIVE_SET]"),
            };
            // Make the request
            CreativeSet response = await creativeSetServiceClient.GetCreativeSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeSet</summary>
        public void GetCreativeSet()
        {
            // Snippet: GetCreativeSet(string, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/creativeSets/[CREATIVE_SET]";
            // Make the request
            CreativeSet response = creativeSetServiceClient.GetCreativeSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeSetAsync</summary>
        public async Task GetCreativeSetAsync()
        {
            // Snippet: GetCreativeSetAsync(string, CallSettings)
            // Additional: GetCreativeSetAsync(string, CancellationToken)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/creativeSets/[CREATIVE_SET]";
            // Make the request
            CreativeSet response = await creativeSetServiceClient.GetCreativeSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeSet</summary>
        public void GetCreativeSetResourceNames()
        {
            // Snippet: GetCreativeSet(CreativeSetName, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            CreativeSetName name = CreativeSetName.FromNetworkCodeCreativeSet("[NETWORK_CODE]", "[CREATIVE_SET]");
            // Make the request
            CreativeSet response = creativeSetServiceClient.GetCreativeSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeSetAsync</summary>
        public async Task GetCreativeSetResourceNamesAsync()
        {
            // Snippet: GetCreativeSetAsync(CreativeSetName, CallSettings)
            // Additional: GetCreativeSetAsync(CreativeSetName, CancellationToken)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreativeSetName name = CreativeSetName.FromNetworkCodeCreativeSet("[NETWORK_CODE]", "[CREATIVE_SET]");
            // Make the request
            CreativeSet response = await creativeSetServiceClient.GetCreativeSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCreativeSets</summary>
        public void ListCreativeSetsRequestObject()
        {
            // Snippet: ListCreativeSets(ListCreativeSetsRequest, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            ListCreativeSetsRequest request = new ListCreativeSetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCreativeSetsResponse, CreativeSet> response = creativeSetServiceClient.ListCreativeSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeSetsAsync</summary>
        public async Task ListCreativeSetsRequestObjectAsync()
        {
            // Snippet: ListCreativeSetsAsync(ListCreativeSetsRequest, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCreativeSetsRequest request = new ListCreativeSetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCreativeSetsResponse, CreativeSet> response = creativeSetServiceClient.ListCreativeSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CreativeSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativeSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeSets</summary>
        public void ListCreativeSets()
        {
            // Snippet: ListCreativeSets(string, string, int?, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCreativeSetsResponse, CreativeSet> response = creativeSetServiceClient.ListCreativeSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeSetsAsync</summary>
        public async Task ListCreativeSetsAsync()
        {
            // Snippet: ListCreativeSetsAsync(string, string, int?, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCreativeSetsResponse, CreativeSet> response = creativeSetServiceClient.ListCreativeSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CreativeSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativeSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeSets</summary>
        public void ListCreativeSetsResourceNames()
        {
            // Snippet: ListCreativeSets(NetworkName, string, int?, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCreativeSetsResponse, CreativeSet> response = creativeSetServiceClient.ListCreativeSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CreativeSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativeSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativeSetsAsync</summary>
        public async Task ListCreativeSetsResourceNamesAsync()
        {
            // Snippet: ListCreativeSetsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCreativeSetsResponse, CreativeSet> response = creativeSetServiceClient.ListCreativeSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CreativeSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativeSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CreativeSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CreativeSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CreativeSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeSet</summary>
        public void CreateCreativeSetRequestObject()
        {
            // Snippet: CreateCreativeSet(CreateCreativeSetRequest, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            CreateCreativeSetRequest request = new CreateCreativeSetRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeSet = new CreativeSet(),
            };
            // Make the request
            CreativeSet response = creativeSetServiceClient.CreateCreativeSet(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeSetAsync</summary>
        public async Task CreateCreativeSetRequestObjectAsync()
        {
            // Snippet: CreateCreativeSetAsync(CreateCreativeSetRequest, CallSettings)
            // Additional: CreateCreativeSetAsync(CreateCreativeSetRequest, CancellationToken)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCreativeSetRequest request = new CreateCreativeSetRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeSet = new CreativeSet(),
            };
            // Make the request
            CreativeSet response = await creativeSetServiceClient.CreateCreativeSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeSet</summary>
        public void CreateCreativeSet()
        {
            // Snippet: CreateCreativeSet(string, CreativeSet, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CreativeSet creativeSet = new CreativeSet();
            // Make the request
            CreativeSet response = creativeSetServiceClient.CreateCreativeSet(parent, creativeSet);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeSetAsync</summary>
        public async Task CreateCreativeSetAsync()
        {
            // Snippet: CreateCreativeSetAsync(string, CreativeSet, CallSettings)
            // Additional: CreateCreativeSetAsync(string, CreativeSet, CancellationToken)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CreativeSet creativeSet = new CreativeSet();
            // Make the request
            CreativeSet response = await creativeSetServiceClient.CreateCreativeSetAsync(parent, creativeSet);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeSet</summary>
        public void CreateCreativeSetResourceNames()
        {
            // Snippet: CreateCreativeSet(NetworkName, CreativeSet, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CreativeSet creativeSet = new CreativeSet();
            // Make the request
            CreativeSet response = creativeSetServiceClient.CreateCreativeSet(parent, creativeSet);
            // End snippet
        }

        /// <summary>Snippet for CreateCreativeSetAsync</summary>
        public async Task CreateCreativeSetResourceNamesAsync()
        {
            // Snippet: CreateCreativeSetAsync(NetworkName, CreativeSet, CallSettings)
            // Additional: CreateCreativeSetAsync(NetworkName, CreativeSet, CancellationToken)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CreativeSet creativeSet = new CreativeSet();
            // Make the request
            CreativeSet response = await creativeSetServiceClient.CreateCreativeSetAsync(parent, creativeSet);
            // End snippet
        }

        /// <summary>Snippet for UpdateCreativeSet</summary>
        public void UpdateCreativeSetRequestObject()
        {
            // Snippet: UpdateCreativeSet(UpdateCreativeSetRequest, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            UpdateCreativeSetRequest request = new UpdateCreativeSetRequest
            {
                CreativeSet = new CreativeSet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CreativeSet response = creativeSetServiceClient.UpdateCreativeSet(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCreativeSetAsync</summary>
        public async Task UpdateCreativeSetRequestObjectAsync()
        {
            // Snippet: UpdateCreativeSetAsync(UpdateCreativeSetRequest, CallSettings)
            // Additional: UpdateCreativeSetAsync(UpdateCreativeSetRequest, CancellationToken)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCreativeSetRequest request = new UpdateCreativeSetRequest
            {
                CreativeSet = new CreativeSet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CreativeSet response = await creativeSetServiceClient.UpdateCreativeSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCreativeSet</summary>
        public void UpdateCreativeSet()
        {
            // Snippet: UpdateCreativeSet(CreativeSet, FieldMask, CallSettings)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = CreativeSetServiceClient.Create();
            // Initialize request argument(s)
            CreativeSet creativeSet = new CreativeSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CreativeSet response = creativeSetServiceClient.UpdateCreativeSet(creativeSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCreativeSetAsync</summary>
        public async Task UpdateCreativeSetAsync()
        {
            // Snippet: UpdateCreativeSetAsync(CreativeSet, FieldMask, CallSettings)
            // Additional: UpdateCreativeSetAsync(CreativeSet, FieldMask, CancellationToken)
            // Create client
            CreativeSetServiceClient creativeSetServiceClient = await CreativeSetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreativeSet creativeSet = new CreativeSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CreativeSet response = await creativeSetServiceClient.UpdateCreativeSetAsync(creativeSet, updateMask);
            // End snippet
        }
    }
}
