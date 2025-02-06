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
    using Google.Cloud.Monitoring.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUptimeCheckServiceClientSnippets
    {
        /// <summary>Snippet for ListUptimeCheckConfigs</summary>
        public void ListUptimeCheckConfigsRequestObject()
        {
            // Snippet: ListUptimeCheckConfigs(ListUptimeCheckConfigsRequest, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigsAsync</summary>
        public async Task ListUptimeCheckConfigsRequestObjectAsync()
        {
            // Snippet: ListUptimeCheckConfigsAsync(ListUptimeCheckConfigsRequest, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUptimeCheckConfigsRequest request = new ListUptimeCheckConfigsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigs</summary>
        public void ListUptimeCheckConfigs()
        {
            // Snippet: ListUptimeCheckConfigs(string, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigsAsync</summary>
        public async Task ListUptimeCheckConfigsAsync()
        {
            // Snippet: ListUptimeCheckConfigsAsync(string, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigs</summary>
        public void ListUptimeCheckConfigsResourceNames1()
        {
            // Snippet: ListUptimeCheckConfigs(ProjectName, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigsAsync</summary>
        public async Task ListUptimeCheckConfigsResourceNames1Async()
        {
            // Snippet: ListUptimeCheckConfigsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigs</summary>
        public void ListUptimeCheckConfigsResourceNames2()
        {
            // Snippet: ListUptimeCheckConfigs(OrganizationName, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigsAsync</summary>
        public async Task ListUptimeCheckConfigsResourceNames2Async()
        {
            // Snippet: ListUptimeCheckConfigsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigs</summary>
        public void ListUptimeCheckConfigsResourceNames3()
        {
            // Snippet: ListUptimeCheckConfigs(FolderName, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigsAsync</summary>
        public async Task ListUptimeCheckConfigsResourceNames3Async()
        {
            // Snippet: ListUptimeCheckConfigsAsync(FolderName, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigs</summary>
        public void ListUptimeCheckConfigsResourceNames4()
        {
            // Snippet: ListUptimeCheckConfigs(IResourceName, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckConfigsAsync</summary>
        public async Task ListUptimeCheckConfigsResourceNames4Async()
        {
            // Snippet: ListUptimeCheckConfigsAsync(IResourceName, string, int?, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> response = uptimeCheckServiceClient.ListUptimeCheckConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfig</summary>
        public void GetUptimeCheckConfigRequestObject()
        {
            // Snippet: GetUptimeCheckConfig(GetUptimeCheckConfigRequest, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.GetUptimeCheckConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfigAsync</summary>
        public async Task GetUptimeCheckConfigRequestObjectAsync()
        {
            // Snippet: GetUptimeCheckConfigAsync(GetUptimeCheckConfigRequest, CallSettings)
            // Additional: GetUptimeCheckConfigAsync(GetUptimeCheckConfigRequest, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUptimeCheckConfigRequest request = new GetUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.GetUptimeCheckConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfig</summary>
        public void GetUptimeCheckConfig()
        {
            // Snippet: GetUptimeCheckConfig(string, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/uptimeCheckConfigs/[UPTIME_CHECK_CONFIG]";
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.GetUptimeCheckConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfigAsync</summary>
        public async Task GetUptimeCheckConfigAsync()
        {
            // Snippet: GetUptimeCheckConfigAsync(string, CallSettings)
            // Additional: GetUptimeCheckConfigAsync(string, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/uptimeCheckConfigs/[UPTIME_CHECK_CONFIG]";
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.GetUptimeCheckConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfig</summary>
        public void GetUptimeCheckConfigResourceNames1()
        {
            // Snippet: GetUptimeCheckConfig(UptimeCheckConfigName, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            UptimeCheckConfigName name = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.GetUptimeCheckConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfigAsync</summary>
        public async Task GetUptimeCheckConfigResourceNames1Async()
        {
            // Snippet: GetUptimeCheckConfigAsync(UptimeCheckConfigName, CallSettings)
            // Additional: GetUptimeCheckConfigAsync(UptimeCheckConfigName, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            UptimeCheckConfigName name = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.GetUptimeCheckConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfig</summary>
        public void GetUptimeCheckConfigResourceNames2()
        {
            // Snippet: GetUptimeCheckConfig(IResourceName, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.GetUptimeCheckConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetUptimeCheckConfigAsync</summary>
        public async Task GetUptimeCheckConfigResourceNames2Async()
        {
            // Snippet: GetUptimeCheckConfigAsync(IResourceName, CallSettings)
            // Additional: GetUptimeCheckConfigAsync(IResourceName, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.GetUptimeCheckConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfig</summary>
        public void CreateUptimeCheckConfigRequestObject()
        {
            // Snippet: CreateUptimeCheckConfig(CreateUptimeCheckConfigRequest, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.CreateUptimeCheckConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigRequestObjectAsync()
        {
            // Snippet: CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest, CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(CreateUptimeCheckConfigRequest, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUptimeCheckConfigRequest request = new CreateUptimeCheckConfigRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfig</summary>
        public void CreateUptimeCheckConfig()
        {
            // Snippet: CreateUptimeCheckConfig(string, UptimeCheckConfig, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.CreateUptimeCheckConfig(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigAsync()
        {
            // Snippet: CreateUptimeCheckConfigAsync(string, UptimeCheckConfig, CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(string, UptimeCheckConfig, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfig</summary>
        public void CreateUptimeCheckConfigResourceNames1()
        {
            // Snippet: CreateUptimeCheckConfig(ProjectName, UptimeCheckConfig, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.CreateUptimeCheckConfig(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigResourceNames1Async()
        {
            // Snippet: CreateUptimeCheckConfigAsync(ProjectName, UptimeCheckConfig, CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(ProjectName, UptimeCheckConfig, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfig</summary>
        public void CreateUptimeCheckConfigResourceNames2()
        {
            // Snippet: CreateUptimeCheckConfig(OrganizationName, UptimeCheckConfig, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.CreateUptimeCheckConfig(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigResourceNames2Async()
        {
            // Snippet: CreateUptimeCheckConfigAsync(OrganizationName, UptimeCheckConfig, CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(OrganizationName, UptimeCheckConfig, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfig</summary>
        public void CreateUptimeCheckConfigResourceNames3()
        {
            // Snippet: CreateUptimeCheckConfig(FolderName, UptimeCheckConfig, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.CreateUptimeCheckConfig(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigResourceNames3Async()
        {
            // Snippet: CreateUptimeCheckConfigAsync(FolderName, UptimeCheckConfig, CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(FolderName, UptimeCheckConfig, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfig</summary>
        public void CreateUptimeCheckConfigResourceNames4()
        {
            // Snippet: CreateUptimeCheckConfig(IResourceName, UptimeCheckConfig, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.CreateUptimeCheckConfig(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateUptimeCheckConfigAsync</summary>
        public async Task CreateUptimeCheckConfigResourceNames4Async()
        {
            // Snippet: CreateUptimeCheckConfigAsync(IResourceName, UptimeCheckConfig, CallSettings)
            // Additional: CreateUptimeCheckConfigAsync(IResourceName, UptimeCheckConfig, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.CreateUptimeCheckConfigAsync(parent, uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateUptimeCheckConfig</summary>
        public void UpdateUptimeCheckConfigRequestObject()
        {
            // Snippet: UpdateUptimeCheckConfig(UpdateUptimeCheckConfigRequest, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UpdateMask = new FieldMask(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.UpdateUptimeCheckConfig(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUptimeCheckConfigAsync</summary>
        public async Task UpdateUptimeCheckConfigRequestObjectAsync()
        {
            // Snippet: UpdateUptimeCheckConfigAsync(UpdateUptimeCheckConfigRequest, CallSettings)
            // Additional: UpdateUptimeCheckConfigAsync(UpdateUptimeCheckConfigRequest, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUptimeCheckConfigRequest request = new UpdateUptimeCheckConfigRequest
            {
                UpdateMask = new FieldMask(),
                UptimeCheckConfig = new UptimeCheckConfig(),
            };
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.UpdateUptimeCheckConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUptimeCheckConfig</summary>
        public void UpdateUptimeCheckConfig()
        {
            // Snippet: UpdateUptimeCheckConfig(UptimeCheckConfig, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = uptimeCheckServiceClient.UpdateUptimeCheckConfig(uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for UpdateUptimeCheckConfigAsync</summary>
        public async Task UpdateUptimeCheckConfigAsync()
        {
            // Snippet: UpdateUptimeCheckConfigAsync(UptimeCheckConfig, CallSettings)
            // Additional: UpdateUptimeCheckConfigAsync(UptimeCheckConfig, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            UptimeCheckConfig uptimeCheckConfig = new UptimeCheckConfig();
            // Make the request
            UptimeCheckConfig response = await uptimeCheckServiceClient.UpdateUptimeCheckConfigAsync(uptimeCheckConfig);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfig</summary>
        public void DeleteUptimeCheckConfigRequestObject()
        {
            // Snippet: DeleteUptimeCheckConfig(DeleteUptimeCheckConfigRequest, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            // Make the request
            uptimeCheckServiceClient.DeleteUptimeCheckConfig(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfigAsync</summary>
        public async Task DeleteUptimeCheckConfigRequestObjectAsync()
        {
            // Snippet: DeleteUptimeCheckConfigAsync(DeleteUptimeCheckConfigRequest, CallSettings)
            // Additional: DeleteUptimeCheckConfigAsync(DeleteUptimeCheckConfigRequest, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUptimeCheckConfigRequest request = new DeleteUptimeCheckConfigRequest
            {
                UptimeCheckConfigName = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]"),
            };
            // Make the request
            await uptimeCheckServiceClient.DeleteUptimeCheckConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfig</summary>
        public void DeleteUptimeCheckConfig()
        {
            // Snippet: DeleteUptimeCheckConfig(string, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/uptimeCheckConfigs/[UPTIME_CHECK_CONFIG]";
            // Make the request
            uptimeCheckServiceClient.DeleteUptimeCheckConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfigAsync</summary>
        public async Task DeleteUptimeCheckConfigAsync()
        {
            // Snippet: DeleteUptimeCheckConfigAsync(string, CallSettings)
            // Additional: DeleteUptimeCheckConfigAsync(string, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/uptimeCheckConfigs/[UPTIME_CHECK_CONFIG]";
            // Make the request
            await uptimeCheckServiceClient.DeleteUptimeCheckConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfig</summary>
        public void DeleteUptimeCheckConfigResourceNames1()
        {
            // Snippet: DeleteUptimeCheckConfig(UptimeCheckConfigName, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            UptimeCheckConfigName name = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            // Make the request
            uptimeCheckServiceClient.DeleteUptimeCheckConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfigAsync</summary>
        public async Task DeleteUptimeCheckConfigResourceNames1Async()
        {
            // Snippet: DeleteUptimeCheckConfigAsync(UptimeCheckConfigName, CallSettings)
            // Additional: DeleteUptimeCheckConfigAsync(UptimeCheckConfigName, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            UptimeCheckConfigName name = UptimeCheckConfigName.FromProjectUptimeCheckConfig("[PROJECT]", "[UPTIME_CHECK_CONFIG]");
            // Make the request
            await uptimeCheckServiceClient.DeleteUptimeCheckConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfig</summary>
        public void DeleteUptimeCheckConfigResourceNames2()
        {
            // Snippet: DeleteUptimeCheckConfig(IResourceName, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            uptimeCheckServiceClient.DeleteUptimeCheckConfig(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUptimeCheckConfigAsync</summary>
        public async Task DeleteUptimeCheckConfigResourceNames2Async()
        {
            // Snippet: DeleteUptimeCheckConfigAsync(IResourceName, CallSettings)
            // Additional: DeleteUptimeCheckConfigAsync(IResourceName, CancellationToken)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            await uptimeCheckServiceClient.DeleteUptimeCheckConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckIps</summary>
        public void ListUptimeCheckIpsRequestObject()
        {
            // Snippet: ListUptimeCheckIps(ListUptimeCheckIpsRequest, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = UptimeCheckServiceClient.Create();
            // Initialize request argument(s)
            ListUptimeCheckIpsRequest request = new ListUptimeCheckIpsRequest { };
            // Make the request
            PagedEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> response = uptimeCheckServiceClient.ListUptimeCheckIps(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UptimeCheckIp item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUptimeCheckIpsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckIp item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckIp> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckIp item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUptimeCheckIpsAsync</summary>
        public async Task ListUptimeCheckIpsRequestObjectAsync()
        {
            // Snippet: ListUptimeCheckIpsAsync(ListUptimeCheckIpsRequest, CallSettings)
            // Create client
            UptimeCheckServiceClient uptimeCheckServiceClient = await UptimeCheckServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUptimeCheckIpsRequest request = new ListUptimeCheckIpsRequest { };
            // Make the request
            PagedAsyncEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> response = uptimeCheckServiceClient.ListUptimeCheckIpsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UptimeCheckIp item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUptimeCheckIpsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UptimeCheckIp item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UptimeCheckIp> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UptimeCheckIp item in singlePage)
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
