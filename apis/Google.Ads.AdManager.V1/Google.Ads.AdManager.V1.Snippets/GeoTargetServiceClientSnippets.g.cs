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
    public sealed class AllGeneratedGeoTargetServiceClientSnippets
    {
        /// <summary>Snippet for GetGeoTarget</summary>
        public void GetGeoTargetRequestObject()
        {
            // Snippet: GetGeoTarget(GetGeoTargetRequest, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = GeoTargetServiceClient.Create();
            // Initialize request argument(s)
            GetGeoTargetRequest request = new GetGeoTargetRequest
            {
                GeoTargetName = GeoTargetName.FromNetworkCodeGeoTarget("[NETWORK_CODE]", "[GEO_TARGET]"),
            };
            // Make the request
            GeoTarget response = geoTargetServiceClient.GetGeoTarget(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTargetAsync</summary>
        public async Task GetGeoTargetRequestObjectAsync()
        {
            // Snippet: GetGeoTargetAsync(GetGeoTargetRequest, CallSettings)
            // Additional: GetGeoTargetAsync(GetGeoTargetRequest, CancellationToken)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = await GeoTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGeoTargetRequest request = new GetGeoTargetRequest
            {
                GeoTargetName = GeoTargetName.FromNetworkCodeGeoTarget("[NETWORK_CODE]", "[GEO_TARGET]"),
            };
            // Make the request
            GeoTarget response = await geoTargetServiceClient.GetGeoTargetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTarget</summary>
        public void GetGeoTarget()
        {
            // Snippet: GetGeoTarget(string, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = GeoTargetServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/geoTargets/[GEO_TARGET]";
            // Make the request
            GeoTarget response = geoTargetServiceClient.GetGeoTarget(name);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTargetAsync</summary>
        public async Task GetGeoTargetAsync()
        {
            // Snippet: GetGeoTargetAsync(string, CallSettings)
            // Additional: GetGeoTargetAsync(string, CancellationToken)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = await GeoTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/geoTargets/[GEO_TARGET]";
            // Make the request
            GeoTarget response = await geoTargetServiceClient.GetGeoTargetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTarget</summary>
        public void GetGeoTargetResourceNames()
        {
            // Snippet: GetGeoTarget(GeoTargetName, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = GeoTargetServiceClient.Create();
            // Initialize request argument(s)
            GeoTargetName name = GeoTargetName.FromNetworkCodeGeoTarget("[NETWORK_CODE]", "[GEO_TARGET]");
            // Make the request
            GeoTarget response = geoTargetServiceClient.GetGeoTarget(name);
            // End snippet
        }

        /// <summary>Snippet for GetGeoTargetAsync</summary>
        public async Task GetGeoTargetResourceNamesAsync()
        {
            // Snippet: GetGeoTargetAsync(GeoTargetName, CallSettings)
            // Additional: GetGeoTargetAsync(GeoTargetName, CancellationToken)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = await GeoTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GeoTargetName name = GeoTargetName.FromNetworkCodeGeoTarget("[NETWORK_CODE]", "[GEO_TARGET]");
            // Make the request
            GeoTarget response = await geoTargetServiceClient.GetGeoTargetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGeoTargets</summary>
        public void ListGeoTargetsRequestObject()
        {
            // Snippet: ListGeoTargets(ListGeoTargetsRequest, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = GeoTargetServiceClient.Create();
            // Initialize request argument(s)
            ListGeoTargetsRequest request = new ListGeoTargetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListGeoTargetsResponse, GeoTarget> response = geoTargetServiceClient.ListGeoTargets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GeoTarget item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeoTargetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeoTarget item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeoTarget> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeoTarget item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeoTargetsAsync</summary>
        public async Task ListGeoTargetsRequestObjectAsync()
        {
            // Snippet: ListGeoTargetsAsync(ListGeoTargetsRequest, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = await GeoTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGeoTargetsRequest request = new ListGeoTargetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListGeoTargetsResponse, GeoTarget> response = geoTargetServiceClient.ListGeoTargetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GeoTarget item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeoTargetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeoTarget item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeoTarget> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeoTarget item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeoTargets</summary>
        public void ListGeoTargets()
        {
            // Snippet: ListGeoTargets(string, string, int?, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = GeoTargetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListGeoTargetsResponse, GeoTarget> response = geoTargetServiceClient.ListGeoTargets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GeoTarget item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeoTargetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeoTarget item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeoTarget> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeoTarget item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeoTargetsAsync</summary>
        public async Task ListGeoTargetsAsync()
        {
            // Snippet: ListGeoTargetsAsync(string, string, int?, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = await GeoTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListGeoTargetsResponse, GeoTarget> response = geoTargetServiceClient.ListGeoTargetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GeoTarget item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeoTargetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeoTarget item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeoTarget> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeoTarget item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeoTargets</summary>
        public void ListGeoTargetsResourceNames()
        {
            // Snippet: ListGeoTargets(NetworkName, string, int?, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = GeoTargetServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListGeoTargetsResponse, GeoTarget> response = geoTargetServiceClient.ListGeoTargets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GeoTarget item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGeoTargetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeoTarget item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeoTarget> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeoTarget item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGeoTargetsAsync</summary>
        public async Task ListGeoTargetsResourceNamesAsync()
        {
            // Snippet: ListGeoTargetsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            GeoTargetServiceClient geoTargetServiceClient = await GeoTargetServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListGeoTargetsResponse, GeoTarget> response = geoTargetServiceClient.ListGeoTargetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GeoTarget item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGeoTargetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GeoTarget item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GeoTarget> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GeoTarget item in singlePage)
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
