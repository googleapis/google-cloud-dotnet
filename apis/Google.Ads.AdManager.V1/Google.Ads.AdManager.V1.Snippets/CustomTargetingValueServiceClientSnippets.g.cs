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
    public sealed class AllGeneratedCustomTargetingValueServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomTargetingValue</summary>
        public void GetCustomTargetingValueRequestObject()
        {
            // Snippet: GetCustomTargetingValue(GetCustomTargetingValueRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            GetCustomTargetingValueRequest request = new GetCustomTargetingValueRequest
            {
                CustomTargetingValueName = CustomTargetingValueName.FromNetworkCodeCustomTargetingValue("[NETWORK_CODE]", "[CUSTOM_TARGETING_VALUE]"),
            };
            // Make the request
            CustomTargetingValue response = customTargetingValueServiceClient.GetCustomTargetingValue(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingValueAsync</summary>
        public async Task GetCustomTargetingValueRequestObjectAsync()
        {
            // Snippet: GetCustomTargetingValueAsync(GetCustomTargetingValueRequest, CallSettings)
            // Additional: GetCustomTargetingValueAsync(GetCustomTargetingValueRequest, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomTargetingValueRequest request = new GetCustomTargetingValueRequest
            {
                CustomTargetingValueName = CustomTargetingValueName.FromNetworkCodeCustomTargetingValue("[NETWORK_CODE]", "[CUSTOM_TARGETING_VALUE]"),
            };
            // Make the request
            CustomTargetingValue response = await customTargetingValueServiceClient.GetCustomTargetingValueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingValue</summary>
        public void GetCustomTargetingValue()
        {
            // Snippet: GetCustomTargetingValue(string, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/customTargetingValues/[CUSTOM_TARGETING_VALUE]";
            // Make the request
            CustomTargetingValue response = customTargetingValueServiceClient.GetCustomTargetingValue(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingValueAsync</summary>
        public async Task GetCustomTargetingValueAsync()
        {
            // Snippet: GetCustomTargetingValueAsync(string, CallSettings)
            // Additional: GetCustomTargetingValueAsync(string, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/customTargetingValues/[CUSTOM_TARGETING_VALUE]";
            // Make the request
            CustomTargetingValue response = await customTargetingValueServiceClient.GetCustomTargetingValueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingValue</summary>
        public void GetCustomTargetingValueResourceNames()
        {
            // Snippet: GetCustomTargetingValue(CustomTargetingValueName, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            CustomTargetingValueName name = CustomTargetingValueName.FromNetworkCodeCustomTargetingValue("[NETWORK_CODE]", "[CUSTOM_TARGETING_VALUE]");
            // Make the request
            CustomTargetingValue response = customTargetingValueServiceClient.GetCustomTargetingValue(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetingValueAsync</summary>
        public async Task GetCustomTargetingValueResourceNamesAsync()
        {
            // Snippet: GetCustomTargetingValueAsync(CustomTargetingValueName, CallSettings)
            // Additional: GetCustomTargetingValueAsync(CustomTargetingValueName, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomTargetingValueName name = CustomTargetingValueName.FromNetworkCodeCustomTargetingValue("[NETWORK_CODE]", "[CUSTOM_TARGETING_VALUE]");
            // Make the request
            CustomTargetingValue response = await customTargetingValueServiceClient.GetCustomTargetingValueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingValues</summary>
        public void ListCustomTargetingValuesRequestObject()
        {
            // Snippet: ListCustomTargetingValues(ListCustomTargetingValuesRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            ListCustomTargetingValuesRequest request = new ListCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> response = customTargetingValueServiceClient.ListCustomTargetingValues(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingValuesAsync</summary>
        public async Task ListCustomTargetingValuesRequestObjectAsync()
        {
            // Snippet: ListCustomTargetingValuesAsync(ListCustomTargetingValuesRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomTargetingValuesRequest request = new ListCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> response = customTargetingValueServiceClient.ListCustomTargetingValuesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CustomTargetingValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCustomTargetingValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingValues</summary>
        public void ListCustomTargetingValues()
        {
            // Snippet: ListCustomTargetingValues(string, string, int?, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> response = customTargetingValueServiceClient.ListCustomTargetingValues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingValuesAsync</summary>
        public async Task ListCustomTargetingValuesAsync()
        {
            // Snippet: ListCustomTargetingValuesAsync(string, string, int?, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> response = customTargetingValueServiceClient.ListCustomTargetingValuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CustomTargetingValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCustomTargetingValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingValues</summary>
        public void ListCustomTargetingValuesResourceNames()
        {
            // Snippet: ListCustomTargetingValues(NetworkName, string, int?, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> response = customTargetingValueServiceClient.ListCustomTargetingValues(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetingValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetingValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetingValuesAsync</summary>
        public async Task ListCustomTargetingValuesResourceNamesAsync()
        {
            // Snippet: ListCustomTargetingValuesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetingValuesResponse, CustomTargetingValue> response = customTargetingValueServiceClient.ListCustomTargetingValuesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (CustomTargetingValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListCustomTargetingValuesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetingValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetingValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingValue</summary>
        public void CreateCustomTargetingValueRequestObject()
        {
            // Snippet: CreateCustomTargetingValue(CreateCustomTargetingValueRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            CreateCustomTargetingValueRequest request = new CreateCustomTargetingValueRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CustomTargetingValue = new CustomTargetingValue(),
            };
            // Make the request
            CustomTargetingValue response = customTargetingValueServiceClient.CreateCustomTargetingValue(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingValueAsync</summary>
        public async Task CreateCustomTargetingValueRequestObjectAsync()
        {
            // Snippet: CreateCustomTargetingValueAsync(CreateCustomTargetingValueRequest, CallSettings)
            // Additional: CreateCustomTargetingValueAsync(CreateCustomTargetingValueRequest, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomTargetingValueRequest request = new CreateCustomTargetingValueRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                CustomTargetingValue = new CustomTargetingValue(),
            };
            // Make the request
            CustomTargetingValue response = await customTargetingValueServiceClient.CreateCustomTargetingValueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingValue</summary>
        public void CreateCustomTargetingValue()
        {
            // Snippet: CreateCustomTargetingValue(string, CustomTargetingValue, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CustomTargetingValue customTargetingValue = new CustomTargetingValue();
            // Make the request
            CustomTargetingValue response = customTargetingValueServiceClient.CreateCustomTargetingValue(parent, customTargetingValue);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingValueAsync</summary>
        public async Task CreateCustomTargetingValueAsync()
        {
            // Snippet: CreateCustomTargetingValueAsync(string, CustomTargetingValue, CallSettings)
            // Additional: CreateCustomTargetingValueAsync(string, CustomTargetingValue, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            CustomTargetingValue customTargetingValue = new CustomTargetingValue();
            // Make the request
            CustomTargetingValue response = await customTargetingValueServiceClient.CreateCustomTargetingValueAsync(parent, customTargetingValue);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingValue</summary>
        public void CreateCustomTargetingValueResourceNames()
        {
            // Snippet: CreateCustomTargetingValue(NetworkName, CustomTargetingValue, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CustomTargetingValue customTargetingValue = new CustomTargetingValue();
            // Make the request
            CustomTargetingValue response = customTargetingValueServiceClient.CreateCustomTargetingValue(parent, customTargetingValue);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetingValueAsync</summary>
        public async Task CreateCustomTargetingValueResourceNamesAsync()
        {
            // Snippet: CreateCustomTargetingValueAsync(NetworkName, CustomTargetingValue, CallSettings)
            // Additional: CreateCustomTargetingValueAsync(NetworkName, CustomTargetingValue, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            CustomTargetingValue customTargetingValue = new CustomTargetingValue();
            // Make the request
            CustomTargetingValue response = await customTargetingValueServiceClient.CreateCustomTargetingValueAsync(parent, customTargetingValue);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingValues</summary>
        public void BatchCreateCustomTargetingValuesRequestObject()
        {
            // Snippet: BatchCreateCustomTargetingValues(BatchCreateCustomTargetingValuesRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateCustomTargetingValuesRequest request = new BatchCreateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateCustomTargetingValueRequest(),
                },
            };
            // Make the request
            BatchCreateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchCreateCustomTargetingValues(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingValuesAsync</summary>
        public async Task BatchCreateCustomTargetingValuesRequestObjectAsync()
        {
            // Snippet: BatchCreateCustomTargetingValuesAsync(BatchCreateCustomTargetingValuesRequest, CallSettings)
            // Additional: BatchCreateCustomTargetingValuesAsync(BatchCreateCustomTargetingValuesRequest, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateCustomTargetingValuesRequest request = new BatchCreateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateCustomTargetingValueRequest(),
                },
            };
            // Make the request
            BatchCreateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchCreateCustomTargetingValuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingValues</summary>
        public void BatchCreateCustomTargetingValues()
        {
            // Snippet: BatchCreateCustomTargetingValues(string, IEnumerable<CreateCustomTargetingValueRequest>, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateCustomTargetingValueRequest> requests = new CreateCustomTargetingValueRequest[]
            {
                new CreateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchCreateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchCreateCustomTargetingValues(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingValuesAsync</summary>
        public async Task BatchCreateCustomTargetingValuesAsync()
        {
            // Snippet: BatchCreateCustomTargetingValuesAsync(string, IEnumerable<CreateCustomTargetingValueRequest>, CallSettings)
            // Additional: BatchCreateCustomTargetingValuesAsync(string, IEnumerable<CreateCustomTargetingValueRequest>, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateCustomTargetingValueRequest> requests = new CreateCustomTargetingValueRequest[]
            {
                new CreateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchCreateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchCreateCustomTargetingValuesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingValues</summary>
        public void BatchCreateCustomTargetingValuesResourceNames()
        {
            // Snippet: BatchCreateCustomTargetingValues(NetworkName, IEnumerable<CreateCustomTargetingValueRequest>, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateCustomTargetingValueRequest> requests = new CreateCustomTargetingValueRequest[]
            {
                new CreateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchCreateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchCreateCustomTargetingValues(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateCustomTargetingValuesAsync</summary>
        public async Task BatchCreateCustomTargetingValuesResourceNamesAsync()
        {
            // Snippet: BatchCreateCustomTargetingValuesAsync(NetworkName, IEnumerable<CreateCustomTargetingValueRequest>, CallSettings)
            // Additional: BatchCreateCustomTargetingValuesAsync(NetworkName, IEnumerable<CreateCustomTargetingValueRequest>, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateCustomTargetingValueRequest> requests = new CreateCustomTargetingValueRequest[]
            {
                new CreateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchCreateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchCreateCustomTargetingValuesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetingValue</summary>
        public void UpdateCustomTargetingValueRequestObject()
        {
            // Snippet: UpdateCustomTargetingValue(UpdateCustomTargetingValueRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            UpdateCustomTargetingValueRequest request = new UpdateCustomTargetingValueRequest
            {
                CustomTargetingValue = new CustomTargetingValue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomTargetingValue response = customTargetingValueServiceClient.UpdateCustomTargetingValue(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetingValueAsync</summary>
        public async Task UpdateCustomTargetingValueRequestObjectAsync()
        {
            // Snippet: UpdateCustomTargetingValueAsync(UpdateCustomTargetingValueRequest, CallSettings)
            // Additional: UpdateCustomTargetingValueAsync(UpdateCustomTargetingValueRequest, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomTargetingValueRequest request = new UpdateCustomTargetingValueRequest
            {
                CustomTargetingValue = new CustomTargetingValue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomTargetingValue response = await customTargetingValueServiceClient.UpdateCustomTargetingValueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetingValue</summary>
        public void UpdateCustomTargetingValue()
        {
            // Snippet: UpdateCustomTargetingValue(CustomTargetingValue, FieldMask, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            CustomTargetingValue customTargetingValue = new CustomTargetingValue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomTargetingValue response = customTargetingValueServiceClient.UpdateCustomTargetingValue(customTargetingValue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetingValueAsync</summary>
        public async Task UpdateCustomTargetingValueAsync()
        {
            // Snippet: UpdateCustomTargetingValueAsync(CustomTargetingValue, FieldMask, CallSettings)
            // Additional: UpdateCustomTargetingValueAsync(CustomTargetingValue, FieldMask, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomTargetingValue customTargetingValue = new CustomTargetingValue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomTargetingValue response = await customTargetingValueServiceClient.UpdateCustomTargetingValueAsync(customTargetingValue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingValues</summary>
        public void BatchUpdateCustomTargetingValuesRequestObject()
        {
            // Snippet: BatchUpdateCustomTargetingValues(BatchUpdateCustomTargetingValuesRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateCustomTargetingValuesRequest request = new BatchUpdateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateCustomTargetingValueRequest(),
                },
            };
            // Make the request
            BatchUpdateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchUpdateCustomTargetingValues(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingValuesAsync</summary>
        public async Task BatchUpdateCustomTargetingValuesRequestObjectAsync()
        {
            // Snippet: BatchUpdateCustomTargetingValuesAsync(BatchUpdateCustomTargetingValuesRequest, CallSettings)
            // Additional: BatchUpdateCustomTargetingValuesAsync(BatchUpdateCustomTargetingValuesRequest, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateCustomTargetingValuesRequest request = new BatchUpdateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateCustomTargetingValueRequest(),
                },
            };
            // Make the request
            BatchUpdateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchUpdateCustomTargetingValuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingValues</summary>
        public void BatchUpdateCustomTargetingValues()
        {
            // Snippet: BatchUpdateCustomTargetingValues(string, IEnumerable<UpdateCustomTargetingValueRequest>, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateCustomTargetingValueRequest> requests = new UpdateCustomTargetingValueRequest[]
            {
                new UpdateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchUpdateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchUpdateCustomTargetingValues(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingValuesAsync</summary>
        public async Task BatchUpdateCustomTargetingValuesAsync()
        {
            // Snippet: BatchUpdateCustomTargetingValuesAsync(string, IEnumerable<UpdateCustomTargetingValueRequest>, CallSettings)
            // Additional: BatchUpdateCustomTargetingValuesAsync(string, IEnumerable<UpdateCustomTargetingValueRequest>, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateCustomTargetingValueRequest> requests = new UpdateCustomTargetingValueRequest[]
            {
                new UpdateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchUpdateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchUpdateCustomTargetingValuesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingValues</summary>
        public void BatchUpdateCustomTargetingValuesResourceNames()
        {
            // Snippet: BatchUpdateCustomTargetingValues(NetworkName, IEnumerable<UpdateCustomTargetingValueRequest>, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateCustomTargetingValueRequest> requests = new UpdateCustomTargetingValueRequest[]
            {
                new UpdateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchUpdateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchUpdateCustomTargetingValues(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateCustomTargetingValuesAsync</summary>
        public async Task BatchUpdateCustomTargetingValuesResourceNamesAsync()
        {
            // Snippet: BatchUpdateCustomTargetingValuesAsync(NetworkName, IEnumerable<UpdateCustomTargetingValueRequest>, CallSettings)
            // Additional: BatchUpdateCustomTargetingValuesAsync(NetworkName, IEnumerable<UpdateCustomTargetingValueRequest>, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateCustomTargetingValueRequest> requests = new UpdateCustomTargetingValueRequest[]
            {
                new UpdateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchUpdateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchUpdateCustomTargetingValuesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingValues</summary>
        public void BatchActivateCustomTargetingValuesRequestObject()
        {
            // Snippet: BatchActivateCustomTargetingValues(BatchActivateCustomTargetingValuesRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateCustomTargetingValuesRequest request = new BatchActivateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new ActivateCustomTargetingValueRequest(),
                },
            };
            // Make the request
            BatchActivateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchActivateCustomTargetingValues(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingValuesAsync</summary>
        public async Task BatchActivateCustomTargetingValuesRequestObjectAsync()
        {
            // Snippet: BatchActivateCustomTargetingValuesAsync(BatchActivateCustomTargetingValuesRequest, CallSettings)
            // Additional: BatchActivateCustomTargetingValuesAsync(BatchActivateCustomTargetingValuesRequest, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateCustomTargetingValuesRequest request = new BatchActivateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new ActivateCustomTargetingValueRequest(),
                },
            };
            // Make the request
            BatchActivateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchActivateCustomTargetingValuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingValues</summary>
        public void BatchActivateCustomTargetingValues()
        {
            // Snippet: BatchActivateCustomTargetingValues(string, IEnumerable<ActivateCustomTargetingValueRequest>, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<ActivateCustomTargetingValueRequest> requests = new ActivateCustomTargetingValueRequest[]
            {
                new ActivateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchActivateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchActivateCustomTargetingValues(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingValuesAsync</summary>
        public async Task BatchActivateCustomTargetingValuesAsync()
        {
            // Snippet: BatchActivateCustomTargetingValuesAsync(string, IEnumerable<ActivateCustomTargetingValueRequest>, CallSettings)
            // Additional: BatchActivateCustomTargetingValuesAsync(string, IEnumerable<ActivateCustomTargetingValueRequest>, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<ActivateCustomTargetingValueRequest> requests = new ActivateCustomTargetingValueRequest[]
            {
                new ActivateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchActivateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchActivateCustomTargetingValuesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingValues</summary>
        public void BatchActivateCustomTargetingValuesResourceNames()
        {
            // Snippet: BatchActivateCustomTargetingValues(NetworkName, IEnumerable<ActivateCustomTargetingValueRequest>, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ActivateCustomTargetingValueRequest> requests = new ActivateCustomTargetingValueRequest[]
            {
                new ActivateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchActivateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchActivateCustomTargetingValues(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateCustomTargetingValuesAsync</summary>
        public async Task BatchActivateCustomTargetingValuesResourceNamesAsync()
        {
            // Snippet: BatchActivateCustomTargetingValuesAsync(NetworkName, IEnumerable<ActivateCustomTargetingValueRequest>, CallSettings)
            // Additional: BatchActivateCustomTargetingValuesAsync(NetworkName, IEnumerable<ActivateCustomTargetingValueRequest>, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ActivateCustomTargetingValueRequest> requests = new ActivateCustomTargetingValueRequest[]
            {
                new ActivateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchActivateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchActivateCustomTargetingValuesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingValues</summary>
        public void BatchDeactivateCustomTargetingValuesRequestObject()
        {
            // Snippet: BatchDeactivateCustomTargetingValues(BatchDeactivateCustomTargetingValuesRequest, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateCustomTargetingValuesRequest request = new BatchDeactivateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new DeactivateCustomTargetingValueRequest(),
                },
            };
            // Make the request
            BatchDeactivateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchDeactivateCustomTargetingValues(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingValuesAsync</summary>
        public async Task BatchDeactivateCustomTargetingValuesRequestObjectAsync()
        {
            // Snippet: BatchDeactivateCustomTargetingValuesAsync(BatchDeactivateCustomTargetingValuesRequest, CallSettings)
            // Additional: BatchDeactivateCustomTargetingValuesAsync(BatchDeactivateCustomTargetingValuesRequest, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateCustomTargetingValuesRequest request = new BatchDeactivateCustomTargetingValuesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new DeactivateCustomTargetingValueRequest(),
                },
            };
            // Make the request
            BatchDeactivateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchDeactivateCustomTargetingValuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingValues</summary>
        public void BatchDeactivateCustomTargetingValues()
        {
            // Snippet: BatchDeactivateCustomTargetingValues(string, IEnumerable<DeactivateCustomTargetingValueRequest>, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<DeactivateCustomTargetingValueRequest> requests = new DeactivateCustomTargetingValueRequest[]
            {
                new DeactivateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchDeactivateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchDeactivateCustomTargetingValues(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingValuesAsync</summary>
        public async Task BatchDeactivateCustomTargetingValuesAsync()
        {
            // Snippet: BatchDeactivateCustomTargetingValuesAsync(string, IEnumerable<DeactivateCustomTargetingValueRequest>, CallSettings)
            // Additional: BatchDeactivateCustomTargetingValuesAsync(string, IEnumerable<DeactivateCustomTargetingValueRequest>, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<DeactivateCustomTargetingValueRequest> requests = new DeactivateCustomTargetingValueRequest[]
            {
                new DeactivateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchDeactivateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchDeactivateCustomTargetingValuesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingValues</summary>
        public void BatchDeactivateCustomTargetingValuesResourceNames()
        {
            // Snippet: BatchDeactivateCustomTargetingValues(NetworkName, IEnumerable<DeactivateCustomTargetingValueRequest>, CallSettings)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = CustomTargetingValueServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<DeactivateCustomTargetingValueRequest> requests = new DeactivateCustomTargetingValueRequest[]
            {
                new DeactivateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchDeactivateCustomTargetingValuesResponse response = customTargetingValueServiceClient.BatchDeactivateCustomTargetingValues(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateCustomTargetingValuesAsync</summary>
        public async Task BatchDeactivateCustomTargetingValuesResourceNamesAsync()
        {
            // Snippet: BatchDeactivateCustomTargetingValuesAsync(NetworkName, IEnumerable<DeactivateCustomTargetingValueRequest>, CallSettings)
            // Additional: BatchDeactivateCustomTargetingValuesAsync(NetworkName, IEnumerable<DeactivateCustomTargetingValueRequest>, CancellationToken)
            // Create client
            CustomTargetingValueServiceClient customTargetingValueServiceClient = await CustomTargetingValueServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<DeactivateCustomTargetingValueRequest> requests = new DeactivateCustomTargetingValueRequest[]
            {
                new DeactivateCustomTargetingValueRequest(),
            };
            // Make the request
            BatchDeactivateCustomTargetingValuesResponse response = await customTargetingValueServiceClient.BatchDeactivateCustomTargetingValuesAsync(parent, requests);
            // End snippet
        }
    }
}
