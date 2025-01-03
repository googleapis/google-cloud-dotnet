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
    using Google.Api;
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Monitoring.V3;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMetricServiceClientSnippets
    {
        /// <summary>Snippet for ListMonitoredResourceDescriptors</summary>
        public void ListMonitoredResourceDescriptorsRequestObject()
        {
            // Snippet: ListMonitoredResourceDescriptors(ListMonitoredResourceDescriptorsRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                Filter = "",
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResourceDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredResourceDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptorsAsync</summary>
        public async Task ListMonitoredResourceDescriptorsRequestObjectAsync()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(ListMonitoredResourceDescriptorsRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest
            {
                Filter = "",
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResourceDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMonitoredResourceDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptors</summary>
        public void ListMonitoredResourceDescriptors()
        {
            // Snippet: ListMonitoredResourceDescriptors(string, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResourceDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredResourceDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptorsAsync</summary>
        public async Task ListMonitoredResourceDescriptorsAsync()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(string, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResourceDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMonitoredResourceDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptors</summary>
        public void ListMonitoredResourceDescriptorsResourceNames1()
        {
            // Snippet: ListMonitoredResourceDescriptors(ProjectName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResourceDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredResourceDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptorsAsync</summary>
        public async Task ListMonitoredResourceDescriptorsResourceNames1Async()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResourceDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMonitoredResourceDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptors</summary>
        public void ListMonitoredResourceDescriptorsResourceNames2()
        {
            // Snippet: ListMonitoredResourceDescriptors(OrganizationName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResourceDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredResourceDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptorsAsync</summary>
        public async Task ListMonitoredResourceDescriptorsResourceNames2Async()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResourceDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMonitoredResourceDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptors</summary>
        public void ListMonitoredResourceDescriptorsResourceNames3()
        {
            // Snippet: ListMonitoredResourceDescriptors(FolderName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResourceDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredResourceDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptorsAsync</summary>
        public async Task ListMonitoredResourceDescriptorsResourceNames3Async()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(FolderName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResourceDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMonitoredResourceDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptors</summary>
        public void ListMonitoredResourceDescriptorsResourceNames4()
        {
            // Snippet: ListMonitoredResourceDescriptors(IResourceName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MonitoredResourceDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMonitoredResourceDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptorsAsync</summary>
        public async Task ListMonitoredResourceDescriptorsResourceNames4Async()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = metricServiceClient.ListMonitoredResourceDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MonitoredResourceDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMonitoredResourceDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MonitoredResourceDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MonitoredResourceDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MonitoredResourceDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredResourceDescriptor</summary>
        public void GetMonitoredResourceDescriptorRequestObject()
        {
            // Snippet: GetMonitoredResourceDescriptor(GetMonitoredResourceDescriptorRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            // Make the request
            MonitoredResourceDescriptor response = metricServiceClient.GetMonitoredResourceDescriptor(request);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredResourceDescriptorAsync</summary>
        public async Task GetMonitoredResourceDescriptorRequestObjectAsync()
        {
            // Snippet: GetMonitoredResourceDescriptorAsync(GetMonitoredResourceDescriptorRequest, CallSettings)
            // Additional: GetMonitoredResourceDescriptorAsync(GetMonitoredResourceDescriptorRequest, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMonitoredResourceDescriptorRequest request = new GetMonitoredResourceDescriptorRequest
            {
                MonitoredResourceDescriptorName = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]"),
            };
            // Make the request
            MonitoredResourceDescriptor response = await metricServiceClient.GetMonitoredResourceDescriptorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredResourceDescriptor</summary>
        public void GetMonitoredResourceDescriptor()
        {
            // Snippet: GetMonitoredResourceDescriptor(string, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/monitoredResourceDescriptors/[MONITORED_RESOURCE_DESCRIPTOR]";
            // Make the request
            MonitoredResourceDescriptor response = metricServiceClient.GetMonitoredResourceDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredResourceDescriptorAsync</summary>
        public async Task GetMonitoredResourceDescriptorAsync()
        {
            // Snippet: GetMonitoredResourceDescriptorAsync(string, CallSettings)
            // Additional: GetMonitoredResourceDescriptorAsync(string, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/monitoredResourceDescriptors/[MONITORED_RESOURCE_DESCRIPTOR]";
            // Make the request
            MonitoredResourceDescriptor response = await metricServiceClient.GetMonitoredResourceDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredResourceDescriptor</summary>
        public void GetMonitoredResourceDescriptorResourceNames1()
        {
            // Snippet: GetMonitoredResourceDescriptor(MonitoredResourceDescriptorName, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            MonitoredResourceDescriptorName name = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]");
            // Make the request
            MonitoredResourceDescriptor response = metricServiceClient.GetMonitoredResourceDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredResourceDescriptorAsync</summary>
        public async Task GetMonitoredResourceDescriptorResourceNames1Async()
        {
            // Snippet: GetMonitoredResourceDescriptorAsync(MonitoredResourceDescriptorName, CallSettings)
            // Additional: GetMonitoredResourceDescriptorAsync(MonitoredResourceDescriptorName, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            MonitoredResourceDescriptorName name = MonitoredResourceDescriptorName.FromProjectMonitoredResourceDescriptor("[PROJECT]", "[MONITORED_RESOURCE_DESCRIPTOR]");
            // Make the request
            MonitoredResourceDescriptor response = await metricServiceClient.GetMonitoredResourceDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredResourceDescriptor</summary>
        public void GetMonitoredResourceDescriptorResourceNames2()
        {
            // Snippet: GetMonitoredResourceDescriptor(IResourceName, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            MonitoredResourceDescriptor response = metricServiceClient.GetMonitoredResourceDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetMonitoredResourceDescriptorAsync</summary>
        public async Task GetMonitoredResourceDescriptorResourceNames2Async()
        {
            // Snippet: GetMonitoredResourceDescriptorAsync(IResourceName, CallSettings)
            // Additional: GetMonitoredResourceDescriptorAsync(IResourceName, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            MonitoredResourceDescriptor response = await metricServiceClient.GetMonitoredResourceDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptors</summary>
        public void ListMetricDescriptorsRequestObject()
        {
            // Snippet: ListMetricDescriptors(ListMetricDescriptorsRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                Filter = "",
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetricDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetricDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptorsAsync</summary>
        public async Task ListMetricDescriptorsRequestObjectAsync()
        {
            // Snippet: ListMetricDescriptorsAsync(ListMetricDescriptorsRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMetricDescriptorsRequest request = new ListMetricDescriptorsRequest
            {
                Filter = "",
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetricDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetricDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptors</summary>
        public void ListMetricDescriptors()
        {
            // Snippet: ListMetricDescriptors(string, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetricDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetricDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptorsAsync</summary>
        public async Task ListMetricDescriptorsAsync()
        {
            // Snippet: ListMetricDescriptorsAsync(string, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetricDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetricDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptors</summary>
        public void ListMetricDescriptorsResourceNames1()
        {
            // Snippet: ListMetricDescriptors(ProjectName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetricDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetricDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptorsAsync</summary>
        public async Task ListMetricDescriptorsResourceNames1Async()
        {
            // Snippet: ListMetricDescriptorsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetricDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetricDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptors</summary>
        public void ListMetricDescriptorsResourceNames2()
        {
            // Snippet: ListMetricDescriptors(OrganizationName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetricDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetricDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptorsAsync</summary>
        public async Task ListMetricDescriptorsResourceNames2Async()
        {
            // Snippet: ListMetricDescriptorsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetricDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetricDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptors</summary>
        public void ListMetricDescriptorsResourceNames3()
        {
            // Snippet: ListMetricDescriptors(FolderName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetricDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetricDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptorsAsync</summary>
        public async Task ListMetricDescriptorsResourceNames3Async()
        {
            // Snippet: ListMetricDescriptorsAsync(FolderName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetricDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetricDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptors</summary>
        public void ListMetricDescriptorsResourceNames4()
        {
            // Snippet: ListMetricDescriptors(IResourceName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptors(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MetricDescriptor item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMetricDescriptorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMetricDescriptorsAsync</summary>
        public async Task ListMetricDescriptorsResourceNames4Async()
        {
            // Snippet: ListMetricDescriptorsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> response = metricServiceClient.ListMetricDescriptorsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MetricDescriptor item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMetricDescriptorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MetricDescriptor item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MetricDescriptor> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MetricDescriptor item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMetricDescriptor</summary>
        public void GetMetricDescriptorRequestObject()
        {
            // Snippet: GetMetricDescriptor(GetMetricDescriptorRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            // Make the request
            MetricDescriptor response = metricServiceClient.GetMetricDescriptor(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetricDescriptorAsync</summary>
        public async Task GetMetricDescriptorRequestObjectAsync()
        {
            // Snippet: GetMetricDescriptorAsync(GetMetricDescriptorRequest, CallSettings)
            // Additional: GetMetricDescriptorAsync(GetMetricDescriptorRequest, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMetricDescriptorRequest request = new GetMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            // Make the request
            MetricDescriptor response = await metricServiceClient.GetMetricDescriptorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMetricDescriptor</summary>
        public void GetMetricDescriptor()
        {
            // Snippet: GetMetricDescriptor(string, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/metricDescriptors/[METRIC_DESCRIPTOR]";
            // Make the request
            MetricDescriptor response = metricServiceClient.GetMetricDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricDescriptorAsync</summary>
        public async Task GetMetricDescriptorAsync()
        {
            // Snippet: GetMetricDescriptorAsync(string, CallSettings)
            // Additional: GetMetricDescriptorAsync(string, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/metricDescriptors/[METRIC_DESCRIPTOR]";
            // Make the request
            MetricDescriptor response = await metricServiceClient.GetMetricDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricDescriptor</summary>
        public void GetMetricDescriptorResourceNames1()
        {
            // Snippet: GetMetricDescriptor(MetricDescriptorName, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            MetricDescriptorName name = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]");
            // Make the request
            MetricDescriptor response = metricServiceClient.GetMetricDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricDescriptorAsync</summary>
        public async Task GetMetricDescriptorResourceNames1Async()
        {
            // Snippet: GetMetricDescriptorAsync(MetricDescriptorName, CallSettings)
            // Additional: GetMetricDescriptorAsync(MetricDescriptorName, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetricDescriptorName name = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]");
            // Make the request
            MetricDescriptor response = await metricServiceClient.GetMetricDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricDescriptor</summary>
        public void GetMetricDescriptorResourceNames2()
        {
            // Snippet: GetMetricDescriptor(IResourceName, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            MetricDescriptor response = metricServiceClient.GetMetricDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for GetMetricDescriptorAsync</summary>
        public async Task GetMetricDescriptorResourceNames2Async()
        {
            // Snippet: GetMetricDescriptorAsync(IResourceName, CallSettings)
            // Additional: GetMetricDescriptorAsync(IResourceName, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            MetricDescriptor response = await metricServiceClient.GetMetricDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptor</summary>
        public void CreateMetricDescriptorRequestObject()
        {
            // Snippet: CreateMetricDescriptor(CreateMetricDescriptorRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new MetricDescriptor(),
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            MetricDescriptor response = metricServiceClient.CreateMetricDescriptor(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptorAsync</summary>
        public async Task CreateMetricDescriptorRequestObjectAsync()
        {
            // Snippet: CreateMetricDescriptorAsync(CreateMetricDescriptorRequest, CallSettings)
            // Additional: CreateMetricDescriptorAsync(CreateMetricDescriptorRequest, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMetricDescriptorRequest request = new CreateMetricDescriptorRequest
            {
                MetricDescriptor = new MetricDescriptor(),
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            MetricDescriptor response = await metricServiceClient.CreateMetricDescriptorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptor</summary>
        public void CreateMetricDescriptor()
        {
            // Snippet: CreateMetricDescriptor(string, MetricDescriptor, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = metricServiceClient.CreateMetricDescriptor(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptorAsync</summary>
        public async Task CreateMetricDescriptorAsync()
        {
            // Snippet: CreateMetricDescriptorAsync(string, MetricDescriptor, CallSettings)
            // Additional: CreateMetricDescriptorAsync(string, MetricDescriptor, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = await metricServiceClient.CreateMetricDescriptorAsync(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptor</summary>
        public void CreateMetricDescriptorResourceNames1()
        {
            // Snippet: CreateMetricDescriptor(ProjectName, MetricDescriptor, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = metricServiceClient.CreateMetricDescriptor(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptorAsync</summary>
        public async Task CreateMetricDescriptorResourceNames1Async()
        {
            // Snippet: CreateMetricDescriptorAsync(ProjectName, MetricDescriptor, CallSettings)
            // Additional: CreateMetricDescriptorAsync(ProjectName, MetricDescriptor, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = await metricServiceClient.CreateMetricDescriptorAsync(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptor</summary>
        public void CreateMetricDescriptorResourceNames2()
        {
            // Snippet: CreateMetricDescriptor(OrganizationName, MetricDescriptor, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = metricServiceClient.CreateMetricDescriptor(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptorAsync</summary>
        public async Task CreateMetricDescriptorResourceNames2Async()
        {
            // Snippet: CreateMetricDescriptorAsync(OrganizationName, MetricDescriptor, CallSettings)
            // Additional: CreateMetricDescriptorAsync(OrganizationName, MetricDescriptor, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = await metricServiceClient.CreateMetricDescriptorAsync(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptor</summary>
        public void CreateMetricDescriptorResourceNames3()
        {
            // Snippet: CreateMetricDescriptor(FolderName, MetricDescriptor, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = metricServiceClient.CreateMetricDescriptor(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptorAsync</summary>
        public async Task CreateMetricDescriptorResourceNames3Async()
        {
            // Snippet: CreateMetricDescriptorAsync(FolderName, MetricDescriptor, CallSettings)
            // Additional: CreateMetricDescriptorAsync(FolderName, MetricDescriptor, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = await metricServiceClient.CreateMetricDescriptorAsync(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptor</summary>
        public void CreateMetricDescriptorResourceNames4()
        {
            // Snippet: CreateMetricDescriptor(IResourceName, MetricDescriptor, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = metricServiceClient.CreateMetricDescriptor(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for CreateMetricDescriptorAsync</summary>
        public async Task CreateMetricDescriptorResourceNames4Async()
        {
            // Snippet: CreateMetricDescriptorAsync(IResourceName, MetricDescriptor, CallSettings)
            // Additional: CreateMetricDescriptorAsync(IResourceName, MetricDescriptor, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            MetricDescriptor metricDescriptor = new MetricDescriptor();
            // Make the request
            MetricDescriptor response = await metricServiceClient.CreateMetricDescriptorAsync(name, metricDescriptor);
            // End snippet
        }

        /// <summary>Snippet for DeleteMetricDescriptor</summary>
        public void DeleteMetricDescriptorRequestObject()
        {
            // Snippet: DeleteMetricDescriptor(DeleteMetricDescriptorRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            // Make the request
            metricServiceClient.DeleteMetricDescriptor(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMetricDescriptorAsync</summary>
        public async Task DeleteMetricDescriptorRequestObjectAsync()
        {
            // Snippet: DeleteMetricDescriptorAsync(DeleteMetricDescriptorRequest, CallSettings)
            // Additional: DeleteMetricDescriptorAsync(DeleteMetricDescriptorRequest, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMetricDescriptorRequest request = new DeleteMetricDescriptorRequest
            {
                MetricDescriptorName = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]"),
            };
            // Make the request
            await metricServiceClient.DeleteMetricDescriptorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMetricDescriptor</summary>
        public void DeleteMetricDescriptor()
        {
            // Snippet: DeleteMetricDescriptor(string, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/metricDescriptors/[METRIC_DESCRIPTOR]";
            // Make the request
            metricServiceClient.DeleteMetricDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMetricDescriptorAsync</summary>
        public async Task DeleteMetricDescriptorAsync()
        {
            // Snippet: DeleteMetricDescriptorAsync(string, CallSettings)
            // Additional: DeleteMetricDescriptorAsync(string, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/metricDescriptors/[METRIC_DESCRIPTOR]";
            // Make the request
            await metricServiceClient.DeleteMetricDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMetricDescriptor</summary>
        public void DeleteMetricDescriptorResourceNames1()
        {
            // Snippet: DeleteMetricDescriptor(MetricDescriptorName, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            MetricDescriptorName name = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]");
            // Make the request
            metricServiceClient.DeleteMetricDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMetricDescriptorAsync</summary>
        public async Task DeleteMetricDescriptorResourceNames1Async()
        {
            // Snippet: DeleteMetricDescriptorAsync(MetricDescriptorName, CallSettings)
            // Additional: DeleteMetricDescriptorAsync(MetricDescriptorName, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            MetricDescriptorName name = MetricDescriptorName.FromProjectMetricDescriptor("[PROJECT]", "[METRIC_DESCRIPTOR]");
            // Make the request
            await metricServiceClient.DeleteMetricDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMetricDescriptor</summary>
        public void DeleteMetricDescriptorResourceNames2()
        {
            // Snippet: DeleteMetricDescriptor(IResourceName, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            metricServiceClient.DeleteMetricDescriptor(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMetricDescriptorAsync</summary>
        public async Task DeleteMetricDescriptorResourceNames2Async()
        {
            // Snippet: DeleteMetricDescriptorAsync(IResourceName, CallSettings)
            // Additional: DeleteMetricDescriptorAsync(IResourceName, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            await metricServiceClient.DeleteMetricDescriptorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeries</summary>
        public void ListTimeSeriesRequestObject()
        {
            // Snippet: ListTimeSeries(ListTimeSeriesRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                Filter = "",
                Interval = new TimeInterval(),
                Aggregation = new Aggregation(),
                OrderBy = "",
                View = ListTimeSeriesRequest.Types.TimeSeriesView.Full,
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                SecondaryAggregation = new Aggregation(),
            };
            // Make the request
            PagedEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeriesAsync</summary>
        public async Task ListTimeSeriesRequestObjectAsync()
        {
            // Snippet: ListTimeSeriesAsync(ListTimeSeriesRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTimeSeriesRequest request = new ListTimeSeriesRequest
            {
                Filter = "",
                Interval = new TimeInterval(),
                Aggregation = new Aggregation(),
                OrderBy = "",
                View = ListTimeSeriesRequest.Types.TimeSeriesView.Full,
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                SecondaryAggregation = new Aggregation(),
            };
            // Make the request
            PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeries</summary>
        public void ListTimeSeries()
        {
            // Snippet: ListTimeSeries(string, string, TimeInterval, ListTimeSeriesRequest.Types.TimeSeriesView, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            string filter = "";
            TimeInterval interval = new TimeInterval();
            ListTimeSeriesRequest.Types.TimeSeriesView view = ListTimeSeriesRequest.Types.TimeSeriesView.Full;
            // Make the request
            PagedEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeries(name, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeriesAsync</summary>
        public async Task ListTimeSeriesAsync()
        {
            // Snippet: ListTimeSeriesAsync(string, string, TimeInterval, ListTimeSeriesRequest.Types.TimeSeriesView, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            string filter = "";
            TimeInterval interval = new TimeInterval();
            ListTimeSeriesRequest.Types.TimeSeriesView view = ListTimeSeriesRequest.Types.TimeSeriesView.Full;
            // Make the request
            PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeriesAsync(name, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeries</summary>
        public void ListTimeSeriesResourceNames1()
        {
            // Snippet: ListTimeSeries(ProjectName, string, TimeInterval, ListTimeSeriesRequest.Types.TimeSeriesView, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            TimeInterval interval = new TimeInterval();
            ListTimeSeriesRequest.Types.TimeSeriesView view = ListTimeSeriesRequest.Types.TimeSeriesView.Full;
            // Make the request
            PagedEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeries(name, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeriesAsync</summary>
        public async Task ListTimeSeriesResourceNames1Async()
        {
            // Snippet: ListTimeSeriesAsync(ProjectName, string, TimeInterval, ListTimeSeriesRequest.Types.TimeSeriesView, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            TimeInterval interval = new TimeInterval();
            ListTimeSeriesRequest.Types.TimeSeriesView view = ListTimeSeriesRequest.Types.TimeSeriesView.Full;
            // Make the request
            PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeriesAsync(name, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeries</summary>
        public void ListTimeSeriesResourceNames2()
        {
            // Snippet: ListTimeSeries(OrganizationName, string, TimeInterval, ListTimeSeriesRequest.Types.TimeSeriesView, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            string filter = "";
            TimeInterval interval = new TimeInterval();
            ListTimeSeriesRequest.Types.TimeSeriesView view = ListTimeSeriesRequest.Types.TimeSeriesView.Full;
            // Make the request
            PagedEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeries(name, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeriesAsync</summary>
        public async Task ListTimeSeriesResourceNames2Async()
        {
            // Snippet: ListTimeSeriesAsync(OrganizationName, string, TimeInterval, ListTimeSeriesRequest.Types.TimeSeriesView, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            string filter = "";
            TimeInterval interval = new TimeInterval();
            ListTimeSeriesRequest.Types.TimeSeriesView view = ListTimeSeriesRequest.Types.TimeSeriesView.Full;
            // Make the request
            PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeriesAsync(name, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeries</summary>
        public void ListTimeSeriesResourceNames3()
        {
            // Snippet: ListTimeSeries(FolderName, string, TimeInterval, ListTimeSeriesRequest.Types.TimeSeriesView, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            string filter = "";
            TimeInterval interval = new TimeInterval();
            ListTimeSeriesRequest.Types.TimeSeriesView view = ListTimeSeriesRequest.Types.TimeSeriesView.Full;
            // Make the request
            PagedEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeries(name, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TimeSeries item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTimeSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTimeSeriesAsync</summary>
        public async Task ListTimeSeriesResourceNames3Async()
        {
            // Snippet: ListTimeSeriesAsync(FolderName, string, TimeInterval, ListTimeSeriesRequest.Types.TimeSeriesView, string, int?, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            string filter = "";
            TimeInterval interval = new TimeInterval();
            ListTimeSeriesRequest.Types.TimeSeriesView view = ListTimeSeriesRequest.Types.TimeSeriesView.Full;
            // Make the request
            PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> response = metricServiceClient.ListTimeSeriesAsync(name, filter, interval, view);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TimeSeries item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTimeSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TimeSeries item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TimeSeries> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TimeSeries item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTimeSeries</summary>
        public void CreateTimeSeriesRequestObject()
        {
            // Snippet: CreateTimeSeries(CreateTimeSeriesRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            metricServiceClient.CreateTimeSeries(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTimeSeriesAsync</summary>
        public async Task CreateTimeSeriesRequestObjectAsync()
        {
            // Snippet: CreateTimeSeriesAsync(CreateTimeSeriesRequest, CallSettings)
            // Additional: CreateTimeSeriesAsync(CreateTimeSeriesRequest, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            await metricServiceClient.CreateTimeSeriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTimeSeries</summary>
        public void CreateTimeSeries()
        {
            // Snippet: CreateTimeSeries(string, IEnumerable<TimeSeries>, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            metricServiceClient.CreateTimeSeries(name, timeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateTimeSeriesAsync</summary>
        public async Task CreateTimeSeriesAsync()
        {
            // Snippet: CreateTimeSeriesAsync(string, IEnumerable<TimeSeries>, CallSettings)
            // Additional: CreateTimeSeriesAsync(string, IEnumerable<TimeSeries>, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            await metricServiceClient.CreateTimeSeriesAsync(name, timeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateTimeSeries</summary>
        public void CreateTimeSeriesResourceNames()
        {
            // Snippet: CreateTimeSeries(ProjectName, IEnumerable<TimeSeries>, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            metricServiceClient.CreateTimeSeries(name, timeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateTimeSeriesAsync</summary>
        public async Task CreateTimeSeriesResourceNamesAsync()
        {
            // Snippet: CreateTimeSeriesAsync(ProjectName, IEnumerable<TimeSeries>, CallSettings)
            // Additional: CreateTimeSeriesAsync(ProjectName, IEnumerable<TimeSeries>, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            await metricServiceClient.CreateTimeSeriesAsync(name, timeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceTimeSeries</summary>
        public void CreateServiceTimeSeriesRequestObject()
        {
            // Snippet: CreateServiceTimeSeries(CreateTimeSeriesRequest, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            metricServiceClient.CreateServiceTimeSeries(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceTimeSeriesAsync</summary>
        public async Task CreateServiceTimeSeriesRequestObjectAsync()
        {
            // Snippet: CreateServiceTimeSeriesAsync(CreateTimeSeriesRequest, CallSettings)
            // Additional: CreateServiceTimeSeriesAsync(CreateTimeSeriesRequest, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTimeSeriesRequest request = new CreateTimeSeriesRequest
            {
                TimeSeries = { new TimeSeries(), },
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            await metricServiceClient.CreateServiceTimeSeriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceTimeSeries</summary>
        public void CreateServiceTimeSeries()
        {
            // Snippet: CreateServiceTimeSeries(string, IEnumerable<TimeSeries>, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            metricServiceClient.CreateServiceTimeSeries(name, timeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceTimeSeriesAsync</summary>
        public async Task CreateServiceTimeSeriesAsync()
        {
            // Snippet: CreateServiceTimeSeriesAsync(string, IEnumerable<TimeSeries>, CallSettings)
            // Additional: CreateServiceTimeSeriesAsync(string, IEnumerable<TimeSeries>, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            await metricServiceClient.CreateServiceTimeSeriesAsync(name, timeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceTimeSeries</summary>
        public void CreateServiceTimeSeriesResourceNames()
        {
            // Snippet: CreateServiceTimeSeries(ProjectName, IEnumerable<TimeSeries>, CallSettings)
            // Create client
            MetricServiceClient metricServiceClient = MetricServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            metricServiceClient.CreateServiceTimeSeries(name, timeSeries);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceTimeSeriesAsync</summary>
        public async Task CreateServiceTimeSeriesResourceNamesAsync()
        {
            // Snippet: CreateServiceTimeSeriesAsync(ProjectName, IEnumerable<TimeSeries>, CallSettings)
            // Additional: CreateServiceTimeSeriesAsync(ProjectName, IEnumerable<TimeSeries>, CancellationToken)
            // Create client
            MetricServiceClient metricServiceClient = await MetricServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IEnumerable<TimeSeries> timeSeries = new TimeSeries[] { new TimeSeries(), };
            // Make the request
            await metricServiceClient.CreateServiceTimeSeriesAsync(name, timeSeries);
            // End snippet
        }
    }
}
