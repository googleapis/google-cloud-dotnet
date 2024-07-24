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
    using Google.Cloud.Workflows.Executions.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedExecutionsClientSnippets
    {
        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsRequestObject()
        {
            // Snippet: ListExecutions(ListExecutionsRequest, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                View = ExecutionView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = executionsClient.ListExecutions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsRequestObjectAsync()
        {
            // Snippet: ListExecutionsAsync(ListExecutionsRequest, CallSettings)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                View = ExecutionView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = executionsClient.ListExecutionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutions()
        {
            // Snippet: ListExecutions(string, string, int?, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = executionsClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsAsync()
        {
            // Snippet: ListExecutionsAsync(string, string, int?, CallSettings)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = executionsClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsResourceNames()
        {
            // Snippet: ListExecutions(WorkflowName, string, int?, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            WorkflowName parent = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            PagedEnumerable<ListExecutionsResponse, Execution> response = executionsClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExecutionsAsync</summary>
        public async Task ListExecutionsResourceNamesAsync()
        {
            // Snippet: ListExecutionsAsync(WorkflowName, string, int?, CallSettings)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowName parent = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            PagedAsyncEnumerable<ListExecutionsResponse, Execution> response = executionsClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecutionRequestObject()
        {
            // Snippet: CreateExecution(CreateExecutionRequest, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Execution = new Execution(),
            };
            // Make the request
            Execution response = executionsClient.CreateExecution(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionRequestObjectAsync()
        {
            // Snippet: CreateExecutionAsync(CreateExecutionRequest, CallSettings)
            // Additional: CreateExecutionAsync(CreateExecutionRequest, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            CreateExecutionRequest request = new CreateExecutionRequest
            {
                ParentAsWorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                Execution = new Execution(),
            };
            // Make the request
            Execution response = await executionsClient.CreateExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecution()
        {
            // Snippet: CreateExecution(string, Execution, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            Execution execution = new Execution();
            // Make the request
            Execution response = executionsClient.CreateExecution(parent, execution);
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionAsync()
        {
            // Snippet: CreateExecutionAsync(string, Execution, CallSettings)
            // Additional: CreateExecutionAsync(string, Execution, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            Execution execution = new Execution();
            // Make the request
            Execution response = await executionsClient.CreateExecutionAsync(parent, execution);
            // End snippet
        }

        /// <summary>Snippet for CreateExecution</summary>
        public void CreateExecutionResourceNames()
        {
            // Snippet: CreateExecution(WorkflowName, Execution, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            WorkflowName parent = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            Execution execution = new Execution();
            // Make the request
            Execution response = executionsClient.CreateExecution(parent, execution);
            // End snippet
        }

        /// <summary>Snippet for CreateExecutionAsync</summary>
        public async Task CreateExecutionResourceNamesAsync()
        {
            // Snippet: CreateExecutionAsync(WorkflowName, Execution, CallSettings)
            // Additional: CreateExecutionAsync(WorkflowName, Execution, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowName parent = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            Execution execution = new Execution();
            // Make the request
            Execution response = await executionsClient.CreateExecutionAsync(parent, execution);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionRequestObject()
        {
            // Snippet: GetExecution(GetExecutionRequest, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                View = ExecutionView.Unspecified,
            };
            // Make the request
            Execution response = executionsClient.GetExecution(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionRequestObjectAsync()
        {
            // Snippet: GetExecutionAsync(GetExecutionRequest, CallSettings)
            // Additional: GetExecutionAsync(GetExecutionRequest, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            GetExecutionRequest request = new GetExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
                View = ExecutionView.Unspecified,
            };
            // Make the request
            Execution response = await executionsClient.GetExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecution()
        {
            // Snippet: GetExecution(string, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]/executions/[EXECUTION]";
            // Make the request
            Execution response = executionsClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionAsync()
        {
            // Snippet: GetExecutionAsync(string, CallSettings)
            // Additional: GetExecutionAsync(string, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]/executions/[EXECUTION]";
            // Make the request
            Execution response = await executionsClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionResourceNames()
        {
            // Snippet: GetExecution(ExecutionName, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]");
            // Make the request
            Execution response = executionsClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionResourceNamesAsync()
        {
            // Snippet: GetExecutionAsync(ExecutionName, CallSettings)
            // Additional: GetExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]");
            // Make the request
            Execution response = await executionsClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelExecution</summary>
        public void CancelExecutionRequestObject()
        {
            // Snippet: CancelExecution(CancelExecutionRequest, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            CancelExecutionRequest request = new CancelExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            // Make the request
            Execution response = executionsClient.CancelExecution(request);
            // End snippet
        }

        /// <summary>Snippet for CancelExecutionAsync</summary>
        public async Task CancelExecutionRequestObjectAsync()
        {
            // Snippet: CancelExecutionAsync(CancelExecutionRequest, CallSettings)
            // Additional: CancelExecutionAsync(CancelExecutionRequest, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            CancelExecutionRequest request = new CancelExecutionRequest
            {
                ExecutionName = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]"),
            };
            // Make the request
            Execution response = await executionsClient.CancelExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelExecution</summary>
        public void CancelExecution()
        {
            // Snippet: CancelExecution(string, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]/executions/[EXECUTION]";
            // Make the request
            Execution response = executionsClient.CancelExecution(name);
            // End snippet
        }

        /// <summary>Snippet for CancelExecutionAsync</summary>
        public async Task CancelExecutionAsync()
        {
            // Snippet: CancelExecutionAsync(string, CallSettings)
            // Additional: CancelExecutionAsync(string, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]/executions/[EXECUTION]";
            // Make the request
            Execution response = await executionsClient.CancelExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelExecution</summary>
        public void CancelExecutionResourceNames()
        {
            // Snippet: CancelExecution(ExecutionName, CallSettings)
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]");
            // Make the request
            Execution response = executionsClient.CancelExecution(name);
            // End snippet
        }

        /// <summary>Snippet for CancelExecutionAsync</summary>
        public async Task CancelExecutionResourceNamesAsync()
        {
            // Snippet: CancelExecutionAsync(ExecutionName, CallSettings)
            // Additional: CancelExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            ExecutionsClient executionsClient = await ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            ExecutionName name = ExecutionName.FromProjectLocationWorkflowExecution("[PROJECT]", "[LOCATION]", "[WORKFLOW]", "[EXECUTION]");
            // Make the request
            Execution response = await executionsClient.CancelExecutionAsync(name);
            // End snippet
        }
    }
}
