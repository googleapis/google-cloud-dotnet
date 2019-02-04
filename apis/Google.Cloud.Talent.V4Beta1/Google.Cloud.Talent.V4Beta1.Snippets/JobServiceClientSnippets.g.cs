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

namespace Google.Cloud.Talent.V4Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Talent.V4Beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using static SearchJobsResponse.Types;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync()
        {
            // Snippet: CreateJobAsync(string,Job,CallSettings)
            // Additional: CreateJobAsync(string,Job,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            Job job = new Job();
            // Make the request
            Job response = await jobServiceClient.CreateJobAsync(formattedParent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob()
        {
            // Snippet: CreateJob(string,Job,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            Job job = new Job();
            // Make the request
            Job response = jobServiceClient.CreateJob(formattedParent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync_RequestObject()
        {
            // Snippet: CreateJobAsync(CreateJobRequest,CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                Job = new Job(),
            };
            // Make the request
            Job response = await jobServiceClient.CreateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob_RequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                Job = new Job(),
            };
            // Make the request
            Job response = jobServiceClient.CreateJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string,CallSettings)
            // Additional: GetJobAsync(string,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new JobName("[PROJECT]", "[JOB]").ToString();
            // Make the request
            Job response = await jobServiceClient.GetJobAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new JobName("[PROJECT]", "[JOB]").ToString();
            // Make the request
            Job response = jobServiceClient.GetJob(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync_RequestObject()
        {
            // Snippet: GetJobAsync(GetJobRequest,CallSettings)
            // Additional: GetJobAsync(GetJobRequest,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                Name = new JobName("[PROJECT]", "[JOB]").ToString(),
            };
            // Make the request
            Job response = await jobServiceClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob_RequestObject()
        {
            // Snippet: GetJob(GetJobRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                Name = new JobName("[PROJECT]", "[JOB]").ToString(),
            };
            // Make the request
            Job response = jobServiceClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobAsync()
        {
            // Snippet: UpdateJobAsync(Job,CallSettings)
            // Additional: UpdateJobAsync(Job,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            Job job = new Job();
            // Make the request
            Job response = await jobServiceClient.UpdateJobAsync(job);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJob()
        {
            // Snippet: UpdateJob(Job,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            Job job = new Job();
            // Make the request
            Job response = jobServiceClient.UpdateJob(job);
            // End snippet
        }

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobAsync_RequestObject()
        {
            // Snippet: UpdateJobAsync(UpdateJobRequest,CallSettings)
            // Additional: UpdateJobAsync(UpdateJobRequest,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
            };
            // Make the request
            Job response = await jobServiceClient.UpdateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJob_RequestObject()
        {
            // Snippet: UpdateJob(UpdateJobRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                Job = new Job(),
            };
            // Make the request
            Job response = jobServiceClient.UpdateJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string,CallSettings)
            // Additional: DeleteJobAsync(string,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new JobName("[PROJECT]", "[JOB]").ToString();
            // Make the request
            await jobServiceClient.DeleteJobAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string formattedName = new JobName("[PROJECT]", "[JOB]").ToString();
            // Make the request
            jobServiceClient.DeleteJob(formattedName);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync_RequestObject()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest,CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                Name = new JobName("[PROJECT]", "[JOB]").ToString(),
            };
            // Make the request
            await jobServiceClient.DeleteJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob_RequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                Name = new JobName("[PROJECT]", "[JOB]").ToString(),
            };
            // Make the request
            jobServiceClient.DeleteJob(request);
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsAsync()
        {
            // Snippet: ListJobsAsync(string,string,string,int?,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response =
                jobServiceClient.ListJobsAsync(formattedParent, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobs()
        {
            // Snippet: ListJobs(string,string,string,int?,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            string filter = "";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response =
                jobServiceClient.ListJobs(formattedParent, filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsAsync_RequestObject()
        {
            // Snippet: ListJobsAsync(ListJobsRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response =
                jobServiceClient.ListJobsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobs_RequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response =
                jobServiceClient.ListJobs(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobsAsync</summary>
        public async Task BatchDeleteJobsAsync()
        {
            // Snippet: BatchDeleteJobsAsync(string,string,CallSettings)
            // Additional: BatchDeleteJobsAsync(string,string,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            string filter = "";
            // Make the request
            await jobServiceClient.BatchDeleteJobsAsync(formattedParent, filter);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobs</summary>
        public void BatchDeleteJobs()
        {
            // Snippet: BatchDeleteJobs(string,string,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string formattedParent = new ProjectName("[PROJECT]").ToString();
            string filter = "";
            // Make the request
            jobServiceClient.BatchDeleteJobs(formattedParent, filter);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobsAsync</summary>
        public async Task BatchDeleteJobsAsync_RequestObject()
        {
            // Snippet: BatchDeleteJobsAsync(BatchDeleteJobsRequest,CallSettings)
            // Additional: BatchDeleteJobsAsync(BatchDeleteJobsRequest,CancellationToken)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                Filter = "",
            };
            // Make the request
            await jobServiceClient.BatchDeleteJobsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteJobs</summary>
        public void BatchDeleteJobs_RequestObject()
        {
            // Snippet: BatchDeleteJobs(BatchDeleteJobsRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteJobsRequest request = new BatchDeleteJobsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                Filter = "",
            };
            // Make the request
            jobServiceClient.BatchDeleteJobs(request);
            // End snippet
        }

        /// <summary>Snippet for SearchJobsAsync</summary>
        public async Task SearchJobsAsync_RequestObject()
        {
            // Snippet: SearchJobsAsync(SearchJobsRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchJobsRequest request = new SearchJobsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                RequestMetadata = new RequestMetadata(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchJobsResponse, MatchingJob> response =
                jobServiceClient.SearchJobsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchJobs</summary>
        public void SearchJobs_RequestObject()
        {
            // Snippet: SearchJobs(SearchJobsRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            SearchJobsRequest request = new SearchJobsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                RequestMetadata = new RequestMetadata(),
            };
            // Make the request
            PagedEnumerable<SearchJobsResponse, MatchingJob> response =
                jobServiceClient.SearchJobs(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchJobsForAlertAsync</summary>
        public async Task SearchJobsForAlertAsync_RequestObject()
        {
            // Snippet: SearchJobsForAlertAsync(SearchJobsRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchJobsRequest request = new SearchJobsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                RequestMetadata = new RequestMetadata(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchJobsResponse, MatchingJob> response =
                jobServiceClient.SearchJobsForAlertAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchJobsForAlert</summary>
        public void SearchJobsForAlert_RequestObject()
        {
            // Snippet: SearchJobsForAlert(SearchJobsRequest,CallSettings)
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            SearchJobsRequest request = new SearchJobsRequest
            {
                Parent = new ProjectName("[PROJECT]").ToString(),
                RequestMetadata = new RequestMetadata(),
            };
            // Make the request
            PagedEnumerable<SearchJobsResponse, MatchingJob> response =
                jobServiceClient.SearchJobsForAlert(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
