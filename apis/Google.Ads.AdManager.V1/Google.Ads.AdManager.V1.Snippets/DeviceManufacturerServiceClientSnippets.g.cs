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
    public sealed class AllGeneratedDeviceManufacturerServiceClientSnippets
    {
        /// <summary>Snippet for GetDeviceManufacturer</summary>
        public void GetDeviceManufacturerRequestObject()
        {
            // Snippet: GetDeviceManufacturer(GetDeviceManufacturerRequest, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = DeviceManufacturerServiceClient.Create();
            // Initialize request argument(s)
            GetDeviceManufacturerRequest request = new GetDeviceManufacturerRequest
            {
                DeviceManufacturerName = DeviceManufacturerName.FromNetworkCodeDeviceManufacturer("[NETWORK_CODE]", "[DEVICE_MANUFACTURER]"),
            };
            // Make the request
            DeviceManufacturer response = deviceManufacturerServiceClient.GetDeviceManufacturer(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceManufacturerAsync</summary>
        public async Task GetDeviceManufacturerRequestObjectAsync()
        {
            // Snippet: GetDeviceManufacturerAsync(GetDeviceManufacturerRequest, CallSettings)
            // Additional: GetDeviceManufacturerAsync(GetDeviceManufacturerRequest, CancellationToken)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = await DeviceManufacturerServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeviceManufacturerRequest request = new GetDeviceManufacturerRequest
            {
                DeviceManufacturerName = DeviceManufacturerName.FromNetworkCodeDeviceManufacturer("[NETWORK_CODE]", "[DEVICE_MANUFACTURER]"),
            };
            // Make the request
            DeviceManufacturer response = await deviceManufacturerServiceClient.GetDeviceManufacturerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceManufacturer</summary>
        public void GetDeviceManufacturer()
        {
            // Snippet: GetDeviceManufacturer(string, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = DeviceManufacturerServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/deviceManufacturers/[DEVICE_MANUFACTURER]";
            // Make the request
            DeviceManufacturer response = deviceManufacturerServiceClient.GetDeviceManufacturer(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceManufacturerAsync</summary>
        public async Task GetDeviceManufacturerAsync()
        {
            // Snippet: GetDeviceManufacturerAsync(string, CallSettings)
            // Additional: GetDeviceManufacturerAsync(string, CancellationToken)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = await DeviceManufacturerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/deviceManufacturers/[DEVICE_MANUFACTURER]";
            // Make the request
            DeviceManufacturer response = await deviceManufacturerServiceClient.GetDeviceManufacturerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceManufacturer</summary>
        public void GetDeviceManufacturerResourceNames()
        {
            // Snippet: GetDeviceManufacturer(DeviceManufacturerName, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = DeviceManufacturerServiceClient.Create();
            // Initialize request argument(s)
            DeviceManufacturerName name = DeviceManufacturerName.FromNetworkCodeDeviceManufacturer("[NETWORK_CODE]", "[DEVICE_MANUFACTURER]");
            // Make the request
            DeviceManufacturer response = deviceManufacturerServiceClient.GetDeviceManufacturer(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceManufacturerAsync</summary>
        public async Task GetDeviceManufacturerResourceNamesAsync()
        {
            // Snippet: GetDeviceManufacturerAsync(DeviceManufacturerName, CallSettings)
            // Additional: GetDeviceManufacturerAsync(DeviceManufacturerName, CancellationToken)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = await DeviceManufacturerServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeviceManufacturerName name = DeviceManufacturerName.FromNetworkCodeDeviceManufacturer("[NETWORK_CODE]", "[DEVICE_MANUFACTURER]");
            // Make the request
            DeviceManufacturer response = await deviceManufacturerServiceClient.GetDeviceManufacturerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceManufacturers</summary>
        public void ListDeviceManufacturersRequestObject()
        {
            // Snippet: ListDeviceManufacturers(ListDeviceManufacturersRequest, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = DeviceManufacturerServiceClient.Create();
            // Initialize request argument(s)
            ListDeviceManufacturersRequest request = new ListDeviceManufacturersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> response = deviceManufacturerServiceClient.ListDeviceManufacturers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceManufacturer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceManufacturersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceManufacturer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceManufacturer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceManufacturer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceManufacturersAsync</summary>
        public async Task ListDeviceManufacturersRequestObjectAsync()
        {
            // Snippet: ListDeviceManufacturersAsync(ListDeviceManufacturersRequest, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = await DeviceManufacturerServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDeviceManufacturersRequest request = new ListDeviceManufacturersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> response = deviceManufacturerServiceClient.ListDeviceManufacturersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceManufacturer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceManufacturersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceManufacturer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceManufacturer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceManufacturer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceManufacturers</summary>
        public void ListDeviceManufacturers()
        {
            // Snippet: ListDeviceManufacturers(string, string, int?, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = DeviceManufacturerServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> response = deviceManufacturerServiceClient.ListDeviceManufacturers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceManufacturer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceManufacturersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceManufacturer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceManufacturer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceManufacturer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceManufacturersAsync</summary>
        public async Task ListDeviceManufacturersAsync()
        {
            // Snippet: ListDeviceManufacturersAsync(string, string, int?, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = await DeviceManufacturerServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> response = deviceManufacturerServiceClient.ListDeviceManufacturersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceManufacturer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceManufacturersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceManufacturer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceManufacturer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceManufacturer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceManufacturers</summary>
        public void ListDeviceManufacturersResourceNames()
        {
            // Snippet: ListDeviceManufacturers(NetworkName, string, int?, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = DeviceManufacturerServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> response = deviceManufacturerServiceClient.ListDeviceManufacturers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceManufacturer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceManufacturersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceManufacturer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceManufacturer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceManufacturer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceManufacturersAsync</summary>
        public async Task ListDeviceManufacturersResourceNamesAsync()
        {
            // Snippet: ListDeviceManufacturersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            DeviceManufacturerServiceClient deviceManufacturerServiceClient = await DeviceManufacturerServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListDeviceManufacturersResponse, DeviceManufacturer> response = deviceManufacturerServiceClient.ListDeviceManufacturersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceManufacturer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceManufacturersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceManufacturer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceManufacturer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceManufacturer item in singlePage)
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
