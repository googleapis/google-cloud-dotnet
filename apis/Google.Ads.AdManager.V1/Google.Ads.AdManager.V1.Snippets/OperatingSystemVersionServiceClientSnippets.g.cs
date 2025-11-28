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
    public sealed class AllGeneratedOperatingSystemVersionServiceClientSnippets
    {
        /// <summary>Snippet for GetOperatingSystemVersion</summary>
        public void GetOperatingSystemVersionRequestObject()
        {
            // Snippet: GetOperatingSystemVersion(GetOperatingSystemVersionRequest, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = OperatingSystemVersionServiceClient.Create();
            // Initialize request argument(s)
            GetOperatingSystemVersionRequest request = new GetOperatingSystemVersionRequest
            {
                OperatingSystemVersionName = OperatingSystemVersionName.FromNetworkCodeOperatingSystemVersion("[NETWORK_CODE]", "[OPERATING_SYSTEM_VERSION]"),
            };
            // Make the request
            OperatingSystemVersion response = operatingSystemVersionServiceClient.GetOperatingSystemVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersionAsync</summary>
        public async Task GetOperatingSystemVersionRequestObjectAsync()
        {
            // Snippet: GetOperatingSystemVersionAsync(GetOperatingSystemVersionRequest, CallSettings)
            // Additional: GetOperatingSystemVersionAsync(GetOperatingSystemVersionRequest, CancellationToken)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = await OperatingSystemVersionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOperatingSystemVersionRequest request = new GetOperatingSystemVersionRequest
            {
                OperatingSystemVersionName = OperatingSystemVersionName.FromNetworkCodeOperatingSystemVersion("[NETWORK_CODE]", "[OPERATING_SYSTEM_VERSION]"),
            };
            // Make the request
            OperatingSystemVersion response = await operatingSystemVersionServiceClient.GetOperatingSystemVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersion</summary>
        public void GetOperatingSystemVersion()
        {
            // Snippet: GetOperatingSystemVersion(string, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = OperatingSystemVersionServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/operatingSystemVersions/[OPERATING_SYSTEM_VERSION]";
            // Make the request
            OperatingSystemVersion response = operatingSystemVersionServiceClient.GetOperatingSystemVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersionAsync</summary>
        public async Task GetOperatingSystemVersionAsync()
        {
            // Snippet: GetOperatingSystemVersionAsync(string, CallSettings)
            // Additional: GetOperatingSystemVersionAsync(string, CancellationToken)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = await OperatingSystemVersionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/operatingSystemVersions/[OPERATING_SYSTEM_VERSION]";
            // Make the request
            OperatingSystemVersion response = await operatingSystemVersionServiceClient.GetOperatingSystemVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersion</summary>
        public void GetOperatingSystemVersionResourceNames()
        {
            // Snippet: GetOperatingSystemVersion(OperatingSystemVersionName, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = OperatingSystemVersionServiceClient.Create();
            // Initialize request argument(s)
            OperatingSystemVersionName name = OperatingSystemVersionName.FromNetworkCodeOperatingSystemVersion("[NETWORK_CODE]", "[OPERATING_SYSTEM_VERSION]");
            // Make the request
            OperatingSystemVersion response = operatingSystemVersionServiceClient.GetOperatingSystemVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemVersionAsync</summary>
        public async Task GetOperatingSystemVersionResourceNamesAsync()
        {
            // Snippet: GetOperatingSystemVersionAsync(OperatingSystemVersionName, CallSettings)
            // Additional: GetOperatingSystemVersionAsync(OperatingSystemVersionName, CancellationToken)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = await OperatingSystemVersionServiceClient.CreateAsync();
            // Initialize request argument(s)
            OperatingSystemVersionName name = OperatingSystemVersionName.FromNetworkCodeOperatingSystemVersion("[NETWORK_CODE]", "[OPERATING_SYSTEM_VERSION]");
            // Make the request
            OperatingSystemVersion response = await operatingSystemVersionServiceClient.GetOperatingSystemVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemVersions</summary>
        public void ListOperatingSystemVersionsRequestObject()
        {
            // Snippet: ListOperatingSystemVersions(ListOperatingSystemVersionsRequest, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = OperatingSystemVersionServiceClient.Create();
            // Initialize request argument(s)
            ListOperatingSystemVersionsRequest request = new ListOperatingSystemVersionsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> response = operatingSystemVersionServiceClient.ListOperatingSystemVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OperatingSystemVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOperatingSystemVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OperatingSystemVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OperatingSystemVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OperatingSystemVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemVersionsAsync</summary>
        public async Task ListOperatingSystemVersionsRequestObjectAsync()
        {
            // Snippet: ListOperatingSystemVersionsAsync(ListOperatingSystemVersionsRequest, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = await OperatingSystemVersionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOperatingSystemVersionsRequest request = new ListOperatingSystemVersionsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> response = operatingSystemVersionServiceClient.ListOperatingSystemVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OperatingSystemVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOperatingSystemVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OperatingSystemVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OperatingSystemVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OperatingSystemVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemVersions</summary>
        public void ListOperatingSystemVersions()
        {
            // Snippet: ListOperatingSystemVersions(string, string, int?, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = OperatingSystemVersionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> response = operatingSystemVersionServiceClient.ListOperatingSystemVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OperatingSystemVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOperatingSystemVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OperatingSystemVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OperatingSystemVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OperatingSystemVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemVersionsAsync</summary>
        public async Task ListOperatingSystemVersionsAsync()
        {
            // Snippet: ListOperatingSystemVersionsAsync(string, string, int?, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = await OperatingSystemVersionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> response = operatingSystemVersionServiceClient.ListOperatingSystemVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OperatingSystemVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOperatingSystemVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OperatingSystemVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OperatingSystemVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OperatingSystemVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemVersions</summary>
        public void ListOperatingSystemVersionsResourceNames()
        {
            // Snippet: ListOperatingSystemVersions(NetworkName, string, int?, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = OperatingSystemVersionServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> response = operatingSystemVersionServiceClient.ListOperatingSystemVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OperatingSystemVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOperatingSystemVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OperatingSystemVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OperatingSystemVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OperatingSystemVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemVersionsAsync</summary>
        public async Task ListOperatingSystemVersionsResourceNamesAsync()
        {
            // Snippet: ListOperatingSystemVersionsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            OperatingSystemVersionServiceClient operatingSystemVersionServiceClient = await OperatingSystemVersionServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListOperatingSystemVersionsResponse, OperatingSystemVersion> response = operatingSystemVersionServiceClient.ListOperatingSystemVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OperatingSystemVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOperatingSystemVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OperatingSystemVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OperatingSystemVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OperatingSystemVersion item in singlePage)
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
