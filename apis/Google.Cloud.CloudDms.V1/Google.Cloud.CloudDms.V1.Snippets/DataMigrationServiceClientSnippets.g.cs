// Copyright 2022 Google LLC
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

namespace Google.Cloud.CloudDms.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
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
                ParentAsConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                ConnectionProfileId = "",
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
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
                ParentAsConnectionProfileName = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]"),
                ConnectionProfileId = "",
                ConnectionProfile = new ConnectionProfile(),
                RequestId = "",
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connectionProfiles/[CONNECTION_PROFILE]";
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
            // Snippet: CreateConnectionProfile(ConnectionProfileName, ConnectionProfile, string, CallSettings)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            ConnectionProfileName parent = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
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
            // Snippet: CreateConnectionProfileAsync(ConnectionProfileName, ConnectionProfile, string, CallSettings)
            // Additional: CreateConnectionProfileAsync(ConnectionProfileName, ConnectionProfile, string, CancellationToken)
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = await DataMigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionProfileName parent = ConnectionProfileName.FromProjectLocationConnectionProfile("[PROJECT]", "[LOCATION]", "[CONNECTION_PROFILE]");
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
    }
}
