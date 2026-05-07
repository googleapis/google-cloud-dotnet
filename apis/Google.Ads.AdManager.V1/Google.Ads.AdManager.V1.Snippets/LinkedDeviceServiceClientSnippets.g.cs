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
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedLinkedDeviceServiceClientSnippets
    {
        /// <summary>Snippet for GetLinkedDevice</summary>
        public void GetLinkedDeviceRequestObject()
        {
            // Snippet: GetLinkedDevice(GetLinkedDeviceRequest, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = LinkedDeviceServiceClient.Create();
            // Initialize request argument(s)
            GetLinkedDeviceRequest request = new GetLinkedDeviceRequest
            {
                LinkedDeviceName = LinkedDeviceName.FromNetworkCodeLinkedDevice("[NETWORK_CODE]", "[LINKED_DEVICE]"),
            };
            // Make the request
            LinkedDevice response = linkedDeviceServiceClient.GetLinkedDevice(request);
            // End snippet
        }

        /// <summary>Snippet for GetLinkedDeviceAsync</summary>
        public async Task GetLinkedDeviceRequestObjectAsync()
        {
            // Snippet: GetLinkedDeviceAsync(GetLinkedDeviceRequest, CallSettings)
            // Additional: GetLinkedDeviceAsync(GetLinkedDeviceRequest, CancellationToken)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = await LinkedDeviceServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLinkedDeviceRequest request = new GetLinkedDeviceRequest
            {
                LinkedDeviceName = LinkedDeviceName.FromNetworkCodeLinkedDevice("[NETWORK_CODE]", "[LINKED_DEVICE]"),
            };
            // Make the request
            LinkedDevice response = await linkedDeviceServiceClient.GetLinkedDeviceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLinkedDevice</summary>
        public void GetLinkedDevice()
        {
            // Snippet: GetLinkedDevice(string, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = LinkedDeviceServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/linkedDevices/[LINKED_DEVICE]";
            // Make the request
            LinkedDevice response = linkedDeviceServiceClient.GetLinkedDevice(name);
            // End snippet
        }

        /// <summary>Snippet for GetLinkedDeviceAsync</summary>
        public async Task GetLinkedDeviceAsync()
        {
            // Snippet: GetLinkedDeviceAsync(string, CallSettings)
            // Additional: GetLinkedDeviceAsync(string, CancellationToken)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = await LinkedDeviceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/linkedDevices/[LINKED_DEVICE]";
            // Make the request
            LinkedDevice response = await linkedDeviceServiceClient.GetLinkedDeviceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLinkedDevice</summary>
        public void GetLinkedDeviceResourceNames()
        {
            // Snippet: GetLinkedDevice(LinkedDeviceName, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = LinkedDeviceServiceClient.Create();
            // Initialize request argument(s)
            LinkedDeviceName name = LinkedDeviceName.FromNetworkCodeLinkedDevice("[NETWORK_CODE]", "[LINKED_DEVICE]");
            // Make the request
            LinkedDevice response = linkedDeviceServiceClient.GetLinkedDevice(name);
            // End snippet
        }

        /// <summary>Snippet for GetLinkedDeviceAsync</summary>
        public async Task GetLinkedDeviceResourceNamesAsync()
        {
            // Snippet: GetLinkedDeviceAsync(LinkedDeviceName, CallSettings)
            // Additional: GetLinkedDeviceAsync(LinkedDeviceName, CancellationToken)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = await LinkedDeviceServiceClient.CreateAsync();
            // Initialize request argument(s)
            LinkedDeviceName name = LinkedDeviceName.FromNetworkCodeLinkedDevice("[NETWORK_CODE]", "[LINKED_DEVICE]");
            // Make the request
            LinkedDevice response = await linkedDeviceServiceClient.GetLinkedDeviceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLinkedDevices</summary>
        public void ListLinkedDevicesRequestObject()
        {
            // Snippet: ListLinkedDevices(ListLinkedDevicesRequest, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = LinkedDeviceServiceClient.Create();
            // Initialize request argument(s)
            ListLinkedDevicesRequest request = new ListLinkedDevicesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListLinkedDevicesResponse, LinkedDevice> response = linkedDeviceServiceClient.ListLinkedDevices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LinkedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLinkedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkedDevice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinkedDevicesAsync</summary>
        public async Task ListLinkedDevicesRequestObjectAsync()
        {
            // Snippet: ListLinkedDevicesAsync(ListLinkedDevicesRequest, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = await LinkedDeviceServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLinkedDevicesRequest request = new ListLinkedDevicesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListLinkedDevicesResponse, LinkedDevice> response = linkedDeviceServiceClient.ListLinkedDevicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LinkedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLinkedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkedDevice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinkedDevices</summary>
        public void ListLinkedDevices()
        {
            // Snippet: ListLinkedDevices(string, string, int?, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = LinkedDeviceServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListLinkedDevicesResponse, LinkedDevice> response = linkedDeviceServiceClient.ListLinkedDevices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LinkedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLinkedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkedDevice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinkedDevicesAsync</summary>
        public async Task ListLinkedDevicesAsync()
        {
            // Snippet: ListLinkedDevicesAsync(string, string, int?, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = await LinkedDeviceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListLinkedDevicesResponse, LinkedDevice> response = linkedDeviceServiceClient.ListLinkedDevicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LinkedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLinkedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkedDevice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinkedDevices</summary>
        public void ListLinkedDevicesResourceNames()
        {
            // Snippet: ListLinkedDevices(NetworkName, string, int?, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = LinkedDeviceServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListLinkedDevicesResponse, LinkedDevice> response = linkedDeviceServiceClient.ListLinkedDevices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LinkedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLinkedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkedDevice> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkedDevice item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLinkedDevicesAsync</summary>
        public async Task ListLinkedDevicesResourceNamesAsync()
        {
            // Snippet: ListLinkedDevicesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            LinkedDeviceServiceClient linkedDeviceServiceClient = await LinkedDeviceServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListLinkedDevicesResponse, LinkedDevice> response = linkedDeviceServiceClient.ListLinkedDevicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (LinkedDevice item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListLinkedDevicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkedDevice item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkedDevice> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkedDevice item in singlePage)
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
