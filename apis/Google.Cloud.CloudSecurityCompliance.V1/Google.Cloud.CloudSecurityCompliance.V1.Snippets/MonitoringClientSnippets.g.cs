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
    using Google.Cloud.CloudSecurityCompliance.V1;
    using Google.Protobuf.WellKnownTypes;
    using Google.Type;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMonitoringClientSnippets
    {
        /// <summary>Snippet for ListFrameworkComplianceSummaries</summary>
        public void ListFrameworkComplianceSummariesRequestObject()
        {
            // Snippet: ListFrameworkComplianceSummaries(ListFrameworkComplianceSummariesRequest, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummaries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkComplianceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkComplianceSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummariesAsync</summary>
        public async Task ListFrameworkComplianceSummariesRequestObjectAsync()
        {
            // Snippet: ListFrameworkComplianceSummariesAsync(ListFrameworkComplianceSummariesRequest, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            ListFrameworkComplianceSummariesRequest request = new ListFrameworkComplianceSummariesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummariesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkComplianceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkComplianceSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummaries</summary>
        public void ListFrameworkComplianceSummaries()
        {
            // Snippet: ListFrameworkComplianceSummaries(string, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkComplianceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkComplianceSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummariesAsync</summary>
        public async Task ListFrameworkComplianceSummariesAsync()
        {
            // Snippet: ListFrameworkComplianceSummariesAsync(string, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkComplianceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkComplianceSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummaries</summary>
        public void ListFrameworkComplianceSummariesResourceNames1()
        {
            // Snippet: ListFrameworkComplianceSummaries(LocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkComplianceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkComplianceSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummariesAsync</summary>
        public async Task ListFrameworkComplianceSummariesResourceNames1Async()
        {
            // Snippet: ListFrameworkComplianceSummariesAsync(LocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkComplianceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkComplianceSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummaries</summary>
        public void ListFrameworkComplianceSummariesResourceNames2()
        {
            // Snippet: ListFrameworkComplianceSummaries(FolderLocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkComplianceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkComplianceSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummariesAsync</summary>
        public async Task ListFrameworkComplianceSummariesResourceNames2Async()
        {
            // Snippet: ListFrameworkComplianceSummariesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkComplianceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkComplianceSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummaries</summary>
        public void ListFrameworkComplianceSummariesResourceNames3()
        {
            // Snippet: ListFrameworkComplianceSummaries(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkComplianceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkComplianceSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkComplianceSummariesAsync</summary>
        public async Task ListFrameworkComplianceSummariesResourceNames3Async()
        {
            // Snippet: ListFrameworkComplianceSummariesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFrameworkComplianceSummariesResponse, FrameworkComplianceSummary> response = monitoringClient.ListFrameworkComplianceSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkComplianceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkComplianceSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkComplianceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummaries</summary>
        public void ListFindingSummariesRequestObject()
        {
            // Snippet: ListFindingSummaries(ListFindingSummariesRequest, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummaries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummariesAsync</summary>
        public async Task ListFindingSummariesRequestObjectAsync()
        {
            // Snippet: ListFindingSummariesAsync(ListFindingSummariesRequest, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            ListFindingSummariesRequest request = new ListFindingSummariesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummariesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FindingSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummaries</summary>
        public void ListFindingSummaries()
        {
            // Snippet: ListFindingSummaries(string, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummariesAsync</summary>
        public async Task ListFindingSummariesAsync()
        {
            // Snippet: ListFindingSummariesAsync(string, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FindingSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummaries</summary>
        public void ListFindingSummariesResourceNames1()
        {
            // Snippet: ListFindingSummaries(LocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummariesAsync</summary>
        public async Task ListFindingSummariesResourceNames1Async()
        {
            // Snippet: ListFindingSummariesAsync(LocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FindingSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummaries</summary>
        public void ListFindingSummariesResourceNames2()
        {
            // Snippet: ListFindingSummaries(FolderLocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummariesAsync</summary>
        public async Task ListFindingSummariesResourceNames2Async()
        {
            // Snippet: ListFindingSummariesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FindingSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummaries</summary>
        public void ListFindingSummariesResourceNames3()
        {
            // Snippet: ListFindingSummaries(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FindingSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFindingSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFindingSummariesAsync</summary>
        public async Task ListFindingSummariesResourceNames3Async()
        {
            // Snippet: ListFindingSummariesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFindingSummariesResponse, FindingSummary> response = monitoringClient.ListFindingSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FindingSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFindingSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FindingSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FindingSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FindingSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworkComplianceReport</summary>
        public void FetchFrameworkComplianceReportRequestObject()
        {
            // Snippet: FetchFrameworkComplianceReport(FetchFrameworkComplianceReportRequest, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            FetchFrameworkComplianceReportRequest request = new FetchFrameworkComplianceReportRequest
            {
                FrameworkComplianceReportName = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]"),
                EndTime = new Timestamp(),
            };
            // Make the request
            FrameworkComplianceReport response = monitoringClient.FetchFrameworkComplianceReport(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworkComplianceReportAsync</summary>
        public async Task FetchFrameworkComplianceReportRequestObjectAsync()
        {
            // Snippet: FetchFrameworkComplianceReportAsync(FetchFrameworkComplianceReportRequest, CallSettings)
            // Additional: FetchFrameworkComplianceReportAsync(FetchFrameworkComplianceReportRequest, CancellationToken)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            FetchFrameworkComplianceReportRequest request = new FetchFrameworkComplianceReportRequest
            {
                FrameworkComplianceReportName = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]"),
                EndTime = new Timestamp(),
            };
            // Make the request
            FrameworkComplianceReport response = await monitoringClient.FetchFrameworkComplianceReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworkComplianceReport</summary>
        public void FetchFrameworkComplianceReport()
        {
            // Snippet: FetchFrameworkComplianceReport(string, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/frameworkComplianceReports/[FRAMEWORK_COMPLIANCE_REPORT]";
            // Make the request
            FrameworkComplianceReport response = monitoringClient.FetchFrameworkComplianceReport(name);
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworkComplianceReportAsync</summary>
        public async Task FetchFrameworkComplianceReportAsync()
        {
            // Snippet: FetchFrameworkComplianceReportAsync(string, CallSettings)
            // Additional: FetchFrameworkComplianceReportAsync(string, CancellationToken)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/frameworkComplianceReports/[FRAMEWORK_COMPLIANCE_REPORT]";
            // Make the request
            FrameworkComplianceReport response = await monitoringClient.FetchFrameworkComplianceReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworkComplianceReport</summary>
        public void FetchFrameworkComplianceReportResourceNames()
        {
            // Snippet: FetchFrameworkComplianceReport(FrameworkComplianceReportName, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            FrameworkComplianceReportName name = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]");
            // Make the request
            FrameworkComplianceReport response = monitoringClient.FetchFrameworkComplianceReport(name);
            // End snippet
        }

        /// <summary>Snippet for FetchFrameworkComplianceReportAsync</summary>
        public async Task FetchFrameworkComplianceReportResourceNamesAsync()
        {
            // Snippet: FetchFrameworkComplianceReportAsync(FrameworkComplianceReportName, CallSettings)
            // Additional: FetchFrameworkComplianceReportAsync(FrameworkComplianceReportName, CancellationToken)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            FrameworkComplianceReportName name = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]");
            // Make the request
            FrameworkComplianceReport response = await monitoringClient.FetchFrameworkComplianceReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListControlComplianceSummaries</summary>
        public void ListControlComplianceSummariesRequestObject()
        {
            // Snippet: ListControlComplianceSummaries(ListControlComplianceSummariesRequest, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            ListControlComplianceSummariesRequest request = new ListControlComplianceSummariesRequest
            {
                ParentAsFrameworkComplianceReportName = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> response = monitoringClient.ListControlComplianceSummaries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ControlComplianceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlComplianceSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ControlComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ControlComplianceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ControlComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlComplianceSummariesAsync</summary>
        public async Task ListControlComplianceSummariesRequestObjectAsync()
        {
            // Snippet: ListControlComplianceSummariesAsync(ListControlComplianceSummariesRequest, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            ListControlComplianceSummariesRequest request = new ListControlComplianceSummariesRequest
            {
                ParentAsFrameworkComplianceReportName = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> response = monitoringClient.ListControlComplianceSummariesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ControlComplianceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListControlComplianceSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ControlComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ControlComplianceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ControlComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlComplianceSummaries</summary>
        public void ListControlComplianceSummaries()
        {
            // Snippet: ListControlComplianceSummaries(string, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/frameworkComplianceReports/[FRAMEWORK_COMPLIANCE_REPORT]";
            // Make the request
            PagedEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> response = monitoringClient.ListControlComplianceSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ControlComplianceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlComplianceSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ControlComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ControlComplianceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ControlComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlComplianceSummariesAsync</summary>
        public async Task ListControlComplianceSummariesAsync()
        {
            // Snippet: ListControlComplianceSummariesAsync(string, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/frameworkComplianceReports/[FRAMEWORK_COMPLIANCE_REPORT]";
            // Make the request
            PagedAsyncEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> response = monitoringClient.ListControlComplianceSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ControlComplianceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListControlComplianceSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ControlComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ControlComplianceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ControlComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlComplianceSummaries</summary>
        public void ListControlComplianceSummariesResourceNames()
        {
            // Snippet: ListControlComplianceSummaries(FrameworkComplianceReportName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            FrameworkComplianceReportName parent = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]");
            // Make the request
            PagedEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> response = monitoringClient.ListControlComplianceSummaries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ControlComplianceSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlComplianceSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ControlComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ControlComplianceSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ControlComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlComplianceSummariesAsync</summary>
        public async Task ListControlComplianceSummariesResourceNamesAsync()
        {
            // Snippet: ListControlComplianceSummariesAsync(FrameworkComplianceReportName, string, int?, CallSettings)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            FrameworkComplianceReportName parent = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]");
            // Make the request
            PagedAsyncEnumerable<ListControlComplianceSummariesResponse, ControlComplianceSummary> response = monitoringClient.ListControlComplianceSummariesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ControlComplianceSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListControlComplianceSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ControlComplianceSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ControlComplianceSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ControlComplianceSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregateFrameworkComplianceReport</summary>
        public void AggregateFrameworkComplianceReportRequestObject()
        {
            // Snippet: AggregateFrameworkComplianceReport(AggregateFrameworkComplianceReportRequest, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            AggregateFrameworkComplianceReportRequest request = new AggregateFrameworkComplianceReportRequest
            {
                FrameworkComplianceReportName = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]"),
                Interval = new Interval(),
                Filter = "",
            };
            // Make the request
            AggregateFrameworkComplianceReportResponse response = monitoringClient.AggregateFrameworkComplianceReport(request);
            // End snippet
        }

        /// <summary>Snippet for AggregateFrameworkComplianceReportAsync</summary>
        public async Task AggregateFrameworkComplianceReportRequestObjectAsync()
        {
            // Snippet: AggregateFrameworkComplianceReportAsync(AggregateFrameworkComplianceReportRequest, CallSettings)
            // Additional: AggregateFrameworkComplianceReportAsync(AggregateFrameworkComplianceReportRequest, CancellationToken)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            AggregateFrameworkComplianceReportRequest request = new AggregateFrameworkComplianceReportRequest
            {
                FrameworkComplianceReportName = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]"),
                Interval = new Interval(),
                Filter = "",
            };
            // Make the request
            AggregateFrameworkComplianceReportResponse response = await monitoringClient.AggregateFrameworkComplianceReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AggregateFrameworkComplianceReport</summary>
        public void AggregateFrameworkComplianceReport()
        {
            // Snippet: AggregateFrameworkComplianceReport(string, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/frameworkComplianceReports/[FRAMEWORK_COMPLIANCE_REPORT]";
            // Make the request
            AggregateFrameworkComplianceReportResponse response = monitoringClient.AggregateFrameworkComplianceReport(name);
            // End snippet
        }

        /// <summary>Snippet for AggregateFrameworkComplianceReportAsync</summary>
        public async Task AggregateFrameworkComplianceReportAsync()
        {
            // Snippet: AggregateFrameworkComplianceReportAsync(string, CallSettings)
            // Additional: AggregateFrameworkComplianceReportAsync(string, CancellationToken)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/frameworkComplianceReports/[FRAMEWORK_COMPLIANCE_REPORT]";
            // Make the request
            AggregateFrameworkComplianceReportResponse response = await monitoringClient.AggregateFrameworkComplianceReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AggregateFrameworkComplianceReport</summary>
        public void AggregateFrameworkComplianceReportResourceNames()
        {
            // Snippet: AggregateFrameworkComplianceReport(FrameworkComplianceReportName, CallSettings)
            // Create client
            MonitoringClient monitoringClient = MonitoringClient.Create();
            // Initialize request argument(s)
            FrameworkComplianceReportName name = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]");
            // Make the request
            AggregateFrameworkComplianceReportResponse response = monitoringClient.AggregateFrameworkComplianceReport(name);
            // End snippet
        }

        /// <summary>Snippet for AggregateFrameworkComplianceReportAsync</summary>
        public async Task AggregateFrameworkComplianceReportResourceNamesAsync()
        {
            // Snippet: AggregateFrameworkComplianceReportAsync(FrameworkComplianceReportName, CallSettings)
            // Additional: AggregateFrameworkComplianceReportAsync(FrameworkComplianceReportName, CancellationToken)
            // Create client
            MonitoringClient monitoringClient = await MonitoringClient.CreateAsync();
            // Initialize request argument(s)
            FrameworkComplianceReportName name = FrameworkComplianceReportName.FromProjectLocationFrameworkComplianceReport("[PROJECT]", "[LOCATION]", "[FRAMEWORK_COMPLIANCE_REPORT]");
            // Make the request
            AggregateFrameworkComplianceReportResponse response = await monitoringClient.AggregateFrameworkComplianceReportAsync(name);
            // End snippet
        }
    }
}
