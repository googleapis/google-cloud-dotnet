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
    using Google.Cloud.Channel.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    [ObsoleteAttribute]
    public sealed class AllGeneratedCloudChannelReportsServiceClientSnippets
    {
        /// <summary>Snippet for RunReportJob</summary>
        public void RunReportJobRequestObject()
        {
            // Snippet: RunReportJob(RunReportJobRequest, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = CloudChannelReportsServiceClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            RunReportJobRequest request = new RunReportJobRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> response = cloudChannelReportsServiceClient.RunReportJob(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            RunReportJobResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> retrievedResponse = cloudChannelReportsServiceClient.PollOnceRunReportJob(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                RunReportJobResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
            // End snippet
        }

        /// <summary>Snippet for RunReportJobAsync</summary>
        public async Task RunReportJobRequestObjectAsync()
        {
            // Snippet: RunReportJobAsync(RunReportJobRequest, CallSettings)
            // Additional: RunReportJobAsync(RunReportJobRequest, CancellationToken)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = await CloudChannelReportsServiceClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            RunReportJobRequest request = new RunReportJobRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> response = await cloudChannelReportsServiceClient.RunReportJobAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            RunReportJobResponse result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<RunReportJobResponse, OperationMetadata> retrievedResponse = await cloudChannelReportsServiceClient.PollOnceRunReportJobAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                RunReportJobResponse retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
            // End snippet
        }

        /// <summary>Snippet for FetchReportResults</summary>
        public void FetchReportResultsRequestObject()
        {
            // Snippet: FetchReportResults(FetchReportResultsRequest, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = CloudChannelReportsServiceClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            FetchReportResultsRequest request = new FetchReportResultsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<FetchReportResultsResponse, Row> response = cloudChannelReportsServiceClient.FetchReportResults(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (Row item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (FetchReportResultsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Row item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Row> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Row item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchReportResultsAsync</summary>
        public async Task FetchReportResultsRequestObjectAsync()
        {
            // Snippet: FetchReportResultsAsync(FetchReportResultsRequest, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = await CloudChannelReportsServiceClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            FetchReportResultsRequest request = new FetchReportResultsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<FetchReportResultsResponse, Row> response = cloudChannelReportsServiceClient.FetchReportResultsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((Row item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((FetchReportResultsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Row item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Row> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Row item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchReportResults</summary>
        public void FetchReportResults()
        {
            // Snippet: FetchReportResults(string, string, int?, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = CloudChannelReportsServiceClient.Create();
            // Initialize request argument(s)
            string reportJob = "accounts/[ACCOUNT]/reportJobs/[REPORT_JOB]";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<FetchReportResultsResponse, Row> response = cloudChannelReportsServiceClient.FetchReportResults(reportJob);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (Row item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (FetchReportResultsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Row item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Row> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Row item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchReportResultsAsync</summary>
        public async Task FetchReportResultsAsync()
        {
            // Snippet: FetchReportResultsAsync(string, string, int?, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = await CloudChannelReportsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string reportJob = "accounts/[ACCOUNT]/reportJobs/[REPORT_JOB]";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<FetchReportResultsResponse, Row> response = cloudChannelReportsServiceClient.FetchReportResultsAsync(reportJob);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((Row item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((FetchReportResultsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Row item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Row> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Row item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchReportResults</summary>
        public void FetchReportResultsResourceNames()
        {
            // Snippet: FetchReportResults(ReportJobName, string, int?, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = CloudChannelReportsServiceClient.Create();
            // Initialize request argument(s)
            ReportJobName reportJob = ReportJobName.FromAccountReportJob("[ACCOUNT]", "[REPORT_JOB]");
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<FetchReportResultsResponse, Row> response = cloudChannelReportsServiceClient.FetchReportResults(reportJob);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (Row item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (FetchReportResultsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Row item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Row> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Row item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchReportResultsAsync</summary>
        public async Task FetchReportResultsResourceNamesAsync()
        {
            // Snippet: FetchReportResultsAsync(ReportJobName, string, int?, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = await CloudChannelReportsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportJobName reportJob = ReportJobName.FromAccountReportJob("[ACCOUNT]", "[REPORT_JOB]");
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<FetchReportResultsResponse, Row> response = cloudChannelReportsServiceClient.FetchReportResultsAsync(reportJob);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((Row item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((FetchReportResultsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Row item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Row> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Row item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReports</summary>
        public void ListReportsRequestObject()
        {
            // Snippet: ListReports(ListReportsRequest, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = CloudChannelReportsServiceClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListReportsRequest request = new ListReportsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListReportsResponse, Report> response = cloudChannelReportsServiceClient.ListReports(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (Report item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListReportsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Report item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Report> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Report item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportsAsync</summary>
        public async Task ListReportsRequestObjectAsync()
        {
            // Snippet: ListReportsAsync(ListReportsRequest, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = await CloudChannelReportsServiceClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListReportsRequest request = new ListReportsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListReportsResponse, Report> response = cloudChannelReportsServiceClient.ListReportsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((Report item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListReportsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Report item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Report> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Report item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReports</summary>
        public void ListReports()
        {
            // Snippet: ListReports(string, string, int?, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = CloudChannelReportsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListReportsResponse, Report> response = cloudChannelReportsServiceClient.ListReports(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (Report item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListReportsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Report item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Report> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Report item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportsAsync</summary>
        public async Task ListReportsAsync()
        {
            // Snippet: ListReportsAsync(string, string, int?, CallSettings)
            // Create client
            CloudChannelReportsServiceClient cloudChannelReportsServiceClient = await CloudChannelReportsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListReportsResponse, Report> response = cloudChannelReportsServiceClient.ListReportsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((Report item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListReportsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Report item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Report> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Report item in singlePage)
#pragma warning restore CS0612
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
