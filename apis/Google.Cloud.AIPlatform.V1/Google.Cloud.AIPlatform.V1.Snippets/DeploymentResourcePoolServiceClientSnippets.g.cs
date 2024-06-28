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
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDeploymentResourcePoolServiceClientSnippets
    {
        /// <summary>Snippet for CreateDeploymentResourcePool</summary>
        public void CreateDeploymentResourcePoolRequestObject()
        {
            // Snippet: CreateDeploymentResourcePool(CreateDeploymentResourcePoolRequest, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            CreateDeploymentResourcePoolRequest request = new CreateDeploymentResourcePoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentResourcePool = new DeploymentResourcePool(),
                DeploymentResourcePoolId = "",
            };
            // Make the request
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> response = deploymentResourcePoolServiceClient.CreateDeploymentResourcePool(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> retrievedResponse = deploymentResourcePoolServiceClient.PollOnceCreateDeploymentResourcePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentResourcePoolAsync</summary>
        public async Task CreateDeploymentResourcePoolRequestObjectAsync()
        {
            // Snippet: CreateDeploymentResourcePoolAsync(CreateDeploymentResourcePoolRequest, CallSettings)
            // Additional: CreateDeploymentResourcePoolAsync(CreateDeploymentResourcePoolRequest, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeploymentResourcePoolRequest request = new CreateDeploymentResourcePoolRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentResourcePool = new DeploymentResourcePool(),
                DeploymentResourcePoolId = "",
            };
            // Make the request
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> response = await deploymentResourcePoolServiceClient.CreateDeploymentResourcePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> retrievedResponse = await deploymentResourcePoolServiceClient.PollOnceCreateDeploymentResourcePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentResourcePool</summary>
        public void CreateDeploymentResourcePool()
        {
            // Snippet: CreateDeploymentResourcePool(string, DeploymentResourcePool, string, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeploymentResourcePool deploymentResourcePool = new DeploymentResourcePool();
            string deploymentResourcePoolId = "";
            // Make the request
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> response = deploymentResourcePoolServiceClient.CreateDeploymentResourcePool(parent, deploymentResourcePool, deploymentResourcePoolId);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> retrievedResponse = deploymentResourcePoolServiceClient.PollOnceCreateDeploymentResourcePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentResourcePoolAsync</summary>
        public async Task CreateDeploymentResourcePoolAsync()
        {
            // Snippet: CreateDeploymentResourcePoolAsync(string, DeploymentResourcePool, string, CallSettings)
            // Additional: CreateDeploymentResourcePoolAsync(string, DeploymentResourcePool, string, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeploymentResourcePool deploymentResourcePool = new DeploymentResourcePool();
            string deploymentResourcePoolId = "";
            // Make the request
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> response = await deploymentResourcePoolServiceClient.CreateDeploymentResourcePoolAsync(parent, deploymentResourcePool, deploymentResourcePoolId);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> retrievedResponse = await deploymentResourcePoolServiceClient.PollOnceCreateDeploymentResourcePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentResourcePool</summary>
        public void CreateDeploymentResourcePoolResourceNames()
        {
            // Snippet: CreateDeploymentResourcePool(LocationName, DeploymentResourcePool, string, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeploymentResourcePool deploymentResourcePool = new DeploymentResourcePool();
            string deploymentResourcePoolId = "";
            // Make the request
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> response = deploymentResourcePoolServiceClient.CreateDeploymentResourcePool(parent, deploymentResourcePool, deploymentResourcePoolId);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> retrievedResponse = deploymentResourcePoolServiceClient.PollOnceCreateDeploymentResourcePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentResourcePoolAsync</summary>
        public async Task CreateDeploymentResourcePoolResourceNamesAsync()
        {
            // Snippet: CreateDeploymentResourcePoolAsync(LocationName, DeploymentResourcePool, string, CallSettings)
            // Additional: CreateDeploymentResourcePoolAsync(LocationName, DeploymentResourcePool, string, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeploymentResourcePool deploymentResourcePool = new DeploymentResourcePool();
            string deploymentResourcePoolId = "";
            // Make the request
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> response = await deploymentResourcePoolServiceClient.CreateDeploymentResourcePoolAsync(parent, deploymentResourcePool, deploymentResourcePoolId);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, CreateDeploymentResourcePoolOperationMetadata> retrievedResponse = await deploymentResourcePoolServiceClient.PollOnceCreateDeploymentResourcePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentResourcePool</summary>
        public void GetDeploymentResourcePoolRequestObject()
        {
            // Snippet: GetDeploymentResourcePool(GetDeploymentResourcePoolRequest, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            GetDeploymentResourcePoolRequest request = new GetDeploymentResourcePoolRequest
            {
                DeploymentResourcePoolName = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]"),
            };
            // Make the request
            DeploymentResourcePool response = deploymentResourcePoolServiceClient.GetDeploymentResourcePool(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentResourcePoolAsync</summary>
        public async Task GetDeploymentResourcePoolRequestObjectAsync()
        {
            // Snippet: GetDeploymentResourcePoolAsync(GetDeploymentResourcePoolRequest, CallSettings)
            // Additional: GetDeploymentResourcePoolAsync(GetDeploymentResourcePoolRequest, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDeploymentResourcePoolRequest request = new GetDeploymentResourcePoolRequest
            {
                DeploymentResourcePoolName = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]"),
            };
            // Make the request
            DeploymentResourcePool response = await deploymentResourcePoolServiceClient.GetDeploymentResourcePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentResourcePool</summary>
        public void GetDeploymentResourcePool()
        {
            // Snippet: GetDeploymentResourcePool(string, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentResourcePools/[DEPLOYMENT_RESOURCE_POOL]";
            // Make the request
            DeploymentResourcePool response = deploymentResourcePoolServiceClient.GetDeploymentResourcePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentResourcePoolAsync</summary>
        public async Task GetDeploymentResourcePoolAsync()
        {
            // Snippet: GetDeploymentResourcePoolAsync(string, CallSettings)
            // Additional: GetDeploymentResourcePoolAsync(string, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentResourcePools/[DEPLOYMENT_RESOURCE_POOL]";
            // Make the request
            DeploymentResourcePool response = await deploymentResourcePoolServiceClient.GetDeploymentResourcePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentResourcePool</summary>
        public void GetDeploymentResourcePoolResourceNames()
        {
            // Snippet: GetDeploymentResourcePool(DeploymentResourcePoolName, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            DeploymentResourcePoolName name = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]");
            // Make the request
            DeploymentResourcePool response = deploymentResourcePoolServiceClient.GetDeploymentResourcePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentResourcePoolAsync</summary>
        public async Task GetDeploymentResourcePoolResourceNamesAsync()
        {
            // Snippet: GetDeploymentResourcePoolAsync(DeploymentResourcePoolName, CallSettings)
            // Additional: GetDeploymentResourcePoolAsync(DeploymentResourcePoolName, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentResourcePoolName name = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]");
            // Make the request
            DeploymentResourcePool response = await deploymentResourcePoolServiceClient.GetDeploymentResourcePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentResourcePools</summary>
        public void ListDeploymentResourcePoolsRequestObject()
        {
            // Snippet: ListDeploymentResourcePools(ListDeploymentResourcePoolsRequest, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            ListDeploymentResourcePoolsRequest request = new ListDeploymentResourcePoolsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> response = deploymentResourcePoolServiceClient.ListDeploymentResourcePools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentResourcePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentResourcePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentResourcePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentResourcePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentResourcePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentResourcePoolsAsync</summary>
        public async Task ListDeploymentResourcePoolsRequestObjectAsync()
        {
            // Snippet: ListDeploymentResourcePoolsAsync(ListDeploymentResourcePoolsRequest, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentResourcePoolsRequest request = new ListDeploymentResourcePoolsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> response = deploymentResourcePoolServiceClient.ListDeploymentResourcePoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeploymentResourcePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentResourcePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentResourcePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentResourcePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentResourcePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentResourcePools</summary>
        public void ListDeploymentResourcePools()
        {
            // Snippet: ListDeploymentResourcePools(string, string, int?, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> response = deploymentResourcePoolServiceClient.ListDeploymentResourcePools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentResourcePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentResourcePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentResourcePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentResourcePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentResourcePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentResourcePoolsAsync</summary>
        public async Task ListDeploymentResourcePoolsAsync()
        {
            // Snippet: ListDeploymentResourcePoolsAsync(string, string, int?, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> response = deploymentResourcePoolServiceClient.ListDeploymentResourcePoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeploymentResourcePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentResourcePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentResourcePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentResourcePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentResourcePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentResourcePools</summary>
        public void ListDeploymentResourcePoolsResourceNames()
        {
            // Snippet: ListDeploymentResourcePools(ProjectName, string, int?, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> response = deploymentResourcePoolServiceClient.ListDeploymentResourcePools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeploymentResourcePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentResourcePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentResourcePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentResourcePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentResourcePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentResourcePoolsAsync</summary>
        public async Task ListDeploymentResourcePoolsResourceNamesAsync()
        {
            // Snippet: ListDeploymentResourcePoolsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentResourcePoolsResponse, DeploymentResourcePool> response = deploymentResourcePoolServiceClient.ListDeploymentResourcePoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeploymentResourcePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentResourcePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeploymentResourcePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeploymentResourcePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeploymentResourcePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentResourcePool</summary>
        public void UpdateDeploymentResourcePoolRequestObject()
        {
            // Snippet: UpdateDeploymentResourcePool(UpdateDeploymentResourcePoolRequest, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            UpdateDeploymentResourcePoolRequest request = new UpdateDeploymentResourcePoolRequest
            {
                DeploymentResourcePool = new DeploymentResourcePool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> response = deploymentResourcePoolServiceClient.UpdateDeploymentResourcePool(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> retrievedResponse = deploymentResourcePoolServiceClient.PollOnceUpdateDeploymentResourcePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentResourcePoolAsync</summary>
        public async Task UpdateDeploymentResourcePoolRequestObjectAsync()
        {
            // Snippet: UpdateDeploymentResourcePoolAsync(UpdateDeploymentResourcePoolRequest, CallSettings)
            // Additional: UpdateDeploymentResourcePoolAsync(UpdateDeploymentResourcePoolRequest, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeploymentResourcePoolRequest request = new UpdateDeploymentResourcePoolRequest
            {
                DeploymentResourcePool = new DeploymentResourcePool(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> response = await deploymentResourcePoolServiceClient.UpdateDeploymentResourcePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> retrievedResponse = await deploymentResourcePoolServiceClient.PollOnceUpdateDeploymentResourcePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentResourcePool</summary>
        public void UpdateDeploymentResourcePool()
        {
            // Snippet: UpdateDeploymentResourcePool(DeploymentResourcePool, FieldMask, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            DeploymentResourcePool deploymentResourcePool = new DeploymentResourcePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> response = deploymentResourcePoolServiceClient.UpdateDeploymentResourcePool(deploymentResourcePool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> retrievedResponse = deploymentResourcePoolServiceClient.PollOnceUpdateDeploymentResourcePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentResourcePoolAsync</summary>
        public async Task UpdateDeploymentResourcePoolAsync()
        {
            // Snippet: UpdateDeploymentResourcePoolAsync(DeploymentResourcePool, FieldMask, CallSettings)
            // Additional: UpdateDeploymentResourcePoolAsync(DeploymentResourcePool, FieldMask, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentResourcePool deploymentResourcePool = new DeploymentResourcePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> response = await deploymentResourcePoolServiceClient.UpdateDeploymentResourcePoolAsync(deploymentResourcePool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeploymentResourcePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeploymentResourcePool, UpdateDeploymentResourcePoolOperationMetadata> retrievedResponse = await deploymentResourcePoolServiceClient.PollOnceUpdateDeploymentResourcePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeploymentResourcePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentResourcePool</summary>
        public void DeleteDeploymentResourcePoolRequestObject()
        {
            // Snippet: DeleteDeploymentResourcePool(DeleteDeploymentResourcePoolRequest, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            DeleteDeploymentResourcePoolRequest request = new DeleteDeploymentResourcePoolRequest
            {
                DeploymentResourcePoolName = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = deploymentResourcePoolServiceClient.DeleteDeploymentResourcePool(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = deploymentResourcePoolServiceClient.PollOnceDeleteDeploymentResourcePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentResourcePoolAsync</summary>
        public async Task DeleteDeploymentResourcePoolRequestObjectAsync()
        {
            // Snippet: DeleteDeploymentResourcePoolAsync(DeleteDeploymentResourcePoolRequest, CallSettings)
            // Additional: DeleteDeploymentResourcePoolAsync(DeleteDeploymentResourcePoolRequest, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeploymentResourcePoolRequest request = new DeleteDeploymentResourcePoolRequest
            {
                DeploymentResourcePoolName = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await deploymentResourcePoolServiceClient.DeleteDeploymentResourcePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await deploymentResourcePoolServiceClient.PollOnceDeleteDeploymentResourcePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentResourcePool</summary>
        public void DeleteDeploymentResourcePool()
        {
            // Snippet: DeleteDeploymentResourcePool(string, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentResourcePools/[DEPLOYMENT_RESOURCE_POOL]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = deploymentResourcePoolServiceClient.DeleteDeploymentResourcePool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = deploymentResourcePoolServiceClient.PollOnceDeleteDeploymentResourcePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentResourcePoolAsync</summary>
        public async Task DeleteDeploymentResourcePoolAsync()
        {
            // Snippet: DeleteDeploymentResourcePoolAsync(string, CallSettings)
            // Additional: DeleteDeploymentResourcePoolAsync(string, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deploymentResourcePools/[DEPLOYMENT_RESOURCE_POOL]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await deploymentResourcePoolServiceClient.DeleteDeploymentResourcePoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await deploymentResourcePoolServiceClient.PollOnceDeleteDeploymentResourcePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentResourcePool</summary>
        public void DeleteDeploymentResourcePoolResourceNames()
        {
            // Snippet: DeleteDeploymentResourcePool(DeploymentResourcePoolName, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            DeploymentResourcePoolName name = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = deploymentResourcePoolServiceClient.DeleteDeploymentResourcePool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = deploymentResourcePoolServiceClient.PollOnceDeleteDeploymentResourcePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeploymentResourcePoolAsync</summary>
        public async Task DeleteDeploymentResourcePoolResourceNamesAsync()
        {
            // Snippet: DeleteDeploymentResourcePoolAsync(DeploymentResourcePoolName, CallSettings)
            // Additional: DeleteDeploymentResourcePoolAsync(DeploymentResourcePoolName, CancellationToken)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentResourcePoolName name = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await deploymentResourcePoolServiceClient.DeleteDeploymentResourcePoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await deploymentResourcePoolServiceClient.PollOnceDeleteDeploymentResourcePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for QueryDeployedModels</summary>
        public void QueryDeployedModelsRequestObject()
        {
            // Snippet: QueryDeployedModels(QueryDeployedModelsRequest, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            QueryDeployedModelsRequest request = new QueryDeployedModelsRequest
            {
                DeploymentResourcePool = "",
            };
            // Make the request
            PagedEnumerable<QueryDeployedModelsResponse, DeployedModelRef> response = deploymentResourcePoolServiceClient.QueryDeployedModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeployedModelRef item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryDeployedModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployedModelRef item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployedModelRef> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployedModelRef item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDeployedModelsAsync</summary>
        public async Task QueryDeployedModelsRequestObjectAsync()
        {
            // Snippet: QueryDeployedModelsAsync(QueryDeployedModelsRequest, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            QueryDeployedModelsRequest request = new QueryDeployedModelsRequest
            {
                DeploymentResourcePool = "",
            };
            // Make the request
            PagedAsyncEnumerable<QueryDeployedModelsResponse, DeployedModelRef> response = deploymentResourcePoolServiceClient.QueryDeployedModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeployedModelRef item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryDeployedModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployedModelRef item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployedModelRef> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployedModelRef item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDeployedModels</summary>
        public void QueryDeployedModels()
        {
            // Snippet: QueryDeployedModels(string, string, int?, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = DeploymentResourcePoolServiceClient.Create();
            // Initialize request argument(s)
            string deploymentResourcePool = "";
            // Make the request
            PagedEnumerable<QueryDeployedModelsResponse, DeployedModelRef> response = deploymentResourcePoolServiceClient.QueryDeployedModels(deploymentResourcePool);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeployedModelRef item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryDeployedModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployedModelRef item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployedModelRef> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployedModelRef item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryDeployedModelsAsync</summary>
        public async Task QueryDeployedModelsAsync()
        {
            // Snippet: QueryDeployedModelsAsync(string, string, int?, CallSettings)
            // Create client
            DeploymentResourcePoolServiceClient deploymentResourcePoolServiceClient = await DeploymentResourcePoolServiceClient.CreateAsync();
            // Initialize request argument(s)
            string deploymentResourcePool = "";
            // Make the request
            PagedAsyncEnumerable<QueryDeployedModelsResponse, DeployedModelRef> response = deploymentResourcePoolServiceClient.QueryDeployedModelsAsync(deploymentResourcePool);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeployedModelRef item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryDeployedModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployedModelRef item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployedModelRef> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployedModelRef item in singlePage)
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
