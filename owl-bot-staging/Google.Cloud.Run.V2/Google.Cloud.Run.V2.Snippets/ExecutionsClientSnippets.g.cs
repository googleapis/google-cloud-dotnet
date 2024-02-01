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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedExecutionsClientSnippets
    {
        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionRequestObject()
        {
            // Snippet: GetExecution(GetExecutionRequest, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            gcrv::GetExecutionRequest request = new gcrv::GetExecutionRequest
            {
                ExecutionName = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
            };
            // Make the request
            gcrv::Execution response = executionsClient.GetExecution(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionRequestObjectAsync()
        {
            // Snippet: GetExecutionAsync(GetExecutionRequest, CallSettings)
            // Additional: GetExecutionAsync(GetExecutionRequest, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::GetExecutionRequest request = new gcrv::GetExecutionRequest
            {
                ExecutionName = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
            };
            // Make the request
            gcrv::Execution response = await executionsClient.GetExecutionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecution()
        {
            // Snippet: GetExecution(string, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/executions/[EXECUTION]";
            // Make the request
            gcrv::Execution response = executionsClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionAsync()
        {
            // Snippet: GetExecutionAsync(string, CallSettings)
            // Additional: GetExecutionAsync(string, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/executions/[EXECUTION]";
            // Make the request
            gcrv::Execution response = await executionsClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecution</summary>
        public void GetExecutionResourceNames()
        {
            // Snippet: GetExecution(ExecutionName, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            gcrv::ExecutionName name = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]");
            // Make the request
            gcrv::Execution response = executionsClient.GetExecution(name);
            // End snippet
        }

        /// <summary>Snippet for GetExecutionAsync</summary>
        public async Task GetExecutionResourceNamesAsync()
        {
            // Snippet: GetExecutionAsync(ExecutionName, CallSettings)
            // Additional: GetExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ExecutionName name = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]");
            // Make the request
            gcrv::Execution response = await executionsClient.GetExecutionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListExecutions</summary>
        public void ListExecutionsRequestObject()
        {
            // Snippet: ListExecutions(ListExecutionsRequest, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            gcrv::ListExecutionsRequest request = new gcrv::ListExecutionsRequest
            {
                ParentAsJobName = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<gcrv::ListExecutionsResponse, gcrv::Execution> response = executionsClient.ListExecutions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Execution item in singlePage)
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
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ListExecutionsRequest request = new gcrv::ListExecutionsRequest
            {
                ParentAsJobName = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<gcrv::ListExecutionsResponse, gcrv::Execution> response = executionsClient.ListExecutionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Execution item in singlePage)
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
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            PagedEnumerable<gcrv::ListExecutionsResponse, gcrv::Execution> response = executionsClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Execution item in singlePage)
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
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            PagedAsyncEnumerable<gcrv::ListExecutionsResponse, gcrv::Execution> response = executionsClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Execution item in singlePage)
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
            // Snippet: ListExecutions(JobName, string, int?, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            gcrv::JobName parent = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            PagedEnumerable<gcrv::ListExecutionsResponse, gcrv::Execution> response = executionsClient.ListExecutions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Execution item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListExecutionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Execution> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Execution item in singlePage)
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
            // Snippet: ListExecutionsAsync(JobName, string, int?, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::JobName parent = gcrv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            PagedAsyncEnumerable<gcrv::ListExecutionsResponse, gcrv::Execution> response = executionsClient.ListExecutionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Execution item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListExecutionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Execution item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Execution> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Execution item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionRequestObject()
        {
            // Snippet: DeleteExecution(DeleteExecutionRequest, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            gcrv::DeleteExecutionRequest request = new gcrv::DeleteExecutionRequest
            {
                ExecutionName = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = executionsClient.DeleteExecution(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = executionsClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionRequestObjectAsync()
        {
            // Snippet: DeleteExecutionAsync(DeleteExecutionRequest, CallSettings)
            // Additional: DeleteExecutionAsync(DeleteExecutionRequest, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::DeleteExecutionRequest request = new gcrv::DeleteExecutionRequest
            {
                ExecutionName = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await executionsClient.DeleteExecutionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await executionsClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecution()
        {
            // Snippet: DeleteExecution(string, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/executions/[EXECUTION]";
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = executionsClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = executionsClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionAsync()
        {
            // Snippet: DeleteExecutionAsync(string, CallSettings)
            // Additional: DeleteExecutionAsync(string, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/executions/[EXECUTION]";
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await executionsClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await executionsClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecution</summary>
        public void DeleteExecutionResourceNames()
        {
            // Snippet: DeleteExecution(ExecutionName, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            gcrv::ExecutionName name = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]");
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = executionsClient.DeleteExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = executionsClient.PollOnceDeleteExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExecutionAsync</summary>
        public async Task DeleteExecutionResourceNamesAsync()
        {
            // Snippet: DeleteExecutionAsync(ExecutionName, CallSettings)
            // Additional: DeleteExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ExecutionName name = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]");
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await executionsClient.DeleteExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await executionsClient.PollOnceDeleteExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelExecution</summary>
        public void CancelExecutionRequestObject()
        {
            // Snippet: CancelExecution(CancelExecutionRequest, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            gcrv::CancelExecutionRequest request = new gcrv::CancelExecutionRequest
            {
                ExecutionName = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = executionsClient.CancelExecution(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = executionsClient.PollOnceCancelExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelExecutionAsync</summary>
        public async Task CancelExecutionRequestObjectAsync()
        {
            // Snippet: CancelExecutionAsync(CancelExecutionRequest, CallSettings)
            // Additional: CancelExecutionAsync(CancelExecutionRequest, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::CancelExecutionRequest request = new gcrv::CancelExecutionRequest
            {
                ExecutionName = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await executionsClient.CancelExecutionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await executionsClient.PollOnceCancelExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelExecution</summary>
        public void CancelExecution()
        {
            // Snippet: CancelExecution(string, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/executions/[EXECUTION]";
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = executionsClient.CancelExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = executionsClient.PollOnceCancelExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelExecutionAsync</summary>
        public async Task CancelExecutionAsync()
        {
            // Snippet: CancelExecutionAsync(string, CallSettings)
            // Additional: CancelExecutionAsync(string, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/executions/[EXECUTION]";
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await executionsClient.CancelExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await executionsClient.PollOnceCancelExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelExecution</summary>
        public void CancelExecutionResourceNames()
        {
            // Snippet: CancelExecution(ExecutionName, CallSettings)
            // Create client
            gcrv::ExecutionsClient executionsClient = gcrv::ExecutionsClient.Create();
            // Initialize request argument(s)
            gcrv::ExecutionName name = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]");
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = executionsClient.CancelExecution(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = executionsClient.PollOnceCancelExecution(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelExecutionAsync</summary>
        public async Task CancelExecutionResourceNamesAsync()
        {
            // Snippet: CancelExecutionAsync(ExecutionName, CallSettings)
            // Additional: CancelExecutionAsync(ExecutionName, CancellationToken)
            // Create client
            gcrv::ExecutionsClient executionsClient = await gcrv::ExecutionsClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ExecutionName name = gcrv::ExecutionName.FromProjectLocationJobExecution("[PROJECT]", "[LOCATION]", "[JOB]", "[EXECUTION]");
            // Make the request
            Operation<gcrv::Execution, gcrv::Execution> response = await executionsClient.CancelExecutionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Execution, gcrv::Execution> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Execution result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Execution, gcrv::Execution> retrievedResponse = await executionsClient.PollOnceCancelExecutionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Execution retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
