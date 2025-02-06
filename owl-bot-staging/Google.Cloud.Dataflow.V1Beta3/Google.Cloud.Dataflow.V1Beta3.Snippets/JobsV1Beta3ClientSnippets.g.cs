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
    using Google.Cloud.Dataflow.V1Beta3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedJobsV1Beta3ClientSnippets
    {
        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobRequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest, CallSettings)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = JobsV1Beta3Client.Create();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ProjectId = "",
                Job = new Job(),
                View = JobView.Unknown,
                ReplaceJobId = "",
                Location = "",
            };
            // Make the request
            Job response = jobsV1Beta3Client.CreateJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobRequestObjectAsync()
        {
            // Snippet: CreateJobAsync(CreateJobRequest, CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest, CancellationToken)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = await JobsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ProjectId = "",
                Job = new Job(),
                View = JobView.Unknown,
                ReplaceJobId = "",
                Location = "",
            };
            // Make the request
            Job response = await jobsV1Beta3Client.CreateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobRequestObject()
        {
            // Snippet: GetJob(GetJobRequest, CallSettings)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = JobsV1Beta3Client.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "",
                JobId = "",
                View = JobView.Unknown,
                Location = "",
            };
            // Make the request
            Job response = jobsV1Beta3Client.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = await JobsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "",
                JobId = "",
                View = JobView.Unknown,
                Location = "",
            };
            // Make the request
            Job response = await jobsV1Beta3Client.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJobRequestObject()
        {
            // Snippet: UpdateJob(UpdateJobRequest, CallSettings)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = JobsV1Beta3Client.Create();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "",
                JobId = "",
                Job = new Job(),
                Location = "",
            };
            // Make the request
            Job response = jobsV1Beta3Client.UpdateJob(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobRequestObjectAsync()
        {
            // Snippet: UpdateJobAsync(UpdateJobRequest, CallSettings)
            // Additional: UpdateJobAsync(UpdateJobRequest, CancellationToken)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = await JobsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "",
                JobId = "",
                Job = new Job(),
                Location = "",
            };
            // Make the request
            Job response = await jobsV1Beta3Client.UpdateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = JobsV1Beta3Client.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ProjectId = "",
                Filter = ListJobsRequest.Types.Filter.Unknown,
                Location = "",
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = jobsV1Beta3Client.ListJobs(request);

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
            JobsV1Beta3Client jobsV1Beta3Client = await JobsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ProjectId = "",
                Filter = ListJobsRequest.Types.Filter.Unknown,
                Location = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = jobsV1Beta3Client.ListJobsAsync(request);

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

        /// <summary>Snippet for AggregatedListJobs</summary>
        public void AggregatedListJobsRequestObject()
        {
            // Snippet: AggregatedListJobs(ListJobsRequest, CallSettings)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = JobsV1Beta3Client.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ProjectId = "",
                Filter = ListJobsRequest.Types.Filter.Unknown,
                Location = "",
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = jobsV1Beta3Client.AggregatedListJobs(request);

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

        /// <summary>Snippet for AggregatedListJobsAsync</summary>
        public async Task AggregatedListJobsRequestObjectAsync()
        {
            // Snippet: AggregatedListJobsAsync(ListJobsRequest, CallSettings)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = await JobsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ProjectId = "",
                Filter = ListJobsRequest.Types.Filter.Unknown,
                Location = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = jobsV1Beta3Client.AggregatedListJobsAsync(request);

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

        /// <summary>Snippet for CheckActiveJobs</summary>
        public void CheckActiveJobsRequestObject()
        {
            // Snippet: CheckActiveJobs(CheckActiveJobsRequest, CallSettings)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = JobsV1Beta3Client.Create();
            // Initialize request argument(s)
            CheckActiveJobsRequest request = new CheckActiveJobsRequest { ProjectId = "", };
            // Make the request
            CheckActiveJobsResponse response = jobsV1Beta3Client.CheckActiveJobs(request);
            // End snippet
        }

        /// <summary>Snippet for CheckActiveJobsAsync</summary>
        public async Task CheckActiveJobsRequestObjectAsync()
        {
            // Snippet: CheckActiveJobsAsync(CheckActiveJobsRequest, CallSettings)
            // Additional: CheckActiveJobsAsync(CheckActiveJobsRequest, CancellationToken)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = await JobsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            CheckActiveJobsRequest request = new CheckActiveJobsRequest { ProjectId = "", };
            // Make the request
            CheckActiveJobsResponse response = await jobsV1Beta3Client.CheckActiveJobsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SnapshotJob</summary>
        public void SnapshotJobRequestObject()
        {
            // Snippet: SnapshotJob(SnapshotJobRequest, CallSettings)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = JobsV1Beta3Client.Create();
            // Initialize request argument(s)
            SnapshotJobRequest request = new SnapshotJobRequest
            {
                ProjectId = "",
                JobId = "",
                Ttl = new Duration(),
                Location = "",
                SnapshotSources = false,
                Description = "",
            };
            // Make the request
            Snapshot response = jobsV1Beta3Client.SnapshotJob(request);
            // End snippet
        }

        /// <summary>Snippet for SnapshotJobAsync</summary>
        public async Task SnapshotJobRequestObjectAsync()
        {
            // Snippet: SnapshotJobAsync(SnapshotJobRequest, CallSettings)
            // Additional: SnapshotJobAsync(SnapshotJobRequest, CancellationToken)
            // Create client
            JobsV1Beta3Client jobsV1Beta3Client = await JobsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            SnapshotJobRequest request = new SnapshotJobRequest
            {
                ProjectId = "",
                JobId = "",
                Ttl = new Duration(),
                Location = "",
                SnapshotSources = false,
                Description = "",
            };
            // Make the request
            Snapshot response = await jobsV1Beta3Client.SnapshotJobAsync(request);
            // End snippet
        }
    }
}
