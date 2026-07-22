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
    public sealed class AllGeneratedTargetingPresetServiceClientSnippets
    {
        /// <summary>Snippet for GetTargetingPreset</summary>
        public void GetTargetingPresetRequestObject()
        {
            // Snippet: GetTargetingPreset(GetTargetingPresetRequest, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            GetTargetingPresetRequest request = new GetTargetingPresetRequest
            {
                TargetingPresetName = TargetingPresetName.FromNetworkCodeTargetingPreset("[NETWORK_CODE]", "[TARGETING_PRESET]"),
            };
            // Make the request
            TargetingPreset response = targetingPresetServiceClient.GetTargetingPreset(request);
            // End snippet
        }

        /// <summary>Snippet for GetTargetingPresetAsync</summary>
        public async Task GetTargetingPresetRequestObjectAsync()
        {
            // Snippet: GetTargetingPresetAsync(GetTargetingPresetRequest, CallSettings)
            // Additional: GetTargetingPresetAsync(GetTargetingPresetRequest, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetingPresetRequest request = new GetTargetingPresetRequest
            {
                TargetingPresetName = TargetingPresetName.FromNetworkCodeTargetingPreset("[NETWORK_CODE]", "[TARGETING_PRESET]"),
            };
            // Make the request
            TargetingPreset response = await targetingPresetServiceClient.GetTargetingPresetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTargetingPreset</summary>
        public void GetTargetingPreset()
        {
            // Snippet: GetTargetingPreset(string, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/targetingPresets/[TARGETING_PRESET]";
            // Make the request
            TargetingPreset response = targetingPresetServiceClient.GetTargetingPreset(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetingPresetAsync</summary>
        public async Task GetTargetingPresetAsync()
        {
            // Snippet: GetTargetingPresetAsync(string, CallSettings)
            // Additional: GetTargetingPresetAsync(string, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/targetingPresets/[TARGETING_PRESET]";
            // Make the request
            TargetingPreset response = await targetingPresetServiceClient.GetTargetingPresetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetingPreset</summary>
        public void GetTargetingPresetResourceNames()
        {
            // Snippet: GetTargetingPreset(TargetingPresetName, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            TargetingPresetName name = TargetingPresetName.FromNetworkCodeTargetingPreset("[NETWORK_CODE]", "[TARGETING_PRESET]");
            // Make the request
            TargetingPreset response = targetingPresetServiceClient.GetTargetingPreset(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetingPresetAsync</summary>
        public async Task GetTargetingPresetResourceNamesAsync()
        {
            // Snippet: GetTargetingPresetAsync(TargetingPresetName, CallSettings)
            // Additional: GetTargetingPresetAsync(TargetingPresetName, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            TargetingPresetName name = TargetingPresetName.FromNetworkCodeTargetingPreset("[NETWORK_CODE]", "[TARGETING_PRESET]");
            // Make the request
            TargetingPreset response = await targetingPresetServiceClient.GetTargetingPresetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTargetingPresets</summary>
        public void ListTargetingPresetsRequestObject()
        {
            // Snippet: ListTargetingPresets(ListTargetingPresetsRequest, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            ListTargetingPresetsRequest request = new ListTargetingPresetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListTargetingPresetsResponse, TargetingPreset> response = targetingPresetServiceClient.ListTargetingPresets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetingPreset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetingPresetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetingPreset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetingPreset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetingPreset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetingPresetsAsync</summary>
        public async Task ListTargetingPresetsRequestObjectAsync()
        {
            // Snippet: ListTargetingPresetsAsync(ListTargetingPresetsRequest, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetingPresetsRequest request = new ListTargetingPresetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListTargetingPresetsResponse, TargetingPreset> response = targetingPresetServiceClient.ListTargetingPresetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TargetingPreset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTargetingPresetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetingPreset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetingPreset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetingPreset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetingPresets</summary>
        public void ListTargetingPresets()
        {
            // Snippet: ListTargetingPresets(string, string, int?, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListTargetingPresetsResponse, TargetingPreset> response = targetingPresetServiceClient.ListTargetingPresets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetingPreset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetingPresetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetingPreset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetingPreset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetingPreset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetingPresetsAsync</summary>
        public async Task ListTargetingPresetsAsync()
        {
            // Snippet: ListTargetingPresetsAsync(string, string, int?, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListTargetingPresetsResponse, TargetingPreset> response = targetingPresetServiceClient.ListTargetingPresetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TargetingPreset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTargetingPresetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetingPreset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetingPreset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetingPreset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetingPresets</summary>
        public void ListTargetingPresetsResourceNames()
        {
            // Snippet: ListTargetingPresets(NetworkName, string, int?, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListTargetingPresetsResponse, TargetingPreset> response = targetingPresetServiceClient.ListTargetingPresets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TargetingPreset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetingPresetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetingPreset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetingPreset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetingPreset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetingPresetsAsync</summary>
        public async Task ListTargetingPresetsResourceNamesAsync()
        {
            // Snippet: ListTargetingPresetsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListTargetingPresetsResponse, TargetingPreset> response = targetingPresetServiceClient.ListTargetingPresetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (TargetingPreset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListTargetingPresetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TargetingPreset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TargetingPreset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TargetingPreset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTargetingPreset</summary>
        public void CreateTargetingPresetRequestObject()
        {
            // Snippet: CreateTargetingPreset(CreateTargetingPresetRequest, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            CreateTargetingPresetRequest request = new CreateTargetingPresetRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                TargetingPreset = new TargetingPreset(),
            };
            // Make the request
            TargetingPreset response = targetingPresetServiceClient.CreateTargetingPreset(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTargetingPresetAsync</summary>
        public async Task CreateTargetingPresetRequestObjectAsync()
        {
            // Snippet: CreateTargetingPresetAsync(CreateTargetingPresetRequest, CallSettings)
            // Additional: CreateTargetingPresetAsync(CreateTargetingPresetRequest, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTargetingPresetRequest request = new CreateTargetingPresetRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                TargetingPreset = new TargetingPreset(),
            };
            // Make the request
            TargetingPreset response = await targetingPresetServiceClient.CreateTargetingPresetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTargetingPreset</summary>
        public void CreateTargetingPreset()
        {
            // Snippet: CreateTargetingPreset(string, TargetingPreset, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            TargetingPreset targetingPreset = new TargetingPreset();
            // Make the request
            TargetingPreset response = targetingPresetServiceClient.CreateTargetingPreset(parent, targetingPreset);
            // End snippet
        }

        /// <summary>Snippet for CreateTargetingPresetAsync</summary>
        public async Task CreateTargetingPresetAsync()
        {
            // Snippet: CreateTargetingPresetAsync(string, TargetingPreset, CallSettings)
            // Additional: CreateTargetingPresetAsync(string, TargetingPreset, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            TargetingPreset targetingPreset = new TargetingPreset();
            // Make the request
            TargetingPreset response = await targetingPresetServiceClient.CreateTargetingPresetAsync(parent, targetingPreset);
            // End snippet
        }

        /// <summary>Snippet for CreateTargetingPreset</summary>
        public void CreateTargetingPresetResourceNames()
        {
            // Snippet: CreateTargetingPreset(NetworkName, TargetingPreset, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            TargetingPreset targetingPreset = new TargetingPreset();
            // Make the request
            TargetingPreset response = targetingPresetServiceClient.CreateTargetingPreset(parent, targetingPreset);
            // End snippet
        }

        /// <summary>Snippet for CreateTargetingPresetAsync</summary>
        public async Task CreateTargetingPresetResourceNamesAsync()
        {
            // Snippet: CreateTargetingPresetAsync(NetworkName, TargetingPreset, CallSettings)
            // Additional: CreateTargetingPresetAsync(NetworkName, TargetingPreset, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            TargetingPreset targetingPreset = new TargetingPreset();
            // Make the request
            TargetingPreset response = await targetingPresetServiceClient.CreateTargetingPresetAsync(parent, targetingPreset);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTargetingPresets</summary>
        public void BatchCreateTargetingPresetsRequestObject()
        {
            // Snippet: BatchCreateTargetingPresets(BatchCreateTargetingPresetsRequest, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateTargetingPresetsRequest request = new BatchCreateTargetingPresetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateTargetingPresetRequest(),
                },
            };
            // Make the request
            BatchCreateTargetingPresetsResponse response = targetingPresetServiceClient.BatchCreateTargetingPresets(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTargetingPresetsAsync</summary>
        public async Task BatchCreateTargetingPresetsRequestObjectAsync()
        {
            // Snippet: BatchCreateTargetingPresetsAsync(BatchCreateTargetingPresetsRequest, CallSettings)
            // Additional: BatchCreateTargetingPresetsAsync(BatchCreateTargetingPresetsRequest, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateTargetingPresetsRequest request = new BatchCreateTargetingPresetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateTargetingPresetRequest(),
                },
            };
            // Make the request
            BatchCreateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchCreateTargetingPresetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTargetingPresets</summary>
        public void BatchCreateTargetingPresets()
        {
            // Snippet: BatchCreateTargetingPresets(string, IEnumerable<CreateTargetingPresetRequest>, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateTargetingPresetRequest> requests = new CreateTargetingPresetRequest[]
            {
                new CreateTargetingPresetRequest(),
            };
            // Make the request
            BatchCreateTargetingPresetsResponse response = targetingPresetServiceClient.BatchCreateTargetingPresets(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTargetingPresetsAsync</summary>
        public async Task BatchCreateTargetingPresetsAsync()
        {
            // Snippet: BatchCreateTargetingPresetsAsync(string, IEnumerable<CreateTargetingPresetRequest>, CallSettings)
            // Additional: BatchCreateTargetingPresetsAsync(string, IEnumerable<CreateTargetingPresetRequest>, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateTargetingPresetRequest> requests = new CreateTargetingPresetRequest[]
            {
                new CreateTargetingPresetRequest(),
            };
            // Make the request
            BatchCreateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchCreateTargetingPresetsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTargetingPresets</summary>
        public void BatchCreateTargetingPresetsResourceNames()
        {
            // Snippet: BatchCreateTargetingPresets(NetworkName, IEnumerable<CreateTargetingPresetRequest>, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateTargetingPresetRequest> requests = new CreateTargetingPresetRequest[]
            {
                new CreateTargetingPresetRequest(),
            };
            // Make the request
            BatchCreateTargetingPresetsResponse response = targetingPresetServiceClient.BatchCreateTargetingPresets(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateTargetingPresetsAsync</summary>
        public async Task BatchCreateTargetingPresetsResourceNamesAsync()
        {
            // Snippet: BatchCreateTargetingPresetsAsync(NetworkName, IEnumerable<CreateTargetingPresetRequest>, CallSettings)
            // Additional: BatchCreateTargetingPresetsAsync(NetworkName, IEnumerable<CreateTargetingPresetRequest>, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateTargetingPresetRequest> requests = new CreateTargetingPresetRequest[]
            {
                new CreateTargetingPresetRequest(),
            };
            // Make the request
            BatchCreateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchCreateTargetingPresetsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetingPreset</summary>
        public void UpdateTargetingPresetRequestObject()
        {
            // Snippet: UpdateTargetingPreset(UpdateTargetingPresetRequest, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            UpdateTargetingPresetRequest request = new UpdateTargetingPresetRequest
            {
                TargetingPreset = new TargetingPreset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TargetingPreset response = targetingPresetServiceClient.UpdateTargetingPreset(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetingPresetAsync</summary>
        public async Task UpdateTargetingPresetRequestObjectAsync()
        {
            // Snippet: UpdateTargetingPresetAsync(UpdateTargetingPresetRequest, CallSettings)
            // Additional: UpdateTargetingPresetAsync(UpdateTargetingPresetRequest, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTargetingPresetRequest request = new UpdateTargetingPresetRequest
            {
                TargetingPreset = new TargetingPreset(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TargetingPreset response = await targetingPresetServiceClient.UpdateTargetingPresetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetingPreset</summary>
        public void UpdateTargetingPreset()
        {
            // Snippet: UpdateTargetingPreset(TargetingPreset, FieldMask, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            TargetingPreset targetingPreset = new TargetingPreset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TargetingPreset response = targetingPresetServiceClient.UpdateTargetingPreset(targetingPreset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetingPresetAsync</summary>
        public async Task UpdateTargetingPresetAsync()
        {
            // Snippet: UpdateTargetingPresetAsync(TargetingPreset, FieldMask, CallSettings)
            // Additional: UpdateTargetingPresetAsync(TargetingPreset, FieldMask, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            TargetingPreset targetingPreset = new TargetingPreset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TargetingPreset response = await targetingPresetServiceClient.UpdateTargetingPresetAsync(targetingPreset, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTargetingPresets</summary>
        public void BatchUpdateTargetingPresetsRequestObject()
        {
            // Snippet: BatchUpdateTargetingPresets(BatchUpdateTargetingPresetsRequest, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateTargetingPresetsRequest request = new BatchUpdateTargetingPresetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateTargetingPresetRequest(),
                },
            };
            // Make the request
            BatchUpdateTargetingPresetsResponse response = targetingPresetServiceClient.BatchUpdateTargetingPresets(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTargetingPresetsAsync</summary>
        public async Task BatchUpdateTargetingPresetsRequestObjectAsync()
        {
            // Snippet: BatchUpdateTargetingPresetsAsync(BatchUpdateTargetingPresetsRequest, CallSettings)
            // Additional: BatchUpdateTargetingPresetsAsync(BatchUpdateTargetingPresetsRequest, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateTargetingPresetsRequest request = new BatchUpdateTargetingPresetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateTargetingPresetRequest(),
                },
            };
            // Make the request
            BatchUpdateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchUpdateTargetingPresetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTargetingPresets</summary>
        public void BatchUpdateTargetingPresets()
        {
            // Snippet: BatchUpdateTargetingPresets(string, IEnumerable<UpdateTargetingPresetRequest>, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateTargetingPresetRequest> requests = new UpdateTargetingPresetRequest[]
            {
                new UpdateTargetingPresetRequest(),
            };
            // Make the request
            BatchUpdateTargetingPresetsResponse response = targetingPresetServiceClient.BatchUpdateTargetingPresets(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTargetingPresetsAsync</summary>
        public async Task BatchUpdateTargetingPresetsAsync()
        {
            // Snippet: BatchUpdateTargetingPresetsAsync(string, IEnumerable<UpdateTargetingPresetRequest>, CallSettings)
            // Additional: BatchUpdateTargetingPresetsAsync(string, IEnumerable<UpdateTargetingPresetRequest>, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateTargetingPresetRequest> requests = new UpdateTargetingPresetRequest[]
            {
                new UpdateTargetingPresetRequest(),
            };
            // Make the request
            BatchUpdateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchUpdateTargetingPresetsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTargetingPresets</summary>
        public void BatchUpdateTargetingPresetsResourceNames()
        {
            // Snippet: BatchUpdateTargetingPresets(NetworkName, IEnumerable<UpdateTargetingPresetRequest>, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateTargetingPresetRequest> requests = new UpdateTargetingPresetRequest[]
            {
                new UpdateTargetingPresetRequest(),
            };
            // Make the request
            BatchUpdateTargetingPresetsResponse response = targetingPresetServiceClient.BatchUpdateTargetingPresets(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateTargetingPresetsAsync</summary>
        public async Task BatchUpdateTargetingPresetsResourceNamesAsync()
        {
            // Snippet: BatchUpdateTargetingPresetsAsync(NetworkName, IEnumerable<UpdateTargetingPresetRequest>, CallSettings)
            // Additional: BatchUpdateTargetingPresetsAsync(NetworkName, IEnumerable<UpdateTargetingPresetRequest>, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateTargetingPresetRequest> requests = new UpdateTargetingPresetRequest[]
            {
                new UpdateTargetingPresetRequest(),
            };
            // Make the request
            BatchUpdateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchUpdateTargetingPresetsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTargetingPresets</summary>
        public void BatchDeactivateTargetingPresetsRequestObject()
        {
            // Snippet: BatchDeactivateTargetingPresets(BatchDeactivateTargetingPresetsRequest, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateTargetingPresetsRequest request = new BatchDeactivateTargetingPresetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new DeactivateTargetingPresetRequest(),
                },
            };
            // Make the request
            BatchDeactivateTargetingPresetsResponse response = targetingPresetServiceClient.BatchDeactivateTargetingPresets(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTargetingPresetsAsync</summary>
        public async Task BatchDeactivateTargetingPresetsRequestObjectAsync()
        {
            // Snippet: BatchDeactivateTargetingPresetsAsync(BatchDeactivateTargetingPresetsRequest, CallSettings)
            // Additional: BatchDeactivateTargetingPresetsAsync(BatchDeactivateTargetingPresetsRequest, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateTargetingPresetsRequest request = new BatchDeactivateTargetingPresetsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new DeactivateTargetingPresetRequest(),
                },
            };
            // Make the request
            BatchDeactivateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchDeactivateTargetingPresetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTargetingPresets</summary>
        public void BatchDeactivateTargetingPresets()
        {
            // Snippet: BatchDeactivateTargetingPresets(string, IEnumerable<DeactivateTargetingPresetRequest>, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<DeactivateTargetingPresetRequest> requests = new DeactivateTargetingPresetRequest[]
            {
                new DeactivateTargetingPresetRequest(),
            };
            // Make the request
            BatchDeactivateTargetingPresetsResponse response = targetingPresetServiceClient.BatchDeactivateTargetingPresets(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTargetingPresetsAsync</summary>
        public async Task BatchDeactivateTargetingPresetsAsync()
        {
            // Snippet: BatchDeactivateTargetingPresetsAsync(string, IEnumerable<DeactivateTargetingPresetRequest>, CallSettings)
            // Additional: BatchDeactivateTargetingPresetsAsync(string, IEnumerable<DeactivateTargetingPresetRequest>, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<DeactivateTargetingPresetRequest> requests = new DeactivateTargetingPresetRequest[]
            {
                new DeactivateTargetingPresetRequest(),
            };
            // Make the request
            BatchDeactivateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchDeactivateTargetingPresetsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTargetingPresets</summary>
        public void BatchDeactivateTargetingPresetsResourceNames()
        {
            // Snippet: BatchDeactivateTargetingPresets(NetworkName, IEnumerable<DeactivateTargetingPresetRequest>, CallSettings)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = TargetingPresetServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<DeactivateTargetingPresetRequest> requests = new DeactivateTargetingPresetRequest[]
            {
                new DeactivateTargetingPresetRequest(),
            };
            // Make the request
            BatchDeactivateTargetingPresetsResponse response = targetingPresetServiceClient.BatchDeactivateTargetingPresets(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateTargetingPresetsAsync</summary>
        public async Task BatchDeactivateTargetingPresetsResourceNamesAsync()
        {
            // Snippet: BatchDeactivateTargetingPresetsAsync(NetworkName, IEnumerable<DeactivateTargetingPresetRequest>, CallSettings)
            // Additional: BatchDeactivateTargetingPresetsAsync(NetworkName, IEnumerable<DeactivateTargetingPresetRequest>, CancellationToken)
            // Create client
            TargetingPresetServiceClient targetingPresetServiceClient = await TargetingPresetServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<DeactivateTargetingPresetRequest> requests = new DeactivateTargetingPresetRequest[]
            {
                new DeactivateTargetingPresetRequest(),
            };
            // Make the request
            BatchDeactivateTargetingPresetsResponse response = await targetingPresetServiceClient.BatchDeactivateTargetingPresetsAsync(parent, requests);
            // End snippet
        }
    }
}
