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
    using Google.Cloud.Deploy.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudDeployClientSnippets
    {
        /// <summary>Snippet for ListDeliveryPipelines</summary>
        public void ListDeliveryPipelinesRequestObject()
        {
            // Snippet: ListDeliveryPipelines(ListDeliveryPipelinesRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListDeliveryPipelinesRequest request = new ListDeliveryPipelinesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> response = cloudDeployClient.ListDeliveryPipelines(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeliveryPipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeliveryPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeliveryPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeliveryPipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeliveryPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryPipelinesAsync</summary>
        public async Task ListDeliveryPipelinesRequestObjectAsync()
        {
            // Snippet: ListDeliveryPipelinesAsync(ListDeliveryPipelinesRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListDeliveryPipelinesRequest request = new ListDeliveryPipelinesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> response = cloudDeployClient.ListDeliveryPipelinesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeliveryPipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeliveryPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeliveryPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeliveryPipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeliveryPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryPipelines</summary>
        public void ListDeliveryPipelines()
        {
            // Snippet: ListDeliveryPipelines(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> response = cloudDeployClient.ListDeliveryPipelines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeliveryPipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeliveryPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeliveryPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeliveryPipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeliveryPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryPipelinesAsync</summary>
        public async Task ListDeliveryPipelinesAsync()
        {
            // Snippet: ListDeliveryPipelinesAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> response = cloudDeployClient.ListDeliveryPipelinesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeliveryPipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeliveryPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeliveryPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeliveryPipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeliveryPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryPipelines</summary>
        public void ListDeliveryPipelinesResourceNames()
        {
            // Snippet: ListDeliveryPipelines(LocationName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> response = cloudDeployClient.ListDeliveryPipelines(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeliveryPipeline item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeliveryPipelinesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeliveryPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeliveryPipeline> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeliveryPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeliveryPipelinesAsync</summary>
        public async Task ListDeliveryPipelinesResourceNamesAsync()
        {
            // Snippet: ListDeliveryPipelinesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> response = cloudDeployClient.ListDeliveryPipelinesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeliveryPipeline item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeliveryPipelinesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeliveryPipeline item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeliveryPipeline> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeliveryPipeline item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryPipeline</summary>
        public void GetDeliveryPipelineRequestObject()
        {
            // Snippet: GetDeliveryPipeline(GetDeliveryPipelineRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetDeliveryPipelineRequest request = new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
            };
            // Make the request
            DeliveryPipeline response = cloudDeployClient.GetDeliveryPipeline(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryPipelineAsync</summary>
        public async Task GetDeliveryPipelineRequestObjectAsync()
        {
            // Snippet: GetDeliveryPipelineAsync(GetDeliveryPipelineRequest, CallSettings)
            // Additional: GetDeliveryPipelineAsync(GetDeliveryPipelineRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetDeliveryPipelineRequest request = new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
            };
            // Make the request
            DeliveryPipeline response = await cloudDeployClient.GetDeliveryPipelineAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryPipeline</summary>
        public void GetDeliveryPipeline()
        {
            // Snippet: GetDeliveryPipeline(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            DeliveryPipeline response = cloudDeployClient.GetDeliveryPipeline(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryPipelineAsync</summary>
        public async Task GetDeliveryPipelineAsync()
        {
            // Snippet: GetDeliveryPipelineAsync(string, CallSettings)
            // Additional: GetDeliveryPipelineAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            DeliveryPipeline response = await cloudDeployClient.GetDeliveryPipelineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryPipeline</summary>
        public void GetDeliveryPipelineResourceNames()
        {
            // Snippet: GetDeliveryPipeline(DeliveryPipelineName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipelineName name = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            DeliveryPipeline response = cloudDeployClient.GetDeliveryPipeline(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeliveryPipelineAsync</summary>
        public async Task GetDeliveryPipelineResourceNamesAsync()
        {
            // Snippet: GetDeliveryPipelineAsync(DeliveryPipelineName, CallSettings)
            // Additional: GetDeliveryPipelineAsync(DeliveryPipelineName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipelineName name = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            DeliveryPipeline response = await cloudDeployClient.GetDeliveryPipelineAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryPipeline</summary>
        public void CreateDeliveryPipelineRequestObject()
        {
            // Snippet: CreateDeliveryPipeline(CreateDeliveryPipelineRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CreateDeliveryPipelineRequest request = new CreateDeliveryPipelineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeliveryPipelineId = "",
                DeliveryPipeline = new DeliveryPipeline(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = cloudDeployClient.CreateDeliveryPipeline(request);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateDeliveryPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryPipelineAsync</summary>
        public async Task CreateDeliveryPipelineRequestObjectAsync()
        {
            // Snippet: CreateDeliveryPipelineAsync(CreateDeliveryPipelineRequest, CallSettings)
            // Additional: CreateDeliveryPipelineAsync(CreateDeliveryPipelineRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeliveryPipelineRequest request = new CreateDeliveryPipelineRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeliveryPipelineId = "",
                DeliveryPipeline = new DeliveryPipeline(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = await cloudDeployClient.CreateDeliveryPipelineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateDeliveryPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryPipeline</summary>
        public void CreateDeliveryPipeline()
        {
            // Snippet: CreateDeliveryPipeline(string, DeliveryPipeline, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeliveryPipeline deliveryPipeline = new DeliveryPipeline();
            string deliveryPipelineId = "";
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = cloudDeployClient.CreateDeliveryPipeline(parent, deliveryPipeline, deliveryPipelineId);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateDeliveryPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryPipelineAsync</summary>
        public async Task CreateDeliveryPipelineAsync()
        {
            // Snippet: CreateDeliveryPipelineAsync(string, DeliveryPipeline, string, CallSettings)
            // Additional: CreateDeliveryPipelineAsync(string, DeliveryPipeline, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeliveryPipeline deliveryPipeline = new DeliveryPipeline();
            string deliveryPipelineId = "";
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = await cloudDeployClient.CreateDeliveryPipelineAsync(parent, deliveryPipeline, deliveryPipelineId);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateDeliveryPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryPipeline</summary>
        public void CreateDeliveryPipelineResourceNames()
        {
            // Snippet: CreateDeliveryPipeline(LocationName, DeliveryPipeline, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeliveryPipeline deliveryPipeline = new DeliveryPipeline();
            string deliveryPipelineId = "";
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = cloudDeployClient.CreateDeliveryPipeline(parent, deliveryPipeline, deliveryPipelineId);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateDeliveryPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeliveryPipelineAsync</summary>
        public async Task CreateDeliveryPipelineResourceNamesAsync()
        {
            // Snippet: CreateDeliveryPipelineAsync(LocationName, DeliveryPipeline, string, CallSettings)
            // Additional: CreateDeliveryPipelineAsync(LocationName, DeliveryPipeline, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeliveryPipeline deliveryPipeline = new DeliveryPipeline();
            string deliveryPipelineId = "";
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = await cloudDeployClient.CreateDeliveryPipelineAsync(parent, deliveryPipeline, deliveryPipelineId);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateDeliveryPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeliveryPipeline</summary>
        public void UpdateDeliveryPipelineRequestObject()
        {
            // Snippet: UpdateDeliveryPipeline(UpdateDeliveryPipelineRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            UpdateDeliveryPipelineRequest request = new UpdateDeliveryPipelineRequest
            {
                UpdateMask = new FieldMask(),
                DeliveryPipeline = new DeliveryPipeline(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = cloudDeployClient.UpdateDeliveryPipeline(request);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateDeliveryPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeliveryPipelineAsync</summary>
        public async Task UpdateDeliveryPipelineRequestObjectAsync()
        {
            // Snippet: UpdateDeliveryPipelineAsync(UpdateDeliveryPipelineRequest, CallSettings)
            // Additional: UpdateDeliveryPipelineAsync(UpdateDeliveryPipelineRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeliveryPipelineRequest request = new UpdateDeliveryPipelineRequest
            {
                UpdateMask = new FieldMask(),
                DeliveryPipeline = new DeliveryPipeline(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = await cloudDeployClient.UpdateDeliveryPipelineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateDeliveryPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeliveryPipeline</summary>
        public void UpdateDeliveryPipeline()
        {
            // Snippet: UpdateDeliveryPipeline(DeliveryPipeline, FieldMask, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipeline deliveryPipeline = new DeliveryPipeline();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = cloudDeployClient.UpdateDeliveryPipeline(deliveryPipeline, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateDeliveryPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeliveryPipelineAsync</summary>
        public async Task UpdateDeliveryPipelineAsync()
        {
            // Snippet: UpdateDeliveryPipelineAsync(DeliveryPipeline, FieldMask, CallSettings)
            // Additional: UpdateDeliveryPipelineAsync(DeliveryPipeline, FieldMask, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipeline deliveryPipeline = new DeliveryPipeline();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DeliveryPipeline, OperationMetadata> response = await cloudDeployClient.UpdateDeliveryPipelineAsync(deliveryPipeline, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DeliveryPipeline, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeliveryPipeline result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeliveryPipeline, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateDeliveryPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeliveryPipeline retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeliveryPipeline</summary>
        public void DeleteDeliveryPipelineRequestObject()
        {
            // Snippet: DeleteDeliveryPipeline(DeleteDeliveryPipelineRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeleteDeliveryPipelineRequest request = new DeleteDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteDeliveryPipeline(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteDeliveryPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeliveryPipelineAsync</summary>
        public async Task DeleteDeliveryPipelineRequestObjectAsync()
        {
            // Snippet: DeleteDeliveryPipelineAsync(DeleteDeliveryPipelineRequest, CallSettings)
            // Additional: DeleteDeliveryPipelineAsync(DeleteDeliveryPipelineRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeliveryPipelineRequest request = new DeleteDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteDeliveryPipelineAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteDeliveryPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeliveryPipeline</summary>
        public void DeleteDeliveryPipeline()
        {
            // Snippet: DeleteDeliveryPipeline(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteDeliveryPipeline(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteDeliveryPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeliveryPipelineAsync</summary>
        public async Task DeleteDeliveryPipelineAsync()
        {
            // Snippet: DeleteDeliveryPipelineAsync(string, CallSettings)
            // Additional: DeleteDeliveryPipelineAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteDeliveryPipelineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteDeliveryPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeliveryPipeline</summary>
        public void DeleteDeliveryPipelineResourceNames()
        {
            // Snippet: DeleteDeliveryPipeline(DeliveryPipelineName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipelineName name = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteDeliveryPipeline(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteDeliveryPipeline(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeliveryPipelineAsync</summary>
        public async Task DeleteDeliveryPipelineResourceNamesAsync()
        {
            // Snippet: DeleteDeliveryPipelineAsync(DeliveryPipelineName, CallSettings)
            // Additional: DeleteDeliveryPipelineAsync(DeliveryPipelineName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipelineName name = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteDeliveryPipelineAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteDeliveryPipelineAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTargets</summary>
        public void ListTargetsRequestObject()
        {
            // Snippet: ListTargets(ListTargetsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListTargetsRequest request = new ListTargetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTargetsResponse, Target> response = cloudDeployClient.ListTargets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Target item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Target item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Target> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Target item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetsAsync</summary>
        public async Task ListTargetsRequestObjectAsync()
        {
            // Snippet: ListTargetsAsync(ListTargetsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListTargetsRequest request = new ListTargetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTargetsResponse, Target> response = cloudDeployClient.ListTargetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Target item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Target item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Target> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Target item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargets</summary>
        public void ListTargets()
        {
            // Snippet: ListTargets(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListTargetsResponse, Target> response = cloudDeployClient.ListTargets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Target item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Target item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Target> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Target item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetsAsync</summary>
        public async Task ListTargetsAsync()
        {
            // Snippet: ListTargetsAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListTargetsResponse, Target> response = cloudDeployClient.ListTargetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Target item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Target item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Target> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Target item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargets</summary>
        public void ListTargetsResourceNames()
        {
            // Snippet: ListTargets(LocationName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListTargetsResponse, Target> response = cloudDeployClient.ListTargets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Target item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTargetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Target item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Target> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Target item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTargetsAsync</summary>
        public async Task ListTargetsResourceNamesAsync()
        {
            // Snippet: ListTargetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListTargetsResponse, Target> response = cloudDeployClient.ListTargetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Target item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTargetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Target item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Target> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Target item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RollbackTarget</summary>
        public void RollbackTargetRequestObject()
        {
            // Snippet: RollbackTarget(RollbackTargetRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RollbackTargetRequest request = new RollbackTargetRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                TargetId = "",
                RolloutId = "",
                ReleaseId = "",
                RolloutToRollBack = "",
                RollbackConfig = new RollbackTargetConfig(),
                ValidateOnly = false,
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            RollbackTargetResponse response = cloudDeployClient.RollbackTarget(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackTargetAsync</summary>
        public async Task RollbackTargetRequestObjectAsync()
        {
            // Snippet: RollbackTargetAsync(RollbackTargetRequest, CallSettings)
            // Additional: RollbackTargetAsync(RollbackTargetRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RollbackTargetRequest request = new RollbackTargetRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                TargetId = "",
                RolloutId = "",
                ReleaseId = "",
                RolloutToRollBack = "",
                RollbackConfig = new RollbackTargetConfig(),
                ValidateOnly = false,
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            RollbackTargetResponse response = await cloudDeployClient.RollbackTargetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackTarget</summary>
        public void RollbackTarget()
        {
            // Snippet: RollbackTarget(string, string, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            string targetId = "";
            string rolloutId = "";
            // Make the request
            RollbackTargetResponse response = cloudDeployClient.RollbackTarget(name, targetId, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for RollbackTargetAsync</summary>
        public async Task RollbackTargetAsync()
        {
            // Snippet: RollbackTargetAsync(string, string, string, CallSettings)
            // Additional: RollbackTargetAsync(string, string, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            string targetId = "";
            string rolloutId = "";
            // Make the request
            RollbackTargetResponse response = await cloudDeployClient.RollbackTargetAsync(name, targetId, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for RollbackTarget</summary>
        public void RollbackTargetResourceNames()
        {
            // Snippet: RollbackTarget(DeliveryPipelineName, string, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipelineName name = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            string targetId = "";
            string rolloutId = "";
            // Make the request
            RollbackTargetResponse response = cloudDeployClient.RollbackTarget(name, targetId, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for RollbackTargetAsync</summary>
        public async Task RollbackTargetResourceNamesAsync()
        {
            // Snippet: RollbackTargetAsync(DeliveryPipelineName, string, string, CallSettings)
            // Additional: RollbackTargetAsync(DeliveryPipelineName, string, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipelineName name = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            string targetId = "";
            string rolloutId = "";
            // Make the request
            RollbackTargetResponse response = await cloudDeployClient.RollbackTargetAsync(name, targetId, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for GetTarget</summary>
        public void GetTargetRequestObject()
        {
            // Snippet: GetTarget(GetTargetRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetTargetRequest request = new GetTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
            };
            // Make the request
            Target response = cloudDeployClient.GetTarget(request);
            // End snippet
        }

        /// <summary>Snippet for GetTargetAsync</summary>
        public async Task GetTargetRequestObjectAsync()
        {
            // Snippet: GetTargetAsync(GetTargetRequest, CallSettings)
            // Additional: GetTargetAsync(GetTargetRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetTargetRequest request = new GetTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
            };
            // Make the request
            Target response = await cloudDeployClient.GetTargetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTarget</summary>
        public void GetTarget()
        {
            // Snippet: GetTarget(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/targets/[TARGET]";
            // Make the request
            Target response = cloudDeployClient.GetTarget(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetAsync</summary>
        public async Task GetTargetAsync()
        {
            // Snippet: GetTargetAsync(string, CallSettings)
            // Additional: GetTargetAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/targets/[TARGET]";
            // Make the request
            Target response = await cloudDeployClient.GetTargetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTarget</summary>
        public void GetTargetResourceNames()
        {
            // Snippet: GetTarget(TargetName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            TargetName name = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]");
            // Make the request
            Target response = cloudDeployClient.GetTarget(name);
            // End snippet
        }

        /// <summary>Snippet for GetTargetAsync</summary>
        public async Task GetTargetResourceNamesAsync()
        {
            // Snippet: GetTargetAsync(TargetName, CallSettings)
            // Additional: GetTargetAsync(TargetName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            TargetName name = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]");
            // Make the request
            Target response = await cloudDeployClient.GetTargetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTarget</summary>
        public void CreateTargetRequestObject()
        {
            // Snippet: CreateTarget(CreateTargetRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CreateTargetRequest request = new CreateTargetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TargetId = "",
                Target = new Target(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Target, OperationMetadata> response = cloudDeployClient.CreateTarget(request);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetAsync</summary>
        public async Task CreateTargetRequestObjectAsync()
        {
            // Snippet: CreateTargetAsync(CreateTargetRequest, CallSettings)
            // Additional: CreateTargetAsync(CreateTargetRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CreateTargetRequest request = new CreateTargetRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TargetId = "",
                Target = new Target(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Target, OperationMetadata> response = await cloudDeployClient.CreateTargetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTarget</summary>
        public void CreateTarget()
        {
            // Snippet: CreateTarget(string, Target, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Target target = new Target();
            string targetId = "";
            // Make the request
            Operation<Target, OperationMetadata> response = cloudDeployClient.CreateTarget(parent, target, targetId);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetAsync</summary>
        public async Task CreateTargetAsync()
        {
            // Snippet: CreateTargetAsync(string, Target, string, CallSettings)
            // Additional: CreateTargetAsync(string, Target, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Target target = new Target();
            string targetId = "";
            // Make the request
            Operation<Target, OperationMetadata> response = await cloudDeployClient.CreateTargetAsync(parent, target, targetId);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTarget</summary>
        public void CreateTargetResourceNames()
        {
            // Snippet: CreateTarget(LocationName, Target, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Target target = new Target();
            string targetId = "";
            // Make the request
            Operation<Target, OperationMetadata> response = cloudDeployClient.CreateTarget(parent, target, targetId);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTargetAsync</summary>
        public async Task CreateTargetResourceNamesAsync()
        {
            // Snippet: CreateTargetAsync(LocationName, Target, string, CallSettings)
            // Additional: CreateTargetAsync(LocationName, Target, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Target target = new Target();
            string targetId = "";
            // Make the request
            Operation<Target, OperationMetadata> response = await cloudDeployClient.CreateTargetAsync(parent, target, targetId);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTarget</summary>
        public void UpdateTargetRequestObject()
        {
            // Snippet: UpdateTarget(UpdateTargetRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            UpdateTargetRequest request = new UpdateTargetRequest
            {
                UpdateMask = new FieldMask(),
                Target = new Target(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Target, OperationMetadata> response = cloudDeployClient.UpdateTarget(request);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetAsync</summary>
        public async Task UpdateTargetRequestObjectAsync()
        {
            // Snippet: UpdateTargetAsync(UpdateTargetRequest, CallSettings)
            // Additional: UpdateTargetAsync(UpdateTargetRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTargetRequest request = new UpdateTargetRequest
            {
                UpdateMask = new FieldMask(),
                Target = new Target(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Target, OperationMetadata> response = await cloudDeployClient.UpdateTargetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTarget</summary>
        public void UpdateTarget()
        {
            // Snippet: UpdateTarget(Target, FieldMask, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            Target target = new Target();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Target, OperationMetadata> response = cloudDeployClient.UpdateTarget(target, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTargetAsync</summary>
        public async Task UpdateTargetAsync()
        {
            // Snippet: UpdateTargetAsync(Target, FieldMask, CallSettings)
            // Additional: UpdateTargetAsync(Target, FieldMask, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            Target target = new Target();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Target, OperationMetadata> response = await cloudDeployClient.UpdateTargetAsync(target, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Target, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Target result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Target, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Target retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTarget</summary>
        public void DeleteTargetRequestObject()
        {
            // Snippet: DeleteTarget(DeleteTargetRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeleteTargetRequest request = new DeleteTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteTarget(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetAsync</summary>
        public async Task DeleteTargetRequestObjectAsync()
        {
            // Snippet: DeleteTargetAsync(DeleteTargetRequest, CallSettings)
            // Additional: DeleteTargetAsync(DeleteTargetRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTargetRequest request = new DeleteTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteTargetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTarget</summary>
        public void DeleteTarget()
        {
            // Snippet: DeleteTarget(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/targets/[TARGET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteTarget(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetAsync</summary>
        public async Task DeleteTargetAsync()
        {
            // Snippet: DeleteTargetAsync(string, CallSettings)
            // Additional: DeleteTargetAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/targets/[TARGET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteTargetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTarget</summary>
        public void DeleteTargetResourceNames()
        {
            // Snippet: DeleteTarget(TargetName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            TargetName name = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteTarget(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteTarget(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTargetAsync</summary>
        public async Task DeleteTargetResourceNamesAsync()
        {
            // Snippet: DeleteTargetAsync(TargetName, CallSettings)
            // Additional: DeleteTargetAsync(TargetName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            TargetName name = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteTargetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteTargetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetTypes</summary>
        public void ListCustomTargetTypesRequestObject()
        {
            // Snippet: ListCustomTargetTypes(ListCustomTargetTypesRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListCustomTargetTypesRequest request = new ListCustomTargetTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListCustomTargetTypesResponse, CustomTargetType> response = cloudDeployClient.ListCustomTargetTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetTypesAsync</summary>
        public async Task ListCustomTargetTypesRequestObjectAsync()
        {
            // Snippet: ListCustomTargetTypesAsync(ListCustomTargetTypesRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomTargetTypesRequest request = new ListCustomTargetTypesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetTypesResponse, CustomTargetType> response = cloudDeployClient.ListCustomTargetTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetTypes</summary>
        public void ListCustomTargetTypes()
        {
            // Snippet: ListCustomTargetTypes(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCustomTargetTypesResponse, CustomTargetType> response = cloudDeployClient.ListCustomTargetTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetTypesAsync</summary>
        public async Task ListCustomTargetTypesAsync()
        {
            // Snippet: ListCustomTargetTypesAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetTypesResponse, CustomTargetType> response = cloudDeployClient.ListCustomTargetTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetTypes</summary>
        public void ListCustomTargetTypesResourceNames()
        {
            // Snippet: ListCustomTargetTypes(LocationName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCustomTargetTypesResponse, CustomTargetType> response = cloudDeployClient.ListCustomTargetTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomTargetType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomTargetTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomTargetTypesAsync</summary>
        public async Task ListCustomTargetTypesResourceNamesAsync()
        {
            // Snippet: ListCustomTargetTypesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCustomTargetTypesResponse, CustomTargetType> response = cloudDeployClient.ListCustomTargetTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomTargetType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomTargetTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomTargetType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomTargetType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomTargetType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetType</summary>
        public void GetCustomTargetTypeRequestObject()
        {
            // Snippet: GetCustomTargetType(GetCustomTargetTypeRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetCustomTargetTypeRequest request = new GetCustomTargetTypeRequest
            {
                CustomTargetTypeName = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]"),
            };
            // Make the request
            CustomTargetType response = cloudDeployClient.GetCustomTargetType(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetTypeAsync</summary>
        public async Task GetCustomTargetTypeRequestObjectAsync()
        {
            // Snippet: GetCustomTargetTypeAsync(GetCustomTargetTypeRequest, CallSettings)
            // Additional: GetCustomTargetTypeAsync(GetCustomTargetTypeRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomTargetTypeRequest request = new GetCustomTargetTypeRequest
            {
                CustomTargetTypeName = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]"),
            };
            // Make the request
            CustomTargetType response = await cloudDeployClient.GetCustomTargetTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetType</summary>
        public void GetCustomTargetType()
        {
            // Snippet: GetCustomTargetType(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customTargetTypes/[CUSTOM_TARGET_TYPE]";
            // Make the request
            CustomTargetType response = cloudDeployClient.GetCustomTargetType(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetTypeAsync</summary>
        public async Task GetCustomTargetTypeAsync()
        {
            // Snippet: GetCustomTargetTypeAsync(string, CallSettings)
            // Additional: GetCustomTargetTypeAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customTargetTypes/[CUSTOM_TARGET_TYPE]";
            // Make the request
            CustomTargetType response = await cloudDeployClient.GetCustomTargetTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetType</summary>
        public void GetCustomTargetTypeResourceNames()
        {
            // Snippet: GetCustomTargetType(CustomTargetTypeName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CustomTargetTypeName name = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]");
            // Make the request
            CustomTargetType response = cloudDeployClient.GetCustomTargetType(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomTargetTypeAsync</summary>
        public async Task GetCustomTargetTypeResourceNamesAsync()
        {
            // Snippet: GetCustomTargetTypeAsync(CustomTargetTypeName, CallSettings)
            // Additional: GetCustomTargetTypeAsync(CustomTargetTypeName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CustomTargetTypeName name = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]");
            // Make the request
            CustomTargetType response = await cloudDeployClient.GetCustomTargetTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetType</summary>
        public void CreateCustomTargetTypeRequestObject()
        {
            // Snippet: CreateCustomTargetType(CreateCustomTargetTypeRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CreateCustomTargetTypeRequest request = new CreateCustomTargetTypeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomTargetTypeId = "",
                CustomTargetType = new CustomTargetType(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = cloudDeployClient.CreateCustomTargetType(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateCustomTargetType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetTypeAsync</summary>
        public async Task CreateCustomTargetTypeRequestObjectAsync()
        {
            // Snippet: CreateCustomTargetTypeAsync(CreateCustomTargetTypeRequest, CallSettings)
            // Additional: CreateCustomTargetTypeAsync(CreateCustomTargetTypeRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomTargetTypeRequest request = new CreateCustomTargetTypeRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomTargetTypeId = "",
                CustomTargetType = new CustomTargetType(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = await cloudDeployClient.CreateCustomTargetTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateCustomTargetTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetType</summary>
        public void CreateCustomTargetType()
        {
            // Snippet: CreateCustomTargetType(string, CustomTargetType, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomTargetType customTargetType = new CustomTargetType();
            string customTargetTypeId = "";
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = cloudDeployClient.CreateCustomTargetType(parent, customTargetType, customTargetTypeId);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateCustomTargetType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetTypeAsync</summary>
        public async Task CreateCustomTargetTypeAsync()
        {
            // Snippet: CreateCustomTargetTypeAsync(string, CustomTargetType, string, CallSettings)
            // Additional: CreateCustomTargetTypeAsync(string, CustomTargetType, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomTargetType customTargetType = new CustomTargetType();
            string customTargetTypeId = "";
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = await cloudDeployClient.CreateCustomTargetTypeAsync(parent, customTargetType, customTargetTypeId);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateCustomTargetTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetType</summary>
        public void CreateCustomTargetTypeResourceNames()
        {
            // Snippet: CreateCustomTargetType(LocationName, CustomTargetType, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CustomTargetType customTargetType = new CustomTargetType();
            string customTargetTypeId = "";
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = cloudDeployClient.CreateCustomTargetType(parent, customTargetType, customTargetTypeId);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateCustomTargetType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCustomTargetTypeAsync</summary>
        public async Task CreateCustomTargetTypeResourceNamesAsync()
        {
            // Snippet: CreateCustomTargetTypeAsync(LocationName, CustomTargetType, string, CallSettings)
            // Additional: CreateCustomTargetTypeAsync(LocationName, CustomTargetType, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CustomTargetType customTargetType = new CustomTargetType();
            string customTargetTypeId = "";
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = await cloudDeployClient.CreateCustomTargetTypeAsync(parent, customTargetType, customTargetTypeId);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateCustomTargetTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetType</summary>
        public void UpdateCustomTargetTypeRequestObject()
        {
            // Snippet: UpdateCustomTargetType(UpdateCustomTargetTypeRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            UpdateCustomTargetTypeRequest request = new UpdateCustomTargetTypeRequest
            {
                UpdateMask = new FieldMask(),
                CustomTargetType = new CustomTargetType(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = cloudDeployClient.UpdateCustomTargetType(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateCustomTargetType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetTypeAsync</summary>
        public async Task UpdateCustomTargetTypeRequestObjectAsync()
        {
            // Snippet: UpdateCustomTargetTypeAsync(UpdateCustomTargetTypeRequest, CallSettings)
            // Additional: UpdateCustomTargetTypeAsync(UpdateCustomTargetTypeRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomTargetTypeRequest request = new UpdateCustomTargetTypeRequest
            {
                UpdateMask = new FieldMask(),
                CustomTargetType = new CustomTargetType(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = await cloudDeployClient.UpdateCustomTargetTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateCustomTargetTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetType</summary>
        public void UpdateCustomTargetType()
        {
            // Snippet: UpdateCustomTargetType(CustomTargetType, FieldMask, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CustomTargetType customTargetType = new CustomTargetType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = cloudDeployClient.UpdateCustomTargetType(customTargetType, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateCustomTargetType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomTargetTypeAsync</summary>
        public async Task UpdateCustomTargetTypeAsync()
        {
            // Snippet: UpdateCustomTargetTypeAsync(CustomTargetType, FieldMask, CallSettings)
            // Additional: UpdateCustomTargetTypeAsync(CustomTargetType, FieldMask, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CustomTargetType customTargetType = new CustomTargetType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<CustomTargetType, OperationMetadata> response = await cloudDeployClient.UpdateCustomTargetTypeAsync(customTargetType, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<CustomTargetType, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CustomTargetType result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CustomTargetType, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateCustomTargetTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CustomTargetType retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomTargetType</summary>
        public void DeleteCustomTargetTypeRequestObject()
        {
            // Snippet: DeleteCustomTargetType(DeleteCustomTargetTypeRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeleteCustomTargetTypeRequest request = new DeleteCustomTargetTypeRequest
            {
                CustomTargetTypeName = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteCustomTargetType(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteCustomTargetType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomTargetTypeAsync</summary>
        public async Task DeleteCustomTargetTypeRequestObjectAsync()
        {
            // Snippet: DeleteCustomTargetTypeAsync(DeleteCustomTargetTypeRequest, CallSettings)
            // Additional: DeleteCustomTargetTypeAsync(DeleteCustomTargetTypeRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCustomTargetTypeRequest request = new DeleteCustomTargetTypeRequest
            {
                CustomTargetTypeName = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteCustomTargetTypeAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteCustomTargetTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomTargetType</summary>
        public void DeleteCustomTargetType()
        {
            // Snippet: DeleteCustomTargetType(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customTargetTypes/[CUSTOM_TARGET_TYPE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteCustomTargetType(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteCustomTargetType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomTargetTypeAsync</summary>
        public async Task DeleteCustomTargetTypeAsync()
        {
            // Snippet: DeleteCustomTargetTypeAsync(string, CallSettings)
            // Additional: DeleteCustomTargetTypeAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/customTargetTypes/[CUSTOM_TARGET_TYPE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteCustomTargetTypeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteCustomTargetTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomTargetType</summary>
        public void DeleteCustomTargetTypeResourceNames()
        {
            // Snippet: DeleteCustomTargetType(CustomTargetTypeName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CustomTargetTypeName name = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteCustomTargetType(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteCustomTargetType(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCustomTargetTypeAsync</summary>
        public async Task DeleteCustomTargetTypeResourceNamesAsync()
        {
            // Snippet: DeleteCustomTargetTypeAsync(CustomTargetTypeName, CallSettings)
            // Additional: DeleteCustomTargetTypeAsync(CustomTargetTypeName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CustomTargetTypeName name = CustomTargetTypeName.FromProjectLocationCustomTargetType("[PROJECT]", "[LOCATION]", "[CUSTOM_TARGET_TYPE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteCustomTargetTypeAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteCustomTargetTypeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleasesRequestObject()
        {
            // Snippet: ListReleases(ListReleasesRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListReleasesRequest request = new ListReleasesRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = cloudDeployClient.ListReleases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesRequestObjectAsync()
        {
            // Snippet: ListReleasesAsync(ListReleasesRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListReleasesRequest request = new ListReleasesRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = cloudDeployClient.ListReleasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleases()
        {
            // Snippet: ListReleases(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = cloudDeployClient.ListReleases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesAsync()
        {
            // Snippet: ListReleasesAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = cloudDeployClient.ListReleasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleases</summary>
        public void ListReleasesResourceNames()
        {
            // Snippet: ListReleases(DeliveryPipelineName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            PagedEnumerable<ListReleasesResponse, Release> response = cloudDeployClient.ListReleases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Release item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReleasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReleasesAsync</summary>
        public async Task ListReleasesResourceNamesAsync()
        {
            // Snippet: ListReleasesAsync(DeliveryPipelineName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            PagedAsyncEnumerable<ListReleasesResponse, Release> response = cloudDeployClient.ListReleasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Release item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReleasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Release item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Release> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Release item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetReleaseRequestObject()
        {
            // Snippet: GetRelease(GetReleaseRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            // Make the request
            Release response = cloudDeployClient.GetRelease(request);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseRequestObjectAsync()
        {
            // Snippet: GetReleaseAsync(GetReleaseRequest, CallSettings)
            // Additional: GetReleaseAsync(GetReleaseRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            // Make the request
            Release response = await cloudDeployClient.GetReleaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetRelease()
        {
            // Snippet: GetRelease(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]";
            // Make the request
            Release response = cloudDeployClient.GetRelease(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseAsync()
        {
            // Snippet: GetReleaseAsync(string, CallSettings)
            // Additional: GetReleaseAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]";
            // Make the request
            Release response = await cloudDeployClient.GetReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRelease</summary>
        public void GetReleaseResourceNames()
        {
            // Snippet: GetRelease(ReleaseName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]");
            // Make the request
            Release response = cloudDeployClient.GetRelease(name);
            // End snippet
        }

        /// <summary>Snippet for GetReleaseAsync</summary>
        public async Task GetReleaseResourceNamesAsync()
        {
            // Snippet: GetReleaseAsync(ReleaseName, CallSettings)
            // Additional: GetReleaseAsync(ReleaseName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]");
            // Make the request
            Release response = await cloudDeployClient.GetReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateReleaseRequestObject()
        {
            // Snippet: CreateRelease(CreateReleaseRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CreateReleaseRequest request = new CreateReleaseRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                ReleaseId = "",
                Release = new Release(),
                RequestId = "",
                ValidateOnly = false,
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            Operation<Release, OperationMetadata> response = cloudDeployClient.CreateRelease(request);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseRequestObjectAsync()
        {
            // Snippet: CreateReleaseAsync(CreateReleaseRequest, CallSettings)
            // Additional: CreateReleaseAsync(CreateReleaseRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CreateReleaseRequest request = new CreateReleaseRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                ReleaseId = "",
                Release = new Release(),
                RequestId = "",
                ValidateOnly = false,
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            Operation<Release, OperationMetadata> response = await cloudDeployClient.CreateReleaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateRelease()
        {
            // Snippet: CreateRelease(string, Release, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Operation<Release, OperationMetadata> response = cloudDeployClient.CreateRelease(parent, release, releaseId);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseAsync()
        {
            // Snippet: CreateReleaseAsync(string, Release, string, CallSettings)
            // Additional: CreateReleaseAsync(string, Release, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Operation<Release, OperationMetadata> response = await cloudDeployClient.CreateReleaseAsync(parent, release, releaseId);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRelease</summary>
        public void CreateReleaseResourceNames()
        {
            // Snippet: CreateRelease(DeliveryPipelineName, Release, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Operation<Release, OperationMetadata> response = cloudDeployClient.CreateRelease(parent, release, releaseId);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateRelease(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReleaseAsync</summary>
        public async Task CreateReleaseResourceNamesAsync()
        {
            // Snippet: CreateReleaseAsync(DeliveryPipelineName, Release, string, CallSettings)
            // Additional: CreateReleaseAsync(DeliveryPipelineName, Release, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            Release release = new Release();
            string releaseId = "";
            // Make the request
            Operation<Release, OperationMetadata> response = await cloudDeployClient.CreateReleaseAsync(parent, release, releaseId);

            // Poll until the returned long-running operation is complete
            Operation<Release, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Release result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Release, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateReleaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Release retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonRelease</summary>
        public void AbandonReleaseRequestObject()
        {
            // Snippet: AbandonRelease(AbandonReleaseRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            AbandonReleaseRequest request = new AbandonReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            // Make the request
            AbandonReleaseResponse response = cloudDeployClient.AbandonRelease(request);
            // End snippet
        }

        /// <summary>Snippet for AbandonReleaseAsync</summary>
        public async Task AbandonReleaseRequestObjectAsync()
        {
            // Snippet: AbandonReleaseAsync(AbandonReleaseRequest, CallSettings)
            // Additional: AbandonReleaseAsync(AbandonReleaseRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            AbandonReleaseRequest request = new AbandonReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            // Make the request
            AbandonReleaseResponse response = await cloudDeployClient.AbandonReleaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AbandonRelease</summary>
        public void AbandonRelease()
        {
            // Snippet: AbandonRelease(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]";
            // Make the request
            AbandonReleaseResponse response = cloudDeployClient.AbandonRelease(name);
            // End snippet
        }

        /// <summary>Snippet for AbandonReleaseAsync</summary>
        public async Task AbandonReleaseAsync()
        {
            // Snippet: AbandonReleaseAsync(string, CallSettings)
            // Additional: AbandonReleaseAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]";
            // Make the request
            AbandonReleaseResponse response = await cloudDeployClient.AbandonReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AbandonRelease</summary>
        public void AbandonReleaseResourceNames()
        {
            // Snippet: AbandonRelease(ReleaseName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]");
            // Make the request
            AbandonReleaseResponse response = cloudDeployClient.AbandonRelease(name);
            // End snippet
        }

        /// <summary>Snippet for AbandonReleaseAsync</summary>
        public async Task AbandonReleaseResourceNamesAsync()
        {
            // Snippet: AbandonReleaseAsync(ReleaseName, CallSettings)
            // Additional: AbandonReleaseAsync(ReleaseName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName name = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]");
            // Make the request
            AbandonReleaseResponse response = await cloudDeployClient.AbandonReleaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployPolicy</summary>
        public void CreateDeployPolicyRequestObject()
        {
            // Snippet: CreateDeployPolicy(CreateDeployPolicyRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CreateDeployPolicyRequest request = new CreateDeployPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeployPolicyId = "",
                DeployPolicy = new DeployPolicy(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = cloudDeployClient.CreateDeployPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateDeployPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeployPolicyAsync</summary>
        public async Task CreateDeployPolicyRequestObjectAsync()
        {
            // Snippet: CreateDeployPolicyAsync(CreateDeployPolicyRequest, CallSettings)
            // Additional: CreateDeployPolicyAsync(CreateDeployPolicyRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeployPolicyRequest request = new CreateDeployPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeployPolicyId = "",
                DeployPolicy = new DeployPolicy(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = await cloudDeployClient.CreateDeployPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateDeployPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeployPolicy</summary>
        public void CreateDeployPolicy()
        {
            // Snippet: CreateDeployPolicy(string, DeployPolicy, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeployPolicy deployPolicy = new DeployPolicy();
            string deployPolicyId = "";
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = cloudDeployClient.CreateDeployPolicy(parent, deployPolicy, deployPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateDeployPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeployPolicyAsync</summary>
        public async Task CreateDeployPolicyAsync()
        {
            // Snippet: CreateDeployPolicyAsync(string, DeployPolicy, string, CallSettings)
            // Additional: CreateDeployPolicyAsync(string, DeployPolicy, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DeployPolicy deployPolicy = new DeployPolicy();
            string deployPolicyId = "";
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = await cloudDeployClient.CreateDeployPolicyAsync(parent, deployPolicy, deployPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateDeployPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeployPolicy</summary>
        public void CreateDeployPolicyResourceNames()
        {
            // Snippet: CreateDeployPolicy(LocationName, DeployPolicy, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeployPolicy deployPolicy = new DeployPolicy();
            string deployPolicyId = "";
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = cloudDeployClient.CreateDeployPolicy(parent, deployPolicy, deployPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateDeployPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDeployPolicyAsync</summary>
        public async Task CreateDeployPolicyResourceNamesAsync()
        {
            // Snippet: CreateDeployPolicyAsync(LocationName, DeployPolicy, string, CallSettings)
            // Additional: CreateDeployPolicyAsync(LocationName, DeployPolicy, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DeployPolicy deployPolicy = new DeployPolicy();
            string deployPolicyId = "";
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = await cloudDeployClient.CreateDeployPolicyAsync(parent, deployPolicy, deployPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateDeployPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployPolicy</summary>
        public void UpdateDeployPolicyRequestObject()
        {
            // Snippet: UpdateDeployPolicy(UpdateDeployPolicyRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            UpdateDeployPolicyRequest request = new UpdateDeployPolicyRequest
            {
                UpdateMask = new FieldMask(),
                DeployPolicy = new DeployPolicy(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = cloudDeployClient.UpdateDeployPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateDeployPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployPolicyAsync</summary>
        public async Task UpdateDeployPolicyRequestObjectAsync()
        {
            // Snippet: UpdateDeployPolicyAsync(UpdateDeployPolicyRequest, CallSettings)
            // Additional: UpdateDeployPolicyAsync(UpdateDeployPolicyRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeployPolicyRequest request = new UpdateDeployPolicyRequest
            {
                UpdateMask = new FieldMask(),
                DeployPolicy = new DeployPolicy(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = await cloudDeployClient.UpdateDeployPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateDeployPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployPolicy</summary>
        public void UpdateDeployPolicy()
        {
            // Snippet: UpdateDeployPolicy(DeployPolicy, FieldMask, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeployPolicy deployPolicy = new DeployPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = cloudDeployClient.UpdateDeployPolicy(deployPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateDeployPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployPolicyAsync</summary>
        public async Task UpdateDeployPolicyAsync()
        {
            // Snippet: UpdateDeployPolicyAsync(DeployPolicy, FieldMask, CallSettings)
            // Additional: UpdateDeployPolicyAsync(DeployPolicy, FieldMask, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeployPolicy deployPolicy = new DeployPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DeployPolicy, OperationMetadata> response = await cloudDeployClient.UpdateDeployPolicyAsync(deployPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DeployPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployPolicy, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateDeployPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployPolicy</summary>
        public void DeleteDeployPolicyRequestObject()
        {
            // Snippet: DeleteDeployPolicy(DeleteDeployPolicyRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeleteDeployPolicyRequest request = new DeleteDeployPolicyRequest
            {
                DeployPolicyName = DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteDeployPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteDeployPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployPolicyAsync</summary>
        public async Task DeleteDeployPolicyRequestObjectAsync()
        {
            // Snippet: DeleteDeployPolicyAsync(DeleteDeployPolicyRequest, CallSettings)
            // Additional: DeleteDeployPolicyAsync(DeleteDeployPolicyRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDeployPolicyRequest request = new DeleteDeployPolicyRequest
            {
                DeployPolicyName = DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteDeployPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteDeployPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployPolicy</summary>
        public void DeleteDeployPolicy()
        {
            // Snippet: DeleteDeployPolicy(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployPolicies/[DEPLOY_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteDeployPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteDeployPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployPolicyAsync</summary>
        public async Task DeleteDeployPolicyAsync()
        {
            // Snippet: DeleteDeployPolicyAsync(string, CallSettings)
            // Additional: DeleteDeployPolicyAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployPolicies/[DEPLOY_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteDeployPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteDeployPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployPolicy</summary>
        public void DeleteDeployPolicyResourceNames()
        {
            // Snippet: DeleteDeployPolicy(DeployPolicyName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeployPolicyName name = DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteDeployPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteDeployPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDeployPolicyAsync</summary>
        public async Task DeleteDeployPolicyResourceNamesAsync()
        {
            // Snippet: DeleteDeployPolicyAsync(DeployPolicyName, CallSettings)
            // Additional: DeleteDeployPolicyAsync(DeployPolicyName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeployPolicyName name = DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteDeployPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteDeployPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDeployPolicies</summary>
        public void ListDeployPoliciesRequestObject()
        {
            // Snippet: ListDeployPolicies(ListDeployPoliciesRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListDeployPoliciesRequest request = new ListDeployPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDeployPoliciesResponse, DeployPolicy> response = cloudDeployClient.ListDeployPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeployPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeployPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployPoliciesAsync</summary>
        public async Task ListDeployPoliciesRequestObjectAsync()
        {
            // Snippet: ListDeployPoliciesAsync(ListDeployPoliciesRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListDeployPoliciesRequest request = new ListDeployPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDeployPoliciesResponse, DeployPolicy> response = cloudDeployClient.ListDeployPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeployPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeployPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployPolicies</summary>
        public void ListDeployPolicies()
        {
            // Snippet: ListDeployPolicies(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDeployPoliciesResponse, DeployPolicy> response = cloudDeployClient.ListDeployPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeployPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeployPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployPoliciesAsync</summary>
        public async Task ListDeployPoliciesAsync()
        {
            // Snippet: ListDeployPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDeployPoliciesResponse, DeployPolicy> response = cloudDeployClient.ListDeployPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeployPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeployPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployPolicies</summary>
        public void ListDeployPoliciesResourceNames()
        {
            // Snippet: ListDeployPolicies(LocationName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDeployPoliciesResponse, DeployPolicy> response = cloudDeployClient.ListDeployPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DeployPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeployPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployPoliciesAsync</summary>
        public async Task ListDeployPoliciesResourceNamesAsync()
        {
            // Snippet: ListDeployPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDeployPoliciesResponse, DeployPolicy> response = cloudDeployClient.ListDeployPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DeployPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeployPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DeployPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DeployPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DeployPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDeployPolicy</summary>
        public void GetDeployPolicyRequestObject()
        {
            // Snippet: GetDeployPolicy(GetDeployPolicyRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetDeployPolicyRequest request = new GetDeployPolicyRequest
            {
                DeployPolicyName = DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
            };
            // Make the request
            DeployPolicy response = cloudDeployClient.GetDeployPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeployPolicyAsync</summary>
        public async Task GetDeployPolicyRequestObjectAsync()
        {
            // Snippet: GetDeployPolicyAsync(GetDeployPolicyRequest, CallSettings)
            // Additional: GetDeployPolicyAsync(GetDeployPolicyRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetDeployPolicyRequest request = new GetDeployPolicyRequest
            {
                DeployPolicyName = DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
            };
            // Make the request
            DeployPolicy response = await cloudDeployClient.GetDeployPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeployPolicy</summary>
        public void GetDeployPolicy()
        {
            // Snippet: GetDeployPolicy(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployPolicies/[DEPLOY_POLICY]";
            // Make the request
            DeployPolicy response = cloudDeployClient.GetDeployPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployPolicyAsync</summary>
        public async Task GetDeployPolicyAsync()
        {
            // Snippet: GetDeployPolicyAsync(string, CallSettings)
            // Additional: GetDeployPolicyAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deployPolicies/[DEPLOY_POLICY]";
            // Make the request
            DeployPolicy response = await cloudDeployClient.GetDeployPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployPolicy</summary>
        public void GetDeployPolicyResourceNames()
        {
            // Snippet: GetDeployPolicy(DeployPolicyName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeployPolicyName name = DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]");
            // Make the request
            DeployPolicy response = cloudDeployClient.GetDeployPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployPolicyAsync</summary>
        public async Task GetDeployPolicyResourceNamesAsync()
        {
            // Snippet: GetDeployPolicyAsync(DeployPolicyName, CallSettings)
            // Additional: GetDeployPolicyAsync(DeployPolicyName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeployPolicyName name = DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]");
            // Make the request
            DeployPolicy response = await cloudDeployClient.GetDeployPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveRollout</summary>
        public void ApproveRolloutRequestObject()
        {
            // Snippet: ApproveRollout(ApproveRolloutRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ApproveRolloutRequest request = new ApproveRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Approved = false,
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            ApproveRolloutResponse response = cloudDeployClient.ApproveRollout(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveRolloutAsync</summary>
        public async Task ApproveRolloutRequestObjectAsync()
        {
            // Snippet: ApproveRolloutAsync(ApproveRolloutRequest, CallSettings)
            // Additional: ApproveRolloutAsync(ApproveRolloutRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ApproveRolloutRequest request = new ApproveRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Approved = false,
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            ApproveRolloutResponse response = await cloudDeployClient.ApproveRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveRollout</summary>
        public void ApproveRollout()
        {
            // Snippet: ApproveRollout(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            // Make the request
            ApproveRolloutResponse response = cloudDeployClient.ApproveRollout(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveRolloutAsync</summary>
        public async Task ApproveRolloutAsync()
        {
            // Snippet: ApproveRolloutAsync(string, CallSettings)
            // Additional: ApproveRolloutAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            // Make the request
            ApproveRolloutResponse response = await cloudDeployClient.ApproveRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveRollout</summary>
        public void ApproveRolloutResourceNames()
        {
            // Snippet: ApproveRollout(RolloutName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            // Make the request
            ApproveRolloutResponse response = cloudDeployClient.ApproveRollout(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveRolloutAsync</summary>
        public async Task ApproveRolloutResourceNamesAsync()
        {
            // Snippet: ApproveRolloutAsync(RolloutName, CallSettings)
            // Additional: ApproveRolloutAsync(RolloutName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            // Make the request
            ApproveRolloutResponse response = await cloudDeployClient.ApproveRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AdvanceRollout</summary>
        public void AdvanceRolloutRequestObject()
        {
            // Snippet: AdvanceRollout(AdvanceRolloutRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            AdvanceRolloutRequest request = new AdvanceRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                PhaseId = "",
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            AdvanceRolloutResponse response = cloudDeployClient.AdvanceRollout(request);
            // End snippet
        }

        /// <summary>Snippet for AdvanceRolloutAsync</summary>
        public async Task AdvanceRolloutRequestObjectAsync()
        {
            // Snippet: AdvanceRolloutAsync(AdvanceRolloutRequest, CallSettings)
            // Additional: AdvanceRolloutAsync(AdvanceRolloutRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            AdvanceRolloutRequest request = new AdvanceRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                PhaseId = "",
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            AdvanceRolloutResponse response = await cloudDeployClient.AdvanceRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AdvanceRollout</summary>
        public void AdvanceRollout()
        {
            // Snippet: AdvanceRollout(string, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            string phaseId = "";
            // Make the request
            AdvanceRolloutResponse response = cloudDeployClient.AdvanceRollout(name, phaseId);
            // End snippet
        }

        /// <summary>Snippet for AdvanceRolloutAsync</summary>
        public async Task AdvanceRolloutAsync()
        {
            // Snippet: AdvanceRolloutAsync(string, string, CallSettings)
            // Additional: AdvanceRolloutAsync(string, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            string phaseId = "";
            // Make the request
            AdvanceRolloutResponse response = await cloudDeployClient.AdvanceRolloutAsync(name, phaseId);
            // End snippet
        }

        /// <summary>Snippet for AdvanceRollout</summary>
        public void AdvanceRolloutResourceNames()
        {
            // Snippet: AdvanceRollout(RolloutName, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            string phaseId = "";
            // Make the request
            AdvanceRolloutResponse response = cloudDeployClient.AdvanceRollout(name, phaseId);
            // End snippet
        }

        /// <summary>Snippet for AdvanceRolloutAsync</summary>
        public async Task AdvanceRolloutResourceNamesAsync()
        {
            // Snippet: AdvanceRolloutAsync(RolloutName, string, CallSettings)
            // Additional: AdvanceRolloutAsync(RolloutName, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            string phaseId = "";
            // Make the request
            AdvanceRolloutResponse response = await cloudDeployClient.AdvanceRolloutAsync(name, phaseId);
            // End snippet
        }

        /// <summary>Snippet for CancelRollout</summary>
        public void CancelRolloutRequestObject()
        {
            // Snippet: CancelRollout(CancelRolloutRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CancelRolloutRequest request = new CancelRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            CancelRolloutResponse response = cloudDeployClient.CancelRollout(request);
            // End snippet
        }

        /// <summary>Snippet for CancelRolloutAsync</summary>
        public async Task CancelRolloutRequestObjectAsync()
        {
            // Snippet: CancelRolloutAsync(CancelRolloutRequest, CallSettings)
            // Additional: CancelRolloutAsync(CancelRolloutRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CancelRolloutRequest request = new CancelRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            CancelRolloutResponse response = await cloudDeployClient.CancelRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelRollout</summary>
        public void CancelRollout()
        {
            // Snippet: CancelRollout(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            // Make the request
            CancelRolloutResponse response = cloudDeployClient.CancelRollout(name);
            // End snippet
        }

        /// <summary>Snippet for CancelRolloutAsync</summary>
        public async Task CancelRolloutAsync()
        {
            // Snippet: CancelRolloutAsync(string, CallSettings)
            // Additional: CancelRolloutAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            // Make the request
            CancelRolloutResponse response = await cloudDeployClient.CancelRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelRollout</summary>
        public void CancelRolloutResourceNames()
        {
            // Snippet: CancelRollout(RolloutName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            // Make the request
            CancelRolloutResponse response = cloudDeployClient.CancelRollout(name);
            // End snippet
        }

        /// <summary>Snippet for CancelRolloutAsync</summary>
        public async Task CancelRolloutResourceNamesAsync()
        {
            // Snippet: CancelRolloutAsync(RolloutName, CallSettings)
            // Additional: CancelRolloutAsync(RolloutName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            // Make the request
            CancelRolloutResponse response = await cloudDeployClient.CancelRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRollouts</summary>
        public void ListRolloutsRequestObject()
        {
            // Snippet: ListRollouts(ListRolloutsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                ParentAsReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = cloudDeployClient.ListRollouts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsRequestObjectAsync()
        {
            // Snippet: ListRolloutsAsync(ListRolloutsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                ParentAsReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = cloudDeployClient.ListRolloutsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollouts</summary>
        public void ListRollouts()
        {
            // Snippet: ListRollouts(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]";
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = cloudDeployClient.ListRollouts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsAsync()
        {
            // Snippet: ListRolloutsAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]";
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = cloudDeployClient.ListRolloutsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollouts</summary>
        public void ListRolloutsResourceNames()
        {
            // Snippet: ListRollouts(ReleaseName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ReleaseName parent = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]");
            // Make the request
            PagedEnumerable<ListRolloutsResponse, Rollout> response = cloudDeployClient.ListRollouts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolloutsAsync</summary>
        public async Task ListRolloutsResourceNamesAsync()
        {
            // Snippet: ListRolloutsAsync(ReleaseName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName parent = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]");
            // Make the request
            PagedAsyncEnumerable<ListRolloutsResponse, Rollout> response = cloudDeployClient.ListRolloutsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRolloutRequestObject()
        {
            // Snippet: GetRollout(GetRolloutRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            // Make the request
            Rollout response = cloudDeployClient.GetRollout(request);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutRequestObjectAsync()
        {
            // Snippet: GetRolloutAsync(GetRolloutRequest, CallSettings)
            // Additional: GetRolloutAsync(GetRolloutRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            // Make the request
            Rollout response = await cloudDeployClient.GetRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRollout()
        {
            // Snippet: GetRollout(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            // Make the request
            Rollout response = cloudDeployClient.GetRollout(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutAsync()
        {
            // Snippet: GetRolloutAsync(string, CallSettings)
            // Additional: GetRolloutAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            // Make the request
            Rollout response = await cloudDeployClient.GetRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRollout</summary>
        public void GetRolloutResourceNames()
        {
            // Snippet: GetRollout(RolloutName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            // Make the request
            Rollout response = cloudDeployClient.GetRollout(name);
            // End snippet
        }

        /// <summary>Snippet for GetRolloutAsync</summary>
        public async Task GetRolloutResourceNamesAsync()
        {
            // Snippet: GetRolloutAsync(RolloutName, CallSettings)
            // Additional: GetRolloutAsync(RolloutName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName name = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            // Make the request
            Rollout response = await cloudDeployClient.GetRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRollout</summary>
        public void CreateRolloutRequestObject()
        {
            // Snippet: CreateRollout(CreateRolloutRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CreateRolloutRequest request = new CreateRolloutRequest
            {
                ParentAsReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                RolloutId = "",
                Rollout = new Rollout(),
                RequestId = "",
                ValidateOnly = false,
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
                StartingPhaseId = "",
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = cloudDeployClient.CreateRollout(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutAsync</summary>
        public async Task CreateRolloutRequestObjectAsync()
        {
            // Snippet: CreateRolloutAsync(CreateRolloutRequest, CallSettings)
            // Additional: CreateRolloutAsync(CreateRolloutRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CreateRolloutRequest request = new CreateRolloutRequest
            {
                ParentAsReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                RolloutId = "",
                Rollout = new Rollout(),
                RequestId = "",
                ValidateOnly = false,
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
                StartingPhaseId = "",
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = await cloudDeployClient.CreateRolloutAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRollout</summary>
        public void CreateRollout()
        {
            // Snippet: CreateRollout(string, Rollout, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]";
            Rollout rollout = new Rollout();
            string rolloutId = "";
            // Make the request
            Operation<Rollout, OperationMetadata> response = cloudDeployClient.CreateRollout(parent, rollout, rolloutId);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutAsync</summary>
        public async Task CreateRolloutAsync()
        {
            // Snippet: CreateRolloutAsync(string, Rollout, string, CallSettings)
            // Additional: CreateRolloutAsync(string, Rollout, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]";
            Rollout rollout = new Rollout();
            string rolloutId = "";
            // Make the request
            Operation<Rollout, OperationMetadata> response = await cloudDeployClient.CreateRolloutAsync(parent, rollout, rolloutId);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRollout</summary>
        public void CreateRolloutResourceNames()
        {
            // Snippet: CreateRollout(ReleaseName, Rollout, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ReleaseName parent = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]");
            Rollout rollout = new Rollout();
            string rolloutId = "";
            // Make the request
            Operation<Rollout, OperationMetadata> response = cloudDeployClient.CreateRollout(parent, rollout, rolloutId);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRolloutAsync</summary>
        public async Task CreateRolloutResourceNamesAsync()
        {
            // Snippet: CreateRolloutAsync(ReleaseName, Rollout, string, CallSettings)
            // Additional: CreateRolloutAsync(ReleaseName, Rollout, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ReleaseName parent = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]");
            Rollout rollout = new Rollout();
            string rolloutId = "";
            // Make the request
            Operation<Rollout, OperationMetadata> response = await cloudDeployClient.CreateRolloutAsync(parent, rollout, rolloutId);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IgnoreJob</summary>
        public void IgnoreJobRequestObject()
        {
            // Snippet: IgnoreJob(IgnoreJobRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            IgnoreJobRequest request = new IgnoreJobRequest
            {
                RolloutAsRolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                PhaseId = "",
                JobId = "",
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            IgnoreJobResponse response = cloudDeployClient.IgnoreJob(request);
            // End snippet
        }

        /// <summary>Snippet for IgnoreJobAsync</summary>
        public async Task IgnoreJobRequestObjectAsync()
        {
            // Snippet: IgnoreJobAsync(IgnoreJobRequest, CallSettings)
            // Additional: IgnoreJobAsync(IgnoreJobRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            IgnoreJobRequest request = new IgnoreJobRequest
            {
                RolloutAsRolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                PhaseId = "",
                JobId = "",
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            IgnoreJobResponse response = await cloudDeployClient.IgnoreJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for IgnoreJob</summary>
        public void IgnoreJob()
        {
            // Snippet: IgnoreJob(string, string, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string rollout = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            string phaseId = "";
            string jobId = "";
            // Make the request
            IgnoreJobResponse response = cloudDeployClient.IgnoreJob(rollout, phaseId, jobId);
            // End snippet
        }

        /// <summary>Snippet for IgnoreJobAsync</summary>
        public async Task IgnoreJobAsync()
        {
            // Snippet: IgnoreJobAsync(string, string, string, CallSettings)
            // Additional: IgnoreJobAsync(string, string, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string rollout = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            string phaseId = "";
            string jobId = "";
            // Make the request
            IgnoreJobResponse response = await cloudDeployClient.IgnoreJobAsync(rollout, phaseId, jobId);
            // End snippet
        }

        /// <summary>Snippet for IgnoreJob</summary>
        public void IgnoreJobResourceNames()
        {
            // Snippet: IgnoreJob(RolloutName, string, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RolloutName rollout = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            string phaseId = "";
            string jobId = "";
            // Make the request
            IgnoreJobResponse response = cloudDeployClient.IgnoreJob(rollout, phaseId, jobId);
            // End snippet
        }

        /// <summary>Snippet for IgnoreJobAsync</summary>
        public async Task IgnoreJobResourceNamesAsync()
        {
            // Snippet: IgnoreJobAsync(RolloutName, string, string, CallSettings)
            // Additional: IgnoreJobAsync(RolloutName, string, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName rollout = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            string phaseId = "";
            string jobId = "";
            // Make the request
            IgnoreJobResponse response = await cloudDeployClient.IgnoreJobAsync(rollout, phaseId, jobId);
            // End snippet
        }

        /// <summary>Snippet for RetryJob</summary>
        public void RetryJobRequestObject()
        {
            // Snippet: RetryJob(RetryJobRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RetryJobRequest request = new RetryJobRequest
            {
                RolloutAsRolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                PhaseId = "",
                JobId = "",
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            RetryJobResponse response = cloudDeployClient.RetryJob(request);
            // End snippet
        }

        /// <summary>Snippet for RetryJobAsync</summary>
        public async Task RetryJobRequestObjectAsync()
        {
            // Snippet: RetryJobAsync(RetryJobRequest, CallSettings)
            // Additional: RetryJobAsync(RetryJobRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RetryJobRequest request = new RetryJobRequest
            {
                RolloutAsRolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                PhaseId = "",
                JobId = "",
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            RetryJobResponse response = await cloudDeployClient.RetryJobAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RetryJob</summary>
        public void RetryJob()
        {
            // Snippet: RetryJob(string, string, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string rollout = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            string phaseId = "";
            string jobId = "";
            // Make the request
            RetryJobResponse response = cloudDeployClient.RetryJob(rollout, phaseId, jobId);
            // End snippet
        }

        /// <summary>Snippet for RetryJobAsync</summary>
        public async Task RetryJobAsync()
        {
            // Snippet: RetryJobAsync(string, string, string, CallSettings)
            // Additional: RetryJobAsync(string, string, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string rollout = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            string phaseId = "";
            string jobId = "";
            // Make the request
            RetryJobResponse response = await cloudDeployClient.RetryJobAsync(rollout, phaseId, jobId);
            // End snippet
        }

        /// <summary>Snippet for RetryJob</summary>
        public void RetryJobResourceNames()
        {
            // Snippet: RetryJob(RolloutName, string, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RolloutName rollout = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            string phaseId = "";
            string jobId = "";
            // Make the request
            RetryJobResponse response = cloudDeployClient.RetryJob(rollout, phaseId, jobId);
            // End snippet
        }

        /// <summary>Snippet for RetryJobAsync</summary>
        public async Task RetryJobResourceNamesAsync()
        {
            // Snippet: RetryJobAsync(RolloutName, string, string, CallSettings)
            // Additional: RetryJobAsync(RolloutName, string, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName rollout = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            string phaseId = "";
            string jobId = "";
            // Make the request
            RetryJobResponse response = await cloudDeployClient.RetryJobAsync(rollout, phaseId, jobId);
            // End snippet
        }

        /// <summary>Snippet for ListJobRuns</summary>
        public void ListJobRunsRequestObject()
        {
            // Snippet: ListJobRuns(ListJobRunsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListJobRunsRequest request = new ListJobRunsRequest
            {
                ParentAsRolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListJobRunsResponse, JobRun> response = cloudDeployClient.ListJobRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (JobRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobRunsAsync</summary>
        public async Task ListJobRunsRequestObjectAsync()
        {
            // Snippet: ListJobRunsAsync(ListJobRunsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListJobRunsRequest request = new ListJobRunsRequest
            {
                ParentAsRolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListJobRunsResponse, JobRun> response = cloudDeployClient.ListJobRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((JobRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobRuns</summary>
        public void ListJobRuns()
        {
            // Snippet: ListJobRuns(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            // Make the request
            PagedEnumerable<ListJobRunsResponse, JobRun> response = cloudDeployClient.ListJobRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (JobRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobRunsAsync</summary>
        public async Task ListJobRunsAsync()
        {
            // Snippet: ListJobRunsAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]";
            // Make the request
            PagedAsyncEnumerable<ListJobRunsResponse, JobRun> response = cloudDeployClient.ListJobRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((JobRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobRuns</summary>
        public void ListJobRunsResourceNames()
        {
            // Snippet: ListJobRuns(RolloutName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            RolloutName parent = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            // Make the request
            PagedEnumerable<ListJobRunsResponse, JobRun> response = cloudDeployClient.ListJobRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (JobRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListJobRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListJobRunsAsync</summary>
        public async Task ListJobRunsResourceNamesAsync()
        {
            // Snippet: ListJobRunsAsync(RolloutName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            RolloutName parent = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]");
            // Make the request
            PagedAsyncEnumerable<ListJobRunsResponse, JobRun> response = cloudDeployClient.ListJobRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((JobRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListJobRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (JobRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<JobRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (JobRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetJobRun</summary>
        public void GetJobRunRequestObject()
        {
            // Snippet: GetJobRun(GetJobRunRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetJobRunRequest request = new GetJobRunRequest
            {
                JobRunName = JobRunName.FromProjectLocationDeliveryPipelineReleaseRolloutJobRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]", "[JOB_RUN]"),
            };
            // Make the request
            JobRun response = cloudDeployClient.GetJobRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobRunAsync</summary>
        public async Task GetJobRunRequestObjectAsync()
        {
            // Snippet: GetJobRunAsync(GetJobRunRequest, CallSettings)
            // Additional: GetJobRunAsync(GetJobRunRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetJobRunRequest request = new GetJobRunRequest
            {
                JobRunName = JobRunName.FromProjectLocationDeliveryPipelineReleaseRolloutJobRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]", "[JOB_RUN]"),
            };
            // Make the request
            JobRun response = await cloudDeployClient.GetJobRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetJobRun</summary>
        public void GetJobRun()
        {
            // Snippet: GetJobRun(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]/jobRuns/[JOB_RUN]";
            // Make the request
            JobRun response = cloudDeployClient.GetJobRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobRunAsync</summary>
        public async Task GetJobRunAsync()
        {
            // Snippet: GetJobRunAsync(string, CallSettings)
            // Additional: GetJobRunAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]/jobRuns/[JOB_RUN]";
            // Make the request
            JobRun response = await cloudDeployClient.GetJobRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobRun</summary>
        public void GetJobRunResourceNames()
        {
            // Snippet: GetJobRun(JobRunName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            JobRunName name = JobRunName.FromProjectLocationDeliveryPipelineReleaseRolloutJobRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]", "[JOB_RUN]");
            // Make the request
            JobRun response = cloudDeployClient.GetJobRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetJobRunAsync</summary>
        public async Task GetJobRunResourceNamesAsync()
        {
            // Snippet: GetJobRunAsync(JobRunName, CallSettings)
            // Additional: GetJobRunAsync(JobRunName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            JobRunName name = JobRunName.FromProjectLocationDeliveryPipelineReleaseRolloutJobRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]", "[JOB_RUN]");
            // Make the request
            JobRun response = await cloudDeployClient.GetJobRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TerminateJobRun</summary>
        public void TerminateJobRunRequestObject()
        {
            // Snippet: TerminateJobRun(TerminateJobRunRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            TerminateJobRunRequest request = new TerminateJobRunRequest
            {
                JobRunName = JobRunName.FromProjectLocationDeliveryPipelineReleaseRolloutJobRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]", "[JOB_RUN]"),
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            TerminateJobRunResponse response = cloudDeployClient.TerminateJobRun(request);
            // End snippet
        }

        /// <summary>Snippet for TerminateJobRunAsync</summary>
        public async Task TerminateJobRunRequestObjectAsync()
        {
            // Snippet: TerminateJobRunAsync(TerminateJobRunRequest, CallSettings)
            // Additional: TerminateJobRunAsync(TerminateJobRunRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            TerminateJobRunRequest request = new TerminateJobRunRequest
            {
                JobRunName = JobRunName.FromProjectLocationDeliveryPipelineReleaseRolloutJobRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]", "[JOB_RUN]"),
                OverrideDeployPolicyAsDeployPolicyNames =
                {
                    DeployPolicyName.FromProjectLocationDeployPolicy("[PROJECT]", "[LOCATION]", "[DEPLOY_POLICY]"),
                },
            };
            // Make the request
            TerminateJobRunResponse response = await cloudDeployClient.TerminateJobRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TerminateJobRun</summary>
        public void TerminateJobRun()
        {
            // Snippet: TerminateJobRun(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]/jobRuns/[JOB_RUN]";
            // Make the request
            TerminateJobRunResponse response = cloudDeployClient.TerminateJobRun(name);
            // End snippet
        }

        /// <summary>Snippet for TerminateJobRunAsync</summary>
        public async Task TerminateJobRunAsync()
        {
            // Snippet: TerminateJobRunAsync(string, CallSettings)
            // Additional: TerminateJobRunAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/releases/[RELEASE]/rollouts/[ROLLOUT]/jobRuns/[JOB_RUN]";
            // Make the request
            TerminateJobRunResponse response = await cloudDeployClient.TerminateJobRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for TerminateJobRun</summary>
        public void TerminateJobRunResourceNames()
        {
            // Snippet: TerminateJobRun(JobRunName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            JobRunName name = JobRunName.FromProjectLocationDeliveryPipelineReleaseRolloutJobRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]", "[JOB_RUN]");
            // Make the request
            TerminateJobRunResponse response = cloudDeployClient.TerminateJobRun(name);
            // End snippet
        }

        /// <summary>Snippet for TerminateJobRunAsync</summary>
        public async Task TerminateJobRunResourceNamesAsync()
        {
            // Snippet: TerminateJobRunAsync(JobRunName, CallSettings)
            // Additional: TerminateJobRunAsync(JobRunName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            JobRunName name = JobRunName.FromProjectLocationDeliveryPipelineReleaseRolloutJobRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]", "[JOB_RUN]");
            // Make the request
            TerminateJobRunResponse response = await cloudDeployClient.TerminateJobRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfigRequestObject()
        {
            // Snippet: GetConfig(GetConfigRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Config response = cloudDeployClient.GetConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigRequestObjectAsync()
        {
            // Snippet: GetConfigAsync(GetConfigRequest, CallSettings)
            // Additional: GetConfigAsync(GetConfigRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Config response = await cloudDeployClient.GetConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfig()
        {
            // Snippet: GetConfig(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/config";
            // Make the request
            Config response = cloudDeployClient.GetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigAsync()
        {
            // Snippet: GetConfigAsync(string, CallSettings)
            // Additional: GetConfigAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/config";
            // Make the request
            Config response = await cloudDeployClient.GetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfig</summary>
        public void GetConfigResourceNames()
        {
            // Snippet: GetConfig(ConfigName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ConfigName name = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Config response = cloudDeployClient.GetConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetConfigAsync</summary>
        public async Task GetConfigResourceNamesAsync()
        {
            // Snippet: GetConfigAsync(ConfigName, CallSettings)
            // Additional: GetConfigAsync(ConfigName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ConfigName name = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Config response = await cloudDeployClient.GetConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAutomation</summary>
        public void CreateAutomationRequestObject()
        {
            // Snippet: CreateAutomation(CreateAutomationRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CreateAutomationRequest request = new CreateAutomationRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                AutomationId = "",
                Automation = new Automation(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Automation, OperationMetadata> response = cloudDeployClient.CreateAutomation(request);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateAutomation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutomationAsync</summary>
        public async Task CreateAutomationRequestObjectAsync()
        {
            // Snippet: CreateAutomationAsync(CreateAutomationRequest, CallSettings)
            // Additional: CreateAutomationAsync(CreateAutomationRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CreateAutomationRequest request = new CreateAutomationRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                AutomationId = "",
                Automation = new Automation(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Automation, OperationMetadata> response = await cloudDeployClient.CreateAutomationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateAutomationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutomation</summary>
        public void CreateAutomation()
        {
            // Snippet: CreateAutomation(string, Automation, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            Automation automation = new Automation();
            string automationId = "";
            // Make the request
            Operation<Automation, OperationMetadata> response = cloudDeployClient.CreateAutomation(parent, automation, automationId);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateAutomation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutomationAsync</summary>
        public async Task CreateAutomationAsync()
        {
            // Snippet: CreateAutomationAsync(string, Automation, string, CallSettings)
            // Additional: CreateAutomationAsync(string, Automation, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            Automation automation = new Automation();
            string automationId = "";
            // Make the request
            Operation<Automation, OperationMetadata> response = await cloudDeployClient.CreateAutomationAsync(parent, automation, automationId);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateAutomationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutomation</summary>
        public void CreateAutomationResourceNames()
        {
            // Snippet: CreateAutomation(DeliveryPipelineName, Automation, string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            Automation automation = new Automation();
            string automationId = "";
            // Make the request
            Operation<Automation, OperationMetadata> response = cloudDeployClient.CreateAutomation(parent, automation, automationId);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceCreateAutomation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutomationAsync</summary>
        public async Task CreateAutomationResourceNamesAsync()
        {
            // Snippet: CreateAutomationAsync(DeliveryPipelineName, Automation, string, CallSettings)
            // Additional: CreateAutomationAsync(DeliveryPipelineName, Automation, string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            Automation automation = new Automation();
            string automationId = "";
            // Make the request
            Operation<Automation, OperationMetadata> response = await cloudDeployClient.CreateAutomationAsync(parent, automation, automationId);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceCreateAutomationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutomation</summary>
        public void UpdateAutomationRequestObject()
        {
            // Snippet: UpdateAutomation(UpdateAutomationRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            UpdateAutomationRequest request = new UpdateAutomationRequest
            {
                UpdateMask = new FieldMask(),
                Automation = new Automation(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Automation, OperationMetadata> response = cloudDeployClient.UpdateAutomation(request);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateAutomation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutomationAsync</summary>
        public async Task UpdateAutomationRequestObjectAsync()
        {
            // Snippet: UpdateAutomationAsync(UpdateAutomationRequest, CallSettings)
            // Additional: UpdateAutomationAsync(UpdateAutomationRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAutomationRequest request = new UpdateAutomationRequest
            {
                UpdateMask = new FieldMask(),
                Automation = new Automation(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Automation, OperationMetadata> response = await cloudDeployClient.UpdateAutomationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateAutomationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutomation</summary>
        public void UpdateAutomation()
        {
            // Snippet: UpdateAutomation(Automation, FieldMask, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            Automation automation = new Automation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Automation, OperationMetadata> response = cloudDeployClient.UpdateAutomation(automation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceUpdateAutomation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutomationAsync</summary>
        public async Task UpdateAutomationAsync()
        {
            // Snippet: UpdateAutomationAsync(Automation, FieldMask, CallSettings)
            // Additional: UpdateAutomationAsync(Automation, FieldMask, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            Automation automation = new Automation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Automation, OperationMetadata> response = await cloudDeployClient.UpdateAutomationAsync(automation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Automation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Automation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Automation, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceUpdateAutomationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Automation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutomation</summary>
        public void DeleteAutomationRequestObject()
        {
            // Snippet: DeleteAutomation(DeleteAutomationRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeleteAutomationRequest request = new DeleteAutomationRequest
            {
                AutomationName = AutomationName.FromProjectLocationDeliveryPipelineAutomation("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteAutomation(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteAutomation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutomationAsync</summary>
        public async Task DeleteAutomationRequestObjectAsync()
        {
            // Snippet: DeleteAutomationAsync(DeleteAutomationRequest, CallSettings)
            // Additional: DeleteAutomationAsync(DeleteAutomationRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAutomationRequest request = new DeleteAutomationRequest
            {
                AutomationName = AutomationName.FromProjectLocationDeliveryPipelineAutomation("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION]"),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteAutomationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteAutomationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutomation</summary>
        public void DeleteAutomation()
        {
            // Snippet: DeleteAutomation(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/automations/[AUTOMATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteAutomation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteAutomation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutomationAsync</summary>
        public async Task DeleteAutomationAsync()
        {
            // Snippet: DeleteAutomationAsync(string, CallSettings)
            // Additional: DeleteAutomationAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/automations/[AUTOMATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteAutomationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteAutomationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutomation</summary>
        public void DeleteAutomationResourceNames()
        {
            // Snippet: DeleteAutomation(AutomationName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            AutomationName name = AutomationName.FromProjectLocationDeliveryPipelineAutomation("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudDeployClient.DeleteAutomation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudDeployClient.PollOnceDeleteAutomation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutomationAsync</summary>
        public async Task DeleteAutomationResourceNamesAsync()
        {
            // Snippet: DeleteAutomationAsync(AutomationName, CallSettings)
            // Additional: DeleteAutomationAsync(AutomationName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            AutomationName name = AutomationName.FromProjectLocationDeliveryPipelineAutomation("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudDeployClient.DeleteAutomationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudDeployClient.PollOnceDeleteAutomationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAutomation</summary>
        public void GetAutomationRequestObject()
        {
            // Snippet: GetAutomation(GetAutomationRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetAutomationRequest request = new GetAutomationRequest
            {
                AutomationName = AutomationName.FromProjectLocationDeliveryPipelineAutomation("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION]"),
            };
            // Make the request
            Automation response = cloudDeployClient.GetAutomation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutomationAsync</summary>
        public async Task GetAutomationRequestObjectAsync()
        {
            // Snippet: GetAutomationAsync(GetAutomationRequest, CallSettings)
            // Additional: GetAutomationAsync(GetAutomationRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetAutomationRequest request = new GetAutomationRequest
            {
                AutomationName = AutomationName.FromProjectLocationDeliveryPipelineAutomation("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION]"),
            };
            // Make the request
            Automation response = await cloudDeployClient.GetAutomationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutomation</summary>
        public void GetAutomation()
        {
            // Snippet: GetAutomation(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/automations/[AUTOMATION]";
            // Make the request
            Automation response = cloudDeployClient.GetAutomation(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomationAsync</summary>
        public async Task GetAutomationAsync()
        {
            // Snippet: GetAutomationAsync(string, CallSettings)
            // Additional: GetAutomationAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/automations/[AUTOMATION]";
            // Make the request
            Automation response = await cloudDeployClient.GetAutomationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomation</summary>
        public void GetAutomationResourceNames()
        {
            // Snippet: GetAutomation(AutomationName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            AutomationName name = AutomationName.FromProjectLocationDeliveryPipelineAutomation("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION]");
            // Make the request
            Automation response = cloudDeployClient.GetAutomation(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomationAsync</summary>
        public async Task GetAutomationResourceNamesAsync()
        {
            // Snippet: GetAutomationAsync(AutomationName, CallSettings)
            // Additional: GetAutomationAsync(AutomationName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            AutomationName name = AutomationName.FromProjectLocationDeliveryPipelineAutomation("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION]");
            // Make the request
            Automation response = await cloudDeployClient.GetAutomationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAutomations</summary>
        public void ListAutomationsRequestObject()
        {
            // Snippet: ListAutomations(ListAutomationsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListAutomationsRequest request = new ListAutomationsRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAutomationsResponse, Automation> response = cloudDeployClient.ListAutomations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Automation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutomationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Automation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Automation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Automation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomationsAsync</summary>
        public async Task ListAutomationsRequestObjectAsync()
        {
            // Snippet: ListAutomationsAsync(ListAutomationsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListAutomationsRequest request = new ListAutomationsRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAutomationsResponse, Automation> response = cloudDeployClient.ListAutomationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Automation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutomationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Automation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Automation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Automation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomations</summary>
        public void ListAutomations()
        {
            // Snippet: ListAutomations(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            PagedEnumerable<ListAutomationsResponse, Automation> response = cloudDeployClient.ListAutomations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Automation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutomationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Automation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Automation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Automation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomationsAsync</summary>
        public async Task ListAutomationsAsync()
        {
            // Snippet: ListAutomationsAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            PagedAsyncEnumerable<ListAutomationsResponse, Automation> response = cloudDeployClient.ListAutomationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Automation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutomationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Automation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Automation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Automation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomations</summary>
        public void ListAutomationsResourceNames()
        {
            // Snippet: ListAutomations(DeliveryPipelineName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            PagedEnumerable<ListAutomationsResponse, Automation> response = cloudDeployClient.ListAutomations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Automation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutomationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Automation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Automation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Automation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomationsAsync</summary>
        public async Task ListAutomationsResourceNamesAsync()
        {
            // Snippet: ListAutomationsAsync(DeliveryPipelineName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            PagedAsyncEnumerable<ListAutomationsResponse, Automation> response = cloudDeployClient.ListAutomationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Automation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutomationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Automation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Automation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Automation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAutomationRun</summary>
        public void GetAutomationRunRequestObject()
        {
            // Snippet: GetAutomationRun(GetAutomationRunRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            GetAutomationRunRequest request = new GetAutomationRunRequest
            {
                AutomationRunName = AutomationRunName.FromProjectLocationDeliveryPipelineAutomationRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION_RUN]"),
            };
            // Make the request
            AutomationRun response = cloudDeployClient.GetAutomationRun(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutomationRunAsync</summary>
        public async Task GetAutomationRunRequestObjectAsync()
        {
            // Snippet: GetAutomationRunAsync(GetAutomationRunRequest, CallSettings)
            // Additional: GetAutomationRunAsync(GetAutomationRunRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            GetAutomationRunRequest request = new GetAutomationRunRequest
            {
                AutomationRunName = AutomationRunName.FromProjectLocationDeliveryPipelineAutomationRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION_RUN]"),
            };
            // Make the request
            AutomationRun response = await cloudDeployClient.GetAutomationRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutomationRun</summary>
        public void GetAutomationRun()
        {
            // Snippet: GetAutomationRun(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/automationRuns/[AUTOMATION_RUN]";
            // Make the request
            AutomationRun response = cloudDeployClient.GetAutomationRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomationRunAsync</summary>
        public async Task GetAutomationRunAsync()
        {
            // Snippet: GetAutomationRunAsync(string, CallSettings)
            // Additional: GetAutomationRunAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/automationRuns/[AUTOMATION_RUN]";
            // Make the request
            AutomationRun response = await cloudDeployClient.GetAutomationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomationRun</summary>
        public void GetAutomationRunResourceNames()
        {
            // Snippet: GetAutomationRun(AutomationRunName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            AutomationRunName name = AutomationRunName.FromProjectLocationDeliveryPipelineAutomationRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION_RUN]");
            // Make the request
            AutomationRun response = cloudDeployClient.GetAutomationRun(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutomationRunAsync</summary>
        public async Task GetAutomationRunResourceNamesAsync()
        {
            // Snippet: GetAutomationRunAsync(AutomationRunName, CallSettings)
            // Additional: GetAutomationRunAsync(AutomationRunName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            AutomationRunName name = AutomationRunName.FromProjectLocationDeliveryPipelineAutomationRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION_RUN]");
            // Make the request
            AutomationRun response = await cloudDeployClient.GetAutomationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAutomationRuns</summary>
        public void ListAutomationRunsRequestObject()
        {
            // Snippet: ListAutomationRuns(ListAutomationRunsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            ListAutomationRunsRequest request = new ListAutomationRunsRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAutomationRunsResponse, AutomationRun> response = cloudDeployClient.ListAutomationRuns(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutomationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutomationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutomationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutomationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutomationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomationRunsAsync</summary>
        public async Task ListAutomationRunsRequestObjectAsync()
        {
            // Snippet: ListAutomationRunsAsync(ListAutomationRunsRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            ListAutomationRunsRequest request = new ListAutomationRunsRequest
            {
                ParentAsDeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAutomationRunsResponse, AutomationRun> response = cloudDeployClient.ListAutomationRunsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutomationRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutomationRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutomationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutomationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutomationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomationRuns</summary>
        public void ListAutomationRuns()
        {
            // Snippet: ListAutomationRuns(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            PagedEnumerable<ListAutomationRunsResponse, AutomationRun> response = cloudDeployClient.ListAutomationRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutomationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutomationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutomationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutomationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutomationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomationRunsAsync</summary>
        public async Task ListAutomationRunsAsync()
        {
            // Snippet: ListAutomationRunsAsync(string, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]";
            // Make the request
            PagedAsyncEnumerable<ListAutomationRunsResponse, AutomationRun> response = cloudDeployClient.ListAutomationRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutomationRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutomationRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutomationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutomationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutomationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomationRuns</summary>
        public void ListAutomationRunsResourceNames()
        {
            // Snippet: ListAutomationRuns(DeliveryPipelineName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            PagedEnumerable<ListAutomationRunsResponse, AutomationRun> response = cloudDeployClient.ListAutomationRuns(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutomationRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutomationRunsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutomationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutomationRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutomationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutomationRunsAsync</summary>
        public async Task ListAutomationRunsResourceNamesAsync()
        {
            // Snippet: ListAutomationRunsAsync(DeliveryPipelineName, string, int?, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            DeliveryPipelineName parent = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]");
            // Make the request
            PagedAsyncEnumerable<ListAutomationRunsResponse, AutomationRun> response = cloudDeployClient.ListAutomationRunsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutomationRun item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutomationRunsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutomationRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutomationRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutomationRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CancelAutomationRun</summary>
        public void CancelAutomationRunRequestObject()
        {
            // Snippet: CancelAutomationRun(CancelAutomationRunRequest, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            CancelAutomationRunRequest request = new CancelAutomationRunRequest
            {
                AutomationRunName = AutomationRunName.FromProjectLocationDeliveryPipelineAutomationRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION_RUN]"),
            };
            // Make the request
            CancelAutomationRunResponse response = cloudDeployClient.CancelAutomationRun(request);
            // End snippet
        }

        /// <summary>Snippet for CancelAutomationRunAsync</summary>
        public async Task CancelAutomationRunRequestObjectAsync()
        {
            // Snippet: CancelAutomationRunAsync(CancelAutomationRunRequest, CallSettings)
            // Additional: CancelAutomationRunAsync(CancelAutomationRunRequest, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            CancelAutomationRunRequest request = new CancelAutomationRunRequest
            {
                AutomationRunName = AutomationRunName.FromProjectLocationDeliveryPipelineAutomationRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION_RUN]"),
            };
            // Make the request
            CancelAutomationRunResponse response = await cloudDeployClient.CancelAutomationRunAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelAutomationRun</summary>
        public void CancelAutomationRun()
        {
            // Snippet: CancelAutomationRun(string, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/automationRuns/[AUTOMATION_RUN]";
            // Make the request
            CancelAutomationRunResponse response = cloudDeployClient.CancelAutomationRun(name);
            // End snippet
        }

        /// <summary>Snippet for CancelAutomationRunAsync</summary>
        public async Task CancelAutomationRunAsync()
        {
            // Snippet: CancelAutomationRunAsync(string, CallSettings)
            // Additional: CancelAutomationRunAsync(string, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/deliveryPipelines/[DELIVERY_PIPELINE]/automationRuns/[AUTOMATION_RUN]";
            // Make the request
            CancelAutomationRunResponse response = await cloudDeployClient.CancelAutomationRunAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CancelAutomationRun</summary>
        public void CancelAutomationRunResourceNames()
        {
            // Snippet: CancelAutomationRun(AutomationRunName, CallSettings)
            // Create client
            CloudDeployClient cloudDeployClient = CloudDeployClient.Create();
            // Initialize request argument(s)
            AutomationRunName name = AutomationRunName.FromProjectLocationDeliveryPipelineAutomationRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION_RUN]");
            // Make the request
            CancelAutomationRunResponse response = cloudDeployClient.CancelAutomationRun(name);
            // End snippet
        }

        /// <summary>Snippet for CancelAutomationRunAsync</summary>
        public async Task CancelAutomationRunResourceNamesAsync()
        {
            // Snippet: CancelAutomationRunAsync(AutomationRunName, CallSettings)
            // Additional: CancelAutomationRunAsync(AutomationRunName, CancellationToken)
            // Create client
            CloudDeployClient cloudDeployClient = await CloudDeployClient.CreateAsync();
            // Initialize request argument(s)
            AutomationRunName name = AutomationRunName.FromProjectLocationDeliveryPipelineAutomationRun("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[AUTOMATION_RUN]");
            // Make the request
            CancelAutomationRunResponse response = await cloudDeployClient.CancelAutomationRunAsync(name);
            // End snippet
        }
    }
}
