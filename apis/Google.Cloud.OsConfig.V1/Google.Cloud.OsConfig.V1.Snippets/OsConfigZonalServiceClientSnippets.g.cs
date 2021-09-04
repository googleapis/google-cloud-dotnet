// Copyright 2021 Google LLC
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

namespace Google.Cloud.OsConfig.V1.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedOsConfigZonalServiceClientSnippets
    {
        /// <summary>Snippet for GetInventory</summary>
        public void GetInventoryRequestObject()
        {
            // Snippet: GetInventory(GetInventoryRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
            };
            // Make the request
            Inventory response = osConfigZonalServiceClient.GetInventory(request);
            // End snippet
        }

        /// <summary>Snippet for GetInventoryAsync</summary>
        public async Task GetInventoryRequestObjectAsync()
        {
            // Snippet: GetInventoryAsync(GetInventoryRequest, CallSettings)
            // Additional: GetInventoryAsync(GetInventoryRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInventoryRequest request = new GetInventoryRequest
            {
                InventoryName = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
            };
            // Make the request
            Inventory response = await osConfigZonalServiceClient.GetInventoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInventory</summary>
        public void GetInventory()
        {
            // Snippet: GetInventory(string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/inventory";
            // Make the request
            Inventory response = osConfigZonalServiceClient.GetInventory(name);
            // End snippet
        }

        /// <summary>Snippet for GetInventoryAsync</summary>
        public async Task GetInventoryAsync()
        {
            // Snippet: GetInventoryAsync(string, CallSettings)
            // Additional: GetInventoryAsync(string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/inventory";
            // Make the request
            Inventory response = await osConfigZonalServiceClient.GetInventoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInventory</summary>
        public void GetInventoryResourceNames()
        {
            // Snippet: GetInventory(InventoryName, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            InventoryName name = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Inventory response = osConfigZonalServiceClient.GetInventory(name);
            // End snippet
        }

        /// <summary>Snippet for GetInventoryAsync</summary>
        public async Task GetInventoryResourceNamesAsync()
        {
            // Snippet: GetInventoryAsync(InventoryName, CallSettings)
            // Additional: GetInventoryAsync(InventoryName, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InventoryName name = InventoryName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            Inventory response = await osConfigZonalServiceClient.GetInventoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListInventories</summary>
        public void ListInventoriesRequestObject()
        {
            // Snippet: ListInventories(ListInventoriesRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            ListInventoriesRequest request = new ListInventoriesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectZoneInstance("[PROJECT]", "[ZONE]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Inventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventoriesAsync</summary>
        public async Task ListInventoriesRequestObjectAsync()
        {
            // Snippet: ListInventoriesAsync(ListInventoriesRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInventoriesRequest request = new ListInventoriesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectZoneInstance("[PROJECT]", "[ZONE]", "[INSTANCE]"),
                View = InventoryView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Inventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventories</summary>
        public void ListInventories()
        {
            // Snippet: ListInventories(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/zones/[ZONE]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Inventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventoriesAsync</summary>
        public async Task ListInventoriesAsync()
        {
            // Snippet: ListInventoriesAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/zones/[ZONE]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Inventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventories</summary>
        public void ListInventoriesResourceNames()
        {
            // Snippet: ListInventories(InstanceName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectZoneInstance("[PROJECT]", "[ZONE]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Inventory item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInventoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInventoriesAsync</summary>
        public async Task ListInventoriesResourceNamesAsync()
        {
            // Snippet: ListInventoriesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectZoneInstance("[PROJECT]", "[ZONE]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListInventoriesResponse, Inventory> response = osConfigZonalServiceClient.ListInventoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Inventory item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInventoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Inventory item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Inventory> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Inventory item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReport</summary>
        public void GetVulnerabilityReportRequestObject()
        {
            // Snippet: GetVulnerabilityReport(GetVulnerabilityReportRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            VulnerabilityReport response = osConfigZonalServiceClient.GetVulnerabilityReport(request);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReportAsync</summary>
        public async Task GetVulnerabilityReportRequestObjectAsync()
        {
            // Snippet: GetVulnerabilityReportAsync(GetVulnerabilityReportRequest, CallSettings)
            // Additional: GetVulnerabilityReportAsync(GetVulnerabilityReportRequest, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVulnerabilityReportRequest request = new GetVulnerabilityReportRequest
            {
                VulnerabilityReportName = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
            };
            // Make the request
            VulnerabilityReport response = await osConfigZonalServiceClient.GetVulnerabilityReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReport</summary>
        public void GetVulnerabilityReport()
        {
            // Snippet: GetVulnerabilityReport(string, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/vulnerabilityReport";
            // Make the request
            VulnerabilityReport response = osConfigZonalServiceClient.GetVulnerabilityReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReportAsync</summary>
        public async Task GetVulnerabilityReportAsync()
        {
            // Snippet: GetVulnerabilityReportAsync(string, CallSettings)
            // Additional: GetVulnerabilityReportAsync(string, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/vulnerabilityReport";
            // Make the request
            VulnerabilityReport response = await osConfigZonalServiceClient.GetVulnerabilityReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReport</summary>
        public void GetVulnerabilityReportResourceNames()
        {
            // Snippet: GetVulnerabilityReport(VulnerabilityReportName, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            VulnerabilityReportName name = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            VulnerabilityReport response = osConfigZonalServiceClient.GetVulnerabilityReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetVulnerabilityReportAsync</summary>
        public async Task GetVulnerabilityReportResourceNamesAsync()
        {
            // Snippet: GetVulnerabilityReportAsync(VulnerabilityReportName, CallSettings)
            // Additional: GetVulnerabilityReportAsync(VulnerabilityReportName, CancellationToken)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            VulnerabilityReportName name = VulnerabilityReportName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            VulnerabilityReport response = await osConfigZonalServiceClient.GetVulnerabilityReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReports</summary>
        public void ListVulnerabilityReportsRequestObject()
        {
            // Snippet: ListVulnerabilityReports(ListVulnerabilityReportsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            ListVulnerabilityReportsRequest request = new ListVulnerabilityReportsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectZoneInstance("[PROJECT]", "[ZONE]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VulnerabilityReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVulnerabilityReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReportsAsync</summary>
        public async Task ListVulnerabilityReportsRequestObjectAsync()
        {
            // Snippet: ListVulnerabilityReportsAsync(ListVulnerabilityReportsRequest, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListVulnerabilityReportsRequest request = new ListVulnerabilityReportsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectZoneInstance("[PROJECT]", "[ZONE]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VulnerabilityReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVulnerabilityReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReports</summary>
        public void ListVulnerabilityReports()
        {
            // Snippet: ListVulnerabilityReports(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/zones/[ZONE]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VulnerabilityReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVulnerabilityReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReportsAsync</summary>
        public async Task ListVulnerabilityReportsAsync()
        {
            // Snippet: ListVulnerabilityReportsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/zones/[ZONE]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VulnerabilityReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVulnerabilityReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReports</summary>
        public void ListVulnerabilityReportsResourceNames()
        {
            // Snippet: ListVulnerabilityReports(InstanceName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = OsConfigZonalServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectZoneInstance("[PROJECT]", "[ZONE]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VulnerabilityReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVulnerabilityReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVulnerabilityReportsAsync</summary>
        public async Task ListVulnerabilityReportsResourceNamesAsync()
        {
            // Snippet: ListVulnerabilityReportsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            OsConfigZonalServiceClient osConfigZonalServiceClient = await OsConfigZonalServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectZoneInstance("[PROJECT]", "[ZONE]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListVulnerabilityReportsResponse, VulnerabilityReport> response = osConfigZonalServiceClient.ListVulnerabilityReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VulnerabilityReport item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVulnerabilityReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VulnerabilityReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VulnerabilityReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VulnerabilityReport item in singlePage)
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
