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
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcbv = Google.Cloud.Batch.V1Alpha;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBatchServiceClientSnippets
    {
        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobRequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::CreateJobRequest request = new gcbv::CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "",
                Job = new gcbv::Job(),
                RequestId = "",
            };
            // Make the request
            gcbv::Job response = batchServiceClient.CreateJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobRequestObjectAsync()
        {
            // Snippet: CreateJobAsync(CreateJobRequest, CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::CreateJobRequest request = new gcbv::CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobId = "",
                Job = new gcbv::Job(),
                RequestId = "",
            };
            // Make the request
            gcbv::Job response = await batchServiceClient.CreateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob()
        {
            // Snippet: CreateJob(string, Job, string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcbv::Job job = new gcbv::Job();
            string jobId = "";
            // Make the request
            gcbv::Job response = batchServiceClient.CreateJob(parent, job, jobId);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync()
        {
            // Snippet: CreateJobAsync(string, Job, string, CallSettings)
            // Additional: CreateJobAsync(string, Job, string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcbv::Job job = new gcbv::Job();
            string jobId = "";
            // Make the request
            gcbv::Job response = await batchServiceClient.CreateJobAsync(parent, job, jobId);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobResourceNames()
        {
            // Snippet: CreateJob(LocationName, Job, string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcbv::Job job = new gcbv::Job();
            string jobId = "";
            // Make the request
            gcbv::Job response = batchServiceClient.CreateJob(parent, job, jobId);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobResourceNamesAsync()
        {
            // Snippet: CreateJobAsync(LocationName, Job, string, CallSettings)
            // Additional: CreateJobAsync(LocationName, Job, string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcbv::Job job = new gcbv::Job();
            string jobId = "";
            // Make the request
            gcbv::Job response = await batchServiceClient.CreateJobAsync(parent, job, jobId);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobRequestObject()
        {
            // Snippet: GetJob(GetJobRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::GetJobRequest request = new gcbv::GetJobRequest
            {
                JobName = gcbv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            gcbv::Job response = batchServiceClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::GetJobRequest request = new gcbv::GetJobRequest
            {
                JobName = gcbv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            gcbv::Job response = await batchServiceClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            gcbv::Job response = batchServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            gcbv::Job response = await batchServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::JobName name = gcbv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            gcbv::Job response = batchServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobResourceNamesAsync()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::JobName name = gcbv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            gcbv::Job response = await batchServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobRequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::DeleteJobRequest request = new gcbv::DeleteJobRequest
            {
                Name = "",
                Reason = "",
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = batchServiceClient.DeleteJob(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = batchServiceClient.PollOnceDeleteJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobRequestObjectAsync()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest, CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::DeleteJobRequest request = new gcbv::DeleteJobRequest
            {
                Name = "",
                Reason = "",
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = await batchServiceClient.DeleteJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceDeleteJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = batchServiceClient.DeleteJob(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = batchServiceClient.PollOnceDeleteJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string, CallSettings)
            // Additional: DeleteJobAsync(string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "";
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = await batchServiceClient.DeleteJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceDeleteJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJobRequestObject()
        {
            // Snippet: CancelJob(CancelJobRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::CancelJobRequest request = new gcbv::CancelJobRequest
            {
                JobName = gcbv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                RequestId = "",
            };
            // Make the request
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> response = batchServiceClient.CancelJob(request);

            // Poll until the returned long-running operation is complete
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcbv::CancelJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> retrievedResponse = batchServiceClient.PollOnceCancelJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcbv::CancelJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobRequestObjectAsync()
        {
            // Snippet: CancelJobAsync(CancelJobRequest, CallSettings)
            // Additional: CancelJobAsync(CancelJobRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::CancelJobRequest request = new gcbv::CancelJobRequest
            {
                JobName = gcbv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                RequestId = "",
            };
            // Make the request
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> response = await batchServiceClient.CancelJobAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcbv::CancelJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceCancelJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcbv::CancelJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJob()
        {
            // Snippet: CancelJob(string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> response = batchServiceClient.CancelJob(name);

            // Poll until the returned long-running operation is complete
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcbv::CancelJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> retrievedResponse = batchServiceClient.PollOnceCancelJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcbv::CancelJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobAsync()
        {
            // Snippet: CancelJobAsync(string, CallSettings)
            // Additional: CancelJobAsync(string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> response = await batchServiceClient.CancelJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcbv::CancelJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceCancelJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcbv::CancelJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJobResourceNames()
        {
            // Snippet: CancelJob(JobName, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::JobName name = gcbv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> response = batchServiceClient.CancelJob(name);

            // Poll until the returned long-running operation is complete
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcbv::CancelJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> retrievedResponse = batchServiceClient.PollOnceCancelJob(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcbv::CancelJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobResourceNamesAsync()
        {
            // Snippet: CancelJobAsync(JobName, CallSettings)
            // Additional: CancelJobAsync(JobName, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::JobName name = gcbv::JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> response = await batchServiceClient.CancelJobAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcbv::CancelJobResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcbv::CancelJobResponse, gcbv::OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceCancelJobAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcbv::CancelJobResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJobRequestObject()
        {
            // Snippet: UpdateJob(UpdateJobRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::UpdateJobRequest request = new gcbv::UpdateJobRequest
            {
                Job = new gcbv::Job(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            gcbv::Job response = batchServiceClient.UpdateJob(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobRequestObjectAsync()
        {
            // Snippet: UpdateJobAsync(UpdateJobRequest, CallSettings)
            // Additional: UpdateJobAsync(UpdateJobRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::UpdateJobRequest request = new gcbv::UpdateJobRequest
            {
                Job = new gcbv::Job(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            gcbv::Job response = await batchServiceClient.UpdateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJob()
        {
            // Snippet: UpdateJob(Job, FieldMask, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::Job job = new gcbv::Job();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcbv::Job response = batchServiceClient.UpdateJob(job, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobAsync()
        {
            // Snippet: UpdateJobAsync(Job, FieldMask, CallSettings)
            // Additional: UpdateJobAsync(Job, FieldMask, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::Job job = new gcbv::Job();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcbv::Job response = await batchServiceClient.UpdateJobAsync(job, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::ListJobsRequest request = new gcbv::ListJobsRequest
            {
                Parent = "",
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcbv::ListJobsResponse, gcbv::Job> response = batchServiceClient.ListJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcbv::ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Job item in singlePage)
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
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::ListJobsRequest request = new gcbv::ListJobsRequest
            {
                Parent = "",
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcbv::ListJobsResponse, gcbv::Job> response = batchServiceClient.ListJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcbv::ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Job item in singlePage)
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
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<gcbv::ListJobsResponse, gcbv::Job> response = batchServiceClient.ListJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcbv::ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Job item in singlePage)
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
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<gcbv::ListJobsResponse, gcbv::Job> response = batchServiceClient.ListJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcbv::ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskRequestObject()
        {
            // Snippet: GetTask(GetTaskRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::GetTaskRequest request = new gcbv::GetTaskRequest
            {
                TaskName = gcbv::TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            // Make the request
            gcbv::Task response = batchServiceClient.GetTask(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskRequestObjectAsync()
        {
            // Snippet: GetTaskAsync(GetTaskRequest, CallSettings)
            // Additional: GetTaskAsync(GetTaskRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::GetTaskRequest request = new gcbv::GetTaskRequest
            {
                TaskName = gcbv::TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]"),
            };
            // Make the request
            gcbv::Task response = await batchServiceClient.GetTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask()
        {
            // Snippet: GetTask(string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/taskGroups/[TASK_GROUP]/tasks/[TASK]";
            // Make the request
            gcbv::Task response = batchServiceClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync()
        {
            // Snippet: GetTaskAsync(string, CallSettings)
            // Additional: GetTaskAsync(string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/taskGroups/[TASK_GROUP]/tasks/[TASK]";
            // Make the request
            gcbv::Task response = await batchServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskResourceNames()
        {
            // Snippet: GetTask(TaskName, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::TaskName name = gcbv::TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]");
            // Make the request
            gcbv::Task response = batchServiceClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskResourceNamesAsync()
        {
            // Snippet: GetTaskAsync(TaskName, CallSettings)
            // Additional: GetTaskAsync(TaskName, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::TaskName name = gcbv::TaskName.FromProjectLocationJobTaskGroupTask("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]", "[TASK]");
            // Make the request
            gcbv::Task response = await batchServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksRequestObject()
        {
            // Snippet: ListTasks(ListTasksRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::ListTasksRequest request = new gcbv::ListTasksRequest
            {
                ParentAsTaskGroupName = gcbv::TaskGroupName.FromProjectLocationJobTaskGroup("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcbv::ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcbv::ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksRequestObjectAsync()
        {
            // Snippet: ListTasksAsync(ListTasksRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::ListTasksRequest request = new gcbv::ListTasksRequest
            {
                ParentAsTaskGroupName = gcbv::TaskGroupName.FromProjectLocationJobTaskGroup("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcbv::ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcbv::ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks()
        {
            // Snippet: ListTasks(string, string, int?, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/taskGroups/[TASK_GROUP]";
            // Make the request
            PagedEnumerable<gcbv::ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcbv::ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksAsync()
        {
            // Snippet: ListTasksAsync(string, string, int?, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]/taskGroups/[TASK_GROUP]";
            // Make the request
            PagedAsyncEnumerable<gcbv::ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcbv::ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksResourceNames()
        {
            // Snippet: ListTasks(TaskGroupName, string, int?, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::TaskGroupName parent = gcbv::TaskGroupName.FromProjectLocationJobTaskGroup("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]");
            // Make the request
            PagedEnumerable<gcbv::ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcbv::ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksResourceNamesAsync()
        {
            // Snippet: ListTasksAsync(TaskGroupName, string, int?, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::TaskGroupName parent = gcbv::TaskGroupName.FromProjectLocationJobTaskGroup("[PROJECT]", "[LOCATION]", "[JOB]", "[TASK_GROUP]");
            // Make the request
            PagedAsyncEnumerable<gcbv::ListTasksResponse, gcbv::Task> response = batchServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcbv::ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateResourceAllowance</summary>
        public void CreateResourceAllowanceRequestObject()
        {
            // Snippet: CreateResourceAllowance(CreateResourceAllowanceRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::CreateResourceAllowanceRequest request = new gcbv::CreateResourceAllowanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ResourceAllowanceId = "",
                ResourceAllowance = new gcbv::ResourceAllowance(),
                RequestId = "",
            };
            // Make the request
            gcbv::ResourceAllowance response = batchServiceClient.CreateResourceAllowance(request);
            // End snippet
        }

        /// <summary>Snippet for CreateResourceAllowanceAsync</summary>
        public async Task CreateResourceAllowanceRequestObjectAsync()
        {
            // Snippet: CreateResourceAllowanceAsync(CreateResourceAllowanceRequest, CallSettings)
            // Additional: CreateResourceAllowanceAsync(CreateResourceAllowanceRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::CreateResourceAllowanceRequest request = new gcbv::CreateResourceAllowanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ResourceAllowanceId = "",
                ResourceAllowance = new gcbv::ResourceAllowance(),
                RequestId = "",
            };
            // Make the request
            gcbv::ResourceAllowance response = await batchServiceClient.CreateResourceAllowanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateResourceAllowance</summary>
        public void CreateResourceAllowance()
        {
            // Snippet: CreateResourceAllowance(string, ResourceAllowance, string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcbv::ResourceAllowance resourceAllowance = new gcbv::ResourceAllowance();
            string resourceAllowanceId = "";
            // Make the request
            gcbv::ResourceAllowance response = batchServiceClient.CreateResourceAllowance(parent, resourceAllowance, resourceAllowanceId);
            // End snippet
        }

        /// <summary>Snippet for CreateResourceAllowanceAsync</summary>
        public async Task CreateResourceAllowanceAsync()
        {
            // Snippet: CreateResourceAllowanceAsync(string, ResourceAllowance, string, CallSettings)
            // Additional: CreateResourceAllowanceAsync(string, ResourceAllowance, string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcbv::ResourceAllowance resourceAllowance = new gcbv::ResourceAllowance();
            string resourceAllowanceId = "";
            // Make the request
            gcbv::ResourceAllowance response = await batchServiceClient.CreateResourceAllowanceAsync(parent, resourceAllowance, resourceAllowanceId);
            // End snippet
        }

        /// <summary>Snippet for CreateResourceAllowance</summary>
        public void CreateResourceAllowanceResourceNames()
        {
            // Snippet: CreateResourceAllowance(LocationName, ResourceAllowance, string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcbv::ResourceAllowance resourceAllowance = new gcbv::ResourceAllowance();
            string resourceAllowanceId = "";
            // Make the request
            gcbv::ResourceAllowance response = batchServiceClient.CreateResourceAllowance(parent, resourceAllowance, resourceAllowanceId);
            // End snippet
        }

        /// <summary>Snippet for CreateResourceAllowanceAsync</summary>
        public async Task CreateResourceAllowanceResourceNamesAsync()
        {
            // Snippet: CreateResourceAllowanceAsync(LocationName, ResourceAllowance, string, CallSettings)
            // Additional: CreateResourceAllowanceAsync(LocationName, ResourceAllowance, string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcbv::ResourceAllowance resourceAllowance = new gcbv::ResourceAllowance();
            string resourceAllowanceId = "";
            // Make the request
            gcbv::ResourceAllowance response = await batchServiceClient.CreateResourceAllowanceAsync(parent, resourceAllowance, resourceAllowanceId);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAllowance</summary>
        public void GetResourceAllowanceRequestObject()
        {
            // Snippet: GetResourceAllowance(GetResourceAllowanceRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::GetResourceAllowanceRequest request = new gcbv::GetResourceAllowanceRequest
            {
                ResourceAllowanceName = gcbv::ResourceAllowanceName.FromProjectLocationResourceAllowance("[PROJECT]", "[LOCATION]", "[RESOURCE_ALLOWANCE]"),
            };
            // Make the request
            gcbv::ResourceAllowance response = batchServiceClient.GetResourceAllowance(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAllowanceAsync</summary>
        public async Task GetResourceAllowanceRequestObjectAsync()
        {
            // Snippet: GetResourceAllowanceAsync(GetResourceAllowanceRequest, CallSettings)
            // Additional: GetResourceAllowanceAsync(GetResourceAllowanceRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::GetResourceAllowanceRequest request = new gcbv::GetResourceAllowanceRequest
            {
                ResourceAllowanceName = gcbv::ResourceAllowanceName.FromProjectLocationResourceAllowance("[PROJECT]", "[LOCATION]", "[RESOURCE_ALLOWANCE]"),
            };
            // Make the request
            gcbv::ResourceAllowance response = await batchServiceClient.GetResourceAllowanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAllowance</summary>
        public void GetResourceAllowance()
        {
            // Snippet: GetResourceAllowance(string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceAllowances/[RESOURCE_ALLOWANCE]";
            // Make the request
            gcbv::ResourceAllowance response = batchServiceClient.GetResourceAllowance(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAllowanceAsync</summary>
        public async Task GetResourceAllowanceAsync()
        {
            // Snippet: GetResourceAllowanceAsync(string, CallSettings)
            // Additional: GetResourceAllowanceAsync(string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceAllowances/[RESOURCE_ALLOWANCE]";
            // Make the request
            gcbv::ResourceAllowance response = await batchServiceClient.GetResourceAllowanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAllowance</summary>
        public void GetResourceAllowanceResourceNames()
        {
            // Snippet: GetResourceAllowance(ResourceAllowanceName, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::ResourceAllowanceName name = gcbv::ResourceAllowanceName.FromProjectLocationResourceAllowance("[PROJECT]", "[LOCATION]", "[RESOURCE_ALLOWANCE]");
            // Make the request
            gcbv::ResourceAllowance response = batchServiceClient.GetResourceAllowance(name);
            // End snippet
        }

        /// <summary>Snippet for GetResourceAllowanceAsync</summary>
        public async Task GetResourceAllowanceResourceNamesAsync()
        {
            // Snippet: GetResourceAllowanceAsync(ResourceAllowanceName, CallSettings)
            // Additional: GetResourceAllowanceAsync(ResourceAllowanceName, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::ResourceAllowanceName name = gcbv::ResourceAllowanceName.FromProjectLocationResourceAllowance("[PROJECT]", "[LOCATION]", "[RESOURCE_ALLOWANCE]");
            // Make the request
            gcbv::ResourceAllowance response = await batchServiceClient.GetResourceAllowanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceAllowance</summary>
        public void DeleteResourceAllowanceRequestObject()
        {
            // Snippet: DeleteResourceAllowance(DeleteResourceAllowanceRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::DeleteResourceAllowanceRequest request = new gcbv::DeleteResourceAllowanceRequest
            {
                ResourceAllowanceName = gcbv::ResourceAllowanceName.FromProjectLocationResourceAllowance("[PROJECT]", "[LOCATION]", "[RESOURCE_ALLOWANCE]"),
                Reason = "",
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = batchServiceClient.DeleteResourceAllowance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = batchServiceClient.PollOnceDeleteResourceAllowance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceAllowanceAsync</summary>
        public async Task DeleteResourceAllowanceRequestObjectAsync()
        {
            // Snippet: DeleteResourceAllowanceAsync(DeleteResourceAllowanceRequest, CallSettings)
            // Additional: DeleteResourceAllowanceAsync(DeleteResourceAllowanceRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::DeleteResourceAllowanceRequest request = new gcbv::DeleteResourceAllowanceRequest
            {
                ResourceAllowanceName = gcbv::ResourceAllowanceName.FromProjectLocationResourceAllowance("[PROJECT]", "[LOCATION]", "[RESOURCE_ALLOWANCE]"),
                Reason = "",
                RequestId = "",
            };
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = await batchServiceClient.DeleteResourceAllowanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceDeleteResourceAllowanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceAllowance</summary>
        public void DeleteResourceAllowance()
        {
            // Snippet: DeleteResourceAllowance(string, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceAllowances/[RESOURCE_ALLOWANCE]";
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = batchServiceClient.DeleteResourceAllowance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = batchServiceClient.PollOnceDeleteResourceAllowance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceAllowanceAsync</summary>
        public async Task DeleteResourceAllowanceAsync()
        {
            // Snippet: DeleteResourceAllowanceAsync(string, CallSettings)
            // Additional: DeleteResourceAllowanceAsync(string, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/resourceAllowances/[RESOURCE_ALLOWANCE]";
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = await batchServiceClient.DeleteResourceAllowanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceDeleteResourceAllowanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceAllowance</summary>
        public void DeleteResourceAllowanceResourceNames()
        {
            // Snippet: DeleteResourceAllowance(ResourceAllowanceName, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::ResourceAllowanceName name = gcbv::ResourceAllowanceName.FromProjectLocationResourceAllowance("[PROJECT]", "[LOCATION]", "[RESOURCE_ALLOWANCE]");
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = batchServiceClient.DeleteResourceAllowance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = batchServiceClient.PollOnceDeleteResourceAllowance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteResourceAllowanceAsync</summary>
        public async Task DeleteResourceAllowanceResourceNamesAsync()
        {
            // Snippet: DeleteResourceAllowanceAsync(ResourceAllowanceName, CallSettings)
            // Additional: DeleteResourceAllowanceAsync(ResourceAllowanceName, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::ResourceAllowanceName name = gcbv::ResourceAllowanceName.FromProjectLocationResourceAllowance("[PROJECT]", "[LOCATION]", "[RESOURCE_ALLOWANCE]");
            // Make the request
            Operation<Empty, gcbv::OperationMetadata> response = await batchServiceClient.DeleteResourceAllowanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcbv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcbv::OperationMetadata> retrievedResponse = await batchServiceClient.PollOnceDeleteResourceAllowanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListResourceAllowances</summary>
        public void ListResourceAllowancesRequestObject()
        {
            // Snippet: ListResourceAllowances(ListResourceAllowancesRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::ListResourceAllowancesRequest request = new gcbv::ListResourceAllowancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<gcbv::ListResourceAllowancesResponse, gcbv::ResourceAllowance> response = batchServiceClient.ListResourceAllowances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::ResourceAllowance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcbv::ListResourceAllowancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::ResourceAllowance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::ResourceAllowance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::ResourceAllowance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceAllowancesAsync</summary>
        public async Task ListResourceAllowancesRequestObjectAsync()
        {
            // Snippet: ListResourceAllowancesAsync(ListResourceAllowancesRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::ListResourceAllowancesRequest request = new gcbv::ListResourceAllowancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcbv::ListResourceAllowancesResponse, gcbv::ResourceAllowance> response = batchServiceClient.ListResourceAllowancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::ResourceAllowance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcbv::ListResourceAllowancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::ResourceAllowance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::ResourceAllowance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::ResourceAllowance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceAllowances</summary>
        public void ListResourceAllowances()
        {
            // Snippet: ListResourceAllowances(string, string, int?, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcbv::ListResourceAllowancesResponse, gcbv::ResourceAllowance> response = batchServiceClient.ListResourceAllowances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::ResourceAllowance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcbv::ListResourceAllowancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::ResourceAllowance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::ResourceAllowance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::ResourceAllowance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceAllowancesAsync</summary>
        public async Task ListResourceAllowancesAsync()
        {
            // Snippet: ListResourceAllowancesAsync(string, string, int?, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcbv::ListResourceAllowancesResponse, gcbv::ResourceAllowance> response = batchServiceClient.ListResourceAllowancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::ResourceAllowance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcbv::ListResourceAllowancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::ResourceAllowance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::ResourceAllowance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::ResourceAllowance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceAllowances</summary>
        public void ListResourceAllowancesResourceNames()
        {
            // Snippet: ListResourceAllowances(LocationName, string, int?, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcbv::ListResourceAllowancesResponse, gcbv::ResourceAllowance> response = batchServiceClient.ListResourceAllowances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcbv::ResourceAllowance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcbv::ListResourceAllowancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::ResourceAllowance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::ResourceAllowance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::ResourceAllowance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListResourceAllowancesAsync</summary>
        public async Task ListResourceAllowancesResourceNamesAsync()
        {
            // Snippet: ListResourceAllowancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcbv::ListResourceAllowancesResponse, gcbv::ResourceAllowance> response = batchServiceClient.ListResourceAllowancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcbv::ResourceAllowance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcbv::ListResourceAllowancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcbv::ResourceAllowance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcbv::ResourceAllowance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcbv::ResourceAllowance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceAllowance</summary>
        public void UpdateResourceAllowanceRequestObject()
        {
            // Snippet: UpdateResourceAllowance(UpdateResourceAllowanceRequest, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::UpdateResourceAllowanceRequest request = new gcbv::UpdateResourceAllowanceRequest
            {
                ResourceAllowance = new gcbv::ResourceAllowance(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            gcbv::ResourceAllowance response = batchServiceClient.UpdateResourceAllowance(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceAllowanceAsync</summary>
        public async Task UpdateResourceAllowanceRequestObjectAsync()
        {
            // Snippet: UpdateResourceAllowanceAsync(UpdateResourceAllowanceRequest, CallSettings)
            // Additional: UpdateResourceAllowanceAsync(UpdateResourceAllowanceRequest, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::UpdateResourceAllowanceRequest request = new gcbv::UpdateResourceAllowanceRequest
            {
                ResourceAllowance = new gcbv::ResourceAllowance(),
                UpdateMask = new FieldMask(),
                RequestId = "",
            };
            // Make the request
            gcbv::ResourceAllowance response = await batchServiceClient.UpdateResourceAllowanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceAllowance</summary>
        public void UpdateResourceAllowance()
        {
            // Snippet: UpdateResourceAllowance(ResourceAllowance, FieldMask, CallSettings)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = gcbv::BatchServiceClient.Create();
            // Initialize request argument(s)
            gcbv::ResourceAllowance resourceAllowance = new gcbv::ResourceAllowance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcbv::ResourceAllowance response = batchServiceClient.UpdateResourceAllowance(resourceAllowance, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateResourceAllowanceAsync</summary>
        public async Task UpdateResourceAllowanceAsync()
        {
            // Snippet: UpdateResourceAllowanceAsync(ResourceAllowance, FieldMask, CallSettings)
            // Additional: UpdateResourceAllowanceAsync(ResourceAllowance, FieldMask, CancellationToken)
            // Create client
            gcbv::BatchServiceClient batchServiceClient = await gcbv::BatchServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcbv::ResourceAllowance resourceAllowance = new gcbv::ResourceAllowance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            gcbv::ResourceAllowance response = await batchServiceClient.UpdateResourceAllowanceAsync(resourceAllowance, updateMask);
            // End snippet
        }
    }
}
