// Copyright 2020 Google LLC
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

namespace Google.Cloud.Logging.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedConfigServiceV2ClientSnippets
    {
        /// <summary>Snippet for ListSinks</summary>
        public void ListSinksRequestObject()
        {
            // Snippet: ListSinks(ListSinksRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public async Task ListSinksRequestObjectAsync()
        {
            // Snippet: ListSinksAsync(ListSinksRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListSinksRequest request = new ListSinksRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public void ListSinks()
        {
            // Snippet: ListSinks(string, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public async Task ListSinksAsync()
        {
            // Snippet: ListSinksAsync(string, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public void ListSinksResourceNames1()
        {
            // Snippet: ListSinks(ProjectName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public async Task ListSinksResourceNames1Async()
        {
            // Snippet: ListSinksAsync(ProjectName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public void ListSinksResourceNames2()
        {
            // Snippet: ListSinks(OrganizationName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public async Task ListSinksResourceNames2Async()
        {
            // Snippet: ListSinksAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public void ListSinksResourceNames3()
        {
            // Snippet: ListSinks(FolderName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public async Task ListSinksResourceNames3Async()
        {
            // Snippet: ListSinksAsync(FolderName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public void ListSinksResourceNames4()
        {
            // Snippet: ListSinks(BillingAccountName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            PagedEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogSink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSinks</summary>
        public async Task ListSinksResourceNames4Async()
        {
            // Snippet: ListSinksAsync(BillingAccountName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListSinksResponse, LogSink> response = configServiceV2Client.ListSinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogSink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogSink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogSink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogSink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSink</summary>
        public void GetSinkRequestObject()
        {
            // Snippet: GetSink(GetSinkRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            // Make the request
            LogSink response = configServiceV2Client.GetSink(request);
            // End snippet
        }

        /// <summary>Snippet for GetSinkAsync</summary>
        public async Task GetSinkRequestObjectAsync()
        {
            // Snippet: GetSinkAsync(GetSinkRequest, CallSettings)
            // Additional: GetSinkAsync(GetSinkRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetSinkRequest request = new GetSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            // Make the request
            LogSink response = await configServiceV2Client.GetSinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSink</summary>
        public void GetSink()
        {
            // Snippet: GetSink(string, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string sinkName = "projects/[PROJECT]/sinks/[SINK]";
            // Make the request
            LogSink response = configServiceV2Client.GetSink(sinkName);
            // End snippet
        }

        /// <summary>Snippet for GetSinkAsync</summary>
        public async Task GetSinkAsync()
        {
            // Snippet: GetSinkAsync(string, CallSettings)
            // Additional: GetSinkAsync(string, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string sinkName = "projects/[PROJECT]/sinks/[SINK]";
            // Make the request
            LogSink response = await configServiceV2Client.GetSinkAsync(sinkName);
            // End snippet
        }

        /// <summary>Snippet for GetSink</summary>
        public void GetSinkResourceNames()
        {
            // Snippet: GetSink(SinkName, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            SinkName sinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]");
            // Make the request
            LogSink response = configServiceV2Client.GetSink(sinkName);
            // End snippet
        }

        /// <summary>Snippet for GetSinkAsync</summary>
        public async Task GetSinkResourceNamesAsync()
        {
            // Snippet: GetSinkAsync(SinkName, CallSettings)
            // Additional: GetSinkAsync(SinkName, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            SinkName sinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]");
            // Make the request
            LogSink response = await configServiceV2Client.GetSinkAsync(sinkName);
            // End snippet
        }

        /// <summary>Snippet for CreateSink</summary>
        public void CreateSinkRequestObject()
        {
            // Snippet: CreateSink(CreateSinkRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
            };
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSinkAsync</summary>
        public async Task CreateSinkRequestObjectAsync()
        {
            // Snippet: CreateSinkAsync(CreateSinkRequest, CallSettings)
            // Additional: CreateSinkAsync(CreateSinkRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            CreateSinkRequest request = new CreateSinkRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
            };
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSink</summary>
        public void CreateSink()
        {
            // Snippet: CreateSink(string, LogSink, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSinkAsync</summary>
        public async Task CreateSinkAsync()
        {
            // Snippet: CreateSinkAsync(string, LogSink, CallSettings)
            // Additional: CreateSinkAsync(string, LogSink, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSink</summary>
        public void CreateSinkResourceNames1()
        {
            // Snippet: CreateSink(ProjectName, LogSink, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSinkAsync</summary>
        public async Task CreateSinkResourceNames1Async()
        {
            // Snippet: CreateSinkAsync(ProjectName, LogSink, CallSettings)
            // Additional: CreateSinkAsync(ProjectName, LogSink, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSink</summary>
        public void CreateSinkResourceNames2()
        {
            // Snippet: CreateSink(OrganizationName, LogSink, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSinkAsync</summary>
        public async Task CreateSinkResourceNames2Async()
        {
            // Snippet: CreateSinkAsync(OrganizationName, LogSink, CallSettings)
            // Additional: CreateSinkAsync(OrganizationName, LogSink, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSink</summary>
        public void CreateSinkResourceNames3()
        {
            // Snippet: CreateSink(FolderName, LogSink, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSinkAsync</summary>
        public async Task CreateSinkResourceNames3Async()
        {
            // Snippet: CreateSinkAsync(FolderName, LogSink, CallSettings)
            // Additional: CreateSinkAsync(FolderName, LogSink, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSink</summary>
        public void CreateSinkResourceNames4()
        {
            // Snippet: CreateSink(BillingAccountName, LogSink, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.CreateSink(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for CreateSinkAsync</summary>
        public async Task CreateSinkResourceNames4Async()
        {
            // Snippet: CreateSinkAsync(BillingAccountName, LogSink, CallSettings)
            // Additional: CreateSinkAsync(BillingAccountName, LogSink, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.CreateSinkAsync(parent, sink);
            // End snippet
        }

        /// <summary>Snippet for UpdateSink</summary>
        public void UpdateSinkRequestObject()
        {
            // Snippet: UpdateSink(UpdateSinkRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSinkAsync</summary>
        public async Task UpdateSinkRequestObjectAsync()
        {
            // Snippet: UpdateSinkAsync(UpdateSinkRequest, CallSettings)
            // Additional: UpdateSinkAsync(UpdateSinkRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateSinkRequest request = new UpdateSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
                Sink = new LogSink(),
                UniqueWriterIdentity = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSink</summary>
        public void UpdateSink1()
        {
            // Snippet: UpdateSink(string, LogSink, FieldMask, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string sinkName = "projects/[PROJECT]/sinks/[SINK]";
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(sinkName, sink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSinkAsync</summary>
        public async Task UpdateSink1Async()
        {
            // Snippet: UpdateSinkAsync(string, LogSink, FieldMask, CallSettings)
            // Additional: UpdateSinkAsync(string, LogSink, FieldMask, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string sinkName = "projects/[PROJECT]/sinks/[SINK]";
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(sinkName, sink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSink</summary>
        public void UpdateSink1ResourceNames()
        {
            // Snippet: UpdateSink(SinkName, LogSink, FieldMask, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            SinkName sinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]");
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(sinkName, sink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSinkAsync</summary>
        public async Task UpdateSink1ResourceNamesAsync()
        {
            // Snippet: UpdateSinkAsync(SinkName, LogSink, FieldMask, CallSettings)
            // Additional: UpdateSinkAsync(SinkName, LogSink, FieldMask, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            SinkName sinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]");
            LogSink sink = new LogSink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(sinkName, sink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSink</summary>
        public void UpdateSink2()
        {
            // Snippet: UpdateSink(string, LogSink, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string sinkName = "projects/[PROJECT]/sinks/[SINK]";
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(sinkName, sink);
            // End snippet
        }

        /// <summary>Snippet for UpdateSinkAsync</summary>
        public async Task UpdateSink2Async()
        {
            // Snippet: UpdateSinkAsync(string, LogSink, CallSettings)
            // Additional: UpdateSinkAsync(string, LogSink, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string sinkName = "projects/[PROJECT]/sinks/[SINK]";
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(sinkName, sink);
            // End snippet
        }

        /// <summary>Snippet for UpdateSink</summary>
        public void UpdateSink2ResourceNames()
        {
            // Snippet: UpdateSink(SinkName, LogSink, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            SinkName sinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = configServiceV2Client.UpdateSink(sinkName, sink);
            // End snippet
        }

        /// <summary>Snippet for UpdateSinkAsync</summary>
        public async Task UpdateSink2ResourceNamesAsync()
        {
            // Snippet: UpdateSinkAsync(SinkName, LogSink, CallSettings)
            // Additional: UpdateSinkAsync(SinkName, LogSink, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            SinkName sinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]");
            LogSink sink = new LogSink();
            // Make the request
            LogSink response = await configServiceV2Client.UpdateSinkAsync(sinkName, sink);
            // End snippet
        }

        /// <summary>Snippet for DeleteSink</summary>
        public void DeleteSinkRequestObject()
        {
            // Snippet: DeleteSink(DeleteSinkRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            // Make the request
            configServiceV2Client.DeleteSink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSinkAsync</summary>
        public async Task DeleteSinkRequestObjectAsync()
        {
            // Snippet: DeleteSinkAsync(DeleteSinkRequest, CallSettings)
            // Additional: DeleteSinkAsync(DeleteSinkRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteSinkRequest request = new DeleteSinkRequest
            {
                SinkNameAsSinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]"),
            };
            // Make the request
            await configServiceV2Client.DeleteSinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSink</summary>
        public void DeleteSink()
        {
            // Snippet: DeleteSink(string, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string sinkName = "projects/[PROJECT]/sinks/[SINK]";
            // Make the request
            configServiceV2Client.DeleteSink(sinkName);
            // End snippet
        }

        /// <summary>Snippet for DeleteSinkAsync</summary>
        public async Task DeleteSinkAsync()
        {
            // Snippet: DeleteSinkAsync(string, CallSettings)
            // Additional: DeleteSinkAsync(string, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string sinkName = "projects/[PROJECT]/sinks/[SINK]";
            // Make the request
            await configServiceV2Client.DeleteSinkAsync(sinkName);
            // End snippet
        }

        /// <summary>Snippet for DeleteSink</summary>
        public void DeleteSinkResourceNames()
        {
            // Snippet: DeleteSink(SinkName, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            SinkName sinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]");
            // Make the request
            configServiceV2Client.DeleteSink(sinkName);
            // End snippet
        }

        /// <summary>Snippet for DeleteSinkAsync</summary>
        public async Task DeleteSinkResourceNamesAsync()
        {
            // Snippet: DeleteSinkAsync(SinkName, CallSettings)
            // Additional: DeleteSinkAsync(SinkName, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            SinkName sinkName = SinkName.FromProjectSink("[PROJECT]", "[SINK]");
            // Make the request
            await configServiceV2Client.DeleteSinkAsync(sinkName);
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public void ListExclusionsRequestObject()
        {
            // Snippet: ListExclusions(ListExclusionsRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogExclusion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExclusionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public async Task ListExclusionsRequestObjectAsync()
        {
            // Snippet: ListExclusionsAsync(ListExclusionsRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListExclusionsRequest request = new ListExclusionsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogExclusion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExclusionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public void ListExclusions()
        {
            // Snippet: ListExclusions(string, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogExclusion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExclusionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public async Task ListExclusionsAsync()
        {
            // Snippet: ListExclusionsAsync(string, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogExclusion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExclusionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public void ListExclusionsResourceNames1()
        {
            // Snippet: ListExclusions(ProjectName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogExclusion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExclusionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public async Task ListExclusionsResourceNames1Async()
        {
            // Snippet: ListExclusionsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogExclusion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExclusionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public void ListExclusionsResourceNames2()
        {
            // Snippet: ListExclusions(OrganizationName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogExclusion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExclusionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public async Task ListExclusionsResourceNames2Async()
        {
            // Snippet: ListExclusionsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogExclusion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExclusionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public void ListExclusionsResourceNames3()
        {
            // Snippet: ListExclusions(FolderName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogExclusion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExclusionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public async Task ListExclusionsResourceNames3Async()
        {
            // Snippet: ListExclusionsAsync(FolderName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogExclusion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExclusionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public void ListExclusionsResourceNames4()
        {
            // Snippet: ListExclusions(BillingAccountName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            PagedEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogExclusion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExclusionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExclusions</summary>
        public async Task ListExclusionsResourceNames4Async()
        {
            // Snippet: ListExclusionsAsync(BillingAccountName, string, int?, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> response = configServiceV2Client.ListExclusionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogExclusion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExclusionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogExclusion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogExclusion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogExclusion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExclusion</summary>
        public void GetExclusionRequestObject()
        {
            // Snippet: GetExclusion(GetExclusionRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            // Make the request
            LogExclusion response = configServiceV2Client.GetExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for GetExclusionAsync</summary>
        public async Task GetExclusionRequestObjectAsync()
        {
            // Snippet: GetExclusionAsync(GetExclusionRequest, CallSettings)
            // Additional: GetExclusionAsync(GetExclusionRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetExclusionRequest request = new GetExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            // Make the request
            LogExclusion response = await configServiceV2Client.GetExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExclusion</summary>
        public void GetExclusion()
        {
            // Snippet: GetExclusion(string, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/exclusions/[EXCLUSION]";
            // Make the request
            LogExclusion response = configServiceV2Client.GetExclusion(name);
            // End snippet
        }

        /// <summary>Snippet for GetExclusionAsync</summary>
        public async Task GetExclusionAsync()
        {
            // Snippet: GetExclusionAsync(string, CallSettings)
            // Additional: GetExclusionAsync(string, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/exclusions/[EXCLUSION]";
            // Make the request
            LogExclusion response = await configServiceV2Client.GetExclusionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExclusion</summary>
        public void GetExclusionResourceNames()
        {
            // Snippet: GetExclusion(ExclusionName, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ExclusionName name = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]");
            // Make the request
            LogExclusion response = configServiceV2Client.GetExclusion(name);
            // End snippet
        }

        /// <summary>Snippet for GetExclusionAsync</summary>
        public async Task GetExclusionResourceNamesAsync()
        {
            // Snippet: GetExclusionAsync(ExclusionName, CallSettings)
            // Additional: GetExclusionAsync(ExclusionName, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ExclusionName name = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]");
            // Make the request
            LogExclusion response = await configServiceV2Client.GetExclusionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusion</summary>
        public void CreateExclusionRequestObject()
        {
            // Snippet: CreateExclusion(CreateExclusionRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            // Make the request
            LogExclusion response = configServiceV2Client.CreateExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusionAsync</summary>
        public async Task CreateExclusionRequestObjectAsync()
        {
            // Snippet: CreateExclusionAsync(CreateExclusionRequest, CallSettings)
            // Additional: CreateExclusionAsync(CreateExclusionRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            CreateExclusionRequest request = new CreateExclusionRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Exclusion = new LogExclusion(),
            };
            // Make the request
            LogExclusion response = await configServiceV2Client.CreateExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusion</summary>
        public void CreateExclusion()
        {
            // Snippet: CreateExclusion(string, LogExclusion, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = configServiceV2Client.CreateExclusion(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusionAsync</summary>
        public async Task CreateExclusionAsync()
        {
            // Snippet: CreateExclusionAsync(string, LogExclusion, CallSettings)
            // Additional: CreateExclusionAsync(string, LogExclusion, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = await configServiceV2Client.CreateExclusionAsync(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusion</summary>
        public void CreateExclusionResourceNames1()
        {
            // Snippet: CreateExclusion(ProjectName, LogExclusion, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = configServiceV2Client.CreateExclusion(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusionAsync</summary>
        public async Task CreateExclusionResourceNames1Async()
        {
            // Snippet: CreateExclusionAsync(ProjectName, LogExclusion, CallSettings)
            // Additional: CreateExclusionAsync(ProjectName, LogExclusion, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = await configServiceV2Client.CreateExclusionAsync(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusion</summary>
        public void CreateExclusionResourceNames2()
        {
            // Snippet: CreateExclusion(OrganizationName, LogExclusion, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = configServiceV2Client.CreateExclusion(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusionAsync</summary>
        public async Task CreateExclusionResourceNames2Async()
        {
            // Snippet: CreateExclusionAsync(OrganizationName, LogExclusion, CallSettings)
            // Additional: CreateExclusionAsync(OrganizationName, LogExclusion, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = await configServiceV2Client.CreateExclusionAsync(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusion</summary>
        public void CreateExclusionResourceNames3()
        {
            // Snippet: CreateExclusion(FolderName, LogExclusion, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = configServiceV2Client.CreateExclusion(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusionAsync</summary>
        public async Task CreateExclusionResourceNames3Async()
        {
            // Snippet: CreateExclusionAsync(FolderName, LogExclusion, CallSettings)
            // Additional: CreateExclusionAsync(FolderName, LogExclusion, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = await configServiceV2Client.CreateExclusionAsync(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusion</summary>
        public void CreateExclusionResourceNames4()
        {
            // Snippet: CreateExclusion(BillingAccountName, LogExclusion, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = configServiceV2Client.CreateExclusion(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for CreateExclusionAsync</summary>
        public async Task CreateExclusionResourceNames4Async()
        {
            // Snippet: CreateExclusionAsync(BillingAccountName, LogExclusion, CallSettings)
            // Additional: CreateExclusionAsync(BillingAccountName, LogExclusion, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            LogExclusion exclusion = new LogExclusion();
            // Make the request
            LogExclusion response = await configServiceV2Client.CreateExclusionAsync(parent, exclusion);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusion</summary>
        public void UpdateExclusionRequestObject()
        {
            // Snippet: UpdateExclusion(UpdateExclusionRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LogExclusion response = configServiceV2Client.UpdateExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusionAsync</summary>
        public async Task UpdateExclusionRequestObjectAsync()
        {
            // Snippet: UpdateExclusionAsync(UpdateExclusionRequest, CallSettings)
            // Additional: UpdateExclusionAsync(UpdateExclusionRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateExclusionRequest request = new UpdateExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
                Exclusion = new LogExclusion(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            LogExclusion response = await configServiceV2Client.UpdateExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusion</summary>
        public void UpdateExclusion()
        {
            // Snippet: UpdateExclusion(string, LogExclusion, FieldMask, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/exclusions/[EXCLUSION]";
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogExclusion response = configServiceV2Client.UpdateExclusion(name, exclusion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusionAsync</summary>
        public async Task UpdateExclusionAsync()
        {
            // Snippet: UpdateExclusionAsync(string, LogExclusion, FieldMask, CallSettings)
            // Additional: UpdateExclusionAsync(string, LogExclusion, FieldMask, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/exclusions/[EXCLUSION]";
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogExclusion response = await configServiceV2Client.UpdateExclusionAsync(name, exclusion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusion</summary>
        public void UpdateExclusionResourceNames()
        {
            // Snippet: UpdateExclusion(ExclusionName, LogExclusion, FieldMask, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ExclusionName name = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]");
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogExclusion response = configServiceV2Client.UpdateExclusion(name, exclusion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExclusionAsync</summary>
        public async Task UpdateExclusionResourceNamesAsync()
        {
            // Snippet: UpdateExclusionAsync(ExclusionName, LogExclusion, FieldMask, CallSettings)
            // Additional: UpdateExclusionAsync(ExclusionName, LogExclusion, FieldMask, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ExclusionName name = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]");
            LogExclusion exclusion = new LogExclusion();
            FieldMask updateMask = new FieldMask();
            // Make the request
            LogExclusion response = await configServiceV2Client.UpdateExclusionAsync(name, exclusion, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusion</summary>
        public void DeleteExclusionRequestObject()
        {
            // Snippet: DeleteExclusion(DeleteExclusionRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            // Make the request
            configServiceV2Client.DeleteExclusion(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusionAsync</summary>
        public async Task DeleteExclusionRequestObjectAsync()
        {
            // Snippet: DeleteExclusionAsync(DeleteExclusionRequest, CallSettings)
            // Additional: DeleteExclusionAsync(DeleteExclusionRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteExclusionRequest request = new DeleteExclusionRequest
            {
                ExclusionName = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]"),
            };
            // Make the request
            await configServiceV2Client.DeleteExclusionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusion</summary>
        public void DeleteExclusion()
        {
            // Snippet: DeleteExclusion(string, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/exclusions/[EXCLUSION]";
            // Make the request
            configServiceV2Client.DeleteExclusion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusionAsync</summary>
        public async Task DeleteExclusionAsync()
        {
            // Snippet: DeleteExclusionAsync(string, CallSettings)
            // Additional: DeleteExclusionAsync(string, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/exclusions/[EXCLUSION]";
            // Make the request
            await configServiceV2Client.DeleteExclusionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusion</summary>
        public void DeleteExclusionResourceNames()
        {
            // Snippet: DeleteExclusion(ExclusionName, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            ExclusionName name = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]");
            // Make the request
            configServiceV2Client.DeleteExclusion(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExclusionAsync</summary>
        public async Task DeleteExclusionResourceNamesAsync()
        {
            // Snippet: DeleteExclusionAsync(ExclusionName, CallSettings)
            // Additional: DeleteExclusionAsync(ExclusionName, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ExclusionName name = ExclusionName.FromProjectExclusion("[PROJECT]", "[EXCLUSION]");
            // Make the request
            await configServiceV2Client.DeleteExclusionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCmekSettings</summary>
        public void GetCmekSettingsRequestObject()
        {
            // Snippet: GetCmekSettings(GetCmekSettingsRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            GetCmekSettingsRequest request = new GetCmekSettingsRequest { Name = "", };
            // Make the request
            CmekSettings response = configServiceV2Client.GetCmekSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetCmekSettingsAsync</summary>
        public async Task GetCmekSettingsRequestObjectAsync()
        {
            // Snippet: GetCmekSettingsAsync(GetCmekSettingsRequest, CallSettings)
            // Additional: GetCmekSettingsAsync(GetCmekSettingsRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            GetCmekSettingsRequest request = new GetCmekSettingsRequest { Name = "", };
            // Make the request
            CmekSettings response = await configServiceV2Client.GetCmekSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekSettings</summary>
        public void UpdateCmekSettingsRequestObject()
        {
            // Snippet: UpdateCmekSettings(UpdateCmekSettingsRequest, CallSettings)
            // Create client
            ConfigServiceV2Client configServiceV2Client = ConfigServiceV2Client.Create();
            // Initialize request argument(s)
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "",
                CmekSettings = new CmekSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CmekSettings response = configServiceV2Client.UpdateCmekSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCmekSettingsAsync</summary>
        public async Task UpdateCmekSettingsRequestObjectAsync()
        {
            // Snippet: UpdateCmekSettingsAsync(UpdateCmekSettingsRequest, CallSettings)
            // Additional: UpdateCmekSettingsAsync(UpdateCmekSettingsRequest, CancellationToken)
            // Create client
            ConfigServiceV2Client configServiceV2Client = await ConfigServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            UpdateCmekSettingsRequest request = new UpdateCmekSettingsRequest
            {
                Name = "",
                CmekSettings = new CmekSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CmekSettings response = await configServiceV2Client.UpdateCmekSettingsAsync(request);
            // End snippet
        }
    }
}
