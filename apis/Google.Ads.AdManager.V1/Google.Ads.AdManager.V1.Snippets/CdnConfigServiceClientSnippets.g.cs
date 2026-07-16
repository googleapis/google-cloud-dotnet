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
    public sealed class AllGeneratedCdnConfigServiceClientSnippets
    {
        /// <summary>Snippet for GetCdnConfig</summary>
        public void GetCdnConfigRequestObject()
        {
            // Snippet: GetCdnConfig(GetCdnConfigRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            GetCdnConfigRequest request = new GetCdnConfigRequest
            {
                CdnConfigName = CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
            };
            // Make the request
            CdnConfig response = cdnConfigServiceClient.GetCdnConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetCdnConfigAsync</summary>
        public async Task GetCdnConfigRequestObjectAsync()
        {
            // Snippet: GetCdnConfigAsync(GetCdnConfigRequest, CallSettings)
            // Additional: GetCdnConfigAsync(GetCdnConfigRequest, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCdnConfigRequest request = new GetCdnConfigRequest
            {
                CdnConfigName = CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
            };
            // Make the request
            CdnConfig response = await cdnConfigServiceClient.GetCdnConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCdnConfig</summary>
        public void GetCdnConfig()
        {
            // Snippet: GetCdnConfig(string, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/cdnConfigs/[CDN_CONFIG]";
            // Make the request
            CdnConfig response = cdnConfigServiceClient.GetCdnConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetCdnConfigAsync</summary>
        public async Task GetCdnConfigAsync()
        {
            // Snippet: GetCdnConfigAsync(string, CallSettings)
            // Additional: GetCdnConfigAsync(string, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/cdnConfigs/[CDN_CONFIG]";
            // Make the request
            CdnConfig response = await cdnConfigServiceClient.GetCdnConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCdnConfig</summary>
        public void GetCdnConfigResourceNames()
        {
            // Snippet: GetCdnConfig(CdnConfigName, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            CdnConfigName name = CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]");
            // Make the request
            CdnConfig response = cdnConfigServiceClient.GetCdnConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetCdnConfigAsync</summary>
        public async Task GetCdnConfigResourceNamesAsync()
        {
            // Snippet: GetCdnConfigAsync(CdnConfigName, CallSettings)
            // Additional: GetCdnConfigAsync(CdnConfigName, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CdnConfigName name = CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]");
            // Make the request
            CdnConfig response = await cdnConfigServiceClient.GetCdnConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCdnConfigs</summary>
        public void ListCdnConfigsRequestObject()
        {
            // Snippet: ListCdnConfigs(ListCdnConfigsRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            ListCdnConfigsRequest request = new ListCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCdnConfigsResponse, CdnConfig> response = cdnConfigServiceClient.ListCdnConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CdnConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCdnConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnConfigsAsync</summary>
        public async Task ListCdnConfigsRequestObjectAsync()
        {
            // Snippet: ListCdnConfigsAsync(ListCdnConfigsRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCdnConfigsRequest request = new ListCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCdnConfigsResponse, CdnConfig> response = cdnConfigServiceClient.ListCdnConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CdnConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCdnConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnConfigs</summary>
        public void ListCdnConfigs()
        {
            // Snippet: ListCdnConfigs(string, string, int?, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCdnConfigsResponse, CdnConfig> response = cdnConfigServiceClient.ListCdnConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CdnConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCdnConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnConfigsAsync</summary>
        public async Task ListCdnConfigsAsync()
        {
            // Snippet: ListCdnConfigsAsync(string, string, int?, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCdnConfigsResponse, CdnConfig> response = cdnConfigServiceClient.ListCdnConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CdnConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCdnConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnConfigs</summary>
        public void ListCdnConfigsResourceNames()
        {
            // Snippet: ListCdnConfigs(NetworkName, string, int?, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCdnConfigsResponse, CdnConfig> response = cdnConfigServiceClient.ListCdnConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CdnConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCdnConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCdnConfigsAsync</summary>
        public async Task ListCdnConfigsResourceNamesAsync()
        {
            // Snippet: ListCdnConfigsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCdnConfigsResponse, CdnConfig> response = cdnConfigServiceClient.ListCdnConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CdnConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCdnConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CdnConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CdnConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CdnConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateCdnConfig</summary>
        public void CreateCdnConfigRequestObject()
        {
            // Snippet: CreateCdnConfig(CreateCdnConfigRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            CreateCdnConfigRequest request = new CreateCdnConfigRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CdnConfig = new CdnConfig(),
            };
            // Make the request
            CdnConfig response = cdnConfigServiceClient.CreateCdnConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnConfigAsync</summary>
        public async Task CreateCdnConfigRequestObjectAsync()
        {
            // Snippet: CreateCdnConfigAsync(CreateCdnConfigRequest, CallSettings)
            // Additional: CreateCdnConfigAsync(CreateCdnConfigRequest, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCdnConfigRequest request = new CreateCdnConfigRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CdnConfig = new CdnConfig(),
            };
            // Make the request
            CdnConfig response = await cdnConfigServiceClient.CreateCdnConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnConfig</summary>
        public void CreateCdnConfig()
        {
            // Snippet: CreateCdnConfig(string, CdnConfig, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CdnConfig cdnConfig = new CdnConfig();
            // Make the request
            CdnConfig response = cdnConfigServiceClient.CreateCdnConfig(parent, cdnConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnConfigAsync</summary>
        public async Task CreateCdnConfigAsync()
        {
            // Snippet: CreateCdnConfigAsync(string, CdnConfig, CallSettings)
            // Additional: CreateCdnConfigAsync(string, CdnConfig, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CdnConfig cdnConfig = new CdnConfig();
            // Make the request
            CdnConfig response = await cdnConfigServiceClient.CreateCdnConfigAsync(parent, cdnConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnConfig</summary>
        public void CreateCdnConfigResourceNames()
        {
            // Snippet: CreateCdnConfig(NetworkName, CdnConfig, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CdnConfig cdnConfig = new CdnConfig();
            // Make the request
            CdnConfig response = cdnConfigServiceClient.CreateCdnConfig(parent, cdnConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateCdnConfigAsync</summary>
        public async Task CreateCdnConfigResourceNamesAsync()
        {
            // Snippet: CreateCdnConfigAsync(NetworkName, CdnConfig, CallSettings)
            // Additional: CreateCdnConfigAsync(NetworkName, CdnConfig, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CdnConfig cdnConfig = new CdnConfig();
            // Make the request
            CdnConfig response = await cdnConfigServiceClient.CreateCdnConfigAsync(parent, cdnConfig);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCdnConfigs</summary>
        public void BatchCreateCdnConfigsRequestObject()
        {
            // Snippet: BatchCreateCdnConfigs(BatchCreateCdnConfigsRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateCdnConfigsRequest request = new BatchCreateCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateCdnConfigRequest(),
                },
            };
            // Make the request
            BatchCreateCdnConfigsResponse response = cdnConfigServiceClient.BatchCreateCdnConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCdnConfigsAsync</summary>
        public async Task BatchCreateCdnConfigsRequestObjectAsync()
        {
            // Snippet: BatchCreateCdnConfigsAsync(BatchCreateCdnConfigsRequest, CallSettings)
            // Additional: BatchCreateCdnConfigsAsync(BatchCreateCdnConfigsRequest, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateCdnConfigsRequest request = new BatchCreateCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateCdnConfigRequest(),
                },
            };
            // Make the request
            BatchCreateCdnConfigsResponse response = await cdnConfigServiceClient.BatchCreateCdnConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCdnConfigs</summary>
        public void BatchCreateCdnConfigs()
        {
            // Snippet: BatchCreateCdnConfigs(string, IEnumerable<CreateCdnConfigRequest>, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateCdnConfigRequest> requests = new CreateCdnConfigRequest[]
            {
                new CreateCdnConfigRequest(),
            };
            // Make the request
            BatchCreateCdnConfigsResponse response = cdnConfigServiceClient.BatchCreateCdnConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCdnConfigsAsync</summary>
        public async Task BatchCreateCdnConfigsAsync()
        {
            // Snippet: BatchCreateCdnConfigsAsync(string, IEnumerable<CreateCdnConfigRequest>, CallSettings)
            // Additional: BatchCreateCdnConfigsAsync(string, IEnumerable<CreateCdnConfigRequest>, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateCdnConfigRequest> requests = new CreateCdnConfigRequest[]
            {
                new CreateCdnConfigRequest(),
            };
            // Make the request
            BatchCreateCdnConfigsResponse response = await cdnConfigServiceClient.BatchCreateCdnConfigsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCdnConfigs</summary>
        public void BatchCreateCdnConfigsResourceNames()
        {
            // Snippet: BatchCreateCdnConfigs(NetworkName, IEnumerable<CreateCdnConfigRequest>, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateCdnConfigRequest> requests = new CreateCdnConfigRequest[]
            {
                new CreateCdnConfigRequest(),
            };
            // Make the request
            BatchCreateCdnConfigsResponse response = cdnConfigServiceClient.BatchCreateCdnConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCdnConfigsAsync</summary>
        public async Task BatchCreateCdnConfigsResourceNamesAsync()
        {
            // Snippet: BatchCreateCdnConfigsAsync(NetworkName, IEnumerable<CreateCdnConfigRequest>, CallSettings)
            // Additional: BatchCreateCdnConfigsAsync(NetworkName, IEnumerable<CreateCdnConfigRequest>, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateCdnConfigRequest> requests = new CreateCdnConfigRequest[]
            {
                new CreateCdnConfigRequest(),
            };
            // Make the request
            BatchCreateCdnConfigsResponse response = await cdnConfigServiceClient.BatchCreateCdnConfigsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateCdnConfig</summary>
        public void UpdateCdnConfigRequestObject()
        {
            // Snippet: UpdateCdnConfig(UpdateCdnConfigRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateCdnConfigRequest request = new UpdateCdnConfigRequest
            {
                CdnConfig = new CdnConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CdnConfig response = cdnConfigServiceClient.UpdateCdnConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCdnConfigAsync</summary>
        public async Task UpdateCdnConfigRequestObjectAsync()
        {
            // Snippet: UpdateCdnConfigAsync(UpdateCdnConfigRequest, CallSettings)
            // Additional: UpdateCdnConfigAsync(UpdateCdnConfigRequest, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCdnConfigRequest request = new UpdateCdnConfigRequest
            {
                CdnConfig = new CdnConfig(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CdnConfig response = await cdnConfigServiceClient.UpdateCdnConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCdnConfig</summary>
        public void UpdateCdnConfig()
        {
            // Snippet: UpdateCdnConfig(CdnConfig, FieldMask, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            CdnConfig cdnConfig = new CdnConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CdnConfig response = cdnConfigServiceClient.UpdateCdnConfig(cdnConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCdnConfigAsync</summary>
        public async Task UpdateCdnConfigAsync()
        {
            // Snippet: UpdateCdnConfigAsync(CdnConfig, FieldMask, CallSettings)
            // Additional: UpdateCdnConfigAsync(CdnConfig, FieldMask, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CdnConfig cdnConfig = new CdnConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CdnConfig response = await cdnConfigServiceClient.UpdateCdnConfigAsync(cdnConfig, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCdnConfigs</summary>
        public void BatchUpdateCdnConfigsRequestObject()
        {
            // Snippet: BatchUpdateCdnConfigs(BatchUpdateCdnConfigsRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateCdnConfigsRequest request = new BatchUpdateCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateCdnConfigRequest(),
                },
            };
            // Make the request
            BatchUpdateCdnConfigsResponse response = cdnConfigServiceClient.BatchUpdateCdnConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCdnConfigsAsync</summary>
        public async Task BatchUpdateCdnConfigsRequestObjectAsync()
        {
            // Snippet: BatchUpdateCdnConfigsAsync(BatchUpdateCdnConfigsRequest, CallSettings)
            // Additional: BatchUpdateCdnConfigsAsync(BatchUpdateCdnConfigsRequest, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateCdnConfigsRequest request = new BatchUpdateCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateCdnConfigRequest(),
                },
            };
            // Make the request
            BatchUpdateCdnConfigsResponse response = await cdnConfigServiceClient.BatchUpdateCdnConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCdnConfigs</summary>
        public void BatchUpdateCdnConfigs()
        {
            // Snippet: BatchUpdateCdnConfigs(string, IEnumerable<UpdateCdnConfigRequest>, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateCdnConfigRequest> requests = new UpdateCdnConfigRequest[]
            {
                new UpdateCdnConfigRequest(),
            };
            // Make the request
            BatchUpdateCdnConfigsResponse response = cdnConfigServiceClient.BatchUpdateCdnConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCdnConfigsAsync</summary>
        public async Task BatchUpdateCdnConfigsAsync()
        {
            // Snippet: BatchUpdateCdnConfigsAsync(string, IEnumerable<UpdateCdnConfigRequest>, CallSettings)
            // Additional: BatchUpdateCdnConfigsAsync(string, IEnumerable<UpdateCdnConfigRequest>, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateCdnConfigRequest> requests = new UpdateCdnConfigRequest[]
            {
                new UpdateCdnConfigRequest(),
            };
            // Make the request
            BatchUpdateCdnConfigsResponse response = await cdnConfigServiceClient.BatchUpdateCdnConfigsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCdnConfigs</summary>
        public void BatchUpdateCdnConfigsResourceNames()
        {
            // Snippet: BatchUpdateCdnConfigs(NetworkName, IEnumerable<UpdateCdnConfigRequest>, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateCdnConfigRequest> requests = new UpdateCdnConfigRequest[]
            {
                new UpdateCdnConfigRequest(),
            };
            // Make the request
            BatchUpdateCdnConfigsResponse response = cdnConfigServiceClient.BatchUpdateCdnConfigs(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCdnConfigsAsync</summary>
        public async Task BatchUpdateCdnConfigsResourceNamesAsync()
        {
            // Snippet: BatchUpdateCdnConfigsAsync(NetworkName, IEnumerable<UpdateCdnConfigRequest>, CallSettings)
            // Additional: BatchUpdateCdnConfigsAsync(NetworkName, IEnumerable<UpdateCdnConfigRequest>, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateCdnConfigRequest> requests = new UpdateCdnConfigRequest[]
            {
                new UpdateCdnConfigRequest(),
            };
            // Make the request
            BatchUpdateCdnConfigsResponse response = await cdnConfigServiceClient.BatchUpdateCdnConfigsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCdnConfigs</summary>
        public void BatchActivateCdnConfigsRequestObject()
        {
            // Snippet: BatchActivateCdnConfigs(BatchActivateCdnConfigsRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateCdnConfigsRequest request = new BatchActivateCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CdnConfigNames =
                {
                    CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
                },
            };
            // Make the request
            BatchActivateCdnConfigsResponse response = cdnConfigServiceClient.BatchActivateCdnConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCdnConfigsAsync</summary>
        public async Task BatchActivateCdnConfigsRequestObjectAsync()
        {
            // Snippet: BatchActivateCdnConfigsAsync(BatchActivateCdnConfigsRequest, CallSettings)
            // Additional: BatchActivateCdnConfigsAsync(BatchActivateCdnConfigsRequest, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateCdnConfigsRequest request = new BatchActivateCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CdnConfigNames =
                {
                    CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
                },
            };
            // Make the request
            BatchActivateCdnConfigsResponse response = await cdnConfigServiceClient.BatchActivateCdnConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCdnConfigs</summary>
        public void BatchActivateCdnConfigs()
        {
            // Snippet: BatchActivateCdnConfigs(string, IEnumerable<string>, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/cdnConfigs/[CDN_CONFIG]",
            };
            // Make the request
            BatchActivateCdnConfigsResponse response = cdnConfigServiceClient.BatchActivateCdnConfigs(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCdnConfigsAsync</summary>
        public async Task BatchActivateCdnConfigsAsync()
        {
            // Snippet: BatchActivateCdnConfigsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateCdnConfigsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/cdnConfigs/[CDN_CONFIG]",
            };
            // Make the request
            BatchActivateCdnConfigsResponse response = await cdnConfigServiceClient.BatchActivateCdnConfigsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCdnConfigs</summary>
        public void BatchActivateCdnConfigsResourceNames()
        {
            // Snippet: BatchActivateCdnConfigs(NetworkName, IEnumerable<CdnConfigName>, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CdnConfigName> names = new CdnConfigName[]
            {
                CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
            };
            // Make the request
            BatchActivateCdnConfigsResponse response = cdnConfigServiceClient.BatchActivateCdnConfigs(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCdnConfigsAsync</summary>
        public async Task BatchActivateCdnConfigsResourceNamesAsync()
        {
            // Snippet: BatchActivateCdnConfigsAsync(NetworkName, IEnumerable<CdnConfigName>, CallSettings)
            // Additional: BatchActivateCdnConfigsAsync(NetworkName, IEnumerable<CdnConfigName>, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CdnConfigName> names = new CdnConfigName[]
            {
                CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
            };
            // Make the request
            BatchActivateCdnConfigsResponse response = await cdnConfigServiceClient.BatchActivateCdnConfigsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveCdnConfigs</summary>
        public void BatchArchiveCdnConfigsRequestObject()
        {
            // Snippet: BatchArchiveCdnConfigs(BatchArchiveCdnConfigsRequest, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveCdnConfigsRequest request = new BatchArchiveCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CdnConfigNames =
                {
                    CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
                },
            };
            // Make the request
            BatchArchiveCdnConfigsResponse response = cdnConfigServiceClient.BatchArchiveCdnConfigs(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveCdnConfigsAsync</summary>
        public async Task BatchArchiveCdnConfigsRequestObjectAsync()
        {
            // Snippet: BatchArchiveCdnConfigsAsync(BatchArchiveCdnConfigsRequest, CallSettings)
            // Additional: BatchArchiveCdnConfigsAsync(BatchArchiveCdnConfigsRequest, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveCdnConfigsRequest request = new BatchArchiveCdnConfigsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CdnConfigNames =
                {
                    CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
                },
            };
            // Make the request
            BatchArchiveCdnConfigsResponse response = await cdnConfigServiceClient.BatchArchiveCdnConfigsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveCdnConfigs</summary>
        public void BatchArchiveCdnConfigs()
        {
            // Snippet: BatchArchiveCdnConfigs(string, IEnumerable<string>, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/cdnConfigs/[CDN_CONFIG]",
            };
            // Make the request
            BatchArchiveCdnConfigsResponse response = cdnConfigServiceClient.BatchArchiveCdnConfigs(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveCdnConfigsAsync</summary>
        public async Task BatchArchiveCdnConfigsAsync()
        {
            // Snippet: BatchArchiveCdnConfigsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveCdnConfigsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/cdnConfigs/[CDN_CONFIG]",
            };
            // Make the request
            BatchArchiveCdnConfigsResponse response = await cdnConfigServiceClient.BatchArchiveCdnConfigsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveCdnConfigs</summary>
        public void BatchArchiveCdnConfigsResourceNames()
        {
            // Snippet: BatchArchiveCdnConfigs(NetworkName, IEnumerable<CdnConfigName>, CallSettings)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = CdnConfigServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CdnConfigName> names = new CdnConfigName[]
            {
                CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
            };
            // Make the request
            BatchArchiveCdnConfigsResponse response = cdnConfigServiceClient.BatchArchiveCdnConfigs(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveCdnConfigsAsync</summary>
        public async Task BatchArchiveCdnConfigsResourceNamesAsync()
        {
            // Snippet: BatchArchiveCdnConfigsAsync(NetworkName, IEnumerable<CdnConfigName>, CallSettings)
            // Additional: BatchArchiveCdnConfigsAsync(NetworkName, IEnumerable<CdnConfigName>, CancellationToken)
            // Create client
            CdnConfigServiceClient cdnConfigServiceClient = await CdnConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CdnConfigName> names = new CdnConfigName[]
            {
                CdnConfigName.FromNetworkCodeCdnConfig("[NETWORK_CODE]", "[CDN_CONFIG]"),
            };
            // Make the request
            BatchArchiveCdnConfigsResponse response = await cdnConfigServiceClient.BatchArchiveCdnConfigsAsync(parent, names);
            // End snippet
        }
    }
}
