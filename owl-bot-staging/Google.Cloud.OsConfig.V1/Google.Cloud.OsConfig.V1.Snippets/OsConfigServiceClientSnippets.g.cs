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
    using Google.Cloud.OsConfig.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOsConfigServiceClientSnippets
    {
        /// <summary>Snippet for ExecutePatchJob</summary>
        public void ExecutePatchJobRequestObject()
        {
            // Snippet: ExecutePatchJob(ExecutePatchJobRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Description = "",
                PatchConfig = new PatchConfig(),
                Duration = new Duration(),
                DryRun = false,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "",
                Rollout = new PatchRollout(),
            };
            // Make the request
            PatchJob response = osConfigServiceClient.ExecutePatchJob(request);
            // End snippet
        }

        /// <summary>Snippet for ExecutePatchJobAsync</summary>
        public async Task ExecutePatchJobRequestObjectAsync()
        {
            // Snippet: ExecutePatchJobAsync(ExecutePatchJobRequest, CallSettings)
            // Additional: ExecutePatchJobAsync(ExecutePatchJobRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExecutePatchJobRequest request = new ExecutePatchJobRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Description = "",
                PatchConfig = new PatchConfig(),
                Duration = new Duration(),
                DryRun = false,
                InstanceFilter = new PatchInstanceFilter(),
                DisplayName = "",
                Rollout = new PatchRollout(),
            };
            // Make the request
            PatchJob response = await osConfigServiceClient.ExecutePatchJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchJob</summary>
        public void GetPatchJobRequestObject()
        {
            // Snippet: GetPatchJob(GetPatchJobRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            // Make the request
            PatchJob response = osConfigServiceClient.GetPatchJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchJobAsync</summary>
        public async Task GetPatchJobRequestObjectAsync()
        {
            // Snippet: GetPatchJobAsync(GetPatchJobRequest, CallSettings)
            // Additional: GetPatchJobAsync(GetPatchJobRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPatchJobRequest request = new GetPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            // Make the request
            PatchJob response = await osConfigServiceClient.GetPatchJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchJob</summary>
        public void GetPatchJob()
        {
            // Snippet: GetPatchJob(string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchJobs/[PATCH_JOB]";
            // Make the request
            PatchJob response = osConfigServiceClient.GetPatchJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetPatchJobAsync</summary>
        public async Task GetPatchJobAsync()
        {
            // Snippet: GetPatchJobAsync(string, CallSettings)
            // Additional: GetPatchJobAsync(string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchJobs/[PATCH_JOB]";
            // Make the request
            PatchJob response = await osConfigServiceClient.GetPatchJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPatchJob</summary>
        public void GetPatchJobResourceNames()
        {
            // Snippet: GetPatchJob(PatchJobName, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            PatchJobName name = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]");
            // Make the request
            PatchJob response = osConfigServiceClient.GetPatchJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetPatchJobAsync</summary>
        public async Task GetPatchJobResourceNamesAsync()
        {
            // Snippet: GetPatchJobAsync(PatchJobName, CallSettings)
            // Additional: GetPatchJobAsync(PatchJobName, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchJobName name = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]");
            // Make the request
            PatchJob response = await osConfigServiceClient.GetPatchJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelPatchJob</summary>
        public void CancelPatchJobRequestObject()
        {
            // Snippet: CancelPatchJob(CancelPatchJobRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            CancelPatchJobRequest request = new CancelPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            // Make the request
            PatchJob response = osConfigServiceClient.CancelPatchJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelPatchJobAsync</summary>
        public async Task CancelPatchJobRequestObjectAsync()
        {
            // Snippet: CancelPatchJobAsync(CancelPatchJobRequest, CallSettings)
            // Additional: CancelPatchJobAsync(CancelPatchJobRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelPatchJobRequest request = new CancelPatchJobRequest
            {
                PatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
            };
            // Make the request
            PatchJob response = await osConfigServiceClient.CancelPatchJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobs</summary>
        public void ListPatchJobsRequestObject()
        {
            // Snippet: ListPatchJobs(ListPatchJobsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ListPatchJobsRequest request = new ListPatchJobsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPatchJobsResponse, PatchJob> response = osConfigServiceClient.ListPatchJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobsAsync</summary>
        public async Task ListPatchJobsRequestObjectAsync()
        {
            // Snippet: ListPatchJobsAsync(ListPatchJobsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPatchJobsRequest request = new ListPatchJobsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> response = osConfigServiceClient.ListPatchJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobs</summary>
        public void ListPatchJobs()
        {
            // Snippet: ListPatchJobs(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListPatchJobsResponse, PatchJob> response = osConfigServiceClient.ListPatchJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobsAsync</summary>
        public async Task ListPatchJobsAsync()
        {
            // Snippet: ListPatchJobsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> response = osConfigServiceClient.ListPatchJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobs</summary>
        public void ListPatchJobsResourceNames()
        {
            // Snippet: ListPatchJobs(ProjectName, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListPatchJobsResponse, PatchJob> response = osConfigServiceClient.ListPatchJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobsAsync</summary>
        public async Task ListPatchJobsResourceNamesAsync()
        {
            // Snippet: ListPatchJobsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListPatchJobsResponse, PatchJob> response = osConfigServiceClient.ListPatchJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetails</summary>
        public void ListPatchJobInstanceDetailsRequestObject()
        {
            // Snippet: ListPatchJobInstanceDetails(ListPatchJobInstanceDetailsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ListPatchJobInstanceDetailsRequest request = new ListPatchJobInstanceDetailsRequest
            {
                ParentAsPatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetails(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJobInstanceDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobInstanceDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetailsAsync</summary>
        public async Task ListPatchJobInstanceDetailsRequestObjectAsync()
        {
            // Snippet: ListPatchJobInstanceDetailsAsync(ListPatchJobInstanceDetailsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPatchJobInstanceDetailsRequest request = new ListPatchJobInstanceDetailsRequest
            {
                ParentAsPatchJobName = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetailsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJobInstanceDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobInstanceDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetails</summary>
        public void ListPatchJobInstanceDetails()
        {
            // Snippet: ListPatchJobInstanceDetails(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/patchJobs/[PATCH_JOB]";
            // Make the request
            PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJobInstanceDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobInstanceDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetailsAsync</summary>
        public async Task ListPatchJobInstanceDetailsAsync()
        {
            // Snippet: ListPatchJobInstanceDetailsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/patchJobs/[PATCH_JOB]";
            // Make the request
            PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJobInstanceDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobInstanceDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetails</summary>
        public void ListPatchJobInstanceDetailsResourceNames()
        {
            // Snippet: ListPatchJobInstanceDetails(PatchJobName, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            PatchJobName parent = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]");
            // Make the request
            PagedEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetails(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchJobInstanceDetails item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchJobInstanceDetailsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchJobInstanceDetailsAsync</summary>
        public async Task ListPatchJobInstanceDetailsResourceNamesAsync()
        {
            // Snippet: ListPatchJobInstanceDetailsAsync(PatchJobName, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchJobName parent = PatchJobName.FromProjectPatchJob("[PROJECT]", "[PATCH_JOB]");
            // Make the request
            PagedAsyncEnumerable<ListPatchJobInstanceDetailsResponse, PatchJobInstanceDetails> response = osConfigServiceClient.ListPatchJobInstanceDetailsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchJobInstanceDetails item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchJobInstanceDetailsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchJobInstanceDetails item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchJobInstanceDetails> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchJobInstanceDetails item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreatePatchDeployment</summary>
        public void CreatePatchDeploymentRequestObject()
        {
            // Snippet: CreatePatchDeployment(CreatePatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PatchDeploymentId = "",
                PatchDeployment = new PatchDeployment(),
            };
            // Make the request
            PatchDeployment response = osConfigServiceClient.CreatePatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePatchDeploymentAsync</summary>
        public async Task CreatePatchDeploymentRequestObjectAsync()
        {
            // Snippet: CreatePatchDeploymentAsync(CreatePatchDeploymentRequest, CallSettings)
            // Additional: CreatePatchDeploymentAsync(CreatePatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePatchDeploymentRequest request = new CreatePatchDeploymentRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                PatchDeploymentId = "",
                PatchDeployment = new PatchDeployment(),
            };
            // Make the request
            PatchDeployment response = await osConfigServiceClient.CreatePatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePatchDeployment</summary>
        public void CreatePatchDeployment()
        {
            // Snippet: CreatePatchDeployment(string, PatchDeployment, string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            PatchDeployment patchDeployment = new PatchDeployment();
            string patchDeploymentId = "";
            // Make the request
            PatchDeployment response = osConfigServiceClient.CreatePatchDeployment(parent, patchDeployment, patchDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreatePatchDeploymentAsync</summary>
        public async Task CreatePatchDeploymentAsync()
        {
            // Snippet: CreatePatchDeploymentAsync(string, PatchDeployment, string, CallSettings)
            // Additional: CreatePatchDeploymentAsync(string, PatchDeployment, string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            PatchDeployment patchDeployment = new PatchDeployment();
            string patchDeploymentId = "";
            // Make the request
            PatchDeployment response = await osConfigServiceClient.CreatePatchDeploymentAsync(parent, patchDeployment, patchDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreatePatchDeployment</summary>
        public void CreatePatchDeploymentResourceNames()
        {
            // Snippet: CreatePatchDeployment(ProjectName, PatchDeployment, string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            PatchDeployment patchDeployment = new PatchDeployment();
            string patchDeploymentId = "";
            // Make the request
            PatchDeployment response = osConfigServiceClient.CreatePatchDeployment(parent, patchDeployment, patchDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreatePatchDeploymentAsync</summary>
        public async Task CreatePatchDeploymentResourceNamesAsync()
        {
            // Snippet: CreatePatchDeploymentAsync(ProjectName, PatchDeployment, string, CallSettings)
            // Additional: CreatePatchDeploymentAsync(ProjectName, PatchDeployment, string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            PatchDeployment patchDeployment = new PatchDeployment();
            string patchDeploymentId = "";
            // Make the request
            PatchDeployment response = await osConfigServiceClient.CreatePatchDeploymentAsync(parent, patchDeployment, patchDeploymentId);
            // End snippet
        }

        /// <summary>Snippet for GetPatchDeployment</summary>
        public void GetPatchDeploymentRequestObject()
        {
            // Snippet: GetPatchDeployment(GetPatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            // Make the request
            PatchDeployment response = osConfigServiceClient.GetPatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchDeploymentAsync</summary>
        public async Task GetPatchDeploymentRequestObjectAsync()
        {
            // Snippet: GetPatchDeploymentAsync(GetPatchDeploymentRequest, CallSettings)
            // Additional: GetPatchDeploymentAsync(GetPatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPatchDeploymentRequest request = new GetPatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            // Make the request
            PatchDeployment response = await osConfigServiceClient.GetPatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPatchDeployment</summary>
        public void GetPatchDeployment()
        {
            // Snippet: GetPatchDeployment(string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchDeployments/[PATCH_DEPLOYMENT]";
            // Make the request
            PatchDeployment response = osConfigServiceClient.GetPatchDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetPatchDeploymentAsync</summary>
        public async Task GetPatchDeploymentAsync()
        {
            // Snippet: GetPatchDeploymentAsync(string, CallSettings)
            // Additional: GetPatchDeploymentAsync(string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchDeployments/[PATCH_DEPLOYMENT]";
            // Make the request
            PatchDeployment response = await osConfigServiceClient.GetPatchDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPatchDeployment</summary>
        public void GetPatchDeploymentResourceNames()
        {
            // Snippet: GetPatchDeployment(PatchDeploymentName, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            PatchDeploymentName name = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]");
            // Make the request
            PatchDeployment response = osConfigServiceClient.GetPatchDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetPatchDeploymentAsync</summary>
        public async Task GetPatchDeploymentResourceNamesAsync()
        {
            // Snippet: GetPatchDeploymentAsync(PatchDeploymentName, CallSettings)
            // Additional: GetPatchDeploymentAsync(PatchDeploymentName, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchDeploymentName name = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]");
            // Make the request
            PatchDeployment response = await osConfigServiceClient.GetPatchDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPatchDeployments</summary>
        public void ListPatchDeploymentsRequestObject()
        {
            // Snippet: ListPatchDeployments(ListPatchDeploymentsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ListPatchDeploymentsRequest request = new ListPatchDeploymentsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> response = osConfigServiceClient.ListPatchDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchDeploymentsAsync</summary>
        public async Task ListPatchDeploymentsRequestObjectAsync()
        {
            // Snippet: ListPatchDeploymentsAsync(ListPatchDeploymentsRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPatchDeploymentsRequest request = new ListPatchDeploymentsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> response = osConfigServiceClient.ListPatchDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchDeployments</summary>
        public void ListPatchDeployments()
        {
            // Snippet: ListPatchDeployments(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> response = osConfigServiceClient.ListPatchDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchDeploymentsAsync</summary>
        public async Task ListPatchDeploymentsAsync()
        {
            // Snippet: ListPatchDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> response = osConfigServiceClient.ListPatchDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchDeployments</summary>
        public void ListPatchDeploymentsResourceNames()
        {
            // Snippet: ListPatchDeployments(ProjectName, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListPatchDeploymentsResponse, PatchDeployment> response = osConfigServiceClient.ListPatchDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PatchDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPatchDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPatchDeploymentsAsync</summary>
        public async Task ListPatchDeploymentsResourceNamesAsync()
        {
            // Snippet: ListPatchDeploymentsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListPatchDeploymentsResponse, PatchDeployment> response = osConfigServiceClient.ListPatchDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PatchDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPatchDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PatchDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PatchDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PatchDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePatchDeployment</summary>
        public void DeletePatchDeploymentRequestObject()
        {
            // Snippet: DeletePatchDeployment(DeletePatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            // Make the request
            osConfigServiceClient.DeletePatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePatchDeploymentAsync</summary>
        public async Task DeletePatchDeploymentRequestObjectAsync()
        {
            // Snippet: DeletePatchDeploymentAsync(DeletePatchDeploymentRequest, CallSettings)
            // Additional: DeletePatchDeploymentAsync(DeletePatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePatchDeploymentRequest request = new DeletePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            // Make the request
            await osConfigServiceClient.DeletePatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePatchDeployment</summary>
        public void DeletePatchDeployment()
        {
            // Snippet: DeletePatchDeployment(string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchDeployments/[PATCH_DEPLOYMENT]";
            // Make the request
            osConfigServiceClient.DeletePatchDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePatchDeploymentAsync</summary>
        public async Task DeletePatchDeploymentAsync()
        {
            // Snippet: DeletePatchDeploymentAsync(string, CallSettings)
            // Additional: DeletePatchDeploymentAsync(string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchDeployments/[PATCH_DEPLOYMENT]";
            // Make the request
            await osConfigServiceClient.DeletePatchDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePatchDeployment</summary>
        public void DeletePatchDeploymentResourceNames()
        {
            // Snippet: DeletePatchDeployment(PatchDeploymentName, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            PatchDeploymentName name = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]");
            // Make the request
            osConfigServiceClient.DeletePatchDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePatchDeploymentAsync</summary>
        public async Task DeletePatchDeploymentResourceNamesAsync()
        {
            // Snippet: DeletePatchDeploymentAsync(PatchDeploymentName, CallSettings)
            // Additional: DeletePatchDeploymentAsync(PatchDeploymentName, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchDeploymentName name = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]");
            // Make the request
            await osConfigServiceClient.DeletePatchDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdatePatchDeployment</summary>
        public void UpdatePatchDeploymentRequestObject()
        {
            // Snippet: UpdatePatchDeployment(UpdatePatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdatePatchDeploymentRequest request = new UpdatePatchDeploymentRequest
            {
                PatchDeployment = new PatchDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PatchDeployment response = osConfigServiceClient.UpdatePatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePatchDeploymentAsync</summary>
        public async Task UpdatePatchDeploymentRequestObjectAsync()
        {
            // Snippet: UpdatePatchDeploymentAsync(UpdatePatchDeploymentRequest, CallSettings)
            // Additional: UpdatePatchDeploymentAsync(UpdatePatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePatchDeploymentRequest request = new UpdatePatchDeploymentRequest
            {
                PatchDeployment = new PatchDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PatchDeployment response = await osConfigServiceClient.UpdatePatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePatchDeployment</summary>
        public void UpdatePatchDeployment()
        {
            // Snippet: UpdatePatchDeployment(PatchDeployment, FieldMask, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            PatchDeployment patchDeployment = new PatchDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PatchDeployment response = osConfigServiceClient.UpdatePatchDeployment(patchDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePatchDeploymentAsync</summary>
        public async Task UpdatePatchDeploymentAsync()
        {
            // Snippet: UpdatePatchDeploymentAsync(PatchDeployment, FieldMask, CallSettings)
            // Additional: UpdatePatchDeploymentAsync(PatchDeployment, FieldMask, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchDeployment patchDeployment = new PatchDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PatchDeployment response = await osConfigServiceClient.UpdatePatchDeploymentAsync(patchDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for PausePatchDeployment</summary>
        public void PausePatchDeploymentRequestObject()
        {
            // Snippet: PausePatchDeployment(PausePatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            PausePatchDeploymentRequest request = new PausePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            // Make the request
            PatchDeployment response = osConfigServiceClient.PausePatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for PausePatchDeploymentAsync</summary>
        public async Task PausePatchDeploymentRequestObjectAsync()
        {
            // Snippet: PausePatchDeploymentAsync(PausePatchDeploymentRequest, CallSettings)
            // Additional: PausePatchDeploymentAsync(PausePatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            PausePatchDeploymentRequest request = new PausePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            // Make the request
            PatchDeployment response = await osConfigServiceClient.PausePatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PausePatchDeployment</summary>
        public void PausePatchDeployment()
        {
            // Snippet: PausePatchDeployment(string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchDeployments/[PATCH_DEPLOYMENT]";
            // Make the request
            PatchDeployment response = osConfigServiceClient.PausePatchDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for PausePatchDeploymentAsync</summary>
        public async Task PausePatchDeploymentAsync()
        {
            // Snippet: PausePatchDeploymentAsync(string, CallSettings)
            // Additional: PausePatchDeploymentAsync(string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchDeployments/[PATCH_DEPLOYMENT]";
            // Make the request
            PatchDeployment response = await osConfigServiceClient.PausePatchDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PausePatchDeployment</summary>
        public void PausePatchDeploymentResourceNames()
        {
            // Snippet: PausePatchDeployment(PatchDeploymentName, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            PatchDeploymentName name = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]");
            // Make the request
            PatchDeployment response = osConfigServiceClient.PausePatchDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for PausePatchDeploymentAsync</summary>
        public async Task PausePatchDeploymentResourceNamesAsync()
        {
            // Snippet: PausePatchDeploymentAsync(PatchDeploymentName, CallSettings)
            // Additional: PausePatchDeploymentAsync(PatchDeploymentName, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchDeploymentName name = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]");
            // Make the request
            PatchDeployment response = await osConfigServiceClient.PausePatchDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumePatchDeployment</summary>
        public void ResumePatchDeploymentRequestObject()
        {
            // Snippet: ResumePatchDeployment(ResumePatchDeploymentRequest, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            ResumePatchDeploymentRequest request = new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            // Make the request
            PatchDeployment response = osConfigServiceClient.ResumePatchDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for ResumePatchDeploymentAsync</summary>
        public async Task ResumePatchDeploymentRequestObjectAsync()
        {
            // Snippet: ResumePatchDeploymentAsync(ResumePatchDeploymentRequest, CallSettings)
            // Additional: ResumePatchDeploymentAsync(ResumePatchDeploymentRequest, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ResumePatchDeploymentRequest request = new ResumePatchDeploymentRequest
            {
                PatchDeploymentName = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]"),
            };
            // Make the request
            PatchDeployment response = await osConfigServiceClient.ResumePatchDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumePatchDeployment</summary>
        public void ResumePatchDeployment()
        {
            // Snippet: ResumePatchDeployment(string, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchDeployments/[PATCH_DEPLOYMENT]";
            // Make the request
            PatchDeployment response = osConfigServiceClient.ResumePatchDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for ResumePatchDeploymentAsync</summary>
        public async Task ResumePatchDeploymentAsync()
        {
            // Snippet: ResumePatchDeploymentAsync(string, CallSettings)
            // Additional: ResumePatchDeploymentAsync(string, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/patchDeployments/[PATCH_DEPLOYMENT]";
            // Make the request
            PatchDeployment response = await osConfigServiceClient.ResumePatchDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumePatchDeployment</summary>
        public void ResumePatchDeploymentResourceNames()
        {
            // Snippet: ResumePatchDeployment(PatchDeploymentName, CallSettings)
            // Create client
            OsConfigServiceClient osConfigServiceClient = OsConfigServiceClient.Create();
            // Initialize request argument(s)
            PatchDeploymentName name = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]");
            // Make the request
            PatchDeployment response = osConfigServiceClient.ResumePatchDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for ResumePatchDeploymentAsync</summary>
        public async Task ResumePatchDeploymentResourceNamesAsync()
        {
            // Snippet: ResumePatchDeploymentAsync(PatchDeploymentName, CallSettings)
            // Additional: ResumePatchDeploymentAsync(PatchDeploymentName, CancellationToken)
            // Create client
            OsConfigServiceClient osConfigServiceClient = await OsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchDeploymentName name = PatchDeploymentName.FromProjectPatchDeployment("[PROJECT]", "[PATCH_DEPLOYMENT]");
            // Make the request
            PatchDeployment response = await osConfigServiceClient.ResumePatchDeploymentAsync(name);
            // End snippet
        }
    }
}
