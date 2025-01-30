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
    using Google.Cloud.Functions.V1;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudFunctionsServiceClientSnippets
    {
        /// <summary>Snippet for ListFunctions</summary>
        public void ListFunctionsRequestObject()
        {
            // Snippet: ListFunctions(ListFunctionsRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            ListFunctionsRequest request = new ListFunctionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListFunctionsResponse, CloudFunction> response = cloudFunctionsServiceClient.ListFunctions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudFunction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFunctionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudFunction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudFunction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudFunction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFunctionsAsync</summary>
        public async Task ListFunctionsRequestObjectAsync()
        {
            // Snippet: ListFunctionsAsync(ListFunctionsRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFunctionsRequest request = new ListFunctionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFunctionsResponse, CloudFunction> response = cloudFunctionsServiceClient.ListFunctionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudFunction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFunctionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudFunction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudFunction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudFunction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetFunction</summary>
        public void GetFunctionRequestObject()
        {
            // Snippet: GetFunction(GetFunctionRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            GetFunctionRequest request = new GetFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                VersionId = 0L,
            };
            // Make the request
            CloudFunction response = cloudFunctionsServiceClient.GetFunction(request);
            // End snippet
        }

        /// <summary>Snippet for GetFunctionAsync</summary>
        public async Task GetFunctionRequestObjectAsync()
        {
            // Snippet: GetFunctionAsync(GetFunctionRequest, CallSettings)
            // Additional: GetFunctionAsync(GetFunctionRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetFunctionRequest request = new GetFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                VersionId = 0L,
            };
            // Make the request
            CloudFunction response = await cloudFunctionsServiceClient.GetFunctionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetFunction</summary>
        public void GetFunction()
        {
            // Snippet: GetFunction(string, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            CloudFunction response = cloudFunctionsServiceClient.GetFunction(name);
            // End snippet
        }

        /// <summary>Snippet for GetFunctionAsync</summary>
        public async Task GetFunctionAsync()
        {
            // Snippet: GetFunctionAsync(string, CallSettings)
            // Additional: GetFunctionAsync(string, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            CloudFunction response = await cloudFunctionsServiceClient.GetFunctionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetFunction</summary>
        public void GetFunctionResourceNames()
        {
            // Snippet: GetFunction(CloudFunctionName, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            CloudFunctionName name = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            // Make the request
            CloudFunction response = cloudFunctionsServiceClient.GetFunction(name);
            // End snippet
        }

        /// <summary>Snippet for GetFunctionAsync</summary>
        public async Task GetFunctionResourceNamesAsync()
        {
            // Snippet: GetFunctionAsync(CloudFunctionName, CallSettings)
            // Additional: GetFunctionAsync(CloudFunctionName, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CloudFunctionName name = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            // Make the request
            CloudFunction response = await cloudFunctionsServiceClient.GetFunctionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateFunction</summary>
        public void CreateFunctionRequestObject()
        {
            // Snippet: CreateFunction(CreateFunctionRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            CreateFunctionRequest request = new CreateFunctionRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Function = new CloudFunction(),
            };
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = cloudFunctionsServiceClient.CreateFunction(request);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = cloudFunctionsServiceClient.PollOnceCreateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunctionAsync</summary>
        public async Task CreateFunctionRequestObjectAsync()
        {
            // Snippet: CreateFunctionAsync(CreateFunctionRequest, CallSettings)
            // Additional: CreateFunctionAsync(CreateFunctionRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFunctionRequest request = new CreateFunctionRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Function = new CloudFunction(),
            };
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = await cloudFunctionsServiceClient.CreateFunctionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = await cloudFunctionsServiceClient.PollOnceCreateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunction</summary>
        public void CreateFunction()
        {
            // Snippet: CreateFunction(string, CloudFunction, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            CloudFunction function = new CloudFunction();
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = cloudFunctionsServiceClient.CreateFunction(location, function);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = cloudFunctionsServiceClient.PollOnceCreateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunctionAsync</summary>
        public async Task CreateFunctionAsync()
        {
            // Snippet: CreateFunctionAsync(string, CloudFunction, CallSettings)
            // Additional: CreateFunctionAsync(string, CloudFunction, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            CloudFunction function = new CloudFunction();
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = await cloudFunctionsServiceClient.CreateFunctionAsync(location, function);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = await cloudFunctionsServiceClient.PollOnceCreateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunction</summary>
        public void CreateFunctionResourceNames()
        {
            // Snippet: CreateFunction(LocationName, CloudFunction, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CloudFunction function = new CloudFunction();
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = cloudFunctionsServiceClient.CreateFunction(location, function);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = cloudFunctionsServiceClient.PollOnceCreateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateFunctionAsync</summary>
        public async Task CreateFunctionResourceNamesAsync()
        {
            // Snippet: CreateFunctionAsync(LocationName, CloudFunction, CallSettings)
            // Additional: CreateFunctionAsync(LocationName, CloudFunction, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CloudFunction function = new CloudFunction();
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = await cloudFunctionsServiceClient.CreateFunctionAsync(location, function);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = await cloudFunctionsServiceClient.PollOnceCreateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFunction</summary>
        public void UpdateFunctionRequestObject()
        {
            // Snippet: UpdateFunction(UpdateFunctionRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            UpdateFunctionRequest request = new UpdateFunctionRequest
            {
                Function = new CloudFunction(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = cloudFunctionsServiceClient.UpdateFunction(request);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = cloudFunctionsServiceClient.PollOnceUpdateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFunctionAsync</summary>
        public async Task UpdateFunctionRequestObjectAsync()
        {
            // Snippet: UpdateFunctionAsync(UpdateFunctionRequest, CallSettings)
            // Additional: UpdateFunctionAsync(UpdateFunctionRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFunctionRequest request = new UpdateFunctionRequest
            {
                Function = new CloudFunction(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = await cloudFunctionsServiceClient.UpdateFunctionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = await cloudFunctionsServiceClient.PollOnceUpdateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFunction</summary>
        public void UpdateFunction()
        {
            // Snippet: UpdateFunction(CloudFunction, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            CloudFunction function = new CloudFunction();
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = cloudFunctionsServiceClient.UpdateFunction(function);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = cloudFunctionsServiceClient.PollOnceUpdateFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateFunctionAsync</summary>
        public async Task UpdateFunctionAsync()
        {
            // Snippet: UpdateFunctionAsync(CloudFunction, CallSettings)
            // Additional: UpdateFunctionAsync(CloudFunction, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CloudFunction function = new CloudFunction();
            // Make the request
            Operation<CloudFunction, OperationMetadataV1> response = await cloudFunctionsServiceClient.UpdateFunctionAsync(function);

            // Poll until the returned long-running operation is complete
            Operation<CloudFunction, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudFunction result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudFunction, OperationMetadataV1> retrievedResponse = await cloudFunctionsServiceClient.PollOnceUpdateFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudFunction retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunction</summary>
        public void DeleteFunctionRequestObject()
        {
            // Snippet: DeleteFunction(DeleteFunctionRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            DeleteFunctionRequest request = new DeleteFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadataV1> response = cloudFunctionsServiceClient.DeleteFunction(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = cloudFunctionsServiceClient.PollOnceDeleteFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunctionAsync</summary>
        public async Task DeleteFunctionRequestObjectAsync()
        {
            // Snippet: DeleteFunctionAsync(DeleteFunctionRequest, CallSettings)
            // Additional: DeleteFunctionAsync(DeleteFunctionRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFunctionRequest request = new DeleteFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadataV1> response = await cloudFunctionsServiceClient.DeleteFunctionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = await cloudFunctionsServiceClient.PollOnceDeleteFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunction</summary>
        public void DeleteFunction()
        {
            // Snippet: DeleteFunction(string, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            Operation<Empty, OperationMetadataV1> response = cloudFunctionsServiceClient.DeleteFunction(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = cloudFunctionsServiceClient.PollOnceDeleteFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunctionAsync</summary>
        public async Task DeleteFunctionAsync()
        {
            // Snippet: DeleteFunctionAsync(string, CallSettings)
            // Additional: DeleteFunctionAsync(string, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            // Make the request
            Operation<Empty, OperationMetadataV1> response = await cloudFunctionsServiceClient.DeleteFunctionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = await cloudFunctionsServiceClient.PollOnceDeleteFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunction</summary>
        public void DeleteFunctionResourceNames()
        {
            // Snippet: DeleteFunction(CloudFunctionName, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            CloudFunctionName name = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            // Make the request
            Operation<Empty, OperationMetadataV1> response = cloudFunctionsServiceClient.DeleteFunction(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = cloudFunctionsServiceClient.PollOnceDeleteFunction(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteFunctionAsync</summary>
        public async Task DeleteFunctionResourceNamesAsync()
        {
            // Snippet: DeleteFunctionAsync(CloudFunctionName, CallSettings)
            // Additional: DeleteFunctionAsync(CloudFunctionName, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CloudFunctionName name = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            // Make the request
            Operation<Empty, OperationMetadataV1> response = await cloudFunctionsServiceClient.DeleteFunctionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadataV1> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadataV1> retrievedResponse = await cloudFunctionsServiceClient.PollOnceDeleteFunctionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CallFunction</summary>
        public void CallFunctionRequestObject()
        {
            // Snippet: CallFunction(CallFunctionRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            CallFunctionRequest request = new CallFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Data = "",
            };
            // Make the request
            CallFunctionResponse response = cloudFunctionsServiceClient.CallFunction(request);
            // End snippet
        }

        /// <summary>Snippet for CallFunctionAsync</summary>
        public async Task CallFunctionRequestObjectAsync()
        {
            // Snippet: CallFunctionAsync(CallFunctionRequest, CallSettings)
            // Additional: CallFunctionAsync(CallFunctionRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CallFunctionRequest request = new CallFunctionRequest
            {
                CloudFunctionName = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]"),
                Data = "",
            };
            // Make the request
            CallFunctionResponse response = await cloudFunctionsServiceClient.CallFunctionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CallFunction</summary>
        public void CallFunction()
        {
            // Snippet: CallFunction(string, string, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            string data = "";
            // Make the request
            CallFunctionResponse response = cloudFunctionsServiceClient.CallFunction(name, data);
            // End snippet
        }

        /// <summary>Snippet for CallFunctionAsync</summary>
        public async Task CallFunctionAsync()
        {
            // Snippet: CallFunctionAsync(string, string, CallSettings)
            // Additional: CallFunctionAsync(string, string, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/functions/[FUNCTION]";
            string data = "";
            // Make the request
            CallFunctionResponse response = await cloudFunctionsServiceClient.CallFunctionAsync(name, data);
            // End snippet
        }

        /// <summary>Snippet for CallFunction</summary>
        public void CallFunctionResourceNames()
        {
            // Snippet: CallFunction(CloudFunctionName, string, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            CloudFunctionName name = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            string data = "";
            // Make the request
            CallFunctionResponse response = cloudFunctionsServiceClient.CallFunction(name, data);
            // End snippet
        }

        /// <summary>Snippet for CallFunctionAsync</summary>
        public async Task CallFunctionResourceNamesAsync()
        {
            // Snippet: CallFunctionAsync(CloudFunctionName, string, CallSettings)
            // Additional: CallFunctionAsync(CloudFunctionName, string, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CloudFunctionName name = CloudFunctionName.FromProjectLocationFunction("[PROJECT]", "[LOCATION]", "[FUNCTION]");
            string data = "";
            // Make the request
            CallFunctionResponse response = await cloudFunctionsServiceClient.CallFunctionAsync(name, data);
            // End snippet
        }

        /// <summary>Snippet for GenerateUploadUrl</summary>
        public void GenerateUploadUrlRequestObject()
        {
            // Snippet: GenerateUploadUrl(GenerateUploadUrlRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            GenerateUploadUrlRequest request = new GenerateUploadUrlRequest
            {
                Parent = "",
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            GenerateUploadUrlResponse response = cloudFunctionsServiceClient.GenerateUploadUrl(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateUploadUrlAsync</summary>
        public async Task GenerateUploadUrlRequestObjectAsync()
        {
            // Snippet: GenerateUploadUrlAsync(GenerateUploadUrlRequest, CallSettings)
            // Additional: GenerateUploadUrlAsync(GenerateUploadUrlRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateUploadUrlRequest request = new GenerateUploadUrlRequest
            {
                Parent = "",
                KmsKeyNameAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            // Make the request
            GenerateUploadUrlResponse response = await cloudFunctionsServiceClient.GenerateUploadUrlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateDownloadUrl</summary>
        public void GenerateDownloadUrlRequestObject()
        {
            // Snippet: GenerateDownloadUrl(GenerateDownloadUrlRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            GenerateDownloadUrlRequest request = new GenerateDownloadUrlRequest
            {
                Name = "",
                VersionId = 0UL,
            };
            // Make the request
            GenerateDownloadUrlResponse response = cloudFunctionsServiceClient.GenerateDownloadUrl(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateDownloadUrlAsync</summary>
        public async Task GenerateDownloadUrlRequestObjectAsync()
        {
            // Snippet: GenerateDownloadUrlAsync(GenerateDownloadUrlRequest, CallSettings)
            // Additional: GenerateDownloadUrlAsync(GenerateDownloadUrlRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateDownloadUrlRequest request = new GenerateDownloadUrlRequest
            {
                Name = "",
                VersionId = 0UL,
            };
            // Make the request
            GenerateDownloadUrlResponse response = await cloudFunctionsServiceClient.GenerateDownloadUrlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = cloudFunctionsServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await cloudFunctionsServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = cloudFunctionsServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await cloudFunctionsServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = CloudFunctionsServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = cloudFunctionsServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            CloudFunctionsServiceClient cloudFunctionsServiceClient = await CloudFunctionsServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await cloudFunctionsServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
