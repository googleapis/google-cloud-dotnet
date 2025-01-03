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
    using Google.Cloud.EnterpriseKnowledgeGraph.V1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedEnterpriseKnowledgeGraphServiceClientSnippets
    {
        /// <summary>Snippet for CreateEntityReconciliationJob</summary>
        public void CreateEntityReconciliationJobRequestObject()
        {
            // Snippet: CreateEntityReconciliationJob(CreateEntityReconciliationJobRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            CreateEntityReconciliationJobRequest request = new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntityReconciliationJob = new EntityReconciliationJob(),
            };
            // Make the request
            EntityReconciliationJob response = enterpriseKnowledgeGraphServiceClient.CreateEntityReconciliationJob(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityReconciliationJobAsync</summary>
        public async Task CreateEntityReconciliationJobRequestObjectAsync()
        {
            // Snippet: CreateEntityReconciliationJobAsync(CreateEntityReconciliationJobRequest, CallSettings)
            // Additional: CreateEntityReconciliationJobAsync(CreateEntityReconciliationJobRequest, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntityReconciliationJobRequest request = new CreateEntityReconciliationJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntityReconciliationJob = new EntityReconciliationJob(),
            };
            // Make the request
            EntityReconciliationJob response = await enterpriseKnowledgeGraphServiceClient.CreateEntityReconciliationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityReconciliationJob</summary>
        public void CreateEntityReconciliationJob()
        {
            // Snippet: CreateEntityReconciliationJob(string, EntityReconciliationJob, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            EntityReconciliationJob entityReconciliationJob = new EntityReconciliationJob();
            // Make the request
            EntityReconciliationJob response = enterpriseKnowledgeGraphServiceClient.CreateEntityReconciliationJob(parent, entityReconciliationJob);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityReconciliationJobAsync</summary>
        public async Task CreateEntityReconciliationJobAsync()
        {
            // Snippet: CreateEntityReconciliationJobAsync(string, EntityReconciliationJob, CallSettings)
            // Additional: CreateEntityReconciliationJobAsync(string, EntityReconciliationJob, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            EntityReconciliationJob entityReconciliationJob = new EntityReconciliationJob();
            // Make the request
            EntityReconciliationJob response = await enterpriseKnowledgeGraphServiceClient.CreateEntityReconciliationJobAsync(parent, entityReconciliationJob);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityReconciliationJob</summary>
        public void CreateEntityReconciliationJobResourceNames()
        {
            // Snippet: CreateEntityReconciliationJob(LocationName, EntityReconciliationJob, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EntityReconciliationJob entityReconciliationJob = new EntityReconciliationJob();
            // Make the request
            EntityReconciliationJob response = enterpriseKnowledgeGraphServiceClient.CreateEntityReconciliationJob(parent, entityReconciliationJob);
            // End snippet
        }

        /// <summary>Snippet for CreateEntityReconciliationJobAsync</summary>
        public async Task CreateEntityReconciliationJobResourceNamesAsync()
        {
            // Snippet: CreateEntityReconciliationJobAsync(LocationName, EntityReconciliationJob, CallSettings)
            // Additional: CreateEntityReconciliationJobAsync(LocationName, EntityReconciliationJob, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EntityReconciliationJob entityReconciliationJob = new EntityReconciliationJob();
            // Make the request
            EntityReconciliationJob response = await enterpriseKnowledgeGraphServiceClient.CreateEntityReconciliationJobAsync(parent, entityReconciliationJob);
            // End snippet
        }

        /// <summary>Snippet for GetEntityReconciliationJob</summary>
        public void GetEntityReconciliationJobRequestObject()
        {
            // Snippet: GetEntityReconciliationJob(GetEntityReconciliationJobRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            GetEntityReconciliationJobRequest request = new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            // Make the request
            EntityReconciliationJob response = enterpriseKnowledgeGraphServiceClient.GetEntityReconciliationJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityReconciliationJobAsync</summary>
        public async Task GetEntityReconciliationJobRequestObjectAsync()
        {
            // Snippet: GetEntityReconciliationJobAsync(GetEntityReconciliationJobRequest, CallSettings)
            // Additional: GetEntityReconciliationJobAsync(GetEntityReconciliationJobRequest, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEntityReconciliationJobRequest request = new GetEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            // Make the request
            EntityReconciliationJob response = await enterpriseKnowledgeGraphServiceClient.GetEntityReconciliationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntityReconciliationJob</summary>
        public void GetEntityReconciliationJob()
        {
            // Snippet: GetEntityReconciliationJob(string, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entityReconciliationJobs/[ENTITY_RECONCILIATION_JOB]";
            // Make the request
            EntityReconciliationJob response = enterpriseKnowledgeGraphServiceClient.GetEntityReconciliationJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityReconciliationJobAsync</summary>
        public async Task GetEntityReconciliationJobAsync()
        {
            // Snippet: GetEntityReconciliationJobAsync(string, CallSettings)
            // Additional: GetEntityReconciliationJobAsync(string, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entityReconciliationJobs/[ENTITY_RECONCILIATION_JOB]";
            // Make the request
            EntityReconciliationJob response = await enterpriseKnowledgeGraphServiceClient.GetEntityReconciliationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityReconciliationJob</summary>
        public void GetEntityReconciliationJobResourceNames()
        {
            // Snippet: GetEntityReconciliationJob(EntityReconciliationJobName, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            EntityReconciliationJobName name = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]");
            // Make the request
            EntityReconciliationJob response = enterpriseKnowledgeGraphServiceClient.GetEntityReconciliationJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntityReconciliationJobAsync</summary>
        public async Task GetEntityReconciliationJobResourceNamesAsync()
        {
            // Snippet: GetEntityReconciliationJobAsync(EntityReconciliationJobName, CallSettings)
            // Additional: GetEntityReconciliationJobAsync(EntityReconciliationJobName, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityReconciliationJobName name = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]");
            // Make the request
            EntityReconciliationJob response = await enterpriseKnowledgeGraphServiceClient.GetEntityReconciliationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEntityReconciliationJobs</summary>
        public void ListEntityReconciliationJobsRequestObject()
        {
            // Snippet: ListEntityReconciliationJobs(ListEntityReconciliationJobsRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            ListEntityReconciliationJobsRequest request = new ListEntityReconciliationJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> response = enterpriseKnowledgeGraphServiceClient.ListEntityReconciliationJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityReconciliationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityReconciliationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityReconciliationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityReconciliationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityReconciliationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityReconciliationJobsAsync</summary>
        public async Task ListEntityReconciliationJobsRequestObjectAsync()
        {
            // Snippet: ListEntityReconciliationJobsAsync(ListEntityReconciliationJobsRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEntityReconciliationJobsRequest request = new ListEntityReconciliationJobsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> response = enterpriseKnowledgeGraphServiceClient.ListEntityReconciliationJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityReconciliationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityReconciliationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityReconciliationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityReconciliationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityReconciliationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityReconciliationJobs</summary>
        public void ListEntityReconciliationJobs()
        {
            // Snippet: ListEntityReconciliationJobs(string, string, int?, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> response = enterpriseKnowledgeGraphServiceClient.ListEntityReconciliationJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityReconciliationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityReconciliationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityReconciliationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityReconciliationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityReconciliationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityReconciliationJobsAsync</summary>
        public async Task ListEntityReconciliationJobsAsync()
        {
            // Snippet: ListEntityReconciliationJobsAsync(string, string, int?, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> response = enterpriseKnowledgeGraphServiceClient.ListEntityReconciliationJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityReconciliationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityReconciliationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityReconciliationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityReconciliationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityReconciliationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityReconciliationJobs</summary>
        public void ListEntityReconciliationJobsResourceNames()
        {
            // Snippet: ListEntityReconciliationJobs(LocationName, string, int?, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> response = enterpriseKnowledgeGraphServiceClient.ListEntityReconciliationJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntityReconciliationJob item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntityReconciliationJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityReconciliationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityReconciliationJob> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityReconciliationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntityReconciliationJobsAsync</summary>
        public async Task ListEntityReconciliationJobsResourceNamesAsync()
        {
            // Snippet: ListEntityReconciliationJobsAsync(LocationName, string, int?, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEntityReconciliationJobsResponse, EntityReconciliationJob> response = enterpriseKnowledgeGraphServiceClient.ListEntityReconciliationJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntityReconciliationJob item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntityReconciliationJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntityReconciliationJob item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntityReconciliationJob> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntityReconciliationJob item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CancelEntityReconciliationJob</summary>
        public void CancelEntityReconciliationJobRequestObject()
        {
            // Snippet: CancelEntityReconciliationJob(CancelEntityReconciliationJobRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            CancelEntityReconciliationJobRequest request = new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            // Make the request
            enterpriseKnowledgeGraphServiceClient.CancelEntityReconciliationJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelEntityReconciliationJobAsync</summary>
        public async Task CancelEntityReconciliationJobRequestObjectAsync()
        {
            // Snippet: CancelEntityReconciliationJobAsync(CancelEntityReconciliationJobRequest, CallSettings)
            // Additional: CancelEntityReconciliationJobAsync(CancelEntityReconciliationJobRequest, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelEntityReconciliationJobRequest request = new CancelEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            // Make the request
            await enterpriseKnowledgeGraphServiceClient.CancelEntityReconciliationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelEntityReconciliationJob</summary>
        public void CancelEntityReconciliationJob()
        {
            // Snippet: CancelEntityReconciliationJob(string, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entityReconciliationJobs/[ENTITY_RECONCILIATION_JOB]";
            // Make the request
            enterpriseKnowledgeGraphServiceClient.CancelEntityReconciliationJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelEntityReconciliationJobAsync</summary>
        public async Task CancelEntityReconciliationJobAsync()
        {
            // Snippet: CancelEntityReconciliationJobAsync(string, CallSettings)
            // Additional: CancelEntityReconciliationJobAsync(string, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entityReconciliationJobs/[ENTITY_RECONCILIATION_JOB]";
            // Make the request
            await enterpriseKnowledgeGraphServiceClient.CancelEntityReconciliationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelEntityReconciliationJob</summary>
        public void CancelEntityReconciliationJobResourceNames()
        {
            // Snippet: CancelEntityReconciliationJob(EntityReconciliationJobName, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            EntityReconciliationJobName name = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]");
            // Make the request
            enterpriseKnowledgeGraphServiceClient.CancelEntityReconciliationJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelEntityReconciliationJobAsync</summary>
        public async Task CancelEntityReconciliationJobResourceNamesAsync()
        {
            // Snippet: CancelEntityReconciliationJobAsync(EntityReconciliationJobName, CallSettings)
            // Additional: CancelEntityReconciliationJobAsync(EntityReconciliationJobName, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityReconciliationJobName name = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]");
            // Make the request
            await enterpriseKnowledgeGraphServiceClient.CancelEntityReconciliationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityReconciliationJob</summary>
        public void DeleteEntityReconciliationJobRequestObject()
        {
            // Snippet: DeleteEntityReconciliationJob(DeleteEntityReconciliationJobRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            DeleteEntityReconciliationJobRequest request = new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            // Make the request
            enterpriseKnowledgeGraphServiceClient.DeleteEntityReconciliationJob(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityReconciliationJobAsync</summary>
        public async Task DeleteEntityReconciliationJobRequestObjectAsync()
        {
            // Snippet: DeleteEntityReconciliationJobAsync(DeleteEntityReconciliationJobRequest, CallSettings)
            // Additional: DeleteEntityReconciliationJobAsync(DeleteEntityReconciliationJobRequest, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEntityReconciliationJobRequest request = new DeleteEntityReconciliationJobRequest
            {
                EntityReconciliationJobName = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]"),
            };
            // Make the request
            await enterpriseKnowledgeGraphServiceClient.DeleteEntityReconciliationJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityReconciliationJob</summary>
        public void DeleteEntityReconciliationJob()
        {
            // Snippet: DeleteEntityReconciliationJob(string, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entityReconciliationJobs/[ENTITY_RECONCILIATION_JOB]";
            // Make the request
            enterpriseKnowledgeGraphServiceClient.DeleteEntityReconciliationJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityReconciliationJobAsync</summary>
        public async Task DeleteEntityReconciliationJobAsync()
        {
            // Snippet: DeleteEntityReconciliationJobAsync(string, CallSettings)
            // Additional: DeleteEntityReconciliationJobAsync(string, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entityReconciliationJobs/[ENTITY_RECONCILIATION_JOB]";
            // Make the request
            await enterpriseKnowledgeGraphServiceClient.DeleteEntityReconciliationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityReconciliationJob</summary>
        public void DeleteEntityReconciliationJobResourceNames()
        {
            // Snippet: DeleteEntityReconciliationJob(EntityReconciliationJobName, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            EntityReconciliationJobName name = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]");
            // Make the request
            enterpriseKnowledgeGraphServiceClient.DeleteEntityReconciliationJob(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntityReconciliationJobAsync</summary>
        public async Task DeleteEntityReconciliationJobResourceNamesAsync()
        {
            // Snippet: DeleteEntityReconciliationJobAsync(EntityReconciliationJobName, CallSettings)
            // Additional: DeleteEntityReconciliationJobAsync(EntityReconciliationJobName, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            EntityReconciliationJobName name = EntityReconciliationJobName.FromProjectLocationEntityReconciliationJob("[PROJECT]", "[LOCATION]", "[ENTITY_RECONCILIATION_JOB]");
            // Make the request
            await enterpriseKnowledgeGraphServiceClient.DeleteEntityReconciliationJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for Lookup</summary>
        public void LookupRequestObject()
        {
            // Snippet: Lookup(LookupRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            LookupRequest request = new LookupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Ids = { "", },
                Languages = { "", },
            };
            // Make the request
            LookupResponse response = enterpriseKnowledgeGraphServiceClient.Lookup(request);
            // End snippet
        }

        /// <summary>Snippet for LookupAsync</summary>
        public async Task LookupRequestObjectAsync()
        {
            // Snippet: LookupAsync(LookupRequest, CallSettings)
            // Additional: LookupAsync(LookupRequest, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            LookupRequest request = new LookupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Ids = { "", },
                Languages = { "", },
            };
            // Make the request
            LookupResponse response = await enterpriseKnowledgeGraphServiceClient.LookupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Lookup</summary>
        public void Lookup()
        {
            // Snippet: Lookup(string, IEnumerable<string>, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> ids = new string[] { "", };
            // Make the request
            LookupResponse response = enterpriseKnowledgeGraphServiceClient.Lookup(parent, ids);
            // End snippet
        }

        /// <summary>Snippet for LookupAsync</summary>
        public async Task LookupAsync()
        {
            // Snippet: LookupAsync(string, IEnumerable<string>, CallSettings)
            // Additional: LookupAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> ids = new string[] { "", };
            // Make the request
            LookupResponse response = await enterpriseKnowledgeGraphServiceClient.LookupAsync(parent, ids);
            // End snippet
        }

        /// <summary>Snippet for Lookup</summary>
        public void LookupResourceNames()
        {
            // Snippet: Lookup(LocationName, IEnumerable<string>, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> ids = new string[] { "", };
            // Make the request
            LookupResponse response = enterpriseKnowledgeGraphServiceClient.Lookup(parent, ids);
            // End snippet
        }

        /// <summary>Snippet for LookupAsync</summary>
        public async Task LookupResourceNamesAsync()
        {
            // Snippet: LookupAsync(LocationName, IEnumerable<string>, CallSettings)
            // Additional: LookupAsync(LocationName, IEnumerable<string>, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> ids = new string[] { "", };
            // Make the request
            LookupResponse response = await enterpriseKnowledgeGraphServiceClient.LookupAsync(parent, ids);
            // End snippet
        }

        /// <summary>Snippet for Search</summary>
        public void SearchRequestObject()
        {
            // Snippet: Search(SearchRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            SearchRequest request = new SearchRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
                Languages = { "", },
                Types_ = { "", },
                Limit = 0,
            };
            // Make the request
            SearchResponse response = enterpriseKnowledgeGraphServiceClient.Search(request);
            // End snippet
        }

        /// <summary>Snippet for SearchAsync</summary>
        public async Task SearchRequestObjectAsync()
        {
            // Snippet: SearchAsync(SearchRequest, CallSettings)
            // Additional: SearchAsync(SearchRequest, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchRequest request = new SearchRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
                Languages = { "", },
                Types_ = { "", },
                Limit = 0,
            };
            // Make the request
            SearchResponse response = await enterpriseKnowledgeGraphServiceClient.SearchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Search</summary>
        public void Search()
        {
            // Snippet: Search(string, string, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            SearchResponse response = enterpriseKnowledgeGraphServiceClient.Search(parent, query);
            // End snippet
        }

        /// <summary>Snippet for SearchAsync</summary>
        public async Task SearchAsync()
        {
            // Snippet: SearchAsync(string, string, CallSettings)
            // Additional: SearchAsync(string, string, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            SearchResponse response = await enterpriseKnowledgeGraphServiceClient.SearchAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for Search</summary>
        public void SearchResourceNames()
        {
            // Snippet: Search(LocationName, string, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            SearchResponse response = enterpriseKnowledgeGraphServiceClient.Search(parent, query);
            // End snippet
        }

        /// <summary>Snippet for SearchAsync</summary>
        public async Task SearchResourceNamesAsync()
        {
            // Snippet: SearchAsync(LocationName, string, CallSettings)
            // Additional: SearchAsync(LocationName, string, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            SearchResponse response = await enterpriseKnowledgeGraphServiceClient.SearchAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for LookupPublicKg</summary>
        public void LookupPublicKgRequestObject()
        {
            // Snippet: LookupPublicKg(LookupPublicKgRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            LookupPublicKgRequest request = new LookupPublicKgRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Ids = { "", },
                Languages = { "", },
            };
            // Make the request
            LookupPublicKgResponse response = enterpriseKnowledgeGraphServiceClient.LookupPublicKg(request);
            // End snippet
        }

        /// <summary>Snippet for LookupPublicKgAsync</summary>
        public async Task LookupPublicKgRequestObjectAsync()
        {
            // Snippet: LookupPublicKgAsync(LookupPublicKgRequest, CallSettings)
            // Additional: LookupPublicKgAsync(LookupPublicKgRequest, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            LookupPublicKgRequest request = new LookupPublicKgRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Ids = { "", },
                Languages = { "", },
            };
            // Make the request
            LookupPublicKgResponse response = await enterpriseKnowledgeGraphServiceClient.LookupPublicKgAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LookupPublicKg</summary>
        public void LookupPublicKg()
        {
            // Snippet: LookupPublicKg(string, IEnumerable<string>, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> ids = new string[] { "", };
            // Make the request
            LookupPublicKgResponse response = enterpriseKnowledgeGraphServiceClient.LookupPublicKg(parent, ids);
            // End snippet
        }

        /// <summary>Snippet for LookupPublicKgAsync</summary>
        public async Task LookupPublicKgAsync()
        {
            // Snippet: LookupPublicKgAsync(string, IEnumerable<string>, CallSettings)
            // Additional: LookupPublicKgAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<string> ids = new string[] { "", };
            // Make the request
            LookupPublicKgResponse response = await enterpriseKnowledgeGraphServiceClient.LookupPublicKgAsync(parent, ids);
            // End snippet
        }

        /// <summary>Snippet for LookupPublicKg</summary>
        public void LookupPublicKgResourceNames()
        {
            // Snippet: LookupPublicKg(LocationName, IEnumerable<string>, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> ids = new string[] { "", };
            // Make the request
            LookupPublicKgResponse response = enterpriseKnowledgeGraphServiceClient.LookupPublicKg(parent, ids);
            // End snippet
        }

        /// <summary>Snippet for LookupPublicKgAsync</summary>
        public async Task LookupPublicKgResourceNamesAsync()
        {
            // Snippet: LookupPublicKgAsync(LocationName, IEnumerable<string>, CallSettings)
            // Additional: LookupPublicKgAsync(LocationName, IEnumerable<string>, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<string> ids = new string[] { "", };
            // Make the request
            LookupPublicKgResponse response = await enterpriseKnowledgeGraphServiceClient.LookupPublicKgAsync(parent, ids);
            // End snippet
        }

        /// <summary>Snippet for SearchPublicKg</summary>
        public void SearchPublicKgRequestObject()
        {
            // Snippet: SearchPublicKg(SearchPublicKgRequest, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            SearchPublicKgRequest request = new SearchPublicKgRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
                Languages = { "", },
                Types_ = { "", },
                Limit = 0,
            };
            // Make the request
            SearchPublicKgResponse response = enterpriseKnowledgeGraphServiceClient.SearchPublicKg(request);
            // End snippet
        }

        /// <summary>Snippet for SearchPublicKgAsync</summary>
        public async Task SearchPublicKgRequestObjectAsync()
        {
            // Snippet: SearchPublicKgAsync(SearchPublicKgRequest, CallSettings)
            // Additional: SearchPublicKgAsync(SearchPublicKgRequest, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchPublicKgRequest request = new SearchPublicKgRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Query = "",
                Languages = { "", },
                Types_ = { "", },
                Limit = 0,
            };
            // Make the request
            SearchPublicKgResponse response = await enterpriseKnowledgeGraphServiceClient.SearchPublicKgAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchPublicKg</summary>
        public void SearchPublicKg()
        {
            // Snippet: SearchPublicKg(string, string, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            SearchPublicKgResponse response = enterpriseKnowledgeGraphServiceClient.SearchPublicKg(parent, query);
            // End snippet
        }

        /// <summary>Snippet for SearchPublicKgAsync</summary>
        public async Task SearchPublicKgAsync()
        {
            // Snippet: SearchPublicKgAsync(string, string, CallSettings)
            // Additional: SearchPublicKgAsync(string, string, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string query = "";
            // Make the request
            SearchPublicKgResponse response = await enterpriseKnowledgeGraphServiceClient.SearchPublicKgAsync(parent, query);
            // End snippet
        }

        /// <summary>Snippet for SearchPublicKg</summary>
        public void SearchPublicKgResourceNames()
        {
            // Snippet: SearchPublicKg(LocationName, string, CallSettings)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = EnterpriseKnowledgeGraphServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            SearchPublicKgResponse response = enterpriseKnowledgeGraphServiceClient.SearchPublicKg(parent, query);
            // End snippet
        }

        /// <summary>Snippet for SearchPublicKgAsync</summary>
        public async Task SearchPublicKgResourceNamesAsync()
        {
            // Snippet: SearchPublicKgAsync(LocationName, string, CallSettings)
            // Additional: SearchPublicKgAsync(LocationName, string, CancellationToken)
            // Create client
            EnterpriseKnowledgeGraphServiceClient enterpriseKnowledgeGraphServiceClient = await EnterpriseKnowledgeGraphServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string query = "";
            // Make the request
            SearchPublicKgResponse response = await enterpriseKnowledgeGraphServiceClient.SearchPublicKgAsync(parent, query);
            // End snippet
        }
    }
}
