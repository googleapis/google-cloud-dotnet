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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReportServiceClientSnippets
    {
        /// <summary>Snippet for GetReport</summary>
        public void GetReportRequestObject()
        {
            // Snippet: GetReport(GetReportRequest, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            GetReportRequest request = new GetReportRequest
            {
                ReportName = ReportName.FromNetworkCodeReport("[NETWORK_CODE]", "[REPORT]"),
            };
            // Make the request
            Report response = reportServiceClient.GetReport(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportRequestObjectAsync()
        {
            // Snippet: GetReportAsync(GetReportRequest, CallSettings)
            // Additional: GetReportAsync(GetReportRequest, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetReportRequest request = new GetReportRequest
            {
                ReportName = ReportName.FromNetworkCodeReport("[NETWORK_CODE]", "[REPORT]"),
            };
            // Make the request
            Report response = await reportServiceClient.GetReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReport</summary>
        public void GetReport()
        {
            // Snippet: GetReport(string, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/reports/[REPORT]";
            // Make the request
            Report response = reportServiceClient.GetReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportAsync()
        {
            // Snippet: GetReportAsync(string, CallSettings)
            // Additional: GetReportAsync(string, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/reports/[REPORT]";
            // Make the request
            Report response = await reportServiceClient.GetReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReport</summary>
        public void GetReportResourceNames()
        {
            // Snippet: GetReport(ReportName, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            ReportName name = ReportName.FromNetworkCodeReport("[NETWORK_CODE]", "[REPORT]");
            // Make the request
            Report response = reportServiceClient.GetReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportResourceNamesAsync()
        {
            // Snippet: GetReportAsync(ReportName, CallSettings)
            // Additional: GetReportAsync(ReportName, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportName name = ReportName.FromNetworkCodeReport("[NETWORK_CODE]", "[REPORT]");
            // Make the request
            Report response = await reportServiceClient.GetReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReports</summary>
        public void ListReportsRequestObject()
        {
            // Snippet: ListReports(ListReportsRequest, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = reportServiceClient.ListReports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
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
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = reportServiceClient.ListReportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Report item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
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
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = reportServiceClient.ListReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
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
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = reportServiceClient.ListReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Report item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReports</summary>
        public void ListReportsResourceNames()
        {
            // Snippet: ListReports(NetworkName, string, int?, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = reportServiceClient.ListReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReportsAsync</summary>
        public async Task ListReportsResourceNamesAsync()
        {
            // Snippet: ListReportsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = reportServiceClient.ListReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Report item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReportsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateReport</summary>
        public void CreateReportRequestObject()
        {
            // Snippet: CreateReport(CreateReportRequest, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            CreateReportRequest request = new CreateReportRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Report = new Report(),
            };
            // Make the request
            Report response = reportServiceClient.CreateReport(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportRequestObjectAsync()
        {
            // Snippet: CreateReportAsync(CreateReportRequest, CallSettings)
            // Additional: CreateReportAsync(CreateReportRequest, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateReportRequest request = new CreateReportRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Report = new Report(),
            };
            // Make the request
            Report response = await reportServiceClient.CreateReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReport</summary>
        public void CreateReport()
        {
            // Snippet: CreateReport(string, Report, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Report report = new Report();
            // Make the request
            Report response = reportServiceClient.CreateReport(parent, report);
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportAsync()
        {
            // Snippet: CreateReportAsync(string, Report, CallSettings)
            // Additional: CreateReportAsync(string, Report, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Report report = new Report();
            // Make the request
            Report response = await reportServiceClient.CreateReportAsync(parent, report);
            // End snippet
        }

        /// <summary>Snippet for CreateReport</summary>
        public void CreateReportResourceNames()
        {
            // Snippet: CreateReport(NetworkName, Report, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Report report = new Report();
            // Make the request
            Report response = reportServiceClient.CreateReport(parent, report);
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportResourceNamesAsync()
        {
            // Snippet: CreateReportAsync(NetworkName, Report, CallSettings)
            // Additional: CreateReportAsync(NetworkName, Report, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Report report = new Report();
            // Make the request
            Report response = await reportServiceClient.CreateReportAsync(parent, report);
            // End snippet
        }

        /// <summary>Snippet for UpdateReport</summary>
        public void UpdateReportRequestObject()
        {
            // Snippet: UpdateReport(UpdateReportRequest, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            UpdateReportRequest request = new UpdateReportRequest
            {
                Report = new Report(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Report response = reportServiceClient.UpdateReport(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReportAsync</summary>
        public async Task UpdateReportRequestObjectAsync()
        {
            // Snippet: UpdateReportAsync(UpdateReportRequest, CallSettings)
            // Additional: UpdateReportAsync(UpdateReportRequest, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReportRequest request = new UpdateReportRequest
            {
                Report = new Report(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Report response = await reportServiceClient.UpdateReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReport</summary>
        public void UpdateReport()
        {
            // Snippet: UpdateReport(Report, FieldMask, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            Report report = new Report();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Report response = reportServiceClient.UpdateReport(report, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateReportAsync</summary>
        public async Task UpdateReportAsync()
        {
            // Snippet: UpdateReportAsync(Report, FieldMask, CallSettings)
            // Additional: UpdateReportAsync(Report, FieldMask, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            Report report = new Report();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Report response = await reportServiceClient.UpdateReportAsync(report, updateMask);
            // End snippet
        }

        /// <summary>Snippet for RunReport</summary>
        public void RunReportRequestObject()
        {
            // Snippet: RunReport(RunReportRequest, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest
            {
                ReportName = ReportName.FromNetworkCodeReport("[NETWORK_CODE]", "[REPORT]"),
            };
            // Make the request
            Operation<RunReportResponse, RunReportMetadata> response = reportServiceClient.RunReport(request);

            // Poll until the returned long-running operation is complete
            Operation<RunReportResponse, RunReportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunReportResponse, RunReportMetadata> retrievedResponse = reportServiceClient.PollOnceRunReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunReportAsync</summary>
        public async Task RunReportRequestObjectAsync()
        {
            // Snippet: RunReportAsync(RunReportRequest, CallSettings)
            // Additional: RunReportAsync(RunReportRequest, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunReportRequest request = new RunReportRequest
            {
                ReportName = ReportName.FromNetworkCodeReport("[NETWORK_CODE]", "[REPORT]"),
            };
            // Make the request
            Operation<RunReportResponse, RunReportMetadata> response = await reportServiceClient.RunReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RunReportResponse, RunReportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunReportResponse, RunReportMetadata> retrievedResponse = await reportServiceClient.PollOnceRunReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunReport</summary>
        public void RunReport()
        {
            // Snippet: RunReport(string, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/reports/[REPORT]";
            // Make the request
            Operation<RunReportResponse, RunReportMetadata> response = reportServiceClient.RunReport(name);

            // Poll until the returned long-running operation is complete
            Operation<RunReportResponse, RunReportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunReportResponse, RunReportMetadata> retrievedResponse = reportServiceClient.PollOnceRunReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunReportAsync</summary>
        public async Task RunReportAsync()
        {
            // Snippet: RunReportAsync(string, CallSettings)
            // Additional: RunReportAsync(string, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/reports/[REPORT]";
            // Make the request
            Operation<RunReportResponse, RunReportMetadata> response = await reportServiceClient.RunReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RunReportResponse, RunReportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunReportResponse, RunReportMetadata> retrievedResponse = await reportServiceClient.PollOnceRunReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunReport</summary>
        public void RunReportResourceNames()
        {
            // Snippet: RunReport(ReportName, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            ReportName name = ReportName.FromNetworkCodeReport("[NETWORK_CODE]", "[REPORT]");
            // Make the request
            Operation<RunReportResponse, RunReportMetadata> response = reportServiceClient.RunReport(name);

            // Poll until the returned long-running operation is complete
            Operation<RunReportResponse, RunReportMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RunReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunReportResponse, RunReportMetadata> retrievedResponse = reportServiceClient.PollOnceRunReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunReportAsync</summary>
        public async Task RunReportResourceNamesAsync()
        {
            // Snippet: RunReportAsync(ReportName, CallSettings)
            // Additional: RunReportAsync(ReportName, CancellationToken)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReportName name = ReportName.FromNetworkCodeReport("[NETWORK_CODE]", "[REPORT]");
            // Make the request
            Operation<RunReportResponse, RunReportMetadata> response = await reportServiceClient.RunReportAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RunReportResponse, RunReportMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RunReportResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RunReportResponse, RunReportMetadata> retrievedResponse = await reportServiceClient.PollOnceRunReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RunReportResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchReportResultRows</summary>
        public void FetchReportResultRowsRequestObject()
        {
            // Snippet: FetchReportResultRows(FetchReportResultRowsRequest, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            FetchReportResultRowsRequest request = new FetchReportResultRowsRequest { Name = "", };
            // Make the request
            PagedEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> response = reportServiceClient.FetchReportResultRows(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Report.Types.DataTable.Types.Row item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchReportResultRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report.Types.DataTable.Types.Row item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report.Types.DataTable.Types.Row> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report.Types.DataTable.Types.Row item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchReportResultRowsAsync</summary>
        public async Task FetchReportResultRowsRequestObjectAsync()
        {
            // Snippet: FetchReportResultRowsAsync(FetchReportResultRowsRequest, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchReportResultRowsRequest request = new FetchReportResultRowsRequest { Name = "", };
            // Make the request
            PagedAsyncEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> response = reportServiceClient.FetchReportResultRowsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Report.Types.DataTable.Types.Row item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchReportResultRowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report.Types.DataTable.Types.Row item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report.Types.DataTable.Types.Row> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report.Types.DataTable.Types.Row item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchReportResultRows</summary>
        public void FetchReportResultRows()
        {
            // Snippet: FetchReportResultRows(string, string, int?, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = ReportServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            PagedEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> response = reportServiceClient.FetchReportResultRows(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Report.Types.DataTable.Types.Row item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchReportResultRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report.Types.DataTable.Types.Row item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report.Types.DataTable.Types.Row> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report.Types.DataTable.Types.Row item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchReportResultRowsAsync</summary>
        public async Task FetchReportResultRowsAsync()
        {
            // Snippet: FetchReportResultRowsAsync(string, string, int?, CallSettings)
            // Create client
            ReportServiceClient reportServiceClient = await ReportServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            PagedAsyncEnumerable<FetchReportResultRowsResponse, Report.Types.DataTable.Types.Row> response = reportServiceClient.FetchReportResultRowsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Report.Types.DataTable.Types.Row item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchReportResultRowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Report.Types.DataTable.Types.Row item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Report.Types.DataTable.Types.Row> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Report.Types.DataTable.Types.Row item in singlePage)
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
