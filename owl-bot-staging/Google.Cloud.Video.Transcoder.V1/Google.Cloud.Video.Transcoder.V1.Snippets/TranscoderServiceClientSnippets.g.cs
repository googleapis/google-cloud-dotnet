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
    using Google.Cloud.Video.Transcoder.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTranscoderServiceClientSnippets
    {
        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobRequestObject()
        {
            // Snippet: CreateJob(CreateJobRequest, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            // Make the request
            Job response = transcoderServiceClient.CreateJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobRequestObjectAsync()
        {
            // Snippet: CreateJobAsync(CreateJobRequest, CallSettings)
            // Additional: CreateJobAsync(CreateJobRequest, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobRequest request = new CreateJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Job = new Job(),
            };
            // Make the request
            Job response = await transcoderServiceClient.CreateJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJob()
        {
            // Snippet: CreateJob(string, Job, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            // Make the request
            Job response = transcoderServiceClient.CreateJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobAsync()
        {
            // Snippet: CreateJobAsync(string, Job, CallSettings)
            // Additional: CreateJobAsync(string, Job, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Job job = new Job();
            // Make the request
            Job response = await transcoderServiceClient.CreateJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJob</summary>
        public void CreateJobResourceNames()
        {
            // Snippet: CreateJob(LocationName, Job, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Job job = new Job();
            // Make the request
            Job response = transcoderServiceClient.CreateJob(parent, job);
            // End snippet
        }

        /// <summary>Snippet for CreateJobAsync</summary>
        public async Task CreateJobResourceNamesAsync()
        {
            // Snippet: CreateJobAsync(LocationName, Job, CallSettings)
            // Additional: CreateJobAsync(LocationName, Job, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Job job = new Job();
            // Make the request
            Job response = await transcoderServiceClient.CreateJobAsync(parent, job);
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = transcoderServiceClient.ListJobs(request);

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
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = transcoderServiceClient.ListJobsAsync(request);

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
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = transcoderServiceClient.ListJobs(parent);

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
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = transcoderServiceClient.ListJobsAsync(parent);

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
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = transcoderServiceClient.ListJobs(parent);

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
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = transcoderServiceClient.ListJobsAsync(parent);

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
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = transcoderServiceClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
            };
            // Make the request
            Job response = await transcoderServiceClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = transcoderServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            Job response = await transcoderServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = transcoderServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobResourceNamesAsync()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            Job response = await transcoderServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobRequestObject()
        {
            // Snippet: DeleteJob(DeleteJobRequest, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                AllowMissing = false,
            };
            // Make the request
            transcoderServiceClient.DeleteJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobRequestObjectAsync()
        {
            // Snippet: DeleteJobAsync(DeleteJobRequest, CallSettings)
            // Additional: DeleteJobAsync(DeleteJobRequest, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobRequest request = new DeleteJobRequest
            {
                JobName = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]"),
                AllowMissing = false,
            };
            // Make the request
            await transcoderServiceClient.DeleteJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJob()
        {
            // Snippet: DeleteJob(string, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            transcoderServiceClient.DeleteJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobAsync()
        {
            // Snippet: DeleteJobAsync(string, CallSettings)
            // Additional: DeleteJobAsync(string, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobs/[JOB]";
            // Make the request
            await transcoderServiceClient.DeleteJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJob</summary>
        public void DeleteJobResourceNames()
        {
            // Snippet: DeleteJob(JobName, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            transcoderServiceClient.DeleteJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobAsync</summary>
        public async Task DeleteJobResourceNamesAsync()
        {
            // Snippet: DeleteJobAsync(JobName, CallSettings)
            // Additional: DeleteJobAsync(JobName, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationJob("[PROJECT]", "[LOCATION]", "[JOB]");
            // Make the request
            await transcoderServiceClient.DeleteJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTemplate</summary>
        public void CreateJobTemplateRequestObject()
        {
            // Snippet: CreateJobTemplate(CreateJobTemplateRequest, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate(),
                JobTemplateId = "",
            };
            // Make the request
            JobTemplate response = transcoderServiceClient.CreateJobTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTemplateAsync</summary>
        public async Task CreateJobTemplateRequestObjectAsync()
        {
            // Snippet: CreateJobTemplateAsync(CreateJobTemplateRequest, CallSettings)
            // Additional: CreateJobTemplateAsync(CreateJobTemplateRequest, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateJobTemplateRequest request = new CreateJobTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                JobTemplate = new JobTemplate(),
                JobTemplateId = "",
            };
            // Make the request
            JobTemplate response = await transcoderServiceClient.CreateJobTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTemplate</summary>
        public void CreateJobTemplate()
        {
            // Snippet: CreateJobTemplate(string, JobTemplate, string, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            JobTemplate jobTemplate = new JobTemplate();
            string jobTemplateId = "";
            // Make the request
            JobTemplate response = transcoderServiceClient.CreateJobTemplate(parent, jobTemplate, jobTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTemplateAsync</summary>
        public async Task CreateJobTemplateAsync()
        {
            // Snippet: CreateJobTemplateAsync(string, JobTemplate, string, CallSettings)
            // Additional: CreateJobTemplateAsync(string, JobTemplate, string, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            JobTemplate jobTemplate = new JobTemplate();
            string jobTemplateId = "";
            // Make the request
            JobTemplate response = await transcoderServiceClient.CreateJobTemplateAsync(parent, jobTemplate, jobTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTemplate</summary>
        public void CreateJobTemplateResourceNames()
        {
            // Snippet: CreateJobTemplate(LocationName, JobTemplate, string, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            JobTemplate jobTemplate = new JobTemplate();
            string jobTemplateId = "";
            // Make the request
            JobTemplate response = transcoderServiceClient.CreateJobTemplate(parent, jobTemplate, jobTemplateId);
            // End snippet
        }

        /// <summary>Snippet for CreateJobTemplateAsync</summary>
        public async Task CreateJobTemplateResourceNamesAsync()
        {
            // Snippet: CreateJobTemplateAsync(LocationName, JobTemplate, string, CallSettings)
            // Additional: CreateJobTemplateAsync(LocationName, JobTemplate, string, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            JobTemplate jobTemplate = new JobTemplate();
            string jobTemplateId = "";
            // Make the request
            JobTemplate response = await transcoderServiceClient.CreateJobTemplateAsync(parent, jobTemplate, jobTemplateId);
            // End snippet
        }

        /// <summary>Snippet for ListJobTemplates</summary>
        public void ListJobTemplatesRequestObject()
        {
            // Snippet: ListJobTemplates(ListJobTemplatesRequest, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            ListJobTemplatesRequest request = new ListJobTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListJobTemplatesResponse, JobTemplate> response = transcoderServiceClient.ListJobTemplates(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (JobTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTemplatesAsync</summary>
        public async Task ListJobTemplatesRequestObjectAsync()
        {
            // Snippet: ListJobTemplatesAsync(ListJobTemplatesRequest, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListJobTemplatesRequest request = new ListJobTemplatesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobTemplatesResponse, JobTemplate> response = transcoderServiceClient.ListJobTemplatesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((JobTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTemplates</summary>
        public void ListJobTemplates()
        {
            // Snippet: ListJobTemplates(string, string, int?, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListJobTemplatesResponse, JobTemplate> response = transcoderServiceClient.ListJobTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (JobTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTemplatesAsync</summary>
        public async Task ListJobTemplatesAsync()
        {
            // Snippet: ListJobTemplatesAsync(string, string, int?, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListJobTemplatesResponse, JobTemplate> response = transcoderServiceClient.ListJobTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((JobTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTemplates</summary>
        public void ListJobTemplatesResourceNames()
        {
            // Snippet: ListJobTemplates(LocationName, string, int?, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListJobTemplatesResponse, JobTemplate> response = transcoderServiceClient.ListJobTemplates(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (JobTemplate item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobTemplatesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobTemplate> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobTemplatesAsync</summary>
        public async Task ListJobTemplatesResourceNamesAsync()
        {
            // Snippet: ListJobTemplatesAsync(LocationName, string, int?, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListJobTemplatesResponse, JobTemplate> response = transcoderServiceClient.ListJobTemplatesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((JobTemplate item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobTemplatesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobTemplate item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobTemplate> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobTemplate item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetJobTemplate</summary>
        public void GetJobTemplateRequestObject()
        {
            // Snippet: GetJobTemplate(GetJobTemplateRequest, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            // Make the request
            JobTemplate response = transcoderServiceClient.GetJobTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobTemplateAsync</summary>
        public async Task GetJobTemplateRequestObjectAsync()
        {
            // Snippet: GetJobTemplateAsync(GetJobTemplateRequest, CallSettings)
            // Additional: GetJobTemplateAsync(GetJobTemplateRequest, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetJobTemplateRequest request = new GetJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
            };
            // Make the request
            JobTemplate response = await transcoderServiceClient.GetJobTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobTemplate</summary>
        public void GetJobTemplate()
        {
            // Snippet: GetJobTemplate(string, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobTemplates/[JOB_TEMPLATE]";
            // Make the request
            JobTemplate response = transcoderServiceClient.GetJobTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobTemplateAsync</summary>
        public async Task GetJobTemplateAsync()
        {
            // Snippet: GetJobTemplateAsync(string, CallSettings)
            // Additional: GetJobTemplateAsync(string, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobTemplates/[JOB_TEMPLATE]";
            // Make the request
            JobTemplate response = await transcoderServiceClient.GetJobTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobTemplate</summary>
        public void GetJobTemplateResourceNames()
        {
            // Snippet: GetJobTemplate(JobTemplateName, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            JobTemplateName name = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]");
            // Make the request
            JobTemplate response = transcoderServiceClient.GetJobTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobTemplateAsync</summary>
        public async Task GetJobTemplateResourceNamesAsync()
        {
            // Snippet: GetJobTemplateAsync(JobTemplateName, CallSettings)
            // Additional: GetJobTemplateAsync(JobTemplateName, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobTemplateName name = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]");
            // Make the request
            JobTemplate response = await transcoderServiceClient.GetJobTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTemplate</summary>
        public void DeleteJobTemplateRequestObject()
        {
            // Snippet: DeleteJobTemplate(DeleteJobTemplateRequest, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                AllowMissing = false,
            };
            // Make the request
            transcoderServiceClient.DeleteJobTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTemplateAsync</summary>
        public async Task DeleteJobTemplateRequestObjectAsync()
        {
            // Snippet: DeleteJobTemplateAsync(DeleteJobTemplateRequest, CallSettings)
            // Additional: DeleteJobTemplateAsync(DeleteJobTemplateRequest, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteJobTemplateRequest request = new DeleteJobTemplateRequest
            {
                JobTemplateName = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]"),
                AllowMissing = false,
            };
            // Make the request
            await transcoderServiceClient.DeleteJobTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTemplate</summary>
        public void DeleteJobTemplate()
        {
            // Snippet: DeleteJobTemplate(string, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobTemplates/[JOB_TEMPLATE]";
            // Make the request
            transcoderServiceClient.DeleteJobTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTemplateAsync</summary>
        public async Task DeleteJobTemplateAsync()
        {
            // Snippet: DeleteJobTemplateAsync(string, CallSettings)
            // Additional: DeleteJobTemplateAsync(string, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/jobTemplates/[JOB_TEMPLATE]";
            // Make the request
            await transcoderServiceClient.DeleteJobTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTemplate</summary>
        public void DeleteJobTemplateResourceNames()
        {
            // Snippet: DeleteJobTemplate(JobTemplateName, CallSettings)
            // Create client
            TranscoderServiceClient transcoderServiceClient = TranscoderServiceClient.Create();
            // Initialize request argument(s)
            JobTemplateName name = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]");
            // Make the request
            transcoderServiceClient.DeleteJobTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteJobTemplateAsync</summary>
        public async Task DeleteJobTemplateResourceNamesAsync()
        {
            // Snippet: DeleteJobTemplateAsync(JobTemplateName, CallSettings)
            // Additional: DeleteJobTemplateAsync(JobTemplateName, CancellationToken)
            // Create client
            TranscoderServiceClient transcoderServiceClient = await TranscoderServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobTemplateName name = JobTemplateName.FromProjectLocationJobTemplate("[PROJECT]", "[LOCATION]", "[JOB_TEMPLATE]");
            // Make the request
            await transcoderServiceClient.DeleteJobTemplateAsync(name);
            // End snippet
        }
    }
}
