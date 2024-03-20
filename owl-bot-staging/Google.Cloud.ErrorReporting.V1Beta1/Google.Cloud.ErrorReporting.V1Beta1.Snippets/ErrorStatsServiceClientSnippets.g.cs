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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ErrorReporting.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedErrorStatsServiceClientSnippets
    {
        /// <summary>Snippet for ListGroupStats</summary>
        public void ListGroupStatsRequestObject()
        {
            // Snippet: ListGroupStats(ListGroupStatsRequest, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            ListGroupStatsRequest request = new ListGroupStatsRequest
            {
                ProjectNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
                GroupId = { "", },
                ServiceFilter = new ServiceContextFilter(),
                TimeRange = new QueryTimeRange(),
                TimedCountDuration = new Duration(),
                Alignment = TimedCountAlignment.ErrorCountAlignmentUnspecified,
                AlignmentTime = new Timestamp(),
                Order = ErrorGroupOrder.GroupOrderUnspecified,
            };
            // Make the request
            PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> response = errorStatsServiceClient.ListGroupStats(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorGroupStats item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupStatsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorGroupStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorGroupStats> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorGroupStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupStatsAsync</summary>
        public async Task ListGroupStatsRequestObjectAsync()
        {
            // Snippet: ListGroupStatsAsync(ListGroupStatsRequest, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGroupStatsRequest request = new ListGroupStatsRequest
            {
                ProjectNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
                GroupId = { "", },
                ServiceFilter = new ServiceContextFilter(),
                TimeRange = new QueryTimeRange(),
                TimedCountDuration = new Duration(),
                Alignment = TimedCountAlignment.ErrorCountAlignmentUnspecified,
                AlignmentTime = new Timestamp(),
                Order = ErrorGroupOrder.GroupOrderUnspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> response = errorStatsServiceClient.ListGroupStatsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorGroupStats item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupStatsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorGroupStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorGroupStats> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorGroupStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupStats</summary>
        public void ListGroupStats()
        {
            // Snippet: ListGroupStats(string, QueryTimeRange, string, int?, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string projectName = "projects/[PROJECT]";
            QueryTimeRange timeRange = new QueryTimeRange();
            // Make the request
            PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> response = errorStatsServiceClient.ListGroupStats(projectName, timeRange);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorGroupStats item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupStatsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorGroupStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorGroupStats> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorGroupStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupStatsAsync</summary>
        public async Task ListGroupStatsAsync()
        {
            // Snippet: ListGroupStatsAsync(string, QueryTimeRange, string, int?, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectName = "projects/[PROJECT]";
            QueryTimeRange timeRange = new QueryTimeRange();
            // Make the request
            PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> response = errorStatsServiceClient.ListGroupStatsAsync(projectName, timeRange);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorGroupStats item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupStatsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorGroupStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorGroupStats> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorGroupStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupStats</summary>
        public void ListGroupStatsResourceNames()
        {
            // Snippet: ListGroupStats(ProjectName, QueryTimeRange, string, int?, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            ProjectName projectName = ProjectName.FromProject("[PROJECT]");
            QueryTimeRange timeRange = new QueryTimeRange();
            // Make the request
            PagedEnumerable<ListGroupStatsResponse, ErrorGroupStats> response = errorStatsServiceClient.ListGroupStats(projectName, timeRange);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorGroupStats item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGroupStatsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorGroupStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorGroupStats> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorGroupStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGroupStatsAsync</summary>
        public async Task ListGroupStatsResourceNamesAsync()
        {
            // Snippet: ListGroupStatsAsync(ProjectName, QueryTimeRange, string, int?, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName projectName = ProjectName.FromProject("[PROJECT]");
            QueryTimeRange timeRange = new QueryTimeRange();
            // Make the request
            PagedAsyncEnumerable<ListGroupStatsResponse, ErrorGroupStats> response = errorStatsServiceClient.ListGroupStatsAsync(projectName, timeRange);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorGroupStats item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGroupStatsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorGroupStats item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorGroupStats> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorGroupStats item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsRequestObject()
        {
            // Snippet: ListEvents(ListEventsRequest, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ProjectNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
                GroupId = "",
                ServiceFilter = new ServiceContextFilter(),
                TimeRange = new QueryTimeRange(),
            };
            // Make the request
            PagedEnumerable<ListEventsResponse, ErrorEvent> response = errorStatsServiceClient.ListEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsRequestObjectAsync()
        {
            // Snippet: ListEventsAsync(ListEventsRequest, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ProjectNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
                GroupId = "",
                ServiceFilter = new ServiceContextFilter(),
                TimeRange = new QueryTimeRange(),
            };
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> response = errorStatsServiceClient.ListEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEvents()
        {
            // Snippet: ListEvents(string, string, string, int?, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string projectName = "projects/[PROJECT]";
            string groupId = "";
            // Make the request
            PagedEnumerable<ListEventsResponse, ErrorEvent> response = errorStatsServiceClient.ListEvents(projectName, groupId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsAsync()
        {
            // Snippet: ListEventsAsync(string, string, string, int?, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectName = "projects/[PROJECT]";
            string groupId = "";
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> response = errorStatsServiceClient.ListEventsAsync(projectName, groupId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsResourceNames()
        {
            // Snippet: ListEvents(ProjectName, string, string, int?, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            ProjectName projectName = ProjectName.FromProject("[PROJECT]");
            string groupId = "";
            // Make the request
            PagedEnumerable<ListEventsResponse, ErrorEvent> response = errorStatsServiceClient.ListEvents(projectName, groupId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ErrorEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsResourceNamesAsync()
        {
            // Snippet: ListEventsAsync(ProjectName, string, string, int?, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName projectName = ProjectName.FromProject("[PROJECT]");
            string groupId = "";
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, ErrorEvent> response = errorStatsServiceClient.ListEventsAsync(projectName, groupId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ErrorEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ErrorEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ErrorEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ErrorEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteEvents</summary>
        public void DeleteEventsRequestObject()
        {
            // Snippet: DeleteEvents(DeleteEventsRequest, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            DeleteEventsResponse response = errorStatsServiceClient.DeleteEvents(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventsAsync</summary>
        public async Task DeleteEventsRequestObjectAsync()
        {
            // Snippet: DeleteEventsAsync(DeleteEventsRequest, CallSettings)
            // Additional: DeleteEventsAsync(DeleteEventsRequest, CancellationToken)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            DeleteEventsResponse response = await errorStatsServiceClient.DeleteEventsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvents</summary>
        public void DeleteEvents()
        {
            // Snippet: DeleteEvents(string, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            string projectName = "projects/[PROJECT]";
            // Make the request
            DeleteEventsResponse response = errorStatsServiceClient.DeleteEvents(projectName);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventsAsync</summary>
        public async Task DeleteEventsAsync()
        {
            // Snippet: DeleteEventsAsync(string, CallSettings)
            // Additional: DeleteEventsAsync(string, CancellationToken)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectName = "projects/[PROJECT]";
            // Make the request
            DeleteEventsResponse response = await errorStatsServiceClient.DeleteEventsAsync(projectName);
            // End snippet
        }

        /// <summary>Snippet for DeleteEvents</summary>
        public void DeleteEventsResourceNames()
        {
            // Snippet: DeleteEvents(ProjectName, CallSettings)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = ErrorStatsServiceClient.Create();
            // Initialize request argument(s)
            ProjectName projectName = ProjectName.FromProject("[PROJECT]");
            // Make the request
            DeleteEventsResponse response = errorStatsServiceClient.DeleteEvents(projectName);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventsAsync</summary>
        public async Task DeleteEventsResourceNamesAsync()
        {
            // Snippet: DeleteEventsAsync(ProjectName, CallSettings)
            // Additional: DeleteEventsAsync(ProjectName, CancellationToken)
            // Create client
            ErrorStatsServiceClient errorStatsServiceClient = await ErrorStatsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName projectName = ProjectName.FromProject("[PROJECT]");
            // Make the request
            DeleteEventsResponse response = await errorStatsServiceClient.DeleteEventsAsync(projectName);
            // End snippet
        }
    }
}
