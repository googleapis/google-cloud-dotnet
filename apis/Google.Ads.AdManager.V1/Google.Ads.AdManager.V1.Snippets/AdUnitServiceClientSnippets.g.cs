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
    public sealed class AllGeneratedAdUnitServiceClientSnippets
    {
        /// <summary>Snippet for GetAdUnit</summary>
        public void GetAdUnitRequestObject()
        {
            // Snippet: GetAdUnit(GetAdUnitRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            GetAdUnitRequest request = new GetAdUnitRequest
            {
                AdUnitName = AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
            };
            // Make the request
            AdUnit response = adUnitServiceClient.GetAdUnit(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdUnitAsync</summary>
        public async Task GetAdUnitRequestObjectAsync()
        {
            // Snippet: GetAdUnitAsync(GetAdUnitRequest, CallSettings)
            // Additional: GetAdUnitAsync(GetAdUnitRequest, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdUnitRequest request = new GetAdUnitRequest
            {
                AdUnitName = AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
            };
            // Make the request
            AdUnit response = await adUnitServiceClient.GetAdUnitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdUnit</summary>
        public void GetAdUnit()
        {
            // Snippet: GetAdUnit(string, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/adUnits/[AD_UNIT]";
            // Make the request
            AdUnit response = adUnitServiceClient.GetAdUnit(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdUnitAsync</summary>
        public async Task GetAdUnitAsync()
        {
            // Snippet: GetAdUnitAsync(string, CallSettings)
            // Additional: GetAdUnitAsync(string, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/adUnits/[AD_UNIT]";
            // Make the request
            AdUnit response = await adUnitServiceClient.GetAdUnitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdUnit</summary>
        public void GetAdUnitResourceNames()
        {
            // Snippet: GetAdUnit(AdUnitName, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            AdUnitName name = AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]");
            // Make the request
            AdUnit response = adUnitServiceClient.GetAdUnit(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdUnitAsync</summary>
        public async Task GetAdUnitResourceNamesAsync()
        {
            // Snippet: GetAdUnitAsync(AdUnitName, CallSettings)
            // Additional: GetAdUnitAsync(AdUnitName, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdUnitName name = AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]");
            // Make the request
            AdUnit response = await adUnitServiceClient.GetAdUnitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAdUnits</summary>
        public void ListAdUnitsRequestObject()
        {
            // Snippet: ListAdUnits(ListAdUnitsRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            ListAdUnitsRequest request = new ListAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListAdUnitsResponse, AdUnit> response = adUnitServiceClient.ListAdUnits(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitsAsync</summary>
        public async Task ListAdUnitsRequestObjectAsync()
        {
            // Snippet: ListAdUnitsAsync(ListAdUnitsRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdUnitsRequest request = new ListAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListAdUnitsResponse, AdUnit> response = adUnitServiceClient.ListAdUnitsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdUnit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdUnitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnits</summary>
        public void ListAdUnits()
        {
            // Snippet: ListAdUnits(string, string, int?, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListAdUnitsResponse, AdUnit> response = adUnitServiceClient.ListAdUnits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitsAsync</summary>
        public async Task ListAdUnitsAsync()
        {
            // Snippet: ListAdUnitsAsync(string, string, int?, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListAdUnitsResponse, AdUnit> response = adUnitServiceClient.ListAdUnitsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdUnit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdUnitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnits</summary>
        public void ListAdUnitsResourceNames()
        {
            // Snippet: ListAdUnits(NetworkName, string, int?, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListAdUnitsResponse, AdUnit> response = adUnitServiceClient.ListAdUnits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdUnit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdUnitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitsAsync</summary>
        public async Task ListAdUnitsResourceNamesAsync()
        {
            // Snippet: ListAdUnitsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListAdUnitsResponse, AdUnit> response = adUnitServiceClient.ListAdUnitsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdUnit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdUnitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitSizes</summary>
        public void ListAdUnitSizesRequestObject()
        {
            // Snippet: ListAdUnitSizes(ListAdUnitSizesRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            ListAdUnitSizesRequest request = new ListAdUnitSizesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListAdUnitSizesResponse, AdUnitSize> response = adUnitServiceClient.ListAdUnitSizes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdUnitSize item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdUnitSizesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnitSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnitSize> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnitSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitSizesAsync</summary>
        public async Task ListAdUnitSizesRequestObjectAsync()
        {
            // Snippet: ListAdUnitSizesAsync(ListAdUnitSizesRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdUnitSizesRequest request = new ListAdUnitSizesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListAdUnitSizesResponse, AdUnitSize> response = adUnitServiceClient.ListAdUnitSizesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdUnitSize item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdUnitSizesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnitSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnitSize> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnitSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitSizes</summary>
        public void ListAdUnitSizes()
        {
            // Snippet: ListAdUnitSizes(string, string, int?, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListAdUnitSizesResponse, AdUnitSize> response = adUnitServiceClient.ListAdUnitSizes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdUnitSize item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdUnitSizesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnitSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnitSize> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnitSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitSizesAsync</summary>
        public async Task ListAdUnitSizesAsync()
        {
            // Snippet: ListAdUnitSizesAsync(string, string, int?, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListAdUnitSizesResponse, AdUnitSize> response = adUnitServiceClient.ListAdUnitSizesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdUnitSize item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdUnitSizesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnitSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnitSize> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnitSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitSizes</summary>
        public void ListAdUnitSizesResourceNames()
        {
            // Snippet: ListAdUnitSizes(NetworkName, string, int?, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListAdUnitSizesResponse, AdUnitSize> response = adUnitServiceClient.ListAdUnitSizes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdUnitSize item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdUnitSizesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnitSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnitSize> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnitSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdUnitSizesAsync</summary>
        public async Task ListAdUnitSizesResourceNamesAsync()
        {
            // Snippet: ListAdUnitSizesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListAdUnitSizesResponse, AdUnitSize> response = adUnitServiceClient.ListAdUnitSizesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdUnitSize item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdUnitSizesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdUnitSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdUnitSize> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdUnitSize item in singlePage)
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
