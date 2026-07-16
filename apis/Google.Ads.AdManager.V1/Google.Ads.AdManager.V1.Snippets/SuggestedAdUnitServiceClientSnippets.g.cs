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
    public sealed class AllGeneratedSuggestedAdUnitServiceClientSnippets
    {
        /// <summary>Snippet for GetSuggestedAdUnit</summary>
        public void GetSuggestedAdUnitRequestObject()
        {
            // Snippet: GetSuggestedAdUnit(GetSuggestedAdUnitRequest, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            GetSuggestedAdUnitRequest request = new GetSuggestedAdUnitRequest
            {
                SuggestedAdUnitName = SuggestedAdUnitName.FromNetworkCodeSuggestedAdUnit("[NETWORK_CODE]", "[SUGGESTED_AD_UNIT]"),
            };
            // Make the request
            SuggestedAdUnit response = suggestedAdUnitServiceClient.GetSuggestedAdUnit(request);
            // End snippet
        }

        /// <summary>Snippet for GetSuggestedAdUnitAsync</summary>
        public async Task GetSuggestedAdUnitRequestObjectAsync()
        {
            // Snippet: GetSuggestedAdUnitAsync(GetSuggestedAdUnitRequest, CallSettings)
            // Additional: GetSuggestedAdUnitAsync(GetSuggestedAdUnitRequest, CancellationToken)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSuggestedAdUnitRequest request = new GetSuggestedAdUnitRequest
            {
                SuggestedAdUnitName = SuggestedAdUnitName.FromNetworkCodeSuggestedAdUnit("[NETWORK_CODE]", "[SUGGESTED_AD_UNIT]"),
            };
            // Make the request
            SuggestedAdUnit response = await suggestedAdUnitServiceClient.GetSuggestedAdUnitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSuggestedAdUnit</summary>
        public void GetSuggestedAdUnit()
        {
            // Snippet: GetSuggestedAdUnit(string, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/suggestedAdUnits/[SUGGESTED_AD_UNIT]";
            // Make the request
            SuggestedAdUnit response = suggestedAdUnitServiceClient.GetSuggestedAdUnit(name);
            // End snippet
        }

        /// <summary>Snippet for GetSuggestedAdUnitAsync</summary>
        public async Task GetSuggestedAdUnitAsync()
        {
            // Snippet: GetSuggestedAdUnitAsync(string, CallSettings)
            // Additional: GetSuggestedAdUnitAsync(string, CancellationToken)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/suggestedAdUnits/[SUGGESTED_AD_UNIT]";
            // Make the request
            SuggestedAdUnit response = await suggestedAdUnitServiceClient.GetSuggestedAdUnitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSuggestedAdUnit</summary>
        public void GetSuggestedAdUnitResourceNames()
        {
            // Snippet: GetSuggestedAdUnit(SuggestedAdUnitName, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            SuggestedAdUnitName name = SuggestedAdUnitName.FromNetworkCodeSuggestedAdUnit("[NETWORK_CODE]", "[SUGGESTED_AD_UNIT]");
            // Make the request
            SuggestedAdUnit response = suggestedAdUnitServiceClient.GetSuggestedAdUnit(name);
            // End snippet
        }

        /// <summary>Snippet for GetSuggestedAdUnitAsync</summary>
        public async Task GetSuggestedAdUnitResourceNamesAsync()
        {
            // Snippet: GetSuggestedAdUnitAsync(SuggestedAdUnitName, CallSettings)
            // Additional: GetSuggestedAdUnitAsync(SuggestedAdUnitName, CancellationToken)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            SuggestedAdUnitName name = SuggestedAdUnitName.FromNetworkCodeSuggestedAdUnit("[NETWORK_CODE]", "[SUGGESTED_AD_UNIT]");
            // Make the request
            SuggestedAdUnit response = await suggestedAdUnitServiceClient.GetSuggestedAdUnitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSuggestedAdUnits</summary>
        public void ListSuggestedAdUnitsRequestObject()
        {
            // Snippet: ListSuggestedAdUnits(ListSuggestedAdUnitsRequest, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            ListSuggestedAdUnitsRequest request = new ListSuggestedAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> response = suggestedAdUnitServiceClient.ListSuggestedAdUnits(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SuggestedAdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSuggestedAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SuggestedAdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SuggestedAdUnit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SuggestedAdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSuggestedAdUnitsAsync</summary>
        public async Task ListSuggestedAdUnitsRequestObjectAsync()
        {
            // Snippet: ListSuggestedAdUnitsAsync(ListSuggestedAdUnitsRequest, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSuggestedAdUnitsRequest request = new ListSuggestedAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> response = suggestedAdUnitServiceClient.ListSuggestedAdUnitsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SuggestedAdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSuggestedAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SuggestedAdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SuggestedAdUnit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SuggestedAdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSuggestedAdUnits</summary>
        public void ListSuggestedAdUnits()
        {
            // Snippet: ListSuggestedAdUnits(string, string, int?, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> response = suggestedAdUnitServiceClient.ListSuggestedAdUnits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SuggestedAdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSuggestedAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SuggestedAdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SuggestedAdUnit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SuggestedAdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSuggestedAdUnitsAsync</summary>
        public async Task ListSuggestedAdUnitsAsync()
        {
            // Snippet: ListSuggestedAdUnitsAsync(string, string, int?, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> response = suggestedAdUnitServiceClient.ListSuggestedAdUnitsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SuggestedAdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSuggestedAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SuggestedAdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SuggestedAdUnit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SuggestedAdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSuggestedAdUnits</summary>
        public void ListSuggestedAdUnitsResourceNames()
        {
            // Snippet: ListSuggestedAdUnits(NetworkName, string, int?, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> response = suggestedAdUnitServiceClient.ListSuggestedAdUnits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SuggestedAdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSuggestedAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SuggestedAdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SuggestedAdUnit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SuggestedAdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSuggestedAdUnitsAsync</summary>
        public async Task ListSuggestedAdUnitsResourceNamesAsync()
        {
            // Snippet: ListSuggestedAdUnitsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListSuggestedAdUnitsResponse, SuggestedAdUnit> response = suggestedAdUnitServiceClient.ListSuggestedAdUnitsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SuggestedAdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSuggestedAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SuggestedAdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SuggestedAdUnit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SuggestedAdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchApproveSuggestedAdUnits</summary>
        public void BatchApproveSuggestedAdUnitsRequestObject()
        {
            // Snippet: BatchApproveSuggestedAdUnits(BatchApproveSuggestedAdUnitsRequest, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            BatchApproveSuggestedAdUnitsRequest request = new BatchApproveSuggestedAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                SuggestedAdUnitNames =
                {
                    SuggestedAdUnitName.FromNetworkCodeSuggestedAdUnit("[NETWORK_CODE]", "[SUGGESTED_AD_UNIT]"),
                },
            };
            // Make the request
            BatchApproveSuggestedAdUnitsResponse response = suggestedAdUnitServiceClient.BatchApproveSuggestedAdUnits(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveSuggestedAdUnitsAsync</summary>
        public async Task BatchApproveSuggestedAdUnitsRequestObjectAsync()
        {
            // Snippet: BatchApproveSuggestedAdUnitsAsync(BatchApproveSuggestedAdUnitsRequest, CallSettings)
            // Additional: BatchApproveSuggestedAdUnitsAsync(BatchApproveSuggestedAdUnitsRequest, CancellationToken)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchApproveSuggestedAdUnitsRequest request = new BatchApproveSuggestedAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                SuggestedAdUnitNames =
                {
                    SuggestedAdUnitName.FromNetworkCodeSuggestedAdUnit("[NETWORK_CODE]", "[SUGGESTED_AD_UNIT]"),
                },
            };
            // Make the request
            BatchApproveSuggestedAdUnitsResponse response = await suggestedAdUnitServiceClient.BatchApproveSuggestedAdUnitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveSuggestedAdUnits</summary>
        public void BatchApproveSuggestedAdUnits()
        {
            // Snippet: BatchApproveSuggestedAdUnits(string, IEnumerable<string>, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/suggestedAdUnits/[SUGGESTED_AD_UNIT]",
            };
            // Make the request
            BatchApproveSuggestedAdUnitsResponse response = suggestedAdUnitServiceClient.BatchApproveSuggestedAdUnits(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveSuggestedAdUnitsAsync</summary>
        public async Task BatchApproveSuggestedAdUnitsAsync()
        {
            // Snippet: BatchApproveSuggestedAdUnitsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchApproveSuggestedAdUnitsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/suggestedAdUnits/[SUGGESTED_AD_UNIT]",
            };
            // Make the request
            BatchApproveSuggestedAdUnitsResponse response = await suggestedAdUnitServiceClient.BatchApproveSuggestedAdUnitsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveSuggestedAdUnits</summary>
        public void BatchApproveSuggestedAdUnitsResourceNames()
        {
            // Snippet: BatchApproveSuggestedAdUnits(NetworkName, IEnumerable<SuggestedAdUnitName>, CallSettings)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = SuggestedAdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<SuggestedAdUnitName> names = new SuggestedAdUnitName[]
            {
                SuggestedAdUnitName.FromNetworkCodeSuggestedAdUnit("[NETWORK_CODE]", "[SUGGESTED_AD_UNIT]"),
            };
            // Make the request
            BatchApproveSuggestedAdUnitsResponse response = suggestedAdUnitServiceClient.BatchApproveSuggestedAdUnits(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchApproveSuggestedAdUnitsAsync</summary>
        public async Task BatchApproveSuggestedAdUnitsResourceNamesAsync()
        {
            // Snippet: BatchApproveSuggestedAdUnitsAsync(NetworkName, IEnumerable<SuggestedAdUnitName>, CallSettings)
            // Additional: BatchApproveSuggestedAdUnitsAsync(NetworkName, IEnumerable<SuggestedAdUnitName>, CancellationToken)
            // Create client
            SuggestedAdUnitServiceClient suggestedAdUnitServiceClient = await SuggestedAdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<SuggestedAdUnitName> names = new SuggestedAdUnitName[]
            {
                SuggestedAdUnitName.FromNetworkCodeSuggestedAdUnit("[NETWORK_CODE]", "[SUGGESTED_AD_UNIT]"),
            };
            // Make the request
            BatchApproveSuggestedAdUnitsResponse response = await suggestedAdUnitServiceClient.BatchApproveSuggestedAdUnitsAsync(parent, names);
            // End snippet
        }
    }
}
