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
    using Google.Cloud.Workflows.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWorkflowsClientSnippets
    {
        /// <summary>Snippet for ListWorkflows</summary>
        public void ListWorkflowsRequestObject()
        {
            // Snippet: ListWorkflows(ListWorkflowsRequest, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            ListWorkflowsRequest request = new ListWorkflowsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListWorkflowsResponse, Workflow> response = workflowsClient.ListWorkflows(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workflow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkflowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workflow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowsAsync</summary>
        public async Task ListWorkflowsRequestObjectAsync()
        {
            // Snippet: ListWorkflowsAsync(ListWorkflowsRequest, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkflowsRequest request = new ListWorkflowsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkflowsResponse, Workflow> response = workflowsClient.ListWorkflowsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workflow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkflowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workflow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflows</summary>
        public void ListWorkflows()
        {
            // Snippet: ListWorkflows(string, string, int?, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListWorkflowsResponse, Workflow> response = workflowsClient.ListWorkflows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workflow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkflowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workflow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowsAsync</summary>
        public async Task ListWorkflowsAsync()
        {
            // Snippet: ListWorkflowsAsync(string, string, int?, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListWorkflowsResponse, Workflow> response = workflowsClient.ListWorkflowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workflow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkflowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workflow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflows</summary>
        public void ListWorkflowsResourceNames()
        {
            // Snippet: ListWorkflows(LocationName, string, int?, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListWorkflowsResponse, Workflow> response = workflowsClient.ListWorkflows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workflow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkflowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workflow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkflowsAsync</summary>
        public async Task ListWorkflowsResourceNamesAsync()
        {
            // Snippet: ListWorkflowsAsync(LocationName, string, int?, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListWorkflowsResponse, Workflow> response = workflowsClient.ListWorkflowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workflow item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkflowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workflow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workflow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workflow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetWorkflow</summary>
        public void GetWorkflowRequestObject()
        {
            // Snippet: GetWorkflow(GetWorkflowRequest, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            GetWorkflowRequest request = new GetWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                RevisionId = "",
            };
            // Make the request
            Workflow response = workflowsClient.GetWorkflow(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowAsync</summary>
        public async Task GetWorkflowRequestObjectAsync()
        {
            // Snippet: GetWorkflowAsync(GetWorkflowRequest, CallSettings)
            // Additional: GetWorkflowAsync(GetWorkflowRequest, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkflowRequest request = new GetWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
                RevisionId = "",
            };
            // Make the request
            Workflow response = await workflowsClient.GetWorkflowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflow</summary>
        public void GetWorkflow()
        {
            // Snippet: GetWorkflow(string, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            Workflow response = workflowsClient.GetWorkflow(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowAsync</summary>
        public async Task GetWorkflowAsync()
        {
            // Snippet: GetWorkflowAsync(string, CallSettings)
            // Additional: GetWorkflowAsync(string, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            Workflow response = await workflowsClient.GetWorkflowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflow</summary>
        public void GetWorkflowResourceNames()
        {
            // Snippet: GetWorkflow(WorkflowName, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            WorkflowName name = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            Workflow response = workflowsClient.GetWorkflow(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkflowAsync</summary>
        public async Task GetWorkflowResourceNamesAsync()
        {
            // Snippet: GetWorkflowAsync(WorkflowName, CallSettings)
            // Additional: GetWorkflowAsync(WorkflowName, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowName name = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            Workflow response = await workflowsClient.GetWorkflowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflow</summary>
        public void CreateWorkflowRequestObject()
        {
            // Snippet: CreateWorkflow(CreateWorkflowRequest, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            CreateWorkflowRequest request = new CreateWorkflowRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Workflow = new Workflow(),
                WorkflowId = "",
            };
            // Make the request
            Operation<Workflow, OperationMetadata> response = workflowsClient.CreateWorkflow(request);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = workflowsClient.PollOnceCreateWorkflow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowAsync</summary>
        public async Task CreateWorkflowRequestObjectAsync()
        {
            // Snippet: CreateWorkflowAsync(CreateWorkflowRequest, CallSettings)
            // Additional: CreateWorkflowAsync(CreateWorkflowRequest, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkflowRequest request = new CreateWorkflowRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Workflow = new Workflow(),
                WorkflowId = "",
            };
            // Make the request
            Operation<Workflow, OperationMetadata> response = await workflowsClient.CreateWorkflowAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceCreateWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflow</summary>
        public void CreateWorkflow()
        {
            // Snippet: CreateWorkflow(string, Workflow, string, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Workflow workflow = new Workflow();
            string workflowId = "";
            // Make the request
            Operation<Workflow, OperationMetadata> response = workflowsClient.CreateWorkflow(parent, workflow, workflowId);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = workflowsClient.PollOnceCreateWorkflow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowAsync</summary>
        public async Task CreateWorkflowAsync()
        {
            // Snippet: CreateWorkflowAsync(string, Workflow, string, CallSettings)
            // Additional: CreateWorkflowAsync(string, Workflow, string, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Workflow workflow = new Workflow();
            string workflowId = "";
            // Make the request
            Operation<Workflow, OperationMetadata> response = await workflowsClient.CreateWorkflowAsync(parent, workflow, workflowId);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceCreateWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflow</summary>
        public void CreateWorkflowResourceNames()
        {
            // Snippet: CreateWorkflow(LocationName, Workflow, string, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Workflow workflow = new Workflow();
            string workflowId = "";
            // Make the request
            Operation<Workflow, OperationMetadata> response = workflowsClient.CreateWorkflow(parent, workflow, workflowId);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = workflowsClient.PollOnceCreateWorkflow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkflowAsync</summary>
        public async Task CreateWorkflowResourceNamesAsync()
        {
            // Snippet: CreateWorkflowAsync(LocationName, Workflow, string, CallSettings)
            // Additional: CreateWorkflowAsync(LocationName, Workflow, string, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Workflow workflow = new Workflow();
            string workflowId = "";
            // Make the request
            Operation<Workflow, OperationMetadata> response = await workflowsClient.CreateWorkflowAsync(parent, workflow, workflowId);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceCreateWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflow</summary>
        public void DeleteWorkflowRequestObject()
        {
            // Snippet: DeleteWorkflow(DeleteWorkflowRequest, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            DeleteWorkflowRequest request = new DeleteWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = workflowsClient.DeleteWorkflow(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workflowsClient.PollOnceDeleteWorkflow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowAsync</summary>
        public async Task DeleteWorkflowRequestObjectAsync()
        {
            // Snippet: DeleteWorkflowAsync(DeleteWorkflowRequest, CallSettings)
            // Additional: DeleteWorkflowAsync(DeleteWorkflowRequest, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkflowRequest request = new DeleteWorkflowRequest
            {
                WorkflowName = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await workflowsClient.DeleteWorkflowAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceDeleteWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflow</summary>
        public void DeleteWorkflow()
        {
            // Snippet: DeleteWorkflow(string, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            Operation<Empty, OperationMetadata> response = workflowsClient.DeleteWorkflow(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workflowsClient.PollOnceDeleteWorkflow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowAsync</summary>
        public async Task DeleteWorkflowAsync()
        {
            // Snippet: DeleteWorkflowAsync(string, CallSettings)
            // Additional: DeleteWorkflowAsync(string, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await workflowsClient.DeleteWorkflowAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceDeleteWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflow</summary>
        public void DeleteWorkflowResourceNames()
        {
            // Snippet: DeleteWorkflow(WorkflowName, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            WorkflowName name = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            Operation<Empty, OperationMetadata> response = workflowsClient.DeleteWorkflow(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = workflowsClient.PollOnceDeleteWorkflow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkflowAsync</summary>
        public async Task DeleteWorkflowResourceNamesAsync()
        {
            // Snippet: DeleteWorkflowAsync(WorkflowName, CallSettings)
            // Additional: DeleteWorkflowAsync(WorkflowName, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            WorkflowName name = WorkflowName.FromProjectLocationWorkflow("[PROJECT]", "[LOCATION]", "[WORKFLOW]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await workflowsClient.DeleteWorkflowAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceDeleteWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflow</summary>
        public void UpdateWorkflowRequestObject()
        {
            // Snippet: UpdateWorkflow(UpdateWorkflowRequest, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            UpdateWorkflowRequest request = new UpdateWorkflowRequest
            {
                Workflow = new Workflow(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Workflow, OperationMetadata> response = workflowsClient.UpdateWorkflow(request);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = workflowsClient.PollOnceUpdateWorkflow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowAsync</summary>
        public async Task UpdateWorkflowRequestObjectAsync()
        {
            // Snippet: UpdateWorkflowAsync(UpdateWorkflowRequest, CallSettings)
            // Additional: UpdateWorkflowAsync(UpdateWorkflowRequest, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkflowRequest request = new UpdateWorkflowRequest
            {
                Workflow = new Workflow(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Workflow, OperationMetadata> response = await workflowsClient.UpdateWorkflowAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceUpdateWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflow</summary>
        public void UpdateWorkflow()
        {
            // Snippet: UpdateWorkflow(Workflow, FieldMask, CallSettings)
            // Create client
            WorkflowsClient workflowsClient = WorkflowsClient.Create();
            // Initialize request argument(s)
            Workflow workflow = new Workflow();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Workflow, OperationMetadata> response = workflowsClient.UpdateWorkflow(workflow, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = workflowsClient.PollOnceUpdateWorkflow(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkflowAsync</summary>
        public async Task UpdateWorkflowAsync()
        {
            // Snippet: UpdateWorkflowAsync(Workflow, FieldMask, CallSettings)
            // Additional: UpdateWorkflowAsync(Workflow, FieldMask, CancellationToken)
            // Create client
            WorkflowsClient workflowsClient = await WorkflowsClient.CreateAsync();
            // Initialize request argument(s)
            Workflow workflow = new Workflow();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Workflow, OperationMetadata> response = await workflowsClient.UpdateWorkflowAsync(workflow, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Workflow, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workflow result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workflow, OperationMetadata> retrievedResponse = await workflowsClient.PollOnceUpdateWorkflowAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workflow retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
