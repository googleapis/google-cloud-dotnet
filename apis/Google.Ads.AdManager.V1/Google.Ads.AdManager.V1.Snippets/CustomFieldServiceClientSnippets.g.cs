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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCustomFieldServiceClientSnippets
    {
        /// <summary>Snippet for GetCustomField</summary>
        public void GetCustomFieldRequestObject()
        {
            // Snippet: GetCustomField(GetCustomFieldRequest, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = CustomFieldServiceClient.Create();
            // Initialize request argument(s)
            GetCustomFieldRequest request = new GetCustomFieldRequest
            {
                CustomFieldName = CustomFieldName.FromNetworkCodeCustomField("[NETWORK_CODE]", "[CUSTOM_FIELD]"),
            };
            // Make the request
            CustomField response = customFieldServiceClient.GetCustomField(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomFieldAsync</summary>
        public async Task GetCustomFieldRequestObjectAsync()
        {
            // Snippet: GetCustomFieldAsync(GetCustomFieldRequest, CallSettings)
            // Additional: GetCustomFieldAsync(GetCustomFieldRequest, CancellationToken)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = await CustomFieldServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomFieldRequest request = new GetCustomFieldRequest
            {
                CustomFieldName = CustomFieldName.FromNetworkCodeCustomField("[NETWORK_CODE]", "[CUSTOM_FIELD]"),
            };
            // Make the request
            CustomField response = await customFieldServiceClient.GetCustomFieldAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomField</summary>
        public void GetCustomField()
        {
            // Snippet: GetCustomField(string, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = CustomFieldServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/customFields/[CUSTOM_FIELD]";
            // Make the request
            CustomField response = customFieldServiceClient.GetCustomField(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomFieldAsync</summary>
        public async Task GetCustomFieldAsync()
        {
            // Snippet: GetCustomFieldAsync(string, CallSettings)
            // Additional: GetCustomFieldAsync(string, CancellationToken)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = await CustomFieldServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/customFields/[CUSTOM_FIELD]";
            // Make the request
            CustomField response = await customFieldServiceClient.GetCustomFieldAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomField</summary>
        public void GetCustomFieldResourceNames()
        {
            // Snippet: GetCustomField(CustomFieldName, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = CustomFieldServiceClient.Create();
            // Initialize request argument(s)
            CustomFieldName name = CustomFieldName.FromNetworkCodeCustomField("[NETWORK_CODE]", "[CUSTOM_FIELD]");
            // Make the request
            CustomField response = customFieldServiceClient.GetCustomField(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomFieldAsync</summary>
        public async Task GetCustomFieldResourceNamesAsync()
        {
            // Snippet: GetCustomFieldAsync(CustomFieldName, CallSettings)
            // Additional: GetCustomFieldAsync(CustomFieldName, CancellationToken)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = await CustomFieldServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomFieldName name = CustomFieldName.FromNetworkCodeCustomField("[NETWORK_CODE]", "[CUSTOM_FIELD]");
            // Make the request
            CustomField response = await customFieldServiceClient.GetCustomFieldAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListCustomFields</summary>
        public void ListCustomFieldsRequestObject()
        {
            // Snippet: ListCustomFields(ListCustomFieldsRequest, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = CustomFieldServiceClient.Create();
            // Initialize request argument(s)
            ListCustomFieldsRequest request = new ListCustomFieldsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListCustomFieldsResponse, CustomField> response = customFieldServiceClient.ListCustomFields(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomField item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomFieldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomField item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomField> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomField item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomFieldsAsync</summary>
        public async Task ListCustomFieldsRequestObjectAsync()
        {
            // Snippet: ListCustomFieldsAsync(ListCustomFieldsRequest, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = await CustomFieldServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomFieldsRequest request = new ListCustomFieldsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomFieldsResponse, CustomField> response = customFieldServiceClient.ListCustomFieldsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomField item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomFieldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomField item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomField> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomField item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomFields</summary>
        public void ListCustomFields()
        {
            // Snippet: ListCustomFields(string, string, int?, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = CustomFieldServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListCustomFieldsResponse, CustomField> response = customFieldServiceClient.ListCustomFields(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomField item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomFieldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomField item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomField> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomField item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomFieldsAsync</summary>
        public async Task ListCustomFieldsAsync()
        {
            // Snippet: ListCustomFieldsAsync(string, string, int?, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = await CustomFieldServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListCustomFieldsResponse, CustomField> response = customFieldServiceClient.ListCustomFieldsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomField item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomFieldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomField item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomField> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomField item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomFields</summary>
        public void ListCustomFieldsResourceNames()
        {
            // Snippet: ListCustomFields(NetworkName, string, int?, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = CustomFieldServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListCustomFieldsResponse, CustomField> response = customFieldServiceClient.ListCustomFields(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomField item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomFieldsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomField item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomField> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomField item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomFieldsAsync</summary>
        public async Task ListCustomFieldsResourceNamesAsync()
        {
            // Snippet: ListCustomFieldsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            CustomFieldServiceClient customFieldServiceClient = await CustomFieldServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListCustomFieldsResponse, CustomField> response = customFieldServiceClient.ListCustomFieldsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomField item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomFieldsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomField item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomField> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomField item in singlePage)
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
