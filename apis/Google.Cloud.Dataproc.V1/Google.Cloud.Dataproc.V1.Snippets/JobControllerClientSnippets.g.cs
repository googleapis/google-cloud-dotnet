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

namespace Google.Cloud.Dataproc.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dataproc.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedJobControllerClientSnippets
    {
        /// <summary>Snippet for SubmitJobAsync</summary>
        public async Task SubmitJobAsync()
        {
            // Snippet: SubmitJobAsync(string,string,Job,CallSettings)
            // Additional: SubmitJobAsync(string,string,Job,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            Job job = new Job();
            // Make the request
            Job response = await jobControllerClient.SubmitJobAsync(projectId, region, job);
            // End snippet
        }

        /// <summary>Snippet for SubmitJob</summary>
        public void SubmitJob()
        {
            // Snippet: SubmitJob(string,string,Job,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            Job job = new Job();
            // Make the request
            Job response = jobControllerClient.SubmitJob(projectId, region, job);
            // End snippet
        }

        /// <summary>Snippet for SubmitJobAsync</summary>
        public async Task SubmitJobAsync_RequestObject()
        {
            // Snippet: SubmitJobAsync(SubmitJobRequest,CallSettings)
            // Additional: SubmitJobAsync(SubmitJobRequest,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "",
                Region = "",
                Job = new Job(),
            };
            // Make the request
            Job response = await jobControllerClient.SubmitJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SubmitJob</summary>
        public void SubmitJob_RequestObject()
        {
            // Snippet: SubmitJob(SubmitJobRequest,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            SubmitJobRequest request = new SubmitJobRequest
            {
                ProjectId = "",
                Region = "",
                Job = new Job(),
            };
            // Make the request
            Job response = jobControllerClient.SubmitJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string,string,string,CallSettings)
            // Additional: GetJobAsync(string,string,string,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string jobId = "";
            // Make the request
            Job response = await jobControllerClient.GetJobAsync(projectId, region, jobId);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string,string,string,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string jobId = "";
            // Make the request
            Job response = jobControllerClient.GetJob(projectId, region, jobId);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync_RequestObject()
        {
            // Snippet: GetJobAsync(GetJobRequest,CallSettings)
            // Additional: GetJobAsync(GetJobRequest,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "",
                Region = "",
                JobId = "",
            };
            // Make the request
            Job response = await jobControllerClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob_RequestObject()
        {
            // Snippet: GetJob(GetJobRequest,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                ProjectId = "",
                Region = "",
                JobId = "",
            };
            // Make the request
            Job response = jobControllerClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for ListJobsAsync</summary>
        public async Task ListJobsAsync1()
        {
            // Snippet: ListJobsAsync(string,string,string,int?,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response =
                jobControllerClient.ListJobsAsync(projectId, region);

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
        public void ListJobs1()
        {
            // Snippet: ListJobs(string,string,string,int?,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response =
                jobControllerClient.ListJobs(projectId, region);

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
        public async Task ListJobsAsync2()
        {
            // Snippet: ListJobsAsync(string,string,string,string,int?,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response =
                jobControllerClient.ListJobsAsync(projectId: projectId, region: region, filter: filter);

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
        public void ListJobs2()
        {
            // Snippet: ListJobs(string,string,string,string,int?,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string filter = "";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response =
                jobControllerClient.ListJobs(projectId: projectId, region: region, filter: filter);

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
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ProjectId = "",
                Region = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response =
                jobControllerClient.ListJobsAsync(request);

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
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ProjectId = "",
                Region = "",
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response =
                jobControllerClient.ListJobs(request);

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

        /// <summary>Snippet for UpdateJobAsync</summary>
        public async Task UpdateJobAsync_RequestObject()
        {
            // Snippet: UpdateJobAsync(UpdateJobRequest,CallSettings)
            // Additional: UpdateJobAsync(UpdateJobRequest,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "",
                Region = "",
                JobId = "",
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Job response = await jobControllerClient.UpdateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateJob</summary>
        public void UpdateJob_RequestObject()
        {
            // Snippet: UpdateJob(UpdateJobRequest,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            UpdateJobRequest request = new UpdateJobRequest
            {
                ProjectId = "",
                Region = "",
                JobId = "",
                Job = new Job(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Job response = jobControllerClient.UpdateJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobAsync()
        {
            // Snippet: CancelJobAsync(string,string,string,CallSettings)
            // Additional: CancelJobAsync(string,string,string,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string jobId = "";
            // Make the request
            Job response = await jobControllerClient.CancelJobAsync(projectId, region, jobId);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJob()
        {
            // Snippet: CancelJob(string,string,string,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string jobId = "";
            // Make the request
            Job response = jobControllerClient.CancelJob(projectId, region, jobId);
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobAsync_RequestObject()
        {
            // Snippet: CancelJobAsync(CancelJobRequest,CallSettings)
            // Additional: CancelJobAsync(CancelJobRequest,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            CancelJobRequest request = new CancelJobRequest
            {
                ProjectId = "",
                Region = "",
                JobId = "",
            };
            // Make the request
            Job response = await jobControllerClient.CancelJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJob_RequestObject()
        {
            // Snippet: CancelJob(CancelJobRequest,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            CancelJobRequest request = new CancelJobRequest
            {
                ProjectId = "",
                Region = "",
                JobId = "",
            };
            // Make the request
            Job response = jobControllerClient.CancelJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string,string,string,CallSettings)
            // Additional: DeleteJobAsync(string,string,string,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string jobId = "";
            // Make the request
            await jobControllerClient.DeleteJobAsync(projectId, region, jobId);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string,string,string,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string jobId = "";
            // Make the request
            jobControllerClient.DeleteJob(projectId, region, jobId);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync_RequestObject()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest,CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest,CancellationToken)
            // Create client
            JobControllerClient jobControllerClient = await JobControllerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                ProjectId = "",
                Region = "",
                JobId = "",
            };
            // Make the request
            await jobControllerClient.DeleteJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob_RequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest,CallSettings)
            // Create client
            JobControllerClient jobControllerClient = JobControllerClient.Create();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                ProjectId = "",
                Region = "",
                JobId = "",
            };
            // Make the request
            jobControllerClient.DeleteJob(request);
            // End snippet
        }

    }
}
