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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSpecialistPoolServiceClientSnippets
    {
        /// <summary>Snippet for CreateSpecialistPool</summary>
        public void CreateSpecialistPoolRequestObject()
        {
            // Snippet: CreateSpecialistPool(CreateSpecialistPoolRequest, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            CreateSpecialistPoolRequest request = new CreateSpecialistPoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SpecialistPool = new SpecialistPool(),
            };
            // Make the request
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> response = specialistPoolServiceClient.CreateSpecialistPool(request);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> retrievedResponse = specialistPoolServiceClient.PollOnceCreateSpecialistPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpecialistPoolAsync</summary>
        public async Task CreateSpecialistPoolRequestObjectAsync()
        {
            // Snippet: CreateSpecialistPoolAsync(CreateSpecialistPoolRequest, CallSettings)
            // Additional: CreateSpecialistPoolAsync(CreateSpecialistPoolRequest, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSpecialistPoolRequest request = new CreateSpecialistPoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SpecialistPool = new SpecialistPool(),
            };
            // Make the request
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> response = await specialistPoolServiceClient.CreateSpecialistPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> retrievedResponse = await specialistPoolServiceClient.PollOnceCreateSpecialistPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpecialistPool</summary>
        public void CreateSpecialistPool()
        {
            // Snippet: CreateSpecialistPool(string, SpecialistPool, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SpecialistPool specialistPool = new SpecialistPool();
            // Make the request
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> response = specialistPoolServiceClient.CreateSpecialistPool(parent, specialistPool);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> retrievedResponse = specialistPoolServiceClient.PollOnceCreateSpecialistPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpecialistPoolAsync</summary>
        public async Task CreateSpecialistPoolAsync()
        {
            // Snippet: CreateSpecialistPoolAsync(string, SpecialistPool, CallSettings)
            // Additional: CreateSpecialistPoolAsync(string, SpecialistPool, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SpecialistPool specialistPool = new SpecialistPool();
            // Make the request
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> response = await specialistPoolServiceClient.CreateSpecialistPoolAsync(parent, specialistPool);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> retrievedResponse = await specialistPoolServiceClient.PollOnceCreateSpecialistPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpecialistPool</summary>
        public void CreateSpecialistPoolResourceNames()
        {
            // Snippet: CreateSpecialistPool(LocationName, SpecialistPool, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SpecialistPool specialistPool = new SpecialistPool();
            // Make the request
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> response = specialistPoolServiceClient.CreateSpecialistPool(parent, specialistPool);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> retrievedResponse = specialistPoolServiceClient.PollOnceCreateSpecialistPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSpecialistPoolAsync</summary>
        public async Task CreateSpecialistPoolResourceNamesAsync()
        {
            // Snippet: CreateSpecialistPoolAsync(LocationName, SpecialistPool, CallSettings)
            // Additional: CreateSpecialistPoolAsync(LocationName, SpecialistPool, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SpecialistPool specialistPool = new SpecialistPool();
            // Make the request
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> response = await specialistPoolServiceClient.CreateSpecialistPoolAsync(parent, specialistPool);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, CreateSpecialistPoolOperationMetadata> retrievedResponse = await specialistPoolServiceClient.PollOnceCreateSpecialistPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSpecialistPool</summary>
        public void GetSpecialistPoolRequestObject()
        {
            // Snippet: GetSpecialistPool(GetSpecialistPoolRequest, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            GetSpecialistPoolRequest request = new GetSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
            };
            // Make the request
            SpecialistPool response = specialistPoolServiceClient.GetSpecialistPool(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpecialistPoolAsync</summary>
        public async Task GetSpecialistPoolRequestObjectAsync()
        {
            // Snippet: GetSpecialistPoolAsync(GetSpecialistPoolRequest, CallSettings)
            // Additional: GetSpecialistPoolAsync(GetSpecialistPoolRequest, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSpecialistPoolRequest request = new GetSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
            };
            // Make the request
            SpecialistPool response = await specialistPoolServiceClient.GetSpecialistPoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpecialistPool</summary>
        public void GetSpecialistPool()
        {
            // Snippet: GetSpecialistPool(string, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/specialistPools/[SPECIALIST_POOL]";
            // Make the request
            SpecialistPool response = specialistPoolServiceClient.GetSpecialistPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecialistPoolAsync</summary>
        public async Task GetSpecialistPoolAsync()
        {
            // Snippet: GetSpecialistPoolAsync(string, CallSettings)
            // Additional: GetSpecialistPoolAsync(string, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/specialistPools/[SPECIALIST_POOL]";
            // Make the request
            SpecialistPool response = await specialistPoolServiceClient.GetSpecialistPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecialistPool</summary>
        public void GetSpecialistPoolResourceNames()
        {
            // Snippet: GetSpecialistPool(SpecialistPoolName, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            SpecialistPoolName name = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]");
            // Make the request
            SpecialistPool response = specialistPoolServiceClient.GetSpecialistPool(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpecialistPoolAsync</summary>
        public async Task GetSpecialistPoolResourceNamesAsync()
        {
            // Snippet: GetSpecialistPoolAsync(SpecialistPoolName, CallSettings)
            // Additional: GetSpecialistPoolAsync(SpecialistPoolName, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpecialistPoolName name = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]");
            // Make the request
            SpecialistPool response = await specialistPoolServiceClient.GetSpecialistPoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSpecialistPools</summary>
        public void ListSpecialistPoolsRequestObject()
        {
            // Snippet: ListSpecialistPools(ListSpecialistPoolsRequest, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            ListSpecialistPoolsRequest request = new ListSpecialistPoolsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListSpecialistPoolsResponse, SpecialistPool> response = specialistPoolServiceClient.ListSpecialistPools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SpecialistPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpecialistPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpecialistPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpecialistPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpecialistPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecialistPoolsAsync</summary>
        public async Task ListSpecialistPoolsRequestObjectAsync()
        {
            // Snippet: ListSpecialistPoolsAsync(ListSpecialistPoolsRequest, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSpecialistPoolsRequest request = new ListSpecialistPoolsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListSpecialistPoolsResponse, SpecialistPool> response = specialistPoolServiceClient.ListSpecialistPoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SpecialistPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpecialistPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpecialistPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpecialistPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpecialistPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecialistPools</summary>
        public void ListSpecialistPools()
        {
            // Snippet: ListSpecialistPools(string, string, int?, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSpecialistPoolsResponse, SpecialistPool> response = specialistPoolServiceClient.ListSpecialistPools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SpecialistPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpecialistPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpecialistPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpecialistPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpecialistPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecialistPoolsAsync</summary>
        public async Task ListSpecialistPoolsAsync()
        {
            // Snippet: ListSpecialistPoolsAsync(string, string, int?, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSpecialistPoolsResponse, SpecialistPool> response = specialistPoolServiceClient.ListSpecialistPoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SpecialistPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpecialistPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpecialistPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpecialistPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpecialistPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecialistPools</summary>
        public void ListSpecialistPoolsResourceNames()
        {
            // Snippet: ListSpecialistPools(LocationName, string, int?, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSpecialistPoolsResponse, SpecialistPool> response = specialistPoolServiceClient.ListSpecialistPools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SpecialistPool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpecialistPoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpecialistPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpecialistPool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpecialistPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpecialistPoolsAsync</summary>
        public async Task ListSpecialistPoolsResourceNamesAsync()
        {
            // Snippet: ListSpecialistPoolsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSpecialistPoolsResponse, SpecialistPool> response = specialistPoolServiceClient.ListSpecialistPoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SpecialistPool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpecialistPoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpecialistPool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpecialistPool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpecialistPool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecialistPool</summary>
        public void DeleteSpecialistPoolRequestObject()
        {
            // Snippet: DeleteSpecialistPool(DeleteSpecialistPoolRequest, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            DeleteSpecialistPoolRequest request = new DeleteSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = specialistPoolServiceClient.DeleteSpecialistPool(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = specialistPoolServiceClient.PollOnceDeleteSpecialistPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecialistPoolAsync</summary>
        public async Task DeleteSpecialistPoolRequestObjectAsync()
        {
            // Snippet: DeleteSpecialistPoolAsync(DeleteSpecialistPoolRequest, CallSettings)
            // Additional: DeleteSpecialistPoolAsync(DeleteSpecialistPoolRequest, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSpecialistPoolRequest request = new DeleteSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await specialistPoolServiceClient.DeleteSpecialistPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await specialistPoolServiceClient.PollOnceDeleteSpecialistPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecialistPool</summary>
        public void DeleteSpecialistPool()
        {
            // Snippet: DeleteSpecialistPool(string, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/specialistPools/[SPECIALIST_POOL]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = specialistPoolServiceClient.DeleteSpecialistPool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = specialistPoolServiceClient.PollOnceDeleteSpecialistPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecialistPoolAsync</summary>
        public async Task DeleteSpecialistPoolAsync()
        {
            // Snippet: DeleteSpecialistPoolAsync(string, CallSettings)
            // Additional: DeleteSpecialistPoolAsync(string, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/specialistPools/[SPECIALIST_POOL]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await specialistPoolServiceClient.DeleteSpecialistPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await specialistPoolServiceClient.PollOnceDeleteSpecialistPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecialistPool</summary>
        public void DeleteSpecialistPoolResourceNames()
        {
            // Snippet: DeleteSpecialistPool(SpecialistPoolName, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            SpecialistPoolName name = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = specialistPoolServiceClient.DeleteSpecialistPool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = specialistPoolServiceClient.PollOnceDeleteSpecialistPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSpecialistPoolAsync</summary>
        public async Task DeleteSpecialistPoolResourceNamesAsync()
        {
            // Snippet: DeleteSpecialistPoolAsync(SpecialistPoolName, CallSettings)
            // Additional: DeleteSpecialistPoolAsync(SpecialistPoolName, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpecialistPoolName name = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await specialistPoolServiceClient.DeleteSpecialistPoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await specialistPoolServiceClient.PollOnceDeleteSpecialistPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSpecialistPool</summary>
        public void UpdateSpecialistPoolRequestObject()
        {
            // Snippet: UpdateSpecialistPool(UpdateSpecialistPoolRequest, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            UpdateSpecialistPoolRequest request = new UpdateSpecialistPoolRequest
            {
                SpecialistPool = new SpecialistPool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> response = specialistPoolServiceClient.UpdateSpecialistPool(request);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> retrievedResponse = specialistPoolServiceClient.PollOnceUpdateSpecialistPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSpecialistPoolAsync</summary>
        public async Task UpdateSpecialistPoolRequestObjectAsync()
        {
            // Snippet: UpdateSpecialistPoolAsync(UpdateSpecialistPoolRequest, CallSettings)
            // Additional: UpdateSpecialistPoolAsync(UpdateSpecialistPoolRequest, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSpecialistPoolRequest request = new UpdateSpecialistPoolRequest
            {
                SpecialistPool = new SpecialistPool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> response = await specialistPoolServiceClient.UpdateSpecialistPoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> retrievedResponse = await specialistPoolServiceClient.PollOnceUpdateSpecialistPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSpecialistPool</summary>
        public void UpdateSpecialistPool()
        {
            // Snippet: UpdateSpecialistPool(SpecialistPool, FieldMask, CallSettings)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = SpecialistPoolServiceClient.Create();
            // Initialize request argument(s)
            SpecialistPool specialistPool = new SpecialistPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> response = specialistPoolServiceClient.UpdateSpecialistPool(specialistPool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> retrievedResponse = specialistPoolServiceClient.PollOnceUpdateSpecialistPool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSpecialistPoolAsync</summary>
        public async Task UpdateSpecialistPoolAsync()
        {
            // Snippet: UpdateSpecialistPoolAsync(SpecialistPool, FieldMask, CallSettings)
            // Additional: UpdateSpecialistPoolAsync(SpecialistPool, FieldMask, CancellationToken)
            // Create client
            SpecialistPoolServiceClient specialistPoolServiceClient = await SpecialistPoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpecialistPool specialistPool = new SpecialistPool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> response = await specialistPoolServiceClient.UpdateSpecialistPoolAsync(specialistPool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SpecialistPool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SpecialistPool, UpdateSpecialistPoolOperationMetadata> retrievedResponse = await specialistPoolServiceClient.PollOnceUpdateSpecialistPoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SpecialistPool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
