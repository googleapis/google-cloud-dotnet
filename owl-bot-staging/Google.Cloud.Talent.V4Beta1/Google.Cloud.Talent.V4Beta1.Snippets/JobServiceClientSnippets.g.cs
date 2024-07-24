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
    using Google.Cloud.Talent.V4Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobRequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job(),
            };
            // Make the request
            Job response = jobServiceClient.CreateJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobRequestObjectAsync()
        {
            // Snippet: CreateJobAsync(CreateJobRequest, CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Job = new Job(),
            };
            // Make the request
            Job response = await jobServiceClient.CreateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob()
        {
            // Snippet: CreateJob(string, Job, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            Job job = new Job();
            // Make the request
            Job response = jobServiceClient.CreateJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync()
        {
            // Snippet: CreateJobAsync(string, Job, CallSettings)
            // Additional: CreateJobAsync(string, Job, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            Job job = new Job();
            // Make the request
            Job response = await jobServiceClient.CreateJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobResourceNames1()
        {
            // Snippet: CreateJob(TenantName, Job, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            Job job = new Job();
            // Make the request
            Job response = jobServiceClient.CreateJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobResourceNames1Async()
        {
            // Snippet: CreateJobAsync(TenantName, Job, CallSettings)
            // Additional: CreateJobAsync(TenantName, Job, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            Job job = new Job();
            // Make the request
            Job response = await jobServiceClient.CreateJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobResourceNames2()
        {
            // Snippet: CreateJob(ProjectName, Job, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Job job = new Job();
            // Make the request
            Job response = jobServiceClient.CreateJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobResourceNames2Async()
        {
            // Snippet: CreateJobAsync(ProjectName, Job, CallSettings)
            // Additional: CreateJobAsync(ProjectName, Job, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Job job = new Job();
            // Make the request
            Job response = await jobServiceClient.CreateJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateJobs</summary>
        public void BatchCreateJobsRequestObject()
        {
            // Snippet: BatchCreateJobs(BatchCreateJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateJobsRequest request = new BatchCreateJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Jobs = { new Job(), },
            };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchCreateJobs(request);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchCreateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateJobsAsync</summary>
        public async Task BatchCreateJobsRequestObjectAsync()
        {
            // Snippet: BatchCreateJobsAsync(BatchCreateJobsRequest, CallSettings)
            // Additional: BatchCreateJobsAsync(BatchCreateJobsRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateJobsRequest request = new BatchCreateJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Jobs = { new Job(), },
            };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = await jobServiceClient.BatchCreateJobsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceBatchCreateJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateJobs</summary>
        public void BatchCreateJobs()
        {
            // Snippet: BatchCreateJobs(string, IEnumerable<Job>, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchCreateJobs(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchCreateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateJobsAsync</summary>
        public async Task BatchCreateJobsAsync()
        {
            // Snippet: BatchCreateJobsAsync(string, IEnumerable<Job>, CallSettings)
            // Additional: BatchCreateJobsAsync(string, IEnumerable<Job>, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = await jobServiceClient.BatchCreateJobsAsync(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceBatchCreateJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateJobs</summary>
        public void BatchCreateJobsResourceNames1()
        {
            // Snippet: BatchCreateJobs(TenantName, IEnumerable<Job>, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchCreateJobs(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchCreateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateJobsAsync</summary>
        public async Task BatchCreateJobsResourceNames1Async()
        {
            // Snippet: BatchCreateJobsAsync(TenantName, IEnumerable<Job>, CallSettings)
            // Additional: BatchCreateJobsAsync(TenantName, IEnumerable<Job>, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = await jobServiceClient.BatchCreateJobsAsync(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceBatchCreateJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateJobs</summary>
        public void BatchCreateJobsResourceNames2()
        {
            // Snippet: BatchCreateJobs(ProjectName, IEnumerable<Job>, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchCreateJobs(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchCreateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateJobsAsync</summary>
        public async Task BatchCreateJobsResourceNames2Async()
        {
            // Snippet: BatchCreateJobsAsync(ProjectName, IEnumerable<Job>, CallSettings)
            // Additional: BatchCreateJobsAsync(ProjectName, IEnumerable<Job>, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = await jobServiceClient.BatchCreateJobsAsync(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceBatchCreateJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobRequestObject()
        {
            // Snippet: GetJob(GetJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            // Make the request
            Job response = jobServiceClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            // Make the request
            Job response = await jobServiceClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/jobs/[JOB]";
            // Make the request
            Job response = jobServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/jobs/[JOB]";
            // Make the request
            Job response = await jobServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]");
            // Make the request
            Job response = jobServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobResourceNamesAsync()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]");
            // Make the request
            Job response = await jobServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJobRequestObject()
        {
            // Snippet: UpdateJob(UpdateJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Job response = jobServiceClient.UpdateJob(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobRequestObjectAsync()
        {
            // Snippet: UpdateJobAsync(UpdateJobRequest, CallSettings)
            // Additional: UpdateJobAsync(UpdateJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Job response = await jobServiceClient.UpdateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJob()
        {
            // Snippet: UpdateJob(Job, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            Job job = new Job();
            // Make the request
            Job response = jobServiceClient.UpdateJob(job);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobAsync()
        {
            // Snippet: UpdateJobAsync(Job, CallSettings)
            // Additional: UpdateJobAsync(Job, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            Job job = new Job();
            // Make the request
            Job response = await jobServiceClient.UpdateJobAsync(job);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateJobs</summary>
        public void BatchUpdateJobsRequestObject()
        {
            // Snippet: BatchUpdateJobs(BatchUpdateJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateJobsRequest request = new BatchUpdateJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Jobs = { new Job(), },
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchUpdateJobs(request);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchUpdateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateJobsAsync</summary>
        public async Task BatchUpdateJobsRequestObjectAsync()
        {
            // Snippet: BatchUpdateJobsAsync(BatchUpdateJobsRequest, CallSettings)
            // Additional: BatchUpdateJobsAsync(BatchUpdateJobsRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateJobsRequest request = new BatchUpdateJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Jobs = { new Job(), },
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = await jobServiceClient.BatchUpdateJobsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceBatchUpdateJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateJobs</summary>
        public void BatchUpdateJobs()
        {
            // Snippet: BatchUpdateJobs(string, IEnumerable<Job>, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchUpdateJobs(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchUpdateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateJobsAsync</summary>
        public async Task BatchUpdateJobsAsync()
        {
            // Snippet: BatchUpdateJobsAsync(string, IEnumerable<Job>, CallSettings)
            // Additional: BatchUpdateJobsAsync(string, IEnumerable<Job>, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = await jobServiceClient.BatchUpdateJobsAsync(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceBatchUpdateJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateJobs</summary>
        public void BatchUpdateJobsResourceNames1()
        {
            // Snippet: BatchUpdateJobs(TenantName, IEnumerable<Job>, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchUpdateJobs(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchUpdateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateJobsAsync</summary>
        public async Task BatchUpdateJobsResourceNames1Async()
        {
            // Snippet: BatchUpdateJobsAsync(TenantName, IEnumerable<Job>, CallSettings)
            // Additional: BatchUpdateJobsAsync(TenantName, IEnumerable<Job>, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = await jobServiceClient.BatchUpdateJobsAsync(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceBatchUpdateJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateJobs</summary>
        public void BatchUpdateJobsResourceNames2()
        {
            // Snippet: BatchUpdateJobs(ProjectName, IEnumerable<Job>, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = jobServiceClient.BatchUpdateJobs(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = jobServiceClient.PollOnceBatchUpdateJobs(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateJobsAsync</summary>
        public async Task BatchUpdateJobsResourceNames2Async()
        {
            // Snippet: BatchUpdateJobsAsync(ProjectName, IEnumerable<Job>, CallSettings)
            // Additional: BatchUpdateJobsAsync(ProjectName, IEnumerable<Job>, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Job> jobs = new Job[] { new Job(), };
            // Make the request
            Operation<JobOperationResult, BatchOperationMetadata> response = await jobServiceClient.BatchUpdateJobsAsync(parent, jobs);

            // Poll until the returned long-running operation is complete
            Operation<JobOperationResult, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            JobOperationResult result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<JobOperationResult, BatchOperationMetadata> retrievedResponse = await jobServiceClient.PollOnceBatchUpdateJobsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                JobOperationResult retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobRequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            // Make the request
            jobServiceClient.DeleteJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobRequestObjectAsync()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest, CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]"),
            };
            // Make the request
            await jobServiceClient.DeleteJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/jobs/[JOB]";
            // Make the request
            jobServiceClient.DeleteJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string, CallSettings)
            // Additional: DeleteJobAsync(string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/tenants/[TENANT]/jobs/[JOB]";
            // Make the request
            await jobServiceClient.DeleteJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobResourceNames()
        {
            // Snippet: DeleteJob(JobName, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]");
            // Make the request
            jobServiceClient.DeleteJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobResourceNamesAsync()
        {
            // Snippet: DeleteJobAsync(JobName, CallSettings)
            // Additional: DeleteJobAsync(JobName, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectTenantJob("[PROJECT]", "[TENANT]", "[JOB]");
            // Make the request
            await jobServiceClient.DeleteJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobs</summary>
        public void BatchDeleteJobsRequestObject()
        {
            // Snippet: BatchDeleteJobs(BatchDeleteJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "",
            };
            // Make the request
            jobServiceClient.BatchDeleteJobs(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobsAsync</summary>
        public async Task BatchDeleteJobsRequestObjectAsync()
        {
            // Snippet: BatchDeleteJobsAsync(BatchDeleteJobsRequest, CallSettings)
            // Additional: BatchDeleteJobsAsync(BatchDeleteJobsRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "",
            };
            // Make the request
            await jobServiceClient.BatchDeleteJobsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobs</summary>
        public void BatchDeleteJobs()
        {
            // Snippet: BatchDeleteJobs(string, string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            string filter = "";
            // Make the request
            jobServiceClient.BatchDeleteJobs(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobsAsync</summary>
        public async Task BatchDeleteJobsAsync()
        {
            // Snippet: BatchDeleteJobsAsync(string, string, CallSettings)
            // Additional: BatchDeleteJobsAsync(string, string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            string filter = "";
            // Make the request
            await jobServiceClient.BatchDeleteJobsAsync(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobs</summary>
        public void BatchDeleteJobsResourceNames1()
        {
            // Snippet: BatchDeleteJobs(TenantName, string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            string filter = "";
            // Make the request
            jobServiceClient.BatchDeleteJobs(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobsAsync</summary>
        public async Task BatchDeleteJobsResourceNames1Async()
        {
            // Snippet: BatchDeleteJobsAsync(TenantName, string, CallSettings)
            // Additional: BatchDeleteJobsAsync(TenantName, string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            string filter = "";
            // Make the request
            await jobServiceClient.BatchDeleteJobsAsync(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobs</summary>
        public void BatchDeleteJobsResourceNames2()
        {
            // Snippet: BatchDeleteJobs(ProjectName, string, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            jobServiceClient.BatchDeleteJobs(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobsAsync</summary>
        public async Task BatchDeleteJobsResourceNames2Async()
        {
            // Snippet: BatchDeleteJobsAsync(ProjectName, string, CallSettings)
            // Additional: BatchDeleteJobsAsync(ProjectName, string, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            await jobServiceClient.BatchDeleteJobsAsync(parent, filter);
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "",
                JobView = JobView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = jobServiceClient.ListJobs(request);

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
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                Filter = "",
                JobView = JobView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = jobServiceClient.ListJobsAsync(request);

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
            // Snippet: ListJobs(string, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = jobServiceClient.ListJobs(parent, filter);

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
            // Snippet: ListJobsAsync(string, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/tenants/[TENANT]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = jobServiceClient.ListJobsAsync(parent, filter);

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
        public void ListJobsResourceNames1()
        {
            // Snippet: ListJobs(TenantName, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = jobServiceClient.ListJobs(parent, filter);

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
        public async Task ListJobsResourceNames1Async()
        {
            // Snippet: ListJobsAsync(TenantName, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            TenantName parent = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = jobServiceClient.ListJobsAsync(parent, filter);

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
        public void ListJobsResourceNames2()
        {
            // Snippet: ListJobs(ProjectName, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = jobServiceClient.ListJobs(parent, filter);

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
        public async Task ListJobsResourceNames2Async()
        {
            // Snippet: ListJobsAsync(ProjectName, string, string, int?, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = jobServiceClient.ListJobsAsync(parent, filter);

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

        /// <summary>Snippet for SearchJobs</summary>
        public void SearchJobsRequestObject()
        {
            // Snippet: SearchJobs(SearchJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            SearchJobsRequest request = new SearchJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                SearchMode = SearchJobsRequest.Types.SearchMode.Unspecified,
                RequestMetadata = new RequestMetadata(),
                JobQuery = new JobQuery(),
                EnableBroadening = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                JobView = JobView.Unspecified,
                Offset = 0,
                PageSize = 0,
                PageToken = "",
                OrderBy = "",
                DiversificationLevel = SearchJobsRequest.Types.DiversificationLevel.Unspecified,
                CustomRankingInfo = new SearchJobsRequest.Types.CustomRankingInfo(),
                DisableKeywordMatch = false,
                KeywordMatchMode = SearchJobsRequest.Types.KeywordMatchMode.Unspecified,
            };
            // Make the request
            SearchJobsResponse response = jobServiceClient.SearchJobs(request);
            // End snippet
        }

        /// <summary>Snippet for SearchJobsAsync</summary>
        public async Task SearchJobsRequestObjectAsync()
        {
            // Snippet: SearchJobsAsync(SearchJobsRequest, CallSettings)
            // Additional: SearchJobsAsync(SearchJobsRequest, CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchJobsRequest request = new SearchJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                SearchMode = SearchJobsRequest.Types.SearchMode.Unspecified,
                RequestMetadata = new RequestMetadata(),
                JobQuery = new JobQuery(),
                EnableBroadening = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                JobView = JobView.Unspecified,
                Offset = 0,
                PageSize = 0,
                PageToken = "",
                OrderBy = "",
                DiversificationLevel = SearchJobsRequest.Types.DiversificationLevel.Unspecified,
                CustomRankingInfo = new SearchJobsRequest.Types.CustomRankingInfo(),
                DisableKeywordMatch = false,
                KeywordMatchMode = SearchJobsRequest.Types.KeywordMatchMode.Unspecified,
            };
            // Make the request
            SearchJobsResponse response = await jobServiceClient.SearchJobsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchJobsForAlert</summary>
        public void SearchJobsForAlertRequestObject()
        {
            // Snippet: SearchJobsForAlert(SearchJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            SearchJobsRequest request = new SearchJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                SearchMode = SearchJobsRequest.Types.SearchMode.Unspecified,
                RequestMetadata = new RequestMetadata(),
                JobQuery = new JobQuery(),
                EnableBroadening = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                JobView = JobView.Unspecified,
                Offset = 0,
                OrderBy = "",
                DiversificationLevel = SearchJobsRequest.Types.DiversificationLevel.Unspecified,
                CustomRankingInfo = new SearchJobsRequest.Types.CustomRankingInfo(),
                DisableKeywordMatch = false,
                KeywordMatchMode = SearchJobsRequest.Types.KeywordMatchMode.Unspecified,
            };
            // Make the request
            PagedEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> response = jobServiceClient.SearchJobsForAlert(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchJobsResponse.Types.MatchingJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchJobsResponse.Types.MatchingJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchJobsResponse.Types.MatchingJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchJobsResponse.Types.MatchingJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchJobsForAlertAsync</summary>
        public async Task SearchJobsForAlertRequestObjectAsync()
        {
            // Snippet: SearchJobsForAlertAsync(SearchJobsRequest, CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchJobsRequest request = new SearchJobsRequest
            {
                ParentAsTenantName = TenantName.FromProjectTenant("[PROJECT]", "[TENANT]"),
                SearchMode = SearchJobsRequest.Types.SearchMode.Unspecified,
                RequestMetadata = new RequestMetadata(),
                JobQuery = new JobQuery(),
                EnableBroadening = false,
                HistogramQueries =
                {
                    new HistogramQuery(),
                },
                JobView = JobView.Unspecified,
                Offset = 0,
                OrderBy = "",
                DiversificationLevel = SearchJobsRequest.Types.DiversificationLevel.Unspecified,
                CustomRankingInfo = new SearchJobsRequest.Types.CustomRankingInfo(),
                DisableKeywordMatch = false,
                KeywordMatchMode = SearchJobsRequest.Types.KeywordMatchMode.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<SearchJobsResponse, SearchJobsResponse.Types.MatchingJob> response = jobServiceClient.SearchJobsForAlertAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchJobsResponse.Types.MatchingJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchJobsResponse.Types.MatchingJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchJobsResponse.Types.MatchingJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchJobsResponse.Types.MatchingJob item in singlePage)
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
