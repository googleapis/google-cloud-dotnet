// Copyright 2023 Google LLC
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
