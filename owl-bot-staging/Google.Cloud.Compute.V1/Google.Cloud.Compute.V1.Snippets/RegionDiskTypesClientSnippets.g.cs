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
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionDiskTypesClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetRegionDiskTypeRequest, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = RegionDiskTypesClient.Create();
            // Initialize request argument(s)
            GetRegionDiskTypeRequest request = new GetRegionDiskTypeRequest
            {
                DiskType = "",
                Region = "",
                Project = "",
            };
            // Make the request
            DiskType response = regionDiskTypesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionDiskTypeRequest, CallSettings)
            // Additional: GetAsync(GetRegionDiskTypeRequest, CancellationToken)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = await RegionDiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionDiskTypeRequest request = new GetRegionDiskTypeRequest
            {
                DiskType = "",
                Region = "",
                Project = "",
            };
            // Make the request
            DiskType response = await regionDiskTypesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = RegionDiskTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string diskType = "";
            // Make the request
            DiskType response = regionDiskTypesClient.Get(project, region, diskType);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = await RegionDiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string diskType = "";
            // Make the request
            DiskType response = await regionDiskTypesClient.GetAsync(project, region, diskType);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListRegionDiskTypesRequest, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = RegionDiskTypesClient.Create();
            // Initialize request argument(s)
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<RegionDiskTypeList, DiskType> response = regionDiskTypesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiskType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionDiskTypeList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiskType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiskType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiskType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListRegionDiskTypesRequest, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = await RegionDiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<RegionDiskTypeList, DiskType> response = regionDiskTypesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiskType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionDiskTypeList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiskType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiskType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiskType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = RegionDiskTypesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<RegionDiskTypeList, DiskType> response = regionDiskTypesClient.List(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DiskType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (RegionDiskTypeList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiskType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiskType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiskType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            RegionDiskTypesClient regionDiskTypesClient = await RegionDiskTypesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<RegionDiskTypeList, DiskType> response = regionDiskTypesClient.ListAsync(project, region);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DiskType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((RegionDiskTypeList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DiskType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DiskType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DiskType item in singlePage)
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
