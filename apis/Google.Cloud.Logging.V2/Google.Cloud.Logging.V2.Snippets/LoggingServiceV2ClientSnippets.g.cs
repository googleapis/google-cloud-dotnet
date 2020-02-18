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
    using Google.Api;
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedLoggingServiceV2ClientSnippets
    {
        /// <summary>Snippet for DeleteLog</summary>
        public void DeleteLogRequestObject()
        {
            // Snippet: DeleteLog(DeleteLogRequest, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            loggingServiceV2Client.DeleteLog(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogAsync</summary>
        public async Task DeleteLogRequestObjectAsync()
        {
            // Snippet: DeleteLogAsync(DeleteLogRequest, CallSettings)
            // Additional: DeleteLogAsync(DeleteLogRequest, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteLog</summary>
        public void DeleteLog()
        {
            // Snippet: DeleteLog(string, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            string logName = "projects/[PROJECT]";
            // Make the request
            loggingServiceV2Client.DeleteLog(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogAsync</summary>
        public async Task DeleteLogAsync()
        {
            // Snippet: DeleteLogAsync(string, CallSettings)
            // Additional: DeleteLogAsync(string, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string logName = "projects/[PROJECT]";
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLog</summary>
        public void DeleteLogResourceNames1()
        {
            // Snippet: DeleteLog(ProjectName, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName logName = ProjectName.FromProject("[PROJECT]");
            // Make the request
            loggingServiceV2Client.DeleteLog(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogAsync</summary>
        public async Task DeleteLogResourceNames1Async()
        {
            // Snippet: DeleteLogAsync(ProjectName, CallSettings)
            // Additional: DeleteLogAsync(ProjectName, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName logName = ProjectName.FromProject("[PROJECT]");
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLog</summary>
        public void DeleteLogResourceNames2()
        {
            // Snippet: DeleteLog(OrganizationName, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            OrganizationName logName = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            loggingServiceV2Client.DeleteLog(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogAsync</summary>
        public async Task DeleteLogResourceNames2Async()
        {
            // Snippet: DeleteLogAsync(OrganizationName, CallSettings)
            // Additional: DeleteLogAsync(OrganizationName, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            OrganizationName logName = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLog</summary>
        public void DeleteLogResourceNames3()
        {
            // Snippet: DeleteLog(FolderName, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            FolderName logName = FolderName.FromFolder("[FOLDER]");
            // Make the request
            loggingServiceV2Client.DeleteLog(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogAsync</summary>
        public async Task DeleteLogResourceNames3Async()
        {
            // Snippet: DeleteLogAsync(FolderName, CallSettings)
            // Additional: DeleteLogAsync(FolderName, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            FolderName logName = FolderName.FromFolder("[FOLDER]");
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLog</summary>
        public void DeleteLogResourceNames4()
        {
            // Snippet: DeleteLog(BillingAccountName, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            BillingAccountName logName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            loggingServiceV2Client.DeleteLog(logName);
            // End snippet
        }

        /// <summary>Snippet for DeleteLogAsync</summary>
        public async Task DeleteLogResourceNames4Async()
        {
            // Snippet: DeleteLogAsync(BillingAccountName, CallSettings)
            // Additional: DeleteLogAsync(BillingAccountName, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName logName = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(logName);
            // End snippet
        }

        /// <summary>Snippet for WriteLogEntries</summary>
        public void WriteLogEntriesRequestObject()
        {
            // Snippet: WriteLogEntries(WriteLogEntriesRequest, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
                Resource = new MonitoredResource(),
                Labels = { { "", "" }, },
                Entries = { new LogEntry(), },
                PartialSuccess = false,
                DryRun = false,
            };
            // Make the request
            WriteLogEntriesResponse response = loggingServiceV2Client.WriteLogEntries(request);
            // End snippet
        }

        /// <summary>Snippet for WriteLogEntriesAsync</summary>
        public async Task WriteLogEntriesRequestObjectAsync()
        {
            // Snippet: WriteLogEntriesAsync(WriteLogEntriesRequest, CallSettings)
            // Additional: WriteLogEntriesAsync(WriteLogEntriesRequest, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogNameAsLogName = LogName.FromProjectLog("[PROJECT]", "[LOG]"),
                Resource = new MonitoredResource(),
                Labels = { { "", "" }, },
                Entries = { new LogEntry(), },
                PartialSuccess = false,
                DryRun = false,
            };
            // Make the request
            WriteLogEntriesResponse response = await loggingServiceV2Client.WriteLogEntriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for WriteLogEntries</summary>
        public void WriteLogEntries()
        {
            // Snippet: WriteLogEntries(string, MonitoredResource, IDictionary<string,string>, IEnumerable<LogEntry>, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            string logName = "projects/[PROJECT]/logs/[LOG]";
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            IEnumerable<LogEntry> entries = new LogEntry[] { new LogEntry(), };
            // Make the request
            WriteLogEntriesResponse response = loggingServiceV2Client.WriteLogEntries(logName, resource, labels, entries);
            // End snippet
        }

        /// <summary>Snippet for WriteLogEntriesAsync</summary>
        public async Task WriteLogEntriesAsync()
        {
            // Snippet: WriteLogEntriesAsync(string, MonitoredResource, IDictionary<string,string>, IEnumerable<LogEntry>, CallSettings)
            // Additional: WriteLogEntriesAsync(string, MonitoredResource, IDictionary<string,string>, IEnumerable<LogEntry>, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string logName = "projects/[PROJECT]/logs/[LOG]";
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            IEnumerable<LogEntry> entries = new LogEntry[] { new LogEntry(), };
            // Make the request
            WriteLogEntriesResponse response = await loggingServiceV2Client.WriteLogEntriesAsync(logName, resource, labels, entries);
            // End snippet
        }

        /// <summary>Snippet for WriteLogEntries</summary>
        public void WriteLogEntriesResourceNames()
        {
            // Snippet: WriteLogEntries(LogName, MonitoredResource, IDictionary<string,string>, IEnumerable<LogEntry>, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            LogName logName = LogName.FromProjectLog("[PROJECT]", "[LOG]");
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            IEnumerable<LogEntry> entries = new LogEntry[] { new LogEntry(), };
            // Make the request
            WriteLogEntriesResponse response = loggingServiceV2Client.WriteLogEntries(logName, resource, labels, entries);
            // End snippet
        }

        /// <summary>Snippet for WriteLogEntriesAsync</summary>
        public async Task WriteLogEntriesResourceNamesAsync()
        {
            // Snippet: WriteLogEntriesAsync(LogName, MonitoredResource, IDictionary<string,string>, IEnumerable<LogEntry>, CallSettings)
            // Additional: WriteLogEntriesAsync(LogName, MonitoredResource, IDictionary<string,string>, IEnumerable<LogEntry>, CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            LogName logName = LogName.FromProjectLog("[PROJECT]", "[LOG]");
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            IEnumerable<LogEntry> entries = new LogEntry[] { new LogEntry(), };
            // Make the request
            WriteLogEntriesResponse response = await loggingServiceV2Client.WriteLogEntriesAsync(logName, resource, labels, entries);
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public void ListLogEntriesRequestObject()
        {
            // Snippet: ListLogEntries(ListLogEntriesRequest, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                Filter = "",
                OrderBy = "",
                ResourceNamesAsProjectNames =
                {
                    ProjectName.FromProject("[PROJECT]"),
                },
            };
            // Make the request
            PagedEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public async Task ListLogEntriesRequestObjectAsync()
        {
            // Snippet: ListLogEntriesAsync(ListLogEntriesRequest, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                Filter = "",
                OrderBy = "",
                ResourceNamesAsProjectNames =
                {
                    ProjectName.FromProject("[PROJECT]"),
                },
            };
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public void ListLogEntries()
        {
            // Snippet: ListLogEntries(IEnumerable<string>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            IEnumerable<string> resourceNames = new string[]
            {
                "projects/[PROJECT]",
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntries(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public async Task ListLogEntriesAsync()
        {
            // Snippet: ListLogEntriesAsync(IEnumerable<string>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<string> resourceNames = new string[]
            {
                "projects/[PROJECT]",
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntriesAsync(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public void ListLogEntriesResourceNames1()
        {
            // Snippet: ListLogEntries(IEnumerable<ProjectName>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            IEnumerable<ProjectName> resourceNames = new ProjectName[]
            {
                ProjectName.FromProject("[PROJECT]"),
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntries(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public async Task ListLogEntriesResourceNames1Async()
        {
            // Snippet: ListLogEntriesAsync(IEnumerable<ProjectName>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<ProjectName> resourceNames = new ProjectName[]
            {
                ProjectName.FromProject("[PROJECT]"),
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntriesAsync(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public void ListLogEntriesResourceNames2()
        {
            // Snippet: ListLogEntries(IEnumerable<OrganizationName>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            IEnumerable<OrganizationName> resourceNames = new OrganizationName[]
            {
                OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntries(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public async Task ListLogEntriesResourceNames2Async()
        {
            // Snippet: ListLogEntriesAsync(IEnumerable<OrganizationName>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<OrganizationName> resourceNames = new OrganizationName[]
            {
                OrganizationName.FromOrganization("[ORGANIZATION]"),
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntriesAsync(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public void ListLogEntriesResourceNames3()
        {
            // Snippet: ListLogEntries(IEnumerable<FolderName>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            IEnumerable<FolderName> resourceNames = new FolderName[]
            {
                FolderName.FromFolder("[FOLDER]"),
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntries(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public async Task ListLogEntriesResourceNames3Async()
        {
            // Snippet: ListLogEntriesAsync(IEnumerable<FolderName>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<FolderName> resourceNames = new FolderName[]
            {
                FolderName.FromFolder("[FOLDER]"),
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntriesAsync(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public void ListLogEntriesResourceNames4()
        {
            // Snippet: ListLogEntries(IEnumerable<BillingAccountName>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            IEnumerable<BillingAccountName> resourceNames = new BillingAccountName[]
            {
                BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntries(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LogEntry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogEntries</summary>
        public async Task ListLogEntriesResourceNames4Async()
        {
            // Snippet: ListLogEntriesAsync(IEnumerable<BillingAccountName>, string, string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<BillingAccountName> resourceNames = new BillingAccountName[]
            {
                BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]"),
            };
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> response = loggingServiceV2Client.ListLogEntriesAsync(resourceNames, filter, orderBy);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LogEntry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LogEntry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LogEntry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LogEntry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMonitoredResourceDescriptors</summary>
        public void ListMonitoredResourceDescriptorsRequestObject()
        {
            // Snippet: ListMonitoredResourceDescriptors(ListMonitoredResourceDescriptorsRequest, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest { };
            // Make the request
            PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = loggingServiceV2Client.ListMonitoredResourceDescriptors(request);

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

        /// <summary>Snippet for ListMonitoredResourceDescriptors</summary>
        public async Task ListMonitoredResourceDescriptorsRequestObjectAsync()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(ListMonitoredResourceDescriptorsRequest, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest { };
            // Make the request
            PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response = loggingServiceV2Client.ListMonitoredResourceDescriptorsAsync(request);

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

        /// <summary>Snippet for ListLogs</summary>
        public void ListLogsRequestObject()
        {
            // Snippet: ListLogs(ListLogsRequest, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public async Task ListLogsRequestObjectAsync()
        {
            // Snippet: ListLogsAsync(ListLogsRequest, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public void ListLogs()
        {
            // Snippet: ListLogs(string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public async Task ListLogsAsync()
        {
            // Snippet: ListLogsAsync(string, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public void ListLogsResourceNames1()
        {
            // Snippet: ListLogs(ProjectName, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public async Task ListLogsResourceNames1Async()
        {
            // Snippet: ListLogsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public void ListLogsResourceNames2()
        {
            // Snippet: ListLogs(OrganizationName, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public async Task ListLogsResourceNames2Async()
        {
            // Snippet: ListLogsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public void ListLogsResourceNames3()
        {
            // Snippet: ListLogs(FolderName, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public async Task ListLogsResourceNames3Async()
        {
            // Snippet: ListLogsAsync(FolderName, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public void ListLogsResourceNames4()
        {
            // Snippet: ListLogs(BillingAccountName, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            PagedEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLogs</summary>
        public async Task ListLogsResourceNames4Async()
        {
            // Snippet: ListLogsAsync(BillingAccountName, string, int?, CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            BillingAccountName parent = BillingAccountName.FromBillingAccount("[BILLING_ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListLogsResponse, string> response = loggingServiceV2Client.ListLogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
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
