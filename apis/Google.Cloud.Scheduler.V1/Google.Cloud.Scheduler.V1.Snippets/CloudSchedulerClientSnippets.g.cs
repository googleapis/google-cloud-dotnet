// Copyright 2019 Google LLC
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

namespace Google.Cloud.Scheduler.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedCloudSchedulerClientSnippets
    {
        /// <summary>Snippet for ListJobs</summary>
        public void ListJobs_RequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = cloudSchedulerClient.ListJobs(request);

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

        /// <summary>Snippet for ListJobs</summary>
        public async Task ListJobsAsync_RequestObject()
        {
            // Snippet: ListJobsAsync(ListJobsRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = cloudSchedulerClient.ListJobsAsync(request);

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
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = cloudSchedulerClient.ListJobs(parent);

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

        /// <summary>Snippet for ListJobs</summary>
        public async Task ListJobsAsync()
        {
            // Snippet: ListJobsAsync(string, string, int?, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = cloudSchedulerClient.ListJobsAsync(parent);

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
        public void ListJobs_ResourceNames()
        {
            // Snippet: ListJobs(LocationName, string, int?, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = cloudSchedulerClient.ListJobs(parent);

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

        /// <summary>Snippet for ListJobs</summary>
        public async Task ListJobsAsync_ResourceNames()
        {
            // Snippet: ListJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = cloudSchedulerClient.ListJobsAsync(parent);

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
        public void GetJob_RequestObject()
        {
            // Snippet: GetJob(GetJobRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = cloudSchedulerClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync_RequestObject()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = await cloudSchedulerClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = cloudSchedulerClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = await cloudSchedulerClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob_ResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = cloudSchedulerClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync_ResourceNames()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = await cloudSchedulerClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob_RequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            // Make the request
            Job response = cloudSchedulerClient.CreateJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync_RequestObject()
        {
            // Snippet: CreateJobAsync(CreateJobRequest, CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            // Make the request
            Job response = await cloudSchedulerClient.CreateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob()
        {
            // Snippet: CreateJob(string, Job, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            // Make the request
            Job response = cloudSchedulerClient.CreateJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync()
        {
            // Snippet: CreateJobAsync(string, Job, CallSettings)
            // Additional: CreateJobAsync(string, Job, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            // Make the request
            Job response = await cloudSchedulerClient.CreateJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob_ResourceNames()
        {
            // Snippet: CreateJob(LocationName, Job, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Job job = new Job();
            // Make the request
            Job response = cloudSchedulerClient.CreateJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync_ResourceNames()
        {
            // Snippet: CreateJobAsync(LocationName, Job, CallSettings)
            // Additional: CreateJobAsync(LocationName, Job, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            Job job = new Job();
            // Make the request
            Job response = await cloudSchedulerClient.CreateJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJob_RequestObject()
        {
            // Snippet: UpdateJob(UpdateJobRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Job response = cloudSchedulerClient.UpdateJob(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobAsync_RequestObject()
        {
            // Snippet: UpdateJobAsync(UpdateJobRequest, CallSettings)
            // Additional: UpdateJobAsync(UpdateJobRequest, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Job response = await cloudSchedulerClient.UpdateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJob()
        {
            // Snippet: UpdateJob(Job, FieldMask, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            Job job = new Job();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Job response = cloudSchedulerClient.UpdateJob(job, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobAsync()
        {
            // Snippet: UpdateJobAsync(Job, FieldMask, CallSettings)
            // Additional: UpdateJobAsync(Job, FieldMask, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            Job job = new Job();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Job response = await cloudSchedulerClient.UpdateJobAsync(job, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob_RequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            cloudSchedulerClient.DeleteJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync_RequestObject()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest, CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            await cloudSchedulerClient.DeleteJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            cloudSchedulerClient.DeleteJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string, CallSettings)
            // Additional: DeleteJobAsync(string, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            await cloudSchedulerClient.DeleteJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob_ResourceNames()
        {
            // Snippet: DeleteJob(JobName, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            cloudSchedulerClient.DeleteJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync_ResourceNames()
        {
            // Snippet: DeleteJobAsync(JobName, CallSettings)
            // Additional: DeleteJobAsync(JobName, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            await cloudSchedulerClient.DeleteJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseJob</summary>
        public void PauseJob_RequestObject()
        {
            // Snippet: PauseJob(PauseJobRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            PauseJobRequest request = new PauseJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = cloudSchedulerClient.PauseJob(request);
            // End snippet
        }

        /// <summary>Snippet for PauseJobAsync</summary>
        public async Task PauseJobAsync_RequestObject()
        {
            // Snippet: PauseJobAsync(PauseJobRequest, CallSettings)
            // Additional: PauseJobAsync(PauseJobRequest, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            PauseJobRequest request = new PauseJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = await cloudSchedulerClient.PauseJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseJob</summary>
        public void PauseJob()
        {
            // Snippet: PauseJob(string, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = cloudSchedulerClient.PauseJob(name);
            // End snippet
        }

        /// <summary>Snippet for PauseJobAsync</summary>
        public async Task PauseJobAsync()
        {
            // Snippet: PauseJobAsync(string, CallSettings)
            // Additional: PauseJobAsync(string, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = await cloudSchedulerClient.PauseJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseJob</summary>
        public void PauseJob_ResourceNames()
        {
            // Snippet: PauseJob(JobName, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = cloudSchedulerClient.PauseJob(name);
            // End snippet
        }

        /// <summary>Snippet for PauseJobAsync</summary>
        public async Task PauseJobAsync_ResourceNames()
        {
            // Snippet: PauseJobAsync(JobName, CallSettings)
            // Additional: PauseJobAsync(JobName, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = await cloudSchedulerClient.PauseJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeJob</summary>
        public void ResumeJob_RequestObject()
        {
            // Snippet: ResumeJob(ResumeJobRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            ResumeJobRequest request = new ResumeJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = cloudSchedulerClient.ResumeJob(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeJobAsync</summary>
        public async Task ResumeJobAsync_RequestObject()
        {
            // Snippet: ResumeJobAsync(ResumeJobRequest, CallSettings)
            // Additional: ResumeJobAsync(ResumeJobRequest, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            ResumeJobRequest request = new ResumeJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = await cloudSchedulerClient.ResumeJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeJob</summary>
        public void ResumeJob()
        {
            // Snippet: ResumeJob(string, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = cloudSchedulerClient.ResumeJob(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeJobAsync</summary>
        public async Task ResumeJobAsync()
        {
            // Snippet: ResumeJobAsync(string, CallSettings)
            // Additional: ResumeJobAsync(string, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = await cloudSchedulerClient.ResumeJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeJob</summary>
        public void ResumeJob_ResourceNames()
        {
            // Snippet: ResumeJob(JobName, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = cloudSchedulerClient.ResumeJob(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeJobAsync</summary>
        public async Task ResumeJobAsync_ResourceNames()
        {
            // Snippet: ResumeJobAsync(JobName, CallSettings)
            // Additional: ResumeJobAsync(JobName, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = await cloudSchedulerClient.ResumeJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunJob</summary>
        public void RunJob_RequestObject()
        {
            // Snippet: RunJob(RunJobRequest, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            RunJobRequest request = new RunJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = cloudSchedulerClient.RunJob(request);
            // End snippet
        }

        /// <summary>Snippet for RunJobAsync</summary>
        public async Task RunJobAsync_RequestObject()
        {
            // Snippet: RunJobAsync(RunJobRequest, CallSettings)
            // Additional: RunJobAsync(RunJobRequest, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            RunJobRequest request = new RunJobRequest
            {
                JobName = new JobName("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = await cloudSchedulerClient.RunJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunJob</summary>
        public void RunJob()
        {
            // Snippet: RunJob(string, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = cloudSchedulerClient.RunJob(name);
            // End snippet
        }

        /// <summary>Snippet for RunJobAsync</summary>
        public async Task RunJobAsync()
        {
            // Snippet: RunJobAsync(string, CallSettings)
            // Additional: RunJobAsync(string, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = await cloudSchedulerClient.RunJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunJob</summary>
        public void RunJob_ResourceNames()
        {
            // Snippet: RunJob(JobName, CallSettings)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = CloudSchedulerClient.Create();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = cloudSchedulerClient.RunJob(name);
            // End snippet
        }

        /// <summary>Snippet for RunJobAsync</summary>
        public async Task RunJobAsync_ResourceNames()
        {
            // Snippet: RunJobAsync(JobName, CallSettings)
            // Additional: RunJobAsync(JobName, CancellationToken)
            // Create client
            CloudSchedulerClient cloudSchedulerClient = await CloudSchedulerClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = new JobName("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = await cloudSchedulerClient.RunJobAsync(name);
            // End snippet
        }
    }
}
