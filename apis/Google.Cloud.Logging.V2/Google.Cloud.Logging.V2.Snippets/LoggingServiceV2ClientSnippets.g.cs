// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Logging.V2;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Logging.V2.Snippets
{
    public class GeneratedLoggingServiceV2ClientSnippets
    {
        public async Task DeleteLogAsync()
        {
            // Snippet: DeleteLogAsync(LogNameOneof,CallSettings)
            // Additional: DeleteLogAsync(LogNameOneof,CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(logName);
            // End snippet
        }

        public void DeleteLog()
        {
            // Snippet: DeleteLog(LogNameOneof,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            // Make the request
            loggingServiceV2Client.DeleteLog(logName);
            // End snippet
        }

        public async Task DeleteLogAsync_RequestObject()
        {
            // Snippet: DeleteLogAsync(DeleteLogRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogNameOneof = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]")),
            };
            // Make the request
            await loggingServiceV2Client.DeleteLogAsync(request);
            // End snippet
        }

        public void DeleteLog_RequestObject()
        {
            // Snippet: DeleteLog(DeleteLogRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogNameAsLogNameOneof = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]")),
            };
            // Make the request
            loggingServiceV2Client.DeleteLog(request);
            // End snippet
        }

        public async Task WriteLogEntriesAsync()
        {
            // Snippet: WriteLogEntriesAsync(LogNameOneof,MonitoredResource,IDictionary<string, string>,IEnumerable<LogEntry>,CallSettings)
            // Additional: WriteLogEntriesAsync(LogNameOneof,MonitoredResource,IDictionary<string, string>,IEnumerable<LogEntry>,CancellationToken)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string>();
            IEnumerable<LogEntry> entries = new List<LogEntry>();
            // Make the request
            WriteLogEntriesResponse response = await loggingServiceV2Client.WriteLogEntriesAsync(logName, resource, labels, entries);
            // End snippet
        }

        public void WriteLogEntries()
        {
            // Snippet: WriteLogEntries(LogNameOneof,MonitoredResource,IDictionary<string, string>,IEnumerable<LogEntry>,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            LogNameOneof logName = LogNameOneof.From(new LogName("[PROJECT]", "[LOG]"));
            MonitoredResource resource = new MonitoredResource();
            IDictionary<string, string> labels = new Dictionary<string, string>();
            IEnumerable<LogEntry> entries = new List<LogEntry>();
            // Make the request
            WriteLogEntriesResponse response = loggingServiceV2Client.WriteLogEntries(logName, resource, labels, entries);
            // End snippet
        }

        public async Task WriteLogEntriesAsync_RequestObject()
        {
            // Snippet: WriteLogEntriesAsync(WriteLogEntriesRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                Entries = { },
            };
            // Make the request
            WriteLogEntriesResponse response = await loggingServiceV2Client.WriteLogEntriesAsync(request);
            // End snippet
        }

        public void WriteLogEntries_RequestObject()
        {
            // Snippet: WriteLogEntries(WriteLogEntriesRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                Entries = { },
            };
            // Make the request
            WriteLogEntriesResponse response = loggingServiceV2Client.WriteLogEntries(request);
            // End snippet
        }

        public async Task ListLogEntriesAsync()
        {
            // Snippet: ListLogEntriesAsync(IEnumerable<string>,string,string,string,int?,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            IEnumerable<string> resourceNames = new List<string>();
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> response =
                loggingServiceV2Client.ListLogEntriesAsync(resourceNames, filter, orderBy);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListLogEntries()
        {
            // Snippet: ListLogEntries(IEnumerable<string>,string,string,string,int?,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            IEnumerable<string> resourceNames = new List<string>();
            string filter = "";
            string orderBy = "";
            // Make the request
            PagedEnumerable<ListLogEntriesResponse, LogEntry> response =
                loggingServiceV2Client.ListLogEntries(resourceNames, filter, orderBy);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListLogEntriesAsync_RequestObject()
        {
            // Snippet: ListLogEntriesAsync(ListLogEntriesRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNames = { },
            };
            // Make the request
            PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> response =
                loggingServiceV2Client.ListLogEntriesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListLogEntries_RequestObject()
        {
            // Snippet: ListLogEntries(ListLogEntriesRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNames = { },
            };
            // Make the request
            PagedEnumerable<ListLogEntriesResponse, LogEntry> response =
                loggingServiceV2Client.ListLogEntries(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListMonitoredResourceDescriptorsAsync_RequestObject()
        {
            // Snippet: ListMonitoredResourceDescriptorsAsync(ListMonitoredResourceDescriptorsRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest();
            // Make the request
            PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response =
                loggingServiceV2Client.ListMonitoredResourceDescriptorsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListMonitoredResourceDescriptors_RequestObject()
        {
            // Snippet: ListMonitoredResourceDescriptors(ListMonitoredResourceDescriptorsRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ListMonitoredResourceDescriptorsRequest request = new ListMonitoredResourceDescriptorsRequest();
            // Make the request
            PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> response =
                loggingServiceV2Client.ListMonitoredResourceDescriptors(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListLogsAsync()
        {
            // Snippet: ListLogsAsync(ParentNameOneof,string,int?,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            // Make the request
            PagedAsyncEnumerable<ListLogsResponse, string> response =
                loggingServiceV2Client.ListLogsAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListLogs()
        {
            // Snippet: ListLogs(ParentNameOneof,string,int?,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ParentNameOneof parent = ParentNameOneof.From(new ProjectName("[PROJECT]"));
            // Make the request
            PagedEnumerable<ListLogsResponse, string> response =
                loggingServiceV2Client.ListLogs(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListLogsAsync_RequestObject()
        {
            // Snippet: ListLogsAsync(ListLogsRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = await LoggingServiceV2Client.CreateAsync();
            // Initialize request argument(s)
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
            };
            // Make the request
            PagedAsyncEnumerable<ListLogsResponse, string> response =
                loggingServiceV2Client.ListLogsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListLogs_RequestObject()
        {
            // Snippet: ListLogs(ListLogsRequest,CallSettings)
            // Create client
            LoggingServiceV2Client loggingServiceV2Client = LoggingServiceV2Client.Create();
            // Initialize request argument(s)
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsParentNameOneof = ParentNameOneof.From(new ProjectName("[PROJECT]")),
            };
            // Make the request
            PagedEnumerable<ListLogsResponse, string> response =
                loggingServiceV2Client.ListLogs(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
