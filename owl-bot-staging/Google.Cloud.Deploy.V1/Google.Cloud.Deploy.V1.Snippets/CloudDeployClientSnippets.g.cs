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

namespace Google.Cloud.Deploy.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
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
    }
}
