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
    public sealed class AllGeneratedDeviceCapabilityServiceClientSnippets
    {
        /// <summary>Snippet for GetDeviceCapability</summary>
        public void GetDeviceCapabilityRequestObject()
        {
            // Snippet: GetDeviceCapability(GetDeviceCapabilityRequest, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = DeviceCapabilityServiceClient.Create();
            // Initialize request argument(s)
            GetDeviceCapabilityRequest request = new GetDeviceCapabilityRequest
            {
                DeviceCapabilityName = DeviceCapabilityName.FromNetworkCodeDeviceCapability("[NETWORK_CODE]", "[DEVICE_CAPABILITY]"),
            };
            // Make the request
            DeviceCapability response = deviceCapabilityServiceClient.GetDeviceCapability(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCapabilityAsync</summary>
        public async Task GetDeviceCapabilityRequestObjectAsync()
        {
            // Snippet: GetDeviceCapabilityAsync(GetDeviceCapabilityRequest, CallSettings)
            // Additional: GetDeviceCapabilityAsync(GetDeviceCapabilityRequest, CancellationToken)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = await DeviceCapabilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeviceCapabilityRequest request = new GetDeviceCapabilityRequest
            {
                DeviceCapabilityName = DeviceCapabilityName.FromNetworkCodeDeviceCapability("[NETWORK_CODE]", "[DEVICE_CAPABILITY]"),
            };
            // Make the request
            DeviceCapability response = await deviceCapabilityServiceClient.GetDeviceCapabilityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCapability</summary>
        public void GetDeviceCapability()
        {
            // Snippet: GetDeviceCapability(string, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = DeviceCapabilityServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/deviceCapabilities/[DEVICE_CAPABILITY]";
            // Make the request
            DeviceCapability response = deviceCapabilityServiceClient.GetDeviceCapability(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCapabilityAsync</summary>
        public async Task GetDeviceCapabilityAsync()
        {
            // Snippet: GetDeviceCapabilityAsync(string, CallSettings)
            // Additional: GetDeviceCapabilityAsync(string, CancellationToken)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = await DeviceCapabilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/deviceCapabilities/[DEVICE_CAPABILITY]";
            // Make the request
            DeviceCapability response = await deviceCapabilityServiceClient.GetDeviceCapabilityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCapability</summary>
        public void GetDeviceCapabilityResourceNames()
        {
            // Snippet: GetDeviceCapability(DeviceCapabilityName, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = DeviceCapabilityServiceClient.Create();
            // Initialize request argument(s)
            DeviceCapabilityName name = DeviceCapabilityName.FromNetworkCodeDeviceCapability("[NETWORK_CODE]", "[DEVICE_CAPABILITY]");
            // Make the request
            DeviceCapability response = deviceCapabilityServiceClient.GetDeviceCapability(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCapabilityAsync</summary>
        public async Task GetDeviceCapabilityResourceNamesAsync()
        {
            // Snippet: GetDeviceCapabilityAsync(DeviceCapabilityName, CallSettings)
            // Additional: GetDeviceCapabilityAsync(DeviceCapabilityName, CancellationToken)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = await DeviceCapabilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeviceCapabilityName name = DeviceCapabilityName.FromNetworkCodeDeviceCapability("[NETWORK_CODE]", "[DEVICE_CAPABILITY]");
            // Make the request
            DeviceCapability response = await deviceCapabilityServiceClient.GetDeviceCapabilityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCapabilities</summary>
        public void ListDeviceCapabilitiesRequestObject()
        {
            // Snippet: ListDeviceCapabilities(ListDeviceCapabilitiesRequest, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = DeviceCapabilityServiceClient.Create();
            // Initialize request argument(s)
            ListDeviceCapabilitiesRequest request = new ListDeviceCapabilitiesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> response = deviceCapabilityServiceClient.ListDeviceCapabilities(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceCapability item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceCapabilitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCapability item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCapability> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCapability item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCapabilitiesAsync</summary>
        public async Task ListDeviceCapabilitiesRequestObjectAsync()
        {
            // Snippet: ListDeviceCapabilitiesAsync(ListDeviceCapabilitiesRequest, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = await DeviceCapabilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDeviceCapabilitiesRequest request = new ListDeviceCapabilitiesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> response = deviceCapabilityServiceClient.ListDeviceCapabilitiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceCapability item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceCapabilitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCapability item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCapability> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCapability item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCapabilities</summary>
        public void ListDeviceCapabilities()
        {
            // Snippet: ListDeviceCapabilities(string, string, int?, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = DeviceCapabilityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> response = deviceCapabilityServiceClient.ListDeviceCapabilities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceCapability item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceCapabilitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCapability item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCapability> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCapability item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCapabilitiesAsync</summary>
        public async Task ListDeviceCapabilitiesAsync()
        {
            // Snippet: ListDeviceCapabilitiesAsync(string, string, int?, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = await DeviceCapabilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> response = deviceCapabilityServiceClient.ListDeviceCapabilitiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceCapability item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceCapabilitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCapability item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCapability> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCapability item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCapabilities</summary>
        public void ListDeviceCapabilitiesResourceNames()
        {
            // Snippet: ListDeviceCapabilities(NetworkName, string, int?, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = DeviceCapabilityServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> response = deviceCapabilityServiceClient.ListDeviceCapabilities(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceCapability item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceCapabilitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCapability item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCapability> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCapability item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCapabilitiesAsync</summary>
        public async Task ListDeviceCapabilitiesResourceNamesAsync()
        {
            // Snippet: ListDeviceCapabilitiesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            DeviceCapabilityServiceClient deviceCapabilityServiceClient = await DeviceCapabilityServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListDeviceCapabilitiesResponse, DeviceCapability> response = deviceCapabilityServiceClient.ListDeviceCapabilitiesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceCapability item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceCapabilitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCapability item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCapability> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCapability item in singlePage)
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
