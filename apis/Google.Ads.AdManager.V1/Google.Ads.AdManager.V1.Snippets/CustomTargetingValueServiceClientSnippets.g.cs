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
            await response.ForEachAsync((CustomTargetingValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((CustomTargetingValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((CustomTargetingValue item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetingValuesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetingValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
    }
}
