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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gaav = Google.Ads.AdManager.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOperatingSystemServiceClientSnippets
    {
        /// <summary>Snippet for GetOperatingSystem</summary>
        public void GetOperatingSystemRequestObject()
        {
            // Snippet: GetOperatingSystem(GetOperatingSystemRequest, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = gaav::OperatingSystemServiceClient.Create();
            // Initialize request argument(s)
            gaav::GetOperatingSystemRequest request = new gaav::GetOperatingSystemRequest
            {
                OperatingSystemName = gaav::OperatingSystemName.FromNetworkCodeOperatingSystem("[NETWORK_CODE]", "[OPERATING_SYSTEM]"),
            };
            // Make the request
            gaav::OperatingSystem response = operatingSystemServiceClient.GetOperatingSystem(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemAsync</summary>
        public async Task GetOperatingSystemRequestObjectAsync()
        {
            // Snippet: GetOperatingSystemAsync(GetOperatingSystemRequest, CallSettings)
            // Additional: GetOperatingSystemAsync(GetOperatingSystemRequest, CancellationToken)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = await gaav::OperatingSystemServiceClient.CreateAsync();
            // Initialize request argument(s)
            gaav::GetOperatingSystemRequest request = new gaav::GetOperatingSystemRequest
            {
                OperatingSystemName = gaav::OperatingSystemName.FromNetworkCodeOperatingSystem("[NETWORK_CODE]", "[OPERATING_SYSTEM]"),
            };
            // Make the request
            gaav::OperatingSystem response = await operatingSystemServiceClient.GetOperatingSystemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystem</summary>
        public void GetOperatingSystem()
        {
            // Snippet: GetOperatingSystem(string, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = gaav::OperatingSystemServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/operatingSystems/[OPERATING_SYSTEM]";
            // Make the request
            gaav::OperatingSystem response = operatingSystemServiceClient.GetOperatingSystem(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemAsync</summary>
        public async Task GetOperatingSystemAsync()
        {
            // Snippet: GetOperatingSystemAsync(string, CallSettings)
            // Additional: GetOperatingSystemAsync(string, CancellationToken)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = await gaav::OperatingSystemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/operatingSystems/[OPERATING_SYSTEM]";
            // Make the request
            gaav::OperatingSystem response = await operatingSystemServiceClient.GetOperatingSystemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystem</summary>
        public void GetOperatingSystemResourceNames()
        {
            // Snippet: GetOperatingSystem(OperatingSystemName, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = gaav::OperatingSystemServiceClient.Create();
            // Initialize request argument(s)
            gaav::OperatingSystemName name = gaav::OperatingSystemName.FromNetworkCodeOperatingSystem("[NETWORK_CODE]", "[OPERATING_SYSTEM]");
            // Make the request
            gaav::OperatingSystem response = operatingSystemServiceClient.GetOperatingSystem(name);
            // End snippet
        }

        /// <summary>Snippet for GetOperatingSystemAsync</summary>
        public async Task GetOperatingSystemResourceNamesAsync()
        {
            // Snippet: GetOperatingSystemAsync(OperatingSystemName, CallSettings)
            // Additional: GetOperatingSystemAsync(OperatingSystemName, CancellationToken)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = await gaav::OperatingSystemServiceClient.CreateAsync();
            // Initialize request argument(s)
            gaav::OperatingSystemName name = gaav::OperatingSystemName.FromNetworkCodeOperatingSystem("[NETWORK_CODE]", "[OPERATING_SYSTEM]");
            // Make the request
            gaav::OperatingSystem response = await operatingSystemServiceClient.GetOperatingSystemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystems</summary>
        public void ListOperatingSystemsRequestObject()
        {
            // Snippet: ListOperatingSystems(ListOperatingSystemsRequest, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = gaav::OperatingSystemServiceClient.Create();
            // Initialize request argument(s)
            gaav::ListOperatingSystemsRequest request = new gaav::ListOperatingSystemsRequest
            {
                ParentAsNetworkName = gaav::NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<gaav::ListOperatingSystemsResponse, gaav::OperatingSystem> response = operatingSystemServiceClient.ListOperatingSystems(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gaav::OperatingSystem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gaav::ListOperatingSystemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gaav::OperatingSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gaav::OperatingSystem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gaav::OperatingSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemsAsync</summary>
        public async Task ListOperatingSystemsRequestObjectAsync()
        {
            // Snippet: ListOperatingSystemsAsync(ListOperatingSystemsRequest, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = await gaav::OperatingSystemServiceClient.CreateAsync();
            // Initialize request argument(s)
            gaav::ListOperatingSystemsRequest request = new gaav::ListOperatingSystemsRequest
            {
                ParentAsNetworkName = gaav::NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<gaav::ListOperatingSystemsResponse, gaav::OperatingSystem> response = operatingSystemServiceClient.ListOperatingSystemsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gaav::OperatingSystem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gaav::ListOperatingSystemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gaav::OperatingSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gaav::OperatingSystem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gaav::OperatingSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystems</summary>
        public void ListOperatingSystems()
        {
            // Snippet: ListOperatingSystems(string, string, int?, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = gaav::OperatingSystemServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<gaav::ListOperatingSystemsResponse, gaav::OperatingSystem> response = operatingSystemServiceClient.ListOperatingSystems(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gaav::OperatingSystem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gaav::ListOperatingSystemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gaav::OperatingSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gaav::OperatingSystem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gaav::OperatingSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemsAsync</summary>
        public async Task ListOperatingSystemsAsync()
        {
            // Snippet: ListOperatingSystemsAsync(string, string, int?, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = await gaav::OperatingSystemServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<gaav::ListOperatingSystemsResponse, gaav::OperatingSystem> response = operatingSystemServiceClient.ListOperatingSystemsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gaav::OperatingSystem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gaav::ListOperatingSystemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gaav::OperatingSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gaav::OperatingSystem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gaav::OperatingSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystems</summary>
        public void ListOperatingSystemsResourceNames()
        {
            // Snippet: ListOperatingSystems(NetworkName, string, int?, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = gaav::OperatingSystemServiceClient.Create();
            // Initialize request argument(s)
            gaav::NetworkName parent = gaav::NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<gaav::ListOperatingSystemsResponse, gaav::OperatingSystem> response = operatingSystemServiceClient.ListOperatingSystems(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gaav::OperatingSystem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gaav::ListOperatingSystemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gaav::OperatingSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gaav::OperatingSystem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gaav::OperatingSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOperatingSystemsAsync</summary>
        public async Task ListOperatingSystemsResourceNamesAsync()
        {
            // Snippet: ListOperatingSystemsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            gaav::OperatingSystemServiceClient operatingSystemServiceClient = await gaav::OperatingSystemServiceClient.CreateAsync();
            // Initialize request argument(s)
            gaav::NetworkName parent = gaav::NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<gaav::ListOperatingSystemsResponse, gaav::OperatingSystem> response = operatingSystemServiceClient.ListOperatingSystemsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gaav::OperatingSystem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gaav::ListOperatingSystemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gaav::OperatingSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gaav::OperatingSystem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gaav::OperatingSystem item in singlePage)
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
