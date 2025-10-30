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
    using Google.Cloud.CloudSecurityCompliance.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAuditClientSnippets
    {
        /// <summary>Snippet for GenerateFrameworkAuditScopeReport</summary>
        public void GenerateFrameworkAuditScopeReportRequestObject()
        {
            // Snippet: GenerateFrameworkAuditScopeReport(GenerateFrameworkAuditScopeReportRequest, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            GenerateFrameworkAuditScopeReportRequest request = new GenerateFrameworkAuditScopeReportRequest
            {
                Scope = "",
                ReportFormat = GenerateFrameworkAuditScopeReportRequest.Types.Format.Unspecified,
                ComplianceFramework = "",
            };
            // Make the request
            GenerateFrameworkAuditScopeReportResponse response = auditClient.GenerateFrameworkAuditScopeReport(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateFrameworkAuditScopeReportAsync</summary>
        public async Task GenerateFrameworkAuditScopeReportRequestObjectAsync()
        {
            // Snippet: GenerateFrameworkAuditScopeReportAsync(GenerateFrameworkAuditScopeReportRequest, CallSettings)
            // Additional: GenerateFrameworkAuditScopeReportAsync(GenerateFrameworkAuditScopeReportRequest, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            GenerateFrameworkAuditScopeReportRequest request = new GenerateFrameworkAuditScopeReportRequest
            {
                Scope = "",
                ReportFormat = GenerateFrameworkAuditScopeReportRequest.Types.Format.Unspecified,
                ComplianceFramework = "",
            };
            // Make the request
            GenerateFrameworkAuditScopeReportResponse response = await auditClient.GenerateFrameworkAuditScopeReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateFrameworkAuditScopeReport</summary>
        public void GenerateFrameworkAuditScopeReport()
        {
            // Snippet: GenerateFrameworkAuditScopeReport(string, GenerateFrameworkAuditScopeReportRequest.Types.Format, string, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            string scope = "";
            GenerateFrameworkAuditScopeReportRequest.Types.Format reportFormat = GenerateFrameworkAuditScopeReportRequest.Types.Format.Unspecified;
            string complianceFramework = "";
            // Make the request
            GenerateFrameworkAuditScopeReportResponse response = auditClient.GenerateFrameworkAuditScopeReport(scope, reportFormat, complianceFramework);
            // End snippet
        }

        /// <summary>Snippet for GenerateFrameworkAuditScopeReportAsync</summary>
        public async Task GenerateFrameworkAuditScopeReportAsync()
        {
            // Snippet: GenerateFrameworkAuditScopeReportAsync(string, GenerateFrameworkAuditScopeReportRequest.Types.Format, string, CallSettings)
            // Additional: GenerateFrameworkAuditScopeReportAsync(string, GenerateFrameworkAuditScopeReportRequest.Types.Format, string, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            string scope = "";
            GenerateFrameworkAuditScopeReportRequest.Types.Format reportFormat = GenerateFrameworkAuditScopeReportRequest.Types.Format.Unspecified;
            string complianceFramework = "";
            // Make the request
            GenerateFrameworkAuditScopeReportResponse response = await auditClient.GenerateFrameworkAuditScopeReportAsync(scope, reportFormat, complianceFramework);
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAudit</summary>
        public void CreateFrameworkAuditRequestObject()
        {
            // Snippet: CreateFrameworkAudit(CreateFrameworkAuditRequest, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            CreateFrameworkAuditRequest request = new CreateFrameworkAuditRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FrameworkAuditId = "",
                FrameworkAudit = new FrameworkAudit(),
            };
            // Make the request
            Operation<FrameworkAudit, OperationMetadata> response = auditClient.CreateFrameworkAudit(request);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkAudit, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FrameworkAudit result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkAudit, OperationMetadata> retrievedResponse = auditClient.PollOnceCreateFrameworkAudit(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkAudit retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAuditAsync</summary>
        public async Task CreateFrameworkAuditRequestObjectAsync()
        {
            // Snippet: CreateFrameworkAuditAsync(CreateFrameworkAuditRequest, CallSettings)
            // Additional: CreateFrameworkAuditAsync(CreateFrameworkAuditRequest, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            CreateFrameworkAuditRequest request = new CreateFrameworkAuditRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                FrameworkAuditId = "",
                FrameworkAudit = new FrameworkAudit(),
            };
            // Make the request
            Operation<FrameworkAudit, OperationMetadata> response = await auditClient.CreateFrameworkAuditAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkAudit, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FrameworkAudit result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkAudit, OperationMetadata> retrievedResponse = await auditClient.PollOnceCreateFrameworkAuditAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkAudit retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAudit</summary>
        public void CreateFrameworkAudit()
        {
            // Snippet: CreateFrameworkAudit(string, FrameworkAudit, string, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FrameworkAudit frameworkAudit = new FrameworkAudit();
            string frameworkAuditId = "";
            // Make the request
            Operation<FrameworkAudit, OperationMetadata> response = auditClient.CreateFrameworkAudit(parent, frameworkAudit, frameworkAuditId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkAudit, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FrameworkAudit result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkAudit, OperationMetadata> retrievedResponse = auditClient.PollOnceCreateFrameworkAudit(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkAudit retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAuditAsync</summary>
        public async Task CreateFrameworkAuditAsync()
        {
            // Snippet: CreateFrameworkAuditAsync(string, FrameworkAudit, string, CallSettings)
            // Additional: CreateFrameworkAuditAsync(string, FrameworkAudit, string, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FrameworkAudit frameworkAudit = new FrameworkAudit();
            string frameworkAuditId = "";
            // Make the request
            Operation<FrameworkAudit, OperationMetadata> response = await auditClient.CreateFrameworkAuditAsync(parent, frameworkAudit, frameworkAuditId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkAudit, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FrameworkAudit result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkAudit, OperationMetadata> retrievedResponse = await auditClient.PollOnceCreateFrameworkAuditAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkAudit retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAudit</summary>
        public void CreateFrameworkAuditResourceNames1()
        {
            // Snippet: CreateFrameworkAudit(LocationName, FrameworkAudit, string, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FrameworkAudit frameworkAudit = new FrameworkAudit();
            string frameworkAuditId = "";
            // Make the request
            Operation<FrameworkAudit, OperationMetadata> response = auditClient.CreateFrameworkAudit(parent, frameworkAudit, frameworkAuditId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkAudit, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FrameworkAudit result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkAudit, OperationMetadata> retrievedResponse = auditClient.PollOnceCreateFrameworkAudit(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkAudit retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAuditAsync</summary>
        public async Task CreateFrameworkAuditResourceNames1Async()
        {
            // Snippet: CreateFrameworkAuditAsync(LocationName, FrameworkAudit, string, CallSettings)
            // Additional: CreateFrameworkAuditAsync(LocationName, FrameworkAudit, string, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            FrameworkAudit frameworkAudit = new FrameworkAudit();
            string frameworkAuditId = "";
            // Make the request
            Operation<FrameworkAudit, OperationMetadata> response = await auditClient.CreateFrameworkAuditAsync(parent, frameworkAudit, frameworkAuditId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkAudit, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FrameworkAudit result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkAudit, OperationMetadata> retrievedResponse = await auditClient.PollOnceCreateFrameworkAuditAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkAudit retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAudit</summary>
        public void CreateFrameworkAuditResourceNames2()
        {
            // Snippet: CreateFrameworkAudit(OrganizationLocationName, FrameworkAudit, string, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            FrameworkAudit frameworkAudit = new FrameworkAudit();
            string frameworkAuditId = "";
            // Make the request
            Operation<FrameworkAudit, OperationMetadata> response = auditClient.CreateFrameworkAudit(parent, frameworkAudit, frameworkAuditId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkAudit, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FrameworkAudit result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkAudit, OperationMetadata> retrievedResponse = auditClient.PollOnceCreateFrameworkAudit(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkAudit retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFrameworkAuditAsync</summary>
        public async Task CreateFrameworkAuditResourceNames2Async()
        {
            // Snippet: CreateFrameworkAuditAsync(OrganizationLocationName, FrameworkAudit, string, CallSettings)
            // Additional: CreateFrameworkAuditAsync(OrganizationLocationName, FrameworkAudit, string, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            FrameworkAudit frameworkAudit = new FrameworkAudit();
            string frameworkAuditId = "";
            // Make the request
            Operation<FrameworkAudit, OperationMetadata> response = await auditClient.CreateFrameworkAuditAsync(parent, frameworkAudit, frameworkAuditId);

            // Poll until the returned long-running operation is complete
            Operation<FrameworkAudit, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            FrameworkAudit result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FrameworkAudit, OperationMetadata> retrievedResponse = await auditClient.PollOnceCreateFrameworkAuditAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FrameworkAudit retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkAudits</summary>
        public void ListFrameworkAuditsRequestObject()
        {
            // Snippet: ListFrameworkAudits(ListFrameworkAuditsRequest, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            ListFrameworkAuditsRequest request = new ListFrameworkAuditsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> response = auditClient.ListFrameworkAudits(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkAudit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkAuditsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkAudit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkAudit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkAudit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkAuditsAsync</summary>
        public async Task ListFrameworkAuditsRequestObjectAsync()
        {
            // Snippet: ListFrameworkAuditsAsync(ListFrameworkAuditsRequest, CallSettings)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            ListFrameworkAuditsRequest request = new ListFrameworkAuditsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> response = auditClient.ListFrameworkAuditsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkAudit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkAuditsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkAudit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkAudit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkAudit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkAudits</summary>
        public void ListFrameworkAudits()
        {
            // Snippet: ListFrameworkAudits(string, string, int?, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> response = auditClient.ListFrameworkAudits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkAudit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkAuditsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkAudit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkAudit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkAudit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkAuditsAsync</summary>
        public async Task ListFrameworkAuditsAsync()
        {
            // Snippet: ListFrameworkAuditsAsync(string, string, int?, CallSettings)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> response = auditClient.ListFrameworkAuditsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkAudit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkAuditsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkAudit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkAudit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkAudit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkAudits</summary>
        public void ListFrameworkAuditsResourceNames1()
        {
            // Snippet: ListFrameworkAudits(LocationName, string, int?, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> response = auditClient.ListFrameworkAudits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkAudit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkAuditsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkAudit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkAudit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkAudit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkAuditsAsync</summary>
        public async Task ListFrameworkAuditsResourceNames1Async()
        {
            // Snippet: ListFrameworkAuditsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> response = auditClient.ListFrameworkAuditsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkAudit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkAuditsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkAudit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkAudit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkAudit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkAudits</summary>
        public void ListFrameworkAuditsResourceNames2()
        {
            // Snippet: ListFrameworkAudits(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> response = auditClient.ListFrameworkAudits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FrameworkAudit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFrameworkAuditsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkAudit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkAudit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkAudit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFrameworkAuditsAsync</summary>
        public async Task ListFrameworkAuditsResourceNames2Async()
        {
            // Snippet: ListFrameworkAuditsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListFrameworkAuditsResponse, FrameworkAudit> response = auditClient.ListFrameworkAuditsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FrameworkAudit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFrameworkAuditsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FrameworkAudit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FrameworkAudit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FrameworkAudit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAudit</summary>
        public void GetFrameworkAuditRequestObject()
        {
            // Snippet: GetFrameworkAudit(GetFrameworkAuditRequest, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            GetFrameworkAuditRequest request = new GetFrameworkAuditRequest
            {
                FrameworkAuditName = FrameworkAuditName.FromProjectLocationFrameworkAudit("[PROJECT]", "[LOCATION]", "[FRAMEWORK_AUDIT]"),
            };
            // Make the request
            FrameworkAudit response = auditClient.GetFrameworkAudit(request);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAuditAsync</summary>
        public async Task GetFrameworkAuditRequestObjectAsync()
        {
            // Snippet: GetFrameworkAuditAsync(GetFrameworkAuditRequest, CallSettings)
            // Additional: GetFrameworkAuditAsync(GetFrameworkAuditRequest, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            GetFrameworkAuditRequest request = new GetFrameworkAuditRequest
            {
                FrameworkAuditName = FrameworkAuditName.FromProjectLocationFrameworkAudit("[PROJECT]", "[LOCATION]", "[FRAMEWORK_AUDIT]"),
            };
            // Make the request
            FrameworkAudit response = await auditClient.GetFrameworkAuditAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAudit</summary>
        public void GetFrameworkAudit()
        {
            // Snippet: GetFrameworkAudit(string, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/frameworkAudits/[FRAMEWORK_AUDIT]";
            // Make the request
            FrameworkAudit response = auditClient.GetFrameworkAudit(name);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAuditAsync</summary>
        public async Task GetFrameworkAuditAsync()
        {
            // Snippet: GetFrameworkAuditAsync(string, CallSettings)
            // Additional: GetFrameworkAuditAsync(string, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/frameworkAudits/[FRAMEWORK_AUDIT]";
            // Make the request
            FrameworkAudit response = await auditClient.GetFrameworkAuditAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAudit</summary>
        public void GetFrameworkAuditResourceNames()
        {
            // Snippet: GetFrameworkAudit(FrameworkAuditName, CallSettings)
            // Create client
            AuditClient auditClient = AuditClient.Create();
            // Initialize request argument(s)
            FrameworkAuditName name = FrameworkAuditName.FromProjectLocationFrameworkAudit("[PROJECT]", "[LOCATION]", "[FRAMEWORK_AUDIT]");
            // Make the request
            FrameworkAudit response = auditClient.GetFrameworkAudit(name);
            // End snippet
        }

        /// <summary>Snippet for GetFrameworkAuditAsync</summary>
        public async Task GetFrameworkAuditResourceNamesAsync()
        {
            // Snippet: GetFrameworkAuditAsync(FrameworkAuditName, CallSettings)
            // Additional: GetFrameworkAuditAsync(FrameworkAuditName, CancellationToken)
            // Create client
            AuditClient auditClient = await AuditClient.CreateAsync();
            // Initialize request argument(s)
            FrameworkAuditName name = FrameworkAuditName.FromProjectLocationFrameworkAudit("[PROJECT]", "[LOCATION]", "[FRAMEWORK_AUDIT]");
            // Make the request
            FrameworkAudit response = await auditClient.GetFrameworkAuditAsync(name);
            // End snippet
        }
    }
}
