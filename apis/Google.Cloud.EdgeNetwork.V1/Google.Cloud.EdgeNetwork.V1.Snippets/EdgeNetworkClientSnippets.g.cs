// Copyright 2024 Google LLC
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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.EdgeNetwork.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEdgeNetworkClientSnippets
    {
        /// <summary>Snippet for InitializeZone</summary>
        public void InitializeZoneRequestObject()
        {
            // Snippet: InitializeZone(InitializeZoneRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            InitializeZoneRequest request = new InitializeZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
            };
            // Make the request
            InitializeZoneResponse response = edgeNetworkClient.InitializeZone(request);
            // End snippet
        }

        /// <summary>Snippet for InitializeZoneAsync</summary>
        public async Task InitializeZoneRequestObjectAsync()
        {
            // Snippet: InitializeZoneAsync(InitializeZoneRequest, CallSettings)
            // Additional: InitializeZoneAsync(InitializeZoneRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            InitializeZoneRequest request = new InitializeZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
            };
            // Make the request
            InitializeZoneResponse response = await edgeNetworkClient.InitializeZoneAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InitializeZone</summary>
        public void InitializeZone()
        {
            // Snippet: InitializeZone(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            InitializeZoneResponse response = edgeNetworkClient.InitializeZone(name);
            // End snippet
        }

        /// <summary>Snippet for InitializeZoneAsync</summary>
        public async Task InitializeZoneAsync()
        {
            // Snippet: InitializeZoneAsync(string, CallSettings)
            // Additional: InitializeZoneAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            InitializeZoneResponse response = await edgeNetworkClient.InitializeZoneAsync(name);
            // End snippet
        }

        /// <summary>Snippet for InitializeZone</summary>
        public void InitializeZoneResourceNames()
        {
            // Snippet: InitializeZone(ZoneName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            InitializeZoneResponse response = edgeNetworkClient.InitializeZone(name);
            // End snippet
        }

        /// <summary>Snippet for InitializeZoneAsync</summary>
        public async Task InitializeZoneResourceNamesAsync()
        {
            // Snippet: InitializeZoneAsync(ZoneName, CallSettings)
            // Additional: InitializeZoneAsync(ZoneName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            InitializeZoneResponse response = await edgeNetworkClient.InitializeZoneAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZonesRequestObject()
        {
            // Snippet: ListZones(ListZonesRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListZonesRequest request = new ListZonesRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListZonesResponse, Zone> response = edgeNetworkClient.ListZones(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListZonesResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesRequestObjectAsync()
        {
            // Snippet: ListZonesAsync(ListZonesRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListZonesRequest request = new ListZonesRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = edgeNetworkClient.ListZonesAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZones()
        {
            // Snippet: ListZones(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListZonesResponse, Zone> response = edgeNetworkClient.ListZones(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListZonesResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesAsync()
        {
            // Snippet: ListZonesAsync(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = edgeNetworkClient.ListZonesAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZonesResourceNames()
        {
            // Snippet: ListZones(LocationName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListZonesResponse, Zone> response = edgeNetworkClient.ListZones(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListZonesResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesResourceNamesAsync()
        {
            // Snippet: ListZonesAsync(LocationName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = edgeNetworkClient.ListZonesAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZoneRequestObject()
        {
            // Snippet: GetZone(GetZoneRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GetZoneRequest request = new GetZoneRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Zone response = edgeNetworkClient.GetZone(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneRequestObjectAsync()
        {
            // Snippet: GetZoneAsync(GetZoneRequest, CallSettings)
            // Additional: GetZoneAsync(GetZoneRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GetZoneRequest request = new GetZoneRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Zone response = await edgeNetworkClient.GetZoneAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZone()
        {
            // Snippet: GetZone(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
#pragma warning disable CS0612
            Zone response = edgeNetworkClient.GetZone(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneAsync()
        {
            // Snippet: GetZoneAsync(string, CallSettings)
            // Additional: GetZoneAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
#pragma warning disable CS0612
            Zone response = await edgeNetworkClient.GetZoneAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZoneResourceNames()
        {
            // Snippet: GetZone(ZoneName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
#pragma warning disable CS0612
            Zone response = edgeNetworkClient.GetZone(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneResourceNamesAsync()
        {
            // Snippet: GetZoneAsync(ZoneName, CallSettings)
            // Additional: GetZoneAsync(ZoneName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
#pragma warning disable CS0612
            Zone response = await edgeNetworkClient.GetZoneAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworksRequestObject()
        {
            // Snippet: ListNetworks(ListNetworksRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = edgeNetworkClient.ListNetworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksRequestObjectAsync()
        {
            // Snippet: ListNetworksAsync(ListNetworksRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworksRequest request = new ListNetworksRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = edgeNetworkClient.ListNetworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworks()
        {
            // Snippet: ListNetworks(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = edgeNetworkClient.ListNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksAsync()
        {
            // Snippet: ListNetworksAsync(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = edgeNetworkClient.ListNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworks</summary>
        public void ListNetworksResourceNames()
        {
            // Snippet: ListNetworks(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedEnumerable<ListNetworksResponse, Network> response = edgeNetworkClient.ListNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Network item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNetworksAsync</summary>
        public async Task ListNetworksResourceNamesAsync()
        {
            // Snippet: ListNetworksAsync(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<ListNetworksResponse, Network> response = edgeNetworkClient.ListNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Network item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Network item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Network> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Network item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetworkRequestObject()
        {
            // Snippet: GetNetwork(GetNetworkRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]"),
            };
            // Make the request
            Network response = edgeNetworkClient.GetNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkRequestObjectAsync()
        {
            // Snippet: GetNetworkAsync(GetNetworkRequest, CallSettings)
            // Additional: GetNetworkAsync(GetNetworkRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkRequest request = new GetNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]"),
            };
            // Make the request
            Network response = await edgeNetworkClient.GetNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetwork()
        {
            // Snippet: GetNetwork(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/networks/[NETWORK]";
            // Make the request
            Network response = edgeNetworkClient.GetNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkAsync()
        {
            // Snippet: GetNetworkAsync(string, CallSettings)
            // Additional: GetNetworkAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/networks/[NETWORK]";
            // Make the request
            Network response = await edgeNetworkClient.GetNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetwork</summary>
        public void GetNetworkResourceNames()
        {
            // Snippet: GetNetwork(NetworkName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]");
            // Make the request
            Network response = edgeNetworkClient.GetNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetNetworkAsync</summary>
        public async Task GetNetworkResourceNamesAsync()
        {
            // Snippet: GetNetworkAsync(NetworkName, CallSettings)
            // Additional: GetNetworkAsync(NetworkName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]");
            // Make the request
            Network response = await edgeNetworkClient.GetNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseNetwork</summary>
        public void DiagnoseNetworkRequestObject()
        {
            // Snippet: DiagnoseNetwork(DiagnoseNetworkRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            DiagnoseNetworkRequest request = new DiagnoseNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]"),
            };
            // Make the request
            DiagnoseNetworkResponse response = edgeNetworkClient.DiagnoseNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseNetworkAsync</summary>
        public async Task DiagnoseNetworkRequestObjectAsync()
        {
            // Snippet: DiagnoseNetworkAsync(DiagnoseNetworkRequest, CallSettings)
            // Additional: DiagnoseNetworkAsync(DiagnoseNetworkRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            DiagnoseNetworkRequest request = new DiagnoseNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]"),
            };
            // Make the request
            DiagnoseNetworkResponse response = await edgeNetworkClient.DiagnoseNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseNetwork</summary>
        public void DiagnoseNetwork()
        {
            // Snippet: DiagnoseNetwork(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/networks/[NETWORK]";
            // Make the request
            DiagnoseNetworkResponse response = edgeNetworkClient.DiagnoseNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseNetworkAsync</summary>
        public async Task DiagnoseNetworkAsync()
        {
            // Snippet: DiagnoseNetworkAsync(string, CallSettings)
            // Additional: DiagnoseNetworkAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/networks/[NETWORK]";
            // Make the request
            DiagnoseNetworkResponse response = await edgeNetworkClient.DiagnoseNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseNetwork</summary>
        public void DiagnoseNetworkResourceNames()
        {
            // Snippet: DiagnoseNetwork(NetworkName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]");
            // Make the request
            DiagnoseNetworkResponse response = edgeNetworkClient.DiagnoseNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseNetworkAsync</summary>
        public async Task DiagnoseNetworkResourceNamesAsync()
        {
            // Snippet: DiagnoseNetworkAsync(NetworkName, CallSettings)
            // Additional: DiagnoseNetworkAsync(NetworkName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]");
            // Make the request
            DiagnoseNetworkResponse response = await edgeNetworkClient.DiagnoseNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateNetwork</summary>
        public void CreateNetworkRequestObject()
        {
            // Snippet: CreateNetwork(CreateNetworkRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            CreateNetworkRequest request = new CreateNetworkRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                NetworkId = "",
                Network = new Network(),
                RequestId = "",
            };
            // Make the request
            Operation<Network, OperationMetadata> response = edgeNetworkClient.CreateNetwork(request);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkAsync</summary>
        public async Task CreateNetworkRequestObjectAsync()
        {
            // Snippet: CreateNetworkAsync(CreateNetworkRequest, CallSettings)
            // Additional: CreateNetworkAsync(CreateNetworkRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            CreateNetworkRequest request = new CreateNetworkRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                NetworkId = "",
                Network = new Network(),
                RequestId = "",
            };
            // Make the request
            Operation<Network, OperationMetadata> response = await edgeNetworkClient.CreateNetworkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetwork</summary>
        public void CreateNetwork()
        {
            // Snippet: CreateNetwork(string, Network, string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            Network network = new Network();
            string networkId = "";
            // Make the request
            Operation<Network, OperationMetadata> response = edgeNetworkClient.CreateNetwork(parent, network, networkId);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkAsync</summary>
        public async Task CreateNetworkAsync()
        {
            // Snippet: CreateNetworkAsync(string, Network, string, CallSettings)
            // Additional: CreateNetworkAsync(string, Network, string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            Network network = new Network();
            string networkId = "";
            // Make the request
            Operation<Network, OperationMetadata> response = await edgeNetworkClient.CreateNetworkAsync(parent, network, networkId);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetwork</summary>
        public void CreateNetworkResourceNames()
        {
            // Snippet: CreateNetwork(ZoneName, Network, string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            Network network = new Network();
            string networkId = "";
            // Make the request
            Operation<Network, OperationMetadata> response = edgeNetworkClient.CreateNetwork(parent, network, networkId);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateNetworkAsync</summary>
        public async Task CreateNetworkResourceNamesAsync()
        {
            // Snippet: CreateNetworkAsync(ZoneName, Network, string, CallSettings)
            // Additional: CreateNetworkAsync(ZoneName, Network, string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            Network network = new Network();
            string networkId = "";
            // Make the request
            Operation<Network, OperationMetadata> response = await edgeNetworkClient.CreateNetworkAsync(parent, network, networkId);

            // Poll until the returned long-running operation is complete
            Operation<Network, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Network result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Network, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Network retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetwork</summary>
        public void DeleteNetworkRequestObject()
        {
            // Snippet: DeleteNetwork(DeleteNetworkRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            DeleteNetworkRequest request = new DeleteNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteNetwork(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkAsync</summary>
        public async Task DeleteNetworkRequestObjectAsync()
        {
            // Snippet: DeleteNetworkAsync(DeleteNetworkRequest, CallSettings)
            // Additional: DeleteNetworkAsync(DeleteNetworkRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkRequest request = new DeleteNetworkRequest
            {
                NetworkName = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteNetworkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetwork</summary>
        public void DeleteNetwork()
        {
            // Snippet: DeleteNetwork(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/networks/[NETWORK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteNetwork(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkAsync</summary>
        public async Task DeleteNetworkAsync()
        {
            // Snippet: DeleteNetworkAsync(string, CallSettings)
            // Additional: DeleteNetworkAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/networks/[NETWORK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteNetworkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetwork</summary>
        public void DeleteNetworkResourceNames()
        {
            // Snippet: DeleteNetwork(NetworkName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteNetwork(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteNetworkAsync</summary>
        public async Task DeleteNetworkResourceNamesAsync()
        {
            // Snippet: DeleteNetworkAsync(NetworkName, CallSettings)
            // Additional: DeleteNetworkAsync(NetworkName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName name = NetworkName.FromProjectLocationZoneNetwork("[PROJECT]", "[LOCATION]", "[ZONE]", "[NETWORK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteNetworkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSubnets</summary>
        public void ListSubnetsRequestObject()
        {
            // Snippet: ListSubnets(ListSubnetsRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ListSubnetsRequest request = new ListSubnetsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSubnetsResponse, Subnet> response = edgeNetworkClient.ListSubnets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnetsAsync</summary>
        public async Task ListSubnetsRequestObjectAsync()
        {
            // Snippet: ListSubnetsAsync(ListSubnetsRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ListSubnetsRequest request = new ListSubnetsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSubnetsResponse, Subnet> response = edgeNetworkClient.ListSubnetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnets</summary>
        public void ListSubnets()
        {
            // Snippet: ListSubnets(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<ListSubnetsResponse, Subnet> response = edgeNetworkClient.ListSubnets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnetsAsync</summary>
        public async Task ListSubnetsAsync()
        {
            // Snippet: ListSubnetsAsync(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<ListSubnetsResponse, Subnet> response = edgeNetworkClient.ListSubnetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnets</summary>
        public void ListSubnetsResourceNames()
        {
            // Snippet: ListSubnets(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedEnumerable<ListSubnetsResponse, Subnet> response = edgeNetworkClient.ListSubnets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Subnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubnetsAsync</summary>
        public async Task ListSubnetsResourceNamesAsync()
        {
            // Snippet: ListSubnetsAsync(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<ListSubnetsResponse, Subnet> response = edgeNetworkClient.ListSubnetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Subnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Subnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Subnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Subnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSubnet</summary>
        public void GetSubnetRequestObject()
        {
            // Snippet: GetSubnet(GetSubnetRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            GetSubnetRequest request = new GetSubnetRequest
            {
                SubnetName = SubnetName.FromProjectLocationZoneSubnet("[PROJECT]", "[LOCATION]", "[ZONE]", "[SUBNET]"),
            };
            // Make the request
            Subnet response = edgeNetworkClient.GetSubnet(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubnetAsync</summary>
        public async Task GetSubnetRequestObjectAsync()
        {
            // Snippet: GetSubnetAsync(GetSubnetRequest, CallSettings)
            // Additional: GetSubnetAsync(GetSubnetRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            GetSubnetRequest request = new GetSubnetRequest
            {
                SubnetName = SubnetName.FromProjectLocationZoneSubnet("[PROJECT]", "[LOCATION]", "[ZONE]", "[SUBNET]"),
            };
            // Make the request
            Subnet response = await edgeNetworkClient.GetSubnetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubnet</summary>
        public void GetSubnet()
        {
            // Snippet: GetSubnet(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/subnets/[SUBNET]";
            // Make the request
            Subnet response = edgeNetworkClient.GetSubnet(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubnetAsync</summary>
        public async Task GetSubnetAsync()
        {
            // Snippet: GetSubnetAsync(string, CallSettings)
            // Additional: GetSubnetAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/subnets/[SUBNET]";
            // Make the request
            Subnet response = await edgeNetworkClient.GetSubnetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubnet</summary>
        public void GetSubnetResourceNames()
        {
            // Snippet: GetSubnet(SubnetName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            SubnetName name = SubnetName.FromProjectLocationZoneSubnet("[PROJECT]", "[LOCATION]", "[ZONE]", "[SUBNET]");
            // Make the request
            Subnet response = edgeNetworkClient.GetSubnet(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubnetAsync</summary>
        public async Task GetSubnetResourceNamesAsync()
        {
            // Snippet: GetSubnetAsync(SubnetName, CallSettings)
            // Additional: GetSubnetAsync(SubnetName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            SubnetName name = SubnetName.FromProjectLocationZoneSubnet("[PROJECT]", "[LOCATION]", "[ZONE]", "[SUBNET]");
            // Make the request
            Subnet response = await edgeNetworkClient.GetSubnetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSubnet</summary>
        public void CreateSubnetRequestObject()
        {
            // Snippet: CreateSubnet(CreateSubnetRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            CreateSubnetRequest request = new CreateSubnetRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                SubnetId = "",
                Subnet = new Subnet(),
                RequestId = "",
            };
            // Make the request
            Operation<Subnet, OperationMetadata> response = edgeNetworkClient.CreateSubnet(request);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubnetAsync</summary>
        public async Task CreateSubnetRequestObjectAsync()
        {
            // Snippet: CreateSubnetAsync(CreateSubnetRequest, CallSettings)
            // Additional: CreateSubnetAsync(CreateSubnetRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            CreateSubnetRequest request = new CreateSubnetRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                SubnetId = "",
                Subnet = new Subnet(),
                RequestId = "",
            };
            // Make the request
            Operation<Subnet, OperationMetadata> response = await edgeNetworkClient.CreateSubnetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubnet</summary>
        public void CreateSubnet()
        {
            // Snippet: CreateSubnet(string, Subnet, string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            Subnet subnet = new Subnet();
            string subnetId = "";
            // Make the request
            Operation<Subnet, OperationMetadata> response = edgeNetworkClient.CreateSubnet(parent, subnet, subnetId);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubnetAsync</summary>
        public async Task CreateSubnetAsync()
        {
            // Snippet: CreateSubnetAsync(string, Subnet, string, CallSettings)
            // Additional: CreateSubnetAsync(string, Subnet, string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            Subnet subnet = new Subnet();
            string subnetId = "";
            // Make the request
            Operation<Subnet, OperationMetadata> response = await edgeNetworkClient.CreateSubnetAsync(parent, subnet, subnetId);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubnet</summary>
        public void CreateSubnetResourceNames()
        {
            // Snippet: CreateSubnet(ZoneName, Subnet, string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            Subnet subnet = new Subnet();
            string subnetId = "";
            // Make the request
            Operation<Subnet, OperationMetadata> response = edgeNetworkClient.CreateSubnet(parent, subnet, subnetId);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSubnetAsync</summary>
        public async Task CreateSubnetResourceNamesAsync()
        {
            // Snippet: CreateSubnetAsync(ZoneName, Subnet, string, CallSettings)
            // Additional: CreateSubnetAsync(ZoneName, Subnet, string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            Subnet subnet = new Subnet();
            string subnetId = "";
            // Make the request
            Operation<Subnet, OperationMetadata> response = await edgeNetworkClient.CreateSubnetAsync(parent, subnet, subnetId);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubnet</summary>
        public void UpdateSubnetRequestObject()
        {
            // Snippet: UpdateSubnet(UpdateSubnetRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            UpdateSubnetRequest request = new UpdateSubnetRequest
            {
                UpdateMask = new FieldMask(),
                Subnet = new Subnet(),
                RequestId = "",
            };
            // Make the request
            Operation<Subnet, OperationMetadata> response = edgeNetworkClient.UpdateSubnet(request);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceUpdateSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubnetAsync</summary>
        public async Task UpdateSubnetRequestObjectAsync()
        {
            // Snippet: UpdateSubnetAsync(UpdateSubnetRequest, CallSettings)
            // Additional: UpdateSubnetAsync(UpdateSubnetRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubnetRequest request = new UpdateSubnetRequest
            {
                UpdateMask = new FieldMask(),
                Subnet = new Subnet(),
                RequestId = "",
            };
            // Make the request
            Operation<Subnet, OperationMetadata> response = await edgeNetworkClient.UpdateSubnetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceUpdateSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubnet</summary>
        public void UpdateSubnet()
        {
            // Snippet: UpdateSubnet(Subnet, FieldMask, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            Subnet subnet = new Subnet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Subnet, OperationMetadata> response = edgeNetworkClient.UpdateSubnet(subnet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceUpdateSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSubnetAsync</summary>
        public async Task UpdateSubnetAsync()
        {
            // Snippet: UpdateSubnetAsync(Subnet, FieldMask, CallSettings)
            // Additional: UpdateSubnetAsync(Subnet, FieldMask, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            Subnet subnet = new Subnet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Subnet, OperationMetadata> response = await edgeNetworkClient.UpdateSubnetAsync(subnet, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Subnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Subnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Subnet, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceUpdateSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Subnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubnet</summary>
        public void DeleteSubnetRequestObject()
        {
            // Snippet: DeleteSubnet(DeleteSubnetRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            DeleteSubnetRequest request = new DeleteSubnetRequest
            {
                SubnetName = SubnetName.FromProjectLocationZoneSubnet("[PROJECT]", "[LOCATION]", "[ZONE]", "[SUBNET]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteSubnet(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubnetAsync</summary>
        public async Task DeleteSubnetRequestObjectAsync()
        {
            // Snippet: DeleteSubnetAsync(DeleteSubnetRequest, CallSettings)
            // Additional: DeleteSubnetAsync(DeleteSubnetRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubnetRequest request = new DeleteSubnetRequest
            {
                SubnetName = SubnetName.FromProjectLocationZoneSubnet("[PROJECT]", "[LOCATION]", "[ZONE]", "[SUBNET]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteSubnetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubnet</summary>
        public void DeleteSubnet()
        {
            // Snippet: DeleteSubnet(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/subnets/[SUBNET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteSubnet(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubnetAsync</summary>
        public async Task DeleteSubnetAsync()
        {
            // Snippet: DeleteSubnetAsync(string, CallSettings)
            // Additional: DeleteSubnetAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/subnets/[SUBNET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteSubnetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubnet</summary>
        public void DeleteSubnetResourceNames()
        {
            // Snippet: DeleteSubnet(SubnetName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            SubnetName name = SubnetName.FromProjectLocationZoneSubnet("[PROJECT]", "[LOCATION]", "[ZONE]", "[SUBNET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteSubnet(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSubnetAsync</summary>
        public async Task DeleteSubnetResourceNamesAsync()
        {
            // Snippet: DeleteSubnetAsync(SubnetName, CallSettings)
            // Additional: DeleteSubnetAsync(SubnetName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            SubnetName name = SubnetName.FromProjectLocationZoneSubnet("[PROJECT]", "[LOCATION]", "[ZONE]", "[SUBNET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteSubnetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInterconnects</summary>
        public void ListInterconnectsRequestObject()
        {
            // Snippet: ListInterconnects(ListInterconnectsRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInterconnectsResponse, Interconnect> response = edgeNetworkClient.ListInterconnects(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Interconnect item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterconnectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectsAsync</summary>
        public async Task ListInterconnectsRequestObjectAsync()
        {
            // Snippet: ListInterconnectsAsync(ListInterconnectsRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInterconnectsResponse, Interconnect> response = edgeNetworkClient.ListInterconnectsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Interconnect item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInterconnectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnects</summary>
        public void ListInterconnects()
        {
            // Snippet: ListInterconnects(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<ListInterconnectsResponse, Interconnect> response = edgeNetworkClient.ListInterconnects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Interconnect item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterconnectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectsAsync</summary>
        public async Task ListInterconnectsAsync()
        {
            // Snippet: ListInterconnectsAsync(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<ListInterconnectsResponse, Interconnect> response = edgeNetworkClient.ListInterconnectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Interconnect item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInterconnectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnects</summary>
        public void ListInterconnectsResourceNames()
        {
            // Snippet: ListInterconnects(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedEnumerable<ListInterconnectsResponse, Interconnect> response = edgeNetworkClient.ListInterconnects(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Interconnect item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterconnectsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectsAsync</summary>
        public async Task ListInterconnectsResourceNamesAsync()
        {
            // Snippet: ListInterconnectsAsync(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<ListInterconnectsResponse, Interconnect> response = edgeNetworkClient.ListInterconnectsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Interconnect item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInterconnectsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Interconnect item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Interconnect> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Interconnect item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInterconnect</summary>
        public void GetInterconnectRequestObject()
        {
            // Snippet: GetInterconnect(GetInterconnectRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            GetInterconnectRequest request = new GetInterconnectRequest
            {
                InterconnectName = InterconnectName.FromProjectLocationZoneInterconnect("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT]"),
            };
            // Make the request
            Interconnect response = edgeNetworkClient.GetInterconnect(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAsync</summary>
        public async Task GetInterconnectRequestObjectAsync()
        {
            // Snippet: GetInterconnectAsync(GetInterconnectRequest, CallSettings)
            // Additional: GetInterconnectAsync(GetInterconnectRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectRequest request = new GetInterconnectRequest
            {
                InterconnectName = InterconnectName.FromProjectLocationZoneInterconnect("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT]"),
            };
            // Make the request
            Interconnect response = await edgeNetworkClient.GetInterconnectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnect</summary>
        public void GetInterconnect()
        {
            // Snippet: GetInterconnect(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/interconnects/[INTERCONNECT]";
            // Make the request
            Interconnect response = edgeNetworkClient.GetInterconnect(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAsync</summary>
        public async Task GetInterconnectAsync()
        {
            // Snippet: GetInterconnectAsync(string, CallSettings)
            // Additional: GetInterconnectAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/interconnects/[INTERCONNECT]";
            // Make the request
            Interconnect response = await edgeNetworkClient.GetInterconnectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnect</summary>
        public void GetInterconnectResourceNames()
        {
            // Snippet: GetInterconnect(InterconnectName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            InterconnectName name = InterconnectName.FromProjectLocationZoneInterconnect("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT]");
            // Make the request
            Interconnect response = edgeNetworkClient.GetInterconnect(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAsync</summary>
        public async Task GetInterconnectResourceNamesAsync()
        {
            // Snippet: GetInterconnectAsync(InterconnectName, CallSettings)
            // Additional: GetInterconnectAsync(InterconnectName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            InterconnectName name = InterconnectName.FromProjectLocationZoneInterconnect("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT]");
            // Make the request
            Interconnect response = await edgeNetworkClient.GetInterconnectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInterconnect</summary>
        public void DiagnoseInterconnectRequestObject()
        {
            // Snippet: DiagnoseInterconnect(DiagnoseInterconnectRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            DiagnoseInterconnectRequest request = new DiagnoseInterconnectRequest
            {
                InterconnectName = InterconnectName.FromProjectLocationZoneInterconnect("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT]"),
            };
            // Make the request
            DiagnoseInterconnectResponse response = edgeNetworkClient.DiagnoseInterconnect(request);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInterconnectAsync</summary>
        public async Task DiagnoseInterconnectRequestObjectAsync()
        {
            // Snippet: DiagnoseInterconnectAsync(DiagnoseInterconnectRequest, CallSettings)
            // Additional: DiagnoseInterconnectAsync(DiagnoseInterconnectRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            DiagnoseInterconnectRequest request = new DiagnoseInterconnectRequest
            {
                InterconnectName = InterconnectName.FromProjectLocationZoneInterconnect("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT]"),
            };
            // Make the request
            DiagnoseInterconnectResponse response = await edgeNetworkClient.DiagnoseInterconnectAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInterconnect</summary>
        public void DiagnoseInterconnect()
        {
            // Snippet: DiagnoseInterconnect(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/interconnects/[INTERCONNECT]";
            // Make the request
            DiagnoseInterconnectResponse response = edgeNetworkClient.DiagnoseInterconnect(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInterconnectAsync</summary>
        public async Task DiagnoseInterconnectAsync()
        {
            // Snippet: DiagnoseInterconnectAsync(string, CallSettings)
            // Additional: DiagnoseInterconnectAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/interconnects/[INTERCONNECT]";
            // Make the request
            DiagnoseInterconnectResponse response = await edgeNetworkClient.DiagnoseInterconnectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInterconnect</summary>
        public void DiagnoseInterconnectResourceNames()
        {
            // Snippet: DiagnoseInterconnect(InterconnectName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            InterconnectName name = InterconnectName.FromProjectLocationZoneInterconnect("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT]");
            // Make the request
            DiagnoseInterconnectResponse response = edgeNetworkClient.DiagnoseInterconnect(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseInterconnectAsync</summary>
        public async Task DiagnoseInterconnectResourceNamesAsync()
        {
            // Snippet: DiagnoseInterconnectAsync(InterconnectName, CallSettings)
            // Additional: DiagnoseInterconnectAsync(InterconnectName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            InterconnectName name = InterconnectName.FromProjectLocationZoneInterconnect("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT]");
            // Make the request
            DiagnoseInterconnectResponse response = await edgeNetworkClient.DiagnoseInterconnectAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectAttachments</summary>
        public void ListInterconnectAttachmentsRequestObject()
        {
            // Snippet: ListInterconnectAttachments(ListInterconnectAttachmentsRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> response = edgeNetworkClient.ListInterconnectAttachments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterconnectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectAttachmentsAsync</summary>
        public async Task ListInterconnectAttachmentsRequestObjectAsync()
        {
            // Snippet: ListInterconnectAttachmentsAsync(ListInterconnectAttachmentsRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> response = edgeNetworkClient.ListInterconnectAttachmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInterconnectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectAttachments</summary>
        public void ListInterconnectAttachments()
        {
            // Snippet: ListInterconnectAttachments(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> response = edgeNetworkClient.ListInterconnectAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterconnectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectAttachmentsAsync</summary>
        public async Task ListInterconnectAttachmentsAsync()
        {
            // Snippet: ListInterconnectAttachmentsAsync(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> response = edgeNetworkClient.ListInterconnectAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInterconnectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectAttachments</summary>
        public void ListInterconnectAttachmentsResourceNames()
        {
            // Snippet: ListInterconnectAttachments(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> response = edgeNetworkClient.ListInterconnectAttachments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectAttachment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterconnectAttachmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterconnectAttachmentsAsync</summary>
        public async Task ListInterconnectAttachmentsResourceNamesAsync()
        {
            // Snippet: ListInterconnectAttachmentsAsync(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<ListInterconnectAttachmentsResponse, InterconnectAttachment> response = edgeNetworkClient.ListInterconnectAttachmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectAttachment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInterconnectAttachmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAttachment</summary>
        public void GetInterconnectAttachmentRequestObject()
        {
            // Snippet: GetInterconnectAttachment(GetInterconnectAttachmentRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                InterconnectAttachmentName = InterconnectAttachmentName.FromProjectLocationZoneInterconnectAttachment("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT_ATTACHMENT]"),
            };
            // Make the request
            InterconnectAttachment response = edgeNetworkClient.GetInterconnectAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAttachmentAsync</summary>
        public async Task GetInterconnectAttachmentRequestObjectAsync()
        {
            // Snippet: GetInterconnectAttachmentAsync(GetInterconnectAttachmentRequest, CallSettings)
            // Additional: GetInterconnectAttachmentAsync(GetInterconnectAttachmentRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                InterconnectAttachmentName = InterconnectAttachmentName.FromProjectLocationZoneInterconnectAttachment("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT_ATTACHMENT]"),
            };
            // Make the request
            InterconnectAttachment response = await edgeNetworkClient.GetInterconnectAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAttachment</summary>
        public void GetInterconnectAttachment()
        {
            // Snippet: GetInterconnectAttachment(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/interconnectAttachments/[INTERCONNECT_ATTACHMENT]";
            // Make the request
            InterconnectAttachment response = edgeNetworkClient.GetInterconnectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAttachmentAsync</summary>
        public async Task GetInterconnectAttachmentAsync()
        {
            // Snippet: GetInterconnectAttachmentAsync(string, CallSettings)
            // Additional: GetInterconnectAttachmentAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/interconnectAttachments/[INTERCONNECT_ATTACHMENT]";
            // Make the request
            InterconnectAttachment response = await edgeNetworkClient.GetInterconnectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAttachment</summary>
        public void GetInterconnectAttachmentResourceNames()
        {
            // Snippet: GetInterconnectAttachment(InterconnectAttachmentName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            InterconnectAttachmentName name = InterconnectAttachmentName.FromProjectLocationZoneInterconnectAttachment("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT_ATTACHMENT]");
            // Make the request
            InterconnectAttachment response = edgeNetworkClient.GetInterconnectAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterconnectAttachmentAsync</summary>
        public async Task GetInterconnectAttachmentResourceNamesAsync()
        {
            // Snippet: GetInterconnectAttachmentAsync(InterconnectAttachmentName, CallSettings)
            // Additional: GetInterconnectAttachmentAsync(InterconnectAttachmentName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            InterconnectAttachmentName name = InterconnectAttachmentName.FromProjectLocationZoneInterconnectAttachment("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT_ATTACHMENT]");
            // Make the request
            InterconnectAttachment response = await edgeNetworkClient.GetInterconnectAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInterconnectAttachment</summary>
        public void CreateInterconnectAttachmentRequestObject()
        {
            // Snippet: CreateInterconnectAttachment(CreateInterconnectAttachmentRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            CreateInterconnectAttachmentRequest request = new CreateInterconnectAttachmentRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                InterconnectAttachmentId = "",
                InterconnectAttachment = new InterconnectAttachment(),
                RequestId = "",
            };
            // Make the request
            Operation<InterconnectAttachment, OperationMetadata> response = edgeNetworkClient.CreateInterconnectAttachment(request);

            // Poll until the returned long-running operation is complete
            Operation<InterconnectAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterconnectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterconnectAttachment, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateInterconnectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterconnectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterconnectAttachmentAsync</summary>
        public async Task CreateInterconnectAttachmentRequestObjectAsync()
        {
            // Snippet: CreateInterconnectAttachmentAsync(CreateInterconnectAttachmentRequest, CallSettings)
            // Additional: CreateInterconnectAttachmentAsync(CreateInterconnectAttachmentRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            CreateInterconnectAttachmentRequest request = new CreateInterconnectAttachmentRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                InterconnectAttachmentId = "",
                InterconnectAttachment = new InterconnectAttachment(),
                RequestId = "",
            };
            // Make the request
            Operation<InterconnectAttachment, OperationMetadata> response = await edgeNetworkClient.CreateInterconnectAttachmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterconnectAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterconnectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterconnectAttachment, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateInterconnectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterconnectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterconnectAttachment</summary>
        public void CreateInterconnectAttachment()
        {
            // Snippet: CreateInterconnectAttachment(string, InterconnectAttachment, string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            InterconnectAttachment interconnectAttachment = new InterconnectAttachment();
            string interconnectAttachmentId = "";
            // Make the request
            Operation<InterconnectAttachment, OperationMetadata> response = edgeNetworkClient.CreateInterconnectAttachment(parent, interconnectAttachment, interconnectAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<InterconnectAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterconnectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterconnectAttachment, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateInterconnectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterconnectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterconnectAttachmentAsync</summary>
        public async Task CreateInterconnectAttachmentAsync()
        {
            // Snippet: CreateInterconnectAttachmentAsync(string, InterconnectAttachment, string, CallSettings)
            // Additional: CreateInterconnectAttachmentAsync(string, InterconnectAttachment, string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            InterconnectAttachment interconnectAttachment = new InterconnectAttachment();
            string interconnectAttachmentId = "";
            // Make the request
            Operation<InterconnectAttachment, OperationMetadata> response = await edgeNetworkClient.CreateInterconnectAttachmentAsync(parent, interconnectAttachment, interconnectAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<InterconnectAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterconnectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterconnectAttachment, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateInterconnectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterconnectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterconnectAttachment</summary>
        public void CreateInterconnectAttachmentResourceNames()
        {
            // Snippet: CreateInterconnectAttachment(ZoneName, InterconnectAttachment, string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            InterconnectAttachment interconnectAttachment = new InterconnectAttachment();
            string interconnectAttachmentId = "";
            // Make the request
            Operation<InterconnectAttachment, OperationMetadata> response = edgeNetworkClient.CreateInterconnectAttachment(parent, interconnectAttachment, interconnectAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<InterconnectAttachment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterconnectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterconnectAttachment, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateInterconnectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterconnectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterconnectAttachmentAsync</summary>
        public async Task CreateInterconnectAttachmentResourceNamesAsync()
        {
            // Snippet: CreateInterconnectAttachmentAsync(ZoneName, InterconnectAttachment, string, CallSettings)
            // Additional: CreateInterconnectAttachmentAsync(ZoneName, InterconnectAttachment, string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            InterconnectAttachment interconnectAttachment = new InterconnectAttachment();
            string interconnectAttachmentId = "";
            // Make the request
            Operation<InterconnectAttachment, OperationMetadata> response = await edgeNetworkClient.CreateInterconnectAttachmentAsync(parent, interconnectAttachment, interconnectAttachmentId);

            // Poll until the returned long-running operation is complete
            Operation<InterconnectAttachment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterconnectAttachment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterconnectAttachment, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateInterconnectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterconnectAttachment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterconnectAttachment</summary>
        public void DeleteInterconnectAttachmentRequestObject()
        {
            // Snippet: DeleteInterconnectAttachment(DeleteInterconnectAttachmentRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                InterconnectAttachmentName = InterconnectAttachmentName.FromProjectLocationZoneInterconnectAttachment("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT_ATTACHMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteInterconnectAttachment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteInterconnectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterconnectAttachmentAsync</summary>
        public async Task DeleteInterconnectAttachmentRequestObjectAsync()
        {
            // Snippet: DeleteInterconnectAttachmentAsync(DeleteInterconnectAttachmentRequest, CallSettings)
            // Additional: DeleteInterconnectAttachmentAsync(DeleteInterconnectAttachmentRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                InterconnectAttachmentName = InterconnectAttachmentName.FromProjectLocationZoneInterconnectAttachment("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT_ATTACHMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteInterconnectAttachmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteInterconnectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterconnectAttachment</summary>
        public void DeleteInterconnectAttachment()
        {
            // Snippet: DeleteInterconnectAttachment(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/interconnectAttachments/[INTERCONNECT_ATTACHMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteInterconnectAttachment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteInterconnectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterconnectAttachmentAsync</summary>
        public async Task DeleteInterconnectAttachmentAsync()
        {
            // Snippet: DeleteInterconnectAttachmentAsync(string, CallSettings)
            // Additional: DeleteInterconnectAttachmentAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/interconnectAttachments/[INTERCONNECT_ATTACHMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteInterconnectAttachmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteInterconnectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterconnectAttachment</summary>
        public void DeleteInterconnectAttachmentResourceNames()
        {
            // Snippet: DeleteInterconnectAttachment(InterconnectAttachmentName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            InterconnectAttachmentName name = InterconnectAttachmentName.FromProjectLocationZoneInterconnectAttachment("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT_ATTACHMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteInterconnectAttachment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteInterconnectAttachment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterconnectAttachmentAsync</summary>
        public async Task DeleteInterconnectAttachmentResourceNamesAsync()
        {
            // Snippet: DeleteInterconnectAttachmentAsync(InterconnectAttachmentName, CallSettings)
            // Additional: DeleteInterconnectAttachmentAsync(InterconnectAttachmentName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            InterconnectAttachmentName name = InterconnectAttachmentName.FromProjectLocationZoneInterconnectAttachment("[PROJECT]", "[LOCATION]", "[ZONE]", "[INTERCONNECT_ATTACHMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteInterconnectAttachmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteInterconnectAttachmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRouters</summary>
        public void ListRoutersRequestObject()
        {
            // Snippet: ListRouters(ListRoutersRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ListRoutersRequest request = new ListRoutersRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRoutersResponse, Router> response = edgeNetworkClient.ListRouters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Router item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutersAsync</summary>
        public async Task ListRoutersRequestObjectAsync()
        {
            // Snippet: ListRoutersAsync(ListRoutersRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ListRoutersRequest request = new ListRoutersRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRoutersResponse, Router> response = edgeNetworkClient.ListRoutersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Router item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRouters</summary>
        public void ListRouters()
        {
            // Snippet: ListRouters(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<ListRoutersResponse, Router> response = edgeNetworkClient.ListRouters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Router item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutersAsync</summary>
        public async Task ListRoutersAsync()
        {
            // Snippet: ListRoutersAsync(string, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<ListRoutersResponse, Router> response = edgeNetworkClient.ListRoutersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Router item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRouters</summary>
        public void ListRoutersResourceNames()
        {
            // Snippet: ListRouters(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedEnumerable<ListRoutersResponse, Router> response = edgeNetworkClient.ListRouters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Router item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRoutersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoutersAsync</summary>
        public async Task ListRoutersResourceNamesAsync()
        {
            // Snippet: ListRoutersAsync(ZoneName, string, int?, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<ListRoutersResponse, Router> response = edgeNetworkClient.ListRoutersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Router item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRoutersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Router item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Router> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Router item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRouter</summary>
        public void GetRouterRequestObject()
        {
            // Snippet: GetRouter(GetRouterRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            GetRouterRequest request = new GetRouterRequest
            {
                RouterName = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]"),
            };
            // Make the request
            Router response = edgeNetworkClient.GetRouter(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouterAsync</summary>
        public async Task GetRouterRequestObjectAsync()
        {
            // Snippet: GetRouterAsync(GetRouterRequest, CallSettings)
            // Additional: GetRouterAsync(GetRouterRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            GetRouterRequest request = new GetRouterRequest
            {
                RouterName = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]"),
            };
            // Make the request
            Router response = await edgeNetworkClient.GetRouterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRouter</summary>
        public void GetRouter()
        {
            // Snippet: GetRouter(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/routers/[ROUTER]";
            // Make the request
            Router response = edgeNetworkClient.GetRouter(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouterAsync</summary>
        public async Task GetRouterAsync()
        {
            // Snippet: GetRouterAsync(string, CallSettings)
            // Additional: GetRouterAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/routers/[ROUTER]";
            // Make the request
            Router response = await edgeNetworkClient.GetRouterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouter</summary>
        public void GetRouterResourceNames()
        {
            // Snippet: GetRouter(RouterName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            RouterName name = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]");
            // Make the request
            Router response = edgeNetworkClient.GetRouter(name);
            // End snippet
        }

        /// <summary>Snippet for GetRouterAsync</summary>
        public async Task GetRouterResourceNamesAsync()
        {
            // Snippet: GetRouterAsync(RouterName, CallSettings)
            // Additional: GetRouterAsync(RouterName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            RouterName name = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]");
            // Make the request
            Router response = await edgeNetworkClient.GetRouterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRouter</summary>
        public void DiagnoseRouterRequestObject()
        {
            // Snippet: DiagnoseRouter(DiagnoseRouterRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            DiagnoseRouterRequest request = new DiagnoseRouterRequest
            {
                RouterName = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]"),
            };
            // Make the request
            DiagnoseRouterResponse response = edgeNetworkClient.DiagnoseRouter(request);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRouterAsync</summary>
        public async Task DiagnoseRouterRequestObjectAsync()
        {
            // Snippet: DiagnoseRouterAsync(DiagnoseRouterRequest, CallSettings)
            // Additional: DiagnoseRouterAsync(DiagnoseRouterRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            DiagnoseRouterRequest request = new DiagnoseRouterRequest
            {
                RouterName = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]"),
            };
            // Make the request
            DiagnoseRouterResponse response = await edgeNetworkClient.DiagnoseRouterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRouter</summary>
        public void DiagnoseRouter()
        {
            // Snippet: DiagnoseRouter(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/routers/[ROUTER]";
            // Make the request
            DiagnoseRouterResponse response = edgeNetworkClient.DiagnoseRouter(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRouterAsync</summary>
        public async Task DiagnoseRouterAsync()
        {
            // Snippet: DiagnoseRouterAsync(string, CallSettings)
            // Additional: DiagnoseRouterAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/routers/[ROUTER]";
            // Make the request
            DiagnoseRouterResponse response = await edgeNetworkClient.DiagnoseRouterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRouter</summary>
        public void DiagnoseRouterResourceNames()
        {
            // Snippet: DiagnoseRouter(RouterName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            RouterName name = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]");
            // Make the request
            DiagnoseRouterResponse response = edgeNetworkClient.DiagnoseRouter(name);
            // End snippet
        }

        /// <summary>Snippet for DiagnoseRouterAsync</summary>
        public async Task DiagnoseRouterResourceNamesAsync()
        {
            // Snippet: DiagnoseRouterAsync(RouterName, CallSettings)
            // Additional: DiagnoseRouterAsync(RouterName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            RouterName name = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]");
            // Make the request
            DiagnoseRouterResponse response = await edgeNetworkClient.DiagnoseRouterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRouter</summary>
        public void CreateRouterRequestObject()
        {
            // Snippet: CreateRouter(CreateRouterRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            CreateRouterRequest request = new CreateRouterRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                RouterId = "",
                Router = new Router(),
                RequestId = "",
            };
            // Make the request
            Operation<Router, OperationMetadata> response = edgeNetworkClient.CreateRouter(request);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateRouter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRouterAsync</summary>
        public async Task CreateRouterRequestObjectAsync()
        {
            // Snippet: CreateRouterAsync(CreateRouterRequest, CallSettings)
            // Additional: CreateRouterAsync(CreateRouterRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            CreateRouterRequest request = new CreateRouterRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]"),
                RouterId = "",
                Router = new Router(),
                RequestId = "",
            };
            // Make the request
            Operation<Router, OperationMetadata> response = await edgeNetworkClient.CreateRouterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateRouterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRouter</summary>
        public void CreateRouter()
        {
            // Snippet: CreateRouter(string, Router, string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            Router router = new Router();
            string routerId = "";
            // Make the request
            Operation<Router, OperationMetadata> response = edgeNetworkClient.CreateRouter(parent, router, routerId);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateRouter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRouterAsync</summary>
        public async Task CreateRouterAsync()
        {
            // Snippet: CreateRouterAsync(string, Router, string, CallSettings)
            // Additional: CreateRouterAsync(string, Router, string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]";
            Router router = new Router();
            string routerId = "";
            // Make the request
            Operation<Router, OperationMetadata> response = await edgeNetworkClient.CreateRouterAsync(parent, router, routerId);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateRouterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRouter</summary>
        public void CreateRouterResourceNames()
        {
            // Snippet: CreateRouter(ZoneName, Router, string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            Router router = new Router();
            string routerId = "";
            // Make the request
            Operation<Router, OperationMetadata> response = edgeNetworkClient.CreateRouter(parent, router, routerId);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceCreateRouter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRouterAsync</summary>
        public async Task CreateRouterResourceNamesAsync()
        {
            // Snippet: CreateRouterAsync(ZoneName, Router, string, CallSettings)
            // Additional: CreateRouterAsync(ZoneName, Router, string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            Router router = new Router();
            string routerId = "";
            // Make the request
            Operation<Router, OperationMetadata> response = await edgeNetworkClient.CreateRouterAsync(parent, router, routerId);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceCreateRouterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRouter</summary>
        public void UpdateRouterRequestObject()
        {
            // Snippet: UpdateRouter(UpdateRouterRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                UpdateMask = new FieldMask(),
                Router = new Router(),
                RequestId = "",
            };
            // Make the request
            Operation<Router, OperationMetadata> response = edgeNetworkClient.UpdateRouter(request);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceUpdateRouter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRouterAsync</summary>
        public async Task UpdateRouterRequestObjectAsync()
        {
            // Snippet: UpdateRouterAsync(UpdateRouterRequest, CallSettings)
            // Additional: UpdateRouterAsync(UpdateRouterRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRouterRequest request = new UpdateRouterRequest
            {
                UpdateMask = new FieldMask(),
                Router = new Router(),
                RequestId = "",
            };
            // Make the request
            Operation<Router, OperationMetadata> response = await edgeNetworkClient.UpdateRouterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceUpdateRouterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRouter</summary>
        public void UpdateRouter()
        {
            // Snippet: UpdateRouter(Router, FieldMask, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            Router router = new Router();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Router, OperationMetadata> response = edgeNetworkClient.UpdateRouter(router, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceUpdateRouter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateRouterAsync</summary>
        public async Task UpdateRouterAsync()
        {
            // Snippet: UpdateRouterAsync(Router, FieldMask, CallSettings)
            // Additional: UpdateRouterAsync(Router, FieldMask, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            Router router = new Router();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Router, OperationMetadata> response = await edgeNetworkClient.UpdateRouterAsync(router, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Router, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Router result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Router, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceUpdateRouterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Router retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouter</summary>
        public void DeleteRouterRequestObject()
        {
            // Snippet: DeleteRouter(DeleteRouterRequest, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                RouterName = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteRouter(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteRouter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouterAsync</summary>
        public async Task DeleteRouterRequestObjectAsync()
        {
            // Snippet: DeleteRouterAsync(DeleteRouterRequest, CallSettings)
            // Additional: DeleteRouterAsync(DeleteRouterRequest, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRouterRequest request = new DeleteRouterRequest
            {
                RouterName = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteRouterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteRouterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouter</summary>
        public void DeleteRouter()
        {
            // Snippet: DeleteRouter(string, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/routers/[ROUTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteRouter(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteRouter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouterAsync</summary>
        public async Task DeleteRouterAsync()
        {
            // Snippet: DeleteRouterAsync(string, CallSettings)
            // Additional: DeleteRouterAsync(string, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/zones/[ZONE]/routers/[ROUTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteRouterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteRouterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouter</summary>
        public void DeleteRouterResourceNames()
        {
            // Snippet: DeleteRouter(RouterName, CallSettings)
            // Create client
            EdgeNetworkClient edgeNetworkClient = EdgeNetworkClient.Create();
            // Initialize request argument(s)
            RouterName name = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = edgeNetworkClient.DeleteRouter(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = edgeNetworkClient.PollOnceDeleteRouter(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRouterAsync</summary>
        public async Task DeleteRouterResourceNamesAsync()
        {
            // Snippet: DeleteRouterAsync(RouterName, CallSettings)
            // Additional: DeleteRouterAsync(RouterName, CancellationToken)
            // Create client
            EdgeNetworkClient edgeNetworkClient = await EdgeNetworkClient.CreateAsync();
            // Initialize request argument(s)
            RouterName name = RouterName.FromProjectLocationZoneRouter("[PROJECT]", "[LOCATION]", "[ZONE]", "[ROUTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await edgeNetworkClient.DeleteRouterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await edgeNetworkClient.PollOnceDeleteRouterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
