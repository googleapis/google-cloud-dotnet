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
    public sealed class AllGeneratedDeviceCategoryServiceClientSnippets
    {
        /// <summary>Snippet for GetDeviceCategory</summary>
        public void GetDeviceCategoryRequestObject()
        {
            // Snippet: GetDeviceCategory(GetDeviceCategoryRequest, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = DeviceCategoryServiceClient.Create();
            // Initialize request argument(s)
            GetDeviceCategoryRequest request = new GetDeviceCategoryRequest
            {
                DeviceCategoryName = DeviceCategoryName.FromNetworkCodeDeviceCategory("[NETWORK_CODE]", "[DEVICE_CATEGORY]"),
            };
            // Make the request
            DeviceCategory response = deviceCategoryServiceClient.GetDeviceCategory(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCategoryAsync</summary>
        public async Task GetDeviceCategoryRequestObjectAsync()
        {
            // Snippet: GetDeviceCategoryAsync(GetDeviceCategoryRequest, CallSettings)
            // Additional: GetDeviceCategoryAsync(GetDeviceCategoryRequest, CancellationToken)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = await DeviceCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeviceCategoryRequest request = new GetDeviceCategoryRequest
            {
                DeviceCategoryName = DeviceCategoryName.FromNetworkCodeDeviceCategory("[NETWORK_CODE]", "[DEVICE_CATEGORY]"),
            };
            // Make the request
            DeviceCategory response = await deviceCategoryServiceClient.GetDeviceCategoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCategory</summary>
        public void GetDeviceCategory()
        {
            // Snippet: GetDeviceCategory(string, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = DeviceCategoryServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/deviceCategories/[DEVICE_CATEGORY]";
            // Make the request
            DeviceCategory response = deviceCategoryServiceClient.GetDeviceCategory(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCategoryAsync</summary>
        public async Task GetDeviceCategoryAsync()
        {
            // Snippet: GetDeviceCategoryAsync(string, CallSettings)
            // Additional: GetDeviceCategoryAsync(string, CancellationToken)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = await DeviceCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/deviceCategories/[DEVICE_CATEGORY]";
            // Make the request
            DeviceCategory response = await deviceCategoryServiceClient.GetDeviceCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCategory</summary>
        public void GetDeviceCategoryResourceNames()
        {
            // Snippet: GetDeviceCategory(DeviceCategoryName, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = DeviceCategoryServiceClient.Create();
            // Initialize request argument(s)
            DeviceCategoryName name = DeviceCategoryName.FromNetworkCodeDeviceCategory("[NETWORK_CODE]", "[DEVICE_CATEGORY]");
            // Make the request
            DeviceCategory response = deviceCategoryServiceClient.GetDeviceCategory(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeviceCategoryAsync</summary>
        public async Task GetDeviceCategoryResourceNamesAsync()
        {
            // Snippet: GetDeviceCategoryAsync(DeviceCategoryName, CallSettings)
            // Additional: GetDeviceCategoryAsync(DeviceCategoryName, CancellationToken)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = await DeviceCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeviceCategoryName name = DeviceCategoryName.FromNetworkCodeDeviceCategory("[NETWORK_CODE]", "[DEVICE_CATEGORY]");
            // Make the request
            DeviceCategory response = await deviceCategoryServiceClient.GetDeviceCategoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCategories</summary>
        public void ListDeviceCategoriesRequestObject()
        {
            // Snippet: ListDeviceCategories(ListDeviceCategoriesRequest, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = DeviceCategoryServiceClient.Create();
            // Initialize request argument(s)
            ListDeviceCategoriesRequest request = new ListDeviceCategoriesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListDeviceCategoriesResponse, DeviceCategory> response = deviceCategoryServiceClient.ListDeviceCategories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCategoriesAsync</summary>
        public async Task ListDeviceCategoriesRequestObjectAsync()
        {
            // Snippet: ListDeviceCategoriesAsync(ListDeviceCategoriesRequest, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = await DeviceCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDeviceCategoriesRequest request = new ListDeviceCategoriesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListDeviceCategoriesResponse, DeviceCategory> response = deviceCategoryServiceClient.ListDeviceCategoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCategories</summary>
        public void ListDeviceCategories()
        {
            // Snippet: ListDeviceCategories(string, string, int?, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = DeviceCategoryServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListDeviceCategoriesResponse, DeviceCategory> response = deviceCategoryServiceClient.ListDeviceCategories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCategoriesAsync</summary>
        public async Task ListDeviceCategoriesAsync()
        {
            // Snippet: ListDeviceCategoriesAsync(string, string, int?, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = await DeviceCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListDeviceCategoriesResponse, DeviceCategory> response = deviceCategoryServiceClient.ListDeviceCategoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCategories</summary>
        public void ListDeviceCategoriesResourceNames()
        {
            // Snippet: ListDeviceCategories(NetworkName, string, int?, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = DeviceCategoryServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListDeviceCategoriesResponse, DeviceCategory> response = deviceCategoryServiceClient.ListDeviceCategories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeviceCategory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeviceCategoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCategory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCategory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeviceCategoriesAsync</summary>
        public async Task ListDeviceCategoriesResourceNamesAsync()
        {
            // Snippet: ListDeviceCategoriesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            DeviceCategoryServiceClient deviceCategoryServiceClient = await DeviceCategoryServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListDeviceCategoriesResponse, DeviceCategory> response = deviceCategoryServiceClient.ListDeviceCategoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeviceCategory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeviceCategoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeviceCategory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeviceCategory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeviceCategory item in singlePage)
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
