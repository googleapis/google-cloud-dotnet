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
    using Google.Cloud.CloudDms.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataMigrationServiceClientSnippets
    {
        /// <summary>Snippet for ListMigrationJobs</summary>
        public void ListMigrationJobsRequestObject()
        {
            // Snippet: ListMigrationJobs(ListMigrationJobsRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ListMigrationJobsRequest request = new ListMigrationJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMigrationJobsResponse, MigrationJob> response = dataMigrationServiceClient.ListMigrationJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationJobsAsync</summary>
        public async Task ListMigrationJobsRequestObjectAsync()
        {
            // Snippet: ListMigrationJobsAsync(ListMigrationJobsRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMigrationJobsRequest request = new ListMigrationJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> response = dataMigrationServiceClient.ListMigrationJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationJobs</summary>
        public void ListMigrationJobs()
        {
            // Snippet: ListMigrationJobs(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMigrationJobsResponse, MigrationJob> response = dataMigrationServiceClient.ListMigrationJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationJobsAsync</summary>
        public async Task ListMigrationJobsAsync()
        {
            // Snippet: ListMigrationJobsAsync(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> response = dataMigrationServiceClient.ListMigrationJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationJobs</summary>
        public void ListMigrationJobsResourceNames()
        {
            // Snippet: ListMigrationJobs(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMigrationJobsResponse, MigrationJob> response = dataMigrationServiceClient.ListMigrationJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigrationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMigrationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMigrationJobsAsync</summary>
        public async Task ListMigrationJobsResourceNamesAsync()
        {
            // Snippet: ListMigrationJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMigrationJobsResponse, MigrationJob> response = dataMigrationServiceClient.ListMigrationJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigrationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMigrationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigrationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigrationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigrationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMigrationJob</summary>
        public void GetMigrationJobRequestObject()
        {
            // Snippet: GetMigrationJob(GetMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            GetMigrationJobRequest request = new GetMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            MigrationJob response = dataMigrationServiceClient.GetMigrationJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationJobAsync</summary>
        public async Task GetMigrationJobRequestObjectAsync()
        {
            // Snippet: GetMigrationJobAsync(GetMigrationJobRequest, CallSettings)
            // Additional: GetMigrationJobAsync(GetMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMigrationJobRequest request = new GetMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            MigrationJob response = await dataMigrationServiceClient.GetMigrationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationJob</summary>
        public void GetMigrationJob()
        {
            // Snippet: GetMigrationJob(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/migrationJobs/[MIGRATION_JOB]";
            // Make the request
            MigrationJob response = dataMigrationServiceClient.GetMigrationJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationJobAsync</summary>
        public async Task GetMigrationJobAsync()
        {
            // Snippet: GetMigrationJobAsync(string, CallSettings)
            // Additional: GetMigrationJobAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/migrationJobs/[MIGRATION_JOB]";
            // Make the request
            MigrationJob response = await dataMigrationServiceClient.GetMigrationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationJob</summary>
        public void GetMigrationJobResourceNames()
        {
            // Snippet: GetMigrationJob(MigrationJobName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            MigrationJobName name = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]");
            // Make the request
            MigrationJob response = dataMigrationServiceClient.GetMigrationJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetMigrationJobAsync</summary>
        public async Task GetMigrationJobResourceNamesAsync()
        {
            // Snippet: GetMigrationJobAsync(MigrationJobName, CallSettings)
            // Additional: GetMigrationJobAsync(MigrationJobName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrationJobName name = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]");
            // Make the request
            MigrationJob response = await dataMigrationServiceClient.GetMigrationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationJob</summary>
        public void CreateMigrationJobRequestObject()
        {
            // Snippet: CreateMigrationJob(CreateMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            CreateMigrationJobRequest request = new CreateMigrationJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationJobId = "",
                MigrationJob = new MigrationJob(),
                RequestId = "",
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.CreateMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationJobAsync</summary>
        public async Task CreateMigrationJobRequestObjectAsync()
        {
            // Snippet: CreateMigrationJobAsync(CreateMigrationJobRequest, CallSettings)
            // Additional: CreateMigrationJobAsync(CreateMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMigrationJobRequest request = new CreateMigrationJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrationJobId = "",
                MigrationJob = new MigrationJob(),
                RequestId = "",
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.CreateMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationJob</summary>
        public void CreateMigrationJob()
        {
            // Snippet: CreateMigrationJob(string, MigrationJob, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MigrationJob migrationJob = new MigrationJob();
            string migrationJobId = "";
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.CreateMigrationJob(parent, migrationJob, migrationJobId);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationJobAsync</summary>
        public async Task CreateMigrationJobAsync()
        {
            // Snippet: CreateMigrationJobAsync(string, MigrationJob, string, CallSettings)
            // Additional: CreateMigrationJobAsync(string, MigrationJob, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MigrationJob migrationJob = new MigrationJob();
            string migrationJobId = "";
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.CreateMigrationJobAsync(parent, migrationJob, migrationJobId);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationJob</summary>
        public void CreateMigrationJobResourceNames()
        {
            // Snippet: CreateMigrationJob(LocationName, MigrationJob, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MigrationJob migrationJob = new MigrationJob();
            string migrationJobId = "";
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.CreateMigrationJob(parent, migrationJob, migrationJobId);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMigrationJobAsync</summary>
        public async Task CreateMigrationJobResourceNamesAsync()
        {
            // Snippet: CreateMigrationJobAsync(LocationName, MigrationJob, string, CallSettings)
            // Additional: CreateMigrationJobAsync(LocationName, MigrationJob, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MigrationJob migrationJob = new MigrationJob();
            string migrationJobId = "";
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.CreateMigrationJobAsync(parent, migrationJob, migrationJobId);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMigrationJob</summary>
        public void UpdateMigrationJobRequestObject()
        {
            // Snippet: UpdateMigrationJob(UpdateMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            UpdateMigrationJobRequest request = new UpdateMigrationJobRequest
            {
                UpdateMask = new FieldMask(),
                MigrationJob = new MigrationJob(),
                RequestId = "",
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.UpdateMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceUpdateMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMigrationJobAsync</summary>
        public async Task UpdateMigrationJobRequestObjectAsync()
        {
            // Snippet: UpdateMigrationJobAsync(UpdateMigrationJobRequest, CallSettings)
            // Additional: UpdateMigrationJobAsync(UpdateMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMigrationJobRequest request = new UpdateMigrationJobRequest
            {
                UpdateMask = new FieldMask(),
                MigrationJob = new MigrationJob(),
                RequestId = "",
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.UpdateMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceUpdateMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMigrationJob</summary>
        public void UpdateMigrationJob()
        {
            // Snippet: UpdateMigrationJob(MigrationJob, FieldMask, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            MigrationJob migrationJob = new MigrationJob();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.UpdateMigrationJob(migrationJob, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceUpdateMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMigrationJobAsync</summary>
        public async Task UpdateMigrationJobAsync()
        {
            // Snippet: UpdateMigrationJobAsync(MigrationJob, FieldMask, CallSettings)
            // Additional: UpdateMigrationJobAsync(MigrationJob, FieldMask, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrationJob migrationJob = new MigrationJob();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.UpdateMigrationJobAsync(migrationJob, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceUpdateMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationJob</summary>
        public void DeleteMigrationJobRequestObject()
        {
            // Snippet: DeleteMigrationJob(DeleteMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            DeleteMigrationJobRequest request = new DeleteMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationJobAsync</summary>
        public async Task DeleteMigrationJobRequestObjectAsync()
        {
            // Snippet: DeleteMigrationJobAsync(DeleteMigrationJobRequest, CallSettings)
            // Additional: DeleteMigrationJobAsync(DeleteMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMigrationJobRequest request = new DeleteMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationJob</summary>
        public void DeleteMigrationJob()
        {
            // Snippet: DeleteMigrationJob(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/migrationJobs/[MIGRATION_JOB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteMigrationJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationJobAsync</summary>
        public async Task DeleteMigrationJobAsync()
        {
            // Snippet: DeleteMigrationJobAsync(string, CallSettings)
            // Additional: DeleteMigrationJobAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/migrationJobs/[MIGRATION_JOB]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteMigrationJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationJob</summary>
        public void DeleteMigrationJobResourceNames()
        {
            // Snippet: DeleteMigrationJob(MigrationJobName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            MigrationJobName name = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteMigrationJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMigrationJobAsync</summary>
        public async Task DeleteMigrationJobResourceNamesAsync()
        {
            // Snippet: DeleteMigrationJobAsync(MigrationJobName, CallSettings)
            // Additional: DeleteMigrationJobAsync(MigrationJobName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MigrationJobName name = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteMigrationJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartMigrationJob</summary>
        public void StartMigrationJobRequestObject()
        {
            // Snippet: StartMigrationJob(StartMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            StartMigrationJobRequest request = new StartMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                SkipValidation = false,
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.StartMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceStartMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartMigrationJobAsync</summary>
        public async Task StartMigrationJobRequestObjectAsync()
        {
            // Snippet: StartMigrationJobAsync(StartMigrationJobRequest, CallSettings)
            // Additional: StartMigrationJobAsync(StartMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            StartMigrationJobRequest request = new StartMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                SkipValidation = false,
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.StartMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceStartMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopMigrationJob</summary>
        public void StopMigrationJobRequestObject()
        {
            // Snippet: StopMigrationJob(StopMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            StopMigrationJobRequest request = new StopMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.StopMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceStopMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopMigrationJobAsync</summary>
        public async Task StopMigrationJobRequestObjectAsync()
        {
            // Snippet: StopMigrationJobAsync(StopMigrationJobRequest, CallSettings)
            // Additional: StopMigrationJobAsync(StopMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            StopMigrationJobRequest request = new StopMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.StopMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceStopMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeMigrationJob</summary>
        public void ResumeMigrationJobRequestObject()
        {
            // Snippet: ResumeMigrationJob(ResumeMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ResumeMigrationJobRequest request = new ResumeMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.ResumeMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceResumeMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResumeMigrationJobAsync</summary>
        public async Task ResumeMigrationJobRequestObjectAsync()
        {
            // Snippet: ResumeMigrationJobAsync(ResumeMigrationJobRequest, CallSettings)
            // Additional: ResumeMigrationJobAsync(ResumeMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResumeMigrationJobRequest request = new ResumeMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.ResumeMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceResumeMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteMigrationJob</summary>
        public void PromoteMigrationJobRequestObject()
        {
            // Snippet: PromoteMigrationJob(PromoteMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            PromoteMigrationJobRequest request = new PromoteMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.PromoteMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOncePromoteMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteMigrationJobAsync</summary>
        public async Task PromoteMigrationJobRequestObjectAsync()
        {
            // Snippet: PromoteMigrationJobAsync(PromoteMigrationJobRequest, CallSettings)
            // Additional: PromoteMigrationJobAsync(PromoteMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            PromoteMigrationJobRequest request = new PromoteMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.PromoteMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOncePromoteMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for VerifyMigrationJob</summary>
        public void VerifyMigrationJobRequestObject()
        {
            // Snippet: VerifyMigrationJob(VerifyMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            VerifyMigrationJobRequest request = new VerifyMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                UpdateMask = new FieldMask(),
                MigrationJob = new MigrationJob(),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.VerifyMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceVerifyMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for VerifyMigrationJobAsync</summary>
        public async Task VerifyMigrationJobRequestObjectAsync()
        {
            // Snippet: VerifyMigrationJobAsync(VerifyMigrationJobRequest, CallSettings)
            // Additional: VerifyMigrationJobAsync(VerifyMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            VerifyMigrationJobRequest request = new VerifyMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                UpdateMask = new FieldMask(),
                MigrationJob = new MigrationJob(),
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.VerifyMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceVerifyMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartMigrationJob</summary>
        public void RestartMigrationJobRequestObject()
        {
            // Snippet: RestartMigrationJob(RestartMigrationJobRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            RestartMigrationJobRequest request = new RestartMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                SkipValidation = false,
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = dataMigrationServiceClient.RestartMigrationJob(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceRestartMigrationJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartMigrationJobAsync</summary>
        public async Task RestartMigrationJobRequestObjectAsync()
        {
            // Snippet: RestartMigrationJobAsync(RestartMigrationJobRequest, CallSettings)
            // Additional: RestartMigrationJobAsync(RestartMigrationJobRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            RestartMigrationJobRequest request = new RestartMigrationJobRequest
            {
                MigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                SkipValidation = false,
            };
            // Make the request
            Operation<MigrationJob, OperationMetadata> response = await dataMigrationServiceClient.RestartMigrationJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MigrationJob, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MigrationJob result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigrationJob, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceRestartMigrationJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigrationJob retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateSshScript</summary>
        public void GenerateSshScriptRequestObject()
        {
            // Snippet: GenerateSshScript(GenerateSshScriptRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            GenerateSshScriptRequest request = new GenerateSshScriptRequest
            {
                MigrationJobAsMigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                Vm = "",
                VmPort = 0,
                VmCreationConfig = new VmCreationConfig(),
            };
            // Make the request
            SshScript response = dataMigrationServiceClient.GenerateSshScript(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateSshScriptAsync</summary>
        public async Task GenerateSshScriptRequestObjectAsync()
        {
            // Snippet: GenerateSshScriptAsync(GenerateSshScriptRequest, CallSettings)
            // Additional: GenerateSshScriptAsync(GenerateSshScriptRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateSshScriptRequest request = new GenerateSshScriptRequest
            {
                MigrationJobAsMigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                Vm = "",
                VmPort = 0,
                VmCreationConfig = new VmCreationConfig(),
            };
            // Make the request
            SshScript response = await dataMigrationServiceClient.GenerateSshScriptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateTcpProxyScript</summary>
        public void GenerateTcpProxyScriptRequestObject()
        {
            // Snippet: GenerateTcpProxyScript(GenerateTcpProxyScriptRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            GenerateTcpProxyScriptRequest request = new GenerateTcpProxyScriptRequest
            {
                MigrationJobAsMigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                VmName = "",
                VmMachineType = "",
                VmZone = "",
                VmSubnet = "",
            };
            // Make the request
            TcpProxyScript response = dataMigrationServiceClient.GenerateTcpProxyScript(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateTcpProxyScriptAsync</summary>
        public async Task GenerateTcpProxyScriptRequestObjectAsync()
        {
            // Snippet: GenerateTcpProxyScriptAsync(GenerateTcpProxyScriptRequest, CallSettings)
            // Additional: GenerateTcpProxyScriptAsync(GenerateTcpProxyScriptRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateTcpProxyScriptRequest request = new GenerateTcpProxyScriptRequest
            {
                MigrationJobAsMigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                VmName = "",
                VmMachineType = "",
                VmZone = "",
                VmSubnet = "",
            };
            // Make the request
            TcpProxyScript response = await dataMigrationServiceClient.GenerateTcpProxyScriptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfiles</summary>
        public void ListConnectionProfilesRequestObject()
        {
            // Snippet: ListConnectionProfiles(ListConnectionProfilesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = dataMigrationServiceClient.ListConnectionProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectionProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfilesAsync</summary>
        public async Task ListConnectionProfilesRequestObjectAsync()
        {
            // Snippet: ListConnectionProfilesAsync(ListConnectionProfilesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectionProfilesRequest request = new ListConnectionProfilesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = dataMigrationServiceClient.ListConnectionProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectionProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfiles</summary>
        public void ListConnectionProfiles()
        {
            // Snippet: ListConnectionProfiles(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = dataMigrationServiceClient.ListConnectionProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectionProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfilesAsync</summary>
        public async Task ListConnectionProfilesAsync()
        {
            // Snippet: ListConnectionProfilesAsync(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = dataMigrationServiceClient.ListConnectionProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectionProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfiles</summary>
        public void ListConnectionProfilesResourceNames()
        {
            // Snippet: ListConnectionProfiles(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = dataMigrationServiceClient.ListConnectionProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectionProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionProfilesAsync</summary>
        public async Task ListConnectionProfilesResourceNamesAsync()
        {
            // Snippet: ListConnectionProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConnectionProfilesResponse, ConnectionProfile> response = dataMigrationServiceClient.ListConnectionProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectionProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectionProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectionProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectionProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfile</summary>
        public void GetConnectionProfileRequestObject()
        {
            // Snippet: GetConnectionProfile(GetConnectionProfileRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            // Make the request
            ConnectionProfile response = dataMigrationServiceClient.GetConnectionProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfileAsync</summary>
        public async Task GetConnectionProfileRequestObjectAsync()
        {
            // Snippet: GetConnectionProfileAsync(GetConnectionProfileRequest, CallSettings)
            // Additional: GetConnectionProfileAsync(GetConnectionProfileRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionProfileRequest request = new GetConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
            };
            // Make the request
            ConnectionProfile response = await dataMigrationServiceClient.GetConnectionProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfile</summary>
        public void GetConnectionProfile()
        {
            // Snippet: GetConnectionProfile(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
            // Make the request
            ConnectionProfile response = dataMigrationServiceClient.GetConnectionProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfileAsync</summary>
        public async Task GetConnectionProfileAsync()
        {
            // Snippet: GetConnectionProfileAsync(string, CallSettings)
            // Additional: GetConnectionProfileAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
            // Make the request
            ConnectionProfile response = await dataMigrationServiceClient.GetConnectionProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfile</summary>
        public void GetConnectionProfileResourceNames()
        {
            // Snippet: GetConnectionProfile(ConnectionProfileName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConnectionProfileName name = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
            // Make the request
            ConnectionProfile response = dataMigrationServiceClient.GetConnectionProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionProfileAsync</summary>
        public async Task GetConnectionProfileResourceNamesAsync()
        {
            // Snippet: GetConnectionProfileAsync(ConnectionProfileName, CallSettings)
            // Additional: GetConnectionProfileAsync(ConnectionProfileName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionProfileName name = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
            // Make the request
            ConnectionProfile response = await dataMigrationServiceClient.GetConnectionProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfile</summary>
        public void CreateConnectionProfileRequestObject()
        {
            // Snippet: CreateConnectionProfile(CreateConnectionProfileRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            CreateConnectionProfileRequest request = new CreateConnectionProfileRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionProfileId = "",
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
                ValidateOnly = false,
                SkipValidation = false,
            };
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = dataMigrationServiceClient.CreateConnectionProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfileAsync</summary>
        public async Task CreateConnectionProfileRequestObjectAsync()
        {
            // Snippet: CreateConnectionProfileAsync(CreateConnectionProfileRequest, CallSettings)
            // Additional: CreateConnectionProfileAsync(CreateConnectionProfileRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectionProfileRequest request = new CreateConnectionProfileRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionProfileId = "",
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
                ValidateOnly = false,
                SkipValidation = false,
            };
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await dataMigrationServiceClient.CreateConnectionProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfile</summary>
        public void CreateConnectionProfile()
        {
            // Snippet: CreateConnectionProfile(string, ConnectionProfile, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = dataMigrationServiceClient.CreateConnectionProfile(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfileAsync</summary>
        public async Task CreateConnectionProfileAsync()
        {
            // Snippet: CreateConnectionProfileAsync(string, ConnectionProfile, string, CallSettings)
            // Additional: CreateConnectionProfileAsync(string, ConnectionProfile, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await dataMigrationServiceClient.CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfile</summary>
        public void CreateConnectionProfileResourceNames()
        {
            // Snippet: CreateConnectionProfile(LocationName, ConnectionProfile, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = dataMigrationServiceClient.CreateConnectionProfile(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionProfileAsync</summary>
        public async Task CreateConnectionProfileResourceNamesAsync()
        {
            // Snippet: CreateConnectionProfileAsync(LocationName, ConnectionProfile, string, CallSettings)
            // Additional: CreateConnectionProfileAsync(LocationName, ConnectionProfile, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConnectionProfile connectionProfile = new ConnectionProfile();
            string connectionProfileId = "";
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await dataMigrationServiceClient.CreateConnectionProfileAsync(parent, connectionProfile, connectionProfileId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionProfile</summary>
        public void UpdateConnectionProfileRequestObject()
        {
            // Snippet: UpdateConnectionProfile(UpdateConnectionProfileRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            UpdateConnectionProfileRequest request = new UpdateConnectionProfileRequest
            {
                UpdateMask = new FieldMask(),
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
                ValidateOnly = false,
                SkipValidation = false,
            };
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = dataMigrationServiceClient.UpdateConnectionProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceUpdateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionProfileAsync</summary>
        public async Task UpdateConnectionProfileRequestObjectAsync()
        {
            // Snippet: UpdateConnectionProfileAsync(UpdateConnectionProfileRequest, CallSettings)
            // Additional: UpdateConnectionProfileAsync(UpdateConnectionProfileRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionProfileRequest request = new UpdateConnectionProfileRequest
            {
                UpdateMask = new FieldMask(),
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
                ValidateOnly = false,
                SkipValidation = false,
            };
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await dataMigrationServiceClient.UpdateConnectionProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceUpdateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionProfile</summary>
        public void UpdateConnectionProfile()
        {
            // Snippet: UpdateConnectionProfile(ConnectionProfile, FieldMask, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConnectionProfile connectionProfile = new ConnectionProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = dataMigrationServiceClient.UpdateConnectionProfile(connectionProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceUpdateConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionProfileAsync</summary>
        public async Task UpdateConnectionProfileAsync()
        {
            // Snippet: UpdateConnectionProfileAsync(ConnectionProfile, FieldMask, CallSettings)
            // Additional: UpdateConnectionProfileAsync(ConnectionProfile, FieldMask, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionProfile connectionProfile = new ConnectionProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ConnectionProfile, OperationMetadata> response = await dataMigrationServiceClient.UpdateConnectionProfileAsync(connectionProfile, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionProfile, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceUpdateConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionProfile retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfile</summary>
        public void DeleteConnectionProfileRequestObject()
        {
            // Snippet: DeleteConnectionProfile(DeleteConnectionProfileRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            DeleteConnectionProfileRequest request = new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteConnectionProfile(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfileAsync</summary>
        public async Task DeleteConnectionProfileRequestObjectAsync()
        {
            // Snippet: DeleteConnectionProfileAsync(DeleteConnectionProfileRequest, CallSettings)
            // Additional: DeleteConnectionProfileAsync(DeleteConnectionProfileRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectionProfileRequest request = new DeleteConnectionProfileRequest
            {
                ConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteConnectionProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfile</summary>
        public void DeleteConnectionProfile()
        {
            // Snippet: DeleteConnectionProfile(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteConnectionProfile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfileAsync</summary>
        public async Task DeleteConnectionProfileAsync()
        {
            // Snippet: DeleteConnectionProfileAsync(string, CallSettings)
            // Additional: DeleteConnectionProfileAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteConnectionProfileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfile</summary>
        public void DeleteConnectionProfileResourceNames()
        {
            // Snippet: DeleteConnectionProfile(ConnectionProfileName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConnectionProfileName name = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteConnectionProfile(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteConnectionProfile(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionProfileAsync</summary>
        public async Task DeleteConnectionProfileResourceNamesAsync()
        {
            // Snippet: DeleteConnectionProfileAsync(ConnectionProfileName, CallSettings)
            // Additional: DeleteConnectionProfileAsync(ConnectionProfileName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionProfileName name = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteConnectionProfileAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteConnectionProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnectionRequestObject()
        {
            // Snippet: CreatePrivateConnection(CreatePrivateConnectionRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            CreatePrivateConnectionRequest request = new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateConnectionId = "",
                PrivateConnection = new PrivateConnection(),
                RequestId = "",
                SkipValidation = false,
            };
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = dataMigrationServiceClient.CreatePrivateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionRequestObjectAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(CreatePrivateConnectionRequest, CallSettings)
            // Additional: CreatePrivateConnectionAsync(CreatePrivateConnectionRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrivateConnectionRequest request = new CreatePrivateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PrivateConnectionId = "",
                PrivateConnection = new PrivateConnection(),
                RequestId = "",
                SkipValidation = false,
            };
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await dataMigrationServiceClient.CreatePrivateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnection()
        {
            // Snippet: CreatePrivateConnection(string, PrivateConnection, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = dataMigrationServiceClient.CreatePrivateConnection(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(string, PrivateConnection, string, CallSettings)
            // Additional: CreatePrivateConnectionAsync(string, PrivateConnection, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await dataMigrationServiceClient.CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnection</summary>
        public void CreatePrivateConnectionResourceNames()
        {
            // Snippet: CreatePrivateConnection(LocationName, PrivateConnection, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = dataMigrationServiceClient.CreatePrivateConnection(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreatePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrivateConnectionAsync</summary>
        public async Task CreatePrivateConnectionResourceNamesAsync()
        {
            // Snippet: CreatePrivateConnectionAsync(LocationName, PrivateConnection, string, CallSettings)
            // Additional: CreatePrivateConnectionAsync(LocationName, PrivateConnection, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PrivateConnection privateConnection = new PrivateConnection();
            string privateConnectionId = "";
            // Make the request
            Operation<PrivateConnection, OperationMetadata> response = await dataMigrationServiceClient.CreatePrivateConnectionAsync(parent, privateConnection, privateConnectionId);

            // Poll until the returned long-running operation is complete
            Operation<PrivateConnection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrivateConnection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrivateConnection, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreatePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrivateConnection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnectionRequestObject()
        {
            // Snippet: GetPrivateConnection(GetPrivateConnectionRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            // Make the request
            PrivateConnection response = dataMigrationServiceClient.GetPrivateConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionRequestObjectAsync()
        {
            // Snippet: GetPrivateConnectionAsync(GetPrivateConnectionRequest, CallSettings)
            // Additional: GetPrivateConnectionAsync(GetPrivateConnectionRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPrivateConnectionRequest request = new GetPrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
            };
            // Make the request
            PrivateConnection response = await dataMigrationServiceClient.GetPrivateConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnection()
        {
            // Snippet: GetPrivateConnection(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PrivateConnection response = dataMigrationServiceClient.GetPrivateConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionAsync()
        {
            // Snippet: GetPrivateConnectionAsync(string, CallSettings)
            // Additional: GetPrivateConnectionAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            PrivateConnection response = await dataMigrationServiceClient.GetPrivateConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnection</summary>
        public void GetPrivateConnectionResourceNames()
        {
            // Snippet: GetPrivateConnection(PrivateConnectionName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PrivateConnection response = dataMigrationServiceClient.GetPrivateConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrivateConnectionAsync</summary>
        public async Task GetPrivateConnectionResourceNamesAsync()
        {
            // Snippet: GetPrivateConnectionAsync(PrivateConnectionName, CallSettings)
            // Additional: GetPrivateConnectionAsync(PrivateConnectionName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            PrivateConnection response = await dataMigrationServiceClient.GetPrivateConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnectionsRequestObject()
        {
            // Snippet: ListPrivateConnections(ListPrivateConnectionsRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = dataMigrationServiceClient.ListPrivateConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsRequestObjectAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(ListPrivateConnectionsRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPrivateConnectionsRequest request = new ListPrivateConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = dataMigrationServiceClient.ListPrivateConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnections()
        {
            // Snippet: ListPrivateConnections(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = dataMigrationServiceClient.ListPrivateConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = dataMigrationServiceClient.ListPrivateConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnections</summary>
        public void ListPrivateConnectionsResourceNames()
        {
            // Snippet: ListPrivateConnections(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = dataMigrationServiceClient.ListPrivateConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrivateConnection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrivateConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrivateConnectionsAsync</summary>
        public async Task ListPrivateConnectionsResourceNamesAsync()
        {
            // Snippet: ListPrivateConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPrivateConnectionsResponse, PrivateConnection> response = dataMigrationServiceClient.ListPrivateConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrivateConnection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrivateConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrivateConnection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrivateConnection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrivateConnection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnectionRequestObject()
        {
            // Snippet: DeletePrivateConnection(DeletePrivateConnectionRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            DeletePrivateConnectionRequest request = new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeletePrivateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionRequestObjectAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(DeletePrivateConnectionRequest, CallSettings)
            // Additional: DeletePrivateConnectionAsync(DeletePrivateConnectionRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePrivateConnectionRequest request = new DeletePrivateConnectionRequest
            {
                PrivateConnectionName = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeletePrivateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnection()
        {
            // Snippet: DeletePrivateConnection(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeletePrivateConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(string, CallSettings)
            // Additional: DeletePrivateConnectionAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/privateConnections/[PRIVATE_CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeletePrivateConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnection</summary>
        public void DeletePrivateConnectionResourceNames()
        {
            // Snippet: DeletePrivateConnection(PrivateConnectionName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeletePrivateConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeletePrivateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrivateConnectionAsync</summary>
        public async Task DeletePrivateConnectionResourceNamesAsync()
        {
            // Snippet: DeletePrivateConnectionAsync(PrivateConnectionName, CallSettings)
            // Additional: DeletePrivateConnectionAsync(PrivateConnectionName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            PrivateConnectionName name = PrivateConnectionName.FromProjectLocationPrivateConnection("[PROJECT]", "[LOCATION]", "[PRIVATE_CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeletePrivateConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeletePrivateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetConversionWorkspace</summary>
        public void GetConversionWorkspaceRequestObject()
        {
            // Snippet: GetConversionWorkspace(GetConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            GetConversionWorkspaceRequest request = new GetConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
            };
            // Make the request
            ConversionWorkspace response = dataMigrationServiceClient.GetConversionWorkspace(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionWorkspaceAsync</summary>
        public async Task GetConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: GetConversionWorkspaceAsync(GetConversionWorkspaceRequest, CallSettings)
            // Additional: GetConversionWorkspaceAsync(GetConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversionWorkspaceRequest request = new GetConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
            };
            // Make the request
            ConversionWorkspace response = await dataMigrationServiceClient.GetConversionWorkspaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversionWorkspace</summary>
        public void GetConversionWorkspace()
        {
            // Snippet: GetConversionWorkspace(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            // Make the request
            ConversionWorkspace response = dataMigrationServiceClient.GetConversionWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversionWorkspaceAsync</summary>
        public async Task GetConversionWorkspaceAsync()
        {
            // Snippet: GetConversionWorkspaceAsync(string, CallSettings)
            // Additional: GetConversionWorkspaceAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            // Make the request
            ConversionWorkspace response = await dataMigrationServiceClient.GetConversionWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversionWorkspace</summary>
        public void GetConversionWorkspaceResourceNames()
        {
            // Snippet: GetConversionWorkspace(ConversionWorkspaceName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConversionWorkspaceName name = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            // Make the request
            ConversionWorkspace response = dataMigrationServiceClient.GetConversionWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversionWorkspaceAsync</summary>
        public async Task GetConversionWorkspaceResourceNamesAsync()
        {
            // Snippet: GetConversionWorkspaceAsync(ConversionWorkspaceName, CallSettings)
            // Additional: GetConversionWorkspaceAsync(ConversionWorkspaceName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionWorkspaceName name = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            // Make the request
            ConversionWorkspace response = await dataMigrationServiceClient.GetConversionWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConversionWorkspaces</summary>
        public void ListConversionWorkspacesRequestObject()
        {
            // Snippet: ListConversionWorkspaces(ListConversionWorkspacesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ListConversionWorkspacesRequest request = new ListConversionWorkspacesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> response = dataMigrationServiceClient.ListConversionWorkspaces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionWorkspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionWorkspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionWorkspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionWorkspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionWorkspacesAsync</summary>
        public async Task ListConversionWorkspacesRequestObjectAsync()
        {
            // Snippet: ListConversionWorkspacesAsync(ListConversionWorkspacesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConversionWorkspacesRequest request = new ListConversionWorkspacesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> response = dataMigrationServiceClient.ListConversionWorkspacesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionWorkspace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionWorkspacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionWorkspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionWorkspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionWorkspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionWorkspaces</summary>
        public void ListConversionWorkspaces()
        {
            // Snippet: ListConversionWorkspaces(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> response = dataMigrationServiceClient.ListConversionWorkspaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionWorkspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionWorkspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionWorkspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionWorkspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionWorkspacesAsync</summary>
        public async Task ListConversionWorkspacesAsync()
        {
            // Snippet: ListConversionWorkspacesAsync(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> response = dataMigrationServiceClient.ListConversionWorkspacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionWorkspace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionWorkspacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionWorkspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionWorkspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionWorkspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionWorkspaces</summary>
        public void ListConversionWorkspacesResourceNames()
        {
            // Snippet: ListConversionWorkspaces(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> response = dataMigrationServiceClient.ListConversionWorkspaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionWorkspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionWorkspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionWorkspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionWorkspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionWorkspacesAsync</summary>
        public async Task ListConversionWorkspacesResourceNamesAsync()
        {
            // Snippet: ListConversionWorkspacesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConversionWorkspacesResponse, ConversionWorkspace> response = dataMigrationServiceClient.ListConversionWorkspacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionWorkspace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionWorkspacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionWorkspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionWorkspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionWorkspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateConversionWorkspace</summary>
        public void CreateConversionWorkspaceRequestObject()
        {
            // Snippet: CreateConversionWorkspace(CreateConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            CreateConversionWorkspaceRequest request = new CreateConversionWorkspaceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConversionWorkspaceId = "",
                ConversionWorkspace = new ConversionWorkspace(),
                RequestId = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.CreateConversionWorkspace(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversionWorkspaceAsync</summary>
        public async Task CreateConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: CreateConversionWorkspaceAsync(CreateConversionWorkspaceRequest, CallSettings)
            // Additional: CreateConversionWorkspaceAsync(CreateConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversionWorkspaceRequest request = new CreateConversionWorkspaceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConversionWorkspaceId = "",
                ConversionWorkspace = new ConversionWorkspace(),
                RequestId = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.CreateConversionWorkspaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversionWorkspace</summary>
        public void CreateConversionWorkspace()
        {
            // Snippet: CreateConversionWorkspace(string, ConversionWorkspace, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConversionWorkspace conversionWorkspace = new ConversionWorkspace();
            string conversionWorkspaceId = "";
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.CreateConversionWorkspace(parent, conversionWorkspace, conversionWorkspaceId);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversionWorkspaceAsync</summary>
        public async Task CreateConversionWorkspaceAsync()
        {
            // Snippet: CreateConversionWorkspaceAsync(string, ConversionWorkspace, string, CallSettings)
            // Additional: CreateConversionWorkspaceAsync(string, ConversionWorkspace, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConversionWorkspace conversionWorkspace = new ConversionWorkspace();
            string conversionWorkspaceId = "";
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.CreateConversionWorkspaceAsync(parent, conversionWorkspace, conversionWorkspaceId);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversionWorkspace</summary>
        public void CreateConversionWorkspaceResourceNames()
        {
            // Snippet: CreateConversionWorkspace(LocationName, ConversionWorkspace, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConversionWorkspace conversionWorkspace = new ConversionWorkspace();
            string conversionWorkspaceId = "";
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.CreateConversionWorkspace(parent, conversionWorkspace, conversionWorkspaceId);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCreateConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversionWorkspaceAsync</summary>
        public async Task CreateConversionWorkspaceResourceNamesAsync()
        {
            // Snippet: CreateConversionWorkspaceAsync(LocationName, ConversionWorkspace, string, CallSettings)
            // Additional: CreateConversionWorkspaceAsync(LocationName, ConversionWorkspace, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConversionWorkspace conversionWorkspace = new ConversionWorkspace();
            string conversionWorkspaceId = "";
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.CreateConversionWorkspaceAsync(parent, conversionWorkspace, conversionWorkspaceId);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCreateConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionWorkspace</summary>
        public void UpdateConversionWorkspaceRequestObject()
        {
            // Snippet: UpdateConversionWorkspace(UpdateConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            UpdateConversionWorkspaceRequest request = new UpdateConversionWorkspaceRequest
            {
                UpdateMask = new FieldMask(),
                ConversionWorkspace = new ConversionWorkspace(),
                RequestId = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.UpdateConversionWorkspace(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceUpdateConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionWorkspaceAsync</summary>
        public async Task UpdateConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: UpdateConversionWorkspaceAsync(UpdateConversionWorkspaceRequest, CallSettings)
            // Additional: UpdateConversionWorkspaceAsync(UpdateConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConversionWorkspaceRequest request = new UpdateConversionWorkspaceRequest
            {
                UpdateMask = new FieldMask(),
                ConversionWorkspace = new ConversionWorkspace(),
                RequestId = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.UpdateConversionWorkspaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceUpdateConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionWorkspace</summary>
        public void UpdateConversionWorkspace()
        {
            // Snippet: UpdateConversionWorkspace(ConversionWorkspace, FieldMask, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConversionWorkspace conversionWorkspace = new ConversionWorkspace();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.UpdateConversionWorkspace(conversionWorkspace, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceUpdateConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionWorkspaceAsync</summary>
        public async Task UpdateConversionWorkspaceAsync()
        {
            // Snippet: UpdateConversionWorkspaceAsync(ConversionWorkspace, FieldMask, CallSettings)
            // Additional: UpdateConversionWorkspaceAsync(ConversionWorkspace, FieldMask, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionWorkspace conversionWorkspace = new ConversionWorkspace();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.UpdateConversionWorkspaceAsync(conversionWorkspace, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceUpdateConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionWorkspace</summary>
        public void DeleteConversionWorkspaceRequestObject()
        {
            // Snippet: DeleteConversionWorkspace(DeleteConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            DeleteConversionWorkspaceRequest request = new DeleteConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteConversionWorkspace(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionWorkspaceAsync</summary>
        public async Task DeleteConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: DeleteConversionWorkspaceAsync(DeleteConversionWorkspaceRequest, CallSettings)
            // Additional: DeleteConversionWorkspaceAsync(DeleteConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversionWorkspaceRequest request = new DeleteConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteConversionWorkspaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionWorkspace</summary>
        public void DeleteConversionWorkspace()
        {
            // Snippet: DeleteConversionWorkspace(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteConversionWorkspace(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionWorkspaceAsync</summary>
        public async Task DeleteConversionWorkspaceAsync()
        {
            // Snippet: DeleteConversionWorkspaceAsync(string, CallSettings)
            // Additional: DeleteConversionWorkspaceAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteConversionWorkspaceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionWorkspace</summary>
        public void DeleteConversionWorkspaceResourceNames()
        {
            // Snippet: DeleteConversionWorkspace(ConversionWorkspaceName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConversionWorkspaceName name = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataMigrationServiceClient.DeleteConversionWorkspace(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceDeleteConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionWorkspaceAsync</summary>
        public async Task DeleteConversionWorkspaceResourceNamesAsync()
        {
            // Snippet: DeleteConversionWorkspaceAsync(ConversionWorkspaceName, CallSettings)
            // Additional: DeleteConversionWorkspaceAsync(ConversionWorkspaceName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionWorkspaceName name = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataMigrationServiceClient.DeleteConversionWorkspaceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceDeleteConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMappingRule</summary>
        public void CreateMappingRuleRequestObject()
        {
            // Snippet: CreateMappingRule(CreateMappingRuleRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            CreateMappingRuleRequest request = new CreateMappingRuleRequest
            {
                ParentAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                MappingRuleId = "",
                MappingRule = new MappingRule(),
                RequestId = "",
            };
            // Make the request
            MappingRule response = dataMigrationServiceClient.CreateMappingRule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMappingRuleAsync</summary>
        public async Task CreateMappingRuleRequestObjectAsync()
        {
            // Snippet: CreateMappingRuleAsync(CreateMappingRuleRequest, CallSettings)
            // Additional: CreateMappingRuleAsync(CreateMappingRuleRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMappingRuleRequest request = new CreateMappingRuleRequest
            {
                ParentAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                MappingRuleId = "",
                MappingRule = new MappingRule(),
                RequestId = "",
            };
            // Make the request
            MappingRule response = await dataMigrationServiceClient.CreateMappingRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMappingRule</summary>
        public void CreateMappingRule()
        {
            // Snippet: CreateMappingRule(string, MappingRule, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            MappingRule mappingRule = new MappingRule();
            string mappingRuleId = "";
            // Make the request
            MappingRule response = dataMigrationServiceClient.CreateMappingRule(parent, mappingRule, mappingRuleId);
            // End snippet
        }

        /// <summary>Snippet for CreateMappingRuleAsync</summary>
        public async Task CreateMappingRuleAsync()
        {
            // Snippet: CreateMappingRuleAsync(string, MappingRule, string, CallSettings)
            // Additional: CreateMappingRuleAsync(string, MappingRule, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            MappingRule mappingRule = new MappingRule();
            string mappingRuleId = "";
            // Make the request
            MappingRule response = await dataMigrationServiceClient.CreateMappingRuleAsync(parent, mappingRule, mappingRuleId);
            // End snippet
        }

        /// <summary>Snippet for CreateMappingRule</summary>
        public void CreateMappingRuleResourceNames()
        {
            // Snippet: CreateMappingRule(ConversionWorkspaceName, MappingRule, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConversionWorkspaceName parent = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            MappingRule mappingRule = new MappingRule();
            string mappingRuleId = "";
            // Make the request
            MappingRule response = dataMigrationServiceClient.CreateMappingRule(parent, mappingRule, mappingRuleId);
            // End snippet
        }

        /// <summary>Snippet for CreateMappingRuleAsync</summary>
        public async Task CreateMappingRuleResourceNamesAsync()
        {
            // Snippet: CreateMappingRuleAsync(ConversionWorkspaceName, MappingRule, string, CallSettings)
            // Additional: CreateMappingRuleAsync(ConversionWorkspaceName, MappingRule, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionWorkspaceName parent = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            MappingRule mappingRule = new MappingRule();
            string mappingRuleId = "";
            // Make the request
            MappingRule response = await dataMigrationServiceClient.CreateMappingRuleAsync(parent, mappingRule, mappingRuleId);
            // End snippet
        }

        /// <summary>Snippet for DeleteMappingRule</summary>
        public void DeleteMappingRuleRequestObject()
        {
            // Snippet: DeleteMappingRule(DeleteMappingRuleRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            DeleteMappingRuleRequest request = new DeleteMappingRuleRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                RequestId = "",
            };
            // Make the request
            dataMigrationServiceClient.DeleteMappingRule(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMappingRuleAsync</summary>
        public async Task DeleteMappingRuleRequestObjectAsync()
        {
            // Snippet: DeleteMappingRuleAsync(DeleteMappingRuleRequest, CallSettings)
            // Additional: DeleteMappingRuleAsync(DeleteMappingRuleRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMappingRuleRequest request = new DeleteMappingRuleRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                RequestId = "",
            };
            // Make the request
            await dataMigrationServiceClient.DeleteMappingRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMappingRule</summary>
        public void DeleteMappingRule()
        {
            // Snippet: DeleteMappingRule(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            // Make the request
            dataMigrationServiceClient.DeleteMappingRule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMappingRuleAsync</summary>
        public async Task DeleteMappingRuleAsync()
        {
            // Snippet: DeleteMappingRuleAsync(string, CallSettings)
            // Additional: DeleteMappingRuleAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            // Make the request
            await dataMigrationServiceClient.DeleteMappingRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMappingRule</summary>
        public void DeleteMappingRuleResourceNames()
        {
            // Snippet: DeleteMappingRule(ConversionWorkspaceName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConversionWorkspaceName name = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            // Make the request
            dataMigrationServiceClient.DeleteMappingRule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMappingRuleAsync</summary>
        public async Task DeleteMappingRuleResourceNamesAsync()
        {
            // Snippet: DeleteMappingRuleAsync(ConversionWorkspaceName, CallSettings)
            // Additional: DeleteMappingRuleAsync(ConversionWorkspaceName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionWorkspaceName name = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            // Make the request
            await dataMigrationServiceClient.DeleteMappingRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMappingRules</summary>
        public void ListMappingRulesRequestObject()
        {
            // Snippet: ListMappingRules(ListMappingRulesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ListMappingRulesRequest request = new ListMappingRulesRequest
            {
                ParentAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
            };
            // Make the request
            PagedEnumerable<ListMappingRulesResponse, MappingRule> response = dataMigrationServiceClient.ListMappingRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MappingRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMappingRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MappingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MappingRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MappingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMappingRulesAsync</summary>
        public async Task ListMappingRulesRequestObjectAsync()
        {
            // Snippet: ListMappingRulesAsync(ListMappingRulesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMappingRulesRequest request = new ListMappingRulesRequest
            {
                ParentAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMappingRulesResponse, MappingRule> response = dataMigrationServiceClient.ListMappingRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MappingRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMappingRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MappingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MappingRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MappingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMappingRules</summary>
        public void ListMappingRules()
        {
            // Snippet: ListMappingRules(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            // Make the request
            PagedEnumerable<ListMappingRulesResponse, MappingRule> response = dataMigrationServiceClient.ListMappingRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MappingRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMappingRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MappingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MappingRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MappingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMappingRulesAsync</summary>
        public async Task ListMappingRulesAsync()
        {
            // Snippet: ListMappingRulesAsync(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]";
            // Make the request
            PagedAsyncEnumerable<ListMappingRulesResponse, MappingRule> response = dataMigrationServiceClient.ListMappingRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MappingRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMappingRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MappingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MappingRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MappingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMappingRules</summary>
        public void ListMappingRulesResourceNames()
        {
            // Snippet: ListMappingRules(ConversionWorkspaceName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConversionWorkspaceName parent = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            // Make the request
            PagedEnumerable<ListMappingRulesResponse, MappingRule> response = dataMigrationServiceClient.ListMappingRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MappingRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMappingRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MappingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MappingRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MappingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMappingRulesAsync</summary>
        public async Task ListMappingRulesResourceNamesAsync()
        {
            // Snippet: ListMappingRulesAsync(ConversionWorkspaceName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionWorkspaceName parent = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]");
            // Make the request
            PagedAsyncEnumerable<ListMappingRulesResponse, MappingRule> response = dataMigrationServiceClient.ListMappingRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MappingRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMappingRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MappingRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MappingRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MappingRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMappingRule</summary>
        public void GetMappingRuleRequestObject()
        {
            // Snippet: GetMappingRule(GetMappingRuleRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            GetMappingRuleRequest request = new GetMappingRuleRequest
            {
                MappingRuleName = MappingRuleName.FromProjectLocationConversionWorkspaceMappingRule("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]", "[MAPPING_RULE]"),
            };
            // Make the request
            MappingRule response = dataMigrationServiceClient.GetMappingRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetMappingRuleAsync</summary>
        public async Task GetMappingRuleRequestObjectAsync()
        {
            // Snippet: GetMappingRuleAsync(GetMappingRuleRequest, CallSettings)
            // Additional: GetMappingRuleAsync(GetMappingRuleRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMappingRuleRequest request = new GetMappingRuleRequest
            {
                MappingRuleName = MappingRuleName.FromProjectLocationConversionWorkspaceMappingRule("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]", "[MAPPING_RULE]"),
            };
            // Make the request
            MappingRule response = await dataMigrationServiceClient.GetMappingRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMappingRule</summary>
        public void GetMappingRule()
        {
            // Snippet: GetMappingRule(string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]/mappingRules/[MAPPING_RULE]";
            // Make the request
            MappingRule response = dataMigrationServiceClient.GetMappingRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetMappingRuleAsync</summary>
        public async Task GetMappingRuleAsync()
        {
            // Snippet: GetMappingRuleAsync(string, CallSettings)
            // Additional: GetMappingRuleAsync(string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversionWorkspaces/[CONVERSION_WORKSPACE]/mappingRules/[MAPPING_RULE]";
            // Make the request
            MappingRule response = await dataMigrationServiceClient.GetMappingRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMappingRule</summary>
        public void GetMappingRuleResourceNames()
        {
            // Snippet: GetMappingRule(MappingRuleName, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            MappingRuleName name = MappingRuleName.FromProjectLocationConversionWorkspaceMappingRule("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]", "[MAPPING_RULE]");
            // Make the request
            MappingRule response = dataMigrationServiceClient.GetMappingRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetMappingRuleAsync</summary>
        public async Task GetMappingRuleResourceNamesAsync()
        {
            // Snippet: GetMappingRuleAsync(MappingRuleName, CallSettings)
            // Additional: GetMappingRuleAsync(MappingRuleName, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            MappingRuleName name = MappingRuleName.FromProjectLocationConversionWorkspaceMappingRule("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]", "[MAPPING_RULE]");
            // Make the request
            MappingRule response = await dataMigrationServiceClient.GetMappingRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SeedConversionWorkspace</summary>
        public void SeedConversionWorkspaceRequestObject()
        {
            // Snippet: SeedConversionWorkspace(SeedConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            SeedConversionWorkspaceRequest request = new SeedConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                AutoCommit = false,
                SourceConnectionProfile = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.SeedConversionWorkspace(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceSeedConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SeedConversionWorkspaceAsync</summary>
        public async Task SeedConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: SeedConversionWorkspaceAsync(SeedConversionWorkspaceRequest, CallSettings)
            // Additional: SeedConversionWorkspaceAsync(SeedConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            SeedConversionWorkspaceRequest request = new SeedConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                AutoCommit = false,
                SourceConnectionProfile = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.SeedConversionWorkspaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceSeedConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportMappingRules</summary>
        public void ImportMappingRulesRequestObject()
        {
            // Snippet: ImportMappingRules(ImportMappingRulesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ImportMappingRulesRequest request = new ImportMappingRulesRequest
            {
                ParentAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                RulesFormat = ImportRulesFileFormat.Unspecified,
                RulesFiles =
                {
                    new ImportMappingRulesRequest.Types.RulesFile(),
                },
                AutoCommit = false,
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.ImportMappingRules(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceImportMappingRules(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportMappingRulesAsync</summary>
        public async Task ImportMappingRulesRequestObjectAsync()
        {
            // Snippet: ImportMappingRulesAsync(ImportMappingRulesRequest, CallSettings)
            // Additional: ImportMappingRulesAsync(ImportMappingRulesRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportMappingRulesRequest request = new ImportMappingRulesRequest
            {
                ParentAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                RulesFormat = ImportRulesFileFormat.Unspecified,
                RulesFiles =
                {
                    new ImportMappingRulesRequest.Types.RulesFile(),
                },
                AutoCommit = false,
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.ImportMappingRulesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceImportMappingRulesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConvertConversionWorkspace</summary>
        public void ConvertConversionWorkspaceRequestObject()
        {
            // Snippet: ConvertConversionWorkspace(ConvertConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConvertConversionWorkspaceRequest request = new ConvertConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                AutoCommit = false,
                Filter = "",
                ConvertFullPath = false,
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.ConvertConversionWorkspace(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceConvertConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ConvertConversionWorkspaceAsync</summary>
        public async Task ConvertConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: ConvertConversionWorkspaceAsync(ConvertConversionWorkspaceRequest, CallSettings)
            // Additional: ConvertConversionWorkspaceAsync(ConvertConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConvertConversionWorkspaceRequest request = new ConvertConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                AutoCommit = false,
                Filter = "",
                ConvertFullPath = false,
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.ConvertConversionWorkspaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceConvertConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CommitConversionWorkspace</summary>
        public void CommitConversionWorkspaceRequestObject()
        {
            // Snippet: CommitConversionWorkspace(CommitConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            CommitConversionWorkspaceRequest request = new CommitConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                CommitName = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.CommitConversionWorkspace(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceCommitConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CommitConversionWorkspaceAsync</summary>
        public async Task CommitConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: CommitConversionWorkspaceAsync(CommitConversionWorkspaceRequest, CallSettings)
            // Additional: CommitConversionWorkspaceAsync(CommitConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CommitConversionWorkspaceRequest request = new CommitConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                CommitName = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.CommitConversionWorkspaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceCommitConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackConversionWorkspace</summary>
        public void RollbackConversionWorkspaceRequestObject()
        {
            // Snippet: RollbackConversionWorkspace(RollbackConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            RollbackConversionWorkspaceRequest request = new RollbackConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.RollbackConversionWorkspace(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceRollbackConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackConversionWorkspaceAsync</summary>
        public async Task RollbackConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: RollbackConversionWorkspaceAsync(RollbackConversionWorkspaceRequest, CallSettings)
            // Additional: RollbackConversionWorkspaceAsync(RollbackConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            RollbackConversionWorkspaceRequest request = new RollbackConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.RollbackConversionWorkspaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceRollbackConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyConversionWorkspace</summary>
        public void ApplyConversionWorkspaceRequestObject()
        {
            // Snippet: ApplyConversionWorkspace(ApplyConversionWorkspaceRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ApplyConversionWorkspaceRequest request = new ApplyConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                Filter = "",
                DryRun = false,
                AutoCommit = false,
                ConnectionProfile = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = dataMigrationServiceClient.ApplyConversionWorkspace(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = dataMigrationServiceClient.PollOnceApplyConversionWorkspace(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApplyConversionWorkspaceAsync</summary>
        public async Task ApplyConversionWorkspaceRequestObjectAsync()
        {
            // Snippet: ApplyConversionWorkspaceAsync(ApplyConversionWorkspaceRequest, CallSettings)
            // Additional: ApplyConversionWorkspaceAsync(ApplyConversionWorkspaceRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApplyConversionWorkspaceRequest request = new ApplyConversionWorkspaceRequest
            {
                ConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                Filter = "",
                DryRun = false,
                AutoCommit = false,
                ConnectionProfile = "",
            };
            // Make the request
            Operation<ConversionWorkspace, OperationMetadata> response = await dataMigrationServiceClient.ApplyConversionWorkspaceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversionWorkspace, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversionWorkspace result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversionWorkspace, OperationMetadata> retrievedResponse = await dataMigrationServiceClient.PollOnceApplyConversionWorkspaceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversionWorkspace retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DescribeDatabaseEntities</summary>
        public void DescribeDatabaseEntitiesRequestObject()
        {
            // Snippet: DescribeDatabaseEntities(DescribeDatabaseEntitiesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            DescribeDatabaseEntitiesRequest request = new DescribeDatabaseEntitiesRequest
            {
                ConversionWorkspaceAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                Tree = DescribeDatabaseEntitiesRequest.Types.DBTreeType.Unspecified,
                Uncommitted = false,
                CommitId = "",
                Filter = "",
                View = DatabaseEntityView.Unspecified,
            };
            // Make the request
            PagedEnumerable<DescribeDatabaseEntitiesResponse, DatabaseEntity> response = dataMigrationServiceClient.DescribeDatabaseEntities(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatabaseEntity item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (DescribeDatabaseEntitiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseEntity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseEntity> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseEntity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DescribeDatabaseEntitiesAsync</summary>
        public async Task DescribeDatabaseEntitiesRequestObjectAsync()
        {
            // Snippet: DescribeDatabaseEntitiesAsync(DescribeDatabaseEntitiesRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DescribeDatabaseEntitiesRequest request = new DescribeDatabaseEntitiesRequest
            {
                ConversionWorkspaceAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                Tree = DescribeDatabaseEntitiesRequest.Types.DBTreeType.Unspecified,
                Uncommitted = false,
                CommitId = "",
                Filter = "",
                View = DatabaseEntityView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<DescribeDatabaseEntitiesResponse, DatabaseEntity> response = dataMigrationServiceClient.DescribeDatabaseEntitiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatabaseEntity item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((DescribeDatabaseEntitiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseEntity item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseEntity> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseEntity item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchBackgroundJobs</summary>
        public void SearchBackgroundJobsRequestObject()
        {
            // Snippet: SearchBackgroundJobs(SearchBackgroundJobsRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            SearchBackgroundJobsRequest request = new SearchBackgroundJobsRequest
            {
                ConversionWorkspaceAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                ReturnMostRecentPerJobType = false,
                MaxSize = 0,
                CompletedUntilTime = new Timestamp(),
            };
            // Make the request
            SearchBackgroundJobsResponse response = dataMigrationServiceClient.SearchBackgroundJobs(request);
            // End snippet
        }

        /// <summary>Snippet for SearchBackgroundJobsAsync</summary>
        public async Task SearchBackgroundJobsRequestObjectAsync()
        {
            // Snippet: SearchBackgroundJobsAsync(SearchBackgroundJobsRequest, CallSettings)
            // Additional: SearchBackgroundJobsAsync(SearchBackgroundJobsRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchBackgroundJobsRequest request = new SearchBackgroundJobsRequest
            {
                ConversionWorkspaceAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                ReturnMostRecentPerJobType = false,
                MaxSize = 0,
                CompletedUntilTime = new Timestamp(),
            };
            // Make the request
            SearchBackgroundJobsResponse response = await dataMigrationServiceClient.SearchBackgroundJobsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DescribeConversionWorkspaceRevisions</summary>
        public void DescribeConversionWorkspaceRevisionsRequestObject()
        {
            // Snippet: DescribeConversionWorkspaceRevisions(DescribeConversionWorkspaceRevisionsRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            DescribeConversionWorkspaceRevisionsRequest request = new DescribeConversionWorkspaceRevisionsRequest
            {
                ConversionWorkspaceAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                CommitId = "",
            };
            // Make the request
            DescribeConversionWorkspaceRevisionsResponse response = dataMigrationServiceClient.DescribeConversionWorkspaceRevisions(request);
            // End snippet
        }

        /// <summary>Snippet for DescribeConversionWorkspaceRevisionsAsync</summary>
        public async Task DescribeConversionWorkspaceRevisionsRequestObjectAsync()
        {
            // Snippet: DescribeConversionWorkspaceRevisionsAsync(DescribeConversionWorkspaceRevisionsRequest, CallSettings)
            // Additional: DescribeConversionWorkspaceRevisionsAsync(DescribeConversionWorkspaceRevisionsRequest, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DescribeConversionWorkspaceRevisionsRequest request = new DescribeConversionWorkspaceRevisionsRequest
            {
                ConversionWorkspaceAsConversionWorkspaceName = ConversionWorkspaceName.FromProjectLocationConversionWorkspace("[PROJECT]", "[LOCATION]", "[CONVERSION_WORKSPACE]"),
                CommitId = "",
            };
            // Make the request
            DescribeConversionWorkspaceRevisionsResponse response = await dataMigrationServiceClient.DescribeConversionWorkspaceRevisionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIps</summary>
        public void FetchStaticIpsRequestObject()
        {
            // Snippet: FetchStaticIps(FetchStaticIpsRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<FetchStaticIpsResponse, string> response = dataMigrationServiceClient.FetchStaticIps(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchStaticIpsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIpsAsync</summary>
        public async Task FetchStaticIpsRequestObjectAsync()
        {
            // Snippet: FetchStaticIpsAsync(FetchStaticIpsRequest, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchStaticIpsRequest request = new FetchStaticIpsRequest
            {
                LocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<FetchStaticIpsResponse, string> response = dataMigrationServiceClient.FetchStaticIpsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchStaticIpsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIps</summary>
        public void FetchStaticIps()
        {
            // Snippet: FetchStaticIps(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<FetchStaticIpsResponse, string> response = dataMigrationServiceClient.FetchStaticIps(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchStaticIpsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIpsAsync</summary>
        public async Task FetchStaticIpsAsync()
        {
            // Snippet: FetchStaticIpsAsync(string, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<FetchStaticIpsResponse, string> response = dataMigrationServiceClient.FetchStaticIpsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchStaticIpsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIps</summary>
        public void FetchStaticIpsResourceNames()
        {
            // Snippet: FetchStaticIps(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<FetchStaticIpsResponse, string> response = dataMigrationServiceClient.FetchStaticIps(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchStaticIpsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchStaticIpsAsync</summary>
        public async Task FetchStaticIpsResourceNamesAsync()
        {
            // Snippet: FetchStaticIpsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName name = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<FetchStaticIpsResponse, string> response = dataMigrationServiceClient.FetchStaticIpsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchStaticIpsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
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
