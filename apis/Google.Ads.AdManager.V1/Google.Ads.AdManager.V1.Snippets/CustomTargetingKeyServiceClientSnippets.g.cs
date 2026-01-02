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
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCustomTargetingKeyServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomTargetingKey</summary>
        public void GetCustomTargetingKeyRequestObject()
        {
            // Snippet: GetCustomTargetingKey(GetCustomTargetingKeyRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            GetCustomTargetingKeyRequest request = new GetCustomTargetingKeyRequest
            {
                CustomTargetingKeyName = CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
            };
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.GetCustomTargetingKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKeyAsync</summary>
        public async Task GetCustomTargetingKeyRequestObjectAsync()
        {
            // Snippet: GetCustomTargetingKeyAsync(GetCustomTargetingKeyRequest, CallSettings)
            // Additional: GetCustomTargetingKeyAsync(GetCustomTargetingKeyRequest, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomTargetingKeyRequest request = new GetCustomTargetingKeyRequest
            {
                CustomTargetingKeyName = CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
            };
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.GetCustomTargetingKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKey</summary>
        public void GetCustomTargetingKey()
        {
            // Snippet: GetCustomTargetingKey(string, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/customTargetingKeys/[CUSTOM_TARGETING_KEY]";
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.GetCustomTargetingKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKeyAsync</summary>
        public async Task GetCustomTargetingKeyAsync()
        {
            // Snippet: GetCustomTargetingKeyAsync(string, CallSettings)
            // Additional: GetCustomTargetingKeyAsync(string, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/customTargetingKeys/[CUSTOM_TARGETING_KEY]";
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.GetCustomTargetingKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKey</summary>
        public void GetCustomTargetingKeyResourceNames()
        {
            // Snippet: GetCustomTargetingKey(CustomTargetingKeyName, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            CustomTargetingKeyName name = CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]");
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.GetCustomTargetingKey(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingKeyAsync</summary>
        public async Task GetCustomTargetingKeyResourceNamesAsync()
        {
            // Snippet: GetCustomTargetingKeyAsync(CustomTargetingKeyName, CallSettings)
            // Additional: GetCustomTargetingKeyAsync(CustomTargetingKeyName, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomTargetingKeyName name = CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]");
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.GetCustomTargetingKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeys</summary>
        public void ListCustomTargetingKeysRequestObject()
        {
            // Snippet: ListCustomTargetingKeys(ListCustomTargetingKeysRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            ListCustomTargetingKeysRequest request = new ListCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeys(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeysAsync</summary>
        public async Task ListCustomTargetingKeysRequestObjectAsync()
        {
            // Snippet: ListCustomTargetingKeysAsync(ListCustomTargetingKeysRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomTargetingKeysRequest request = new ListCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetingKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeys</summary>
        public void ListCustomTargetingKeys()
        {
            // Snippet: ListCustomTargetingKeys(string, string, int?, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeysAsync</summary>
        public async Task ListCustomTargetingKeysAsync()
        {
            // Snippet: ListCustomTargetingKeysAsync(string, string, int?, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetingKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeys</summary>
        public void ListCustomTargetingKeysResourceNames()
        {
            // Snippet: ListCustomTargetingKeys(NetworkName, string, int?, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeys(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingKey item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingKeysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingKeysAsync</summary>
        public async Task ListCustomTargetingKeysResourceNamesAsync()
        {
            // Snippet: ListCustomTargetingKeysAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingKeysResponse, CustomTargetingKey> response = customTargetingKeyServiceClient.ListCustomTargetingKeysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetingKey item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingKeysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingKey item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingKey> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingKey item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingKey</summary>
        public void CreateCustomTargetingKeyRequestObject()
        {
            // Snippet: CreateCustomTargetingKey(CreateCustomTargetingKeyRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            CreateCustomTargetingKeyRequest request = new CreateCustomTargetingKeyRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CustomTargetingKey = new CustomTargetingKey(),
            };
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.CreateCustomTargetingKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingKeyAsync</summary>
        public async Task CreateCustomTargetingKeyRequestObjectAsync()
        {
            // Snippet: CreateCustomTargetingKeyAsync(CreateCustomTargetingKeyRequest, CallSettings)
            // Additional: CreateCustomTargetingKeyAsync(CreateCustomTargetingKeyRequest, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomTargetingKeyRequest request = new CreateCustomTargetingKeyRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CustomTargetingKey = new CustomTargetingKey(),
            };
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.CreateCustomTargetingKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingKey</summary>
        public void CreateCustomTargetingKey()
        {
            // Snippet: CreateCustomTargetingKey(string, CustomTargetingKey, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CustomTargetingKey customTargetingKey = new CustomTargetingKey();
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.CreateCustomTargetingKey(parent, customTargetingKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingKeyAsync</summary>
        public async Task CreateCustomTargetingKeyAsync()
        {
            // Snippet: CreateCustomTargetingKeyAsync(string, CustomTargetingKey, CallSettings)
            // Additional: CreateCustomTargetingKeyAsync(string, CustomTargetingKey, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CustomTargetingKey customTargetingKey = new CustomTargetingKey();
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.CreateCustomTargetingKeyAsync(parent, customTargetingKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingKey</summary>
        public void CreateCustomTargetingKeyResourceNames()
        {
            // Snippet: CreateCustomTargetingKey(NetworkName, CustomTargetingKey, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CustomTargetingKey customTargetingKey = new CustomTargetingKey();
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.CreateCustomTargetingKey(parent, customTargetingKey);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingKeyAsync</summary>
        public async Task CreateCustomTargetingKeyResourceNamesAsync()
        {
            // Snippet: CreateCustomTargetingKeyAsync(NetworkName, CustomTargetingKey, CallSettings)
            // Additional: CreateCustomTargetingKeyAsync(NetworkName, CustomTargetingKey, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CustomTargetingKey customTargetingKey = new CustomTargetingKey();
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.CreateCustomTargetingKeyAsync(parent, customTargetingKey);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingKeys</summary>
        public void BatchCreateCustomTargetingKeysRequestObject()
        {
            // Snippet: BatchCreateCustomTargetingKeys(BatchCreateCustomTargetingKeysRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateCustomTargetingKeysRequest request = new BatchCreateCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateCustomTargetingKeyRequest(),
                },
            };
            // Make the request
            BatchCreateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchCreateCustomTargetingKeys(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingKeysAsync</summary>
        public async Task BatchCreateCustomTargetingKeysRequestObjectAsync()
        {
            // Snippet: BatchCreateCustomTargetingKeysAsync(BatchCreateCustomTargetingKeysRequest, CallSettings)
            // Additional: BatchCreateCustomTargetingKeysAsync(BatchCreateCustomTargetingKeysRequest, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateCustomTargetingKeysRequest request = new BatchCreateCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateCustomTargetingKeyRequest(),
                },
            };
            // Make the request
            BatchCreateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchCreateCustomTargetingKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingKeys</summary>
        public void BatchCreateCustomTargetingKeys()
        {
            // Snippet: BatchCreateCustomTargetingKeys(string, IEnumerable<CreateCustomTargetingKeyRequest>, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateCustomTargetingKeyRequest> requests = new CreateCustomTargetingKeyRequest[]
            {
                new CreateCustomTargetingKeyRequest(),
            };
            // Make the request
            BatchCreateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchCreateCustomTargetingKeys(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingKeysAsync</summary>
        public async Task BatchCreateCustomTargetingKeysAsync()
        {
            // Snippet: BatchCreateCustomTargetingKeysAsync(string, IEnumerable<CreateCustomTargetingKeyRequest>, CallSettings)
            // Additional: BatchCreateCustomTargetingKeysAsync(string, IEnumerable<CreateCustomTargetingKeyRequest>, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateCustomTargetingKeyRequest> requests = new CreateCustomTargetingKeyRequest[]
            {
                new CreateCustomTargetingKeyRequest(),
            };
            // Make the request
            BatchCreateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchCreateCustomTargetingKeysAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingKeys</summary>
        public void BatchCreateCustomTargetingKeysResourceNames()
        {
            // Snippet: BatchCreateCustomTargetingKeys(NetworkName, IEnumerable<CreateCustomTargetingKeyRequest>, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateCustomTargetingKeyRequest> requests = new CreateCustomTargetingKeyRequest[]
            {
                new CreateCustomTargetingKeyRequest(),
            };
            // Make the request
            BatchCreateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchCreateCustomTargetingKeys(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingKeysAsync</summary>
        public async Task BatchCreateCustomTargetingKeysResourceNamesAsync()
        {
            // Snippet: BatchCreateCustomTargetingKeysAsync(NetworkName, IEnumerable<CreateCustomTargetingKeyRequest>, CallSettings)
            // Additional: BatchCreateCustomTargetingKeysAsync(NetworkName, IEnumerable<CreateCustomTargetingKeyRequest>, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateCustomTargetingKeyRequest> requests = new CreateCustomTargetingKeyRequest[]
            {
                new CreateCustomTargetingKeyRequest(),
            };
            // Make the request
            BatchCreateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchCreateCustomTargetingKeysAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetingKey</summary>
        public void UpdateCustomTargetingKeyRequestObject()
        {
            // Snippet: UpdateCustomTargetingKey(UpdateCustomTargetingKeyRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            UpdateCustomTargetingKeyRequest request = new UpdateCustomTargetingKeyRequest
            {
                CustomTargetingKey = new CustomTargetingKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.UpdateCustomTargetingKey(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetingKeyAsync</summary>
        public async Task UpdateCustomTargetingKeyRequestObjectAsync()
        {
            // Snippet: UpdateCustomTargetingKeyAsync(UpdateCustomTargetingKeyRequest, CallSettings)
            // Additional: UpdateCustomTargetingKeyAsync(UpdateCustomTargetingKeyRequest, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomTargetingKeyRequest request = new UpdateCustomTargetingKeyRequest
            {
                CustomTargetingKey = new CustomTargetingKey(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.UpdateCustomTargetingKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetingKey</summary>
        public void UpdateCustomTargetingKey()
        {
            // Snippet: UpdateCustomTargetingKey(CustomTargetingKey, FieldMask, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            CustomTargetingKey customTargetingKey = new CustomTargetingKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomTargetingKey response = customTargetingKeyServiceClient.UpdateCustomTargetingKey(customTargetingKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetingKeyAsync</summary>
        public async Task UpdateCustomTargetingKeyAsync()
        {
            // Snippet: UpdateCustomTargetingKeyAsync(CustomTargetingKey, FieldMask, CallSettings)
            // Additional: UpdateCustomTargetingKeyAsync(CustomTargetingKey, FieldMask, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomTargetingKey customTargetingKey = new CustomTargetingKey();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomTargetingKey response = await customTargetingKeyServiceClient.UpdateCustomTargetingKeyAsync(customTargetingKey, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingKeys</summary>
        public void BatchUpdateCustomTargetingKeysRequestObject()
        {
            // Snippet: BatchUpdateCustomTargetingKeys(BatchUpdateCustomTargetingKeysRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateCustomTargetingKeysRequest request = new BatchUpdateCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateCustomTargetingKeyRequest(),
                },
            };
            // Make the request
            BatchUpdateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchUpdateCustomTargetingKeys(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingKeysAsync</summary>
        public async Task BatchUpdateCustomTargetingKeysRequestObjectAsync()
        {
            // Snippet: BatchUpdateCustomTargetingKeysAsync(BatchUpdateCustomTargetingKeysRequest, CallSettings)
            // Additional: BatchUpdateCustomTargetingKeysAsync(BatchUpdateCustomTargetingKeysRequest, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateCustomTargetingKeysRequest request = new BatchUpdateCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateCustomTargetingKeyRequest(),
                },
            };
            // Make the request
            BatchUpdateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchUpdateCustomTargetingKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingKeys</summary>
        public void BatchUpdateCustomTargetingKeys()
        {
            // Snippet: BatchUpdateCustomTargetingKeys(string, IEnumerable<UpdateCustomTargetingKeyRequest>, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateCustomTargetingKeyRequest> requests = new UpdateCustomTargetingKeyRequest[]
            {
                new UpdateCustomTargetingKeyRequest(),
            };
            // Make the request
            BatchUpdateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchUpdateCustomTargetingKeys(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingKeysAsync</summary>
        public async Task BatchUpdateCustomTargetingKeysAsync()
        {
            // Snippet: BatchUpdateCustomTargetingKeysAsync(string, IEnumerable<UpdateCustomTargetingKeyRequest>, CallSettings)
            // Additional: BatchUpdateCustomTargetingKeysAsync(string, IEnumerable<UpdateCustomTargetingKeyRequest>, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateCustomTargetingKeyRequest> requests = new UpdateCustomTargetingKeyRequest[]
            {
                new UpdateCustomTargetingKeyRequest(),
            };
            // Make the request
            BatchUpdateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchUpdateCustomTargetingKeysAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingKeys</summary>
        public void BatchUpdateCustomTargetingKeysResourceNames()
        {
            // Snippet: BatchUpdateCustomTargetingKeys(NetworkName, IEnumerable<UpdateCustomTargetingKeyRequest>, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateCustomTargetingKeyRequest> requests = new UpdateCustomTargetingKeyRequest[]
            {
                new UpdateCustomTargetingKeyRequest(),
            };
            // Make the request
            BatchUpdateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchUpdateCustomTargetingKeys(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingKeysAsync</summary>
        public async Task BatchUpdateCustomTargetingKeysResourceNamesAsync()
        {
            // Snippet: BatchUpdateCustomTargetingKeysAsync(NetworkName, IEnumerable<UpdateCustomTargetingKeyRequest>, CallSettings)
            // Additional: BatchUpdateCustomTargetingKeysAsync(NetworkName, IEnumerable<UpdateCustomTargetingKeyRequest>, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateCustomTargetingKeyRequest> requests = new UpdateCustomTargetingKeyRequest[]
            {
                new UpdateCustomTargetingKeyRequest(),
            };
            // Make the request
            BatchUpdateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchUpdateCustomTargetingKeysAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingKeys</summary>
        public void BatchActivateCustomTargetingKeysRequestObject()
        {
            // Snippet: BatchActivateCustomTargetingKeys(BatchActivateCustomTargetingKeysRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateCustomTargetingKeysRequest request = new BatchActivateCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CustomTargetingKeyNames =
                {
                    CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
                },
            };
            // Make the request
            BatchActivateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchActivateCustomTargetingKeys(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingKeysAsync</summary>
        public async Task BatchActivateCustomTargetingKeysRequestObjectAsync()
        {
            // Snippet: BatchActivateCustomTargetingKeysAsync(BatchActivateCustomTargetingKeysRequest, CallSettings)
            // Additional: BatchActivateCustomTargetingKeysAsync(BatchActivateCustomTargetingKeysRequest, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateCustomTargetingKeysRequest request = new BatchActivateCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CustomTargetingKeyNames =
                {
                    CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
                },
            };
            // Make the request
            BatchActivateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchActivateCustomTargetingKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingKeys</summary>
        public void BatchActivateCustomTargetingKeys()
        {
            // Snippet: BatchActivateCustomTargetingKeys(string, IEnumerable<string>, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/customTargetingKeys/[CUSTOM_TARGETING_KEY]",
            };
            // Make the request
            BatchActivateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchActivateCustomTargetingKeys(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingKeysAsync</summary>
        public async Task BatchActivateCustomTargetingKeysAsync()
        {
            // Snippet: BatchActivateCustomTargetingKeysAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateCustomTargetingKeysAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/customTargetingKeys/[CUSTOM_TARGETING_KEY]",
            };
            // Make the request
            BatchActivateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchActivateCustomTargetingKeysAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingKeys</summary>
        public void BatchActivateCustomTargetingKeysResourceNames()
        {
            // Snippet: BatchActivateCustomTargetingKeys(NetworkName, IEnumerable<CustomTargetingKeyName>, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CustomTargetingKeyName> names = new CustomTargetingKeyName[]
            {
                CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
            };
            // Make the request
            BatchActivateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchActivateCustomTargetingKeys(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingKeysAsync</summary>
        public async Task BatchActivateCustomTargetingKeysResourceNamesAsync()
        {
            // Snippet: BatchActivateCustomTargetingKeysAsync(NetworkName, IEnumerable<CustomTargetingKeyName>, CallSettings)
            // Additional: BatchActivateCustomTargetingKeysAsync(NetworkName, IEnumerable<CustomTargetingKeyName>, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CustomTargetingKeyName> names = new CustomTargetingKeyName[]
            {
                CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
            };
            // Make the request
            BatchActivateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchActivateCustomTargetingKeysAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingKeys</summary>
        public void BatchDeactivateCustomTargetingKeysRequestObject()
        {
            // Snippet: BatchDeactivateCustomTargetingKeys(BatchDeactivateCustomTargetingKeysRequest, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateCustomTargetingKeysRequest request = new BatchDeactivateCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CustomTargetingKeyNames =
                {
                    CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
                },
            };
            // Make the request
            BatchDeactivateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchDeactivateCustomTargetingKeys(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingKeysAsync</summary>
        public async Task BatchDeactivateCustomTargetingKeysRequestObjectAsync()
        {
            // Snippet: BatchDeactivateCustomTargetingKeysAsync(BatchDeactivateCustomTargetingKeysRequest, CallSettings)
            // Additional: BatchDeactivateCustomTargetingKeysAsync(BatchDeactivateCustomTargetingKeysRequest, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateCustomTargetingKeysRequest request = new BatchDeactivateCustomTargetingKeysRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CustomTargetingKeyNames =
                {
                    CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
                },
            };
            // Make the request
            BatchDeactivateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchDeactivateCustomTargetingKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingKeys</summary>
        public void BatchDeactivateCustomTargetingKeys()
        {
            // Snippet: BatchDeactivateCustomTargetingKeys(string, IEnumerable<string>, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/customTargetingKeys/[CUSTOM_TARGETING_KEY]",
            };
            // Make the request
            BatchDeactivateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchDeactivateCustomTargetingKeys(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingKeysAsync</summary>
        public async Task BatchDeactivateCustomTargetingKeysAsync()
        {
            // Snippet: BatchDeactivateCustomTargetingKeysAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateCustomTargetingKeysAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/customTargetingKeys/[CUSTOM_TARGETING_KEY]",
            };
            // Make the request
            BatchDeactivateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchDeactivateCustomTargetingKeysAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingKeys</summary>
        public void BatchDeactivateCustomTargetingKeysResourceNames()
        {
            // Snippet: BatchDeactivateCustomTargetingKeys(NetworkName, IEnumerable<CustomTargetingKeyName>, CallSettings)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = CustomTargetingKeyServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CustomTargetingKeyName> names = new CustomTargetingKeyName[]
            {
                CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
            };
            // Make the request
            BatchDeactivateCustomTargetingKeysResponse response = customTargetingKeyServiceClient.BatchDeactivateCustomTargetingKeys(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingKeysAsync</summary>
        public async Task BatchDeactivateCustomTargetingKeysResourceNamesAsync()
        {
            // Snippet: BatchDeactivateCustomTargetingKeysAsync(NetworkName, IEnumerable<CustomTargetingKeyName>, CallSettings)
            // Additional: BatchDeactivateCustomTargetingKeysAsync(NetworkName, IEnumerable<CustomTargetingKeyName>, CancellationToken)
            // Create client
            CustomTargetingKeyServiceClient customTargetingKeyServiceClient = await CustomTargetingKeyServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CustomTargetingKeyName> names = new CustomTargetingKeyName[]
            {
                CustomTargetingKeyName.FromNetworkCodeCustomTargetingKey("[NETWORK_CODE]", "[CUSTOM_TARGETING_KEY]"),
            };
            // Make the request
            BatchDeactivateCustomTargetingKeysResponse response = await customTargetingKeyServiceClient.BatchDeactivateCustomTargetingKeysAsync(parent, names);
            // End snippet
        }
    }
}
