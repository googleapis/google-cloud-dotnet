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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMigrationServiceClientSnippets
    {
        /// <summary>Snippet for SearchMigratableResources</summary>
        public void SearchMigratableResourcesRequestObject()
        {
            // Snippet: SearchMigratableResources(SearchMigratableResourcesRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            SearchMigratableResourcesRequest request = new SearchMigratableResourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<SearchMigratableResourcesResponse, MigratableResource> response = migrationServiceClient.SearchMigratableResources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigratableResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchMigratableResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratableResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratableResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratableResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMigratableResourcesAsync</summary>
        public async Task SearchMigratableResourcesRequestObjectAsync()
        {
            // Snippet: SearchMigratableResourcesAsync(SearchMigratableResourcesRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchMigratableResourcesRequest request = new SearchMigratableResourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchMigratableResourcesResponse, MigratableResource> response = migrationServiceClient.SearchMigratableResourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigratableResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchMigratableResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratableResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratableResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratableResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMigratableResources</summary>
        public void SearchMigratableResources()
        {
            // Snippet: SearchMigratableResources(string, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<SearchMigratableResourcesResponse, MigratableResource> response = migrationServiceClient.SearchMigratableResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigratableResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchMigratableResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratableResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratableResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratableResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMigratableResourcesAsync</summary>
        public async Task SearchMigratableResourcesAsync()
        {
            // Snippet: SearchMigratableResourcesAsync(string, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<SearchMigratableResourcesResponse, MigratableResource> response = migrationServiceClient.SearchMigratableResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigratableResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchMigratableResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratableResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratableResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratableResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMigratableResources</summary>
        public void SearchMigratableResourcesResourceNames()
        {
            // Snippet: SearchMigratableResources(LocationName, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<SearchMigratableResourcesResponse, MigratableResource> response = migrationServiceClient.SearchMigratableResources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MigratableResource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchMigratableResourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratableResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratableResource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratableResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchMigratableResourcesAsync</summary>
        public async Task SearchMigratableResourcesResourceNamesAsync()
        {
            // Snippet: SearchMigratableResourcesAsync(LocationName, string, int?, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<SearchMigratableResourcesResponse, MigratableResource> response = migrationServiceClient.SearchMigratableResourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MigratableResource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchMigratableResourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MigratableResource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MigratableResource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MigratableResource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchMigrateResources</summary>
        public void BatchMigrateResourcesRequestObject()
        {
            // Snippet: BatchMigrateResources(BatchMigrateResourcesRequest, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            BatchMigrateResourcesRequest request = new BatchMigrateResourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrateResourceRequests =
                {
                    new MigrateResourceRequest(),
                },
            };
            // Make the request
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> response = migrationServiceClient.BatchMigrateResources(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchMigrateResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> retrievedResponse = migrationServiceClient.PollOnceBatchMigrateResources(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchMigrateResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchMigrateResourcesAsync</summary>
        public async Task BatchMigrateResourcesRequestObjectAsync()
        {
            // Snippet: BatchMigrateResourcesAsync(BatchMigrateResourcesRequest, CallSettings)
            // Additional: BatchMigrateResourcesAsync(BatchMigrateResourcesRequest, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchMigrateResourcesRequest request = new BatchMigrateResourcesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MigrateResourceRequests =
                {
                    new MigrateResourceRequest(),
                },
            };
            // Make the request
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> response = await migrationServiceClient.BatchMigrateResourcesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchMigrateResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> retrievedResponse = await migrationServiceClient.PollOnceBatchMigrateResourcesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchMigrateResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchMigrateResources</summary>
        public void BatchMigrateResources()
        {
            // Snippet: BatchMigrateResources(string, IEnumerable<MigrateResourceRequest>, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<MigrateResourceRequest> migrateResourceRequests = new MigrateResourceRequest[]
            {
                new MigrateResourceRequest(),
            };
            // Make the request
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> response = migrationServiceClient.BatchMigrateResources(parent, migrateResourceRequests);

            // Poll until the returned long-running operation is complete
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchMigrateResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> retrievedResponse = migrationServiceClient.PollOnceBatchMigrateResources(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchMigrateResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchMigrateResourcesAsync</summary>
        public async Task BatchMigrateResourcesAsync()
        {
            // Snippet: BatchMigrateResourcesAsync(string, IEnumerable<MigrateResourceRequest>, CallSettings)
            // Additional: BatchMigrateResourcesAsync(string, IEnumerable<MigrateResourceRequest>, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IEnumerable<MigrateResourceRequest> migrateResourceRequests = new MigrateResourceRequest[]
            {
                new MigrateResourceRequest(),
            };
            // Make the request
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> response = await migrationServiceClient.BatchMigrateResourcesAsync(parent, migrateResourceRequests);

            // Poll until the returned long-running operation is complete
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchMigrateResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> retrievedResponse = await migrationServiceClient.PollOnceBatchMigrateResourcesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchMigrateResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchMigrateResources</summary>
        public void BatchMigrateResourcesResourceNames()
        {
            // Snippet: BatchMigrateResources(LocationName, IEnumerable<MigrateResourceRequest>, CallSettings)
            // Create client
            MigrationServiceClient migrationServiceClient = MigrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<MigrateResourceRequest> migrateResourceRequests = new MigrateResourceRequest[]
            {
                new MigrateResourceRequest(),
            };
            // Make the request
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> response = migrationServiceClient.BatchMigrateResources(parent, migrateResourceRequests);

            // Poll until the returned long-running operation is complete
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchMigrateResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> retrievedResponse = migrationServiceClient.PollOnceBatchMigrateResources(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchMigrateResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchMigrateResourcesAsync</summary>
        public async Task BatchMigrateResourcesResourceNamesAsync()
        {
            // Snippet: BatchMigrateResourcesAsync(LocationName, IEnumerable<MigrateResourceRequest>, CallSettings)
            // Additional: BatchMigrateResourcesAsync(LocationName, IEnumerable<MigrateResourceRequest>, CancellationToken)
            // Create client
            MigrationServiceClient migrationServiceClient = await MigrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IEnumerable<MigrateResourceRequest> migrateResourceRequests = new MigrateResourceRequest[]
            {
                new MigrateResourceRequest(),
            };
            // Make the request
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> response = await migrationServiceClient.BatchMigrateResourcesAsync(parent, migrateResourceRequests);

            // Poll until the returned long-running operation is complete
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchMigrateResourcesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchMigrateResourcesResponse, BatchMigrateResourcesOperationMetadata> retrievedResponse = await migrationServiceClient.PollOnceBatchMigrateResourcesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchMigrateResourcesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
