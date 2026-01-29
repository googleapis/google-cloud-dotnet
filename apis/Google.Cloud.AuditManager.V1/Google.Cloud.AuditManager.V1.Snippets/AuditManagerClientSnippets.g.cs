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
    using Google.Cloud.AuditManager.V1;
    using Google.LongRunning;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAuditManagerClientSnippets
    {
        /// <summary>Snippet for EnrollResource</summary>
        public void EnrollResourceRequestObject()
        {
            // Snippet: EnrollResource(EnrollResourceRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            EnrollResourceRequest request = new EnrollResourceRequest
            {
                Scope = "",
                Destinations =
                {
                    new EnrollResourceRequest.Types.EligibleDestination(),
                },
            };
            // Make the request
            Enrollment response = auditManagerClient.EnrollResource(request);
            // End snippet
        }

        /// <summary>Snippet for EnrollResourceAsync</summary>
        public async Task EnrollResourceRequestObjectAsync()
        {
            // Snippet: EnrollResourceAsync(EnrollResourceRequest, CallSettings)
            // Additional: EnrollResourceAsync(EnrollResourceRequest, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            EnrollResourceRequest request = new EnrollResourceRequest
            {
                Scope = "",
                Destinations =
                {
                    new EnrollResourceRequest.Types.EligibleDestination(),
                },
            };
            // Make the request
            Enrollment response = await auditManagerClient.EnrollResourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EnrollResource</summary>
        public void EnrollResource()
        {
            // Snippet: EnrollResource(string, IEnumerable<EnrollResourceRequest.Types.EligibleDestination>, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            string scope = "";
            IEnumerable<EnrollResourceRequest.Types.EligibleDestination> destinations = new EnrollResourceRequest.Types.EligibleDestination[]
            {
                new EnrollResourceRequest.Types.EligibleDestination(),
            };
            // Make the request
            Enrollment response = auditManagerClient.EnrollResource(scope, destinations);
            // End snippet
        }

        /// <summary>Snippet for EnrollResourceAsync</summary>
        public async Task EnrollResourceAsync()
        {
            // Snippet: EnrollResourceAsync(string, IEnumerable<EnrollResourceRequest.Types.EligibleDestination>, CallSettings)
            // Additional: EnrollResourceAsync(string, IEnumerable<EnrollResourceRequest.Types.EligibleDestination>, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            IEnumerable<EnrollResourceRequest.Types.EligibleDestination> destinations = new EnrollResourceRequest.Types.EligibleDestination[]
            {
                new EnrollResourceRequest.Types.EligibleDestination(),
            };
            // Make the request
            Enrollment response = await auditManagerClient.EnrollResourceAsync(scope, destinations);
            // End snippet
        }

        /// <summary>Snippet for GenerateAuditScopeReport</summary>
        public void GenerateAuditScopeReportRequestObject()
        {
            // Snippet: GenerateAuditScopeReport(GenerateAuditScopeReportRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            GenerateAuditScopeReportRequest request = new GenerateAuditScopeReportRequest
            {
                Scope = "",
                ComplianceStandard = "",
                ReportFormat = GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat.Unspecified,
                ComplianceFramework = "",
            };
            // Make the request
            AuditScopeReport response = auditManagerClient.GenerateAuditScopeReport(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAuditScopeReportAsync</summary>
        public async Task GenerateAuditScopeReportRequestObjectAsync()
        {
            // Snippet: GenerateAuditScopeReportAsync(GenerateAuditScopeReportRequest, CallSettings)
            // Additional: GenerateAuditScopeReportAsync(GenerateAuditScopeReportRequest, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAuditScopeReportRequest request = new GenerateAuditScopeReportRequest
            {
                Scope = "",
                ComplianceStandard = "",
                ReportFormat = GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat.Unspecified,
                ComplianceFramework = "",
            };
            // Make the request
            AuditScopeReport response = await auditManagerClient.GenerateAuditScopeReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAuditScopeReport</summary>
        public void GenerateAuditScopeReport()
        {
            // Snippet: GenerateAuditScopeReport(string, string, GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string complianceStandard = "";
            GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat reportFormat = GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat.Unspecified;
            // Make the request
            AuditScopeReport response = auditManagerClient.GenerateAuditScopeReport(scope, complianceStandard, reportFormat);
            // End snippet
        }

        /// <summary>Snippet for GenerateAuditScopeReportAsync</summary>
        public async Task GenerateAuditScopeReportAsync()
        {
            // Snippet: GenerateAuditScopeReportAsync(string, string, GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat, CallSettings)
            // Additional: GenerateAuditScopeReportAsync(string, string, GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string complianceStandard = "";
            GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat reportFormat = GenerateAuditScopeReportRequest.Types.AuditScopeReportFormat.Unspecified;
            // Make the request
            AuditScopeReport response = await auditManagerClient.GenerateAuditScopeReportAsync(scope, complianceStandard, reportFormat);
            // End snippet
        }

        /// <summary>Snippet for GenerateAuditReport</summary>
        public void GenerateAuditReportRequestObject()
        {
            // Snippet: GenerateAuditReport(GenerateAuditReportRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            GenerateAuditReportRequest request = new GenerateAuditReportRequest
            {
                Scope = "",
                GcsUri = "",
                ComplianceStandard = "",
                ReportFormat = GenerateAuditReportRequest.Types.AuditReportFormat.Unspecified,
                ComplianceFramework = "",
            };
            // Make the request
            Operation<AuditReport, OperationMetadata> response = auditManagerClient.GenerateAuditReport(request);

            // Poll until the returned long-running operation is complete
            Operation<AuditReport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuditReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuditReport, OperationMetadata> retrievedResponse = auditManagerClient.PollOnceGenerateAuditReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuditReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAuditReportAsync</summary>
        public async Task GenerateAuditReportRequestObjectAsync()
        {
            // Snippet: GenerateAuditReportAsync(GenerateAuditReportRequest, CallSettings)
            // Additional: GenerateAuditReportAsync(GenerateAuditReportRequest, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAuditReportRequest request = new GenerateAuditReportRequest
            {
                Scope = "",
                GcsUri = "",
                ComplianceStandard = "",
                ReportFormat = GenerateAuditReportRequest.Types.AuditReportFormat.Unspecified,
                ComplianceFramework = "",
            };
            // Make the request
            Operation<AuditReport, OperationMetadata> response = await auditManagerClient.GenerateAuditReportAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AuditReport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuditReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuditReport, OperationMetadata> retrievedResponse = await auditManagerClient.PollOnceGenerateAuditReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuditReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAuditReport</summary>
        public void GenerateAuditReport()
        {
            // Snippet: GenerateAuditReport(string, string, string, GenerateAuditReportRequest.Types.AuditReportFormat, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            string scope = "";
            string gcsUri = "";
            string complianceStandard = "";
            GenerateAuditReportRequest.Types.AuditReportFormat reportFormat = GenerateAuditReportRequest.Types.AuditReportFormat.Unspecified;
            // Make the request
            Operation<AuditReport, OperationMetadata> response = auditManagerClient.GenerateAuditReport(scope, gcsUri, complianceStandard, reportFormat);

            // Poll until the returned long-running operation is complete
            Operation<AuditReport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuditReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuditReport, OperationMetadata> retrievedResponse = auditManagerClient.PollOnceGenerateAuditReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuditReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAuditReportAsync</summary>
        public async Task GenerateAuditReportAsync()
        {
            // Snippet: GenerateAuditReportAsync(string, string, string, GenerateAuditReportRequest.Types.AuditReportFormat, CallSettings)
            // Additional: GenerateAuditReportAsync(string, string, string, GenerateAuditReportRequest.Types.AuditReportFormat, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            string gcsUri = "";
            string complianceStandard = "";
            GenerateAuditReportRequest.Types.AuditReportFormat reportFormat = GenerateAuditReportRequest.Types.AuditReportFormat.Unspecified;
            // Make the request
            Operation<AuditReport, OperationMetadata> response = await auditManagerClient.GenerateAuditReportAsync(scope, gcsUri, complianceStandard, reportFormat);

            // Poll until the returned long-running operation is complete
            Operation<AuditReport, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuditReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuditReport, OperationMetadata> retrievedResponse = await auditManagerClient.PollOnceGenerateAuditReportAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuditReport retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAuditReports</summary>
        public void ListAuditReportsRequestObject()
        {
            // Snippet: ListAuditReports(ListAuditReportsRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            ListAuditReportsRequest request = new ListAuditReportsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAuditReportsResponse, AuditReport> response = auditManagerClient.ListAuditReports(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuditReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuditReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuditReportsAsync</summary>
        public async Task ListAuditReportsRequestObjectAsync()
        {
            // Snippet: ListAuditReportsAsync(ListAuditReportsRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListAuditReportsRequest request = new ListAuditReportsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> response = auditManagerClient.ListAuditReportsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AuditReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuditReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuditReports</summary>
        public void ListAuditReports()
        {
            // Snippet: ListAuditReports(string, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAuditReportsResponse, AuditReport> response = auditManagerClient.ListAuditReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuditReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuditReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuditReportsAsync</summary>
        public async Task ListAuditReportsAsync()
        {
            // Snippet: ListAuditReportsAsync(string, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> response = auditManagerClient.ListAuditReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AuditReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuditReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuditReports</summary>
        public void ListAuditReportsResourceNames1()
        {
            // Snippet: ListAuditReports(LocationName, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAuditReportsResponse, AuditReport> response = auditManagerClient.ListAuditReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuditReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuditReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuditReportsAsync</summary>
        public async Task ListAuditReportsResourceNames1Async()
        {
            // Snippet: ListAuditReportsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> response = auditManagerClient.ListAuditReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AuditReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuditReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuditReports</summary>
        public void ListAuditReportsResourceNames2()
        {
            // Snippet: ListAuditReports(FolderLocationName, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAuditReportsResponse, AuditReport> response = auditManagerClient.ListAuditReports(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuditReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuditReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditReport> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuditReportsAsync</summary>
        public async Task ListAuditReportsResourceNames2Async()
        {
            // Snippet: ListAuditReportsAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAuditReportsResponse, AuditReport> response = auditManagerClient.ListAuditReportsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AuditReport item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAuditReportsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditReport item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditReport> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditReport item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAuditReport</summary>
        public void GetAuditReportRequestObject()
        {
            // Snippet: GetAuditReport(GetAuditReportRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            GetAuditReportRequest request = new GetAuditReportRequest
            {
                AuditReportName = AuditReportName.FromProjectLocationAuditReport("[PROJECT]", "[LOCATION]", "[AUDIT_REPORT]"),
            };
            // Make the request
            AuditReport response = auditManagerClient.GetAuditReport(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuditReportAsync</summary>
        public async Task GetAuditReportRequestObjectAsync()
        {
            // Snippet: GetAuditReportAsync(GetAuditReportRequest, CallSettings)
            // Additional: GetAuditReportAsync(GetAuditReportRequest, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetAuditReportRequest request = new GetAuditReportRequest
            {
                AuditReportName = AuditReportName.FromProjectLocationAuditReport("[PROJECT]", "[LOCATION]", "[AUDIT_REPORT]"),
            };
            // Make the request
            AuditReport response = await auditManagerClient.GetAuditReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuditReport</summary>
        public void GetAuditReport()
        {
            // Snippet: GetAuditReport(string, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/auditReports/[AUDIT_REPORT]";
            // Make the request
            AuditReport response = auditManagerClient.GetAuditReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuditReportAsync</summary>
        public async Task GetAuditReportAsync()
        {
            // Snippet: GetAuditReportAsync(string, CallSettings)
            // Additional: GetAuditReportAsync(string, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/auditReports/[AUDIT_REPORT]";
            // Make the request
            AuditReport response = await auditManagerClient.GetAuditReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuditReport</summary>
        public void GetAuditReportResourceNames()
        {
            // Snippet: GetAuditReport(AuditReportName, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            AuditReportName name = AuditReportName.FromProjectLocationAuditReport("[PROJECT]", "[LOCATION]", "[AUDIT_REPORT]");
            // Make the request
            AuditReport response = auditManagerClient.GetAuditReport(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuditReportAsync</summary>
        public async Task GetAuditReportResourceNamesAsync()
        {
            // Snippet: GetAuditReportAsync(AuditReportName, CallSettings)
            // Additional: GetAuditReportAsync(AuditReportName, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            AuditReportName name = AuditReportName.FromProjectLocationAuditReport("[PROJECT]", "[LOCATION]", "[AUDIT_REPORT]");
            // Make the request
            AuditReport response = await auditManagerClient.GetAuditReportAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceEnrollmentStatus</summary>
        public void GetResourceEnrollmentStatusRequestObject()
        {
            // Snippet: GetResourceEnrollmentStatus(GetResourceEnrollmentStatusRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            GetResourceEnrollmentStatusRequest request = new GetResourceEnrollmentStatusRequest
            {
                ResourceEnrollmentStatusName = ResourceEnrollmentStatusName.FromFolderLocationResourceEnrollmentStatus("[FOLDER]", "[LOCATION]", "[RESOURCE_ENROLLMENT_STATUS]"),
            };
            // Make the request
            ResourceEnrollmentStatus response = auditManagerClient.GetResourceEnrollmentStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceEnrollmentStatusAsync</summary>
        public async Task GetResourceEnrollmentStatusRequestObjectAsync()
        {
            // Snippet: GetResourceEnrollmentStatusAsync(GetResourceEnrollmentStatusRequest, CallSettings)
            // Additional: GetResourceEnrollmentStatusAsync(GetResourceEnrollmentStatusRequest, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetResourceEnrollmentStatusRequest request = new GetResourceEnrollmentStatusRequest
            {
                ResourceEnrollmentStatusName = ResourceEnrollmentStatusName.FromFolderLocationResourceEnrollmentStatus("[FOLDER]", "[LOCATION]", "[RESOURCE_ENROLLMENT_STATUS]"),
            };
            // Make the request
            ResourceEnrollmentStatus response = await auditManagerClient.GetResourceEnrollmentStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceEnrollmentStatus</summary>
        public void GetResourceEnrollmentStatus()
        {
            // Snippet: GetResourceEnrollmentStatus(string, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]/locations/[LOCATION]/resourceEnrollmentStatuses/[RESOURCE_ENROLLMENT_STATUS]";
            // Make the request
            ResourceEnrollmentStatus response = auditManagerClient.GetResourceEnrollmentStatus(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceEnrollmentStatusAsync</summary>
        public async Task GetResourceEnrollmentStatusAsync()
        {
            // Snippet: GetResourceEnrollmentStatusAsync(string, CallSettings)
            // Additional: GetResourceEnrollmentStatusAsync(string, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]/locations/[LOCATION]/resourceEnrollmentStatuses/[RESOURCE_ENROLLMENT_STATUS]";
            // Make the request
            ResourceEnrollmentStatus response = await auditManagerClient.GetResourceEnrollmentStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceEnrollmentStatus</summary>
        public void GetResourceEnrollmentStatusResourceNames()
        {
            // Snippet: GetResourceEnrollmentStatus(ResourceEnrollmentStatusName, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            ResourceEnrollmentStatusName name = ResourceEnrollmentStatusName.FromFolderLocationResourceEnrollmentStatus("[FOLDER]", "[LOCATION]", "[RESOURCE_ENROLLMENT_STATUS]");
            // Make the request
            ResourceEnrollmentStatus response = auditManagerClient.GetResourceEnrollmentStatus(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceEnrollmentStatusAsync</summary>
        public async Task GetResourceEnrollmentStatusResourceNamesAsync()
        {
            // Snippet: GetResourceEnrollmentStatusAsync(ResourceEnrollmentStatusName, CallSettings)
            // Additional: GetResourceEnrollmentStatusAsync(ResourceEnrollmentStatusName, CancellationToken)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            ResourceEnrollmentStatusName name = ResourceEnrollmentStatusName.FromFolderLocationResourceEnrollmentStatus("[FOLDER]", "[LOCATION]", "[RESOURCE_ENROLLMENT_STATUS]");
            // Make the request
            ResourceEnrollmentStatus response = await auditManagerClient.GetResourceEnrollmentStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListResourceEnrollmentStatuses</summary>
        public void ListResourceEnrollmentStatusesRequestObject()
        {
            // Snippet: ListResourceEnrollmentStatuses(ListResourceEnrollmentStatusesRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            ListResourceEnrollmentStatusesRequest request = new ListResourceEnrollmentStatusesRequest
            {
                ParentAsEnrollmentStatusScopeName = EnrollmentStatusScopeName.FromFolderLocation("[FOLDER]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> response = auditManagerClient.ListResourceEnrollmentStatuses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceEnrollmentStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceEnrollmentStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceEnrollmentStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceEnrollmentStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceEnrollmentStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceEnrollmentStatusesAsync</summary>
        public async Task ListResourceEnrollmentStatusesRequestObjectAsync()
        {
            // Snippet: ListResourceEnrollmentStatusesAsync(ListResourceEnrollmentStatusesRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListResourceEnrollmentStatusesRequest request = new ListResourceEnrollmentStatusesRequest
            {
                ParentAsEnrollmentStatusScopeName = EnrollmentStatusScopeName.FromFolderLocation("[FOLDER]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> response = auditManagerClient.ListResourceEnrollmentStatusesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceEnrollmentStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceEnrollmentStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceEnrollmentStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceEnrollmentStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceEnrollmentStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceEnrollmentStatuses</summary>
        public void ListResourceEnrollmentStatuses()
        {
            // Snippet: ListResourceEnrollmentStatuses(string, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            string parent = "folders/[FOLDER]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> response = auditManagerClient.ListResourceEnrollmentStatuses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceEnrollmentStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceEnrollmentStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceEnrollmentStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceEnrollmentStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceEnrollmentStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceEnrollmentStatusesAsync</summary>
        public async Task ListResourceEnrollmentStatusesAsync()
        {
            // Snippet: ListResourceEnrollmentStatusesAsync(string, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "folders/[FOLDER]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> response = auditManagerClient.ListResourceEnrollmentStatusesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceEnrollmentStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceEnrollmentStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceEnrollmentStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceEnrollmentStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceEnrollmentStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceEnrollmentStatuses</summary>
        public void ListResourceEnrollmentStatusesResourceNames()
        {
            // Snippet: ListResourceEnrollmentStatuses(EnrollmentStatusScopeName, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            EnrollmentStatusScopeName parent = EnrollmentStatusScopeName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> response = auditManagerClient.ListResourceEnrollmentStatuses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ResourceEnrollmentStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListResourceEnrollmentStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceEnrollmentStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceEnrollmentStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceEnrollmentStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceEnrollmentStatusesAsync</summary>
        public async Task ListResourceEnrollmentStatusesResourceNamesAsync()
        {
            // Snippet: ListResourceEnrollmentStatusesAsync(EnrollmentStatusScopeName, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            EnrollmentStatusScopeName parent = EnrollmentStatusScopeName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListResourceEnrollmentStatusesResponse, ResourceEnrollmentStatus> response = auditManagerClient.ListResourceEnrollmentStatusesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ResourceEnrollmentStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListResourceEnrollmentStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ResourceEnrollmentStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ResourceEnrollmentStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ResourceEnrollmentStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControls</summary>
        public void ListControlsRequestObject()
        {
            // Snippet: ListControls(ListControlsRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsStandardName = StandardName.FromProjectLocationStandard("[PROJECT]", "[LOCATION]", "[STANDARD]"),
            };
            // Make the request
            PagedEnumerable<ListControlsResponse, Control> response = auditManagerClient.ListControls(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlsAsync</summary>
        public async Task ListControlsRequestObjectAsync()
        {
            // Snippet: ListControlsAsync(ListControlsRequest, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListControlsRequest request = new ListControlsRequest
            {
                ParentAsStandardName = StandardName.FromProjectLocationStandard("[PROJECT]", "[LOCATION]", "[STANDARD]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListControlsResponse, Control> response = auditManagerClient.ListControlsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControls</summary>
        public void ListControls()
        {
            // Snippet: ListControls(string, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/standards/[STANDARD]";
            // Make the request
            PagedEnumerable<ListControlsResponse, Control> response = auditManagerClient.ListControls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlsAsync</summary>
        public async Task ListControlsAsync()
        {
            // Snippet: ListControlsAsync(string, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/standards/[STANDARD]";
            // Make the request
            PagedAsyncEnumerable<ListControlsResponse, Control> response = auditManagerClient.ListControlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControls</summary>
        public void ListControlsResourceNames()
        {
            // Snippet: ListControls(StandardName, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            StandardName parent = StandardName.FromProjectLocationStandard("[PROJECT]", "[LOCATION]", "[STANDARD]");
            // Make the request
            PagedEnumerable<ListControlsResponse, Control> response = auditManagerClient.ListControls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListControlsAsync</summary>
        public async Task ListControlsResourceNamesAsync()
        {
            // Snippet: ListControlsAsync(StandardName, string, int?, CallSettings)
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            StandardName parent = StandardName.FromProjectLocationStandard("[PROJECT]", "[LOCATION]", "[STANDARD]");
            // Make the request
            PagedAsyncEnumerable<ListControlsResponse, Control> response = auditManagerClient.ListControlsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Control item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListControlsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Control item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Control> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Control item in singlePage)
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
