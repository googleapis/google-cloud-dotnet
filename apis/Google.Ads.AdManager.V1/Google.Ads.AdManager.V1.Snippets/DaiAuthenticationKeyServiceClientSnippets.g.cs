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
    public sealed class AllGeneratedDaiAuthenticationKeyServiceClientSnippets
    {
        /// <summary>Snippet for GetDaiAuthenticationKey</summary>
        public void GetDaiAuthenticationKeyRequestObject()
        {
            // Snippet: GetDaiAuthenticationKey(GetDaiAuthenticationKeyRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            GetDaiAuthenticationKeyRequest request = new GetDaiAuthenticationKeyRequest
            {
                DaiAuthenticationKeyName = DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
            };
            // Make the request
            DaiAuthenticationKey response = daiAuthenticationKeyServiceClient.GetDaiAuthenticationKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetDaiAuthenticationKeyAsync</summary>
        public async Task GetDaiAuthenticationKeyRequestObjectAsync()
        {
            // Snippet: GetDaiAuthenticationKeyAsync(GetDaiAuthenticationKeyRequest, CallSettings)
            // Additional: GetDaiAuthenticationKeyAsync(GetDaiAuthenticationKeyRequest, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDaiAuthenticationKeyRequest request = new GetDaiAuthenticationKeyRequest
            {
                DaiAuthenticationKeyName = DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
            };
            // Make the request
            DaiAuthenticationKey response = await daiAuthenticationKeyServiceClient.GetDaiAuthenticationKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDaiAuthenticationKey</summary>
        public void GetDaiAuthenticationKey()
        {
            // Snippet: GetDaiAuthenticationKey(string, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/daiAuthenticationKeys/[DAI_AUTHENTICATION_KEY]";
            // Make the request
            DaiAuthenticationKey response = daiAuthenticationKeyServiceClient.GetDaiAuthenticationKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiAuthenticationKeyAsync</summary>
        public async Task GetDaiAuthenticationKeyAsync()
        {
            // Snippet: GetDaiAuthenticationKeyAsync(string, CallSettings)
            // Additional: GetDaiAuthenticationKeyAsync(string, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/daiAuthenticationKeys/[DAI_AUTHENTICATION_KEY]";
            // Make the request
            DaiAuthenticationKey response = await daiAuthenticationKeyServiceClient.GetDaiAuthenticationKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiAuthenticationKey</summary>
        public void GetDaiAuthenticationKeyResourceNames()
        {
            // Snippet: GetDaiAuthenticationKey(DaiAuthenticationKeyName, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            DaiAuthenticationKeyName name = DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]");
            // Make the request
            DaiAuthenticationKey response = daiAuthenticationKeyServiceClient.GetDaiAuthenticationKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetDaiAuthenticationKeyAsync</summary>
        public async Task GetDaiAuthenticationKeyResourceNamesAsync()
        {
            // Snippet: GetDaiAuthenticationKeyAsync(DaiAuthenticationKeyName, CallSettings)
            // Additional: GetDaiAuthenticationKeyAsync(DaiAuthenticationKeyName, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DaiAuthenticationKeyName name = DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]");
            // Make the request
            DaiAuthenticationKey response = await daiAuthenticationKeyServiceClient.GetDaiAuthenticationKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDaiAuthenticationKeys</summary>
        public void ListDaiAuthenticationKeysRequestObject()
        {
            // Snippet: ListDaiAuthenticationKeys(ListDaiAuthenticationKeysRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            ListDaiAuthenticationKeysRequest request = new ListDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> response = daiAuthenticationKeyServiceClient.ListDaiAuthenticationKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DaiAuthenticationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDaiAuthenticationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiAuthenticationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiAuthenticationKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiAuthenticationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiAuthenticationKeysAsync</summary>
        public async Task ListDaiAuthenticationKeysRequestObjectAsync()
        {
            // Snippet: ListDaiAuthenticationKeysAsync(ListDaiAuthenticationKeysRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDaiAuthenticationKeysRequest request = new ListDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> response = daiAuthenticationKeyServiceClient.ListDaiAuthenticationKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DaiAuthenticationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDaiAuthenticationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiAuthenticationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiAuthenticationKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiAuthenticationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiAuthenticationKeys</summary>
        public void ListDaiAuthenticationKeys()
        {
            // Snippet: ListDaiAuthenticationKeys(string, string, int?, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> response = daiAuthenticationKeyServiceClient.ListDaiAuthenticationKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DaiAuthenticationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDaiAuthenticationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiAuthenticationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiAuthenticationKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiAuthenticationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiAuthenticationKeysAsync</summary>
        public async Task ListDaiAuthenticationKeysAsync()
        {
            // Snippet: ListDaiAuthenticationKeysAsync(string, string, int?, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> response = daiAuthenticationKeyServiceClient.ListDaiAuthenticationKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DaiAuthenticationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDaiAuthenticationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiAuthenticationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiAuthenticationKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiAuthenticationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiAuthenticationKeys</summary>
        public void ListDaiAuthenticationKeysResourceNames()
        {
            // Snippet: ListDaiAuthenticationKeys(NetworkName, string, int?, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> response = daiAuthenticationKeyServiceClient.ListDaiAuthenticationKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DaiAuthenticationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDaiAuthenticationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiAuthenticationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiAuthenticationKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiAuthenticationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDaiAuthenticationKeysAsync</summary>
        public async Task ListDaiAuthenticationKeysResourceNamesAsync()
        {
            // Snippet: ListDaiAuthenticationKeysAsync(NetworkName, string, int?, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListDaiAuthenticationKeysResponse, DaiAuthenticationKey> response = daiAuthenticationKeyServiceClient.ListDaiAuthenticationKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DaiAuthenticationKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDaiAuthenticationKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DaiAuthenticationKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DaiAuthenticationKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DaiAuthenticationKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDaiAuthenticationKey</summary>
        public void CreateDaiAuthenticationKeyRequestObject()
        {
            // Snippet: CreateDaiAuthenticationKey(CreateDaiAuthenticationKeyRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            CreateDaiAuthenticationKeyRequest request = new CreateDaiAuthenticationKeyRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DaiAuthenticationKey = new DaiAuthenticationKey(),
            };
            // Make the request
            DaiAuthenticationKey response = daiAuthenticationKeyServiceClient.CreateDaiAuthenticationKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiAuthenticationKeyAsync</summary>
        public async Task CreateDaiAuthenticationKeyRequestObjectAsync()
        {
            // Snippet: CreateDaiAuthenticationKeyAsync(CreateDaiAuthenticationKeyRequest, CallSettings)
            // Additional: CreateDaiAuthenticationKeyAsync(CreateDaiAuthenticationKeyRequest, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDaiAuthenticationKeyRequest request = new CreateDaiAuthenticationKeyRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DaiAuthenticationKey = new DaiAuthenticationKey(),
            };
            // Make the request
            DaiAuthenticationKey response = await daiAuthenticationKeyServiceClient.CreateDaiAuthenticationKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiAuthenticationKey</summary>
        public void CreateDaiAuthenticationKey()
        {
            // Snippet: CreateDaiAuthenticationKey(string, DaiAuthenticationKey, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            DaiAuthenticationKey daiAuthenticationKey = new DaiAuthenticationKey();
            // Make the request
            DaiAuthenticationKey response = daiAuthenticationKeyServiceClient.CreateDaiAuthenticationKey(parent, daiAuthenticationKey);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiAuthenticationKeyAsync</summary>
        public async Task CreateDaiAuthenticationKeyAsync()
        {
            // Snippet: CreateDaiAuthenticationKeyAsync(string, DaiAuthenticationKey, CallSettings)
            // Additional: CreateDaiAuthenticationKeyAsync(string, DaiAuthenticationKey, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            DaiAuthenticationKey daiAuthenticationKey = new DaiAuthenticationKey();
            // Make the request
            DaiAuthenticationKey response = await daiAuthenticationKeyServiceClient.CreateDaiAuthenticationKeyAsync(parent, daiAuthenticationKey);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiAuthenticationKey</summary>
        public void CreateDaiAuthenticationKeyResourceNames()
        {
            // Snippet: CreateDaiAuthenticationKey(NetworkName, DaiAuthenticationKey, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            DaiAuthenticationKey daiAuthenticationKey = new DaiAuthenticationKey();
            // Make the request
            DaiAuthenticationKey response = daiAuthenticationKeyServiceClient.CreateDaiAuthenticationKey(parent, daiAuthenticationKey);
            // End snippet
        }

        /// <summary>Snippet for CreateDaiAuthenticationKeyAsync</summary>
        public async Task CreateDaiAuthenticationKeyResourceNamesAsync()
        {
            // Snippet: CreateDaiAuthenticationKeyAsync(NetworkName, DaiAuthenticationKey, CallSettings)
            // Additional: CreateDaiAuthenticationKeyAsync(NetworkName, DaiAuthenticationKey, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            DaiAuthenticationKey daiAuthenticationKey = new DaiAuthenticationKey();
            // Make the request
            DaiAuthenticationKey response = await daiAuthenticationKeyServiceClient.CreateDaiAuthenticationKeyAsync(parent, daiAuthenticationKey);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiAuthenticationKeys</summary>
        public void BatchCreateDaiAuthenticationKeysRequestObject()
        {
            // Snippet: BatchCreateDaiAuthenticationKeys(BatchCreateDaiAuthenticationKeysRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateDaiAuthenticationKeysRequest request = new BatchCreateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateDaiAuthenticationKeyRequest(),
                },
            };
            // Make the request
            BatchCreateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchCreateDaiAuthenticationKeys(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiAuthenticationKeysAsync</summary>
        public async Task BatchCreateDaiAuthenticationKeysRequestObjectAsync()
        {
            // Snippet: BatchCreateDaiAuthenticationKeysAsync(BatchCreateDaiAuthenticationKeysRequest, CallSettings)
            // Additional: BatchCreateDaiAuthenticationKeysAsync(BatchCreateDaiAuthenticationKeysRequest, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateDaiAuthenticationKeysRequest request = new BatchCreateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateDaiAuthenticationKeyRequest(),
                },
            };
            // Make the request
            BatchCreateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchCreateDaiAuthenticationKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiAuthenticationKeys</summary>
        public void BatchCreateDaiAuthenticationKeys()
        {
            // Snippet: BatchCreateDaiAuthenticationKeys(string, IEnumerable<CreateDaiAuthenticationKeyRequest>, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateDaiAuthenticationKeyRequest> requests = new CreateDaiAuthenticationKeyRequest[]
            {
                new CreateDaiAuthenticationKeyRequest(),
            };
            // Make the request
            BatchCreateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchCreateDaiAuthenticationKeys(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiAuthenticationKeysAsync</summary>
        public async Task BatchCreateDaiAuthenticationKeysAsync()
        {
            // Snippet: BatchCreateDaiAuthenticationKeysAsync(string, IEnumerable<CreateDaiAuthenticationKeyRequest>, CallSettings)
            // Additional: BatchCreateDaiAuthenticationKeysAsync(string, IEnumerable<CreateDaiAuthenticationKeyRequest>, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateDaiAuthenticationKeyRequest> requests = new CreateDaiAuthenticationKeyRequest[]
            {
                new CreateDaiAuthenticationKeyRequest(),
            };
            // Make the request
            BatchCreateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchCreateDaiAuthenticationKeysAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiAuthenticationKeys</summary>
        public void BatchCreateDaiAuthenticationKeysResourceNames()
        {
            // Snippet: BatchCreateDaiAuthenticationKeys(NetworkName, IEnumerable<CreateDaiAuthenticationKeyRequest>, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateDaiAuthenticationKeyRequest> requests = new CreateDaiAuthenticationKeyRequest[]
            {
                new CreateDaiAuthenticationKeyRequest(),
            };
            // Make the request
            BatchCreateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchCreateDaiAuthenticationKeys(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateDaiAuthenticationKeysAsync</summary>
        public async Task BatchCreateDaiAuthenticationKeysResourceNamesAsync()
        {
            // Snippet: BatchCreateDaiAuthenticationKeysAsync(NetworkName, IEnumerable<CreateDaiAuthenticationKeyRequest>, CallSettings)
            // Additional: BatchCreateDaiAuthenticationKeysAsync(NetworkName, IEnumerable<CreateDaiAuthenticationKeyRequest>, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateDaiAuthenticationKeyRequest> requests = new CreateDaiAuthenticationKeyRequest[]
            {
                new CreateDaiAuthenticationKeyRequest(),
            };
            // Make the request
            BatchCreateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchCreateDaiAuthenticationKeysAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateDaiAuthenticationKey</summary>
        public void UpdateDaiAuthenticationKeyRequestObject()
        {
            // Snippet: UpdateDaiAuthenticationKey(UpdateDaiAuthenticationKeyRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            UpdateDaiAuthenticationKeyRequest request = new UpdateDaiAuthenticationKeyRequest
            {
                DaiAuthenticationKey = new DaiAuthenticationKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DaiAuthenticationKey response = daiAuthenticationKeyServiceClient.UpdateDaiAuthenticationKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDaiAuthenticationKeyAsync</summary>
        public async Task UpdateDaiAuthenticationKeyRequestObjectAsync()
        {
            // Snippet: UpdateDaiAuthenticationKeyAsync(UpdateDaiAuthenticationKeyRequest, CallSettings)
            // Additional: UpdateDaiAuthenticationKeyAsync(UpdateDaiAuthenticationKeyRequest, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDaiAuthenticationKeyRequest request = new UpdateDaiAuthenticationKeyRequest
            {
                DaiAuthenticationKey = new DaiAuthenticationKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DaiAuthenticationKey response = await daiAuthenticationKeyServiceClient.UpdateDaiAuthenticationKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDaiAuthenticationKey</summary>
        public void UpdateDaiAuthenticationKey()
        {
            // Snippet: UpdateDaiAuthenticationKey(DaiAuthenticationKey, FieldMask, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            DaiAuthenticationKey daiAuthenticationKey = new DaiAuthenticationKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DaiAuthenticationKey response = daiAuthenticationKeyServiceClient.UpdateDaiAuthenticationKey(daiAuthenticationKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDaiAuthenticationKeyAsync</summary>
        public async Task UpdateDaiAuthenticationKeyAsync()
        {
            // Snippet: UpdateDaiAuthenticationKeyAsync(DaiAuthenticationKey, FieldMask, CallSettings)
            // Additional: UpdateDaiAuthenticationKeyAsync(DaiAuthenticationKey, FieldMask, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DaiAuthenticationKey daiAuthenticationKey = new DaiAuthenticationKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DaiAuthenticationKey response = await daiAuthenticationKeyServiceClient.UpdateDaiAuthenticationKeyAsync(daiAuthenticationKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiAuthenticationKeys</summary>
        public void BatchUpdateDaiAuthenticationKeysRequestObject()
        {
            // Snippet: BatchUpdateDaiAuthenticationKeys(BatchUpdateDaiAuthenticationKeysRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateDaiAuthenticationKeysRequest request = new BatchUpdateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateDaiAuthenticationKeyRequest(),
                },
            };
            // Make the request
            BatchUpdateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchUpdateDaiAuthenticationKeys(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiAuthenticationKeysAsync</summary>
        public async Task BatchUpdateDaiAuthenticationKeysRequestObjectAsync()
        {
            // Snippet: BatchUpdateDaiAuthenticationKeysAsync(BatchUpdateDaiAuthenticationKeysRequest, CallSettings)
            // Additional: BatchUpdateDaiAuthenticationKeysAsync(BatchUpdateDaiAuthenticationKeysRequest, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateDaiAuthenticationKeysRequest request = new BatchUpdateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateDaiAuthenticationKeyRequest(),
                },
            };
            // Make the request
            BatchUpdateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchUpdateDaiAuthenticationKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiAuthenticationKeys</summary>
        public void BatchUpdateDaiAuthenticationKeys()
        {
            // Snippet: BatchUpdateDaiAuthenticationKeys(string, IEnumerable<UpdateDaiAuthenticationKeyRequest>, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateDaiAuthenticationKeyRequest> requests = new UpdateDaiAuthenticationKeyRequest[]
            {
                new UpdateDaiAuthenticationKeyRequest(),
            };
            // Make the request
            BatchUpdateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchUpdateDaiAuthenticationKeys(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiAuthenticationKeysAsync</summary>
        public async Task BatchUpdateDaiAuthenticationKeysAsync()
        {
            // Snippet: BatchUpdateDaiAuthenticationKeysAsync(string, IEnumerable<UpdateDaiAuthenticationKeyRequest>, CallSettings)
            // Additional: BatchUpdateDaiAuthenticationKeysAsync(string, IEnumerable<UpdateDaiAuthenticationKeyRequest>, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateDaiAuthenticationKeyRequest> requests = new UpdateDaiAuthenticationKeyRequest[]
            {
                new UpdateDaiAuthenticationKeyRequest(),
            };
            // Make the request
            BatchUpdateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchUpdateDaiAuthenticationKeysAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiAuthenticationKeys</summary>
        public void BatchUpdateDaiAuthenticationKeysResourceNames()
        {
            // Snippet: BatchUpdateDaiAuthenticationKeys(NetworkName, IEnumerable<UpdateDaiAuthenticationKeyRequest>, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateDaiAuthenticationKeyRequest> requests = new UpdateDaiAuthenticationKeyRequest[]
            {
                new UpdateDaiAuthenticationKeyRequest(),
            };
            // Make the request
            BatchUpdateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchUpdateDaiAuthenticationKeys(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateDaiAuthenticationKeysAsync</summary>
        public async Task BatchUpdateDaiAuthenticationKeysResourceNamesAsync()
        {
            // Snippet: BatchUpdateDaiAuthenticationKeysAsync(NetworkName, IEnumerable<UpdateDaiAuthenticationKeyRequest>, CallSettings)
            // Additional: BatchUpdateDaiAuthenticationKeysAsync(NetworkName, IEnumerable<UpdateDaiAuthenticationKeyRequest>, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateDaiAuthenticationKeyRequest> requests = new UpdateDaiAuthenticationKeyRequest[]
            {
                new UpdateDaiAuthenticationKeyRequest(),
            };
            // Make the request
            BatchUpdateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchUpdateDaiAuthenticationKeysAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiAuthenticationKeys</summary>
        public void BatchActivateDaiAuthenticationKeysRequestObject()
        {
            // Snippet: BatchActivateDaiAuthenticationKeys(BatchActivateDaiAuthenticationKeysRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateDaiAuthenticationKeysRequest request = new BatchActivateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DaiAuthenticationKeyNames =
                {
                    DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
                },
            };
            // Make the request
            BatchActivateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchActivateDaiAuthenticationKeys(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiAuthenticationKeysAsync</summary>
        public async Task BatchActivateDaiAuthenticationKeysRequestObjectAsync()
        {
            // Snippet: BatchActivateDaiAuthenticationKeysAsync(BatchActivateDaiAuthenticationKeysRequest, CallSettings)
            // Additional: BatchActivateDaiAuthenticationKeysAsync(BatchActivateDaiAuthenticationKeysRequest, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateDaiAuthenticationKeysRequest request = new BatchActivateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DaiAuthenticationKeyNames =
                {
                    DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
                },
            };
            // Make the request
            BatchActivateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchActivateDaiAuthenticationKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiAuthenticationKeys</summary>
        public void BatchActivateDaiAuthenticationKeys()
        {
            // Snippet: BatchActivateDaiAuthenticationKeys(string, IEnumerable<string>, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/daiAuthenticationKeys/[DAI_AUTHENTICATION_KEY]",
            };
            // Make the request
            BatchActivateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchActivateDaiAuthenticationKeys(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiAuthenticationKeysAsync</summary>
        public async Task BatchActivateDaiAuthenticationKeysAsync()
        {
            // Snippet: BatchActivateDaiAuthenticationKeysAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateDaiAuthenticationKeysAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/daiAuthenticationKeys/[DAI_AUTHENTICATION_KEY]",
            };
            // Make the request
            BatchActivateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchActivateDaiAuthenticationKeysAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiAuthenticationKeys</summary>
        public void BatchActivateDaiAuthenticationKeysResourceNames()
        {
            // Snippet: BatchActivateDaiAuthenticationKeys(NetworkName, IEnumerable<DaiAuthenticationKeyName>, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<DaiAuthenticationKeyName> names = new DaiAuthenticationKeyName[]
            {
                DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
            };
            // Make the request
            BatchActivateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchActivateDaiAuthenticationKeys(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateDaiAuthenticationKeysAsync</summary>
        public async Task BatchActivateDaiAuthenticationKeysResourceNamesAsync()
        {
            // Snippet: BatchActivateDaiAuthenticationKeysAsync(NetworkName, IEnumerable<DaiAuthenticationKeyName>, CallSettings)
            // Additional: BatchActivateDaiAuthenticationKeysAsync(NetworkName, IEnumerable<DaiAuthenticationKeyName>, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<DaiAuthenticationKeyName> names = new DaiAuthenticationKeyName[]
            {
                DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
            };
            // Make the request
            BatchActivateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchActivateDaiAuthenticationKeysAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateDaiAuthenticationKeys</summary>
        public void BatchDeactivateDaiAuthenticationKeysRequestObject()
        {
            // Snippet: BatchDeactivateDaiAuthenticationKeys(BatchDeactivateDaiAuthenticationKeysRequest, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateDaiAuthenticationKeysRequest request = new BatchDeactivateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DaiAuthenticationKeyNames =
                {
                    DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
                },
            };
            // Make the request
            BatchDeactivateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchDeactivateDaiAuthenticationKeys(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateDaiAuthenticationKeysAsync</summary>
        public async Task BatchDeactivateDaiAuthenticationKeysRequestObjectAsync()
        {
            // Snippet: BatchDeactivateDaiAuthenticationKeysAsync(BatchDeactivateDaiAuthenticationKeysRequest, CallSettings)
            // Additional: BatchDeactivateDaiAuthenticationKeysAsync(BatchDeactivateDaiAuthenticationKeysRequest, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateDaiAuthenticationKeysRequest request = new BatchDeactivateDaiAuthenticationKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                DaiAuthenticationKeyNames =
                {
                    DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
                },
            };
            // Make the request
            BatchDeactivateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchDeactivateDaiAuthenticationKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateDaiAuthenticationKeys</summary>
        public void BatchDeactivateDaiAuthenticationKeys()
        {
            // Snippet: BatchDeactivateDaiAuthenticationKeys(string, IEnumerable<string>, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/daiAuthenticationKeys/[DAI_AUTHENTICATION_KEY]",
            };
            // Make the request
            BatchDeactivateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchDeactivateDaiAuthenticationKeys(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateDaiAuthenticationKeysAsync</summary>
        public async Task BatchDeactivateDaiAuthenticationKeysAsync()
        {
            // Snippet: BatchDeactivateDaiAuthenticationKeysAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateDaiAuthenticationKeysAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/daiAuthenticationKeys/[DAI_AUTHENTICATION_KEY]",
            };
            // Make the request
            BatchDeactivateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchDeactivateDaiAuthenticationKeysAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateDaiAuthenticationKeys</summary>
        public void BatchDeactivateDaiAuthenticationKeysResourceNames()
        {
            // Snippet: BatchDeactivateDaiAuthenticationKeys(NetworkName, IEnumerable<DaiAuthenticationKeyName>, CallSettings)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = DaiAuthenticationKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<DaiAuthenticationKeyName> names = new DaiAuthenticationKeyName[]
            {
                DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
            };
            // Make the request
            BatchDeactivateDaiAuthenticationKeysResponse response = daiAuthenticationKeyServiceClient.BatchDeactivateDaiAuthenticationKeys(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateDaiAuthenticationKeysAsync</summary>
        public async Task BatchDeactivateDaiAuthenticationKeysResourceNamesAsync()
        {
            // Snippet: BatchDeactivateDaiAuthenticationKeysAsync(NetworkName, IEnumerable<DaiAuthenticationKeyName>, CallSettings)
            // Additional: BatchDeactivateDaiAuthenticationKeysAsync(NetworkName, IEnumerable<DaiAuthenticationKeyName>, CancellationToken)
            // Create client
            DaiAuthenticationKeyServiceClient daiAuthenticationKeyServiceClient = await DaiAuthenticationKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<DaiAuthenticationKeyName> names = new DaiAuthenticationKeyName[]
            {
                DaiAuthenticationKeyName.FromNetworkCodeDaiAuthenticationKey("[NETWORK_CODE]", "[DAI_AUTHENTICATION_KEY]"),
            };
            // Make the request
            BatchDeactivateDaiAuthenticationKeysResponse response = await daiAuthenticationKeyServiceClient.BatchDeactivateDaiAuthenticationKeysAsync(parent, names);
            // End snippet
        }
    }
}
