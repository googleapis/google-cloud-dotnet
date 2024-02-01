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
    using Google.Cloud.StorageTransfer.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStorageTransferServiceClientSnippets
    {
        /// <summary>Snippet for GetGoogleServiceAccount</summary>
        public void GetGoogleServiceAccountRequestObject()
        {
            // Snippet: GetGoogleServiceAccount(GetGoogleServiceAccountRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            GetGoogleServiceAccountRequest request = new GetGoogleServiceAccountRequest { ProjectId = "", };
            // Make the request
            GoogleServiceAccount response = storageTransferServiceClient.GetGoogleServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleServiceAccountAsync</summary>
        public async Task GetGoogleServiceAccountRequestObjectAsync()
        {
            // Snippet: GetGoogleServiceAccountAsync(GetGoogleServiceAccountRequest, CallSettings)
            // Additional: GetGoogleServiceAccountAsync(GetGoogleServiceAccountRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGoogleServiceAccountRequest request = new GetGoogleServiceAccountRequest { ProjectId = "", };
            // Make the request
            GoogleServiceAccount response = await storageTransferServiceClient.GetGoogleServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferJob</summary>
        public void CreateTransferJobRequestObject()
        {
            // Snippet: CreateTransferJob(CreateTransferJobRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            CreateTransferJobRequest request = new CreateTransferJobRequest
            {
                TransferJob = new TransferJob(),
            };
            // Make the request
            TransferJob response = storageTransferServiceClient.CreateTransferJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTransferJobAsync</summary>
        public async Task CreateTransferJobRequestObjectAsync()
        {
            // Snippet: CreateTransferJobAsync(CreateTransferJobRequest, CallSettings)
            // Additional: CreateTransferJobAsync(CreateTransferJobRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTransferJobRequest request = new CreateTransferJobRequest
            {
                TransferJob = new TransferJob(),
            };
            // Make the request
            TransferJob response = await storageTransferServiceClient.CreateTransferJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferJob</summary>
        public void UpdateTransferJobRequestObject()
        {
            // Snippet: UpdateTransferJob(UpdateTransferJobRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            UpdateTransferJobRequest request = new UpdateTransferJobRequest
            {
                JobName = "",
                ProjectId = "",
                TransferJob = new TransferJob(),
                UpdateTransferJobFieldMask = new FieldMask(),
            };
            // Make the request
            TransferJob response = storageTransferServiceClient.UpdateTransferJob(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTransferJobAsync</summary>
        public async Task UpdateTransferJobRequestObjectAsync()
        {
            // Snippet: UpdateTransferJobAsync(UpdateTransferJobRequest, CallSettings)
            // Additional: UpdateTransferJobAsync(UpdateTransferJobRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTransferJobRequest request = new UpdateTransferJobRequest
            {
                JobName = "",
                ProjectId = "",
                TransferJob = new TransferJob(),
                UpdateTransferJobFieldMask = new FieldMask(),
            };
            // Make the request
            TransferJob response = await storageTransferServiceClient.UpdateTransferJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferJob</summary>
        public void GetTransferJobRequestObject()
        {
            // Snippet: GetTransferJob(GetTransferJobRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            GetTransferJobRequest request = new GetTransferJobRequest
            {
                JobName = "",
                ProjectId = "",
            };
            // Make the request
            TransferJob response = storageTransferServiceClient.GetTransferJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetTransferJobAsync</summary>
        public async Task GetTransferJobRequestObjectAsync()
        {
            // Snippet: GetTransferJobAsync(GetTransferJobRequest, CallSettings)
            // Additional: GetTransferJobAsync(GetTransferJobRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTransferJobRequest request = new GetTransferJobRequest
            {
                JobName = "",
                ProjectId = "",
            };
            // Make the request
            TransferJob response = await storageTransferServiceClient.GetTransferJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListTransferJobs</summary>
        public void ListTransferJobsRequestObject()
        {
            // Snippet: ListTransferJobs(ListTransferJobsRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            ListTransferJobsRequest request = new ListTransferJobsRequest { Filter = "", };
            // Make the request
            PagedEnumerable<ListTransferJobsResponse, TransferJob> response = storageTransferServiceClient.ListTransferJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (TransferJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTransferJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTransferJobsAsync</summary>
        public async Task ListTransferJobsRequestObjectAsync()
        {
            // Snippet: ListTransferJobsAsync(ListTransferJobsRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTransferJobsRequest request = new ListTransferJobsRequest { Filter = "", };
            // Make the request
            PagedAsyncEnumerable<ListTransferJobsResponse, TransferJob> response = storageTransferServiceClient.ListTransferJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((TransferJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTransferJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (TransferJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<TransferJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (TransferJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for PauseTransferOperation</summary>
        public void PauseTransferOperationRequestObject()
        {
            // Snippet: PauseTransferOperation(PauseTransferOperationRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            PauseTransferOperationRequest request = new PauseTransferOperationRequest { Name = "", };
            // Make the request
            storageTransferServiceClient.PauseTransferOperation(request);
            // End snippet
        }

        /// <summary>Snippet for PauseTransferOperationAsync</summary>
        public async Task PauseTransferOperationRequestObjectAsync()
        {
            // Snippet: PauseTransferOperationAsync(PauseTransferOperationRequest, CallSettings)
            // Additional: PauseTransferOperationAsync(PauseTransferOperationRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            PauseTransferOperationRequest request = new PauseTransferOperationRequest { Name = "", };
            // Make the request
            await storageTransferServiceClient.PauseTransferOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeTransferOperation</summary>
        public void ResumeTransferOperationRequestObject()
        {
            // Snippet: ResumeTransferOperation(ResumeTransferOperationRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            ResumeTransferOperationRequest request = new ResumeTransferOperationRequest { Name = "", };
            // Make the request
            storageTransferServiceClient.ResumeTransferOperation(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeTransferOperationAsync</summary>
        public async Task ResumeTransferOperationRequestObjectAsync()
        {
            // Snippet: ResumeTransferOperationAsync(ResumeTransferOperationRequest, CallSettings)
            // Additional: ResumeTransferOperationAsync(ResumeTransferOperationRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResumeTransferOperationRequest request = new ResumeTransferOperationRequest { Name = "", };
            // Make the request
            await storageTransferServiceClient.ResumeTransferOperationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunTransferJob</summary>
        public void RunTransferJobRequestObject()
        {
            // Snippet: RunTransferJob(RunTransferJobRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            RunTransferJobRequest request = new RunTransferJobRequest
            {
                JobName = "",
                ProjectId = "",
            };
            // Make the request
            Operation<Empty, TransferOperation> response = storageTransferServiceClient.RunTransferJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, TransferOperation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, TransferOperation> retrievedResponse = storageTransferServiceClient.PollOnceRunTransferJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RunTransferJobAsync</summary>
        public async Task RunTransferJobRequestObjectAsync()
        {
            // Snippet: RunTransferJobAsync(RunTransferJobRequest, CallSettings)
            // Additional: RunTransferJobAsync(RunTransferJobRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunTransferJobRequest request = new RunTransferJobRequest
            {
                JobName = "",
                ProjectId = "",
            };
            // Make the request
            Operation<Empty, TransferOperation> response = await storageTransferServiceClient.RunTransferJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, TransferOperation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, TransferOperation> retrievedResponse = await storageTransferServiceClient.PollOnceRunTransferJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferJob</summary>
        public void DeleteTransferJobRequestObject()
        {
            // Snippet: DeleteTransferJob(DeleteTransferJobRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteTransferJobRequest request = new DeleteTransferJobRequest
            {
                JobName = "",
                ProjectId = "",
            };
            // Make the request
            storageTransferServiceClient.DeleteTransferJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTransferJobAsync</summary>
        public async Task DeleteTransferJobRequestObjectAsync()
        {
            // Snippet: DeleteTransferJobAsync(DeleteTransferJobRequest, CallSettings)
            // Additional: DeleteTransferJobAsync(DeleteTransferJobRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTransferJobRequest request = new DeleteTransferJobRequest
            {
                JobName = "",
                ProjectId = "",
            };
            // Make the request
            await storageTransferServiceClient.DeleteTransferJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentPool</summary>
        public void CreateAgentPoolRequestObject()
        {
            // Snippet: CreateAgentPool(CreateAgentPoolRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            CreateAgentPoolRequest request = new CreateAgentPoolRequest
            {
                ProjectId = "",
                AgentPool = new AgentPool(),
                AgentPoolId = "",
            };
            // Make the request
            AgentPool response = storageTransferServiceClient.CreateAgentPool(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentPoolAsync</summary>
        public async Task CreateAgentPoolRequestObjectAsync()
        {
            // Snippet: CreateAgentPoolAsync(CreateAgentPoolRequest, CallSettings)
            // Additional: CreateAgentPoolAsync(CreateAgentPoolRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAgentPoolRequest request = new CreateAgentPoolRequest
            {
                ProjectId = "",
                AgentPool = new AgentPool(),
                AgentPoolId = "",
            };
            // Make the request
            AgentPool response = await storageTransferServiceClient.CreateAgentPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentPool</summary>
        public void CreateAgentPool()
        {
            // Snippet: CreateAgentPool(string, AgentPool, string, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            AgentPool agentPool = new AgentPool();
            string agentPoolId = "";
            // Make the request
            AgentPool response = storageTransferServiceClient.CreateAgentPool(projectId, agentPool, agentPoolId);
            // End snippet
        }

        /// <summary>Snippet for CreateAgentPoolAsync</summary>
        public async Task CreateAgentPoolAsync()
        {
            // Snippet: CreateAgentPoolAsync(string, AgentPool, string, CallSettings)
            // Additional: CreateAgentPoolAsync(string, AgentPool, string, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            AgentPool agentPool = new AgentPool();
            string agentPoolId = "";
            // Make the request
            AgentPool response = await storageTransferServiceClient.CreateAgentPoolAsync(projectId, agentPool, agentPoolId);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgentPool</summary>
        public void UpdateAgentPoolRequestObject()
        {
            // Snippet: UpdateAgentPool(UpdateAgentPoolRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            UpdateAgentPoolRequest request = new UpdateAgentPoolRequest
            {
                AgentPool = new AgentPool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AgentPool response = storageTransferServiceClient.UpdateAgentPool(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgentPoolAsync</summary>
        public async Task UpdateAgentPoolRequestObjectAsync()
        {
            // Snippet: UpdateAgentPoolAsync(UpdateAgentPoolRequest, CallSettings)
            // Additional: UpdateAgentPoolAsync(UpdateAgentPoolRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAgentPoolRequest request = new UpdateAgentPoolRequest
            {
                AgentPool = new AgentPool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AgentPool response = await storageTransferServiceClient.UpdateAgentPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgentPool</summary>
        public void UpdateAgentPool()
        {
            // Snippet: UpdateAgentPool(AgentPool, FieldMask, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            AgentPool agentPool = new AgentPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AgentPool response = storageTransferServiceClient.UpdateAgentPool(agentPool, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAgentPoolAsync</summary>
        public async Task UpdateAgentPoolAsync()
        {
            // Snippet: UpdateAgentPoolAsync(AgentPool, FieldMask, CallSettings)
            // Additional: UpdateAgentPoolAsync(AgentPool, FieldMask, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            AgentPool agentPool = new AgentPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AgentPool response = await storageTransferServiceClient.UpdateAgentPoolAsync(agentPool, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetAgentPool</summary>
        public void GetAgentPoolRequestObject()
        {
            // Snippet: GetAgentPool(GetAgentPoolRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            GetAgentPoolRequest request = new GetAgentPoolRequest { Name = "", };
            // Make the request
            AgentPool response = storageTransferServiceClient.GetAgentPool(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentPoolAsync</summary>
        public async Task GetAgentPoolRequestObjectAsync()
        {
            // Snippet: GetAgentPoolAsync(GetAgentPoolRequest, CallSettings)
            // Additional: GetAgentPoolAsync(GetAgentPoolRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAgentPoolRequest request = new GetAgentPoolRequest { Name = "", };
            // Make the request
            AgentPool response = await storageTransferServiceClient.GetAgentPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAgentPool</summary>
        public void GetAgentPool()
        {
            // Snippet: GetAgentPool(string, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            AgentPool response = storageTransferServiceClient.GetAgentPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetAgentPoolAsync</summary>
        public async Task GetAgentPoolAsync()
        {
            // Snippet: GetAgentPoolAsync(string, CallSettings)
            // Additional: GetAgentPoolAsync(string, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            AgentPool response = await storageTransferServiceClient.GetAgentPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAgentPools</summary>
        public void ListAgentPoolsRequestObject()
        {
            // Snippet: ListAgentPools(ListAgentPoolsRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            ListAgentPoolsRequest request = new ListAgentPoolsRequest
            {
                ProjectId = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAgentPoolsResponse, AgentPool> response = storageTransferServiceClient.ListAgentPools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AgentPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentPoolsAsync</summary>
        public async Task ListAgentPoolsRequestObjectAsync()
        {
            // Snippet: ListAgentPoolsAsync(ListAgentPoolsRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAgentPoolsRequest request = new ListAgentPoolsRequest
            {
                ProjectId = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAgentPoolsResponse, AgentPool> response = storageTransferServiceClient.ListAgentPoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AgentPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAgentPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentPools</summary>
        public void ListAgentPools()
        {
            // Snippet: ListAgentPools(string, string, int?, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            PagedEnumerable<ListAgentPoolsResponse, AgentPool> response = storageTransferServiceClient.ListAgentPools(projectId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AgentPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAgentPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAgentPoolsAsync</summary>
        public async Task ListAgentPoolsAsync()
        {
            // Snippet: ListAgentPoolsAsync(string, string, int?, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            PagedAsyncEnumerable<ListAgentPoolsResponse, AgentPool> response = storageTransferServiceClient.ListAgentPoolsAsync(projectId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AgentPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAgentPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AgentPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AgentPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AgentPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentPool</summary>
        public void DeleteAgentPoolRequestObject()
        {
            // Snippet: DeleteAgentPool(DeleteAgentPoolRequest, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteAgentPoolRequest request = new DeleteAgentPoolRequest { Name = "", };
            // Make the request
            storageTransferServiceClient.DeleteAgentPool(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentPoolAsync</summary>
        public async Task DeleteAgentPoolRequestObjectAsync()
        {
            // Snippet: DeleteAgentPoolAsync(DeleteAgentPoolRequest, CallSettings)
            // Additional: DeleteAgentPoolAsync(DeleteAgentPoolRequest, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAgentPoolRequest request = new DeleteAgentPoolRequest { Name = "", };
            // Make the request
            await storageTransferServiceClient.DeleteAgentPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentPool</summary>
        public void DeleteAgentPool()
        {
            // Snippet: DeleteAgentPool(string, CallSettings)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = StorageTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            storageTransferServiceClient.DeleteAgentPool(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAgentPoolAsync</summary>
        public async Task DeleteAgentPoolAsync()
        {
            // Snippet: DeleteAgentPoolAsync(string, CallSettings)
            // Additional: DeleteAgentPoolAsync(string, CancellationToken)
            // Create client
            StorageTransferServiceClient storageTransferServiceClient = await StorageTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            await storageTransferServiceClient.DeleteAgentPoolAsync(name);
            // End snippet
        }
    }
}
