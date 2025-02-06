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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcoasv = Google.Cloud.Orchestration.Airflow.Service.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEnvironmentsClientSnippets
    {
        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironmentRequestObject()
        {
            // Snippet: CreateEnvironment(CreateEnvironmentRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::CreateEnvironmentRequest request = new gcoasv::CreateEnvironmentRequest
            {
                Parent = "",
                Environment = new gcoasv::Environment(),
            };
            // Make the request
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> response = environmentsClient.CreateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcoasv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentRequestObjectAsync()
        {
            // Snippet: CreateEnvironmentAsync(CreateEnvironmentRequest, CallSettings)
            // Additional: CreateEnvironmentAsync(CreateEnvironmentRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::CreateEnvironmentRequest request = new gcoasv::CreateEnvironmentRequest
            {
                Parent = "",
                Environment = new gcoasv::Environment(),
            };
            // Make the request
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> response = await environmentsClient.CreateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcoasv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironment()
        {
            // Snippet: CreateEnvironment(string, Environment, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            gcoasv::Environment environment = new gcoasv::Environment();
            // Make the request
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> response = environmentsClient.CreateEnvironment(parent, environment);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcoasv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentAsync()
        {
            // Snippet: CreateEnvironmentAsync(string, Environment, CallSettings)
            // Additional: CreateEnvironmentAsync(string, Environment, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            gcoasv::Environment environment = new gcoasv::Environment();
            // Make the request
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> response = await environmentsClient.CreateEnvironmentAsync(parent, environment);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcoasv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentRequestObject()
        {
            // Snippet: GetEnvironment(GetEnvironmentRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::GetEnvironmentRequest request = new gcoasv::GetEnvironmentRequest { Name = "", };
            // Make the request
            gcoasv::Environment response = environmentsClient.GetEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentRequestObjectAsync()
        {
            // Snippet: GetEnvironmentAsync(GetEnvironmentRequest, CallSettings)
            // Additional: GetEnvironmentAsync(GetEnvironmentRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::GetEnvironmentRequest request = new gcoasv::GetEnvironmentRequest { Name = "", };
            // Make the request
            gcoasv::Environment response = await environmentsClient.GetEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironment()
        {
            // Snippet: GetEnvironment(string, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcoasv::Environment response = environmentsClient.GetEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentAsync()
        {
            // Snippet: GetEnvironmentAsync(string, CallSettings)
            // Additional: GetEnvironmentAsync(string, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            gcoasv::Environment response = await environmentsClient.GetEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsRequestObject()
        {
            // Snippet: ListEnvironments(ListEnvironmentsRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::ListEnvironmentsRequest request = new gcoasv::ListEnvironmentsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<gcoasv::ListEnvironmentsResponse, gcoasv::Environment> response = environmentsClient.ListEnvironments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsRequestObjectAsync()
        {
            // Snippet: ListEnvironmentsAsync(ListEnvironmentsRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::ListEnvironmentsRequest request = new gcoasv::ListEnvironmentsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListEnvironmentsResponse, gcoasv::Environment> response = environmentsClient.ListEnvironmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironments()
        {
            // Snippet: ListEnvironments(string, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<gcoasv::ListEnvironmentsResponse, gcoasv::Environment> response = environmentsClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsAsync()
        {
            // Snippet: ListEnvironmentsAsync(string, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListEnvironmentsResponse, gcoasv::Environment> response = environmentsClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironment</summary>
        public void UpdateEnvironmentRequestObject()
        {
            // Snippet: UpdateEnvironment(UpdateEnvironmentRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UpdateEnvironmentRequest request = new gcoasv::UpdateEnvironmentRequest
            {
                Environment = new gcoasv::Environment(),
                Name = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> response = environmentsClient.UpdateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcoasv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceUpdateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironmentAsync</summary>
        public async Task UpdateEnvironmentRequestObjectAsync()
        {
            // Snippet: UpdateEnvironmentAsync(UpdateEnvironmentRequest, CallSettings)
            // Additional: UpdateEnvironmentAsync(UpdateEnvironmentRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UpdateEnvironmentRequest request = new gcoasv::UpdateEnvironmentRequest
            {
                Environment = new gcoasv::Environment(),
                Name = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> response = await environmentsClient.UpdateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcoasv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceUpdateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironment</summary>
        public void UpdateEnvironment()
        {
            // Snippet: UpdateEnvironment(string, Environment, FieldMask, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "";
            gcoasv::Environment environment = new gcoasv::Environment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> response = environmentsClient.UpdateEnvironment(name, environment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcoasv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceUpdateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironmentAsync</summary>
        public async Task UpdateEnvironmentAsync()
        {
            // Snippet: UpdateEnvironmentAsync(string, Environment, FieldMask, CallSettings)
            // Additional: UpdateEnvironmentAsync(string, Environment, FieldMask, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            gcoasv::Environment environment = new gcoasv::Environment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> response = await environmentsClient.UpdateEnvironmentAsync(name, environment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcoasv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::Environment, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceUpdateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironmentRequestObject()
        {
            // Snippet: DeleteEnvironment(DeleteEnvironmentRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::DeleteEnvironmentRequest request = new gcoasv::DeleteEnvironmentRequest { Name = "", };
            // Make the request
            Operation<Empty, gcoasv::OperationMetadata> response = environmentsClient.DeleteEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceDeleteEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentRequestObjectAsync()
        {
            // Snippet: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CallSettings)
            // Additional: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::DeleteEnvironmentRequest request = new gcoasv::DeleteEnvironmentRequest { Name = "", };
            // Make the request
            Operation<Empty, gcoasv::OperationMetadata> response = await environmentsClient.DeleteEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceDeleteEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironment()
        {
            // Snippet: DeleteEnvironment(string, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcoasv::OperationMetadata> response = environmentsClient.DeleteEnvironment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceDeleteEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentAsync()
        {
            // Snippet: DeleteEnvironmentAsync(string, CallSettings)
            // Additional: DeleteEnvironmentAsync(string, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcoasv::OperationMetadata> response = await environmentsClient.DeleteEnvironmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceDeleteEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecuteAirflowCommand</summary>
        public void ExecuteAirflowCommandRequestObject()
        {
            // Snippet: ExecuteAirflowCommand(ExecuteAirflowCommandRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::ExecuteAirflowCommandRequest request = new gcoasv::ExecuteAirflowCommandRequest
            {
                Environment = "",
                Command = "",
                Subcommand = "",
                Parameters = { "", },
            };
            // Make the request
            gcoasv::ExecuteAirflowCommandResponse response = environmentsClient.ExecuteAirflowCommand(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteAirflowCommandAsync</summary>
        public async Task ExecuteAirflowCommandRequestObjectAsync()
        {
            // Snippet: ExecuteAirflowCommandAsync(ExecuteAirflowCommandRequest, CallSettings)
            // Additional: ExecuteAirflowCommandAsync(ExecuteAirflowCommandRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::ExecuteAirflowCommandRequest request = new gcoasv::ExecuteAirflowCommandRequest
            {
                Environment = "",
                Command = "",
                Subcommand = "",
                Parameters = { "", },
            };
            // Make the request
            gcoasv::ExecuteAirflowCommandResponse response = await environmentsClient.ExecuteAirflowCommandAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StopAirflowCommand</summary>
        public void StopAirflowCommandRequestObject()
        {
            // Snippet: StopAirflowCommand(StopAirflowCommandRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::StopAirflowCommandRequest request = new gcoasv::StopAirflowCommandRequest
            {
                Environment = "",
                ExecutionId = "",
                Pod = "",
                PodNamespace = "",
                Force = false,
            };
            // Make the request
            gcoasv::StopAirflowCommandResponse response = environmentsClient.StopAirflowCommand(request);
            // End snippet
        }

        /// <summary>Snippet for StopAirflowCommandAsync</summary>
        public async Task StopAirflowCommandRequestObjectAsync()
        {
            // Snippet: StopAirflowCommandAsync(StopAirflowCommandRequest, CallSettings)
            // Additional: StopAirflowCommandAsync(StopAirflowCommandRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::StopAirflowCommandRequest request = new gcoasv::StopAirflowCommandRequest
            {
                Environment = "",
                ExecutionId = "",
                Pod = "",
                PodNamespace = "",
                Force = false,
            };
            // Make the request
            gcoasv::StopAirflowCommandResponse response = await environmentsClient.StopAirflowCommandAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PollAirflowCommand</summary>
        public void PollAirflowCommandRequestObject()
        {
            // Snippet: PollAirflowCommand(PollAirflowCommandRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::PollAirflowCommandRequest request = new gcoasv::PollAirflowCommandRequest
            {
                Environment = "",
                ExecutionId = "",
                Pod = "",
                PodNamespace = "",
                NextLineNumber = 0,
            };
            // Make the request
            gcoasv::PollAirflowCommandResponse response = environmentsClient.PollAirflowCommand(request);
            // End snippet
        }

        /// <summary>Snippet for PollAirflowCommandAsync</summary>
        public async Task PollAirflowCommandRequestObjectAsync()
        {
            // Snippet: PollAirflowCommandAsync(PollAirflowCommandRequest, CallSettings)
            // Additional: PollAirflowCommandAsync(PollAirflowCommandRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::PollAirflowCommandRequest request = new gcoasv::PollAirflowCommandRequest
            {
                Environment = "",
                ExecutionId = "",
                Pod = "",
                PodNamespace = "",
                NextLineNumber = 0,
            };
            // Make the request
            gcoasv::PollAirflowCommandResponse response = await environmentsClient.PollAirflowCommandAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloadsRequestObject()
        {
            // Snippet: ListWorkloads(ListWorkloadsRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::ListWorkloadsRequest request = new gcoasv::ListWorkloadsRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcoasv::ListWorkloadsResponse, gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> response = environmentsClient.ListWorkloads(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsRequestObjectAsync()
        {
            // Snippet: ListWorkloadsAsync(ListWorkloadsRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::ListWorkloadsRequest request = new gcoasv::ListWorkloadsRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListWorkloadsResponse, gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> response = environmentsClient.ListWorkloadsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloads()
        {
            // Snippet: ListWorkloads(string, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            // Make the request
            PagedEnumerable<gcoasv::ListWorkloadsResponse, gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> response = environmentsClient.ListWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsAsync()
        {
            // Snippet: ListWorkloadsAsync(string, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListWorkloadsResponse, gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> response = environmentsClient.ListWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloads</summary>
        public void ListWorkloadsResourceNames()
        {
            // Snippet: ListWorkloads(EnvironmentName, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            // Make the request
            PagedEnumerable<gcoasv::ListWorkloadsResponse, gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> response = environmentsClient.ListWorkloads(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListWorkloadsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkloadsAsync</summary>
        public async Task ListWorkloadsResourceNamesAsync()
        {
            // Snippet: ListWorkloadsAsync(EnvironmentName, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListWorkloadsResponse, gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> response = environmentsClient.ListWorkloadsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListWorkloadsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::ListWorkloadsResponse.Types.ComposerWorkload> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::ListWorkloadsResponse.Types.ComposerWorkload item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CheckUpgrade</summary>
        public void CheckUpgradeRequestObject()
        {
            // Snippet: CheckUpgrade(CheckUpgradeRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::CheckUpgradeRequest request = new gcoasv::CheckUpgradeRequest
            {
                Environment = "",
                ImageVersion = "",
            };
            // Make the request
            Operation<gcoasv::CheckUpgradeResponse, gcoasv::OperationMetadata> response = environmentsClient.CheckUpgrade(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::CheckUpgradeResponse, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcoasv::CheckUpgradeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::CheckUpgradeResponse, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceCheckUpgrade(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::CheckUpgradeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CheckUpgradeAsync</summary>
        public async Task CheckUpgradeRequestObjectAsync()
        {
            // Snippet: CheckUpgradeAsync(CheckUpgradeRequest, CallSettings)
            // Additional: CheckUpgradeAsync(CheckUpgradeRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::CheckUpgradeRequest request = new gcoasv::CheckUpgradeRequest
            {
                Environment = "",
                ImageVersion = "",
            };
            // Make the request
            Operation<gcoasv::CheckUpgradeResponse, gcoasv::OperationMetadata> response = await environmentsClient.CheckUpgradeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::CheckUpgradeResponse, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcoasv::CheckUpgradeResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::CheckUpgradeResponse, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceCheckUpgradeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::CheckUpgradeResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsSecret</summary>
        public void CreateUserWorkloadsSecretRequestObject()
        {
            // Snippet: CreateUserWorkloadsSecret(CreateUserWorkloadsSecretRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::CreateUserWorkloadsSecretRequest request = new gcoasv::CreateUserWorkloadsSecretRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                UserWorkloadsSecret = new gcoasv::UserWorkloadsSecret(),
            };
            // Make the request
            gcoasv::UserWorkloadsSecret response = environmentsClient.CreateUserWorkloadsSecret(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsSecretAsync</summary>
        public async Task CreateUserWorkloadsSecretRequestObjectAsync()
        {
            // Snippet: CreateUserWorkloadsSecretAsync(CreateUserWorkloadsSecretRequest, CallSettings)
            // Additional: CreateUserWorkloadsSecretAsync(CreateUserWorkloadsSecretRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::CreateUserWorkloadsSecretRequest request = new gcoasv::CreateUserWorkloadsSecretRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                UserWorkloadsSecret = new gcoasv::UserWorkloadsSecret(),
            };
            // Make the request
            gcoasv::UserWorkloadsSecret response = await environmentsClient.CreateUserWorkloadsSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsSecret</summary>
        public void CreateUserWorkloadsSecret()
        {
            // Snippet: CreateUserWorkloadsSecret(string, UserWorkloadsSecret, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            gcoasv::UserWorkloadsSecret userWorkloadsSecret = new gcoasv::UserWorkloadsSecret();
            // Make the request
            gcoasv::UserWorkloadsSecret response = environmentsClient.CreateUserWorkloadsSecret(parent, userWorkloadsSecret);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsSecretAsync</summary>
        public async Task CreateUserWorkloadsSecretAsync()
        {
            // Snippet: CreateUserWorkloadsSecretAsync(string, UserWorkloadsSecret, CallSettings)
            // Additional: CreateUserWorkloadsSecretAsync(string, UserWorkloadsSecret, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            gcoasv::UserWorkloadsSecret userWorkloadsSecret = new gcoasv::UserWorkloadsSecret();
            // Make the request
            gcoasv::UserWorkloadsSecret response = await environmentsClient.CreateUserWorkloadsSecretAsync(parent, userWorkloadsSecret);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsSecret</summary>
        public void CreateUserWorkloadsSecretResourceNames()
        {
            // Snippet: CreateUserWorkloadsSecret(EnvironmentName, UserWorkloadsSecret, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            gcoasv::UserWorkloadsSecret userWorkloadsSecret = new gcoasv::UserWorkloadsSecret();
            // Make the request
            gcoasv::UserWorkloadsSecret response = environmentsClient.CreateUserWorkloadsSecret(parent, userWorkloadsSecret);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsSecretAsync</summary>
        public async Task CreateUserWorkloadsSecretResourceNamesAsync()
        {
            // Snippet: CreateUserWorkloadsSecretAsync(EnvironmentName, UserWorkloadsSecret, CallSettings)
            // Additional: CreateUserWorkloadsSecretAsync(EnvironmentName, UserWorkloadsSecret, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            gcoasv::UserWorkloadsSecret userWorkloadsSecret = new gcoasv::UserWorkloadsSecret();
            // Make the request
            gcoasv::UserWorkloadsSecret response = await environmentsClient.CreateUserWorkloadsSecretAsync(parent, userWorkloadsSecret);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsSecret</summary>
        public void GetUserWorkloadsSecretRequestObject()
        {
            // Snippet: GetUserWorkloadsSecret(GetUserWorkloadsSecretRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::GetUserWorkloadsSecretRequest request = new gcoasv::GetUserWorkloadsSecretRequest
            {
                UserWorkloadsSecretName = gcoasv::UserWorkloadsSecretName.FromProjectLocationEnvironmentUserWorkloadsSecret("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_SECRET]"),
            };
            // Make the request
            gcoasv::UserWorkloadsSecret response = environmentsClient.GetUserWorkloadsSecret(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsSecretAsync</summary>
        public async Task GetUserWorkloadsSecretRequestObjectAsync()
        {
            // Snippet: GetUserWorkloadsSecretAsync(GetUserWorkloadsSecretRequest, CallSettings)
            // Additional: GetUserWorkloadsSecretAsync(GetUserWorkloadsSecretRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::GetUserWorkloadsSecretRequest request = new gcoasv::GetUserWorkloadsSecretRequest
            {
                UserWorkloadsSecretName = gcoasv::UserWorkloadsSecretName.FromProjectLocationEnvironmentUserWorkloadsSecret("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_SECRET]"),
            };
            // Make the request
            gcoasv::UserWorkloadsSecret response = await environmentsClient.GetUserWorkloadsSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsSecret</summary>
        public void GetUserWorkloadsSecret()
        {
            // Snippet: GetUserWorkloadsSecret(string, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]/userWorkloadsSecrets/[USER_WORKLOADS_SECRET]";
            // Make the request
            gcoasv::UserWorkloadsSecret response = environmentsClient.GetUserWorkloadsSecret(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsSecretAsync</summary>
        public async Task GetUserWorkloadsSecretAsync()
        {
            // Snippet: GetUserWorkloadsSecretAsync(string, CallSettings)
            // Additional: GetUserWorkloadsSecretAsync(string, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]/userWorkloadsSecrets/[USER_WORKLOADS_SECRET]";
            // Make the request
            gcoasv::UserWorkloadsSecret response = await environmentsClient.GetUserWorkloadsSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsSecret</summary>
        public void GetUserWorkloadsSecretResourceNames()
        {
            // Snippet: GetUserWorkloadsSecret(UserWorkloadsSecretName, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsSecretName name = gcoasv::UserWorkloadsSecretName.FromProjectLocationEnvironmentUserWorkloadsSecret("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_SECRET]");
            // Make the request
            gcoasv::UserWorkloadsSecret response = environmentsClient.GetUserWorkloadsSecret(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsSecretAsync</summary>
        public async Task GetUserWorkloadsSecretResourceNamesAsync()
        {
            // Snippet: GetUserWorkloadsSecretAsync(UserWorkloadsSecretName, CallSettings)
            // Additional: GetUserWorkloadsSecretAsync(UserWorkloadsSecretName, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsSecretName name = gcoasv::UserWorkloadsSecretName.FromProjectLocationEnvironmentUserWorkloadsSecret("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_SECRET]");
            // Make the request
            gcoasv::UserWorkloadsSecret response = await environmentsClient.GetUserWorkloadsSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsSecrets</summary>
        public void ListUserWorkloadsSecretsRequestObject()
        {
            // Snippet: ListUserWorkloadsSecrets(ListUserWorkloadsSecretsRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::ListUserWorkloadsSecretsRequest request = new gcoasv::ListUserWorkloadsSecretsRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedEnumerable<gcoasv::ListUserWorkloadsSecretsResponse, gcoasv::UserWorkloadsSecret> response = environmentsClient.ListUserWorkloadsSecrets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::UserWorkloadsSecret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListUserWorkloadsSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsSecret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsSecretsAsync</summary>
        public async Task ListUserWorkloadsSecretsRequestObjectAsync()
        {
            // Snippet: ListUserWorkloadsSecretsAsync(ListUserWorkloadsSecretsRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::ListUserWorkloadsSecretsRequest request = new gcoasv::ListUserWorkloadsSecretsRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListUserWorkloadsSecretsResponse, gcoasv::UserWorkloadsSecret> response = environmentsClient.ListUserWorkloadsSecretsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::UserWorkloadsSecret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListUserWorkloadsSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsSecret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsSecrets</summary>
        public void ListUserWorkloadsSecrets()
        {
            // Snippet: ListUserWorkloadsSecrets(string, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            // Make the request
            PagedEnumerable<gcoasv::ListUserWorkloadsSecretsResponse, gcoasv::UserWorkloadsSecret> response = environmentsClient.ListUserWorkloadsSecrets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::UserWorkloadsSecret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListUserWorkloadsSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsSecret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsSecretsAsync</summary>
        public async Task ListUserWorkloadsSecretsAsync()
        {
            // Snippet: ListUserWorkloadsSecretsAsync(string, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListUserWorkloadsSecretsResponse, gcoasv::UserWorkloadsSecret> response = environmentsClient.ListUserWorkloadsSecretsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::UserWorkloadsSecret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListUserWorkloadsSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsSecret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsSecrets</summary>
        public void ListUserWorkloadsSecretsResourceNames()
        {
            // Snippet: ListUserWorkloadsSecrets(EnvironmentName, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            // Make the request
            PagedEnumerable<gcoasv::ListUserWorkloadsSecretsResponse, gcoasv::UserWorkloadsSecret> response = environmentsClient.ListUserWorkloadsSecrets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::UserWorkloadsSecret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListUserWorkloadsSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsSecret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsSecretsAsync</summary>
        public async Task ListUserWorkloadsSecretsResourceNamesAsync()
        {
            // Snippet: ListUserWorkloadsSecretsAsync(EnvironmentName, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListUserWorkloadsSecretsResponse, gcoasv::UserWorkloadsSecret> response = environmentsClient.ListUserWorkloadsSecretsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::UserWorkloadsSecret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListUserWorkloadsSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsSecret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateUserWorkloadsSecret</summary>
        public void UpdateUserWorkloadsSecretRequestObject()
        {
            // Snippet: UpdateUserWorkloadsSecret(UpdateUserWorkloadsSecretRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UpdateUserWorkloadsSecretRequest request = new gcoasv::UpdateUserWorkloadsSecretRequest
            {
                UserWorkloadsSecret = new gcoasv::UserWorkloadsSecret(),
            };
            // Make the request
            gcoasv::UserWorkloadsSecret response = environmentsClient.UpdateUserWorkloadsSecret(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserWorkloadsSecretAsync</summary>
        public async Task UpdateUserWorkloadsSecretRequestObjectAsync()
        {
            // Snippet: UpdateUserWorkloadsSecretAsync(UpdateUserWorkloadsSecretRequest, CallSettings)
            // Additional: UpdateUserWorkloadsSecretAsync(UpdateUserWorkloadsSecretRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UpdateUserWorkloadsSecretRequest request = new gcoasv::UpdateUserWorkloadsSecretRequest
            {
                UserWorkloadsSecret = new gcoasv::UserWorkloadsSecret(),
            };
            // Make the request
            gcoasv::UserWorkloadsSecret response = await environmentsClient.UpdateUserWorkloadsSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserWorkloadsSecret</summary>
        public void UpdateUserWorkloadsSecret()
        {
            // Snippet: UpdateUserWorkloadsSecret(UserWorkloadsSecret, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsSecret userWorkloadsSecret = new gcoasv::UserWorkloadsSecret();
            // Make the request
            gcoasv::UserWorkloadsSecret response = environmentsClient.UpdateUserWorkloadsSecret(userWorkloadsSecret);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserWorkloadsSecretAsync</summary>
        public async Task UpdateUserWorkloadsSecretAsync()
        {
            // Snippet: UpdateUserWorkloadsSecretAsync(UserWorkloadsSecret, CallSettings)
            // Additional: UpdateUserWorkloadsSecretAsync(UserWorkloadsSecret, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsSecret userWorkloadsSecret = new gcoasv::UserWorkloadsSecret();
            // Make the request
            gcoasv::UserWorkloadsSecret response = await environmentsClient.UpdateUserWorkloadsSecretAsync(userWorkloadsSecret);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsSecret</summary>
        public void DeleteUserWorkloadsSecretRequestObject()
        {
            // Snippet: DeleteUserWorkloadsSecret(DeleteUserWorkloadsSecretRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::DeleteUserWorkloadsSecretRequest request = new gcoasv::DeleteUserWorkloadsSecretRequest
            {
                UserWorkloadsSecretName = gcoasv::UserWorkloadsSecretName.FromProjectLocationEnvironmentUserWorkloadsSecret("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_SECRET]"),
            };
            // Make the request
            environmentsClient.DeleteUserWorkloadsSecret(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsSecretAsync</summary>
        public async Task DeleteUserWorkloadsSecretRequestObjectAsync()
        {
            // Snippet: DeleteUserWorkloadsSecretAsync(DeleteUserWorkloadsSecretRequest, CallSettings)
            // Additional: DeleteUserWorkloadsSecretAsync(DeleteUserWorkloadsSecretRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::DeleteUserWorkloadsSecretRequest request = new gcoasv::DeleteUserWorkloadsSecretRequest
            {
                UserWorkloadsSecretName = gcoasv::UserWorkloadsSecretName.FromProjectLocationEnvironmentUserWorkloadsSecret("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_SECRET]"),
            };
            // Make the request
            await environmentsClient.DeleteUserWorkloadsSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsSecret</summary>
        public void DeleteUserWorkloadsSecret()
        {
            // Snippet: DeleteUserWorkloadsSecret(string, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]/userWorkloadsSecrets/[USER_WORKLOADS_SECRET]";
            // Make the request
            environmentsClient.DeleteUserWorkloadsSecret(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsSecretAsync</summary>
        public async Task DeleteUserWorkloadsSecretAsync()
        {
            // Snippet: DeleteUserWorkloadsSecretAsync(string, CallSettings)
            // Additional: DeleteUserWorkloadsSecretAsync(string, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]/userWorkloadsSecrets/[USER_WORKLOADS_SECRET]";
            // Make the request
            await environmentsClient.DeleteUserWorkloadsSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsSecret</summary>
        public void DeleteUserWorkloadsSecretResourceNames()
        {
            // Snippet: DeleteUserWorkloadsSecret(UserWorkloadsSecretName, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsSecretName name = gcoasv::UserWorkloadsSecretName.FromProjectLocationEnvironmentUserWorkloadsSecret("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_SECRET]");
            // Make the request
            environmentsClient.DeleteUserWorkloadsSecret(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsSecretAsync</summary>
        public async Task DeleteUserWorkloadsSecretResourceNamesAsync()
        {
            // Snippet: DeleteUserWorkloadsSecretAsync(UserWorkloadsSecretName, CallSettings)
            // Additional: DeleteUserWorkloadsSecretAsync(UserWorkloadsSecretName, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsSecretName name = gcoasv::UserWorkloadsSecretName.FromProjectLocationEnvironmentUserWorkloadsSecret("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_SECRET]");
            // Make the request
            await environmentsClient.DeleteUserWorkloadsSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsConfigMap</summary>
        public void CreateUserWorkloadsConfigMapRequestObject()
        {
            // Snippet: CreateUserWorkloadsConfigMap(CreateUserWorkloadsConfigMapRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::CreateUserWorkloadsConfigMapRequest request = new gcoasv::CreateUserWorkloadsConfigMapRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                UserWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap(),
            };
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = environmentsClient.CreateUserWorkloadsConfigMap(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsConfigMapAsync</summary>
        public async Task CreateUserWorkloadsConfigMapRequestObjectAsync()
        {
            // Snippet: CreateUserWorkloadsConfigMapAsync(CreateUserWorkloadsConfigMapRequest, CallSettings)
            // Additional: CreateUserWorkloadsConfigMapAsync(CreateUserWorkloadsConfigMapRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::CreateUserWorkloadsConfigMapRequest request = new gcoasv::CreateUserWorkloadsConfigMapRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
                UserWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap(),
            };
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = await environmentsClient.CreateUserWorkloadsConfigMapAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsConfigMap</summary>
        public void CreateUserWorkloadsConfigMap()
        {
            // Snippet: CreateUserWorkloadsConfigMap(string, UserWorkloadsConfigMap, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            gcoasv::UserWorkloadsConfigMap userWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap();
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = environmentsClient.CreateUserWorkloadsConfigMap(parent, userWorkloadsConfigMap);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsConfigMapAsync</summary>
        public async Task CreateUserWorkloadsConfigMapAsync()
        {
            // Snippet: CreateUserWorkloadsConfigMapAsync(string, UserWorkloadsConfigMap, CallSettings)
            // Additional: CreateUserWorkloadsConfigMapAsync(string, UserWorkloadsConfigMap, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            gcoasv::UserWorkloadsConfigMap userWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap();
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = await environmentsClient.CreateUserWorkloadsConfigMapAsync(parent, userWorkloadsConfigMap);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsConfigMap</summary>
        public void CreateUserWorkloadsConfigMapResourceNames()
        {
            // Snippet: CreateUserWorkloadsConfigMap(EnvironmentName, UserWorkloadsConfigMap, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            gcoasv::UserWorkloadsConfigMap userWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap();
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = environmentsClient.CreateUserWorkloadsConfigMap(parent, userWorkloadsConfigMap);
            // End snippet
        }

        /// <summary>Snippet for CreateUserWorkloadsConfigMapAsync</summary>
        public async Task CreateUserWorkloadsConfigMapResourceNamesAsync()
        {
            // Snippet: CreateUserWorkloadsConfigMapAsync(EnvironmentName, UserWorkloadsConfigMap, CallSettings)
            // Additional: CreateUserWorkloadsConfigMapAsync(EnvironmentName, UserWorkloadsConfigMap, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            gcoasv::UserWorkloadsConfigMap userWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap();
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = await environmentsClient.CreateUserWorkloadsConfigMapAsync(parent, userWorkloadsConfigMap);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsConfigMap</summary>
        public void GetUserWorkloadsConfigMapRequestObject()
        {
            // Snippet: GetUserWorkloadsConfigMap(GetUserWorkloadsConfigMapRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::GetUserWorkloadsConfigMapRequest request = new gcoasv::GetUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMapName = gcoasv::UserWorkloadsConfigMapName.FromProjectLocationEnvironmentUserWorkloadsConfigMap("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_CONFIG_MAP]"),
            };
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = environmentsClient.GetUserWorkloadsConfigMap(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsConfigMapAsync</summary>
        public async Task GetUserWorkloadsConfigMapRequestObjectAsync()
        {
            // Snippet: GetUserWorkloadsConfigMapAsync(GetUserWorkloadsConfigMapRequest, CallSettings)
            // Additional: GetUserWorkloadsConfigMapAsync(GetUserWorkloadsConfigMapRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::GetUserWorkloadsConfigMapRequest request = new gcoasv::GetUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMapName = gcoasv::UserWorkloadsConfigMapName.FromProjectLocationEnvironmentUserWorkloadsConfigMap("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_CONFIG_MAP]"),
            };
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = await environmentsClient.GetUserWorkloadsConfigMapAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsConfigMap</summary>
        public void GetUserWorkloadsConfigMap()
        {
            // Snippet: GetUserWorkloadsConfigMap(string, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]/userWorkloadsConfigMaps/[USER_WORKLOADS_CONFIG_MAP]";
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = environmentsClient.GetUserWorkloadsConfigMap(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsConfigMapAsync</summary>
        public async Task GetUserWorkloadsConfigMapAsync()
        {
            // Snippet: GetUserWorkloadsConfigMapAsync(string, CallSettings)
            // Additional: GetUserWorkloadsConfigMapAsync(string, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]/userWorkloadsConfigMaps/[USER_WORKLOADS_CONFIG_MAP]";
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = await environmentsClient.GetUserWorkloadsConfigMapAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsConfigMap</summary>
        public void GetUserWorkloadsConfigMapResourceNames()
        {
            // Snippet: GetUserWorkloadsConfigMap(UserWorkloadsConfigMapName, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsConfigMapName name = gcoasv::UserWorkloadsConfigMapName.FromProjectLocationEnvironmentUserWorkloadsConfigMap("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_CONFIG_MAP]");
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = environmentsClient.GetUserWorkloadsConfigMap(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserWorkloadsConfigMapAsync</summary>
        public async Task GetUserWorkloadsConfigMapResourceNamesAsync()
        {
            // Snippet: GetUserWorkloadsConfigMapAsync(UserWorkloadsConfigMapName, CallSettings)
            // Additional: GetUserWorkloadsConfigMapAsync(UserWorkloadsConfigMapName, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsConfigMapName name = gcoasv::UserWorkloadsConfigMapName.FromProjectLocationEnvironmentUserWorkloadsConfigMap("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_CONFIG_MAP]");
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = await environmentsClient.GetUserWorkloadsConfigMapAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsConfigMaps</summary>
        public void ListUserWorkloadsConfigMapsRequestObject()
        {
            // Snippet: ListUserWorkloadsConfigMaps(ListUserWorkloadsConfigMapsRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::ListUserWorkloadsConfigMapsRequest request = new gcoasv::ListUserWorkloadsConfigMapsRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedEnumerable<gcoasv::ListUserWorkloadsConfigMapsResponse, gcoasv::UserWorkloadsConfigMap> response = environmentsClient.ListUserWorkloadsConfigMaps(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::UserWorkloadsConfigMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListUserWorkloadsConfigMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsConfigMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsConfigMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsConfigMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsConfigMapsAsync</summary>
        public async Task ListUserWorkloadsConfigMapsRequestObjectAsync()
        {
            // Snippet: ListUserWorkloadsConfigMapsAsync(ListUserWorkloadsConfigMapsRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::ListUserWorkloadsConfigMapsRequest request = new gcoasv::ListUserWorkloadsConfigMapsRequest
            {
                ParentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListUserWorkloadsConfigMapsResponse, gcoasv::UserWorkloadsConfigMap> response = environmentsClient.ListUserWorkloadsConfigMapsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::UserWorkloadsConfigMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListUserWorkloadsConfigMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsConfigMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsConfigMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsConfigMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsConfigMaps</summary>
        public void ListUserWorkloadsConfigMaps()
        {
            // Snippet: ListUserWorkloadsConfigMaps(string, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            // Make the request
            PagedEnumerable<gcoasv::ListUserWorkloadsConfigMapsResponse, gcoasv::UserWorkloadsConfigMap> response = environmentsClient.ListUserWorkloadsConfigMaps(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::UserWorkloadsConfigMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListUserWorkloadsConfigMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsConfigMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsConfigMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsConfigMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsConfigMapsAsync</summary>
        public async Task ListUserWorkloadsConfigMapsAsync()
        {
            // Snippet: ListUserWorkloadsConfigMapsAsync(string, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]";
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListUserWorkloadsConfigMapsResponse, gcoasv::UserWorkloadsConfigMap> response = environmentsClient.ListUserWorkloadsConfigMapsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::UserWorkloadsConfigMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListUserWorkloadsConfigMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsConfigMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsConfigMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsConfigMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsConfigMaps</summary>
        public void ListUserWorkloadsConfigMapsResourceNames()
        {
            // Snippet: ListUserWorkloadsConfigMaps(EnvironmentName, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            // Make the request
            PagedEnumerable<gcoasv::ListUserWorkloadsConfigMapsResponse, gcoasv::UserWorkloadsConfigMap> response = environmentsClient.ListUserWorkloadsConfigMaps(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcoasv::UserWorkloadsConfigMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcoasv::ListUserWorkloadsConfigMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsConfigMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsConfigMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsConfigMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserWorkloadsConfigMapsAsync</summary>
        public async Task ListUserWorkloadsConfigMapsResourceNamesAsync()
        {
            // Snippet: ListUserWorkloadsConfigMapsAsync(EnvironmentName, string, int?, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::EnvironmentName parent = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]");
            // Make the request
            PagedAsyncEnumerable<gcoasv::ListUserWorkloadsConfigMapsResponse, gcoasv::UserWorkloadsConfigMap> response = environmentsClient.ListUserWorkloadsConfigMapsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcoasv::UserWorkloadsConfigMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcoasv::ListUserWorkloadsConfigMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcoasv::UserWorkloadsConfigMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcoasv::UserWorkloadsConfigMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcoasv::UserWorkloadsConfigMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateUserWorkloadsConfigMap</summary>
        public void UpdateUserWorkloadsConfigMapRequestObject()
        {
            // Snippet: UpdateUserWorkloadsConfigMap(UpdateUserWorkloadsConfigMapRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UpdateUserWorkloadsConfigMapRequest request = new gcoasv::UpdateUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap(),
            };
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = environmentsClient.UpdateUserWorkloadsConfigMap(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserWorkloadsConfigMapAsync</summary>
        public async Task UpdateUserWorkloadsConfigMapRequestObjectAsync()
        {
            // Snippet: UpdateUserWorkloadsConfigMapAsync(UpdateUserWorkloadsConfigMapRequest, CallSettings)
            // Additional: UpdateUserWorkloadsConfigMapAsync(UpdateUserWorkloadsConfigMapRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UpdateUserWorkloadsConfigMapRequest request = new gcoasv::UpdateUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap(),
            };
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = await environmentsClient.UpdateUserWorkloadsConfigMapAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserWorkloadsConfigMap</summary>
        public void UpdateUserWorkloadsConfigMap()
        {
            // Snippet: UpdateUserWorkloadsConfigMap(UserWorkloadsConfigMap, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsConfigMap userWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap();
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = environmentsClient.UpdateUserWorkloadsConfigMap(userWorkloadsConfigMap);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserWorkloadsConfigMapAsync</summary>
        public async Task UpdateUserWorkloadsConfigMapAsync()
        {
            // Snippet: UpdateUserWorkloadsConfigMapAsync(UserWorkloadsConfigMap, CallSettings)
            // Additional: UpdateUserWorkloadsConfigMapAsync(UserWorkloadsConfigMap, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsConfigMap userWorkloadsConfigMap = new gcoasv::UserWorkloadsConfigMap();
            // Make the request
            gcoasv::UserWorkloadsConfigMap response = await environmentsClient.UpdateUserWorkloadsConfigMapAsync(userWorkloadsConfigMap);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsConfigMap</summary>
        public void DeleteUserWorkloadsConfigMapRequestObject()
        {
            // Snippet: DeleteUserWorkloadsConfigMap(DeleteUserWorkloadsConfigMapRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::DeleteUserWorkloadsConfigMapRequest request = new gcoasv::DeleteUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMapName = gcoasv::UserWorkloadsConfigMapName.FromProjectLocationEnvironmentUserWorkloadsConfigMap("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_CONFIG_MAP]"),
            };
            // Make the request
            environmentsClient.DeleteUserWorkloadsConfigMap(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsConfigMapAsync</summary>
        public async Task DeleteUserWorkloadsConfigMapRequestObjectAsync()
        {
            // Snippet: DeleteUserWorkloadsConfigMapAsync(DeleteUserWorkloadsConfigMapRequest, CallSettings)
            // Additional: DeleteUserWorkloadsConfigMapAsync(DeleteUserWorkloadsConfigMapRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::DeleteUserWorkloadsConfigMapRequest request = new gcoasv::DeleteUserWorkloadsConfigMapRequest
            {
                UserWorkloadsConfigMapName = gcoasv::UserWorkloadsConfigMapName.FromProjectLocationEnvironmentUserWorkloadsConfigMap("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_CONFIG_MAP]"),
            };
            // Make the request
            await environmentsClient.DeleteUserWorkloadsConfigMapAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsConfigMap</summary>
        public void DeleteUserWorkloadsConfigMap()
        {
            // Snippet: DeleteUserWorkloadsConfigMap(string, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]/userWorkloadsConfigMaps/[USER_WORKLOADS_CONFIG_MAP]";
            // Make the request
            environmentsClient.DeleteUserWorkloadsConfigMap(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsConfigMapAsync</summary>
        public async Task DeleteUserWorkloadsConfigMapAsync()
        {
            // Snippet: DeleteUserWorkloadsConfigMapAsync(string, CallSettings)
            // Additional: DeleteUserWorkloadsConfigMapAsync(string, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/environments/[ENVIRONMENT]/userWorkloadsConfigMaps/[USER_WORKLOADS_CONFIG_MAP]";
            // Make the request
            await environmentsClient.DeleteUserWorkloadsConfigMapAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsConfigMap</summary>
        public void DeleteUserWorkloadsConfigMapResourceNames()
        {
            // Snippet: DeleteUserWorkloadsConfigMap(UserWorkloadsConfigMapName, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsConfigMapName name = gcoasv::UserWorkloadsConfigMapName.FromProjectLocationEnvironmentUserWorkloadsConfigMap("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_CONFIG_MAP]");
            // Make the request
            environmentsClient.DeleteUserWorkloadsConfigMap(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserWorkloadsConfigMapAsync</summary>
        public async Task DeleteUserWorkloadsConfigMapResourceNamesAsync()
        {
            // Snippet: DeleteUserWorkloadsConfigMapAsync(UserWorkloadsConfigMapName, CallSettings)
            // Additional: DeleteUserWorkloadsConfigMapAsync(UserWorkloadsConfigMapName, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::UserWorkloadsConfigMapName name = gcoasv::UserWorkloadsConfigMapName.FromProjectLocationEnvironmentUserWorkloadsConfigMap("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]", "[USER_WORKLOADS_CONFIG_MAP]");
            // Make the request
            await environmentsClient.DeleteUserWorkloadsConfigMapAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SaveSnapshot</summary>
        public void SaveSnapshotRequestObject()
        {
            // Snippet: SaveSnapshot(SaveSnapshotRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::SaveSnapshotRequest request = new gcoasv::SaveSnapshotRequest
            {
                Environment = "",
                SnapshotLocation = "",
            };
            // Make the request
            Operation<gcoasv::SaveSnapshotResponse, gcoasv::OperationMetadata> response = environmentsClient.SaveSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::SaveSnapshotResponse, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcoasv::SaveSnapshotResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::SaveSnapshotResponse, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceSaveSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::SaveSnapshotResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SaveSnapshotAsync</summary>
        public async Task SaveSnapshotRequestObjectAsync()
        {
            // Snippet: SaveSnapshotAsync(SaveSnapshotRequest, CallSettings)
            // Additional: SaveSnapshotAsync(SaveSnapshotRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::SaveSnapshotRequest request = new gcoasv::SaveSnapshotRequest
            {
                Environment = "",
                SnapshotLocation = "",
            };
            // Make the request
            Operation<gcoasv::SaveSnapshotResponse, gcoasv::OperationMetadata> response = await environmentsClient.SaveSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::SaveSnapshotResponse, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcoasv::SaveSnapshotResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::SaveSnapshotResponse, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceSaveSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::SaveSnapshotResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LoadSnapshot</summary>
        public void LoadSnapshotRequestObject()
        {
            // Snippet: LoadSnapshot(LoadSnapshotRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::LoadSnapshotRequest request = new gcoasv::LoadSnapshotRequest
            {
                Environment = "",
                SnapshotPath = "",
                SkipPypiPackagesInstallation = false,
                SkipEnvironmentVariablesSetting = false,
                SkipAirflowOverridesSetting = false,
                SkipGcsDataCopying = false,
            };
            // Make the request
            Operation<gcoasv::LoadSnapshotResponse, gcoasv::OperationMetadata> response = environmentsClient.LoadSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::LoadSnapshotResponse, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcoasv::LoadSnapshotResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::LoadSnapshotResponse, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceLoadSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::LoadSnapshotResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for LoadSnapshotAsync</summary>
        public async Task LoadSnapshotRequestObjectAsync()
        {
            // Snippet: LoadSnapshotAsync(LoadSnapshotRequest, CallSettings)
            // Additional: LoadSnapshotAsync(LoadSnapshotRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::LoadSnapshotRequest request = new gcoasv::LoadSnapshotRequest
            {
                Environment = "",
                SnapshotPath = "",
                SkipPypiPackagesInstallation = false,
                SkipEnvironmentVariablesSetting = false,
                SkipAirflowOverridesSetting = false,
                SkipGcsDataCopying = false,
            };
            // Make the request
            Operation<gcoasv::LoadSnapshotResponse, gcoasv::OperationMetadata> response = await environmentsClient.LoadSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::LoadSnapshotResponse, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcoasv::LoadSnapshotResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::LoadSnapshotResponse, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceLoadSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::LoadSnapshotResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DatabaseFailover</summary>
        public void DatabaseFailoverRequestObject()
        {
            // Snippet: DatabaseFailover(DatabaseFailoverRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::DatabaseFailoverRequest request = new gcoasv::DatabaseFailoverRequest { Environment = "", };
            // Make the request
            Operation<gcoasv::DatabaseFailoverResponse, gcoasv::OperationMetadata> response = environmentsClient.DatabaseFailover(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::DatabaseFailoverResponse, gcoasv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcoasv::DatabaseFailoverResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::DatabaseFailoverResponse, gcoasv::OperationMetadata> retrievedResponse = environmentsClient.PollOnceDatabaseFailover(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::DatabaseFailoverResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DatabaseFailoverAsync</summary>
        public async Task DatabaseFailoverRequestObjectAsync()
        {
            // Snippet: DatabaseFailoverAsync(DatabaseFailoverRequest, CallSettings)
            // Additional: DatabaseFailoverAsync(DatabaseFailoverRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::DatabaseFailoverRequest request = new gcoasv::DatabaseFailoverRequest { Environment = "", };
            // Make the request
            Operation<gcoasv::DatabaseFailoverResponse, gcoasv::OperationMetadata> response = await environmentsClient.DatabaseFailoverAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcoasv::DatabaseFailoverResponse, gcoasv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcoasv::DatabaseFailoverResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcoasv::DatabaseFailoverResponse, gcoasv::OperationMetadata> retrievedResponse = await environmentsClient.PollOnceDatabaseFailoverAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcoasv::DatabaseFailoverResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchDatabaseProperties</summary>
        public void FetchDatabasePropertiesRequestObject()
        {
            // Snippet: FetchDatabaseProperties(FetchDatabasePropertiesRequest, CallSettings)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = gcoasv::EnvironmentsClient.Create();
            // Initialize request argument(s)
            gcoasv::FetchDatabasePropertiesRequest request = new gcoasv::FetchDatabasePropertiesRequest
            {
                EnvironmentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
            };
            // Make the request
            gcoasv::FetchDatabasePropertiesResponse response = environmentsClient.FetchDatabaseProperties(request);
            // End snippet
        }

        /// <summary>Snippet for FetchDatabasePropertiesAsync</summary>
        public async Task FetchDatabasePropertiesRequestObjectAsync()
        {
            // Snippet: FetchDatabasePropertiesAsync(FetchDatabasePropertiesRequest, CallSettings)
            // Additional: FetchDatabasePropertiesAsync(FetchDatabasePropertiesRequest, CancellationToken)
            // Create client
            gcoasv::EnvironmentsClient environmentsClient = await gcoasv::EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            gcoasv::FetchDatabasePropertiesRequest request = new gcoasv::FetchDatabasePropertiesRequest
            {
                EnvironmentAsEnvironmentName = gcoasv::EnvironmentName.FromProjectLocationEnvironment("[PROJECT]", "[LOCATION]", "[ENVIRONMENT]"),
            };
            // Make the request
            gcoasv::FetchDatabasePropertiesResponse response = await environmentsClient.FetchDatabasePropertiesAsync(request);
            // End snippet
        }
    }
}
