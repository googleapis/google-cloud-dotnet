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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
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

        /// <summary>Snippet for CreateAdUnit</summary>
        public void CreateAdUnitRequestObject()
        {
            // Snippet: CreateAdUnit(CreateAdUnitRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            CreateAdUnitRequest request = new CreateAdUnitRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdUnit = new AdUnit(),
            };
            // Make the request
            AdUnit response = adUnitServiceClient.CreateAdUnit(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdUnitAsync</summary>
        public async Task CreateAdUnitRequestObjectAsync()
        {
            // Snippet: CreateAdUnitAsync(CreateAdUnitRequest, CallSettings)
            // Additional: CreateAdUnitAsync(CreateAdUnitRequest, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAdUnitRequest request = new CreateAdUnitRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdUnit = new AdUnit(),
            };
            // Make the request
            AdUnit response = await adUnitServiceClient.CreateAdUnitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdUnit</summary>
        public void CreateAdUnit()
        {
            // Snippet: CreateAdUnit(string, AdUnit, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            AdUnit adUnit = new AdUnit();
            // Make the request
            AdUnit response = adUnitServiceClient.CreateAdUnit(parent, adUnit);
            // End snippet
        }

        /// <summary>Snippet for CreateAdUnitAsync</summary>
        public async Task CreateAdUnitAsync()
        {
            // Snippet: CreateAdUnitAsync(string, AdUnit, CallSettings)
            // Additional: CreateAdUnitAsync(string, AdUnit, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            AdUnit adUnit = new AdUnit();
            // Make the request
            AdUnit response = await adUnitServiceClient.CreateAdUnitAsync(parent, adUnit);
            // End snippet
        }

        /// <summary>Snippet for CreateAdUnit</summary>
        public void CreateAdUnitResourceNames()
        {
            // Snippet: CreateAdUnit(NetworkName, AdUnit, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            AdUnit adUnit = new AdUnit();
            // Make the request
            AdUnit response = adUnitServiceClient.CreateAdUnit(parent, adUnit);
            // End snippet
        }

        /// <summary>Snippet for CreateAdUnitAsync</summary>
        public async Task CreateAdUnitResourceNamesAsync()
        {
            // Snippet: CreateAdUnitAsync(NetworkName, AdUnit, CallSettings)
            // Additional: CreateAdUnitAsync(NetworkName, AdUnit, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            AdUnit adUnit = new AdUnit();
            // Make the request
            AdUnit response = await adUnitServiceClient.CreateAdUnitAsync(parent, adUnit);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdUnit</summary>
        public void UpdateAdUnitRequestObject()
        {
            // Snippet: UpdateAdUnit(UpdateAdUnitRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            UpdateAdUnitRequest request = new UpdateAdUnitRequest
            {
                AdUnit = new AdUnit(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdUnit response = adUnitServiceClient.UpdateAdUnit(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdUnitAsync</summary>
        public async Task UpdateAdUnitRequestObjectAsync()
        {
            // Snippet: UpdateAdUnitAsync(UpdateAdUnitRequest, CallSettings)
            // Additional: UpdateAdUnitAsync(UpdateAdUnitRequest, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAdUnitRequest request = new UpdateAdUnitRequest
            {
                AdUnit = new AdUnit(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdUnit response = await adUnitServiceClient.UpdateAdUnitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdUnit</summary>
        public void UpdateAdUnit()
        {
            // Snippet: UpdateAdUnit(AdUnit, FieldMask, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            AdUnit adUnit = new AdUnit();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdUnit response = adUnitServiceClient.UpdateAdUnit(adUnit, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdUnitAsync</summary>
        public async Task UpdateAdUnitAsync()
        {
            // Snippet: UpdateAdUnitAsync(AdUnit, FieldMask, CallSettings)
            // Additional: UpdateAdUnitAsync(AdUnit, FieldMask, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdUnit adUnit = new AdUnit();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdUnit response = await adUnitServiceClient.UpdateAdUnitAsync(adUnit, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdUnits</summary>
        public void BatchCreateAdUnitsRequestObject()
        {
            // Snippet: BatchCreateAdUnits(BatchCreateAdUnitsRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateAdUnitsRequest request = new BatchCreateAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateAdUnitRequest(),
                },
            };
            // Make the request
            BatchCreateAdUnitsResponse response = adUnitServiceClient.BatchCreateAdUnits(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdUnitsAsync</summary>
        public async Task BatchCreateAdUnitsRequestObjectAsync()
        {
            // Snippet: BatchCreateAdUnitsAsync(BatchCreateAdUnitsRequest, CallSettings)
            // Additional: BatchCreateAdUnitsAsync(BatchCreateAdUnitsRequest, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateAdUnitsRequest request = new BatchCreateAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateAdUnitRequest(),
                },
            };
            // Make the request
            BatchCreateAdUnitsResponse response = await adUnitServiceClient.BatchCreateAdUnitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdUnits</summary>
        public void BatchCreateAdUnits()
        {
            // Snippet: BatchCreateAdUnits(string, IEnumerable<CreateAdUnitRequest>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateAdUnitRequest> requests = new CreateAdUnitRequest[]
            {
                new CreateAdUnitRequest(),
            };
            // Make the request
            BatchCreateAdUnitsResponse response = adUnitServiceClient.BatchCreateAdUnits(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdUnitsAsync</summary>
        public async Task BatchCreateAdUnitsAsync()
        {
            // Snippet: BatchCreateAdUnitsAsync(string, IEnumerable<CreateAdUnitRequest>, CallSettings)
            // Additional: BatchCreateAdUnitsAsync(string, IEnumerable<CreateAdUnitRequest>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateAdUnitRequest> requests = new CreateAdUnitRequest[]
            {
                new CreateAdUnitRequest(),
            };
            // Make the request
            BatchCreateAdUnitsResponse response = await adUnitServiceClient.BatchCreateAdUnitsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdUnits</summary>
        public void BatchCreateAdUnitsResourceNames()
        {
            // Snippet: BatchCreateAdUnits(NetworkName, IEnumerable<CreateAdUnitRequest>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateAdUnitRequest> requests = new CreateAdUnitRequest[]
            {
                new CreateAdUnitRequest(),
            };
            // Make the request
            BatchCreateAdUnitsResponse response = adUnitServiceClient.BatchCreateAdUnits(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdUnitsAsync</summary>
        public async Task BatchCreateAdUnitsResourceNamesAsync()
        {
            // Snippet: BatchCreateAdUnitsAsync(NetworkName, IEnumerable<CreateAdUnitRequest>, CallSettings)
            // Additional: BatchCreateAdUnitsAsync(NetworkName, IEnumerable<CreateAdUnitRequest>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateAdUnitRequest> requests = new CreateAdUnitRequest[]
            {
                new CreateAdUnitRequest(),
            };
            // Make the request
            BatchCreateAdUnitsResponse response = await adUnitServiceClient.BatchCreateAdUnitsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdUnits</summary>
        public void BatchUpdateAdUnitsRequestObject()
        {
            // Snippet: BatchUpdateAdUnits(BatchUpdateAdUnitsRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateAdUnitsRequest request = new BatchUpdateAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateAdUnitRequest(),
                },
            };
            // Make the request
            BatchUpdateAdUnitsResponse response = adUnitServiceClient.BatchUpdateAdUnits(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdUnitsAsync</summary>
        public async Task BatchUpdateAdUnitsRequestObjectAsync()
        {
            // Snippet: BatchUpdateAdUnitsAsync(BatchUpdateAdUnitsRequest, CallSettings)
            // Additional: BatchUpdateAdUnitsAsync(BatchUpdateAdUnitsRequest, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateAdUnitsRequest request = new BatchUpdateAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateAdUnitRequest(),
                },
            };
            // Make the request
            BatchUpdateAdUnitsResponse response = await adUnitServiceClient.BatchUpdateAdUnitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdUnits</summary>
        public void BatchUpdateAdUnits()
        {
            // Snippet: BatchUpdateAdUnits(string, IEnumerable<UpdateAdUnitRequest>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateAdUnitRequest> requests = new UpdateAdUnitRequest[]
            {
                new UpdateAdUnitRequest(),
            };
            // Make the request
            BatchUpdateAdUnitsResponse response = adUnitServiceClient.BatchUpdateAdUnits(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdUnitsAsync</summary>
        public async Task BatchUpdateAdUnitsAsync()
        {
            // Snippet: BatchUpdateAdUnitsAsync(string, IEnumerable<UpdateAdUnitRequest>, CallSettings)
            // Additional: BatchUpdateAdUnitsAsync(string, IEnumerable<UpdateAdUnitRequest>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateAdUnitRequest> requests = new UpdateAdUnitRequest[]
            {
                new UpdateAdUnitRequest(),
            };
            // Make the request
            BatchUpdateAdUnitsResponse response = await adUnitServiceClient.BatchUpdateAdUnitsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdUnits</summary>
        public void BatchUpdateAdUnitsResourceNames()
        {
            // Snippet: BatchUpdateAdUnits(NetworkName, IEnumerable<UpdateAdUnitRequest>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateAdUnitRequest> requests = new UpdateAdUnitRequest[]
            {
                new UpdateAdUnitRequest(),
            };
            // Make the request
            BatchUpdateAdUnitsResponse response = adUnitServiceClient.BatchUpdateAdUnits(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdUnitsAsync</summary>
        public async Task BatchUpdateAdUnitsResourceNamesAsync()
        {
            // Snippet: BatchUpdateAdUnitsAsync(NetworkName, IEnumerable<UpdateAdUnitRequest>, CallSettings)
            // Additional: BatchUpdateAdUnitsAsync(NetworkName, IEnumerable<UpdateAdUnitRequest>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateAdUnitRequest> requests = new UpdateAdUnitRequest[]
            {
                new UpdateAdUnitRequest(),
            };
            // Make the request
            BatchUpdateAdUnitsResponse response = await adUnitServiceClient.BatchUpdateAdUnitsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdUnits</summary>
        public void BatchActivateAdUnitsRequestObject()
        {
            // Snippet: BatchActivateAdUnits(BatchActivateAdUnitsRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateAdUnitsRequest request = new BatchActivateAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdUnitNames =
                {
                    AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
                },
            };
            // Make the request
            BatchActivateAdUnitsResponse response = adUnitServiceClient.BatchActivateAdUnits(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdUnitsAsync</summary>
        public async Task BatchActivateAdUnitsRequestObjectAsync()
        {
            // Snippet: BatchActivateAdUnitsAsync(BatchActivateAdUnitsRequest, CallSettings)
            // Additional: BatchActivateAdUnitsAsync(BatchActivateAdUnitsRequest, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateAdUnitsRequest request = new BatchActivateAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdUnitNames =
                {
                    AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
                },
            };
            // Make the request
            BatchActivateAdUnitsResponse response = await adUnitServiceClient.BatchActivateAdUnitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdUnits</summary>
        public void BatchActivateAdUnits()
        {
            // Snippet: BatchActivateAdUnits(string, IEnumerable<string>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adUnits/[AD_UNIT]",
            };
            // Make the request
            BatchActivateAdUnitsResponse response = adUnitServiceClient.BatchActivateAdUnits(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdUnitsAsync</summary>
        public async Task BatchActivateAdUnitsAsync()
        {
            // Snippet: BatchActivateAdUnitsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateAdUnitsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adUnits/[AD_UNIT]",
            };
            // Make the request
            BatchActivateAdUnitsResponse response = await adUnitServiceClient.BatchActivateAdUnitsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdUnits</summary>
        public void BatchActivateAdUnitsResourceNames()
        {
            // Snippet: BatchActivateAdUnits(NetworkName, IEnumerable<AdUnitName>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdUnitName> names = new AdUnitName[]
            {
                AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
            };
            // Make the request
            BatchActivateAdUnitsResponse response = adUnitServiceClient.BatchActivateAdUnits(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdUnitsAsync</summary>
        public async Task BatchActivateAdUnitsResourceNamesAsync()
        {
            // Snippet: BatchActivateAdUnitsAsync(NetworkName, IEnumerable<AdUnitName>, CallSettings)
            // Additional: BatchActivateAdUnitsAsync(NetworkName, IEnumerable<AdUnitName>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdUnitName> names = new AdUnitName[]
            {
                AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
            };
            // Make the request
            BatchActivateAdUnitsResponse response = await adUnitServiceClient.BatchActivateAdUnitsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdUnits</summary>
        public void BatchDeactivateAdUnitsRequestObject()
        {
            // Snippet: BatchDeactivateAdUnits(BatchDeactivateAdUnitsRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateAdUnitsRequest request = new BatchDeactivateAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdUnitNames =
                {
                    AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
                },
            };
            // Make the request
            BatchDeactivateAdUnitsResponse response = adUnitServiceClient.BatchDeactivateAdUnits(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdUnitsAsync</summary>
        public async Task BatchDeactivateAdUnitsRequestObjectAsync()
        {
            // Snippet: BatchDeactivateAdUnitsAsync(BatchDeactivateAdUnitsRequest, CallSettings)
            // Additional: BatchDeactivateAdUnitsAsync(BatchDeactivateAdUnitsRequest, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateAdUnitsRequest request = new BatchDeactivateAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdUnitNames =
                {
                    AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
                },
            };
            // Make the request
            BatchDeactivateAdUnitsResponse response = await adUnitServiceClient.BatchDeactivateAdUnitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdUnits</summary>
        public void BatchDeactivateAdUnits()
        {
            // Snippet: BatchDeactivateAdUnits(string, IEnumerable<string>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adUnits/[AD_UNIT]",
            };
            // Make the request
            BatchDeactivateAdUnitsResponse response = adUnitServiceClient.BatchDeactivateAdUnits(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdUnitsAsync</summary>
        public async Task BatchDeactivateAdUnitsAsync()
        {
            // Snippet: BatchDeactivateAdUnitsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateAdUnitsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adUnits/[AD_UNIT]",
            };
            // Make the request
            BatchDeactivateAdUnitsResponse response = await adUnitServiceClient.BatchDeactivateAdUnitsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdUnits</summary>
        public void BatchDeactivateAdUnitsResourceNames()
        {
            // Snippet: BatchDeactivateAdUnits(NetworkName, IEnumerable<AdUnitName>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdUnitName> names = new AdUnitName[]
            {
                AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
            };
            // Make the request
            BatchDeactivateAdUnitsResponse response = adUnitServiceClient.BatchDeactivateAdUnits(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdUnitsAsync</summary>
        public async Task BatchDeactivateAdUnitsResourceNamesAsync()
        {
            // Snippet: BatchDeactivateAdUnitsAsync(NetworkName, IEnumerable<AdUnitName>, CallSettings)
            // Additional: BatchDeactivateAdUnitsAsync(NetworkName, IEnumerable<AdUnitName>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdUnitName> names = new AdUnitName[]
            {
                AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
            };
            // Make the request
            BatchDeactivateAdUnitsResponse response = await adUnitServiceClient.BatchDeactivateAdUnitsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveAdUnits</summary>
        public void BatchArchiveAdUnitsRequestObject()
        {
            // Snippet: BatchArchiveAdUnits(BatchArchiveAdUnitsRequest, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveAdUnitsRequest request = new BatchArchiveAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdUnitNames =
                {
                    AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
                },
            };
            // Make the request
            BatchArchiveAdUnitsResponse response = adUnitServiceClient.BatchArchiveAdUnits(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveAdUnitsAsync</summary>
        public async Task BatchArchiveAdUnitsRequestObjectAsync()
        {
            // Snippet: BatchArchiveAdUnitsAsync(BatchArchiveAdUnitsRequest, CallSettings)
            // Additional: BatchArchiveAdUnitsAsync(BatchArchiveAdUnitsRequest, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveAdUnitsRequest request = new BatchArchiveAdUnitsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdUnitNames =
                {
                    AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
                },
            };
            // Make the request
            BatchArchiveAdUnitsResponse response = await adUnitServiceClient.BatchArchiveAdUnitsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveAdUnits</summary>
        public void BatchArchiveAdUnits()
        {
            // Snippet: BatchArchiveAdUnits(string, IEnumerable<string>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adUnits/[AD_UNIT]",
            };
            // Make the request
            BatchArchiveAdUnitsResponse response = adUnitServiceClient.BatchArchiveAdUnits(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveAdUnitsAsync</summary>
        public async Task BatchArchiveAdUnitsAsync()
        {
            // Snippet: BatchArchiveAdUnitsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveAdUnitsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adUnits/[AD_UNIT]",
            };
            // Make the request
            BatchArchiveAdUnitsResponse response = await adUnitServiceClient.BatchArchiveAdUnitsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveAdUnits</summary>
        public void BatchArchiveAdUnitsResourceNames()
        {
            // Snippet: BatchArchiveAdUnits(NetworkName, IEnumerable<AdUnitName>, CallSettings)
            // Create client
            AdUnitServiceClient adUnitServiceClient = AdUnitServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdUnitName> names = new AdUnitName[]
            {
                AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
            };
            // Make the request
            BatchArchiveAdUnitsResponse response = adUnitServiceClient.BatchArchiveAdUnits(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveAdUnitsAsync</summary>
        public async Task BatchArchiveAdUnitsResourceNamesAsync()
        {
            // Snippet: BatchArchiveAdUnitsAsync(NetworkName, IEnumerable<AdUnitName>, CallSettings)
            // Additional: BatchArchiveAdUnitsAsync(NetworkName, IEnumerable<AdUnitName>, CancellationToken)
            // Create client
            AdUnitServiceClient adUnitServiceClient = await AdUnitServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdUnitName> names = new AdUnitName[]
            {
                AdUnitName.FromNetworkCodeAdUnit("[NETWORK_CODE]", "[AD_UNIT]"),
            };
            // Make the request
            BatchArchiveAdUnitsResponse response = await adUnitServiceClient.BatchArchiveAdUnitsAsync(parent, names);
            // End snippet
        }
    }
}
