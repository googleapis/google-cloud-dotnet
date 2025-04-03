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
    using Google.Cloud.StorageBatchOperations.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStorageBatchOperationsClientSnippets
    {
        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = storageBatchOperationsClient.ListJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsRequestObjectAsync()
        {
            // Snippet: ListJobsAsync(ListJobsRequest, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = storageBatchOperationsClient.ListJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobs()
        {
            // Snippet: ListJobs(string, string, int?, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = storageBatchOperationsClient.ListJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsAsync()
        {
            // Snippet: ListJobsAsync(string, string, int?, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = storageBatchOperationsClient.ListJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsResourceNames()
        {
            // Snippet: ListJobs(LocationName, string, int?, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = storageBatchOperationsClient.ListJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsResourceNamesAsync()
        {
            // Snippet: ListJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = storageBatchOperationsClient.ListJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobRequestObject()
        {
            // Snippet: GetJob(GetJobRequest, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = storageBatchOperationsClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = await storageBatchOperationsClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = storageBatchOperationsClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = await storageBatchOperationsClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = storageBatchOperationsClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobResourceNamesAsync()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = await storageBatchOperationsClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobRequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "",
                Job = new Job(),
                RequestId = "",
            };
            // Make the request
            Operation<Job, OperationMetadata> response = storageBatchOperationsClient.CreateJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Job, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Job, OperationMetadata> retrievedResponse = storageBatchOperationsClient.PollOnceCreateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobRequestObjectAsync()
        {
            // Snippet: CreateJobAsync(CreateJobRequest, CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "",
                Job = new Job(),
                RequestId = "",
            };
            // Make the request
            Operation<Job, OperationMetadata> response = await storageBatchOperationsClient.CreateJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Job, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Job, OperationMetadata> retrievedResponse = await storageBatchOperationsClient.PollOnceCreateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob()
        {
            // Snippet: CreateJob(string, Job, string, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            string jobId = "";
            // Make the request
            Operation<Job, OperationMetadata> response = storageBatchOperationsClient.CreateJob(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<Job, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Job, OperationMetadata> retrievedResponse = storageBatchOperationsClient.PollOnceCreateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync()
        {
            // Snippet: CreateJobAsync(string, Job, string, CallSettings)
            // Additional: CreateJobAsync(string, Job, string, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            string jobId = "";
            // Make the request
            Operation<Job, OperationMetadata> response = await storageBatchOperationsClient.CreateJobAsync(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<Job, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Job, OperationMetadata> retrievedResponse = await storageBatchOperationsClient.PollOnceCreateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobResourceNames()
        {
            // Snippet: CreateJob(LocationName, Job, string, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Job job = new Job();
            string jobId = "";
            // Make the request
            Operation<Job, OperationMetadata> response = storageBatchOperationsClient.CreateJob(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<Job, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Job, OperationMetadata> retrievedResponse = storageBatchOperationsClient.PollOnceCreateJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobResourceNamesAsync()
        {
            // Snippet: CreateJobAsync(LocationName, Job, string, CallSettings)
            // Additional: CreateJobAsync(LocationName, Job, string, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Job job = new Job();
            string jobId = "";
            // Make the request
            Operation<Job, OperationMetadata> response = await storageBatchOperationsClient.CreateJobAsync(parent, job, jobId);

            // Poll until the returned long-running operation is complete
            Operation<Job, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Job result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Job, OperationMetadata> retrievedResponse = await storageBatchOperationsClient.PollOnceCreateJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Job retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobRequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                RequestId = "",
            };
            // Make the request
            storageBatchOperationsClient.DeleteJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobRequestObjectAsync()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest, CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                RequestId = "",
            };
            // Make the request
            await storageBatchOperationsClient.DeleteJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            storageBatchOperationsClient.DeleteJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string, CallSettings)
            // Additional: DeleteJobAsync(string, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            await storageBatchOperationsClient.DeleteJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobResourceNames()
        {
            // Snippet: DeleteJob(JobName, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            storageBatchOperationsClient.DeleteJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobResourceNamesAsync()
        {
            // Snippet: DeleteJobAsync(JobName, CallSettings)
            // Additional: DeleteJobAsync(JobName, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            await storageBatchOperationsClient.DeleteJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJobRequestObject()
        {
            // Snippet: CancelJob(CancelJobRequest, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                RequestId = "",
            };
            // Make the request
            CancelJobResponse response = storageBatchOperationsClient.CancelJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobRequestObjectAsync()
        {
            // Snippet: CancelJobAsync(CancelJobRequest, CallSettings)
            // Additional: CancelJobAsync(CancelJobRequest, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                RequestId = "",
            };
            // Make the request
            CancelJobResponse response = await storageBatchOperationsClient.CancelJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJob()
        {
            // Snippet: CancelJob(string, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            CancelJobResponse response = storageBatchOperationsClient.CancelJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobAsync()
        {
            // Snippet: CancelJobAsync(string, CallSettings)
            // Additional: CancelJobAsync(string, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            CancelJobResponse response = await storageBatchOperationsClient.CancelJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJobResourceNames()
        {
            // Snippet: CancelJob(JobName, CallSettings)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = StorageBatchOperationsClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            CancelJobResponse response = storageBatchOperationsClient.CancelJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobResourceNamesAsync()
        {
            // Snippet: CancelJobAsync(JobName, CallSettings)
            // Additional: CancelJobAsync(JobName, CancellationToken)
            // Create client
            StorageBatchOperationsClient storageBatchOperationsClient = await StorageBatchOperationsClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            CancelJobResponse response = await storageBatchOperationsClient.CancelJobAsync(name);
            // End snippet
        }
    }
}
