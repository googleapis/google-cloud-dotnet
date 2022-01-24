// Copyright 2022 Google LLC
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

namespace Google.Cloud.Dataplex.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcdv = Google.Cloud.Dataplex.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedDataplexServiceClientSnippets
    {
        /// <summary>Snippet for CreateLake</summary>
        public void CreateLakeRequestObject()
        {
            // Snippet: CreateLake(CreateLakeRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            CreateLakeRequest request = new CreateLakeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LakeId = "",
                Lake = new Lake(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Lake, OperationMetadata> response = dataplexServiceClient.CreateLake(request);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLakeAsync</summary>
        public async Task CreateLakeRequestObjectAsync()
        {
            // Snippet: CreateLakeAsync(CreateLakeRequest, CallSettings)
            // Additional: CreateLakeAsync(CreateLakeRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateLakeRequest request = new CreateLakeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LakeId = "",
                Lake = new Lake(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Lake, OperationMetadata> response = await dataplexServiceClient.CreateLakeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLake</summary>
        public void CreateLake()
        {
            // Snippet: CreateLake(string, Lake, string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Lake lake = new Lake();
            string lakeId = "";
            // Make the request
            Operation<Lake, OperationMetadata> response = dataplexServiceClient.CreateLake(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLakeAsync</summary>
        public async Task CreateLakeAsync()
        {
            // Snippet: CreateLakeAsync(string, Lake, string, CallSettings)
            // Additional: CreateLakeAsync(string, Lake, string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Lake lake = new Lake();
            string lakeId = "";
            // Make the request
            Operation<Lake, OperationMetadata> response = await dataplexServiceClient.CreateLakeAsync(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLake</summary>
        public void CreateLakeResourceNames()
        {
            // Snippet: CreateLake(LocationName, Lake, string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Lake lake = new Lake();
            string lakeId = "";
            // Make the request
            Operation<Lake, OperationMetadata> response = dataplexServiceClient.CreateLake(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLakeAsync</summary>
        public async Task CreateLakeResourceNamesAsync()
        {
            // Snippet: CreateLakeAsync(LocationName, Lake, string, CallSettings)
            // Additional: CreateLakeAsync(LocationName, Lake, string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Lake lake = new Lake();
            string lakeId = "";
            // Make the request
            Operation<Lake, OperationMetadata> response = await dataplexServiceClient.CreateLakeAsync(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLake</summary>
        public void UpdateLakeRequestObject()
        {
            // Snippet: UpdateLake(UpdateLakeRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            UpdateLakeRequest request = new UpdateLakeRequest
            {
                UpdateMask = new FieldMask(),
                Lake = new Lake(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Lake, OperationMetadata> response = dataplexServiceClient.UpdateLake(request);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLakeAsync</summary>
        public async Task UpdateLakeRequestObjectAsync()
        {
            // Snippet: UpdateLakeAsync(UpdateLakeRequest, CallSettings)
            // Additional: UpdateLakeAsync(UpdateLakeRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateLakeRequest request = new UpdateLakeRequest
            {
                UpdateMask = new FieldMask(),
                Lake = new Lake(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Lake, OperationMetadata> response = await dataplexServiceClient.UpdateLakeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLake</summary>
        public void UpdateLake()
        {
            // Snippet: UpdateLake(Lake, FieldMask, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            Lake lake = new Lake();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Lake, OperationMetadata> response = dataplexServiceClient.UpdateLake(lake, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLakeAsync</summary>
        public async Task UpdateLakeAsync()
        {
            // Snippet: UpdateLakeAsync(Lake, FieldMask, CallSettings)
            // Additional: UpdateLakeAsync(Lake, FieldMask, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            Lake lake = new Lake();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Lake, OperationMetadata> response = await dataplexServiceClient.UpdateLakeAsync(lake, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Lake, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Lake, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLake</summary>
        public void DeleteLakeRequestObject()
        {
            // Snippet: DeleteLake(DeleteLakeRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            DeleteLakeRequest request = new DeleteLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteLake(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLakeAsync</summary>
        public async Task DeleteLakeRequestObjectAsync()
        {
            // Snippet: DeleteLakeAsync(DeleteLakeRequest, CallSettings)
            // Additional: DeleteLakeAsync(DeleteLakeRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteLakeRequest request = new DeleteLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteLakeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLake</summary>
        public void DeleteLake()
        {
            // Snippet: DeleteLake(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteLake(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLakeAsync</summary>
        public async Task DeleteLakeAsync()
        {
            // Snippet: DeleteLakeAsync(string, CallSettings)
            // Additional: DeleteLakeAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteLakeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLake</summary>
        public void DeleteLakeResourceNames()
        {
            // Snippet: DeleteLake(LakeName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LakeName name = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteLake(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLakeAsync</summary>
        public async Task DeleteLakeResourceNamesAsync()
        {
            // Snippet: DeleteLakeAsync(LakeName, CallSettings)
            // Additional: DeleteLakeAsync(LakeName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LakeName name = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteLakeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListLakes</summary>
        public void ListLakesRequestObject()
        {
            // Snippet: ListLakes(ListLakesRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ListLakesRequest request = new ListLakesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListLakesResponse, Lake> response = dataplexServiceClient.ListLakes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lake item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLakesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lake> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lake item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakesAsync</summary>
        public async Task ListLakesRequestObjectAsync()
        {
            // Snippet: ListLakesAsync(ListLakesRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLakesRequest request = new ListLakesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListLakesResponse, Lake> response = dataplexServiceClient.ListLakesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lake item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLakesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lake> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lake item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakes</summary>
        public void ListLakes()
        {
            // Snippet: ListLakes(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListLakesResponse, Lake> response = dataplexServiceClient.ListLakes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lake item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLakesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lake> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lake item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakesAsync</summary>
        public async Task ListLakesAsync()
        {
            // Snippet: ListLakesAsync(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListLakesResponse, Lake> response = dataplexServiceClient.ListLakesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lake item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLakesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lake> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lake item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakes</summary>
        public void ListLakesResourceNames()
        {
            // Snippet: ListLakes(LocationName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListLakesResponse, Lake> response = dataplexServiceClient.ListLakes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Lake item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListLakesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lake> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lake item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakesAsync</summary>
        public async Task ListLakesResourceNamesAsync()
        {
            // Snippet: ListLakesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListLakesResponse, Lake> response = dataplexServiceClient.ListLakesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Lake item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListLakesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Lake> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Lake item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetLake</summary>
        public void GetLakeRequestObject()
        {
            // Snippet: GetLake(GetLakeRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            GetLakeRequest request = new GetLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            Lake response = dataplexServiceClient.GetLake(request);
            // End snippet
        }

        /// <summary>Snippet for GetLakeAsync</summary>
        public async Task GetLakeRequestObjectAsync()
        {
            // Snippet: GetLakeAsync(GetLakeRequest, CallSettings)
            // Additional: GetLakeAsync(GetLakeRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetLakeRequest request = new GetLakeRequest
            {
                LakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            Lake response = await dataplexServiceClient.GetLakeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLake</summary>
        public void GetLake()
        {
            // Snippet: GetLake(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            Lake response = dataplexServiceClient.GetLake(name);
            // End snippet
        }

        /// <summary>Snippet for GetLakeAsync</summary>
        public async Task GetLakeAsync()
        {
            // Snippet: GetLakeAsync(string, CallSettings)
            // Additional: GetLakeAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            Lake response = await dataplexServiceClient.GetLakeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLake</summary>
        public void GetLakeResourceNames()
        {
            // Snippet: GetLake(LakeName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LakeName name = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            Lake response = dataplexServiceClient.GetLake(name);
            // End snippet
        }

        /// <summary>Snippet for GetLakeAsync</summary>
        public async Task GetLakeResourceNamesAsync()
        {
            // Snippet: GetLakeAsync(LakeName, CallSettings)
            // Additional: GetLakeAsync(LakeName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LakeName name = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            Lake response = await dataplexServiceClient.GetLakeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLakeActions</summary>
        public void ListLakeActionsRequestObject()
        {
            // Snippet: ListLakeActions(ListLakeActionsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ListLakeActionsRequest request = new ListLakeActionsRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakeActionsAsync</summary>
        public async Task ListLakeActionsRequestObjectAsync()
        {
            // Snippet: ListLakeActionsAsync(ListLakeActionsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListLakeActionsRequest request = new ListLakeActionsRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakeActions</summary>
        public void ListLakeActions()
        {
            // Snippet: ListLakeActions(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakeActionsAsync</summary>
        public async Task ListLakeActionsAsync()
        {
            // Snippet: ListLakeActionsAsync(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakeActions</summary>
        public void ListLakeActionsResourceNames()
        {
            // Snippet: ListLakeActions(LakeName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListLakeActionsAsync</summary>
        public async Task ListLakeActionsResourceNamesAsync()
        {
            // Snippet: ListLakeActionsAsync(LakeName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateZone</summary>
        public void CreateZoneRequestObject()
        {
            // Snippet: CreateZone(CreateZoneRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            CreateZoneRequest request = new CreateZoneRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                ZoneId = "",
                Zone = new Zone(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = dataplexServiceClient.CreateZone(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneRequestObjectAsync()
        {
            // Snippet: CreateZoneAsync(CreateZoneRequest, CallSettings)
            // Additional: CreateZoneAsync(CreateZoneRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateZoneRequest request = new CreateZoneRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                ZoneId = "",
                Zone = new Zone(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = await dataplexServiceClient.CreateZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZone</summary>
        public void CreateZone()
        {
            // Snippet: CreateZone(string, Zone, string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            Zone zone = new Zone();
            string zoneId = "";
            // Make the request
            Operation<Zone, OperationMetadata> response = dataplexServiceClient.CreateZone(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneAsync()
        {
            // Snippet: CreateZoneAsync(string, Zone, string, CallSettings)
            // Additional: CreateZoneAsync(string, Zone, string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            Zone zone = new Zone();
            string zoneId = "";
            // Make the request
            Operation<Zone, OperationMetadata> response = await dataplexServiceClient.CreateZoneAsync(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZone</summary>
        public void CreateZoneResourceNames()
        {
            // Snippet: CreateZone(LakeName, Zone, string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            Zone zone = new Zone();
            string zoneId = "";
            // Make the request
            Operation<Zone, OperationMetadata> response = dataplexServiceClient.CreateZone(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneResourceNamesAsync()
        {
            // Snippet: CreateZoneAsync(LakeName, Zone, string, CallSettings)
            // Additional: CreateZoneAsync(LakeName, Zone, string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            Zone zone = new Zone();
            string zoneId = "";
            // Make the request
            Operation<Zone, OperationMetadata> response = await dataplexServiceClient.CreateZoneAsync(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZone</summary>
        public void UpdateZoneRequestObject()
        {
            // Snippet: UpdateZone(UpdateZoneRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            UpdateZoneRequest request = new UpdateZoneRequest
            {
                UpdateMask = new FieldMask(),
                Zone = new Zone(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = dataplexServiceClient.UpdateZone(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZoneAsync</summary>
        public async Task UpdateZoneRequestObjectAsync()
        {
            // Snippet: UpdateZoneAsync(UpdateZoneRequest, CallSettings)
            // Additional: UpdateZoneAsync(UpdateZoneRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateZoneRequest request = new UpdateZoneRequest
            {
                UpdateMask = new FieldMask(),
                Zone = new Zone(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Zone, OperationMetadata> response = await dataplexServiceClient.UpdateZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZone</summary>
        public void UpdateZone()
        {
            // Snippet: UpdateZone(Zone, FieldMask, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            Zone zone = new Zone();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Zone, OperationMetadata> response = dataplexServiceClient.UpdateZone(zone, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZoneAsync</summary>
        public async Task UpdateZoneAsync()
        {
            // Snippet: UpdateZoneAsync(Zone, FieldMask, CallSettings)
            // Additional: UpdateZoneAsync(Zone, FieldMask, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            Zone zone = new Zone();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Zone, OperationMetadata> response = await dataplexServiceClient.UpdateZoneAsync(zone, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZone</summary>
        public void DeleteZoneRequestObject()
        {
            // Snippet: DeleteZone(DeleteZoneRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            DeleteZoneRequest request = new DeleteZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteZone(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZoneAsync</summary>
        public async Task DeleteZoneRequestObjectAsync()
        {
            // Snippet: DeleteZoneAsync(DeleteZoneRequest, CallSettings)
            // Additional: DeleteZoneAsync(DeleteZoneRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteZoneRequest request = new DeleteZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZone</summary>
        public void DeleteZone()
        {
            // Snippet: DeleteZone(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteZone(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZoneAsync</summary>
        public async Task DeleteZoneAsync()
        {
            // Snippet: DeleteZoneAsync(string, CallSettings)
            // Additional: DeleteZoneAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteZoneAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZone</summary>
        public void DeleteZoneResourceNames()
        {
            // Snippet: DeleteZone(ZoneName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteZone(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZoneAsync</summary>
        public async Task DeleteZoneResourceNamesAsync()
        {
            // Snippet: DeleteZoneAsync(ZoneName, CallSettings)
            // Additional: DeleteZoneAsync(ZoneName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteZoneAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZonesRequestObject()
        {
            // Snippet: ListZones(ListZonesRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ListZonesRequest request = new ListZonesRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListZonesResponse, Zone> response = dataplexServiceClient.ListZones(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesRequestObjectAsync()
        {
            // Snippet: ListZonesAsync(ListZonesRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListZonesRequest request = new ListZonesRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = dataplexServiceClient.ListZonesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZones()
        {
            // Snippet: ListZones(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedEnumerable<ListZonesResponse, Zone> response = dataplexServiceClient.ListZones(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesAsync()
        {
            // Snippet: ListZonesAsync(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = dataplexServiceClient.ListZonesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZones</summary>
        public void ListZonesResourceNames()
        {
            // Snippet: ListZones(LakeName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedEnumerable<ListZonesResponse, Zone> response = dataplexServiceClient.ListZones(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZonesAsync</summary>
        public async Task ListZonesResourceNamesAsync()
        {
            // Snippet: ListZonesAsync(LakeName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedAsyncEnumerable<ListZonesResponse, Zone> response = dataplexServiceClient.ListZonesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Zone item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZoneRequestObject()
        {
            // Snippet: GetZone(GetZoneRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            Zone response = dataplexServiceClient.GetZone(request);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneRequestObjectAsync()
        {
            // Snippet: GetZoneAsync(GetZoneRequest, CallSettings)
            // Additional: GetZoneAsync(GetZoneRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetZoneRequest request = new GetZoneRequest
            {
                ZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            Zone response = await dataplexServiceClient.GetZoneAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZone()
        {
            // Snippet: GetZone(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            Zone response = dataplexServiceClient.GetZone(name);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneAsync()
        {
            // Snippet: GetZoneAsync(string, CallSettings)
            // Additional: GetZoneAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            Zone response = await dataplexServiceClient.GetZoneAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZoneResourceNames()
        {
            // Snippet: GetZone(ZoneName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            Zone response = dataplexServiceClient.GetZone(name);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneResourceNamesAsync()
        {
            // Snippet: GetZoneAsync(ZoneName, CallSettings)
            // Additional: GetZoneAsync(ZoneName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            Zone response = await dataplexServiceClient.GetZoneAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListZoneActions</summary>
        public void ListZoneActionsRequestObject()
        {
            // Snippet: ListZoneActions(ListZoneActionsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ListZoneActionsRequest request = new ListZoneActionsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZoneActionsAsync</summary>
        public async Task ListZoneActionsRequestObjectAsync()
        {
            // Snippet: ListZoneActionsAsync(ListZoneActionsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListZoneActionsRequest request = new ListZoneActionsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZoneActions</summary>
        public void ListZoneActions()
        {
            // Snippet: ListZoneActions(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZoneActionsAsync</summary>
        public async Task ListZoneActionsAsync()
        {
            // Snippet: ListZoneActionsAsync(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZoneActions</summary>
        public void ListZoneActionsResourceNames()
        {
            // Snippet: ListZoneActions(ZoneName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListZoneActionsAsync</summary>
        public async Task ListZoneActionsResourceNamesAsync()
        {
            // Snippet: ListZoneActionsAsync(ZoneName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAsset</summary>
        public void CreateAssetRequestObject()
        {
            // Snippet: CreateAsset(CreateAssetRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            CreateAssetRequest request = new CreateAssetRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                AssetId = "",
                Asset = new Asset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Asset, OperationMetadata> response = dataplexServiceClient.CreateAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetRequestObjectAsync()
        {
            // Snippet: CreateAssetAsync(CreateAssetRequest, CallSettings)
            // Additional: CreateAssetAsync(CreateAssetRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAssetRequest request = new CreateAssetRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                AssetId = "",
                Asset = new Asset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Asset, OperationMetadata> response = await dataplexServiceClient.CreateAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAsset</summary>
        public void CreateAsset()
        {
            // Snippet: CreateAsset(string, Asset, string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            Asset asset = new Asset();
            string assetId = "";
            // Make the request
            Operation<Asset, OperationMetadata> response = dataplexServiceClient.CreateAsset(parent, asset, assetId);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetAsync()
        {
            // Snippet: CreateAssetAsync(string, Asset, string, CallSettings)
            // Additional: CreateAssetAsync(string, Asset, string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            Asset asset = new Asset();
            string assetId = "";
            // Make the request
            Operation<Asset, OperationMetadata> response = await dataplexServiceClient.CreateAssetAsync(parent, asset, assetId);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAsset</summary>
        public void CreateAssetResourceNames()
        {
            // Snippet: CreateAsset(ZoneName, Asset, string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            Asset asset = new Asset();
            string assetId = "";
            // Make the request
            Operation<Asset, OperationMetadata> response = dataplexServiceClient.CreateAsset(parent, asset, assetId);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetResourceNamesAsync()
        {
            // Snippet: CreateAssetAsync(ZoneName, Asset, string, CallSettings)
            // Additional: CreateAssetAsync(ZoneName, Asset, string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            Asset asset = new Asset();
            string assetId = "";
            // Make the request
            Operation<Asset, OperationMetadata> response = await dataplexServiceClient.CreateAssetAsync(parent, asset, assetId);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsset</summary>
        public void UpdateAssetRequestObject()
        {
            // Snippet: UpdateAsset(UpdateAssetRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            UpdateAssetRequest request = new UpdateAssetRequest
            {
                UpdateMask = new FieldMask(),
                Asset = new Asset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Asset, OperationMetadata> response = dataplexServiceClient.UpdateAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAssetAsync</summary>
        public async Task UpdateAssetRequestObjectAsync()
        {
            // Snippet: UpdateAssetAsync(UpdateAssetRequest, CallSettings)
            // Additional: UpdateAssetAsync(UpdateAssetRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAssetRequest request = new UpdateAssetRequest
            {
                UpdateMask = new FieldMask(),
                Asset = new Asset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Asset, OperationMetadata> response = await dataplexServiceClient.UpdateAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsset</summary>
        public void UpdateAsset()
        {
            // Snippet: UpdateAsset(Asset, FieldMask, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            Asset asset = new Asset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Asset, OperationMetadata> response = dataplexServiceClient.UpdateAsset(asset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAssetAsync</summary>
        public async Task UpdateAssetAsync()
        {
            // Snippet: UpdateAssetAsync(Asset, FieldMask, CallSettings)
            // Additional: UpdateAssetAsync(Asset, FieldMask, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            Asset asset = new Asset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Asset, OperationMetadata> response = await dataplexServiceClient.UpdateAssetAsync(asset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Asset, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Asset, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAssetRequestObject()
        {
            // Snippet: DeleteAsset(DeleteAssetRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            DeleteAssetRequest request = new DeleteAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetRequestObjectAsync()
        {
            // Snippet: DeleteAssetAsync(DeleteAssetRequest, CallSettings)
            // Additional: DeleteAssetAsync(DeleteAssetRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAssetRequest request = new DeleteAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAsset()
        {
            // Snippet: DeleteAsset(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteAsset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetAsync()
        {
            // Snippet: DeleteAssetAsync(string, CallSettings)
            // Additional: DeleteAssetAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteAssetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAssetResourceNames()
        {
            // Snippet: DeleteAsset(AssetName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            AssetName name = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteAsset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAssetAsync</summary>
        public async Task DeleteAssetResourceNamesAsync()
        {
            // Snippet: DeleteAssetAsync(AssetName, CallSettings)
            // Additional: DeleteAssetAsync(AssetName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssetName name = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteAssetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssetsRequestObject()
        {
            // Snippet: ListAssets(ListAssetsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = dataplexServiceClient.ListAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsRequestObjectAsync()
        {
            // Snippet: ListAssetsAsync(ListAssetsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAssetsRequest request = new ListAssetsRequest
            {
                ParentAsZoneName = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = dataplexServiceClient.ListAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssets()
        {
            // Snippet: ListAssets(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = dataplexServiceClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsAsync()
        {
            // Snippet: ListAssetsAsync(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = dataplexServiceClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssets</summary>
        public void ListAssetsResourceNames()
        {
            // Snippet: ListAssets(ZoneName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedEnumerable<ListAssetsResponse, Asset> response = dataplexServiceClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetsAsync</summary>
        public async Task ListAssetsResourceNamesAsync()
        {
            // Snippet: ListAssetsAsync(ZoneName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName parent = ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<ListAssetsResponse, Asset> response = dataplexServiceClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Asset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetRequestObject()
        {
            // Snippet: GetAsset(GetAssetRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            Asset response = dataplexServiceClient.GetAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetRequestObjectAsync()
        {
            // Snippet: GetAssetAsync(GetAssetRequest, CallSettings)
            // Additional: GetAssetAsync(GetAssetRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAssetRequest request = new GetAssetRequest
            {
                AssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            Asset response = await dataplexServiceClient.GetAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAsset()
        {
            // Snippet: GetAsset(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            Asset response = dataplexServiceClient.GetAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetAsync()
        {
            // Snippet: GetAssetAsync(string, CallSettings)
            // Additional: GetAssetAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            Asset response = await dataplexServiceClient.GetAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetResourceNames()
        {
            // Snippet: GetAsset(AssetName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            AssetName name = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            Asset response = dataplexServiceClient.GetAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetResourceNamesAsync()
        {
            // Snippet: GetAssetAsync(AssetName, CallSettings)
            // Additional: GetAssetAsync(AssetName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssetName name = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            Asset response = await dataplexServiceClient.GetAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAssetActions</summary>
        public void ListAssetActionsRequestObject()
        {
            // Snippet: ListAssetActions(ListAssetActionsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ListAssetActionsRequest request = new ListAssetActionsRequest
            {
                ParentAsAssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetActionsAsync</summary>
        public async Task ListAssetActionsRequestObjectAsync()
        {
            // Snippet: ListAssetActionsAsync(ListAssetActionsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAssetActionsRequest request = new ListAssetActionsRequest
            {
                ParentAsAssetName = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetActions</summary>
        public void ListAssetActions()
        {
            // Snippet: ListAssetActions(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetActionsAsync</summary>
        public async Task ListAssetActionsAsync()
        {
            // Snippet: ListAssetActionsAsync(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetActions</summary>
        public void ListAssetActionsResourceNames()
        {
            // Snippet: ListAssetActions(AssetName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            AssetName parent = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            PagedEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListActionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssetActionsAsync</summary>
        public async Task ListAssetActionsResourceNamesAsync()
        {
            // Snippet: ListAssetActionsAsync(AssetName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssetName parent = AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            PagedAsyncEnumerable<ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListActionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Action item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Action> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Action item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTaskRequestObject()
        {
            // Snippet: CreateTask(CreateTaskRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                TaskId = "",
                Task = new gcdv::Task(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = dataplexServiceClient.CreateTask(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateTask(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskRequestObjectAsync()
        {
            // Snippet: CreateTaskAsync(CreateTaskRequest, CallSettings)
            // Additional: CreateTaskAsync(CreateTaskRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateTaskRequest request = new CreateTaskRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                TaskId = "",
                Task = new gcdv::Task(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = await dataplexServiceClient.CreateTaskAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTask()
        {
            // Snippet: CreateTask(string, Task, string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = dataplexServiceClient.CreateTask(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateTask(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskAsync()
        {
            // Snippet: CreateTaskAsync(string, Task, string, CallSettings)
            // Additional: CreateTaskAsync(string, Task, string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = await dataplexServiceClient.CreateTaskAsync(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTask</summary>
        public void CreateTaskResourceNames()
        {
            // Snippet: CreateTask(LakeName, Task, string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = dataplexServiceClient.CreateTask(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateTask(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTaskAsync</summary>
        public async Task CreateTaskResourceNamesAsync()
        {
            // Snippet: CreateTaskAsync(LakeName, Task, string, CallSettings)
            // Additional: CreateTaskAsync(LakeName, Task, string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = await dataplexServiceClient.CreateTaskAsync(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTask</summary>
        public void UpdateTaskRequestObject()
        {
            // Snippet: UpdateTask(UpdateTaskRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            UpdateTaskRequest request = new UpdateTaskRequest
            {
                UpdateMask = new FieldMask(),
                Task = new gcdv::Task(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = dataplexServiceClient.UpdateTask(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateTask(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTaskAsync</summary>
        public async Task UpdateTaskRequestObjectAsync()
        {
            // Snippet: UpdateTaskAsync(UpdateTaskRequest, CallSettings)
            // Additional: UpdateTaskAsync(UpdateTaskRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTaskRequest request = new UpdateTaskRequest
            {
                UpdateMask = new FieldMask(),
                Task = new gcdv::Task(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = await dataplexServiceClient.UpdateTaskAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTask</summary>
        public void UpdateTask()
        {
            // Snippet: UpdateTask(Task, FieldMask, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Task task = new gcdv::Task();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = dataplexServiceClient.UpdateTask(task, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateTask(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTaskAsync</summary>
        public async Task UpdateTaskAsync()
        {
            // Snippet: UpdateTaskAsync(Task, FieldMask, CallSettings)
            // Additional: UpdateTaskAsync(Task, FieldMask, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Task task = new gcdv::Task();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Task, OperationMetadata> response = await dataplexServiceClient.UpdateTaskAsync(task, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Task retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTaskRequestObject()
        {
            // Snippet: DeleteTask(DeleteTaskRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteTask(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteTask(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskRequestObjectAsync()
        {
            // Snippet: DeleteTaskAsync(DeleteTaskRequest, CallSettings)
            // Additional: DeleteTaskAsync(DeleteTaskRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTaskRequest request = new DeleteTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteTaskAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTask()
        {
            // Snippet: DeleteTask(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteTask(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteTask(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskAsync()
        {
            // Snippet: DeleteTaskAsync(string, CallSettings)
            // Additional: DeleteTaskAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteTaskAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTask</summary>
        public void DeleteTaskResourceNames()
        {
            // Snippet: DeleteTask(TaskName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataplexServiceClient.DeleteTask(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteTask(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTaskAsync</summary>
        public async Task DeleteTaskResourceNamesAsync()
        {
            // Snippet: DeleteTaskAsync(TaskName, CallSettings)
            // Additional: DeleteTaskAsync(TaskName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataplexServiceClient.DeleteTaskAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteTaskAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksRequestObject()
        {
            // Snippet: ListTasks(ListTasksRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksRequestObjectAsync()
        {
            // Snippet: ListTasksAsync(ListTasksRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTasksRequest request = new ListTasksRequest
            {
                ParentAsLakeName = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasks()
        {
            // Snippet: ListTasks(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedEnumerable<ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksAsync()
        {
            // Snippet: ListTasksAsync(string, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasks</summary>
        public void ListTasksResourceNames()
        {
            // Snippet: ListTasks(LakeName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedEnumerable<ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTasksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Task> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTasksAsync</summary>
        public async Task ListTasksResourceNamesAsync()
        {
            // Snippet: ListTasksAsync(LakeName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LakeName parent = LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedAsyncEnumerable<ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTasksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Task item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Task> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Task item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskRequestObject()
        {
            // Snippet: GetTask(GetTaskRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            gcdv::Task response = dataplexServiceClient.GetTask(request);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskRequestObjectAsync()
        {
            // Snippet: GetTaskAsync(GetTaskRequest, CallSettings)
            // Additional: GetTaskAsync(GetTaskRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTaskRequest request = new GetTaskRequest
            {
                TaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            gcdv::Task response = await dataplexServiceClient.GetTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTask()
        {
            // Snippet: GetTask(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            gcdv::Task response = dataplexServiceClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskAsync()
        {
            // Snippet: GetTaskAsync(string, CallSettings)
            // Additional: GetTaskAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            gcdv::Task response = await dataplexServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTask</summary>
        public void GetTaskResourceNames()
        {
            // Snippet: GetTask(TaskName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            gcdv::Task response = dataplexServiceClient.GetTask(name);
            // End snippet
        }

        /// <summary>Snippet for GetTaskAsync</summary>
        public async Task GetTaskResourceNamesAsync()
        {
            // Snippet: GetTaskAsync(TaskName, CallSettings)
            // Additional: GetTaskAsync(TaskName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            TaskName name = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            gcdv::Task response = await dataplexServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsTaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = dataplexServiceClient.ListJobs(request);

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
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListJobsRequest request = new ListJobsRequest
            {
                ParentAsTaskName = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = dataplexServiceClient.ListJobsAsync(request);

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
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = dataplexServiceClient.ListJobs(parent);

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
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = dataplexServiceClient.ListJobsAsync(parent);

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
            // Snippet: ListJobs(TaskName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            TaskName parent = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            PagedEnumerable<ListJobsResponse, Job> response = dataplexServiceClient.ListJobs(parent);

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
            // Snippet: ListJobsAsync(TaskName, string, int?, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            TaskName parent = TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            PagedAsyncEnumerable<ListJobsResponse, Job> response = dataplexServiceClient.ListJobsAsync(parent);

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
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            // Make the request
            Job response = dataplexServiceClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRequest request = new GetJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            // Make the request
            Job response = await dataplexServiceClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]/jobs/[JOB]";
            // Make the request
            Job response = dataplexServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]/jobs/[JOB]";
            // Make the request
            Job response = await dataplexServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]");
            // Make the request
            Job response = dataplexServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobResourceNamesAsync()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]");
            // Make the request
            Job response = await dataplexServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJobRequestObject()
        {
            // Snippet: CancelJob(CancelJobRequest, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            // Make the request
            dataplexServiceClient.CancelJob(request);
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobRequestObjectAsync()
        {
            // Snippet: CancelJobAsync(CancelJobRequest, CallSettings)
            // Additional: CancelJobAsync(CancelJobRequest, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelJobRequest request = new CancelJobRequest
            {
                JobName = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            // Make the request
            await dataplexServiceClient.CancelJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJob()
        {
            // Snippet: CancelJob(string, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]/jobs/[JOB]";
            // Make the request
            dataplexServiceClient.CancelJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobAsync()
        {
            // Snippet: CancelJobAsync(string, CallSettings)
            // Additional: CancelJobAsync(string, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]/jobs/[JOB]";
            // Make the request
            await dataplexServiceClient.CancelJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJobResourceNames()
        {
            // Snippet: CancelJob(JobName, CallSettings)
            // Create client
            DataplexServiceClient dataplexServiceClient = DataplexServiceClient.Create();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]");
            // Make the request
            dataplexServiceClient.CancelJob(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJobAsync</summary>
        public async Task CancelJobResourceNamesAsync()
        {
            // Snippet: CancelJobAsync(JobName, CallSettings)
            // Additional: CancelJobAsync(JobName, CancellationToken)
            // Create client
            DataplexServiceClient dataplexServiceClient = await DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            JobName name = JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]");
            // Make the request
            await dataplexServiceClient.CancelJobAsync(name);
            // End snippet
        }
    }
}
