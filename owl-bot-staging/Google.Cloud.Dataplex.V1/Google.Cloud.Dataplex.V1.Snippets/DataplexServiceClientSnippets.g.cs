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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
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
    public sealed class AllGeneratedDataplexServiceClientSnippets
    {
        /// <summary>Snippet for CreateLake</summary>
        public void CreateLakeRequestObject()
        {
            // Snippet: CreateLake(CreateLakeRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateLakeRequest request = new gcdv::CreateLakeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LakeId = "",
                Lake = new gcdv::Lake(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = dataplexServiceClient.CreateLake(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLakeAsync</summary>
        public async Task CreateLakeRequestObjectAsync()
        {
            // Snippet: CreateLakeAsync(CreateLakeRequest, CallSettings)
            // Additional: CreateLakeAsync(CreateLakeRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateLakeRequest request = new gcdv::CreateLakeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                LakeId = "",
                Lake = new gcdv::Lake(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateLakeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLake</summary>
        public void CreateLake()
        {
            // Snippet: CreateLake(string, Lake, string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Lake lake = new gcdv::Lake();
            string lakeId = "";
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = dataplexServiceClient.CreateLake(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLakeAsync</summary>
        public async Task CreateLakeAsync()
        {
            // Snippet: CreateLakeAsync(string, Lake, string, CallSettings)
            // Additional: CreateLakeAsync(string, Lake, string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcdv::Lake lake = new gcdv::Lake();
            string lakeId = "";
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateLakeAsync(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLake</summary>
        public void CreateLakeResourceNames()
        {
            // Snippet: CreateLake(LocationName, Lake, string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Lake lake = new gcdv::Lake();
            string lakeId = "";
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = dataplexServiceClient.CreateLake(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateLakeAsync</summary>
        public async Task CreateLakeResourceNamesAsync()
        {
            // Snippet: CreateLakeAsync(LocationName, Lake, string, CallSettings)
            // Additional: CreateLakeAsync(LocationName, Lake, string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcdv::Lake lake = new gcdv::Lake();
            string lakeId = "";
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateLakeAsync(parent, lake, lakeId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLake</summary>
        public void UpdateLakeRequestObject()
        {
            // Snippet: UpdateLake(UpdateLakeRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateLakeRequest request = new gcdv::UpdateLakeRequest
            {
                UpdateMask = new FieldMask(),
                Lake = new gcdv::Lake(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateLake(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLakeAsync</summary>
        public async Task UpdateLakeRequestObjectAsync()
        {
            // Snippet: UpdateLakeAsync(UpdateLakeRequest, CallSettings)
            // Additional: UpdateLakeAsync(UpdateLakeRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateLakeRequest request = new gcdv::UpdateLakeRequest
            {
                UpdateMask = new FieldMask(),
                Lake = new gcdv::Lake(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateLakeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLake</summary>
        public void UpdateLake()
        {
            // Snippet: UpdateLake(Lake, FieldMask, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Lake lake = new gcdv::Lake();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateLake(lake, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateLake(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateLakeAsync</summary>
        public async Task UpdateLakeAsync()
        {
            // Snippet: UpdateLakeAsync(Lake, FieldMask, CallSettings)
            // Additional: UpdateLakeAsync(Lake, FieldMask, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Lake lake = new gcdv::Lake();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Lake, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateLakeAsync(lake, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Lake, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Lake result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Lake, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateLakeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Lake retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteLake</summary>
        public void DeleteLakeRequestObject()
        {
            // Snippet: DeleteLake(DeleteLakeRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteLakeRequest request = new gcdv::DeleteLakeRequest
            {
                LakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteLake(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteLake(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteLakeRequest request = new gcdv::DeleteLakeRequest
            {
                LakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteLakeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteLakeAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteLake(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteLake(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteLakeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteLakeAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName name = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteLake(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteLake(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName name = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteLakeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteLakeAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListLakesRequest request = new gcdv::ListLakesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListLakesResponse, gcdv::Lake> response = dataplexServiceClient.ListLakes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Lake item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListLakesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Lake> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Lake item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListLakesRequest request = new gcdv::ListLakesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListLakesResponse, gcdv::Lake> response = dataplexServiceClient.ListLakesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Lake item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListLakesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Lake> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Lake item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcdv::ListLakesResponse, gcdv::Lake> response = dataplexServiceClient.ListLakes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Lake item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListLakesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Lake> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Lake item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListLakesResponse, gcdv::Lake> response = dataplexServiceClient.ListLakesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Lake item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListLakesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Lake> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Lake item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcdv::ListLakesResponse, gcdv::Lake> response = dataplexServiceClient.ListLakes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Lake item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListLakesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Lake> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Lake item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListLakesResponse, gcdv::Lake> response = dataplexServiceClient.ListLakesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Lake item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListLakesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Lake item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Lake> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Lake item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetLakeRequest request = new gcdv::GetLakeRequest
            {
                LakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            gcdv::Lake response = dataplexServiceClient.GetLake(request);
            // End snippet
        }

        /// <summary>Snippet for GetLakeAsync</summary>
        public async Task GetLakeRequestObjectAsync()
        {
            // Snippet: GetLakeAsync(GetLakeRequest, CallSettings)
            // Additional: GetLakeAsync(GetLakeRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetLakeRequest request = new gcdv::GetLakeRequest
            {
                LakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            gcdv::Lake response = await dataplexServiceClient.GetLakeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLake</summary>
        public void GetLake()
        {
            // Snippet: GetLake(string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            gcdv::Lake response = dataplexServiceClient.GetLake(name);
            // End snippet
        }

        /// <summary>Snippet for GetLakeAsync</summary>
        public async Task GetLakeAsync()
        {
            // Snippet: GetLakeAsync(string, CallSettings)
            // Additional: GetLakeAsync(string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            gcdv::Lake response = await dataplexServiceClient.GetLakeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetLake</summary>
        public void GetLakeResourceNames()
        {
            // Snippet: GetLake(LakeName, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName name = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            gcdv::Lake response = dataplexServiceClient.GetLake(name);
            // End snippet
        }

        /// <summary>Snippet for GetLakeAsync</summary>
        public async Task GetLakeResourceNamesAsync()
        {
            // Snippet: GetLakeAsync(LakeName, CallSettings)
            // Additional: GetLakeAsync(LakeName, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName name = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            gcdv::Lake response = await dataplexServiceClient.GetLakeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListLakeActions</summary>
        public void ListLakeActionsRequestObject()
        {
            // Snippet: ListLakeActions(ListLakeActionsRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListLakeActionsRequest request = new gcdv::ListLakeActionsRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListLakeActionsRequest request = new gcdv::ListLakeActionsRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListLakeActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateZoneRequest request = new gcdv::CreateZoneRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                ZoneId = "",
                Zone = new gcdv::Zone(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = dataplexServiceClient.CreateZone(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneRequestObjectAsync()
        {
            // Snippet: CreateZoneAsync(CreateZoneRequest, CallSettings)
            // Additional: CreateZoneAsync(CreateZoneRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateZoneRequest request = new gcdv::CreateZoneRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                ZoneId = "",
                Zone = new gcdv::Zone(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZone</summary>
        public void CreateZone()
        {
            // Snippet: CreateZone(string, Zone, string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Zone zone = new gcdv::Zone();
            string zoneId = "";
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = dataplexServiceClient.CreateZone(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneAsync()
        {
            // Snippet: CreateZoneAsync(string, Zone, string, CallSettings)
            // Additional: CreateZoneAsync(string, Zone, string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Zone zone = new gcdv::Zone();
            string zoneId = "";
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateZoneAsync(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZone</summary>
        public void CreateZoneResourceNames()
        {
            // Snippet: CreateZone(LakeName, Zone, string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Zone zone = new gcdv::Zone();
            string zoneId = "";
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = dataplexServiceClient.CreateZone(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateZoneAsync</summary>
        public async Task CreateZoneResourceNamesAsync()
        {
            // Snippet: CreateZoneAsync(LakeName, Zone, string, CallSettings)
            // Additional: CreateZoneAsync(LakeName, Zone, string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Zone zone = new gcdv::Zone();
            string zoneId = "";
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateZoneAsync(parent, zone, zoneId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZone</summary>
        public void UpdateZoneRequestObject()
        {
            // Snippet: UpdateZone(UpdateZoneRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateZoneRequest request = new gcdv::UpdateZoneRequest
            {
                UpdateMask = new FieldMask(),
                Zone = new gcdv::Zone(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateZone(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZoneAsync</summary>
        public async Task UpdateZoneRequestObjectAsync()
        {
            // Snippet: UpdateZoneAsync(UpdateZoneRequest, CallSettings)
            // Additional: UpdateZoneAsync(UpdateZoneRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateZoneRequest request = new gcdv::UpdateZoneRequest
            {
                UpdateMask = new FieldMask(),
                Zone = new gcdv::Zone(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZone</summary>
        public void UpdateZone()
        {
            // Snippet: UpdateZone(Zone, FieldMask, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Zone zone = new gcdv::Zone();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateZone(zone, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateZone(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateZoneAsync</summary>
        public async Task UpdateZoneAsync()
        {
            // Snippet: UpdateZoneAsync(Zone, FieldMask, CallSettings)
            // Additional: UpdateZoneAsync(Zone, FieldMask, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Zone zone = new gcdv::Zone();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Zone, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateZoneAsync(zone, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Zone, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Zone, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateZoneAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Zone retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteZone</summary>
        public void DeleteZoneRequestObject()
        {
            // Snippet: DeleteZone(DeleteZoneRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteZoneRequest request = new gcdv::DeleteZoneRequest
            {
                ZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteZone(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteZone(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteZoneRequest request = new gcdv::DeleteZoneRequest
            {
                ZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteZoneAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteZoneAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteZone(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteZone(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteZoneAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteZoneAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ZoneName name = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteZone(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteZone(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ZoneName name = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteZoneAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteZoneAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListZonesRequest request = new gcdv::ListZonesRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListZonesResponse, gcdv::Zone> response = dataplexServiceClient.ListZones(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Zone item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListZonesRequest request = new gcdv::ListZonesRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListZonesResponse, gcdv::Zone> response = dataplexServiceClient.ListZonesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Zone item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedEnumerable<gcdv::ListZonesResponse, gcdv::Zone> response = dataplexServiceClient.ListZones(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Zone item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListZonesResponse, gcdv::Zone> response = dataplexServiceClient.ListZonesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Zone item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedEnumerable<gcdv::ListZonesResponse, gcdv::Zone> response = dataplexServiceClient.ListZones(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Zone item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListZonesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Zone> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Zone item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListZonesResponse, gcdv::Zone> response = dataplexServiceClient.ListZonesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Zone item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListZonesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Zone item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Zone> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Zone item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetZoneRequest request = new gcdv::GetZoneRequest
            {
                ZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            gcdv::Zone response = dataplexServiceClient.GetZone(request);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneRequestObjectAsync()
        {
            // Snippet: GetZoneAsync(GetZoneRequest, CallSettings)
            // Additional: GetZoneAsync(GetZoneRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetZoneRequest request = new gcdv::GetZoneRequest
            {
                ZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            gcdv::Zone response = await dataplexServiceClient.GetZoneAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZone()
        {
            // Snippet: GetZone(string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            gcdv::Zone response = dataplexServiceClient.GetZone(name);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneAsync()
        {
            // Snippet: GetZoneAsync(string, CallSettings)
            // Additional: GetZoneAsync(string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            gcdv::Zone response = await dataplexServiceClient.GetZoneAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetZone</summary>
        public void GetZoneResourceNames()
        {
            // Snippet: GetZone(ZoneName, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ZoneName name = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            gcdv::Zone response = dataplexServiceClient.GetZone(name);
            // End snippet
        }

        /// <summary>Snippet for GetZoneAsync</summary>
        public async Task GetZoneResourceNamesAsync()
        {
            // Snippet: GetZoneAsync(ZoneName, CallSettings)
            // Additional: GetZoneAsync(ZoneName, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ZoneName name = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            gcdv::Zone response = await dataplexServiceClient.GetZoneAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListZoneActions</summary>
        public void ListZoneActionsRequestObject()
        {
            // Snippet: ListZoneActions(ListZoneActionsRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListZoneActionsRequest request = new gcdv::ListZoneActionsRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListZoneActionsRequest request = new gcdv::ListZoneActionsRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListZoneActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateAssetRequest request = new gcdv::CreateAssetRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                AssetId = "",
                Asset = new gcdv::Asset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = dataplexServiceClient.CreateAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetRequestObjectAsync()
        {
            // Snippet: CreateAssetAsync(CreateAssetRequest, CallSettings)
            // Additional: CreateAssetAsync(CreateAssetRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateAssetRequest request = new gcdv::CreateAssetRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                AssetId = "",
                Asset = new gcdv::Asset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAsset</summary>
        public void CreateAsset()
        {
            // Snippet: CreateAsset(string, Asset, string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            gcdv::Asset asset = new gcdv::Asset();
            string assetId = "";
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = dataplexServiceClient.CreateAsset(parent, asset, assetId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetAsync()
        {
            // Snippet: CreateAssetAsync(string, Asset, string, CallSettings)
            // Additional: CreateAssetAsync(string, Asset, string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            gcdv::Asset asset = new gcdv::Asset();
            string assetId = "";
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateAssetAsync(parent, asset, assetId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAsset</summary>
        public void CreateAssetResourceNames()
        {
            // Snippet: CreateAsset(ZoneName, Asset, string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            gcdv::Asset asset = new gcdv::Asset();
            string assetId = "";
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = dataplexServiceClient.CreateAsset(parent, asset, assetId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAssetAsync</summary>
        public async Task CreateAssetResourceNamesAsync()
        {
            // Snippet: CreateAssetAsync(ZoneName, Asset, string, CallSettings)
            // Additional: CreateAssetAsync(ZoneName, Asset, string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            gcdv::Asset asset = new gcdv::Asset();
            string assetId = "";
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateAssetAsync(parent, asset, assetId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsset</summary>
        public void UpdateAssetRequestObject()
        {
            // Snippet: UpdateAsset(UpdateAssetRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateAssetRequest request = new gcdv::UpdateAssetRequest
            {
                UpdateMask = new FieldMask(),
                Asset = new gcdv::Asset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAssetAsync</summary>
        public async Task UpdateAssetRequestObjectAsync()
        {
            // Snippet: UpdateAssetAsync(UpdateAssetRequest, CallSettings)
            // Additional: UpdateAssetAsync(UpdateAssetRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateAssetRequest request = new gcdv::UpdateAssetRequest
            {
                UpdateMask = new FieldMask(),
                Asset = new gcdv::Asset(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsset</summary>
        public void UpdateAsset()
        {
            // Snippet: UpdateAsset(Asset, FieldMask, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Asset asset = new gcdv::Asset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateAsset(asset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateAsset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAssetAsync</summary>
        public async Task UpdateAssetAsync()
        {
            // Snippet: UpdateAssetAsync(Asset, FieldMask, CallSettings)
            // Additional: UpdateAssetAsync(Asset, FieldMask, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Asset asset = new gcdv::Asset();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Asset, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateAssetAsync(asset, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Asset, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Asset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Asset, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateAssetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Asset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsset</summary>
        public void DeleteAssetRequestObject()
        {
            // Snippet: DeleteAsset(DeleteAssetRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteAssetRequest request = new gcdv::DeleteAssetRequest
            {
                AssetName = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteAsset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteAsset(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteAssetRequest request = new gcdv::DeleteAssetRequest
            {
                AssetName = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteAssetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteAssetAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteAsset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteAsset(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteAssetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteAssetAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::AssetName name = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteAsset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteAsset(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::AssetName name = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteAssetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteAssetAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListAssetsRequest request = new gcdv::ListAssetsRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListAssetsResponse, gcdv::Asset> response = dataplexServiceClient.ListAssets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Asset item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListAssetsRequest request = new gcdv::ListAssetsRequest
            {
                ParentAsZoneName = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListAssetsResponse, gcdv::Asset> response = dataplexServiceClient.ListAssetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Asset item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedEnumerable<gcdv::ListAssetsResponse, gcdv::Asset> response = dataplexServiceClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Asset item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListAssetsResponse, gcdv::Asset> response = dataplexServiceClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Asset item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedEnumerable<gcdv::ListAssetsResponse, gcdv::Asset> response = dataplexServiceClient.ListAssets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Asset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListAssetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Asset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Asset item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ZoneName parent = gcdv::ZoneName.FromProjectLocationLakeZone("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListAssetsResponse, gcdv::Asset> response = dataplexServiceClient.ListAssetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Asset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListAssetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Asset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Asset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Asset item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetAssetRequest request = new gcdv::GetAssetRequest
            {
                AssetName = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            gcdv::Asset response = dataplexServiceClient.GetAsset(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetRequestObjectAsync()
        {
            // Snippet: GetAssetAsync(GetAssetRequest, CallSettings)
            // Additional: GetAssetAsync(GetAssetRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetAssetRequest request = new gcdv::GetAssetRequest
            {
                AssetName = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            gcdv::Asset response = await dataplexServiceClient.GetAssetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAsset()
        {
            // Snippet: GetAsset(string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            gcdv::Asset response = dataplexServiceClient.GetAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetAsync()
        {
            // Snippet: GetAssetAsync(string, CallSettings)
            // Additional: GetAssetAsync(string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            gcdv::Asset response = await dataplexServiceClient.GetAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAsset</summary>
        public void GetAssetResourceNames()
        {
            // Snippet: GetAsset(AssetName, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::AssetName name = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            gcdv::Asset response = dataplexServiceClient.GetAsset(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssetAsync</summary>
        public async Task GetAssetResourceNamesAsync()
        {
            // Snippet: GetAssetAsync(AssetName, CallSettings)
            // Additional: GetAssetAsync(AssetName, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::AssetName name = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            gcdv::Asset response = await dataplexServiceClient.GetAssetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAssetActions</summary>
        public void ListAssetActionsRequestObject()
        {
            // Snippet: ListAssetActions(ListAssetActionsRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListAssetActionsRequest request = new gcdv::ListAssetActionsRequest
            {
                ParentAsAssetName = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListAssetActionsRequest request = new gcdv::ListAssetActionsRequest
            {
                ParentAsAssetName = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/zones/[ZONE]/assets/[ASSET]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::AssetName parent = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            PagedEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Action item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListActionsResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::AssetName parent = gcdv::AssetName.FromProjectLocationLakeZoneAsset("[PROJECT]", "[LOCATION]", "[LAKE]", "[ZONE]", "[ASSET]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListActionsResponse, gcdv::Action> response = dataplexServiceClient.ListAssetActionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Action item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListActionsResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateTaskRequest request = new gcdv::CreateTaskRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                TaskId = "",
                Task = new gcdv::Task(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = dataplexServiceClient.CreateTask(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateTask(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateTaskRequest request = new gcdv::CreateTaskRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                TaskId = "",
                Task = new gcdv::Task(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateTaskAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateTaskAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = dataplexServiceClient.CreateTask(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateTask(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateTaskAsync(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateTaskAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = dataplexServiceClient.CreateTask(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateTask(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Task task = new gcdv::Task();
            string taskId = "";
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateTaskAsync(parent, task, taskId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateTaskAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateTaskRequest request = new gcdv::UpdateTaskRequest
            {
                UpdateMask = new FieldMask(),
                Task = new gcdv::Task(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateTask(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateTask(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateTaskRequest request = new gcdv::UpdateTaskRequest
            {
                UpdateMask = new FieldMask(),
                Task = new gcdv::Task(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateTaskAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateTaskAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Task task = new gcdv::Task();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateTask(task, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateTask(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Task task = new gcdv::Task();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Task, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateTaskAsync(task, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Task, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Task result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Task, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateTaskAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteTaskRequest request = new gcdv::DeleteTaskRequest
            {
                TaskName = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteTask(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteTask(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteTaskRequest request = new gcdv::DeleteTaskRequest
            {
                TaskName = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteTaskAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteTaskAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteTask(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteTask(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteTaskAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteTaskAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::TaskName name = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteTask(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteTask(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TaskName name = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteTaskAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteTaskAsync(operationName);
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListTasksRequest request = new gcdv::ListTasksRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListTasksResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListTasksRequest request = new gcdv::ListTasksRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListTasksResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedEnumerable<gcdv::ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListTasksResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListTasksResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedEnumerable<gcdv::ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Task item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListTasksResponse page in response.AsRawResponses())
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListTasksResponse, gcdv::Task> response = dataplexServiceClient.ListTasksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Task item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListTasksResponse page) =>
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetTaskRequest request = new gcdv::GetTaskRequest
            {
                TaskName = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetTaskRequest request = new gcdv::GetTaskRequest
            {
                TaskName = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::TaskName name = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TaskName name = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            gcdv::Task response = await dataplexServiceClient.GetTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListJobs</summary>
        public void ListJobsRequestObject()
        {
            // Snippet: ListJobs(ListJobsRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListJobsRequest request = new gcdv::ListJobsRequest
            {
                ParentAsTaskName = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            PagedEnumerable<gcdv::ListJobsResponse, gcdv::Job> response = dataplexServiceClient.ListJobs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Job item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListJobsRequest request = new gcdv::ListJobsRequest
            {
                ParentAsTaskName = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListJobsResponse, gcdv::Job> response = dataplexServiceClient.ListJobsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Job item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            PagedEnumerable<gcdv::ListJobsResponse, gcdv::Job> response = dataplexServiceClient.ListJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Job item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListJobsResponse, gcdv::Job> response = dataplexServiceClient.ListJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Job item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::TaskName parent = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            PagedEnumerable<gcdv::ListJobsResponse, gcdv::Job> response = dataplexServiceClient.ListJobs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Job item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListJobsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Job> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Job item in singlePage)
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TaskName parent = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListJobsResponse, gcdv::Job> response = dataplexServiceClient.ListJobsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Job item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListJobsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Job item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Job> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Job item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTaskRequestObject()
        {
            // Snippet: RunTask(RunTaskRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::RunTaskRequest request = new gcdv::RunTaskRequest
            {
                TaskName = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
                Labels = { { "", "" }, },
                Args = { { "", "" }, },
            };
            // Make the request
            gcdv::RunTaskResponse response = dataplexServiceClient.RunTask(request);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskRequestObjectAsync()
        {
            // Snippet: RunTaskAsync(RunTaskRequest, CallSettings)
            // Additional: RunTaskAsync(RunTaskRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::RunTaskRequest request = new gcdv::RunTaskRequest
            {
                TaskName = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]"),
                Labels = { { "", "" }, },
                Args = { { "", "" }, },
            };
            // Make the request
            gcdv::RunTaskResponse response = await dataplexServiceClient.RunTaskAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTask()
        {
            // Snippet: RunTask(string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            gcdv::RunTaskResponse response = dataplexServiceClient.RunTask(name);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskAsync()
        {
            // Snippet: RunTaskAsync(string, CallSettings)
            // Additional: RunTaskAsync(string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]";
            // Make the request
            gcdv::RunTaskResponse response = await dataplexServiceClient.RunTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunTask</summary>
        public void RunTaskResourceNames()
        {
            // Snippet: RunTask(TaskName, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::TaskName name = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            gcdv::RunTaskResponse response = dataplexServiceClient.RunTask(name);
            // End snippet
        }

        /// <summary>Snippet for RunTaskAsync</summary>
        public async Task RunTaskResourceNamesAsync()
        {
            // Snippet: RunTaskAsync(TaskName, CallSettings)
            // Additional: RunTaskAsync(TaskName, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::TaskName name = gcdv::TaskName.FromProjectLocationLakeTask("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]");
            // Make the request
            gcdv::RunTaskResponse response = await dataplexServiceClient.RunTaskAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobRequestObject()
        {
            // Snippet: GetJob(GetJobRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetJobRequest request = new gcdv::GetJobRequest
            {
                JobName = gcdv::JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            // Make the request
            gcdv::Job response = dataplexServiceClient.GetJob(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobRequestObjectAsync()
        {
            // Snippet: GetJobAsync(GetJobRequest, CallSettings)
            // Additional: GetJobAsync(GetJobRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetJobRequest request = new gcdv::GetJobRequest
            {
                JobName = gcdv::JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
            };
            // Make the request
            gcdv::Job response = await dataplexServiceClient.GetJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJob()
        {
            // Snippet: GetJob(string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]/jobs/[JOB]";
            // Make the request
            gcdv::Job response = dataplexServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobAsync()
        {
            // Snippet: GetJobAsync(string, CallSettings)
            // Additional: GetJobAsync(string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/tasks/[TASK]/jobs/[JOB]";
            // Make the request
            gcdv::Job response = await dataplexServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJob</summary>
        public void GetJobResourceNames()
        {
            // Snippet: GetJob(JobName, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::JobName name = gcdv::JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]");
            // Make the request
            gcdv::Job response = dataplexServiceClient.GetJob(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobAsync</summary>
        public async Task GetJobResourceNamesAsync()
        {
            // Snippet: GetJobAsync(JobName, CallSettings)
            // Additional: GetJobAsync(JobName, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::JobName name = gcdv::JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]");
            // Make the request
            gcdv::Job response = await dataplexServiceClient.GetJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelJob</summary>
        public void CancelJobRequestObject()
        {
            // Snippet: CancelJob(CancelJobRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CancelJobRequest request = new gcdv::CancelJobRequest
            {
                JobName = gcdv::JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CancelJobRequest request = new gcdv::CancelJobRequest
            {
                JobName = gcdv::JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]"),
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
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
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::JobName name = gcdv::JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]");
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
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::JobName name = gcdv::JobName.FromProjectLocationLakeTaskJob("[PROJECT]", "[LOCATION]", "[LAKE]", "[TASK]", "[JOB]");
            // Make the request
            await dataplexServiceClient.CancelJobAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironmentRequestObject()
        {
            // Snippet: CreateEnvironment(CreateEnvironmentRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::CreateEnvironmentRequest request = new gcdv::CreateEnvironmentRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                EnvironmentId = "",
                Environment = new gcdv::Environment(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = dataplexServiceClient.CreateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentRequestObjectAsync()
        {
            // Snippet: CreateEnvironmentAsync(CreateEnvironmentRequest, CallSettings)
            // Additional: CreateEnvironmentAsync(CreateEnvironmentRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::CreateEnvironmentRequest request = new gcdv::CreateEnvironmentRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                EnvironmentId = "",
                Environment = new gcdv::Environment(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironment()
        {
            // Snippet: CreateEnvironment(string, Environment, string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Environment environment = new gcdv::Environment();
            string environmentId = "";
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = dataplexServiceClient.CreateEnvironment(parent, environment, environmentId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentAsync()
        {
            // Snippet: CreateEnvironmentAsync(string, Environment, string, CallSettings)
            // Additional: CreateEnvironmentAsync(string, Environment, string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            gcdv::Environment environment = new gcdv::Environment();
            string environmentId = "";
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateEnvironmentAsync(parent, environment, environmentId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironment</summary>
        public void CreateEnvironmentResourceNames()
        {
            // Snippet: CreateEnvironment(LakeName, Environment, string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Environment environment = new gcdv::Environment();
            string environmentId = "";
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = dataplexServiceClient.CreateEnvironment(parent, environment, environmentId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEnvironmentAsync</summary>
        public async Task CreateEnvironmentResourceNamesAsync()
        {
            // Snippet: CreateEnvironmentAsync(LakeName, Environment, string, CallSettings)
            // Additional: CreateEnvironmentAsync(LakeName, Environment, string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            gcdv::Environment environment = new gcdv::Environment();
            string environmentId = "";
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = await dataplexServiceClient.CreateEnvironmentAsync(parent, environment, environmentId);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceCreateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironment</summary>
        public void UpdateEnvironmentRequestObject()
        {
            // Snippet: UpdateEnvironment(UpdateEnvironmentRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::UpdateEnvironmentRequest request = new gcdv::UpdateEnvironmentRequest
            {
                UpdateMask = new FieldMask(),
                Environment = new gcdv::Environment(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironmentAsync</summary>
        public async Task UpdateEnvironmentRequestObjectAsync()
        {
            // Snippet: UpdateEnvironmentAsync(UpdateEnvironmentRequest, CallSettings)
            // Additional: UpdateEnvironmentAsync(UpdateEnvironmentRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::UpdateEnvironmentRequest request = new gcdv::UpdateEnvironmentRequest
            {
                UpdateMask = new FieldMask(),
                Environment = new gcdv::Environment(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironment</summary>
        public void UpdateEnvironment()
        {
            // Snippet: UpdateEnvironment(Environment, FieldMask, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::Environment environment = new gcdv::Environment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = dataplexServiceClient.UpdateEnvironment(environment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceUpdateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEnvironmentAsync</summary>
        public async Task UpdateEnvironmentAsync()
        {
            // Snippet: UpdateEnvironmentAsync(Environment, FieldMask, CallSettings)
            // Additional: UpdateEnvironmentAsync(Environment, FieldMask, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::Environment environment = new gcdv::Environment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcdv::Environment, gcdv::OperationMetadata> response = await dataplexServiceClient.UpdateEnvironmentAsync(environment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcdv::Environment, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcdv::Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcdv::Environment, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceUpdateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcdv::Environment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironmentRequestObject()
        {
            // Snippet: DeleteEnvironment(DeleteEnvironmentRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::DeleteEnvironmentRequest request = new gcdv::DeleteEnvironmentRequest
            {
                EnvironmentName = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentRequestObjectAsync()
        {
            // Snippet: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CallSettings)
            // Additional: DeleteEnvironmentAsync(DeleteEnvironmentRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::DeleteEnvironmentRequest request = new gcdv::DeleteEnvironmentRequest
            {
                EnvironmentName = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironment()
        {
            // Snippet: DeleteEnvironment(string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/environments/[ENVIRONMENT]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteEnvironment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentAsync()
        {
            // Snippet: DeleteEnvironmentAsync(string, CallSettings)
            // Additional: DeleteEnvironmentAsync(string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/environments/[ENVIRONMENT]";
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteEnvironmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironment</summary>
        public void DeleteEnvironmentResourceNames()
        {
            // Snippet: DeleteEnvironment(EnvironmentName, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EnvironmentName name = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = dataplexServiceClient.DeleteEnvironment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = dataplexServiceClient.PollOnceDeleteEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEnvironmentAsync</summary>
        public async Task DeleteEnvironmentResourceNamesAsync()
        {
            // Snippet: DeleteEnvironmentAsync(EnvironmentName, CallSettings)
            // Additional: DeleteEnvironmentAsync(EnvironmentName, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EnvironmentName name = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]");
            // Make the request
            Operation<Empty, gcdv::OperationMetadata> response = await dataplexServiceClient.DeleteEnvironmentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, gcdv::OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, gcdv::OperationMetadata> retrievedResponse = await dataplexServiceClient.PollOnceDeleteEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsRequestObject()
        {
            // Snippet: ListEnvironments(ListEnvironmentsRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListEnvironmentsRequest request = new gcdv::ListEnvironmentsRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = dataplexServiceClient.ListEnvironments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsRequestObjectAsync()
        {
            // Snippet: ListEnvironmentsAsync(ListEnvironmentsRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListEnvironmentsRequest request = new gcdv::ListEnvironmentsRequest
            {
                ParentAsLakeName = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = dataplexServiceClient.ListEnvironmentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironments()
        {
            // Snippet: ListEnvironments(string, string, int?, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = dataplexServiceClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsAsync()
        {
            // Snippet: ListEnvironmentsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = dataplexServiceClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironments</summary>
        public void ListEnvironmentsResourceNames()
        {
            // Snippet: ListEnvironments(LakeName, string, int?, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = dataplexServiceClient.ListEnvironments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Environment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListEnvironmentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEnvironmentsAsync</summary>
        public async Task ListEnvironmentsResourceNamesAsync()
        {
            // Snippet: ListEnvironmentsAsync(LakeName, string, int?, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::LakeName parent = gcdv::LakeName.FromProjectLocationLake("[PROJECT]", "[LOCATION]", "[LAKE]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListEnvironmentsResponse, gcdv::Environment> response = dataplexServiceClient.ListEnvironmentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Environment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListEnvironmentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Environment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Environment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Environment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentRequestObject()
        {
            // Snippet: GetEnvironment(GetEnvironmentRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::GetEnvironmentRequest request = new gcdv::GetEnvironmentRequest
            {
                EnvironmentName = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            // Make the request
            gcdv::Environment response = dataplexServiceClient.GetEnvironment(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentRequestObjectAsync()
        {
            // Snippet: GetEnvironmentAsync(GetEnvironmentRequest, CallSettings)
            // Additional: GetEnvironmentAsync(GetEnvironmentRequest, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::GetEnvironmentRequest request = new gcdv::GetEnvironmentRequest
            {
                EnvironmentName = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
            };
            // Make the request
            gcdv::Environment response = await dataplexServiceClient.GetEnvironmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironment()
        {
            // Snippet: GetEnvironment(string, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/environments/[ENVIRONMENT]";
            // Make the request
            gcdv::Environment response = dataplexServiceClient.GetEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentAsync()
        {
            // Snippet: GetEnvironmentAsync(string, CallSettings)
            // Additional: GetEnvironmentAsync(string, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/environments/[ENVIRONMENT]";
            // Make the request
            gcdv::Environment response = await dataplexServiceClient.GetEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironment</summary>
        public void GetEnvironmentResourceNames()
        {
            // Snippet: GetEnvironment(EnvironmentName, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EnvironmentName name = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]");
            // Make the request
            gcdv::Environment response = dataplexServiceClient.GetEnvironment(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnvironmentAsync</summary>
        public async Task GetEnvironmentResourceNamesAsync()
        {
            // Snippet: GetEnvironmentAsync(EnvironmentName, CallSettings)
            // Additional: GetEnvironmentAsync(EnvironmentName, CancellationToken)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EnvironmentName name = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]");
            // Make the request
            gcdv::Environment response = await dataplexServiceClient.GetEnvironmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessionsRequestObject()
        {
            // Snippet: ListSessions(ListSessionsRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::ListSessionsRequest request = new gcdv::ListSessionsRequest
            {
                ParentAsEnvironmentName = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcdv::ListSessionsResponse, gcdv::Session> response = dataplexServiceClient.ListSessions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionsAsync</summary>
        public async Task ListSessionsRequestObjectAsync()
        {
            // Snippet: ListSessionsAsync(ListSessionsRequest, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::ListSessionsRequest request = new gcdv::ListSessionsRequest
            {
                ParentAsEnvironmentName = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcdv::ListSessionsResponse, gcdv::Session> response = dataplexServiceClient.ListSessionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessions()
        {
            // Snippet: ListSessions(string, string, int?, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/environments/[ENVIRONMENT]";
            // Make the request
            PagedEnumerable<gcdv::ListSessionsResponse, gcdv::Session> response = dataplexServiceClient.ListSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionsAsync</summary>
        public async Task ListSessionsAsync()
        {
            // Snippet: ListSessionsAsync(string, string, int?, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/lakes/[LAKE]/environments/[ENVIRONMENT]";
            // Make the request
            PagedAsyncEnumerable<gcdv::ListSessionsResponse, gcdv::Session> response = dataplexServiceClient.ListSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessionsResourceNames()
        {
            // Snippet: ListSessions(EnvironmentName, string, int?, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = gcdv::DataplexServiceClient.Create();
            // Initialize request argument(s)
            gcdv::EnvironmentName parent = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]");
            // Make the request
            PagedEnumerable<gcdv::ListSessionsResponse, gcdv::Session> response = dataplexServiceClient.ListSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcdv::Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcdv::ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionsAsync</summary>
        public async Task ListSessionsResourceNamesAsync()
        {
            // Snippet: ListSessionsAsync(EnvironmentName, string, int?, CallSettings)
            // Create client
            gcdv::DataplexServiceClient dataplexServiceClient = await gcdv::DataplexServiceClient.CreateAsync();
            // Initialize request argument(s)
            gcdv::EnvironmentName parent = gcdv::EnvironmentName.FromProjectLocationLakeEnvironment("[PROJECT]", "[LOCATION]", "[LAKE]", "[ENVIRONMENT]");
            // Make the request
            PagedAsyncEnumerable<gcdv::ListSessionsResponse, gcdv::Session> response = dataplexServiceClient.ListSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcdv::Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcdv::ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcdv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcdv::Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcdv::Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
