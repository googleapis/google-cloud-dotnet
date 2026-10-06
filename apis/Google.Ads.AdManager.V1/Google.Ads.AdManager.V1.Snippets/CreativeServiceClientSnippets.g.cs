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
    public sealed class AllGeneratedCreativeServiceClientSnippets
    {
        /// <summary>Snippet for GetCreative</summary>
        public void GetCreativeRequestObject()
        {
            // Snippet: GetCreative(GetCreativeRequest, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            GetCreativeRequest request = new GetCreativeRequest
            {
                CreativeName = CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
            };
            // Make the request
            Creative response = creativeServiceClient.GetCreative(request);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeAsync</summary>
        public async Task GetCreativeRequestObjectAsync()
        {
            // Snippet: GetCreativeAsync(GetCreativeRequest, CallSettings)
            // Additional: GetCreativeAsync(GetCreativeRequest, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCreativeRequest request = new GetCreativeRequest
            {
                CreativeName = CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
            };
            // Make the request
            Creative response = await creativeServiceClient.GetCreativeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCreative</summary>
        public void GetCreative()
        {
            // Snippet: GetCreative(string, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/creatives/[CREATIVE]";
            // Make the request
            Creative response = creativeServiceClient.GetCreative(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeAsync</summary>
        public async Task GetCreativeAsync()
        {
            // Snippet: GetCreativeAsync(string, CallSettings)
            // Additional: GetCreativeAsync(string, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/creatives/[CREATIVE]";
            // Make the request
            Creative response = await creativeServiceClient.GetCreativeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreative</summary>
        public void GetCreativeResourceNames()
        {
            // Snippet: GetCreative(CreativeName, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            CreativeName name = CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]");
            // Make the request
            Creative response = creativeServiceClient.GetCreative(name);
            // End snippet
        }

        /// <summary>Snippet for GetCreativeAsync</summary>
        public async Task GetCreativeResourceNamesAsync()
        {
            // Snippet: GetCreativeAsync(CreativeName, CallSettings)
            // Additional: GetCreativeAsync(CreativeName, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreativeName name = CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]");
            // Make the request
            Creative response = await creativeServiceClient.GetCreativeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCreatives</summary>
        public void ListCreativesRequestObject()
        {
            // Snippet: ListCreatives(ListCreativesRequest, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            ListCreativesRequest request = new ListCreativesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCreativesResponse, Creative> response = creativeServiceClient.ListCreatives(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Creative item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Creative item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Creative> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Creative item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativesAsync</summary>
        public async Task ListCreativesRequestObjectAsync()
        {
            // Snippet: ListCreativesAsync(ListCreativesRequest, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCreativesRequest request = new ListCreativesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCreativesResponse, Creative> response = creativeServiceClient.ListCreativesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Creative item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Creative item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Creative> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Creative item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreatives</summary>
        public void ListCreatives()
        {
            // Snippet: ListCreatives(string, string, int?, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCreativesResponse, Creative> response = creativeServiceClient.ListCreatives(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Creative item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Creative item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Creative> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Creative item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativesAsync</summary>
        public async Task ListCreativesAsync()
        {
            // Snippet: ListCreativesAsync(string, string, int?, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCreativesResponse, Creative> response = creativeServiceClient.ListCreativesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Creative item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Creative item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Creative> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Creative item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreatives</summary>
        public void ListCreativesResourceNames()
        {
            // Snippet: ListCreatives(NetworkName, string, int?, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCreativesResponse, Creative> response = creativeServiceClient.ListCreatives(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Creative item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCreativesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Creative item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Creative> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Creative item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCreativesAsync</summary>
        public async Task ListCreativesResourceNamesAsync()
        {
            // Snippet: ListCreativesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCreativesResponse, Creative> response = creativeServiceClient.ListCreativesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Creative item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCreativesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Creative item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Creative> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Creative item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreatives</summary>
        public void BatchActivateCreativesRequestObject()
        {
            // Snippet: BatchActivateCreatives(BatchActivateCreativesRequest, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateCreativesRequest request = new BatchActivateCreativesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeNames =
                {
                    CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
                },
            };
            // Make the request
            BatchActivateCreativesResponse response = creativeServiceClient.BatchActivateCreatives(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativesAsync</summary>
        public async Task BatchActivateCreativesRequestObjectAsync()
        {
            // Snippet: BatchActivateCreativesAsync(BatchActivateCreativesRequest, CallSettings)
            // Additional: BatchActivateCreativesAsync(BatchActivateCreativesRequest, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateCreativesRequest request = new BatchActivateCreativesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeNames =
                {
                    CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
                },
            };
            // Make the request
            BatchActivateCreativesResponse response = await creativeServiceClient.BatchActivateCreativesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreatives</summary>
        public void BatchActivateCreatives()
        {
            // Snippet: BatchActivateCreatives(string, IEnumerable<string>, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/creatives/[CREATIVE]",
            };
            // Make the request
            BatchActivateCreativesResponse response = creativeServiceClient.BatchActivateCreatives(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativesAsync</summary>
        public async Task BatchActivateCreativesAsync()
        {
            // Snippet: BatchActivateCreativesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateCreativesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/creatives/[CREATIVE]",
            };
            // Make the request
            BatchActivateCreativesResponse response = await creativeServiceClient.BatchActivateCreativesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreatives</summary>
        public void BatchActivateCreativesResourceNames()
        {
            // Snippet: BatchActivateCreatives(NetworkName, IEnumerable<CreativeName>, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreativeName> names = new CreativeName[]
            {
                CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
            };
            // Make the request
            BatchActivateCreativesResponse response = creativeServiceClient.BatchActivateCreatives(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCreativesAsync</summary>
        public async Task BatchActivateCreativesResourceNamesAsync()
        {
            // Snippet: BatchActivateCreativesAsync(NetworkName, IEnumerable<CreativeName>, CallSettings)
            // Additional: BatchActivateCreativesAsync(NetworkName, IEnumerable<CreativeName>, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreativeName> names = new CreativeName[]
            {
                CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
            };
            // Make the request
            BatchActivateCreativesResponse response = await creativeServiceClient.BatchActivateCreativesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreatives</summary>
        public void BatchDeactivateCreativesRequestObject()
        {
            // Snippet: BatchDeactivateCreatives(BatchDeactivateCreativesRequest, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateCreativesRequest request = new BatchDeactivateCreativesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeNames =
                {
                    CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
                },
            };
            // Make the request
            BatchDeactivateCreativesResponse response = creativeServiceClient.BatchDeactivateCreatives(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativesAsync</summary>
        public async Task BatchDeactivateCreativesRequestObjectAsync()
        {
            // Snippet: BatchDeactivateCreativesAsync(BatchDeactivateCreativesRequest, CallSettings)
            // Additional: BatchDeactivateCreativesAsync(BatchDeactivateCreativesRequest, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateCreativesRequest request = new BatchDeactivateCreativesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CreativeNames =
                {
                    CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
                },
            };
            // Make the request
            BatchDeactivateCreativesResponse response = await creativeServiceClient.BatchDeactivateCreativesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreatives</summary>
        public void BatchDeactivateCreatives()
        {
            // Snippet: BatchDeactivateCreatives(string, IEnumerable<string>, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/creatives/[CREATIVE]",
            };
            // Make the request
            BatchDeactivateCreativesResponse response = creativeServiceClient.BatchDeactivateCreatives(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativesAsync</summary>
        public async Task BatchDeactivateCreativesAsync()
        {
            // Snippet: BatchDeactivateCreativesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateCreativesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/creatives/[CREATIVE]",
            };
            // Make the request
            BatchDeactivateCreativesResponse response = await creativeServiceClient.BatchDeactivateCreativesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreatives</summary>
        public void BatchDeactivateCreativesResourceNames()
        {
            // Snippet: BatchDeactivateCreatives(NetworkName, IEnumerable<CreativeName>, CallSettings)
            // Create client
            CreativeServiceClient creativeServiceClient = CreativeServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreativeName> names = new CreativeName[]
            {
                CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
            };
            // Make the request
            BatchDeactivateCreativesResponse response = creativeServiceClient.BatchDeactivateCreatives(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCreativesAsync</summary>
        public async Task BatchDeactivateCreativesResourceNamesAsync()
        {
            // Snippet: BatchDeactivateCreativesAsync(NetworkName, IEnumerable<CreativeName>, CallSettings)
            // Additional: BatchDeactivateCreativesAsync(NetworkName, IEnumerable<CreativeName>, CancellationToken)
            // Create client
            CreativeServiceClient creativeServiceClient = await CreativeServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreativeName> names = new CreativeName[]
            {
                CreativeName.FromNetworkCodeCreative("[NETWORK_CODE]", "[CREATIVE]"),
            };
            // Make the request
            BatchDeactivateCreativesResponse response = await creativeServiceClient.BatchDeactivateCreativesAsync(parent, names);
            // End snippet
        }
    }
}
