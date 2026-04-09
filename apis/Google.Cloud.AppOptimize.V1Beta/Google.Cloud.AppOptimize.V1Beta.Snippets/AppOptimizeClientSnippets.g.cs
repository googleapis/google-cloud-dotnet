// Copyright 2026 Google LLC
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
    using Google.Cloud.AppOptimize.V1Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAppOptimizeClientSnippets
    {
        /// <summary>Snippet for CreateReport</summary>
        public void CreateReportRequestObject()
        {
            // Snippet: CreateReport(CreateReportRequest, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            CreateReportRequest request = new CreateReportRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReportId = "",
                Report = new Report(),
            };
            // Make the request
            Operation<Report, OperationMetadata> response = appOptimizeClient.CreateReport(request);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = appOptimizeClient.PollOnceCreateReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportRequestObjectAsync()
        {
            // Snippet: CreateReportAsync(CreateReportRequest, CallSettings)
            // Additional: CreateReportAsync(CreateReportRequest, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            CreateReportRequest request = new CreateReportRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReportId = "",
                Report = new Report(),
            };
            // Make the request
            Operation<Report, OperationMetadata> response = await appOptimizeClient.CreateReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = await appOptimizeClient.PollOnceCreateReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReport</summary>
        public void CreateReport()
        {
            // Snippet: CreateReport(string, Report, string, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Report report = new Report();
            string reportId = "";
            // Make the request
            Operation<Report, OperationMetadata> response = appOptimizeClient.CreateReport(parent, report, reportId);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = appOptimizeClient.PollOnceCreateReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportAsync()
        {
            // Snippet: CreateReportAsync(string, Report, string, CallSettings)
            // Additional: CreateReportAsync(string, Report, string, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Report report = new Report();
            string reportId = "";
            // Make the request
            Operation<Report, OperationMetadata> response = await appOptimizeClient.CreateReportAsync(parent, report, reportId);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = await appOptimizeClient.PollOnceCreateReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReport</summary>
        public void CreateReportResourceNames()
        {
            // Snippet: CreateReport(LocationName, Report, string, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Report report = new Report();
            string reportId = "";
            // Make the request
            Operation<Report, OperationMetadata> response = appOptimizeClient.CreateReport(parent, report, reportId);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = appOptimizeClient.PollOnceCreateReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReportAsync</summary>
        public async Task CreateReportResourceNamesAsync()
        {
            // Snippet: CreateReportAsync(LocationName, Report, string, CallSettings)
            // Additional: CreateReportAsync(LocationName, Report, string, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Report report = new Report();
            string reportId = "";
            // Make the request
            Operation<Report, OperationMetadata> response = await appOptimizeClient.CreateReportAsync(parent, report, reportId);

            // Poll until the returned long-running operation is complete
            Operation<Report, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Report result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Report, OperationMetadata> retrievedResponse = await appOptimizeClient.PollOnceCreateReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Report retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetReport</summary>
        public void GetReportRequestObject()
        {
            // Snippet: GetReport(GetReportRequest, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            GetReportRequest request = new GetReportRequest
            {
                ReportName = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]"),
            };
            // Make the request
            Report response = appOptimizeClient.GetReport(request);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportRequestObjectAsync()
        {
            // Snippet: GetReportAsync(GetReportRequest, CallSettings)
            // Additional: GetReportAsync(GetReportRequest, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            GetReportRequest request = new GetReportRequest
            {
                ReportName = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]"),
            };
            // Make the request
            Report response = await appOptimizeClient.GetReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReport</summary>
        public void GetReport()
        {
            // Snippet: GetReport(string, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reports/[REPORT]";
            // Make the request
            Report response = appOptimizeClient.GetReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportAsync()
        {
            // Snippet: GetReportAsync(string, CallSettings)
            // Additional: GetReportAsync(string, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reports/[REPORT]";
            // Make the request
            Report response = await appOptimizeClient.GetReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReport</summary>
        public void GetReportResourceNames()
        {
            // Snippet: GetReport(ReportName, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]");
            // Make the request
            Report response = appOptimizeClient.GetReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetReportAsync</summary>
        public async Task GetReportResourceNamesAsync()
        {
            // Snippet: GetReportAsync(ReportName, CallSettings)
            // Additional: GetReportAsync(ReportName, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]");
            // Make the request
            Report response = await appOptimizeClient.GetReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReports</summary>
        public void ListReportsRequestObject()
        {
            // Snippet: ListReports(ListReportsRequest, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = appOptimizeClient.ListReports(request);

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
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            ListReportsRequest request = new ListReportsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = appOptimizeClient.ListReportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListReportsResponse page in response.AsRawResponses())
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
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = appOptimizeClient.ListReports(parent);

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
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = appOptimizeClient.ListReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListReportsResponse page in response.AsRawResponses())
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
            // Snippet: ListReports(LocationName, string, int?, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListReportsResponse, Report> response = appOptimizeClient.ListReports(parent);

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
            // Snippet: ListReportsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListReportsResponse, Report> response = appOptimizeClient.ListReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Report item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListReportsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for DeleteReport</summary>
        public void DeleteReportRequestObject()
        {
            // Snippet: DeleteReport(DeleteReportRequest, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            DeleteReportRequest request = new DeleteReportRequest
            {
                ReportName = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]"),
                AllowMissing = false,
            };
            // Make the request
            appOptimizeClient.DeleteReport(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportAsync</summary>
        public async Task DeleteReportRequestObjectAsync()
        {
            // Snippet: DeleteReportAsync(DeleteReportRequest, CallSettings)
            // Additional: DeleteReportAsync(DeleteReportRequest, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReportRequest request = new DeleteReportRequest
            {
                ReportName = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]"),
                AllowMissing = false,
            };
            // Make the request
            await appOptimizeClient.DeleteReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReport</summary>
        public void DeleteReport()
        {
            // Snippet: DeleteReport(string, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reports/[REPORT]";
            // Make the request
            appOptimizeClient.DeleteReport(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportAsync</summary>
        public async Task DeleteReportAsync()
        {
            // Snippet: DeleteReportAsync(string, CallSettings)
            // Additional: DeleteReportAsync(string, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reports/[REPORT]";
            // Make the request
            await appOptimizeClient.DeleteReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReport</summary>
        public void DeleteReportResourceNames()
        {
            // Snippet: DeleteReport(ReportName, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]");
            // Make the request
            appOptimizeClient.DeleteReport(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReportAsync</summary>
        public async Task DeleteReportResourceNamesAsync()
        {
            // Snippet: DeleteReportAsync(ReportName, CallSettings)
            // Additional: DeleteReportAsync(ReportName, CancellationToken)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]");
            // Make the request
            await appOptimizeClient.DeleteReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ReadReport</summary>
        public void ReadReportRequestObject()
        {
            // Snippet: ReadReport(ReadReportRequest, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            ReadReportRequest request = new ReadReportRequest
            {
                ReportName = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]"),
            };
            // Make the request
            PagedEnumerable<ReadReportResponse, ListValue> response = appOptimizeClient.ReadReport(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReadReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ReadReportAsync</summary>
        public async Task ReadReportRequestObjectAsync()
        {
            // Snippet: ReadReportAsync(ReadReportRequest, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            ReadReportRequest request = new ReadReportRequest
            {
                ReportName = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ReadReportResponse, ListValue> response = appOptimizeClient.ReadReportAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ListValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ReadReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ReadReport</summary>
        public void ReadReport()
        {
            // Snippet: ReadReport(string, string, int?, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reports/[REPORT]";
            // Make the request
            PagedEnumerable<ReadReportResponse, ListValue> response = appOptimizeClient.ReadReport(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReadReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ReadReportAsync</summary>
        public async Task ReadReportAsync()
        {
            // Snippet: ReadReportAsync(string, string, int?, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reports/[REPORT]";
            // Make the request
            PagedAsyncEnumerable<ReadReportResponse, ListValue> response = appOptimizeClient.ReadReportAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ListValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ReadReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ReadReport</summary>
        public void ReadReportResourceNames()
        {
            // Snippet: ReadReport(ReportName, string, int?, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = AppOptimizeClient.Create();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]");
            // Make the request
            PagedEnumerable<ReadReportResponse, ListValue> response = appOptimizeClient.ReadReport(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReadReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListValue> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListValue item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ReadReportAsync</summary>
        public async Task ReadReportResourceNamesAsync()
        {
            // Snippet: ReadReportAsync(ReportName, string, int?, CallSettings)
            // Create client
            AppOptimizeClient appOptimizeClient = await AppOptimizeClient.CreateAsync();
            // Initialize request argument(s)
            ReportName name = ReportName.FromProjectLocationReport("[PROJECT]", "[LOCATION]", "[REPORT]");
            // Make the request
            PagedAsyncEnumerable<ReadReportResponse, ListValue> response = appOptimizeClient.ReadReportAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ListValue item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ReadReportResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListValue item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListValue> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListValue item in singlePage)
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
