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
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Maintenance.Api.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMaintenanceClientSnippets
    {
        /// <summary>Snippet for SummarizeMaintenances</summary>
        public void SummarizeMaintenancesRequestObject()
        {
            // Snippet: SummarizeMaintenances(SummarizeMaintenancesRequest, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            SummarizeMaintenancesRequest request = new SummarizeMaintenancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> response = maintenanceClient.SummarizeMaintenances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MaintenanceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SummarizeMaintenancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MaintenanceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MaintenanceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MaintenanceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SummarizeMaintenancesAsync</summary>
        public async Task SummarizeMaintenancesRequestObjectAsync()
        {
            // Snippet: SummarizeMaintenancesAsync(SummarizeMaintenancesRequest, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            SummarizeMaintenancesRequest request = new SummarizeMaintenancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> response = maintenanceClient.SummarizeMaintenancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MaintenanceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SummarizeMaintenancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MaintenanceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MaintenanceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MaintenanceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SummarizeMaintenances</summary>
        public void SummarizeMaintenances()
        {
            // Snippet: SummarizeMaintenances(string, string, int?, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> response = maintenanceClient.SummarizeMaintenances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MaintenanceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SummarizeMaintenancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MaintenanceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MaintenanceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MaintenanceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SummarizeMaintenancesAsync</summary>
        public async Task SummarizeMaintenancesAsync()
        {
            // Snippet: SummarizeMaintenancesAsync(string, string, int?, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> response = maintenanceClient.SummarizeMaintenancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MaintenanceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SummarizeMaintenancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MaintenanceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MaintenanceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MaintenanceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SummarizeMaintenances</summary>
        public void SummarizeMaintenancesResourceNames()
        {
            // Snippet: SummarizeMaintenances(LocationName, string, int?, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> response = maintenanceClient.SummarizeMaintenances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MaintenanceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SummarizeMaintenancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MaintenanceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MaintenanceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MaintenanceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SummarizeMaintenancesAsync</summary>
        public async Task SummarizeMaintenancesResourceNamesAsync()
        {
            // Snippet: SummarizeMaintenancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<SummarizeMaintenancesResponse, MaintenanceSummary> response = maintenanceClient.SummarizeMaintenancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MaintenanceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SummarizeMaintenancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MaintenanceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MaintenanceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MaintenanceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceMaintenances</summary>
        public void ListResourceMaintenancesRequestObject()
        {
            // Snippet: ListResourceMaintenances(ListResourceMaintenancesRequest, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            ListResourceMaintenancesRequest request = new ListResourceMaintenancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> response = maintenanceClient.ListResourceMaintenances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceMaintenance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceMaintenancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceMaintenance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceMaintenance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceMaintenance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceMaintenancesAsync</summary>
        public async Task ListResourceMaintenancesRequestObjectAsync()
        {
            // Snippet: ListResourceMaintenancesAsync(ListResourceMaintenancesRequest, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            ListResourceMaintenancesRequest request = new ListResourceMaintenancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> response = maintenanceClient.ListResourceMaintenancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceMaintenance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceMaintenancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceMaintenance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceMaintenance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceMaintenance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceMaintenances</summary>
        public void ListResourceMaintenances()
        {
            // Snippet: ListResourceMaintenances(string, string, int?, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> response = maintenanceClient.ListResourceMaintenances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceMaintenance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceMaintenancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceMaintenance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceMaintenance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceMaintenance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceMaintenancesAsync</summary>
        public async Task ListResourceMaintenancesAsync()
        {
            // Snippet: ListResourceMaintenancesAsync(string, string, int?, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> response = maintenanceClient.ListResourceMaintenancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceMaintenance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceMaintenancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceMaintenance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceMaintenance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceMaintenance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceMaintenances</summary>
        public void ListResourceMaintenancesResourceNames()
        {
            // Snippet: ListResourceMaintenances(LocationName, string, int?, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> response = maintenanceClient.ListResourceMaintenances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceMaintenance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceMaintenancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceMaintenance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceMaintenance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceMaintenance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceMaintenancesAsync</summary>
        public async Task ListResourceMaintenancesResourceNamesAsync()
        {
            // Snippet: ListResourceMaintenancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListResourceMaintenancesResponse, ResourceMaintenance> response = maintenanceClient.ListResourceMaintenancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ResourceMaintenance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListResourceMaintenancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceMaintenance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceMaintenance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceMaintenance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetResourceMaintenance</summary>
        public void GetResourceMaintenanceRequestObject()
        {
            // Snippet: GetResourceMaintenance(GetResourceMaintenanceRequest, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            GetResourceMaintenanceRequest request = new GetResourceMaintenanceRequest
            {
                ResourceMaintenanceName = ResourceMaintenanceName.FromProjectLocationResourceMaintenance("[PROJECT]", "[LOCATION]", "[RESOURCE_MAINTENANCE]"),
            };
            // Make the request
            ResourceMaintenance response = maintenanceClient.GetResourceMaintenance(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceMaintenanceAsync</summary>
        public async Task GetResourceMaintenanceRequestObjectAsync()
        {
            // Snippet: GetResourceMaintenanceAsync(GetResourceMaintenanceRequest, CallSettings)
            // Additional: GetResourceMaintenanceAsync(GetResourceMaintenanceRequest, CancellationToken)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            GetResourceMaintenanceRequest request = new GetResourceMaintenanceRequest
            {
                ResourceMaintenanceName = ResourceMaintenanceName.FromProjectLocationResourceMaintenance("[PROJECT]", "[LOCATION]", "[RESOURCE_MAINTENANCE]"),
            };
            // Make the request
            ResourceMaintenance response = await maintenanceClient.GetResourceMaintenanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceMaintenance</summary>
        public void GetResourceMaintenance()
        {
            // Snippet: GetResourceMaintenance(string, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceMaintenances/[RESOURCE_MAINTENANCE]";
            // Make the request
            ResourceMaintenance response = maintenanceClient.GetResourceMaintenance(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceMaintenanceAsync</summary>
        public async Task GetResourceMaintenanceAsync()
        {
            // Snippet: GetResourceMaintenanceAsync(string, CallSettings)
            // Additional: GetResourceMaintenanceAsync(string, CancellationToken)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceMaintenances/[RESOURCE_MAINTENANCE]";
            // Make the request
            ResourceMaintenance response = await maintenanceClient.GetResourceMaintenanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceMaintenance</summary>
        public void GetResourceMaintenanceResourceNames()
        {
            // Snippet: GetResourceMaintenance(ResourceMaintenanceName, CallSettings)
            // Create client
            MaintenanceClient maintenanceClient = MaintenanceClient.Create();
            // Initialize request argument(s)
            ResourceMaintenanceName name = ResourceMaintenanceName.FromProjectLocationResourceMaintenance("[PROJECT]", "[LOCATION]", "[RESOURCE_MAINTENANCE]");
            // Make the request
            ResourceMaintenance response = maintenanceClient.GetResourceMaintenance(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceMaintenanceAsync</summary>
        public async Task GetResourceMaintenanceResourceNamesAsync()
        {
            // Snippet: GetResourceMaintenanceAsync(ResourceMaintenanceName, CallSettings)
            // Additional: GetResourceMaintenanceAsync(ResourceMaintenanceName, CancellationToken)
            // Create client
            MaintenanceClient maintenanceClient = await MaintenanceClient.CreateAsync();
            // Initialize request argument(s)
            ResourceMaintenanceName name = ResourceMaintenanceName.FromProjectLocationResourceMaintenance("[PROJECT]", "[LOCATION]", "[RESOURCE_MAINTENANCE]");
            // Make the request
            ResourceMaintenance response = await maintenanceClient.GetResourceMaintenanceAsync(name);
            // End snippet
        }
    }
}
