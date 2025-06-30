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
    public sealed class AllGeneratedBandwidthGroupServiceClientSnippets
    {
        /// <summary>Snippet for GetBandwidthGroup</summary>
        public void GetBandwidthGroupRequestObject()
        {
            // Snippet: GetBandwidthGroup(GetBandwidthGroupRequest, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = BandwidthGroupServiceClient.Create();
            // Initialize request argument(s)
            GetBandwidthGroupRequest request = new GetBandwidthGroupRequest
            {
                BandwidthGroupName = BandwidthGroupName.FromNetworkCodeBandwidthGroup("[NETWORK_CODE]", "[BANDWIDTH_GROUP]"),
            };
            // Make the request
            BandwidthGroup response = bandwidthGroupServiceClient.GetBandwidthGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBandwidthGroupAsync</summary>
        public async Task GetBandwidthGroupRequestObjectAsync()
        {
            // Snippet: GetBandwidthGroupAsync(GetBandwidthGroupRequest, CallSettings)
            // Additional: GetBandwidthGroupAsync(GetBandwidthGroupRequest, CancellationToken)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = await BandwidthGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBandwidthGroupRequest request = new GetBandwidthGroupRequest
            {
                BandwidthGroupName = BandwidthGroupName.FromNetworkCodeBandwidthGroup("[NETWORK_CODE]", "[BANDWIDTH_GROUP]"),
            };
            // Make the request
            BandwidthGroup response = await bandwidthGroupServiceClient.GetBandwidthGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBandwidthGroup</summary>
        public void GetBandwidthGroup()
        {
            // Snippet: GetBandwidthGroup(string, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = BandwidthGroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/bandwidthGroups/[BANDWIDTH_GROUP]";
            // Make the request
            BandwidthGroup response = bandwidthGroupServiceClient.GetBandwidthGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBandwidthGroupAsync</summary>
        public async Task GetBandwidthGroupAsync()
        {
            // Snippet: GetBandwidthGroupAsync(string, CallSettings)
            // Additional: GetBandwidthGroupAsync(string, CancellationToken)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = await BandwidthGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/bandwidthGroups/[BANDWIDTH_GROUP]";
            // Make the request
            BandwidthGroup response = await bandwidthGroupServiceClient.GetBandwidthGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBandwidthGroup</summary>
        public void GetBandwidthGroupResourceNames()
        {
            // Snippet: GetBandwidthGroup(BandwidthGroupName, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = BandwidthGroupServiceClient.Create();
            // Initialize request argument(s)
            BandwidthGroupName name = BandwidthGroupName.FromNetworkCodeBandwidthGroup("[NETWORK_CODE]", "[BANDWIDTH_GROUP]");
            // Make the request
            BandwidthGroup response = bandwidthGroupServiceClient.GetBandwidthGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBandwidthGroupAsync</summary>
        public async Task GetBandwidthGroupResourceNamesAsync()
        {
            // Snippet: GetBandwidthGroupAsync(BandwidthGroupName, CallSettings)
            // Additional: GetBandwidthGroupAsync(BandwidthGroupName, CancellationToken)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = await BandwidthGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            BandwidthGroupName name = BandwidthGroupName.FromNetworkCodeBandwidthGroup("[NETWORK_CODE]", "[BANDWIDTH_GROUP]");
            // Make the request
            BandwidthGroup response = await bandwidthGroupServiceClient.GetBandwidthGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBandwidthGroups</summary>
        public void ListBandwidthGroupsRequestObject()
        {
            // Snippet: ListBandwidthGroups(ListBandwidthGroupsRequest, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = BandwidthGroupServiceClient.Create();
            // Initialize request argument(s)
            ListBandwidthGroupsRequest request = new ListBandwidthGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> response = bandwidthGroupServiceClient.ListBandwidthGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BandwidthGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBandwidthGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BandwidthGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BandwidthGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BandwidthGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBandwidthGroupsAsync</summary>
        public async Task ListBandwidthGroupsRequestObjectAsync()
        {
            // Snippet: ListBandwidthGroupsAsync(ListBandwidthGroupsRequest, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = await BandwidthGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBandwidthGroupsRequest request = new ListBandwidthGroupsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> response = bandwidthGroupServiceClient.ListBandwidthGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BandwidthGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBandwidthGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BandwidthGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BandwidthGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BandwidthGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBandwidthGroups</summary>
        public void ListBandwidthGroups()
        {
            // Snippet: ListBandwidthGroups(string, string, int?, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = BandwidthGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> response = bandwidthGroupServiceClient.ListBandwidthGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BandwidthGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBandwidthGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BandwidthGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BandwidthGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BandwidthGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBandwidthGroupsAsync</summary>
        public async Task ListBandwidthGroupsAsync()
        {
            // Snippet: ListBandwidthGroupsAsync(string, string, int?, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = await BandwidthGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> response = bandwidthGroupServiceClient.ListBandwidthGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BandwidthGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBandwidthGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BandwidthGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BandwidthGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BandwidthGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBandwidthGroups</summary>
        public void ListBandwidthGroupsResourceNames()
        {
            // Snippet: ListBandwidthGroups(NetworkName, string, int?, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = BandwidthGroupServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> response = bandwidthGroupServiceClient.ListBandwidthGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BandwidthGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBandwidthGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BandwidthGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BandwidthGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BandwidthGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBandwidthGroupsAsync</summary>
        public async Task ListBandwidthGroupsResourceNamesAsync()
        {
            // Snippet: ListBandwidthGroupsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            BandwidthGroupServiceClient bandwidthGroupServiceClient = await BandwidthGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> response = bandwidthGroupServiceClient.ListBandwidthGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BandwidthGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBandwidthGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BandwidthGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BandwidthGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BandwidthGroup item in singlePage)
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
