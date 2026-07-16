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
    public sealed class AllGeneratedAdSpotServiceClientSnippets
    {
        /// <summary>Snippet for GetAdSpot</summary>
        public void GetAdSpotRequestObject()
        {
            // Snippet: GetAdSpot(GetAdSpotRequest, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            GetAdSpotRequest request = new GetAdSpotRequest
            {
                AdSpotName = AdSpotName.FromNetworkCodeAdSpot("[NETWORK_CODE]", "[AD_SPOT]"),
            };
            // Make the request
            AdSpot response = adSpotServiceClient.GetAdSpot(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdSpotAsync</summary>
        public async Task GetAdSpotRequestObjectAsync()
        {
            // Snippet: GetAdSpotAsync(GetAdSpotRequest, CallSettings)
            // Additional: GetAdSpotAsync(GetAdSpotRequest, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdSpotRequest request = new GetAdSpotRequest
            {
                AdSpotName = AdSpotName.FromNetworkCodeAdSpot("[NETWORK_CODE]", "[AD_SPOT]"),
            };
            // Make the request
            AdSpot response = await adSpotServiceClient.GetAdSpotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdSpot</summary>
        public void GetAdSpot()
        {
            // Snippet: GetAdSpot(string, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/adSpots/[AD_SPOT]";
            // Make the request
            AdSpot response = adSpotServiceClient.GetAdSpot(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdSpotAsync</summary>
        public async Task GetAdSpotAsync()
        {
            // Snippet: GetAdSpotAsync(string, CallSettings)
            // Additional: GetAdSpotAsync(string, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/adSpots/[AD_SPOT]";
            // Make the request
            AdSpot response = await adSpotServiceClient.GetAdSpotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdSpot</summary>
        public void GetAdSpotResourceNames()
        {
            // Snippet: GetAdSpot(AdSpotName, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            AdSpotName name = AdSpotName.FromNetworkCodeAdSpot("[NETWORK_CODE]", "[AD_SPOT]");
            // Make the request
            AdSpot response = adSpotServiceClient.GetAdSpot(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdSpotAsync</summary>
        public async Task GetAdSpotResourceNamesAsync()
        {
            // Snippet: GetAdSpotAsync(AdSpotName, CallSettings)
            // Additional: GetAdSpotAsync(AdSpotName, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdSpotName name = AdSpotName.FromNetworkCodeAdSpot("[NETWORK_CODE]", "[AD_SPOT]");
            // Make the request
            AdSpot response = await adSpotServiceClient.GetAdSpotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAdSpots</summary>
        public void ListAdSpotsRequestObject()
        {
            // Snippet: ListAdSpots(ListAdSpotsRequest, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            ListAdSpotsRequest request = new ListAdSpotsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListAdSpotsResponse, AdSpot> response = adSpotServiceClient.ListAdSpots(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdSpot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdSpotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSpot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSpot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSpot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSpotsAsync</summary>
        public async Task ListAdSpotsRequestObjectAsync()
        {
            // Snippet: ListAdSpotsAsync(ListAdSpotsRequest, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdSpotsRequest request = new ListAdSpotsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListAdSpotsResponse, AdSpot> response = adSpotServiceClient.ListAdSpotsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdSpot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdSpotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSpot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSpot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSpot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSpots</summary>
        public void ListAdSpots()
        {
            // Snippet: ListAdSpots(string, string, int?, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListAdSpotsResponse, AdSpot> response = adSpotServiceClient.ListAdSpots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdSpot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdSpotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSpot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSpot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSpot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSpotsAsync</summary>
        public async Task ListAdSpotsAsync()
        {
            // Snippet: ListAdSpotsAsync(string, string, int?, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListAdSpotsResponse, AdSpot> response = adSpotServiceClient.ListAdSpotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdSpot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdSpotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSpot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSpot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSpot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSpots</summary>
        public void ListAdSpotsResourceNames()
        {
            // Snippet: ListAdSpots(NetworkName, string, int?, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListAdSpotsResponse, AdSpot> response = adSpotServiceClient.ListAdSpots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdSpot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdSpotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSpot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSpot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSpot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSpotsAsync</summary>
        public async Task ListAdSpotsResourceNamesAsync()
        {
            // Snippet: ListAdSpotsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListAdSpotsResponse, AdSpot> response = adSpotServiceClient.ListAdSpotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdSpot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdSpotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSpot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSpot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSpot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAdSpot</summary>
        public void CreateAdSpotRequestObject()
        {
            // Snippet: CreateAdSpot(CreateAdSpotRequest, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            CreateAdSpotRequest request = new CreateAdSpotRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdSpot = new AdSpot(),
            };
            // Make the request
            AdSpot response = adSpotServiceClient.CreateAdSpot(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSpotAsync</summary>
        public async Task CreateAdSpotRequestObjectAsync()
        {
            // Snippet: CreateAdSpotAsync(CreateAdSpotRequest, CallSettings)
            // Additional: CreateAdSpotAsync(CreateAdSpotRequest, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAdSpotRequest request = new CreateAdSpotRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdSpot = new AdSpot(),
            };
            // Make the request
            AdSpot response = await adSpotServiceClient.CreateAdSpotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSpot</summary>
        public void CreateAdSpot()
        {
            // Snippet: CreateAdSpot(string, AdSpot, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            AdSpot adSpot = new AdSpot();
            // Make the request
            AdSpot response = adSpotServiceClient.CreateAdSpot(parent, adSpot);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSpotAsync</summary>
        public async Task CreateAdSpotAsync()
        {
            // Snippet: CreateAdSpotAsync(string, AdSpot, CallSettings)
            // Additional: CreateAdSpotAsync(string, AdSpot, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            AdSpot adSpot = new AdSpot();
            // Make the request
            AdSpot response = await adSpotServiceClient.CreateAdSpotAsync(parent, adSpot);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSpot</summary>
        public void CreateAdSpotResourceNames()
        {
            // Snippet: CreateAdSpot(NetworkName, AdSpot, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            AdSpot adSpot = new AdSpot();
            // Make the request
            AdSpot response = adSpotServiceClient.CreateAdSpot(parent, adSpot);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSpotAsync</summary>
        public async Task CreateAdSpotResourceNamesAsync()
        {
            // Snippet: CreateAdSpotAsync(NetworkName, AdSpot, CallSettings)
            // Additional: CreateAdSpotAsync(NetworkName, AdSpot, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            AdSpot adSpot = new AdSpot();
            // Make the request
            AdSpot response = await adSpotServiceClient.CreateAdSpotAsync(parent, adSpot);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdSpots</summary>
        public void BatchCreateAdSpotsRequestObject()
        {
            // Snippet: BatchCreateAdSpots(BatchCreateAdSpotsRequest, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateAdSpotsRequest request = new BatchCreateAdSpotsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateAdSpotRequest(),
                },
            };
            // Make the request
            BatchCreateAdSpotsResponse response = adSpotServiceClient.BatchCreateAdSpots(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdSpotsAsync</summary>
        public async Task BatchCreateAdSpotsRequestObjectAsync()
        {
            // Snippet: BatchCreateAdSpotsAsync(BatchCreateAdSpotsRequest, CallSettings)
            // Additional: BatchCreateAdSpotsAsync(BatchCreateAdSpotsRequest, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateAdSpotsRequest request = new BatchCreateAdSpotsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateAdSpotRequest(),
                },
            };
            // Make the request
            BatchCreateAdSpotsResponse response = await adSpotServiceClient.BatchCreateAdSpotsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdSpots</summary>
        public void BatchCreateAdSpots()
        {
            // Snippet: BatchCreateAdSpots(string, IEnumerable<CreateAdSpotRequest>, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateAdSpotRequest> requests = new CreateAdSpotRequest[]
            {
                new CreateAdSpotRequest(),
            };
            // Make the request
            BatchCreateAdSpotsResponse response = adSpotServiceClient.BatchCreateAdSpots(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdSpotsAsync</summary>
        public async Task BatchCreateAdSpotsAsync()
        {
            // Snippet: BatchCreateAdSpotsAsync(string, IEnumerable<CreateAdSpotRequest>, CallSettings)
            // Additional: BatchCreateAdSpotsAsync(string, IEnumerable<CreateAdSpotRequest>, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateAdSpotRequest> requests = new CreateAdSpotRequest[]
            {
                new CreateAdSpotRequest(),
            };
            // Make the request
            BatchCreateAdSpotsResponse response = await adSpotServiceClient.BatchCreateAdSpotsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdSpots</summary>
        public void BatchCreateAdSpotsResourceNames()
        {
            // Snippet: BatchCreateAdSpots(NetworkName, IEnumerable<CreateAdSpotRequest>, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateAdSpotRequest> requests = new CreateAdSpotRequest[]
            {
                new CreateAdSpotRequest(),
            };
            // Make the request
            BatchCreateAdSpotsResponse response = adSpotServiceClient.BatchCreateAdSpots(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdSpotsAsync</summary>
        public async Task BatchCreateAdSpotsResourceNamesAsync()
        {
            // Snippet: BatchCreateAdSpotsAsync(NetworkName, IEnumerable<CreateAdSpotRequest>, CallSettings)
            // Additional: BatchCreateAdSpotsAsync(NetworkName, IEnumerable<CreateAdSpotRequest>, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateAdSpotRequest> requests = new CreateAdSpotRequest[]
            {
                new CreateAdSpotRequest(),
            };
            // Make the request
            BatchCreateAdSpotsResponse response = await adSpotServiceClient.BatchCreateAdSpotsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdSpot</summary>
        public void UpdateAdSpotRequestObject()
        {
            // Snippet: UpdateAdSpot(UpdateAdSpotRequest, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            UpdateAdSpotRequest request = new UpdateAdSpotRequest
            {
                AdSpot = new AdSpot(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdSpot response = adSpotServiceClient.UpdateAdSpot(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdSpotAsync</summary>
        public async Task UpdateAdSpotRequestObjectAsync()
        {
            // Snippet: UpdateAdSpotAsync(UpdateAdSpotRequest, CallSettings)
            // Additional: UpdateAdSpotAsync(UpdateAdSpotRequest, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAdSpotRequest request = new UpdateAdSpotRequest
            {
                AdSpot = new AdSpot(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdSpot response = await adSpotServiceClient.UpdateAdSpotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdSpot</summary>
        public void UpdateAdSpot()
        {
            // Snippet: UpdateAdSpot(AdSpot, FieldMask, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            AdSpot adSpot = new AdSpot();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdSpot response = adSpotServiceClient.UpdateAdSpot(adSpot, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdSpotAsync</summary>
        public async Task UpdateAdSpotAsync()
        {
            // Snippet: UpdateAdSpotAsync(AdSpot, FieldMask, CallSettings)
            // Additional: UpdateAdSpotAsync(AdSpot, FieldMask, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdSpot adSpot = new AdSpot();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdSpot response = await adSpotServiceClient.UpdateAdSpotAsync(adSpot, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdSpots</summary>
        public void BatchUpdateAdSpotsRequestObject()
        {
            // Snippet: BatchUpdateAdSpots(BatchUpdateAdSpotsRequest, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateAdSpotsRequest request = new BatchUpdateAdSpotsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateAdSpotRequest(),
                },
            };
            // Make the request
            BatchUpdateAdSpotsResponse response = adSpotServiceClient.BatchUpdateAdSpots(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdSpotsAsync</summary>
        public async Task BatchUpdateAdSpotsRequestObjectAsync()
        {
            // Snippet: BatchUpdateAdSpotsAsync(BatchUpdateAdSpotsRequest, CallSettings)
            // Additional: BatchUpdateAdSpotsAsync(BatchUpdateAdSpotsRequest, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateAdSpotsRequest request = new BatchUpdateAdSpotsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateAdSpotRequest(),
                },
            };
            // Make the request
            BatchUpdateAdSpotsResponse response = await adSpotServiceClient.BatchUpdateAdSpotsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdSpots</summary>
        public void BatchUpdateAdSpots()
        {
            // Snippet: BatchUpdateAdSpots(string, IEnumerable<UpdateAdSpotRequest>, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateAdSpotRequest> requests = new UpdateAdSpotRequest[]
            {
                new UpdateAdSpotRequest(),
            };
            // Make the request
            BatchUpdateAdSpotsResponse response = adSpotServiceClient.BatchUpdateAdSpots(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdSpotsAsync</summary>
        public async Task BatchUpdateAdSpotsAsync()
        {
            // Snippet: BatchUpdateAdSpotsAsync(string, IEnumerable<UpdateAdSpotRequest>, CallSettings)
            // Additional: BatchUpdateAdSpotsAsync(string, IEnumerable<UpdateAdSpotRequest>, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateAdSpotRequest> requests = new UpdateAdSpotRequest[]
            {
                new UpdateAdSpotRequest(),
            };
            // Make the request
            BatchUpdateAdSpotsResponse response = await adSpotServiceClient.BatchUpdateAdSpotsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdSpots</summary>
        public void BatchUpdateAdSpotsResourceNames()
        {
            // Snippet: BatchUpdateAdSpots(NetworkName, IEnumerable<UpdateAdSpotRequest>, CallSettings)
            // Create client
            AdSpotServiceClient adSpotServiceClient = AdSpotServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateAdSpotRequest> requests = new UpdateAdSpotRequest[]
            {
                new UpdateAdSpotRequest(),
            };
            // Make the request
            BatchUpdateAdSpotsResponse response = adSpotServiceClient.BatchUpdateAdSpots(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdSpotsAsync</summary>
        public async Task BatchUpdateAdSpotsResourceNamesAsync()
        {
            // Snippet: BatchUpdateAdSpotsAsync(NetworkName, IEnumerable<UpdateAdSpotRequest>, CallSettings)
            // Additional: BatchUpdateAdSpotsAsync(NetworkName, IEnumerable<UpdateAdSpotRequest>, CancellationToken)
            // Create client
            AdSpotServiceClient adSpotServiceClient = await AdSpotServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateAdSpotRequest> requests = new UpdateAdSpotRequest[]
            {
                new UpdateAdSpotRequest(),
            };
            // Make the request
            BatchUpdateAdSpotsResponse response = await adSpotServiceClient.BatchUpdateAdSpotsAsync(parent, requests);
            // End snippet
        }
    }
}
