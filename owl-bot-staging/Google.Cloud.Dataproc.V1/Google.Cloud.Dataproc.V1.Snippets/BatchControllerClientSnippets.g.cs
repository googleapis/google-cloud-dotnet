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
    using Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBatchControllerClientSnippets
    {
        /// <summary>Snippet for CreateBatch</summary>
        public void CreateBatchRequestObject()
        {
            // Snippet: CreateBatch(CreateBatchRequest, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            CreateBatchRequest request = new CreateBatchRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Batch = new Batch(),
                BatchId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Batch, BatchOperationMetadata> response = batchControllerClient.CreateBatch(request);

            // Poll until the returned long-running operation is complete
            Operation<Batch, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Batch result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Batch, BatchOperationMetadata> retrievedResponse = batchControllerClient.PollOnceCreateBatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Batch retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBatchAsync</summary>
        public async Task CreateBatchRequestObjectAsync()
        {
            // Snippet: CreateBatchAsync(CreateBatchRequest, CallSettings)
            // Additional: CreateBatchAsync(CreateBatchRequest, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            CreateBatchRequest request = new CreateBatchRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Batch = new Batch(),
                BatchId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Batch, BatchOperationMetadata> response = await batchControllerClient.CreateBatchAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Batch, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Batch result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Batch, BatchOperationMetadata> retrievedResponse = await batchControllerClient.PollOnceCreateBatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Batch retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBatch</summary>
        public void CreateBatch()
        {
            // Snippet: CreateBatch(string, Batch, string, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Batch batch = new Batch();
            string batchId = "";
            // Make the request
            Operation<Batch, BatchOperationMetadata> response = batchControllerClient.CreateBatch(parent, batch, batchId);

            // Poll until the returned long-running operation is complete
            Operation<Batch, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Batch result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Batch, BatchOperationMetadata> retrievedResponse = batchControllerClient.PollOnceCreateBatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Batch retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBatchAsync</summary>
        public async Task CreateBatchAsync()
        {
            // Snippet: CreateBatchAsync(string, Batch, string, CallSettings)
            // Additional: CreateBatchAsync(string, Batch, string, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Batch batch = new Batch();
            string batchId = "";
            // Make the request
            Operation<Batch, BatchOperationMetadata> response = await batchControllerClient.CreateBatchAsync(parent, batch, batchId);

            // Poll until the returned long-running operation is complete
            Operation<Batch, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Batch result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Batch, BatchOperationMetadata> retrievedResponse = await batchControllerClient.PollOnceCreateBatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Batch retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBatch</summary>
        public void CreateBatchResourceNames()
        {
            // Snippet: CreateBatch(LocationName, Batch, string, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Batch batch = new Batch();
            string batchId = "";
            // Make the request
            Operation<Batch, BatchOperationMetadata> response = batchControllerClient.CreateBatch(parent, batch, batchId);

            // Poll until the returned long-running operation is complete
            Operation<Batch, BatchOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Batch result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Batch, BatchOperationMetadata> retrievedResponse = batchControllerClient.PollOnceCreateBatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Batch retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBatchAsync</summary>
        public async Task CreateBatchResourceNamesAsync()
        {
            // Snippet: CreateBatchAsync(LocationName, Batch, string, CallSettings)
            // Additional: CreateBatchAsync(LocationName, Batch, string, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Batch batch = new Batch();
            string batchId = "";
            // Make the request
            Operation<Batch, BatchOperationMetadata> response = await batchControllerClient.CreateBatchAsync(parent, batch, batchId);

            // Poll until the returned long-running operation is complete
            Operation<Batch, BatchOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Batch result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Batch, BatchOperationMetadata> retrievedResponse = await batchControllerClient.PollOnceCreateBatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Batch retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetBatch</summary>
        public void GetBatchRequestObject()
        {
            // Snippet: GetBatch(GetBatchRequest, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            GetBatchRequest request = new GetBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            // Make the request
            Batch response = batchControllerClient.GetBatch(request);
            // End snippet
        }

        /// <summary>Snippet for GetBatchAsync</summary>
        public async Task GetBatchRequestObjectAsync()
        {
            // Snippet: GetBatchAsync(GetBatchRequest, CallSettings)
            // Additional: GetBatchAsync(GetBatchRequest, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            GetBatchRequest request = new GetBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            // Make the request
            Batch response = await batchControllerClient.GetBatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBatch</summary>
        public void GetBatch()
        {
            // Snippet: GetBatch(string, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batches/[BATCH]";
            // Make the request
            Batch response = batchControllerClient.GetBatch(name);
            // End snippet
        }

        /// <summary>Snippet for GetBatchAsync</summary>
        public async Task GetBatchAsync()
        {
            // Snippet: GetBatchAsync(string, CallSettings)
            // Additional: GetBatchAsync(string, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batches/[BATCH]";
            // Make the request
            Batch response = await batchControllerClient.GetBatchAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBatch</summary>
        public void GetBatchResourceNames()
        {
            // Snippet: GetBatch(BatchName, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            BatchName name = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]");
            // Make the request
            Batch response = batchControllerClient.GetBatch(name);
            // End snippet
        }

        /// <summary>Snippet for GetBatchAsync</summary>
        public async Task GetBatchResourceNamesAsync()
        {
            // Snippet: GetBatchAsync(BatchName, CallSettings)
            // Additional: GetBatchAsync(BatchName, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            BatchName name = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]");
            // Make the request
            Batch response = await batchControllerClient.GetBatchAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBatches</summary>
        public void ListBatchesRequestObject()
        {
            // Snippet: ListBatches(ListBatchesRequest, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            ListBatchesRequest request = new ListBatchesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBatchesResponse, Batch> response = batchControllerClient.ListBatches(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Batch item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Batch item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Batch> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Batch item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchesAsync</summary>
        public async Task ListBatchesRequestObjectAsync()
        {
            // Snippet: ListBatchesAsync(ListBatchesRequest, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            ListBatchesRequest request = new ListBatchesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBatchesResponse, Batch> response = batchControllerClient.ListBatchesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Batch item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Batch item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Batch> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Batch item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatches</summary>
        public void ListBatches()
        {
            // Snippet: ListBatches(string, string, int?, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBatchesResponse, Batch> response = batchControllerClient.ListBatches(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Batch item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Batch item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Batch> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Batch item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchesAsync</summary>
        public async Task ListBatchesAsync()
        {
            // Snippet: ListBatchesAsync(string, string, int?, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBatchesResponse, Batch> response = batchControllerClient.ListBatchesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Batch item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Batch item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Batch> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Batch item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatches</summary>
        public void ListBatchesResourceNames()
        {
            // Snippet: ListBatches(LocationName, string, int?, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBatchesResponse, Batch> response = batchControllerClient.ListBatches(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Batch item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBatchesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Batch item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Batch> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Batch item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBatchesAsync</summary>
        public async Task ListBatchesResourceNamesAsync()
        {
            // Snippet: ListBatchesAsync(LocationName, string, int?, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBatchesResponse, Batch> response = batchControllerClient.ListBatchesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Batch item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBatchesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Batch item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Batch> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Batch item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBatch</summary>
        public void DeleteBatchRequestObject()
        {
            // Snippet: DeleteBatch(DeleteBatchRequest, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            DeleteBatchRequest request = new DeleteBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            // Make the request
            batchControllerClient.DeleteBatch(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchAsync</summary>
        public async Task DeleteBatchRequestObjectAsync()
        {
            // Snippet: DeleteBatchAsync(DeleteBatchRequest, CallSettings)
            // Additional: DeleteBatchAsync(DeleteBatchRequest, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBatchRequest request = new DeleteBatchRequest
            {
                BatchName = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]"),
            };
            // Make the request
            await batchControllerClient.DeleteBatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBatch</summary>
        public void DeleteBatch()
        {
            // Snippet: DeleteBatch(string, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batches/[BATCH]";
            // Make the request
            batchControllerClient.DeleteBatch(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchAsync</summary>
        public async Task DeleteBatchAsync()
        {
            // Snippet: DeleteBatchAsync(string, CallSettings)
            // Additional: DeleteBatchAsync(string, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/batches/[BATCH]";
            // Make the request
            await batchControllerClient.DeleteBatchAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBatch</summary>
        public void DeleteBatchResourceNames()
        {
            // Snippet: DeleteBatch(BatchName, CallSettings)
            // Create client
            BatchControllerClient batchControllerClient = BatchControllerClient.Create();
            // Initialize request argument(s)
            BatchName name = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]");
            // Make the request
            batchControllerClient.DeleteBatch(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBatchAsync</summary>
        public async Task DeleteBatchResourceNamesAsync()
        {
            // Snippet: DeleteBatchAsync(BatchName, CallSettings)
            // Additional: DeleteBatchAsync(BatchName, CancellationToken)
            // Create client
            BatchControllerClient batchControllerClient = await BatchControllerClient.CreateAsync();
            // Initialize request argument(s)
            BatchName name = BatchName.FromProjectLocationBatch("[PROJECT]", "[LOCATION]", "[BATCH]");
            // Make the request
            await batchControllerClient.DeleteBatchAsync(name);
            // End snippet
        }
    }
}
